using Prodajalna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prodajalna.Controllers
{
    public class ProductsController : ApiController
    {
        Product[] products = new Product[]
        {
new Product { Id = 1, Ime = "Paradižnikova juha", Kategorija = "Jestivne",
Cena = 1 },
new Product { Id = 2, Ime = "Žoga", Kategorija = "Igrače", Cena = 3.75M },
new Product { Id = 3, Ime = "Kladivo", Kategorija= "Železnina", Cena =
16.99M }
        };
        public IEnumerable<Product> GetAllProducts() //vrni vse produkte
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id) //vrni en izdelek
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
