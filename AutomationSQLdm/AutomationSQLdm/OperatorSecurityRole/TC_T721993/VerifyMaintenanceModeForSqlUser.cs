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

namespace AutomationSQLdm.OperatorSecurityRole.New_folder
{
    /// <summary>
    /// Description of VerifyMaintenanceModeForSqlUser.
    /// </summary>
    [TestModule("C3784972-9A59-4D5E-B1BF-466C49F854CA", ModuleType.UserCode, 1)]
    public class VerifyMaintenanceModeForSqlUser : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyMaintenanceModeForSqlUser()
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
			  Steps.RightClickMonitoredServer();
        	  Steps.ClickMaintainceModeContextMenu();
        	  Steps.VerifyMaintainceModeContextMenuItems();
        	  Steps.EnableMaintainceMode();
        	  Steps.VerifyMaintainceModeIsChanged();
        	} 
        	catch (Exception ex)
        	{
        		Validate.Fail(ex.Message);
        	}
        	return true;
        }
        
      
    }
}
