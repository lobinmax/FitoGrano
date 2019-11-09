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
	public partial class frMain
	{
		public frMain()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frMain defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frMain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frMain();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		// Локация герба {600; 12}
		public void frMain_Load(System.Object sender, System.EventArgs e)
		{
			this.ptbGerb.Parent = this.ptbFone;
			DevExpress.LookAndFeel.UserLookAndFeel.Default.StyleChanged += Default_StyleChanged;
		}
		
		public void tmrDateTime_Tick(System.Object sender, System.EventArgs e)
		{
			this.lbDateTime.Caption = System.Convert.ToString(DateTime.Now.ToLocalTime());
		}
		
		public void btnSecurityUsers_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frSecurityUsers.Default.ShowDialog();
		}
		
		public void btnOrganizationStructure_ItemClick(System.Object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frBooks_OrganizationStructure.Default.ShowDialog();
		}
		
		public void BarButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frAddEditOrganizationsRoleJob.Default.ShowDialog();
		}
		
		// Событие изменения темы оформления
		private void Default_StyleChanged(object sender, EventArgs e)
		{
			mdRegistrySetting.RegistryWrite(mdVariables.pref_ComplexSettings, "SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName);
		}
		
		public void btnClassificationProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frBooks_ClassificationProducts.Default.ShowDialog();
		}
		
		public void btnResearchDirection_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frBooks_ResearchDirection.Default.ShowDialog();
		}
		
		public void btnResearchObjects_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frBooks_ResearchObjects.Default.ShowDialog();
		}
		
		public void btnCountryAgreements_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			frBooks_CountryAgreements.Default.ShowDialog();
		}
	}
}
