using System;
using Godot;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestFolder
{
    class Program : Node
    {
        String test_url = "https://www.google.com";
        RichTextLabel testConsole;


        public override void _Ready()
        {
            testConsole = (RichTextLabel)GetNode("Control/MarginContainer6/RichTextLabel");
        }

        public void test_One()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = test_url;

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(12));

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[name = 'q']")));

            searchText.SendKeys("Godot game engine" + Keys.Enter);

            IWebElement godotWebPage = driver.FindElement(By.ClassName("LC20lb"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("LC20lb")));

            godotWebPage.Click();

            IWebElement downloadPage = driver.FindElement(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a")));

            downloadPage.Click();

            System.Threading.Thread.Sleep(6000);

            GD.Print("Test 1 Passed");
            print_To_Test_Console("Test 1 Passed");

            driver.Quit();
        }


        public void test_Two()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = test_url;

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(12));

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[name = 'q']")));


            searchText.SendKeys("Godot game engine" + Keys.Enter);


            IWebElement godotWebPage = driver.FindElement(By.ClassName("LC20lb"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("LC20lb")));


            godotWebPage.Click();

            IWebElement downloadPage = driver.FindElement(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a")));

            downloadPage.Click();

            System.Threading.Thread.Sleep(6000);

            GD.Print("Test 2 Passed");
            print_To_Test_Console("Test 2 Passed");


            driver.Quit();
        }

        public void test_Three()
        {
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = test_url;

            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(12));

            IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector("[name = 'q']")));


            searchText.SendKeys("Godot game engine" + Keys.Enter);


            IWebElement godotWebPage = driver.FindElement(By.ClassName("LC20lb"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("LC20lb")));


            godotWebPage.Click();

            IWebElement downloadPage = driver.FindElement(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/header/div/nav/ul[2]/li[1]/a")));

            downloadPage.Click();

            System.Threading.Thread.Sleep(6000);

            GD.Print("Test 3 Passed");
            print_To_Test_Console("Test 3 Passed");

            driver.Quit();
        }

        private void print_To_Test_Console(String str){
            testConsole.AddText($"{str}\n");
        }

        private void _on_TestOne_pressed(){
        System.Threading.Thread test1 = new System.Threading.Thread(() => this.test_One());
        test1.Start();
        }


        private void _on_TestTwo_pressed(){
        System.Threading.Thread test2 = new System.Threading.Thread(() => this.test_Two());
        test2.Start();
        }

        private void _on_TestThree_pressed(){
        System.Threading.Thread test3 = new System.Threading.Thread(() => this.test_Three());
        test3.Start();
        }

        private void _on_AllTests_pressed(){
        System.Threading.Thread test1 = new System.Threading.Thread(() => this.test_One());
        test1.Start();
        System.Threading.Thread test2 = new System.Threading.Thread(() => this.test_Two());
        test2.Start();
        System.Threading.Thread test3 = new System.Threading.Thread(() => this.test_Three());
        test3.Start();

        }

        private void _on_Quit_pressed(){
            GetTree().Quit();
        }

        private void _on_DeleteLog_pressed(){
            testConsole.Clear();
        }

    }
}