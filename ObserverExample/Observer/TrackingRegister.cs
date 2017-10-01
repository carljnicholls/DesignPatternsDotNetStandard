using ObserverExample.Subject;
using System;
using System.Collections.Generic;

namespace ObserverExample
{
    /// <summary>
    /// Abstract Subject Class 
    /// </summary>
    public abstract class TrackingRegister
    {
        private string _registerName; 
        private List<People> _peopleList;

        public string RegisterName { get => _registerName; set => _registerName = value; }
        public List<People> PeopleList { get => _peopleList; set => _peopleList = value; }

        public TrackingRegister(string registerName)
        {
            _registerName = registerName; 
            _peopleList = new List<People>(); 
        }

        public void Register(People people)
        {
            _peopleList.Add(people);
        }

        public void UnRegister(People people)
        {
            _peopleList.Remove(people);
        }

        public void NotifyObservers()
        {
            foreach (var register in _peopleList)
                register.Update(this);
        }
    }
}
