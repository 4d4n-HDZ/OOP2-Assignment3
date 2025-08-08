using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public User(string name) => Name = name;
        public override bool Equals(object obj) => obj is User u && Name == u.Name;
        public override int GetHashCode() => Name?.GetHashCode() ?? 0;
    }
}
