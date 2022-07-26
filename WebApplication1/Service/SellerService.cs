using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Service
{
    public class SellerService : ISellerService
    {
        DatabaseContext _dbContext = null;

        public SellerService(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Delete(int sellerId)
        {
            _dbContext.Database.ExecuteSqlRaw($"DeleteSeller {sellerId} ");

            var sellers = _dbContext.Sellers.ToList();
        }

        public List<Seller> GetSellers(string name)
        {
            var sellers = _dbContext.Sellers.FromSqlRaw($"GetSellers {name}").ToList();
            return sellers;
        }

        public void SaveOrUpdate(Seller seller)
        {
            _dbContext.Database.ExecuteSqlRaw($"SaveOrUpdateSeller {seller.SellerId},{seller.Name},{seller.Email},{seller.Fax},{seller.Age},{seller.Phone}");

            var sellers = _dbContext.Sellers.ToList();


        }
    }
}
