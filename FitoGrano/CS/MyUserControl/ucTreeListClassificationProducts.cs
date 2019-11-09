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
	
	public partial class ucTreeListClassificationProducts
	{
		ImageCollection ImageCol = new ImageCollection(); // Коллекция иконок
		int SelectedItemId; // Текущая ветка
		string _TableName;
		string _CountryId;
		bool _IsExpClassification;
		bool _ShowCountProducts;
		string _FilterParametr;
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
		
		public ucTreeListClassificationProducts()
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
				this.gcnClassification.Visible = false;
				this.tlClassification.Parent = this;
			}
			else
			{
				// загрузка наcтроек
				this.gcnClassification.CustomHeaderButtons[2].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnClassification.btnMultiCheck", System.Convert.ToString(false)));
				this.gcnClassification.CustomHeaderButtons[3].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnClassification.btnShowSearchRow", System.Convert.ToString(false)));
				this.gcnClassification.CustomHeaderButtons[4].Properties.Checked = System.Convert.ToBoolean(mdRegistrySetting.RegistryRead(PreferenceForms, "gcnClassification.btnShowFilterRow", System.Convert.ToString(false)));
				this.gcnClassification.CustomHeaderButtons[2].Properties.Visible = UserControlProperty._btnMultiCheckingIsVisible;
				this.gcnClassification.CustomHeaderButtons[2].Properties.Checked = UserControlProperty._IsCheckBoxes;
				// проставить чеки недоступны без OptionsView.ShowCheckBoxes = True
				this.gcnClassification.CustomHeaderButtons[9].Properties.Enabled = this.tlClassification.OptionsView.ShowCheckBoxes;
				this.gcnClassification.CustomHeaderButtons[10].Properties.Enabled = this.tlClassification.OptionsView.ShowCheckBoxes;
			}
			// событие выгрузки родительской формы
			this.ParentForm.FormClosing += ParentForm_FormClosing;
			this.tlClassification.OptionsView.ShowCheckBoxes = UserControlProperty._IsCheckBoxes;
		}
		// выгрузка родительской формы
		private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			clsMyUserFunction.RemoveTableDataSet(sender);
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnClassification.btnMultiCheck", this.tlClassification.OptionsView.ShowCheckBoxes.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnClassification.btnShowSearchRow", this.tlClassification.OptionsFind.AlwaysVisible.ToString());
			mdRegistrySetting.RegistryWrite(PreferenceForms, "gcnClassification.btnShowFilterRow", this.tlClassification.OptionsView.ShowAutoFilterRow.ToString());
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
				foreach (TreeListNode nd in this.tlClassification.Nodes)
				{
					NodeList.Id = System.Convert.ToInt32(nd["Id"]);
					NodeList.Expanded = nd.Expanded;
					if (tlClassification.OptionsView.ShowCheckBoxes)
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
					if (tlClassification.OptionsView.ShowCheckBoxes)
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
		/// <param name="CountryId">Если NULL, выгружается вся классификация, иначе по стране</param>
		/// <param name="IsExpClassification">Развернуть узлы направлений</param>
		/// <param name="ShowCountProducts">Показывать кол-во продукций у классификации</param>
		public void LoadTreeList(string TableName = null, string CountryId = "NULL", bool IsExpClassification = true, bool ShowCountProducts = false, string FilterParametr = "NULL")
			{
			if (ReferenceEquals(TableName, null))
			{
				TableName = "Classification." + ParentForm.Name;
			}
			
			_TableName = TableName;
			_CountryId = CountryId;
			_IsExpClassification = IsExpClassification;
			_ShowCountProducts = ShowCountProducts;
			_FilterParametr = FilterParametr;
			// загружаем изображения в коллекцию
			if (this.tlClassification.Nodes.Count != 0)
			{
				Filling_ndList();
			}
			mdVariables.EventChangedControl = false;
			
			ImageCol.Clear();
			ImageCol.AddImage(global::My.Resources.Resources.directions_16x16);
			ImageCol.AddImage(global::My.Resources.Resources.ClassificationProducts_16x16);
			mdQuery.SelectQueryData(
				TableName,
				"EXEC GetTreeListClassificationProducts " +
				"@CountryId = " + CountryId + ", " +
				"@IsExpClassification = " + System.Convert.ToString(Convert.ToInt16(IsExpClassification)) + ", " +
				"@ShowCountProducts = " + System.Convert.ToString(Convert.ToInt16(ShowCountProducts)) + ", " +
				"@FilterParametr = " + clsForSQL.InDataBase(FilterParametr),
				"Class.GetResearchMethods"
				);
			
			if (ReferenceEquals(this.tlClassification.DataSource, null))
			{
				this.tlClassification.ClearNodes();
				this.tlClassification.DataSource = mdQuery.iDataSet.Tables[TableName];
				this.tlClassification.ParentFieldName = "ParentId";
				this.tlClassification.KeyFieldName = "Id";
				this.tlClassification.BestFitColumns(true);
				this.tlClassification.StateImageList = ImageCol;
				mdHidenAllColumns.HidenAllColumns_TreeList(this.tlClassification);
				// если столбец существует, показываем его
				if (!ReferenceEquals(this.tlClassification.Columns[UserControlProperty.ColumnsNameInTreeList], null))
				{
					this.tlClassification.Columns[UserControlProperty.ColumnsNameInTreeList].Visible = true;
				}
			}
			mdVariables.EventChangedControl = true;
			// всем нодам присваиваем иконку
			foreach (TreeListNode nd in this.tlClassification.Nodes)
			{
				FillSelectImageIndex(nd);
				SettingsNode(nd);
			}
			// извлечение из коллекций состояний нодов
			foreach (var n in ndList)
			{
				if (this.tlClassification.FindNodeByKeyID(n.Id) != null)
				{
					this.tlClassification.FindNodeByKeyID(n.Id).Expanded = System.Convert.ToBoolean(n.Expanded);
					this.tlClassification.FindNodeByKeyID(n.Id).Checked = System.Convert.ToBoolean(n.Checked);
				}
			}
			this.tlClassification.FocusedNode = this.tlClassification.FindNodeByKeyID(SelectedItemId);
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
		public void tlClassification_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
		{
			if (ReferenceEquals(e.Node, null) || mdVariables.EventChangedControl == false)
			{
				return;
			}
			SelectedItemId = System.Convert.ToInt32(e.Node["Id"]);
		}
		
		// Двойной клик по узлу
		public void tlClassification_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			TreeList tl = sender;
			TreeListHitInfo hitinfo = tl.CalcHitInfo(e.Location);
			if (ReferenceEquals(hitinfo.Node, null))
			{
				return;
			}
			// если ветка с продукцией
			if (hitinfo.Node.Level == 1)
			{
				hitinfo.Node.Checked = clsMyUserFunction.InvertBoolean(hitinfo.Node.Checked);
			}
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
					this.tlClassification.OptionsView.ShowCheckBoxes = btn.Checked;
					this.gcnClassification.CustomHeaderButtons[9].Properties.Enabled = btn.Checked;
					this.gcnClassification.CustomHeaderButtons[10].Properties.Enabled = btn.Checked;
					break;
					
				case 3: // btnShowSearchRow
					this.tlClassification.OptionsFind.AlwaysVisible = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlClassification.FindFilterText = null; // при отключении очищаем фильтрацию
					}
					break;
					
				case 4: // btnShowFilterRow
					this.tlClassification.OptionsView.ShowAutoFilterRow = btn.Checked;
					if (btn.Checked == false)
					{
						this.tlClassification.ClearColumnsFilter(); // при отключении очищаем фильтрацию
					}
					break;
					
				case 6: // btnExpandedAll
					this.tlClassification.ExpandAll();
					break;
					
				case 7: // btnCollapsedAll
					this.tlClassification.CollapseAll();
					break;
					
				case 9: // btnCheckAll
					if (IsMultiChecked())
					{
						this.tlClassification.CheckAll();
					}
					break;
					
				case 10: // btnUncheckAll
					if (IsMultiChecked())
					{
						this.tlClassification.UncheckAll();
					}
					break;
					
				case 12: // btnEditBooks
					frBooks_ClassificationProducts.Default.ShowDialog();
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
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlClassification.FocusedNode["Id"]);
		}
		
		/// <summary>
		/// Уровень активного узла
		/// </summary>
		public int GetFocusedLevel()
		{
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return 0;
			}
			return System.Convert.ToInt32(this.tlClassification.FocusedNode["Level"]);
		}
		
		/// <summary>
		/// Ид активной классификации
		/// </summary>
		public string GetFocusedClassificationId()
		{
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlClassification.FocusedNode["ClassificationId"]);
		}
		
		/// <summary>
		/// Ид активной продукции
		/// </summary>
		public string GetFocusedProductId()
		{
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlClassification.FocusedNode["ProductId"]);
		}
		
		/// <summary>
		/// Имя активной классификации
		/// </summary>
		public string GetFocusedClassificationName()
		{
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlClassification.FocusedNode["ClassificationName"]);
		}
		
		/// <summary>
		/// Имя активной подукции
		/// </summary>
		public string GetFocusedProductName()
		{
			if (ReferenceEquals(this.tlClassification.FocusedNode, null))
			{
				return "NULL";
			}
			return System.Convert.ToString( this.tlClassification.FocusedNode["ProductName"]);
		}
		
		/// <summary>
		/// Мультистрока Ид классификаций
		/// </summary>
		public string GetMultiStringClassificationId()
		{
			TreeList sender = this.tlClassification; // TreeList
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
			TreeList sender = this.tlClassification; // TreeList
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
			TreeList sender = this.tlClassification; // TreeList
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
			TreeList sender = this.tlClassification; // TreeList
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
			return this.tlClassification.OptionsView.ShowCheckBoxes;
		}
		
		/// <summary>
		/// Задать чеки по объекту из базы
		/// </summary>
		/// <param name="CountryId">Ид страны</param>>
		/// <returns></returns>
		public bool SetMultiCheckedProductId(string CountryId)
		{
			DevExpress.XtraEditors.CheckEdit checkEdit;
			mdQuery.SelectQueryData("CheckedProductsId." + ParentForm.Name,
				"SELECT ClassificationId, ProductId FROM vBooks_CountriesProducts WHERE CountryId = " + CountryId,
				"SetMultiCheckedProductId");
			foreach (System.Data.DataRow r in mdQuery.iDataSet.Tables["CheckedProductsId." + ParentForm.Name].Rows)
			{
				this.tlClassification.FindNodeByKeyID(System.Convert.ToInt32(r["ClassificationId"])).Checked = true;
				this.tlClassification.FindNodeByKeyID(System.Convert.ToInt32(r["ClassificationId"])).Expand();
				this.tlClassification.FindNodeByKeyID(System.Convert.ToInt32(r["ProductId"])).Checked = true;
				this.tlClassification.FindNodeByKeyID(System.Convert.ToInt32(r["ProductId"])).ParentNode.Expand();
			}
		}
		
		/// <summary>
		/// Обновление с текущими параметрами
		/// </summary>
		public void UpdateTreeList()
		{
			mdVariables.tmWaitAnimation.StartWaitingIndicator(this.tlClassification, 0);
			LoadTreeList(_TableName, _CountryId, _IsExpClassification, _ShowCountProducts, _FilterParametr);
			mdVariables.tmWaitAnimation.StopWaitingIndicator();
		}
		
		/// <summary>
		/// Задать Caption для дерева
		/// </summary>
		/// ''' <param name="iValue">Строка значения для Caption</param>>
		public void SetCaptionTreeList(string iValue)
		{
			this.tlClassification.Caption = System.Convert.ToString(iValue);
		}
#endregion
	}
	
}
