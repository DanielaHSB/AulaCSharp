﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02.Entity
{
    public class Person
    {
        private string name;
        private string email;

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public Person(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        public Person()
        {

        }
    }
}
