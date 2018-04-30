using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Repository
{
    public interface INotesRepository
    {
		IEnumerable<Notes> GetAll();
		Notes Get(int id);
		Notes Add(Notes item);
		void Remove(int id);
		bool Update(Notes item);
	}
}
