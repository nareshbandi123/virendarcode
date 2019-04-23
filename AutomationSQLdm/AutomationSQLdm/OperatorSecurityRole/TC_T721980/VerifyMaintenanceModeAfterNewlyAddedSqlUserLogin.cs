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

namespace AutomationSQLdm.OperatorSecurityRole.TC_T721980
{
    /// <summary>
    /// Description of VerifyMaintenanceModeAfterSqlUserLogin.
    /// </summary>
    [TestModule("A58D8F56-E8CF-4170-91F8-1062234A3964", ModuleType.UserCode, 1)]
    public class VerifyMaintenanceModeAfterNewlyAddedSqlUserLogin : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifyMaintenanceModeAfterNewlyAddedSqlUserLogin()
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
//        	  Steps.EnterDomianUserName(Constants.NewSqlUser);
//        	  Steps.SelectSqlAuthentication();
//        	  Steps.ClickNextButton();
//        	  Steps.ClickOptionBtn_ViewDataAcknowledgwAlarm();
//        	  Steps.ClickNextButton();
//        	  Steps.SelectServers();
//        	  Steps.ClickAddButton();
//        	  Steps.ClickNextButton();
//        	  Steps.ClickFinishButton();
//        	  Steps.VerifySqlUserAdded();
        	  
//        	  //Login DM with newly created SQL User
        	  Steps.ConnectDMRepo(Constants.SqlUser);
        	  
        	  AutomationSQLdm.Grooming_Modifications.Steps.ClickOnTools();
        	  Steps.ClickMaintainceModeMenuItem();
        	  Steps.VerifyMaintainceModeMenuItems();

        	  Steps.EnableDisableMaintainceModeFromMenuItem(Constants.strEnable);
        	  
//        	  AutomationSQLdm.Grooming_Modifications.Steps.ClickOnTools();
//        	  Steps.ClickMaintainceModeMenuItem();
        	  
//        	  Steps.EnableDisableMaintainceModeFromMenuItem(Constants.strEnable);
        	  Steps.VerifyMaintainceModeMenuItemIsApplied();
        	  
        	  AutomationSQLdm.Grooming_Modifications.Steps.ClickOnTools();
        	  Steps.ClickMaintainceModeMenuItem();
        	  Steps.EnableDisableMaintainceModeFromMenuItem(Constants.strDisable);
        	  Steps.VerifyMaintainceModeMenuItemIsApplied();
        	  
        	} 
        	catch (Exception ex)
        	{
        		Validate.Fail(ex.Message);
        	}
        	finally
        	{
        		Steps.ConnectDMRepo(Constants.WindowsUser);
        		Steps.ClickAdministration();
        		Steps.ClickSqlUserToDelete();
        	    Steps.DeleteAddedUser();
        	}
        	return true;
        }
        
      
    }
}
