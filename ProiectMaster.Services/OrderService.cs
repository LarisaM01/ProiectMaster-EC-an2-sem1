using ProiectMaster.Models.DTOs;
using ProiectMaster.Models.DTOs.VM;
using ProiectMaster.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Services
{
    public class OrderService : IOrderService
    {
        public void AddProduct(OrderVM1 dto)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderVM1> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public OrderVM1 GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<IdNameDto> GetProductTypes()
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(int id, OrderVM1 dto)
        {
            throw new NotImplementedException();
        }
    }
}
