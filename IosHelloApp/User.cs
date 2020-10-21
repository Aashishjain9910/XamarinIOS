using System;
using SQLite;


namespace IosHelloApp
{
    public class User
    {
        
        public string Name { get; set; }

        [PrimaryKey]
        public string Email { get; set; }

        public string Phone { get; set; }

        public string Password { get; set; }

    }
}
