using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_T2_iago.Models
{
    public interface IStorage
    {
        List<Product> GetProducts();
    }
}
