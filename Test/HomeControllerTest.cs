using Lab_T2_iago;
using Lab_T2_iago.Controllers;
using Lab_T2_iago.Models;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using FluentAssertions;

namespace Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void Test1()
        {
            // I den här test så skickar jag en lista av produkter som kommer skickas till en fake databas för att returnera data. Efter det så skickas data till HomeController och på homecontroller så kallar jag på en metod och kollar ifall i databasen finns en produkt som finns på section D om den finns så ska den "skriva ut" det på html sidan.

            var listOfProducts = new List<Product>();
            listOfProducts.Add(new Product("Labb T2", "D", 2));

            Mock<IStorage> mockStorage = new Mock<IStorage>();
            mockStorage.Setup(s => s.GetProducts()).Returns(listOfProducts);

            var homeController = new HomeController(mockStorage.Object);

            bool IsPrintingOutData = homeController.Are_There_Products_That_Are_In_The_Selected_Section("D");

            Assert.True(IsPrintingOutData);

        }
    }
}
