
using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Extensions;

namespace AutomationSQLdm.TC_164838
{
   
  
    public static class Steps 
    {
    	public static TC164838Repo repo = TC164838Repo.Instance;
		public static string TC_164838_Path = System.Configuration.ConfigurationManager.AppSettings["TC_164838_Path"].ToString();
        
       public static bool ClickOnQueries()
		{
			try 
			{
				repo.IderaSQLdmRepo.btnQueriesInfo.WaitForExists(new Ranorex.Duration(1000));
				repo.IderaSQLdmRepo.btnQueries.Click();
//				//repo.Application.F1MenuInfo.WaitForExists(new Ranorex.Duration(1000));
//				if (repo.Application.F1Menu.Checked) 
//					repo.Application.F1Menu.ClickThis();
			} 
			catch (Exception)
			{
				
			}
			return true;
		}
       
       public static bool ClickOnConfigQueryMonitor()
		{
			try 
			{
				repo.IderaSQLdmRepo.btnConfigQueryMonitorInfo.WaitForExists(new Ranorex.Duration(1000));
				repo.IderaSQLdmRepo.btnConfigQueryMonitor.ClickThis();
//				//repo.Application.F1MenuInfo.WaitForExists(new Ranorex.Duration(1000));
//				if (repo.Application.F1Menu.Checked) 
//					repo.Application.F1Menu.ClickThis();
			} 
			catch (Exception)
			{
				
			}
			return true;
		}
        
      
    }
}
