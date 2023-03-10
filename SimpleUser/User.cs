using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleUser
{
    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        }

        public bool IsOldEnough()
        {
            return this.Age >= 18;
        }

        public string GetResultMessage()
        {
            if (this.IsOldEnough())
            {
                return $"{this.Name} is old enough";
            }
            else
            {
                return $"{this.Name} is not old enough";
            }
        }
    }
}
