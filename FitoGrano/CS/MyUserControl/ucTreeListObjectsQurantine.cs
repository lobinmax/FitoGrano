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
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ButtonsPanelControl;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;
using FitoGrano;

namespace FitoGrano
{
	
	public partial class ucTreeListObjectsQurantine
	{
		ImageCollection ImageCol = new ImageCollection(); // Коллекция иконок
		int SelectedItemId; // Текущая ветка
		string _TableName;
		string _CountryId;
		string _ProductId;
		
		List<ConditionNodeList> ndList = new List<ConditionNodeList>(); // Коллекция состояний нодов
		ConditionNodeList NodeList; // Запись для добавления в коллекцию
		string PreferenceForms; // Ветка в реестре для хранения настроек формы
		public UserControlProp UserControlProperty {get; set;}
		
		[TypeConverter(typeof(ExpandableObjectConverter))]
			public class UserControlProp
			{
			public bool _btnMultiCheckingIsVisible = true;
			public string _ColumnsNameInTreeList = "Name";
			public bool _IsCheckBoxes = true;
			public bool _IsShortForm = false;
			
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
			[Description("Вкл/выкл чекбоксы в дереве"), DefaultValue(true)]
				public bool IsCheckBoxes
				{
				get
				{
					return _IsCheckBoxes;
				}
				set
				{
					_IsCheckBoxes = value;
				}
			}
			[Description("Вкл/выкл усеченной формы. Только TreeList для выбора узлов"), DefaultValue(false)]
				public bool IsShortForm
				{
				get
				{
					return _IsShortForm;
				}
				set
				{
					_IsShortForm = value;
				}
			}
		}
		
		public ucTreeListObjectsQurantine()
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
			if (UserControlProperty._IsShortForm)
			{
				this.gcnQurantineObjects.Visible = false;
				this.tlQurantineObjects.Parent = this;
			}
			else
			{
				// загрузка наcтроек
				this.gcnQurantineObjects.CustomHeaderButtons[2].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnQurantineObjects.btnMultiCheck", System.Convert.ToString(false)));
				this.gcnQurantineObjects.CustomHeaderButtons[3].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnQurantineObjects.btnShowSearchRow", System.Convert.ToString(false)));
				this.gcnQurantineObjects.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnQurantineObjects.btnShowFilterRow", System.Convert.ToString(false)));
				this.gcnQurantineObjects.CustomHeaderButtons[2].Properties.Visible = UserControlProperty._btnMultiCheckingIsVisible;
				this.gcnQurantineObjects.CustomHeaderButtons[2].Properties.Checked = UserControlProperty._IsCheckBoxes;
				// проставить чеки недоступны без OptionsView.ShowCheckBoxes = True
				this.gcnQurantineObjects.CustomHeaderButtons[9].Properties.Enabled = this.tlQurantineObjects.OptionsView.ShowCheckBoxes;
				this.gcnQurantineObjects.CustomHeaderButtons[10].Properties.Enabled = this.tlQurantineObjects.OptionsView.ShowCheckBoxes;
			}
			// событие выгрузки родительской формы
			this.ParentForm.FormClosing += ParentForm_FormClosing;
			this.tlQurantineObjects.OptionsView.ShowCheckBoxes = UserControlProperty._IsCheckBoxes;
		}
		// выгрузка родительской формы
		private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(sender);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnMultiCheck", this.tlQurantineObjects.OptionsView.ShowCheckBoxes.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnShowSearchRow", this.tlQurantineObjects.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnQurantineObjects.btnShowFilterRow", this.tlQurantineObjects.OptionsView.ShowAutoFilterRow.ToString());
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
				foreach (TreeListNode nd in this.tlQurantineObjects.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					if (tlQurantineObjects.OptionsView.ShowCheckBoxes)
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
					if (tlQurantineObjects.OptionsView.ShowCheckBoxes)
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
		/// <param name="CountryId">Если NULL, выгружается вся продукция, иначе по стране</param>
		/// <param name="ProductId">Если NULL, выгружается вся продукция, иначе по продукция</param>
		public void LoadTreeList(string TableName = null, string CountryId = "NULL", string ProductId = "NULL")
			{
			if (ReferenceEquals(TableName, null))
			{
				TableName = "ObjectsQurantine." + ParentForm.Name;
			}
			
			_TableName = TableName;
			_CountryId = CountryId;
			_ProductId = ProductId;
			// загружаем изображения в коллекцию
			if (this.tlQurantineObjects.Nodes.Count != 0)
			{
				Filling_ndList();
			}
			mdVariables.EventChangedControl = false;
			
			ImageCol.Clear();
			ImageCol.AddImage(global::My.Resources.Resources.microscope_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.bakterii_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.virus_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.gribi16x16);
			ImageCol.AddImage(global::My.Resources.Resources.cleshi_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.molliuski_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.nasekomye_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.nematody_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.sorniaki_16x16);
			mdQuery.SelectQueryData(
				TableName,
				"EXEC GetTreeListObjectsQurantine " +
				"@CountryId = " + CountryId + ", " +
				"@ProductId = " + ProductId,
				"Class.GetObjectsQurantine"
				);
			
			if (ReferenceEquals(this.tlQurantineObjects.DataSource, null))
			{
				this.tlQurantineObjects.ClearNodes();
				this.tlQurantineObjects.DataSource = mdQuery.iDataSet.Tables[TableName];
				this.tlQurantineObjects.ParentFieldName = "ParentId";
				this.tlQurantineObjects.KeyFieldName = "Id";
				this.tlQurantineObjects.BestFitColumns(true);
				this.tlQurantineObjects.StateImageList = ImageCol;
				mdHidenAllColumns.HidenAllColumns_TreeList(this.tlQurantineObjects);
				// если столбец существует, показываем его
				if (!ReferenceEquals(this.tlQurantineObjects.Columns[UserControlProperty.ColumnsNameInTreeList], null))
				{
					this.tlQurantineObjects.Columns[UserControlProperty.ColumnsNameInTreeList].Visible = true;
				}
			}
			mdVariables.EventChangedControl = true;
			// всем нодам присваиваем иконку
			foreach (TreeListNode nd in this.tlQurantineObjects.Nodes)
			{
				FillSelectImageIndex(nd);
				SettingsNode(nd);
			}
			// извлечение из коллекций состояний нодов
			foreach (var n in ndList)
			{
				if (this.tlQurantineObjects.FindNodeByKeyID(n.Id) != null)
				{
					this.tlQurantineObjects.FindNodeByKeyID(n.Id).Expanded = System.Convert.ToBoolean(n.Expanded);
					this.tlQurantineObjects.FindNodeByKeyID(n.Id).Checked = System.Convert.ToBoolean(n.Checked);
				}
			}
			this.tlQurantineObjects.FocusedNode = this.tlQurantineObjects.FindNodeByKeyID(SelectedItemId);
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
			nd.StateImageIndex = nd["IconIndex"];
		}
		
		// запоминаем активный элемент
		public void tlClassification_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			if (ReferenceEquals(e.Node, null) || mdVariables.EventChangedControl == false)
			{
				return;
			}
			SelectedItemId = System.Convert.ToInt32(e.Node["Id"]);
		}
		
		// группа Кнопок
		public void gcnClassification_CustomButtonClick(object sender, BaseButtonEventArgs e)
		{
			GroupBoxButton btn = e.Button;
			switch (btn.VisibleIndex)
			{
				case 0: // btnEditCheckingProducts
					if (frAddEditQuarantineProducts.Default.ShowDialog() == DialogResult.OK)
					{
						UpdateTreeList();
					}
					break;
					
				case 2: // btnMultiCheck
					this.tlQurantineObjects.OptionsView.ShowCheckBoxes = btn.Checked;
					this.gcnQurantineObjects.CustomHeaderButtons[9].Properties.Enabled = btn.Checked;
					this.gcnQurantineObjects.CustomHeaderButtons[10].Properties.Enabled = btn.Checked;
					break;
					
				case 3: // btnShowSearchRow
					this.tlQurantineObjects.OptionsFind.AlwaysVisible = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlQurantineObjects.FindFilterText = null; // при отключении очищаем фильтрацию
					}
					break;
					
				case 4: // btnShowFilterRow
					this.tlQurantineObjects.OptionsView.ShowAutoFilterRow = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlQurantineObjects.ClearColumnsFilter(); // при отключении очищаем фильтрацию
					}
					break;
					
				case 6: // btnExpandedAll
					this.tlQurantineObjects.ExpandAll();
					break;
					
				case 7: // btnCollapsedAll
					this.tlQurantineObjects.CollapseAll();
					break;
					
				case 9: // btnCheckAll
					if (IsMultiChecked())
					{
						this.tlQurantineObjects.CheckAll();
					}
					break;
					
				case 10: // btnUncheckAll
					if (IsMultiChecked())
					{
						this.tlQurantineObjects.UncheckAll();
					}
					break;
					
				case 12: // btnEditBooks
					DialogResult dr;
					dr = XtraMessageBox.Show("Редактирование справочной информации:" + "\n" +
						"<b>Да</b> - Справочник Направления исследований" + "\n" +
						"<b>Нет</b> - Справочник Объекты исследований",
						Application.ProductName,
						MessageBoxButtons.YesNoCancel,
						MessageBoxIcon.Question,
						DefaultBoolean.True);
					if (dr == DialogResult.Yes)
					{
						frBooks_ResearchDirection.Default.ShowDialog();
					}
					if (dr == DialogResult.No)
					{
						frBooks_ResearchObjects.Default.ShowDialog();
					}
					UpdateTreeList();
					break;
				case 13: // btnUpdate
					UpdateTreeList();
					break;
			}
		}
#region Функции
		/// <summary>
		/// Ид активного узла
		/// </summary>
		public string GetFocusedId()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlQurantineObjects.FocusedNode["Id"]);
		}
		
		/// <summary>
		/// Уровень активного узла
		/// </summary>
		public int GetFocusedLevel()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return 0;
			}
			return System.Convert.ToInt32(this.tlQurantineObjects.FocusedNode["Level"]);
		}
		
		/// <summary>
		/// Ид активной классификации
		/// </summary>
		public string GetFocusedClassificationId()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlQurantineObjects.FocusedNode["ClassificationId"]);
		}
		
		/// <summary>
		/// Ид активной продукции
		/// </summary>
		public string GetFocusedProductId()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlQurantineObjects.FocusedNode["ProductId"]);
		}
		
		/// <summary>
		/// Имя активной классификации
		/// </summary>
		public string GetFocusedClassificationName()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlQurantineObjects.FocusedNode["ClassificationName"]);
		}
		
		/// <summary>
		/// Имя активной подукции
		/// </summary>
		public string GetFocusedProductName()
		{
			if (ReferenceEquals(this.tlQurantineObjects.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlQurantineObjects.FocusedNode["ProductName"]);
		}
		
		/// <summary>
		/// Мультистрока Ид классификаций
		/// </summary>
		public string GetMultiStringClassificationId()
		{
			TreeList sender = this.tlQurantineObjects; // TreeList
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
					MultiString += sep + System.Convert.ToString(n["ClassificationId"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока Ид продукций
		/// </summary>
		public string GetMultiStringProductId()
		{
			TreeList sender = this.tlQurantineObjects; // TreeList
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
					MultiString += sep + System.Convert.ToString(n["ProductId"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока имен классификаций
		/// </summary>
		public string GetMultiStringClassificationName()
		{
			TreeList sender = this.tlQurantineObjects; // TreeList
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
					MultiString += sep + System.Convert.ToString(n["ClassificationName"]);
					sep = ",";
				}
			}
			return "'" + MultiString.Replace("NULL", "") + "'".Replace("''", "NULL");
		}
		
		/// <summary>
		/// Мультистрока имен продукций
		/// </summary>
		public string GetMultiStringProductName()
		{
			TreeList sender = this.tlQurantineObjects; // TreeList
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
					MultiString += sep + System.Convert.ToString(n["ProductName"]);
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
			return this.tlQurantineObjects.OptionsView.ShowCheckBoxes;
		}
		
		/// <summary>
		/// Задать чеки по объекту из базы
		/// </summary>
		/// <param name="CountryId">Ид страны</param>>
		/// <returns></returns>
		public bool SetMultiCheckedProductId(string CountryId)
		{
			//Dim checkEdit As DevExpress.XtraEditors.CheckEdit
			//SelectQueryData("CheckedProductsId." & ParentForm.Name,
			//                "SELECT ClassificationId, ProductId FROM vBooks_CountriesProducts WHERE CountryId = " & CountryId,
			//                "SetMultiCheckedProductId")
			//For Each r As System.Data.DataRow In iDataSet.Tables("CheckedProductsId." & ParentForm.Name).Rows
			//    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ClassificationId"), Integer)).Checked = True
			//    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ClassificationId"), Integer)).Expand()
			//    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ProductId"), Integer)).Checked = True
			//    Me.tlQurantineProducts.FindNodeByKeyID(CType(r("ProductId"), Integer)).ParentNode.Expand()
			//Next
		}
		
		/// <summary>
		/// Обновление с текущими параметрами
		/// </summary>
		public void UpdateTreeList()
		{
			mdVariables.tmWaitAnimation.StartWaitingIndicator(this.tlQurantineObjects, 0);
			LoadTreeList(_TableName, _CountryId, _ProductId);
			mdVariables.tmWaitAnimation.StopWaitingIndicator();
		}
		
		/// <summary>
		/// Задать Caption для дерева
		/// </summary>
		/// ''' <param name="iValue">Строка значения для Caption</param>>
		public void SetCaptionTreeList(string iValue)
		{
			this.tlQurantineObjects.Caption = System.Convert.ToString(iValue);
		}
		
		/// <summary>
		/// Очистить DataSet привязанный к TreeListView
		/// </summary>
		public void ClearDataSet()
		{
			if (mdQuery.iDataSet.Tables.Contains(_TableName))
			{
				mdQuery.iDataSet.Tables[_TableName].Clear();
			}
		}
#endregion
	}
	
}
