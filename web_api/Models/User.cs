using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_app_2._0
{
    public class User
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string username { get; set; }
        public Gender gender { get; set; }
        public Uri profile { get; set; }
        public string password { get; set; }

        public static implicit operator Task<object>(User v)
        {
            throw new NotImplementedException();
        }
    }
}
