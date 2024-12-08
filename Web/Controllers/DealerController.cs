using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectName.Controllers
{
    public class DealerController : Controller
    {
        public IActionResult Index()
        {
            // Список дилеров с логотипами
            var dealers = new List<Dealer>
            {
                new Dealer
                {
                    Name = "Audi",
                    LogoUrl = "/images/dealers/audi.png",
                    Description = "Официальный дилер автомобилей Audi."
                },
                new Dealer
                {
                    Name = "Ford",
                    LogoUrl = "/images/dealers/ford.png",
                    Description = "Официальный дилер автомобилей Ford."
                },
                new Dealer
                {
                    Name = "Honda",
                    LogoUrl = "/images/dealers/honda.png",
                    Description = "Официальный дилер автомобилей Honda."
                },
                new Dealer
                {
                    Name = "Lada",
                    LogoUrl = "/images/dealers/lada.png",
                    Description = "Официальный дилер автомобилей Lada."
                },
                new Dealer
                {
                    Name = "Mercedes",
                    LogoUrl = "/images/dealers/mercedes.png",
                    Description = "Официальный дилер автомобилей Mercedes-Benz."
                },
                new Dealer
                {
                    Name = "Subaru",
                    LogoUrl = "/images/dealers/subaru.png",
                    Description = "Официальный дилер автомобилей Subaru."
                },
                new Dealer
                {
                    Name = "Toyota",
                    LogoUrl = "/images/dealers/toyota.png",
                    Description = "Официальный дилер автомобилей Toyota."
                },
                new Dealer
                {
                    Name = "UAZ",
                    LogoUrl = "/images/dealers/uaz.png",
                    Description = "Официальный дилер автомобилей УАЗ."
                },
                new Dealer
                {
                    Name = "Volkswagen",
                    LogoUrl = "/images/dealers/volkswagen.png",
                    Description = "Официальный дилер автомобилей Volkswagen."
                }
            };

            // Упорядочиваем дилеров по имени
            dealers = dealers.OrderBy(d => d.Name).ToList();

            return View(dealers);
        }
    }
}
