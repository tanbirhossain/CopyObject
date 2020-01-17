using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyObject.Tests.Entity
{
   public class User
    {
        public User()
        {
            Id = 0;
            Name = "Mohammed Tanbir Hossain";
            DOB = DateTime.UtcNow;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
    }
}
