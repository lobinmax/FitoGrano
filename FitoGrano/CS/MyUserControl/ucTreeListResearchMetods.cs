// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using Microsoft.VisualBasic;
using System.Xml.Linq;
using System.Windows.Forms;
// End of VB project level imports

using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class ucTreeListResearchMetods
	{
		ImageCollection ImageCol = new ImageCollection(); // Коллекция иконок
		int SelectedItemId; // Текущая ветка
		string _TableName;
		string _IsExpDirection;
		List<ConditionNodeList> ndList = new List<ConditionNodeList>(); // Коллекция состояний нодов
		ConditionNodeList NodeList; // Запись для добавления в коллекцию
		string PreferenceForms; // Ветка в реестре для хранения настроек формы
		public UserControlProp UserControlProperty {get; set;}
		
		[TypeConverter(typeof(ExpandableObjectConverter))]
			public class UserControlProp
			{
			public bool _btnMultiCheckingIsVisible = true;
			public string _ColumnsNameInTreeList = "Name";
			public bool _tlMethodsViewCheckBoxes = true;
			
			[Description("Имя отбражаемого столбца"), DefaultValue("Name")]
				public string ColumnsNameInTreeList
				{
				get
				{
					if (ReferenceEquals(_ColumnsNameInTreeList, null))
					{
						return "Name";
					}
					else
					{
						return _ColumnsNameInTreeList;
					}
				}
				set
				{
					if (ReferenceEquals(value, null))
					{
						_ColumnsNameInTreeList = "Name";
					}
					else
					{
						_ColumnsNameInTreeList = value;
					}
				}
			}
			[Description("Видимость кнопки мультивыбор"), DefaultValue(true)]
				public bool btnMultiCheckingIsVisible
				{
				get
				{
					return _btnMultiCheckingIsVisible;
				}
				set
				{
					_btnMultiCheckingIsVisible = value;
				}
			}
			[Description("Вкл/выкл чекбоксы в дереве направлений"), DefaultValue(true)]
				public bool tlMethodsViewCheckBoxes
				{
				get
				{
					return _tlMethodsViewCheckBoxes;
				}
				set
				{
					_tlMethodsViewCheckBoxes = value;
				}
			}
		}
		
		public ucTreeListResearchMetods()
		{
			// Этот вызов является обязательным для конструктора.
			InitializeComponent();
			
			// Добавить код инициализации после вызова InitializeComponent().
			UserControlProperty = new UserControlProp(); // подключаем дополнительные свойства
		}
		// коллекции состяния нодов
		public struct ConditionNodeList
		{
			public int Id; // Ид нода
			public bool Expanded; // Состояноие нода
			public bool Checked; // Чек нода
		}
		
		// загрузка контрола
		public void ucTreeListResearchMetods_Load(object sender, EventArgs e)
		{
			PreferenceForms = mdVariables.pref_UserSettings + this.ParentForm.Name + "\\";
			// загрузка наcтроек
			this.gcnMethods.CustomHeaderButtons[0].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnMethods.btnMultiCheck", System.Convert.ToString(false)));
			this.gcnMethods.CustomHeaderButtons[1].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnMethods.btnShowSearchRow", System.Convert.ToString(false)));
			this.gcnMethods.CustomHeaderButtons[2].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnMethods.btnShowFilterRow", System.Convert.ToString(false)));
			// событие выгрузки родительской формы
			this.ParentForm.FormClosing += ParentForm_FormClosing;
			this.gcnMethods.CustomHeaderButtons[0].Properties.Visible = UserControlProperty._btnMultiCheckingIsVisible;
			this.tlMethods.OptionsView.ShowCheckBoxes = UserControlProperty._tlMethodsViewCheckBoxes;
			this.gcnMethods.CustomHeaderButtons[0].Properties.Checked = UserControlProperty._tlMethodsViewCheckBoxes;
		}
		// выгрузка родительской формы
		private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(sender);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnMethods.btnMultiCheck", this.tlMethods.OptionsView.ShowCheckBoxes.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnMethods.btnShowSearchRow", this.tlMethods.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnMethods.btnShowFilterRow", this.tlMethods.OptionsView.ShowAutoFilterRow.ToString());
		}
		
		// Заполняем коллекцию при первом запуске и извлекаем при последующих
		private void Filling_ndList(TreeListNode node = null, bool IsFirstRun = true)
			{
			if (IsFirstRun)
			{
				ndList.Clear();
			}
			if (IsFirstRun == true) // Первый запуск
			{
				foreach (TreeListNode nd in this.tlMethods.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					if (tlMethods.OptionsView.ShowCheckBoxes)
					{
						NodeList.Checked = nd.Checked;
					}
					ndList.Add(NodeList);
					if (nd.HasChildren)
					{
						Filling_ndList(nd, false);
					}
				}
			} // рекурсия
			else
			{
				foreach (TreeListNode nd in node.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					if (tlMethods.OptionsView.ShowCheckBoxes)
					{
						NodeList.Checked = nd.Checked;
					}
					ndList.Add(NodeList);
					if (nd.HasChildren)
					{
						Filling_ndList(nd, false);
					}
				}
			}
		}
		
		/// <summary>Загрузка списка контролеров из базы данных</summary>
		/// <param name="TableName">Имя таблицы для загрузки данных</param>
		/// <param name="IsExpDirection">Развернуть узлы направлений</param>
		public void LoadMethodList(string TableName = null, bool IsExpDirection = true)
			{
			if (ReferenceEquals(TableName, null))
			{
				TableName = "ResearchMethods." + ParentForm.Name;
			}
			
			_TableName = TableName;
			_IsExpDirection = System.Convert.ToString(IsExpDirection);
			// загружаем изображения в коллекцию
			if (this.tlMethods.Nodes.Count != 0)
			{
				Filling_ndList();
			}
			mdVariables.EventChangedControl = false;
			
			ImageCol.Clear();
			ImageCol.AddImage(global::My.Resources.Resources.directions_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.microscope_16x16);
			mdQuery.SelectQueryData(
				TableName,
				"EXEC GetTreeListResearchMethods " +
				"@IsExpDirection = " + System.Convert.ToString(Convert.ToInt16(IsExpDirection)),
				"Class.GetResearchMethods"
				);
			
			if (ReferenceEquals(this.tlMethods.DataSource, null))
			{
				this.tlMethods.ClearNodes();
				this.tlMethods.DataSource = mdQuery.iDataSet.Tables[TableName];
				this.tlMethods.ParentFieldName = "ParentId";
				this.tlMethods.KeyFieldName = "Id";
				this.tlMethods.BestFitColumns(true);
				this.tlMethods.StateImageList = ImageCol;
				mdHidenAllColumns.HidenAllColumns_TreeList(this.tlMethods);
				// если столбец существует, показываем его
				if (!ReferenceEquals(this.tlMethods.Columns[UserControlProperty.ColumnsNameInTreeList], null))
				{
					this.tlMethods.Columns[UserControlProperty.ColumnsNameInTreeList].Visible = true;
				}
			}
			mdVariables.EventChangedControl = true;
			// всем нодам присваиваем иконку
			foreach (TreeListNode nd in this.tlMethods.Nodes)
			{
				FillSelectImageIndex(nd);
				SettingsNode(nd);
			}
			// извлечение из коллекций состояний нодов
			foreach (var n in ndList)
			{
				if (this.tlMethods.FindNodeByKeyID(n.Id) != null)
				{
					this.tlMethods.FindNodeByKeyID(n.Id).Expanded = System.Convert.ToBoolean(n.Expanded);
					this.tlMethods.FindNodeByKeyID(n.Id).Checked = System.Convert.ToBoolean(n.Checked);
				}
			}
			this.tlMethods.FocusedNode = this.tlMethods.FindNodeByKeyID(SelectedItemId);
		}
		// цикл по всем дочерним узлам
		private void FillSelectImageIndex(TreeListNode ParentNode)
		{
			foreach (TreeListNode nd in ParentNode.Nodes)
			{
				FillSelectImageIndex(nd);
				SettingsNode(nd);
			}
		}
		private void SettingsNode(TreeListNode nd)
		{
			nd.Expanded = nd["IsExpanded"];
			nd.StateImageIndex = nd.Level;
		}
		
		// запоминаем активный элемент
		public void tlMethods_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			if (ReferenceEquals(e.Node, null) || mdVariables.EventChangedControl == false)
			{
				return;
			}
			SelectedItemId = System.Convert.ToInt32(e.Node["Id"]);
		}
		
		// группа Кнопок
		public void gcnMethods_CustomButtonClick(object sender, BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 0: // btnMultiCheck
					this.tlMethods.OptionsView.ShowCheckBoxes = btn.Checked;
					break;
					
				case 1: // btnShowSearchRow
					this.tlMethods.OptionsFind.AlwaysVisible = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlMethods.FindFilterText = null; // при отключении очищаем фильтрацию
					}
					break;
					
				case 2: // btnShowFilterRow
					this.tlMethods.OptionsView.ShowAutoFilterRow = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlMethods.ClearColumnsFilter(); // при отключении очищаем фильтрацию
					}
					break;
					
				case 4: // btnExpandedAll
					this.tlMethods.ExpandAll();
					break;
					
				case 5: // btnCollapsedAll
					this.tlMethods.CollapseAll();
					break;
					
				case 7: // btnCheckAll
					if (IsMultiChecked())
					{
						this.tlMethods.CheckAll();
					}
					break;
					
				case 8: // btnUncheckAll
					if (IsMultiChecked())
					{
						this.tlMethods.UncheckAll();
					}
					break;
					
				case 10: // btnEditBooks
					frBooks_ResearchDirection.Default.ShowDialog();
					mdVariables.tmWaitAnimation.StartWaitingIndicator(this.tlMethods, 0);
					LoadMethodList(_TableName, bool.Parse(_IsExpDirection));
					mdVariables.tmWaitAnimation.StopWaitingIndicator();
					break;
				case 11: // btnUpdate
					mdVariables.tmWaitAnimation.StartWaitingIndicator(this.tlMethods, 0);
					LoadMethodList(_TableName, bool.Parse(_IsExpDirection));
					mdVariables.tmWaitAnimation.StopWaitingIndicator();
					break;
			}
		}
#region Функции
		
		/// <summary>
		/// Ид активного узла
		/// </summary>
		public string GetFocusedId()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlMethods.FocusedNode["Id"]);
		}
		
		/// <summary>
		/// Уровень активного узла
		/// </summary>
		public int GetFocusedLevel()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return 0;
			}
			return System.Convert.ToInt32(this.tlMethods.FocusedNode["Level"]);
		}
		
		/// <summary>
		/// Ид активного направления
		/// </summary>
		public string GetFocusedDirectionId()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlMethods.FocusedNode["DirectionId"]);
		}
		
		/// <summary>
		/// Ид активного метода
		/// </summary>
		public string GetFocusedMethodId()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlMethods.FocusedNode["MethodId"]);
		}
		
		/// <summary>
		/// Имя активного направления
		/// </summary>
		public string GetFocusedDirectionName()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlMethods.FocusedNode["DirectionName"]);
		}
		
		/// <summary>
		/// Имя активного метода
		/// </summary>
		public string GetFocusedMethodName()
		{
			if (ReferenceEquals(this.tlMethods.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlMethods.FocusedNode["MethodName"]);
		}
		
		/// <summary>
		/// Мультистрока Ид направлений
		/// </summary>
		public string GetMultiStringDirectionId()
		{
			TreeList sender = this.tlMethods; // TreeList
			TreeListNode nd = sender.FocusedNode; // Активный узел
			string sep = ""; // разделитель для мультистроки
			string MultiString = ""; // Строка накопитель
			if (ReferenceEquals(nd, null) || sender.OptionsView.ShowCheckBoxes == false)
			{
				return "NULL";
			}
			// собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
			if (sender.GetAllCheckedNodes().Count == 0)
			{
				return "NULL";
			}
			foreach (TreeListNode n in sender.GetAllCheckedNodes())
			{
				// среди контролеров
				if ((int) n["Level"] == 0)
				{
					MultiString += sep + System.Convert.ToString(n["DirectionId"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока Ид методов
		/// </summary>
		public string GetMultiStringMethodId()
		{
			TreeList sender = this.tlMethods; // TreeList
			TreeListNode nd = sender.FocusedNode; // Активный узел
			string sep = ""; // разделитель для мультистроки
			string MultiString = ""; // Строка накопитель
			if (ReferenceEquals(nd, null) || sender.OptionsView.ShowCheckBoxes == false)
			{
				return "NULL";
			}
			// собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
			if (sender.GetAllCheckedNodes().Count == 0)
			{
				return "NULL";
			}
			foreach (TreeListNode n in sender.GetAllCheckedNodes())
			{
				// среди контролеров
				if ((int) n["Level"] == 1)
				{
					MultiString += sep + System.Convert.ToString(n["MethodId"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока имен направлений
		/// </summary>
		public string GetMultiStringDirectionName()
		{
			TreeList sender = this.tlMethods; // TreeList
			TreeListNode nd = sender.FocusedNode; // Активный узел
			string sep = ""; // разделитель для мультистроки
			string MultiString = ""; // Строка накопитель
			if (ReferenceEquals(nd, null) || sender.OptionsView.ShowCheckBoxes == false)
			{
				return "NULL";
			}
			// собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
			if (sender.GetAllCheckedNodes().Count == 0 || sender.Nodes[0].Checked)
			{
				return "NULL";
			}
			foreach (TreeListNode n in sender.GetAllCheckedNodes())
			{
				// среди контролеров
				if ((int) n["Level"] == 0)
				{
					MultiString += sep + System.Convert.ToString(n["DirectionName"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока имен методов
		/// </summary>
		public string GetMultiStringMethodName()
		{
			TreeList sender = this.tlMethods; // TreeList
			TreeListNode nd = sender.FocusedNode; // Активный узел
			string sep = ""; // разделитель для мультистроки
			string MultiString = ""; // Строка накопитель
			if (ReferenceEquals(nd, null) || sender.OptionsView.ShowCheckBoxes == false)
			{
				return "NULL";
			}
			// собираем чекнутые строки если они есть или если чекнут Root значит фильтра нет
			if (sender.GetAllCheckedNodes().Count == 0 || sender.Nodes[0].Checked)
			{
				return "NULL";
			}
			foreach (TreeListNode n in sender.GetAllCheckedNodes())
			{
				// среди контролеров
				if ((int) n["Level"] == 1)
				{
					MultiString += sep + System.Convert.ToString(n["MethodName"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Активность мультивыбора
		/// </summary>
		/// <returns></returns>
		public bool IsMultiChecked()
		{
			return this.tlMethods.OptionsView.ShowCheckBoxes;
		}
		
		/// <summary>
		/// Задать чеки по объекту из базы
		/// </summary>
		/// <param name="ObjectId">Ид объекта исследования</param>>
		/// <returns></returns>
		public bool SetMultiCheckedObjectId(string ObjectId)
		{
			DevExpress.XtraEditors.CheckEdit checkEdit;
			mdQuery.SelectQueryData("CheckedObjectId." + ParentForm.Name,
				"SELECT DirectionId, MethodId FROM vBooks_Objects WHERE Id = " + ObjectId,
				"SetMultiCheckedObjectId");
			foreach (System.Data.DataRow r in mdQuery.iDataSet.Tables["CheckedObjectId." + ParentForm.Name].Rows)
			{
				this.tlMethods.FindNodeByKeyID(System.Convert.ToInt32(r["DirectionId"])).Checked = true;
				this.tlMethods.FindNodeByKeyID(System.Convert.ToInt32(r["DirectionId"])).Expand();
				this.tlMethods.FindNodeByKeyID(System.Convert.ToInt32(r["MethodId"])).Checked = true;
				this.tlMethods.FindNodeByKeyID(System.Convert.ToInt32(r["MethodId"])).ParentNode.Expand();
			}
		}
#endregion
	}
	
}
