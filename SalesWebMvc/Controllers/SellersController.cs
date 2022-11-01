using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SellersController : Controller
    {
        //dependency injection
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var sellersList = _sellerService.FindlAll(); 
            return View(sellersList);
        }

        public IActionResult Create()
        {
            return View();
        }

        //adding new seller
        [HttpPost] //to send post requisition
        [ValidateAntiForgeryToken] //antihack?
        public IActionResult Create(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }
    }
}
