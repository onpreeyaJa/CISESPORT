using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CISESPORT
{
    public class Player
    {
        private string name, lastname, studentid, 
            major, gname, email, tel;
        private int age = 0;
        public Player(string name, string lastname, string studentid, 
            string major, string gname, string email, string tel, int age )
        {
            this.name = name;
            this.lastname = lastname;
            this.studentid = studentid;
            this.major = major;
            this.gname = gname;
            this.email = email;
            this.tel = tel;
            this.age = age;
        }
        public string Name { get => name; }
        public string Lastname { get => lastname; }
        public string Major { get => major; }
        public string Gname { get => gname ; }
        public string Email { get => email; }
    }
}
