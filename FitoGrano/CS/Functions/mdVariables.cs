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

using DevExpress.LookAndFeel;
using DevExpress.Utils.Animation;
using FitoGrano;


namespace FitoGrano
{
	sealed class mdVariables
	{
		// модуль для складирования переменных
		internal static DefaultLookAndFeel iLookAndFeel = new DefaultLookAndFeel(); // Стили оформления для программы
		internal static string pref_RegistryPath = "Software\\Microsoft\\FitoGrano\\"; // Префикс пути в реестре к настройкам
		internal static string pref_ComplexSettings = "Software\\Microsoft\\FitoGrano\\" + "ComplexSettings\\"; // Префикс пути в реестре к настройкам комплекса
		internal static string pref_UserSettings = "Software\\Microsoft\\FitoGrano\\" + "UserSettings\\"; // Префикс пути в реестре к настройкам пользователя
		internal static TransitionManager tmWaitAnimation = new TransitionManager(); // Анимация при ожидании
		internal static string DecSeporator; // Разделитель десятичной доли заданный в системе пользователя
		// Friend AddEdit As Integer = 2                                                   ' 2 - Добавить; 3 - Изменить
		internal static bool EventChangedControl = false; // Разрешение на обработку событий элементов управления
		internal static string glNewId; // Ид новой записи в базе (глобальная переменная)
		
		// Переменные для хранения параметров
		internal static string pref_PerformerId; // id текущего пользователя
		internal static string pref_PerformerName; // Полное имя текущего пользователя
		internal static string pref_PerformerNameShort; // ФИО текущего пользователя
		internal static string pref_PerformerLogin; // Логин текущего пользователя
		internal static string pref_ServerIP; // ip текущего сервера
		internal static string pref_DataBaseName; // Имя текущей базы данных
		internal static string pref_OrganizationFilial; // Текущий филиал
		internal static string pref_ConnectionString; // Строка подключения текущего пользователя
		
		// Пол
		public enum SexType
		{
			Женский = 0,
			Мужской = 1
		}
	}
	
}
