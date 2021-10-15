using ProiectMaster.Models.DTOs;
using ProiectMaster.Models.DTOs.VM;
using System.Collections.Generic;

namespace ProiectMaster.Models.Interfaces
{
    public interface IOrderService
    {

        IEnumerable<OrderVM1> GetAllProducts();
        OrderVM1 GetProduct(int id);
        void AddProduct(OrderVM1 dto);
        void UpdateProduct(int id, OrderVM1 dto);
        void DeleteProduct(int id);
        List<IdNameDto> GetProductTypes();
    }
}
