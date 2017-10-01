using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverExample.Subject
{
    /// <summary>
    /// IObserver Class 
    /// </summary>
    public interface IPeople
    {
        string Update(TrackingRegister register);
    }
}
