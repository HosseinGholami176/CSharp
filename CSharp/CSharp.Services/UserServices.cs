using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Models;
namespace CSharp.Services
{
    public class UserServices : IDisposable
    {

        private User[] list = new User[1000];
        private int index = 0;

        public void Add(User user)
        {
            list[index++] = user;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        
       
    }
}
