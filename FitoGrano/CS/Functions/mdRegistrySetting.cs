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

using DevExpress.XtraEditors;
using Microsoft.Win32;
using FitoGrano;

// класс для работы с реестром (для настроек приложения)
namespace FitoGrano
{
	internal sealed class mdRegistrySetting
	{
#region Работа с реестром
		// Чтение из реестра
		public static dynamic RegistryRead(string SectionName, string KeyName, string NothingValue = "", RegistryValueKind NothingDataType = RegistryValueKind.String)
			{
			// если раздела не существует, но нет ключа вернется значение по-умолчанию
			// Проверка существования раздела
			string iSec = System.Convert.ToString(Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, null)); // Возвращаем значение из реестра
			if (string.IsNullOrEmpty(iSec)) // Если раздела и ключа не существует
			{
				// они будут созданы автоматически
				RegistryWrite(SectionName, KeyName, NothingValue, NothingDataType);
			}
			// если существуют, вернуться значения из реестра
			return Registry.CurrentUser.CreateSubKey(SectionName).GetValue(KeyName, NothingValue);
		}
		// Запись в реестр
		public static void RegistryWrite(string SectionName, string KeyName, string Value, RegistryValueKind DataType = RegistryValueKind.String)
			{
			// Если ни раздела, ни ключа не существует, он будет создан
			(new Microsoft.VisualBasic.Devices.Computer()).Registry.CurrentUser.CreateSubKey(SectionName, false).SetValue(KeyName, Value, DataType); // Записываем текст в раздел Test
		}
		// Создание раздела
		public static void RegistryCreateSection(string SectionName)
		{
			(new Microsoft.VisualBasic.Devices.Computer()).Registry.CurrentUser.CreateSubKey(SectionName, RegistryKeyPermissionCheck.ReadWriteSubTree); // Создаем новый раздел в реестре с доступом на запись
		}
		// Удаление раздела
		public static void RegistryDeleteSection(string SectionName)
		{
			try
			{
				(new Microsoft.VisualBasic.Devices.Computer()).Registry.CurrentUser.DeleteSubKeyTree(SectionName, true); // Удаляем раздел из реестра
			}
			catch (Exception e)
			{
				XtraMessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		// Удаление ключа из ветки реестра
		public static dynamic RegistryDeleteKey(string SectionName, string KeyName)
		{
			try
			{
				(new Microsoft.VisualBasic.Devices.Computer()).Registry.CurrentUser.OpenSubKey(SectionName, true).DeleteValue(KeyName, true);
			}
			catch (Exception eX)
			{
				XtraMessageBox.Show(eX.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
#endregion
	}
	
}
