using System;
using System.Drawing;
using System.Text;
using AutomationSQLdm.Extensions;
using AutomationSQLdm.Commons;
using Ranorex.Core;
using Ranorex;
using System.Configuration;
using AutomationSQLdm.Configuration;

namespace AutomationSQLdm.OperatorSecurityRole
{
	/// <summary>
	/// Description of Steps.
	/// </summary>
	public static class Steps
	{
		public static T721974Repo repo = T721974Repo.Instance;
		//public const string SNOOZEALERT_MENU = @"/contextmenu[@processname='SQLdmDesktopClient']/menuitem[@automationid='menuToolsGrooming']";
		public const string SNOOZEALERT_MENU = @"/contextmenu[@processname='SQLdmDesktopClient']/menuitem[@automationid='snoozeAllAlertsToolMenu']";
		
		public static void SelectSnoozeAlertMenuItem()
		{ 
			try
			{
				Ranorex.MenuItem snoozeMenuItem = SNOOZEALERT_MENU;
				if(snoozeMenuItem != null) snoozeMenuItem.ClickThis();
				Reports.ReportLog("Selected SnoozeAlert MenuItem", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : SelectSnoozeAlertMenuItem :" + ex.Message);
			}
		}
		
		public static void SetSnoozeAlertTime()
		{ 
			try
			{
				repo.SnoozeAlertsDialog.SnooozeAlertTime.TextValue = "2";
				repo.SnoozeAlertsDialog.OkButton.ClickThis();
				Reports.ReportLog("SnoozeAlert Time applied successfully ! ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : SetSnoozeAlertTime :" + ex.Message);
			}
		}
		
		public static void VerifySnoozeAlertApplied()
		{ 
			try
			{
				Ranorex.MenuItem snoozeMenuItem = SNOOZEALERT_MENU;
				Report.Info(snoozeMenuItem.Enabled.ToString());
				if(!snoozeMenuItem.Enabled) 
					Reports.ReportLog("SnoozeAlert is applied successfully ! ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
				{
					Reports.ReportLog("SnoozeAlert Not applied successfully. ", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
					Validate.Fail("SnoozeAlert Not applied successfully.");
				}
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifySnoozeAlertApplied :" + ex.Message);
			}
		}
		
		public static void ClickAdministration()
		{
			try
			{
				repo.Application.btnAdministrationInfo.WaitForExists(new Duration(100000));
				repo.Application.btnAdministration.ClickThis();
				Reports.ReportLog("Clicked Administration button", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickAdministration : " + ex.Message);
			}
		}
		
		public static void ClickApplicationSecurity()
		{
			try
			{
				//repo.Application.ApplicationSecurityInfo.WaitForExists(new Duration(100000));
				repo.Application.ApplicationSecurity.Click();
				Reports.ReportLog("Clicked Application Security", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickApplicationSecurity : " + ex.Message);
			}
		}
		
		public static void ClickEnableSecurity()
		{
			try
			{
				//repo.Application.EnableSecurityInfo.WaitForExists(new Duration(100000));
				if(repo.Application.EnableSecurityInfo.Exists())
				{
					repo.Application.EnableSecurity.ClickThis();
					Reports.ReportLog("Clicked Enabled Security", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
				}
				else
					Reports.ReportLog("Enabled Security link not exists", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickEnableSecurity : " + ex.Message);
			}
		}

		public static void AcceptExceptionMessage()
		{
			try
			{
				if(repo.ExceptionForm.SelfInfo.Exists())
				{
					repo.ExceptionForm.btnYes.ClickThis();
					Reports.ReportLog("Clicked Yes button on Exception Alert", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
				}
				else
					Reports.ReportLog("Exception Message popup does not exists", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : AcceptExceptionMessage : " + ex.Message);
			}
		}
		
		public static void ClickToAddUsers()
		{
			try
			{
				repo.Application.btnAddUsers.ClickThis();
				Reports.ReportLog("Clicked Add Users", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickToAddUsers : " + ex.Message);
			}
		}
		
		public static void ClickNextButton()
		{
			try
			{
				//repo.AddPermissionWizard.btnNextInfo.WaitForExists(new Duration(500));				
				repo.AddPermissionWizard.btnNext.ClickThis();
				Reports.ReportLog("Clicked Next Button", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickNextButton : " + ex.Message);
			}
		}
	
		public static void EnterDomianUserName(string domainUserName)
		{
			try
			{
				//repo.AddPermissionWizard.txtUserNameInfo.WaitForExists(new Duration(500));				
				repo.AddPermissionWizard.txtUserName.PressKeys(domainUserName);
				Reports.ReportLog("Entered DomianUserName", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : EnterDomianUserName : " + ex.Message);
			}
		}
		
		public static void SelectSqlAuthentication()
		{
			try
			{
				Ranorex.ComboBox combobox = repo.AddPermissionWizard.ComboBoxUserPageCmbBxAuthentication;
				combobox.Click();
				ListItem lst_userItem = combobox.FindSingle<ListItem>("/list/listitem[@text='SQL Server Authentication']");
				lst_userItem.Focus();  
				lst_userItem.Click(); 
				Reports.ReportLog("SQL Server Authentication Selected ", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : SelectAuthenticationType : " + ex.Message);
			}
		}
		
		public static void ClickOptionBtn_ViewDataAcknowledgwAlarm()
		{
			try
			{
				//repo.AddPermissionWizard.ViewDataAcknowledgwAlarmInfo.WaitForExists(new Duration(500));
				repo.AddPermissionWizard.ViewDataAcknowledgwAlarm.Click();
				Reports.ReportLog("Selected Option ViewDataAcknowledgwAlarm ", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickOptionBtn_ViewDataAcknowledgwAlarm : " + ex.Message);
			}
		}
		
		public static void SelectServers()
		{
			try
			{
				Ranorex.List serversLists= null;
				if(repo.AddPermissionWizard.AvailableServersInfo.Exists())
				{
					serversLists = repo.AddPermissionWizard.AvailableServers;
					if(serversLists.Children.Count >= 1)
					{
						//Report.Info("serversLists.Items[0]: " + serversLists.Items[0]);
						//serversLists.Children[0].Click();
						serversLists.Items[0].Click();
						Reports.ReportLog("Selected Server", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
					}
					else
					{
						Reports.ReportLog("No Servers Available in Server List : ", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
					}
				}
				else
				{
					Reports.ReportLog("Available Server Dialog not exists : ", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickOptionBtn_ViewDataAcknowledgwAlarm : " + ex.Message);
			}
		}
		
		public static void ClickAddButton()
		{
			try
			{
				//repo.AddPermissionWizard.ViewDataAcknowledgwAlarmInfo.WaitForExists(new Duration(500));
				repo.AddPermissionWizard.ButtonAdd.Click();
				Reports.ReportLog("Clicked Add button to Add Server", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickAddButton : " + ex.Message);
			}
		}
		
		public static void ClickFinishButton()
		{
			try
			{
				//repo.AddPermissionWizard.ViewDataAcknowledgwAlarmInfo.WaitForExists(new Duration(500));
				repo.AddPermissionWizard.ButtonFinish.Click();
				Reports.ReportLog("Clicked Finish Button", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickFinishButton : " + ex.Message);
			}
		}
		
		public static void VerifyWindowsUserAdded()
		{
			try
			{
				if(repo.Application.NewWindowsUserAddedInfo.Exists())
				{
					Reports.ReportLog("New User Added Successfully ! " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
				}
				else
				{
					Reports.ReportLog("New User not Added : ", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
					Validate.Fail("New User not Added Successfully");
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : VerifyWindowsUserAdded : " + ex.Message);
			}
		}
		
		public static void VerifySqlUserAdded()
		{
			try
			{
				if(repo.Application.NewSqlUserAddedInfo.Exists())
				{
					Reports.ReportLog("New User Added Successfully ! " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
				}
				else
				{
					Reports.ReportLog("New User not Added : ", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
					Validate.Fail("New User not Added Successfully");
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : VerifySqlUserAdded : " + ex.Message);
			}
		}
			
		public static void VerifyViewDataAcknowledgwAlarmIsSelected(string userType)
		{
			try
			{
				//repo.Application.NewWindowsUserAdded.DoubleClick();
				if(userType.Equals("WindowsUser")) 
					repo.Application.NewWindowsUserAdded.DoubleClick();
				else 
					repo.Application.NewSqlUserAdded.DoubleClick();
				if(repo.PermissionPropertyDialog.ViewDataAcknowledgwAlarm.Checked)
				{
					Reports.ReportLog("ViewDataAcknowledgwAlarm Option is Selected " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
					
				}
				else
				{
					Reports.ReportLog("ViewDataAcknowledgwAlarm Option Not Selected : ", Reports.SQLdmReportLevel.Info, null, Configuration.Config.TestCaseName);
					Validate.Fail("ViewDataAcknowledgwAlarm Option Not Selected");
				}
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : VerifyUserAdded : " + ex.Message);
			}
		}
		
		public static void ClickCancelPermissionProperties()
		{
			try
			{
				repo.PermissionPropertyDialog.btnCancel.ClickThis();
				Reports.ReportLog("Clicked Cancel Permission Properties " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : VerifyUserAdded : " + ex.Message);
			}
		}
		
		public static void ClickWindowsUserToDelete()
		{
			try
			{
				repo.Application.NewWindowsUserAdded.Click();
				Reports.ReportLog("Clicked New WindowsUser Added " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickWindowsUserAdded : " + ex.Message);
			}
		}
		
		public static void ClickSqlUserToDelete()
		{
			try
			{
				repo.Application.NewSqlUserAdded.Click();
				Reports.ReportLog("Clicked New SqlUser Added " , Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : ClickSqlUserAdded : " + ex.Message);
			}
		}
		
		public static void DeleteAddedUser()
		{
			try
			{
				//repo.AddPermissionWizard.ViewDataAcknowledgwAlarmInfo.WaitForExists(new Duration(500));
				//repo.Application.NewWindowsUserAdded.Click();
				repo.Application.btnDelete.Click();
				repo.ExceptionForm.btnYes.Click();
				Reports.ReportLog("New User Deleted Successfully ! ", Reports.SQLdmReportLevel.Success, null, Configuration.Config.TestCaseName);
			}
			catch(Exception ex)
			{
				throw new Exception("Failed : DeleteAddedUser : " + ex.Message);
			}
		}
		
	}
}
