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
            // I den h�r test s� skickar jag en lista av produkter som kommer skickas till en fake databas f�r att returnera data. Efter det s� skickas data till HomeController och p� homecontroller s� kallar jag p� en metod och kollar ifall i databasen finns en produkt som finns p� section D om den finns s� ska den "skriva ut" det p� html sidan.

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
