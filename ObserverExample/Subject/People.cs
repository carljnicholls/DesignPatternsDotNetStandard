using ObserverExample.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample
{
    /// <summary>
    /// Observable Class 
    /// </summary>
    public abstract class People
    {
        private string _name;
        private DateTime _signInTime;

        public string Name { get => _name; set => _name = value; }
        public DateTime SignInTime { get => _signInTime; set => _signInTime = value; }

        public People(string name, DateTime signInTime)
        {
            _name = name;
            _signInTime = signInTime;
        }

        public string Update(TrackingRegister trackingRegister)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Register Name: ").Append(
                trackingRegister.RegisterName)
                .Append(" Sign In Time: ")
                .Append(SignInTime.ToShortTimeString());

            return sb.ToString();
        }
    }
}
