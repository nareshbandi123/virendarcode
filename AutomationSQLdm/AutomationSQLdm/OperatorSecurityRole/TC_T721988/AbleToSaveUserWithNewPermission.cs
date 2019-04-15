﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using WinForms = System.Windows.Forms;
using AutomationSQLdm.Base;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Configuration;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace AutomationSQLdm.OperatorSecurityRole.TC_T721988
{
    /// <summary>
    /// Description of AbleToSaveUserWithNewPermission.
    /// </summary>
    [TestModule("7539C170-42ED-4C80-85E6-9F46BEDD0342", ModuleType.UserCode, 1)]
    public class VerifySnoozeAlertsForFewMinutesForSqlUser : BaseClass, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VerifySnoozeAlertsForFewMinutesForSqlUser()
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
        	  //Steps.Cell_test();
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
        	  //Steps.VerifyViewDataAcknowledgwAlarmIsSelected(Constants.SqlUser);
        	  Steps.ChangePermission(Constants.SqlUser);
        	  Steps.VerifyPermissionChanged();
        	  Steps.DeleteAddedUser();
        	} 
        	catch (Exception ex)
        	{
        		Reports.ReportLog(ex.Message, Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
        	}
        	return true;
        }
    }
}



