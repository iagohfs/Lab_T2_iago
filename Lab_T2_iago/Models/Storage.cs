using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_T2_iago.Models
{
    public class Storage : IStorage
    {
        // låtsas databas
        public List<Product> GetProducts()
        {
            var productList = new List<Product>();

            productList.Add(new Product("Text Adventure", "A", 1));
            productList.Add(new Product("Arrays", "A", 2));
            productList.Add(new Product("Functions", "", 3));
            productList.Add(new Product("Interfaces and Namespaces", "A", 4));
            productList.Add(new Product("WPF", "A", 5));
            productList.Add(new Product("Pub", "A", 6));
            productList.Add(new Product("SQl", "B", 1));
            productList.Add(new Product("Entity Framework", "B", 2));
            productList.Add(new Product("MongoDb", "B", 2));
            productList.Add(new Product("Azure Functions", "B", 3));
            productList.Add(new Product("Html CSS", "C", 1));
            productList.Add(new Product("JavaScript", "C", 2));
            productList.Add(new Product("Berras Bio", "C", 3));
            productList.Add(new Product("Quiz App", "C", 5));
            productList.Add(new Product("Projekt", "C", 4));
            productList.Add(new Product("Hemtenta", "C", 5));
            productList.Add(new Product("Labb T1", "D", 1));
            productList.Add(new Product("Labb T2", "D", 2));
            productList.Add(new Product("Hemtenta", "D", 3));

            return productList;
        }
    }
}
