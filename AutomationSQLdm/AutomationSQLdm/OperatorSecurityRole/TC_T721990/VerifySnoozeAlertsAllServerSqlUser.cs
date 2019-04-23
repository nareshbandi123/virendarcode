﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using AutomationSQLdm.Base;
using AutomationSQLdm.Commons;


namespace AutomationSQLdm.OperatorSecurityRole.TC_T721990
{
    /// <summary>
    /// Description of VerifySnoozeAlertsAllServerSqlUser.
    /// </summary>
    [TestModule("CCEFCEA9-B10B-45FC-9DB8-E2128E7F56CE", ModuleType.UserCode, 1)]
    public class VerifySnoozeAlertsAllServerSqlUser : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifySnoozeAlertsAllServerSqlUser()
        {
            // Do not delete - a parameterless constructor is required!
        }

     	void ITestModule.Run()
        {
         	StartProcess();
        }
        
        bool StartProcess()
        {
        	try 
        	{
        	  Steps.ClickAdministration();
        	  Steps.ClickApplicationSecurity();
        	  Steps.ClickEnableSecurity();
        	  Steps.AcceptExceptionMessage();
        	  Steps.ClickToAddUsers();
        	  Steps.ClickNextButton();
        	  Steps.EnterDomianUserName(Constants.NewSqlUser);
        	   Steps.SelectSqlAuthentication();
        	  Steps.ClickNextButton();
        	  Steps.ClickOptionBtn_ViewDataAcknowledgwAlarm();
        	  Steps.ClickNextButton();
        	  Steps.SelectServers();
        	  Steps.ClickAddButton();
        	  Steps.ClickNextButton();
        	  Steps.ClickFinishButton();
        	  Steps.VerifySqlUserAdded();
        	  Steps.ClickServersInLeftPane();
			  Steps.RightClickAllServer();
        	  Steps.ClickSnoozeAlertContextMenu();
        	  Steps.SetSnoozeAlertTime();
        	  Steps.VerifyServerSnoozed();
        	} 
        	catch (Exception ex)
        	{
        		Validate.Fail(ex.Message);
        	}
        	finally
        	{
        		Steps.ClickAdministration();
        		Steps.ClickWindowsUserToDelete();
        	    Steps.DeleteAddedUser();
        	}
        	return true;
        }
        
      
    }
}
