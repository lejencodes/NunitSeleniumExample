using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NunitExample
{
    [TestFixture(1200)]
    public class Tests
    {
        private IWebDriver driver_;
        private int width_;

        public Tests(int width)
        {
            width_ = width;
        }
        [SetUp]
        public void Setup()
        {
            driver_ = new ChromeDriver();
            driver_.Manage().Window.Size = new System.Drawing.Size(width_, 1000);
        }

        [TearDown]
        public void TearDown()
        {
            driver_.Quit();
        }

        [Test]
        public void Test1()
        {
            driver_.Url = "https://github.com";
            driver_.FindElement(By.LinkText("Enterprise")).Click();
            driver_.FindElement(By.LinkText("Team")).Click();

        }

    }
}