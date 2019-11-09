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

using FitoGrano;

namespace FitoGrano
{
	public class clsForSQL
	{
		// проверка передаваемых значений в базу
		public static string InDataBase(object iValue, string iDataType = "varchar")
		{
			// If IsNumeric(iValue) = False Then
			if (ReferenceEquals(iValue, null))
			{
				return "NULL";
			}
			if (Information.IsDBNull(iValue))
			{
				return "NULL";
			}
			if (iValue.ToString() == "NULL")
			{
				return "NULL";
			}
			if (Strings.Trim(System.Convert.ToString(iValue)) == "")
			{
				return "NULL";
			}
			//End If
			if (iDataType == "varchar")
			{
				iValue = Strings.Replace(System.Convert.ToString(iValue), "'", "''");
				return "'" + Strings.Trim(System.Convert.ToString(iValue)) + "'";
			}
			if (iDataType == "int")
			{
				return Strings.Trim(System.Convert.ToString(iValue));
			}
			if (iDataType == "DateTime")
			{
				DateTime d = System.Convert.ToDateTime(iValue);
				return "'" + d.ToShortDateString() + "'";
			}
		}
		// проверка значений из бызы
		public static dynamic OutDataBase(object iValue)
		{
			if (Information.IsDBNull(iValue))
			{
				return null;
			}
			else
			{
				return iValue;
			}
		}
		// замена аппострофов
		private string CheckingApostrophe(string iString)
		{
			string iChar = ""; // проверяемый символ
			string iText = ""; // проверяемый текст
			for (var i = 1; i <= iString.Length; i++)
			{
				iChar = Microsoft.VisualBasic.Strings.Mid(iString, System.Convert.ToInt32(i), 1);
				if (iChar == "'")
				{
					iChar = "'''";
				}
				iText += iChar;
			}
			return iText;
		}
		
		
		
	}
	
}
