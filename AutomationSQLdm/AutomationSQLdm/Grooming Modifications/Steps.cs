using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Data.SqlClient;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

using AutomationSQLdm.Commons;
using AutomationSQLdm.Extensions;
using AutomationSQLdm.Configuration;


namespace AutomationSQLdm.Grooming_Modifications
{
    [TestModule("5832C0D8-1C2E-4CBF-B426-859040845D52", ModuleType.UserCode, 1)]
    public static class Steps 
    {
   		public static GroomingRepo repo = GroomingRepo.Instance;
		public const string GROOMING_MENU = @"/contextmenu[@processname='SQLdmDesktopClient']/menuitem[@automationid='menuToolsGrooming']";
		
		//public const string MaintenanceModeMenu = @"/contextmenu[@processname='SQLdmDesktopClient']/menuitem[@accessiblename='Maintenance Mode']";
        public static void ClickOnTools()
		{
			try 
			{
				repo.Application.ToolsInfo.WaitForExists(new Duration(1000000));
				repo.Application.Tools.Click();
				Reports.ReportLog("ClickOnTools", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : ClickOnTools :" + ex.Message);
			}
		}
        
        public static void SelectGroomingOption()
		{ 
			try
			{
				Ranorex.MenuItem groomingMenuItem = GROOMING_MENU;
				if(groomingMenuItem != null) groomingMenuItem.ClickThis();
				Reports.ReportLog("SelectGroomingOption", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			}
			catch (Exception ex)
			{
				throw new Exception("Failed : SelectGroomingOption :" + ex.Message);
			}
		}

        public static void VerifyAggregateforecastingValue()
		{
			try 
			{
				repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
				if (repo.GroomingOptionWindow.AggregateTextboxInfo.Exists())
					Reports.ReportLog("Verify Aggregate forecasting data to daily records after is Displaying: " + repo.GroomingOptionWindow.AggregateTextbox.TextValue , Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
					Reports.ReportLog("Verify Aggregate forecasting data to daily records after", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyAggregateforecastingValue :" + ex.Message);
			}
		}
        
        public static void VerifyGroomforecastingValue()
		{
			try 
			{
				repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
				if (repo.GroomingOptionWindow.GroomForecastTextboxInfo.Exists())
					
					Reports.ReportLog("Groom forecasting data to daily records after is Displaying : " + repo.GroomingOptionWindow.GroomForecastTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
					Reports.ReportLog("Groom forecasting data to daily records after", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyAggregateforecastingValue :" + ex.Message);
			}
		}

 		public static void ClickOnCancel()
		{
			try 
			{	
				repo.GroomingOptionWindow.CancelButtonInfo.WaitForExists(new Duration(1000000));
				repo.GroomingOptionWindow.CancelButton.Click();
				Reports.ReportLog("Click On Cancel Button", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : ClickOnCancel :" + ex.Message);
			}
		}
 		
 		public static void VerifyQueryIsRemovedFromText()
		{
			try 
			{
				//Verify Query is Removed from The Current time on the repository
				repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
				
				if (repo.GroomingOptionWindow.GroomForecastTextboxInfo.Exists())
					
					Reports.ReportLog("The Current time on the repository is Displaying : " + repo.GroomingOptionWindow.GroomForecastTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
					Reports.ReportLog("Query is not Removed from The Current time on the repository", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyQueryIsRemovedFromText :" + ex.Message);
			}
		}
 		 
 		public static void VerifyDefaultMetricsDataAs90Days()
		{
			try 
			{
				repo.GroomingOptionWindow.SelfInfo.WaitForExists(new Duration(1000000));
				
				Validate.AttributeContains(repo.GroomingOptionWindow.GroomStandardMetrixAndBaselineInfo, "Text", "90");
				
				if (repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue.Equals("90") )
					Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : " + repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				else
					Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
			} 
			catch (Exception ex)
			{
				throw new Exception("Failed : VerifyDefaultMetricsDataAs90Days :" + ex.Message);
			}
		}
 		
 		public static void VerifyFieldsAreEditable()
 		{
 			if(repo.GroomingOptionWindow.GroomingOnceDailyAt.Enabled.Equals(true))
    			Reports.ReportLog("GroomingOnceDailyAt and baseline is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("GroomingOnceDailyAt is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomingOnceDailyAtInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.AggregaionOnceDailyAt.Enabled.Equals(true))
    			Reports.ReportLog("AggregaionOnceDailyAt and baseline is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("AggregaionOnceDailyAt is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.AggregaionOnceDailyAtInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.Enabled.Equals(true))
    			Reports.ReportLog("Groom standard Metrics and baseline is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Groom standard Metrics and baseline is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomStandardMetrixAndBaselineInfo, "Enabled", "true");
			}
			
			
			if(repo.GroomingOptionWindow.GroomSessionsQueries.Enabled.Equals(true))
    			Reports.ReportLog("Groom Sessions Queries is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Groom Sessions Queries is Not Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomSessionsQueriesInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.GroomInactiveAlert.Enabled.Equals(true))
				Reports.ReportLog("Groom Inactive Alert is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Groom Inactive Alert is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomInactiveAlertInfo,  "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.AggregateQueryDataInto.Enabled.Equals(true))
				Reports.ReportLog("Aggregate Query Data Into is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Aggregate Query Data Into is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.AggregateQueryDataIntoInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.GroomChangeLog.Enabled.Equals(true))
				Reports.ReportLog("GroomChangeLog is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("GroomChangeLog is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomChangeLogInfo, "Enabled", "true");
			}

			if(repo.GroomingOptionWindow.GroomPrescriptiveAnalysis.Enabled.Equals(true))
				Reports.ReportLog("GroomPrescriptiveAnalysis is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("GroomPrescriptiveAnalysis is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomPrescriptiveAnalysisInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.AggregateTextbox.Enabled.Equals(true))
				Reports.ReportLog("Aggregate Forcasting data is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Aggregate Forcasting data is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.AggregateTextboxInfo, "Enabled", "true");
			}
			
			if(repo.GroomingOptionWindow.GroomForecastTextbox.Enabled.Equals(true))
				Reports.ReportLog("Groom Forecasting is Enabled", Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
			else
			{
				Reports.ReportLog("Groom Forecasting is Not Enabled", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
				Validate.AttributeNotEqual(repo.GroomingOptionWindow.GroomForecastTextboxInfo, "Enabled", "true");
			}
 		}
 		
// 		public static void VerifyValuesInRepositoryTable()
//		{
//			try 
//			{
//				string query = "select * from RepositoryInfo";
//	        	DataTable dt = DBOperations.GetData(query);
//	        	if(dt != null && dt.Rows.Count > 0)
//	        	{   
//	        		string GroomMetricsValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[0]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		string GroomQueryAggregationValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[1]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		string GroomAlertsValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[2]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		string GroomPrescriptiveAnalysisValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[3]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		string AggregateForecastingValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[4]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		string GroomForecastingValue = dt.Select("Name='"+ Constants.RepositoryInfo_TableCols[5]+"'")[0][Constants.RepositoryInfo_ColName].ToString();
//	        		
//	        		if(repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue.Equals(GroomMetricsValue))
//	        			Reports.ReportLog("Groom standard Metrics and baseline Data is Displaying : " + repo.GroomingOptionWindow.GroomStandardMetrixAndBaseline.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog("Groom standard Metrics value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomStandardMetrixAndBaselineInfo, "Text", GroomMetricsValue);
//					}
//					
//					if(repo.GroomingOptionWindow.GroomInactiveAlert.TextValue.Equals(GroomQueryAggregationValue))
//	        			Reports.ReportLog("Groom Inactive Alert is Displaying : " + repo.GroomingOptionWindow.GroomInactiveAlert.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog("Groom Inactive Alert value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomInactiveAlertInfo, "Text", GroomQueryAggregationValue);
//					}
//					
//					if(repo.GroomingOptionWindow.AggregateQueryDataInto.TextValue.Equals(GroomAlertsValue))
//						Reports.ReportLog(" Aggregate Query Data Into is Displaying : " + repo.GroomingOptionWindow.AggregateQueryDataInto.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog(" Aggregat eQuery Data Into value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.AggregateQueryDataIntoInfo, "Text", GroomAlertsValue);
//					}
//
//					if(repo.GroomingOptionWindow.GroomPrescriptiveAnalysis.TextValue.Equals(GroomPrescriptiveAnalysisValue))
//	        			Reports.ReportLog(" GroomPrescriptiveAnalysis is Displaying : " + repo.GroomingOptionWindow.GroomPrescriptiveAnalysis.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog(" GroomPrescriptiveAnalysis value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomPrescriptiveAnalysisInfo, "Text", GroomPrescriptiveAnalysisValue);
//					}
//					
//					if(repo.GroomingOptionWindow.AggregateTextbox.TextValue.Equals(AggregateForecastingValue))
//	        			Reports.ReportLog(" Aggregate Forcasting data is Displaying : " + repo.GroomingOptionWindow.AggregateTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog(" Aggregate Forcasting data value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.AggregateTextboxInfo, "Text", AggregateForecastingValue);
//					}
//					
//					if(repo.GroomingOptionWindow.GroomForecastTextbox.TextValue.Equals(GroomForecastingValue))
//	        			Reports.ReportLog(" Groom Forecasting is Displaying : " + repo.GroomingOptionWindow.GroomForecastTextbox.TextValue, Reports.SQLdmReportLevel.Success, null, Config.TestCaseName);
//					else
//					{
//						Reports.ReportLog(" Groom Forecasting value not matching with DB value : ", Reports.SQLdmReportLevel.Info, null, Config.TestCaseName);
//						Validate.AttributeEqual(repo.GroomingOptionWindow.GroomForecastTextboxInfo, "Text", GroomForecastingValue);
//					}
//	        	}
//	        		
//	        	else
//	        		Reports.ReportLog("Records is not present in RepositoryInfo Table " , Reports.SQLdmReportLevel.Fail, null, Config.TestCaseName);
//	        	
//	        	
//			} 
//			catch (Exception ex)
//			{
//				throw new Exception("Failed : VerifyValuesInRepositoryTable :" + ex.Message);
//			}
//		}
 		
    }
}
