using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// issue with this observers must be able to select and subscribe to notifications only 
    /// they are interedted in to this has to be more specific, carry only the data required 
    /// for that observer
    /// </summary>
    //public interface IObserver
    //{
    //    void AfterDoSomethingWith(ISubject sender,string data);
    //    void AfterDoMore(ISubject sender, string completedData, string appendedData);
    //}
    // T carries what observer is interested in
    public interface IObserver<T>
    {
        void Update(object sender, T data);
    }
}
