
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

namespace AutomationSQLdm.TC_164838
{
    
    [TestModule("F2C1CE39-FB17-4F62-9C21-B6F4B28B10CE", ModuleType.UserCode, 1)]
    public class TopQueryPlanDurationMilliSeconds : ITestModule
    {
       
        public TopQueryPlanDurationMilliSeconds()
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
        		
        		Steps.ClickOnQueries();
        		Steps.ClickOnConfigQueryMonitor();
        	} 
        	catch (Exception)
        	{
        		
        	}
        	return true;
        }
    }
}
