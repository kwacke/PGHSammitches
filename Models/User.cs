using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PittsburghSammitches.Models
{
    public class User
    {
        int User_ID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }  
        string Email { get; set; }
        string Password { get; set; }
        string Username { get; set; }

    }
}
