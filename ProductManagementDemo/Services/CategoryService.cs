using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Repositories;

namespace Services
{
    public class CategoryService : ICatergoryService
    {
        private readonly ICatergoryService icatergoryService;


        public CategoryService()
        {
            icatergoryService = new CategoryRepository();
        }
        public List<Category> GetCategories()
        {
            return icatergoryService.GetCategories();
        }
    }
}
