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

using System.Data;
using FitoGrano;

namespace FitoGrano
{
	
	public class clsMyUserFunction
	{
		// Инвертация логических значений
		public static bool InvertBoolean(bool _value)
		{
			if (_value == false)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// Очистка содержимого не нужных таблиц в DataSet принадлежащих указанной форме
		// _Me - форма в которой были созданы таблицы
		public static void RemoveTableDataSet(dynamic _Me)
		{
			// Края вхождения строки
			int lStrNum = 0;
			int rStrNum = System.Convert.ToInt32(_Me.Name.Length);
			string s;
			List<string> iName = new List<string>();
			
			mdVariables.EventChangedControl = false;
			mdQuery.iDataSet.Relations.Clear(); // удаление отношений
			for (var t = 0; t <= mdQuery.iDataSet.Tables.Count - 1; t++)
			{
				if (mdQuery.iDataSet.Tables.Contains(mdQuery.iDataSet.Tables[t].TableName))
				{
					lStrNum = (mdQuery.iDataSet.Tables[t].TableName.ToString()).IndexOf(_Me.Name.ToString()) + 1;
					if (lStrNum != 0)
					{
						s = Strings.Mid(mdQuery.iDataSet.Tables[t].TableName.ToString(), lStrNum, rStrNum);
						if (s == _Me.Name.ToString())
						{
							// запись в коллекцию имени таблиц к удалени
							iName.Add(mdQuery.iDataSet.Tables[t].TableName.ToString());
							Console.WriteLine(mdQuery.iDataSet.Tables[t].TableName.ToString() + " -к удалению");
						}
					}
				}
			}
			// удаление таблиц по коллекции
			foreach (string n in iName)
			{
				mdQuery.iDataSet.Tables.Remove(n);
			}
			Console.WriteLine(mdQuery.iDataSet.Tables.Count);
			foreach (DataTable t in mdQuery.iDataSet.Tables)
			{
				Console.WriteLine("Осталась - " + t.TableName);
			}
			_Me.Dispose();
			mdVariables.EventChangedControl = true;
		}
		
		// Сортировка таблица в Dataset
		public static DataTable SortDataTable(DataTable _DataTable, string _ColumnName, string _Sorting = "ASC")
		{
			DataTable tablecopy = new DataTable();
			tablecopy = _DataTable.Copy();
			_DataTable.Clear();
			DataRow[] foundRows;
			foundRows = tablecopy.Select("", _ColumnName + " " + _Sorting);
			
			foreach (DataRow dbrow in foundRows)
			{
				_DataTable.ImportRow(dbrow);
			}
			tablecopy.Clear();
			return _DataTable;
		}
		
#region Получение сохранение параметров форм (размер и положение)
		public static void LoadViewForm(dynamic _Me)
		{
			string PreferenceForms = mdVariables.pref_UserSettings + "\\" + _Me.Name + "\\";
			// Размер
			int SizeHeight = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "Size.Height", System.Convert.ToString(0)));
			int SizeWidth = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "Size.Width", System.Convert.ToString(0)));
			// Положение
			int LocationX = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "Location.X", System.Convert.ToString(0)));
			int LocationY = System.Convert.ToInt32(mdRegistrySetting.RegistryRead(PreferenceForms, "Location.Y", System.Convert.ToString(0)));
			
			if (SizeHeight != 0 | SizeWidth != 0)
			{
				_Me.Size = new System.Drawing.Point(SizeWidth, SizeHeight);
			}
			if (LocationX != 0 | LocationY != 0)
			{
				_Me.StartPosition = FormStartPosition.Manual;
				_Me.Location = new System.Drawing.Point(LocationX, LocationY);
			}
		}
		public static void SaveViewForm(dynamic _Me)
		{
			string PreferenceForms = mdVariables.pref_UserSettings + "\\" + _Me.Name + "\\";
			// Размер
			mdRegistrySetting.RegistryWrite(PreferenceForms, "Size.Height", System.Convert.ToString(_Me.Size.Height));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "Size.Width", System.Convert.ToString(_Me.Size.Width));
			// Положение
			mdRegistrySetting.RegistryWrite(PreferenceForms, "Location.X", System.Convert.ToString(_Me.Location.X));
			mdRegistrySetting.RegistryWrite(PreferenceForms, "Location.Y", System.Convert.ToString(_Me.Location.Y));
			_Me.Dispose();
		}
#endregion
	}
	
}
