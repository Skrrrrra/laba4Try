using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4Try
{
    public abstract class User
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string password
        {
            get
            {
                return username;
            }
            set
            {
                if(password.Length <8)
                {
                    Console.WriteLine("Password must be more than 8 symbols");
                    password = Console.ReadLine();
                }
            }
        }
        protected virtual bool CanChange()
        {
            return false;
        }
    }
}
