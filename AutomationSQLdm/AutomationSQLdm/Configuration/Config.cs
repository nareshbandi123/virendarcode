
using System;


namespace AutomationSQLdm.Configuration
{
 
    public static class Config 
    {
        public static string AppPath = System.Configuration.ConfigurationManager.AppSettings["APP_PATH"].ToString();
		public static int ProcessID;
		public static string TestCaseName;
		public static string WindowsUser = System.Configuration.ConfigurationManager.AppSettings["WindowsUser"].ToString();
		public static string WinUserPassword = System.Configuration.ConfigurationManager.AppSettings["WinUserPassword"].ToString();
    }
}
