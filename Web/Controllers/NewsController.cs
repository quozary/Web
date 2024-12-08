using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;
using System.Collections.Generic;

namespace ProjectName.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            // Пример списка новостей
            var news = new List<News>
            {
                new News
                {
                    Id = 1,
                    Title = "Новое поступление автомобилей Toyota",
                    ShortDescription = "Поступление новых моделей Toyota RAV4 и Corolla.",
                    ImageUrl = "/images/news/toyota-news.jpeg"
                },
                new News
                {
                    Id = 2,
                    Title = "Скидки на автомобили Lada!",
                    ShortDescription = "Специальные условия на покупку Lada Granta и Vesta.",
                    ImageUrl = "/images/news/lada-news.jpeg"
                },
                new News
                {
                    Id = 3,
                    Title = "Новый сервисный центр Subaru",
                    ShortDescription = "В Красноярске открыли новый сервисный центр для владельцев Subaru.",
                    ImageUrl = "/images/news/subaru-news.jpeg"
                },
                new News
                {
                    Id = 4,
                    Title = "У автосалона Гаечка новое приложение",
                    ShortDescription = "Мы создали удобное приложение для наших клиентов",
                    ImageUrl = "/images/news/gaechka.png"
                },
                new News
                {
                    Id = 5,
                    Title = "Мы открылись!",
                    ShortDescription = "Открылся наш сервисный центр на Затонской 666",
                    ImageUrl = "/images/news/zaton.jpg"
                }

            };

            return View(news);
        }

        public IActionResult Details(int id)
        {
            // Пример получения данных для одной новости
            var newsItem = new News
            {
                Id = id,
                Title = "Новость",
                FullDescription = "Здесь будет текст полной статьи.",
                ImageUrl = "/images/news/example.jpg"
            };

            return View(newsItem);
        }
    }
}
