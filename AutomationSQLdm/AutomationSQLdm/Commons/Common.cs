﻿
using System;
using AutomationSQLdm.Base;
using AutomationSQLdm.Commons;
using AutomationSQLdm.Configuration;
using AutomationSQLdm.Extensions;

namespace AutomationSQLdm.Commons
{
   
    public static class Common 
    {
        
       public static int ApplicationOpenWaitTime = 180000;
		
		public static void DeleteFile(string filename)
        {
        	try 
        	{
	        	if(System.IO.File.Exists(filename))
	        		System.IO.File.Delete(filename);
        	} 
        	catch (Exception e)
        	{
        		throw e;
        	}
        }
    }
}
