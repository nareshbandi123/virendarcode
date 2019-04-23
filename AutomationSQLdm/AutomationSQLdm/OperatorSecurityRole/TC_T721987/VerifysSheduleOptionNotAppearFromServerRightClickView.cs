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
namespace AutomationSQLdm.OperatorSecurityRole.TC_T721987
{
    /// <summary>
    /// Description of VerifysSheduleOptionNotAppearFromServerRightClickView.
    /// </summary>
    [TestModule("7C5115A7-E07E-481F-BEEC-6CF026A05A92", ModuleType.UserCode, 1)]
    public class VerifysSheduleOptionNotAppearFromServerRightClickView : BaseClass,  ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifysSheduleOptionNotAppearFromServerRightClickView()
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
        	  
//        	  //Login DM with newly created SQL User
        	  Steps.ConnectDMRepo(Constants.SqlUser);
        	  Steps.ClickServersInLeftPane();
			  Steps.RightClickMonitoredServer();
        	  Steps.ClickMaintainceModeContextMenu();
        	  Steps.VerifyMaintainceModeContextMenuItems_1(); 
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
