using Microsoft.AspNetCore.Mvc;

namespace DemoStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataContext _dataContext;
        public ProductController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult ProductList()
        {
            var values = _dataContext.Products.ToList();
            return View(values);
        }
    }
}
