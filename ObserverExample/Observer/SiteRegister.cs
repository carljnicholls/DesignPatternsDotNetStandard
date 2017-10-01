using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    /// <summary>
    /// Concrete Subject Class
    /// </summary>
    public class SiteRegister : TrackingRegister
    {
        private DateTime _openingTime;
        private DateTime _closingTime; 

        public SiteRegister(string registerName, DateTime openingTime, DateTime closingTime) : base(registerName)
        {
            _openingTime = openingTime;
            _closingTime = closingTime; 
        }

        public DateTime OpeningTime { get => _openingTime; set => _openingTime = value; }
        public DateTime ClosingTime { get => _closingTime; set => _closingTime = value; }
    }
}
