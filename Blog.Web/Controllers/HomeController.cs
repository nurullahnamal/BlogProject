using Blog.Service.Services.Abstractions;
using Blog.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;

        public HomeController(ILogger<HomeController> logger,IArticleService articleService)
        {
            _logger = logger;
            this.articleService = articleService;
        }


        public async Task< IActionResult> Index()
        {
            var article=await articleService.GetAllArticlesWithCategoryNonDeletedAsync();
            return View(article);
        }

        
    }
}