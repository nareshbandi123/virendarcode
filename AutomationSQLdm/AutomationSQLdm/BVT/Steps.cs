using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Configuration;
using AutomationSQLdm.Extensions;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;
//using Ranorex

namespace AutomationSQLdm.BVT
{
	/// <summary>
	/// Description of Steps.
	/// </summary>
	public static class  Steps
	{
		public static BVTRepo repo = BVTRepo.Instance;
		
		public static void ClickProperties()
		{
			try
			{
				repo.SQLdmDesktopClient.Properties.ClickThis();
				Reports.ReportLog("Clicked Properties ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : ClickProperties :" + ex.Message);
			}
		}
		
		public static void ClickOSMetrix()
		{
			try
			{
				repo.MonitoredSqlServerInstancePropertiesDial.OSMetrix.ClickThis();
				Reports.ReportLog("Clicked OSMetrix ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : OSMetrix :" + ex.Message);
			}
		}
		
		public static void SelectOperatingSystemMetrixUsingDirectWMI()
		{
			try
			{
				repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.OptionWmiDirect.Click();
				Reports.ReportLog("Option Operating System Metrix Using Direct WMI Selected ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : SelectOperatingSystemMetrixUsingDirectWMI :" + ex.Message);
			}
		}
		
		public static void SelectOptionSqldmServiceAccount()
		{
			try
			{
				if(repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.SqldmServiceAccount.Checked)
				{
					repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.SqldmServiceAccount.ClickThis();
					Reports.ReportLog("OptionSqldmServiceAccount Selected ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : SelectOptionSelectSqldmServiceAccount :" + ex.Message);
			}
		}
		
		public static void EnterUsername(string username)
		{
			try
			{
				repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.UserName.PressKeys(username);
				Reports.ReportLog("Entered Username " + username , Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : EnterUsername :" + ex.Message);
			}
		}
		
		public static void EnterPassword(string password)
		{
			try
			{
				repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.Password.PressKeys(password);
				Reports.ReportLog("Entered Password "+ password, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : EnterPassword :" + ex.Message);
			}
		}
		
		public static void ClickTest()
		{
			try
			{
				repo.MonitoredSqlServerInstancePropertiesDial.OsPropertyPage.WmiTestButton.ClickThis();
				Reports.ReportLog("Clicked Test Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : ClickTest :" + ex.Message);
			}
		}
		
		public static void VerifyPopupMessage()
		{
			try
			{
				if(repo.ExceptionMessageBoxForm.SelfInfo.Exists())
				{
					Reports.ReportLog("PopupMessage Exists", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				}
				else
				{
					Reports.ReportLog("PopupMessage does not Exists", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
					throw new Exception("Failed : VerifyPopupMessage ");
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyPopupMessage :" + ex.Message);
			}
		}
		
		
		public static void VerifyImage123()
		{
			try
			{
				if(repo.Application.ElementBrInfo.Exists())
				{
					CompressedImage BarChart = repo.Application.ElementBrInfo.GetCPU();
					
					Imaging.FindOptions MyFindOptions = new Imaging.FindOptions(0.40);
					
					Bitmap bmp = Imaging.CaptureImage(repo.Application.ElementBr);
					bool isvalid = Imaging.Compare(bmp, BarChart, MyFindOptions);
					if(isvalid)
					{
						Reports.ReportLog("PopupMessage Exists", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					}
					
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : ValidateCurrencycodeColorChart  : " + ex.Message);
			}

	   }
  
    }
}
	

