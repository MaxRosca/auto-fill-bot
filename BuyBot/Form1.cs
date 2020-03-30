using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace BuyBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            IWebDriver driver = new ChromeDriver(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName);

            driver.Navigate().GoToUrl(@"https://www.g2g.com/sell/manage?service=18&game=22666");

            driver.FindElement(By.XPath("//*[@id='c2c_4753988']/td[2]/div/div[2]/span[2]/a")).Click();


        }

    }
}
