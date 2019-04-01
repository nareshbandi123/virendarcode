using System;
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

namespace AutomationSQLdm.ApplicationSecurity.TC_T721981
{
    /// <summary>
    /// Description of VerifySnoozeAlertsForUserWithViewDataAcknowledgeAlarms.
    /// </summary>
    [TestModule("F30DD081-D3D3-4CAD-A667-CE95C221E53A", ModuleType.UserCode, 1)]
    public class VerifySnoozeAlertsForUserWithViewDataAcknowledgeAlarms : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifySnoozeAlertsForUserWithViewDataAcknowledgeAlarms()
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
//        	  Steps.ClickAdministration();
//        	  Steps.ClickApplicationSecurity();
////        	  Steps.ClickEnableSecurity();
////        	  Steps.AcceptExceptionMessage();
//        	  Steps.ClickToAddUsers();
//        	  Steps.ClickNextButton();
//        	  Steps.EnterDomianUserName(Constants.NewWindowsUser);
//        	  Steps.ClickNextButton();
//        	  Steps.ClickOptionBtn_ViewDataAcknowledgwAlarm();
//        	  Steps.ClickNextButton();
//        	  Steps.SelectServers();
//        	  Steps.ClickAddButton();
//        	  Steps.ClickNextButton();
//        	  Steps.ClickFinishButton();
//        	  Steps.VerifyWindowsUserAdded();
//        	  //Steps.ClickWindowsUserToDelete();
//        	  //Steps.DeleteAddedUser();
//			  AutomationSQLdm.Grooming_Modifications.Steps.ClickOnTools();
//        	  Steps.SelectSnoozeAlertMenuItem();
//        	  Steps.SetSnoozeAlertTime();
        	  AutomationSQLdm.Grooming_Modifications.Steps.ClickOnTools();
        	  Steps.VerifySnoozeAlertApplied();
        	} 
        	catch (Exception ex)
        	{
        		Validate.Fail(ex.Message);
        	}
        	return true;
        }
        
      
    }
}
