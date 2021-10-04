using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Text;

namespace AjioAutomation
{
    class ReportClass
    {
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentReports extent;

        public static ExtentReports Report()
        {
            if (extent == null)
            {
                string reportPath = @"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\Report\Report.html";
                htmlReporter = new ExtentHtmlReporter(reportPath);
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
                extent.AddSystemInfo("OS", "Windows");
                extent.AddSystemInfo("UserName", "girish");
                extent.AddSystemInfo("ProviderName", "girish");
                extent.AddSystemInfo("Domain", "QA");
                extent.AddSystemInfo("ProjectName", "Ajio Automation");

                string conifgPath = @"C:\Users\girish.v\source\repos\AjioAutomation\AjioAutomation\report.xml";
                htmlReporter.LoadConfig(conifgPath);
            }
            return extent;
        }
    }
}
