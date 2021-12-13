using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace selenium_webdriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inpUser = "LoginControl1_txtusername";
            string inpPassword = "LoginControl1_txtpassword";
            string btnDangNhap = "LoginControl1_btnDangNhap";
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://thongtin.dainam.edu.vn/";
            IWebElement txtUsername = driver.FindElement(By.Id(inpUser));
            txtUsername.SendKeys("1251020103");
            IWebElement txtPassword = driver.FindElement(By.Id(inpPassword));
            txtPassword.SendKeys("Binh2311");
            IWebElement btnDang = driver.FindElement(By.Id(btnDangNhap));
            btnDang.Click();
        }
    }
}
