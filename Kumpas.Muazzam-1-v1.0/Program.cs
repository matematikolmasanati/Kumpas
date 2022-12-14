using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Windows.Forms;

namespace Kumpas.Muazzam_1_v1._0
{
    class Program
    {
        
        static void Main()
        {
            var query = System.IO.File.ReadAllLines("data.txt")[0]; 
            var driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl($"https://www.youtube.com/results?search_query={query}");
            Thread.Sleep(500);
            var randomVideo = new Random().Next(1, 10);
            var video = driver.FindElement(By.XPath(
                $"/html/body/ytd-app/div[1]/ytd-page-manager/ytd-search/div[1]/ytd-two-column-search-results-renderer/div[2]/div/ytd-section-list-renderer/div[2]/ytd-item-section-renderer/div[3]/ytd-video-renderer[{randomVideo}]"));
            video.Click();
            Thread.Sleep(500);
            driver.SwitchTo().ActiveElement().SendKeys("m");
            driver.SwitchTo().ActiveElement().SendKeys("f");
           Application.Run();
        }
    }
}
