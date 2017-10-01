using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample.Subject
{
    public class StaffMember : People
    {
        private string _role; 

        public StaffMember(string name, DateTime signInTime) 
            : base(name, signInTime)
        {
            _role = "Default"; 
        }

        public StaffMember(string name, DateTime signInTime, string role)
            : base(name, signInTime)
        {
            _role = role;
        }

        public string Role { get => _role; set => _role = value; }
    }
}
