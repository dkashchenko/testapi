using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.DAL.Repository.Product
{
    interface IProductRepository
    {
        Task<IList<TestAPI.Model.Models.Product>> GetAllAsync();

        Task<TestAPI.Model.Models.Product> GetByIdAsync();

    }
}
