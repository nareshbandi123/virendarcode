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


namespace AutomationSQLdm.OperatorSecurityRole.TC_T721989
{
    /// <summary>
    /// Description of VerifyMaintenanceModeForAllServersForWindowsUser.
    /// </summary>
    [TestModule("312C6FF6-55A4-403E-8466-8617234F935B", ModuleType.UserCode, 1)]
    public class VerifyMaintenanceModeForAllServersForWindowsUser : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyMaintenanceModeForAllServersForWindowsUser()
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
        	  Steps.EnterDomianUserName(Constants.NewWindowsUser);
        	  Steps.ClickNextButton();
        	  Steps.ClickOptionBtn_ViewDataAcknowledgwAlarm();
        	  Steps.ClickNextButton();
        	  Steps.SelectServers();
        	  Steps.ClickAddButton();
        	  Steps.ClickNextButton();
        	  Steps.ClickFinishButton();
        	  Steps.VerifyWindowsUserAdded();
			  Steps.ClickServersInLeftPane();
			  Steps.RightClickAllServer();
        	  Steps.ClickMaintainceModeContextMenu();
        	  Steps.VerifyMaintainceModeContextMenuItems();
        	  Steps.EnableMaintainceMode();
        	  Steps.VerifyMaintainceModeIsChanged();
        	  //Steps.ClickWindowsUserToDelete();
        	  //Steps.DeleteAddedUser();
        	  
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
