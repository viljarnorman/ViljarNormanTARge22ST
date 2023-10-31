using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using OpenQA.Selenium.Support.UI;
using System.Collections.Generic;
using OpenQA.Selenium.Interactions;
using System.Collections.ObjectModel;
using System.Threading;

namespace ViljarNormanTARge22ST
{
    public class Tests
    {

        IWebDriver driver;
        String test_url = "https://viljarnorman22.thkit.ee/";
        private readonly Random _random = new Random();

        [SetUp]
        public void start_browser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }
        // Testing HOME link
        [Test]
        public void test_page1()
        {
            driver.Url = test_url;
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-13\"]"));
            element.Click();
            Thread.Sleep(5000);
        }

        // Testing BLOG link
        [Test]
        public void test_page2()
        {
            driver.Url = test_url;
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-584\"]"));
            element.Click();
            Thread.Sleep(3000);
        }
        // Testing ABOUT link 
        [Test]
        public void test_page3()
        {
            driver.Url = test_url;                           
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"menu-item-12\"]"));
            element.Click();
            Thread.Sleep(2500);
        }

        //  Testing broken CONTACT link 
        [Test]
        public void test_page4()
        {
            driver.Url = test_url;
            Thread.Sleep(2500);
            IWebElement element = driver.FindElement(By.XPath("//*[@id=\"meny-item-150\"]")); // correct path: //*[@id="menu-item-150"]
            element.Click();
            Thread.Sleep(2500);
        }



        [TearDown]
        public void close_Browser()
        {
            driver.Close();
        }
    }
}