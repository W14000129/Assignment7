using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Repository
{
    public interface ICategoryRepository
    {
		IEnumerable<Category> GetAll();
		Category Get(int id);
		Category Add(Category item);
		void Remove(int id);
		bool Update(Category item);
	}
}
