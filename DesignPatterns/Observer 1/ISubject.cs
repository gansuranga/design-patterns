using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// subject is an general interface to notify the others (observers) about the important events
    /// </summary>
    public interface ISubject
    {
        //void Attach(IObserver observer);
        //void Detach(IObserver observer);
        void AfterDoSomethingWith(string data);
        void AfterDoMore(string completedData, string appendedData);
        //string Data { get; } remove Data from the subject, it's silly to have Data on
        //
    }
}
