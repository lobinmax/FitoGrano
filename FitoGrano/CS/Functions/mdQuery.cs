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

using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;
using FitoGrano;


namespace FitoGrano
{
	sealed class mdQuery
	{
		// РџРµСЂРµРјРµРЅРЅС‹Рµ РґР»СЏ РєР»РёРµРЅС‚СЃРєРѕР№ Р±Р°Р·С‹ РґР°РЅРЅС‹С…
		internal static SqlConnection Conn = new SqlConnection(); // РџРѕРґРєР»СЋС‡РµРЅРёРµ Рє Р‘Р”
		//Friend SqlCom As New SqlCommand                                                 ' РџРµСЂРµРјРµРЅРЅР°СЏ РґР»СЏ Sql Р·Р°РїСЂРѕСЃРѕРІ
		//Friend iDataAdapter As New SqlDataAdapter                                       ' РђРґР°РїС‚РµСЂ РґР»СЏ Р·Р°РїРѕР»РЅРµРЅРёСЏ С‚Р°Р±Р»РёС†С‹ РїРѕСЃР»Рµ Р·Р°РїСЂРѕСЃР°
		internal static DataSet iDataSet = new DataSet(); // РўР°Р±Р»РёС†Р° РґР»СЏ С…СЂР°РЅРµРЅРёСЏ СЂРµР·СѓР»СЊС‚Р°С‚РѕРІ Р·Р°РїСЂРѕСЃР°
		// РџРµСЂРµРјРµРЅРЅС‹Рµ РґР»СЏ СѓРЅРёРІРµСЂСЃР°Р»СЊРЅРѕРіРѕ РЎРµР»РµРєС‚Р°
		//Friend iTableName As String                                                     ' РРјСЏ Р±СѓРґСѓС‰РµР№ С‚Р°Р±Р»РёС†С‹
		//Friend iCommandText As String                                                   ' РўРµРєСЃС‚ SQL Р·Р°РїСЂРѕСЃР°
		internal static bool CompliteLoad; // Р•СЃР»Рё False, Р·Р°РїСЂРѕСЃ Рє Р±Р°Р·Рµ РµС‰Рµ РІС‹РїРѕР»РЅСЏРµС‚СЃСЏ
		
		// РџРѕРґРєР»СЋС‡РµРЅРёРµ Рє РєР»РёРµРЅС‚СЃРєРѕР№ Р±Р°Р·Рµ РґР°РЅРЅС‹С…
		internal static void ConnectionToBase(string server, string user, string pass, string bd)
		{
			if (Conn.State == ConnectionState.Open)
			{
				Conn.Close();
			}
			// РЎС‚СЂРѕРєР° РїРѕРґРєР»СЋС‡РµРЅРёСЏ СЃ РїРµСЂРµРјРµРЅРЅС‹РјРё РёР· РІС…РѕРґРЅС‹С… РїР°СЂР°РјРµС‚СЂРѕРІ РїСЂРѕС†РµРґСѓСЂС‹
			Conn.ConnectionString = "Persist Security Info = False;" +
				"Connect Timeout = 360;" +
				"User ID =" + user + ";" +
				"Password =" + pass + ";" +
				"Initial Catalog =" + bd + ";" +
				"Server =" + server + ";" +
				"MultipleActiveResultSets = True";
			mdVariables.pref_ConnectionString = Conn.ConnectionString;
			if (Conn.State == ConnectionState.Closed)
			{
				Conn.Open(); // РћС‚РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
			}
		}
		// РЈРЅРёРІРµСЂСЃР°Р»СЊРЅР°СЏ РїСЂРѕС†РµРґСѓСЂР° СЃ РІС…РѕРґРЅС‹РјРё РїР°СЂР°РјРµС‚СЂР°РјРё РґР»СЏ РІС‹Р±РѕСЂРєРё РёР· Р±С‹Р·С‹
		// iTableName - РРјСЏ СЃРѕР·РґР°РІР°РµРјРѕР№ С‚Р°Р±Р»РёС†С‹ РІ iDataSet
		// iCommandText - РўРµРєСЃС‚ РєРѕРјР°РЅРґС‹
		// iName - РРјСЏ РґРѕС‡РµСЂРЅРµР№ РїСЂРѕС†РµРґСѓСЂС‹
		internal static bool SelectQueryData(string iTableName, string iCommandText, string iName = "")
		{
			SqlDataAdapter iDataAdapter = new SqlDataAdapter();
			SqlCommand SqlCom = new SqlCommand();
			CompliteLoad = false; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅСЏРµС‚СЃСЏ
			try
			{
				// Р•СЃР»Рё С‚Р°Р±Р»РёС†Р° iTableName СЃСѓС‰РµСЃС‚РІСѓРµС‚ С‚Рѕ, РѕС‡РёС‰Р°Рµ РµРµ' Р•СЃР»Рё С‚Р°Р±Р»РёС†Р° iTableName СЃСѓС‰РµСЃС‚РІСѓРµС‚ С‚Рѕ, РѕС‡РёС‰Р°Рµ РµРµ
				if (iDataSet.Tables.Contains(iTableName))
				{
					iDataSet.Tables[iTableName].Clear();
				}
				if (Conn.State == ConnectionState.Closed)
				{
					Conn.Open(); // РћС‚РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
				}
				SqlCom.Connection = Conn; // РЈРєР°Р·С‹РІР°РµРј РїРѕРґРєР»СЋС‡РµРЅРёРµ
				SqlCom.CommandText = iCommandText; // РЈРєР°Р·С‹РІР°РµРј С‚РµРєСЃС‚ Р·Р°РїСЂРѕСЃР°
				SqlCom.CommandTimeout = 600;
				
				// РќР°СЃС‚СЂР°РёРІР°РµРј РђРґР°РїС‚РµСЂ
				iDataAdapter.SelectCommand = SqlCom; // РЈРєР°Р·С‹РІР°РµРј РєРѕРјР°РЅРґСѓ РЅР° РІС‹РіСЂСѓР·РєСѓ РґР°РЅРЅС‹С… РёР· Р±Р°Р·С‹
				iDataAdapter.Fill(iDataSet, iTableName); // Р’С‹РіСЂСѓР¶РµРЅРЅС‹Рµ РґР°РЅРЅС‹Рµ Р·Р°Р»РёРІР°РµРј РІ DateSet Рё РёРјРµРЅСѓРµРј
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return true;
			}
			catch (Exception ex)
			{
				XtraMessageBox.Show(ex.Message + "\n" +
					"РћС€РёР±РєР° РІС‹Р·РѕРІР° РїСЂРѕС†РµРґСѓСЂС‹: <b>" + iName + "</b>",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					DevExpress.Utils.DefaultBoolean.True);
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return false;
			}
			Conn.Close();
		}
        // +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        // РЈРЅРёРІРµСЂСЃР°Р»СЊРЅР°СЏ РїСЂРѕС†РµРґСѓСЂР° СЃ РІС…РѕРґРЅС‹РјРё РїР°СЂР°РјРµС‚СЂР°РјРё РґР»СЏ РІС‹РїРѕР»РЅРµРЅРёСЏ РїСЂРѕС†РµРґСѓСЂ РІ Р±Р°Р·Рµ Р±РµР· РІРѕР·РІСЂР°С‚Р° Р·РЅР°С‡РµРЅРёР№
        // iCommandText - С‚РµРєСЃС‚ РєРѕРјР°РЅРґС‹
        // iName - РРјСЏ РґРѕС‡РµСЂРЅРµР№ РїСЂРѕС†РµРґСѓСЂС‹
        internal static bool ExecuteQuery(string iCommandText, string iName = "")
		{
			SqlCommand SqlCom = new SqlCommand();
			CompliteLoad = false; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅСЏРµС‚СЃСЏ
			try // РџРѕРїС‹С‚РєР° РѕР±РЅРѕРІР»РµРЅРёСЏ РґР°РЅРЅС‹С…
			{
				if (Conn.State == ConnectionState.Closed)
				{
					Conn.Open(); // РћС‚РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
				}
				SqlCom.Connection = Conn;
				SqlCom.CommandText = iCommandText; // Р—Р°РїРёСЃСЊ С‚РµРєСЃС‚Р° РєРѕРјР°РЅРґС‹
				SqlCom.ExecuteNonQuery(); // Р’С‹РїРѕР»РЅРµРЅРёРµ РєРѕРјР°РЅРґС‹ РЅР° СЃРµСЂРІРµСЂ
				SqlCom.CommandTimeout = 600;
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return true;
				// РЎРѕРѕР±С‰РµРЅРёРµ РїСЂРё РЅРµСѓРґР°С‡РЅРѕРј РїРѕРґРєР»СЋС‡РµРЅРёРё Рє Р±Р°Р·Рµ РґР°РЅРЅС‹С…
			}
			catch (Exception ex)
			{
				// РЎРѕРѕР±С‰РµРЅРёРµ РїСЂРё РЅРµСѓРґР°С‡РЅРѕРј РїРѕРґРєР»СЋС‡РµРЅРёРё Рє Р±Р°Р·Рµ РґР°РЅРЅС‹С…
				XtraMessageBox.Show(ex.Message + "\n" +
					"РћС€РёР±РєР° РІС‹Р·РѕРІР° РїСЂРѕС†РµРґСѓСЂС‹: <b>" + iName + "</b>",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					DevExpress.Utils.DefaultBoolean.True);
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return false;
			}
			Conn.Close(); // Р—Р°РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
		}
		
		// +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
		// РЈРЅРёРІРµСЂСЃР°Р»СЊРЅР°СЏ РїСЂРѕС†РµРґСѓСЂР° СЃ РІС…РѕРґРЅС‹РјРё РїР°СЂР°РјРµС‚СЂР°РјРё РґР»СЏ РІС‹РїРѕР»РЅРµРЅРёСЏ СЃРєР°Р»СЏСЂРЅС‹С… С„СѓРЅРєС†РёР№ РІ Р±Р°Р·Рµ
		// iCommandText - С‚РµРєСЃС‚ РєРѕРјР°РЅРґС‹
		// iName - РРјСЏ РґРѕС‡РµСЂРЅРµР№ РїСЂРѕС†РµРґСѓСЂС‹
		internal static dynamic ExecuteScalar(string iCommandText, string iName = "")
		{
			SqlCommand SqlCom = new SqlCommand();
			CompliteLoad = false; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅСЏРµС‚СЃСЏ
			try // РџРѕРїС‹С‚РєР° РѕР±РЅРѕРІР»РµРЅРёСЏ РґР°РЅРЅС‹С…
			{
				if (Conn.State == ConnectionState.Closed)
				{
					Conn.Open(); // РћС‚РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
				}
				SqlCom.Connection = Conn;
				SqlCom.CommandText = iCommandText; // Р—Р°РїРёСЃСЊ С‚РµРєСЃС‚Р° РєРѕРјР°РЅРґС‹
				SqlCom.CommandTimeout = 600; // РўР°Р№РјР°СѓС‚ Р·Р°РїСЂРѕСЃР°
				
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return SqlCom.ExecuteScalar(); // Р’С‹РїРѕР»РЅРµРЅРёРµ РєРѕРјР°РЅРґС‹ РЅР° СЃРµСЂРІРµСЂ
				// РЎРѕРѕР±С‰РµРЅРёРµ РїСЂРё РЅРµСѓРґР°С‡РЅРѕРј РїРѕРґРєР»СЋС‡РµРЅРёРё Рє Р±Р°Р·Рµ РґР°РЅРЅС‹С…
			}
			catch (Exception ex)
			{
				// РЎРѕРѕР±С‰РµРЅРёРµ РїСЂРё РЅРµСѓРґР°С‡РЅРѕРј РїРѕРґРєР»СЋС‡РµРЅРёРё Рє Р±Р°Р·Рµ РґР°РЅРЅС‹С…
				XtraMessageBox.Show(ex.Message + "\n" +
					"РћС€РёР±РєР° РІС‹Р·РѕРІР° РїСЂРѕС†РµРґСѓСЂС‹: <b>" + iName + "</b>",
					Application.ProductName,
					MessageBoxButtons.OK,
					MessageBoxIcon.Error,
					DevExpress.Utils.DefaultBoolean.True);
				CompliteLoad = true; // Р—Р°РїСЂРѕСЃ РІС‹РїРѕР»РЅРµРЅ
				return "err";
			}
			Conn.Close(); // Р—Р°РєСЂС‹РІР°РµРј СЃРѕРµРґРёРЅРµРЅРёРµ
		}
	}
	
}
