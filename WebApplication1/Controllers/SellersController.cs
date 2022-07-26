using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class SellersController : Controller
    {
        ISellerService _sellerService = null;
        public SellersController(ISellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        public List<Seller> GetSellers(string name)
        {
            return _sellerService.GetSellers(name);
        }

        public void SaveOrUpdate(Seller seller)
        {
            _sellerService.SaveOrUpdate(seller);
        }
        public void Delete(int sellerId)
        {
            _sellerService.Delete(sellerId);
        }
    }
}
