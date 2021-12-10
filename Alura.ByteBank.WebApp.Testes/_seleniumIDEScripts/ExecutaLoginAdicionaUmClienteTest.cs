// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;
public class SuiteTests : IDisposable {
  public IWebDriver driver {get; private set;}
  public IDictionary<String, Object> vars {get; private set;}
  public IJavaScriptExecutor js {get; private set;}
  public SuiteTests()
  {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<String, Object>();
  }
  public void Dispose()
  {
    driver.Quit();
  }
  [Fact]
  public void ExecutaLoginAdicionaUmCliente() {
    driver.Navigate().GoToUrl("https://localhost:44309/");
    driver.Manage().Window.Size = new System.Drawing.Size(1309, 712);
    driver.FindElement(By.LinkText("Login")).Click();
    driver.FindElement(By.Id("Email")).Click();
    driver.FindElement(By.Id("Email")).SendKeys("andre@email.com");
    driver.FindElement(By.Id("Senha")).Click();
    driver.FindElement(By.Id("Senha")).SendKeys("senha01");
    driver.FindElement(By.Id("btn-logar")).Click();
    driver.FindElement(By.Id("clientes")).Click();
    driver.FindElement(By.LinkText("Adicionar Cliente")).Click();
    driver.FindElement(By.Id("Identificador")).Click();
    driver.FindElement(By.Id("Identificador")).SendKeys("2df71922-ca7d-4d43-b142-0767b32f822a");
    driver.FindElement(By.Id("CPF")).Click();
    driver.FindElement(By.Id("CPF")).SendKeys("69981034096");
    driver.FindElement(By.Id("Nome")).Click();
    driver.FindElement(By.Id("Nome")).SendKeys("Fulano de Tal");
    driver.FindElement(By.Id("Profissao")).Click();
    driver.FindElement(By.Id("Profissao")).SendKeys("DBA");
    driver.FindElement(By.CssSelector(".btn-primary")).Click();
    driver.FindElement(By.Id("home")).Click();
  }
}
