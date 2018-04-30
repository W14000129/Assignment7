using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models.Repository
{
    public interface IUsersRepository
    {
		IEnumerable<Users> GetAll();
		Users Get(int id);
		Users Add(Users item);
		void Remove(int id);
		bool Update(Users item);

	}
}
