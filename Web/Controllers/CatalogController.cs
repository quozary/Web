using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;

namespace ProjectName.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            var cars = new List<Car>
            {
                new Car
                {
                    Id = 1,
                    Name = "Toyota Crown",
                    Model = "XI (S170)",
                    Price = 210000,
                    Description = "Седан E-класса, задний и полный привод. Автомат. Бензиновые двигатели мощностью от 160 до 280 лошадиных сил",
                    Year = 2002,
                    Mileage = 200000,
                    ImageUrl = "/images/cars/car1.jpg"
                },
                new Car
                {
                    Id = 2,
                    Name = "Audi Q5",
                    Model = "II (FY)",
                    Price = 2850000,
                    Description = "Внедорожник 5 дв. D-класса, полный и передний привод. Робот, автомат и механика. Бензиновые, дизельные и гибридные двигатели мощностью от 136 до 367 лошадиных сил.",
                    Year = 2018,
                    Mileage = 118000,
                    ImageUrl = "/images/cars/car2.jpg"
                },
                new Car
                {
                    Id = 3,
                    Name = "Lada Vesta",
                    Model = "I Рестайлинг (NG)",
                    Price = 2364000,
                    Description = "Универсал 5 дв. SW Sportline B-класса, передний привод. Механика. Бензиновые двигатели мощностью 118 лошадиных сил.",
                    Year = 2024,
                    Mileage = 0,
                    ImageUrl = "/images/cars/car3.jpg"
                },
                new Car
                {
                    Id = 4,
                    Name = "Honda Prelude",
                    Model = "V",
                    Price = 680000,
                    Description = "Купе C-класса, передний привод. Механика и автомат. Бензиновые двигатели мощностью от 133 до 220 лошадиных сил.",
                    Year = 1999,
                    Mileage = 86000,
                    ImageUrl = "/images/cars/car4.jpg"
                },
                new Car
                {
                    Id = 5,
                    Name = "Toyota Supra",
                    Model = "V (A90)",
                    Price = 6650000,
                    Description = "Купе S-класса, задний привод. Автомат и механика. Бензиновые двигатели мощностью от 197 до 387 лошадиных сил.",
                    Year = 2019,
                    Mileage = 15200,
                    ImageUrl = "/images/cars/car5.jpg"
                },
                new Car
                {
                    Id = 6,
                    Name = "Ford Mustang",
                    Model = "I",
                    Price = 9950000,
                    Description = "Купе S-класса, задний привод. Механика и автомат. Бензиновые двигатели мощностью от 102 до 390 лошадиных сил.",
                    Year = 1967,
                    Mileage = 44676,
                    ImageUrl = "/images/cars/car6.jpg"
                },
                new Car
                {
                    Id = 7,
                    Name = "Mercedes-Benz SLS AMG",
                    Model = "I",
                    Price = 30500000,
                    Description = "Купе S-класса, задний привод. Робот. Бензиновые двигатели мощностью от 571 до 591 лошадиных сил.",
                    Year = 2010,
                    Mileage = 14300,
                    ImageUrl = "/images/cars/car7.jpg"
                }


            };

            return View(cars);
        }
    }
}
