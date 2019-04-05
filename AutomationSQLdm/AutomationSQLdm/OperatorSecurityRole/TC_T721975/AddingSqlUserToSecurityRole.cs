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

namespace AutomationSQLdm.OperatorSecurityRole.TC_T721975
{
    /// <summary>
    /// Description of AddingSqlUserToSecurityRole.
    /// </summary>
    [TestModule("498B78B1-B6DF-4253-8760-F2436276D963", ModuleType.UserCode, 1)]
    public class AddingSqlUserToSecurityRole : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddingSqlUserToSecurityRole()
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
        	  Steps.ClickSqlUserToDelete();
        	  Steps.DeleteAddedUser();
        	} 
        	catch (Exception ex)
        	{
        		Validate.Fail(ex.Message);
        	}
        	return true;
        }
        
      
    }
}
