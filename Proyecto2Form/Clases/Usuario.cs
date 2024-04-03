using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2Form.Clases
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }

        public Usuario(int id, string username, string password, string role)
        {
            Id = id;
            Username = username;
            Password = password;
            Role = role;
        }

        
        public override string ToString()
        {
            return $"Id: {Id}, Username: {Username}, Role: {Role}";
        }
    }
}
