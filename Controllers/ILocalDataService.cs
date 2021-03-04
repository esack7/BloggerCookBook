using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Controllers
{
    public interface ILocalDataService
    {
        bool Initialize();
        void Close();
        void AddUser(User newUser);
        List<User> GetAllUsers();
    }
}
