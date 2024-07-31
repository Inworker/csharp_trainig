﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : TestBase
    {
        private string firstname;
        private string lastname;
        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }
        
        public string Firstname
        {
            get { return this.firstname; }
            set { this.firstname = value; }
        }

        public string LastName
        {
            get { return this.lastname; }
            set { this.lastname = value; }
        }
    
    }
}
