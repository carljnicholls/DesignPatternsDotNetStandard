using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample.Subject
{
    public class Visitor : People
    {
        public Visitor(string name, DateTime signInTime) 
            : base(name, signInTime)
        {
        }
    }
}
