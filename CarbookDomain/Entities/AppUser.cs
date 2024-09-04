using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarbookDomain.Entities
{
	public class AppUser
	{
        public int AppUserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int AppRoleId { get; set; }
        public string Email { get; set; }
        public AppRole AppRole { get; set; }
    }
}
