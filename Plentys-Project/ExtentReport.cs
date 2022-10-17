
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Configuration;

namespace Plentys_Project
{
    public class ExtentReport
    {
        public static ExtentReports extentReports;
        public static ExtentTest exParentTest;
        public static ExtentTest exChildTest;
        public static string dirpath;

        public static void LogReport(string testcase)
        {
            extentReports = new ExtentReports();
            dirpath = @"C:\Users\HP\source\repos\Plentys-Project\Plentys-Project\extentReport" + testcase + ".html";
            ExtentV3HtmlReporter htmlReporter = new ExtentV3HtmlReporter(dirpath);
            //ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(dirpath);
            htmlReporter.Config.Theme = Theme.Dark;
            extentReports.AttachReporter(htmlReporter);
        }
    }
}
