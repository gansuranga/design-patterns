using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// managing list of observers are not a responsiblity of the subject
    /// this is the concrete subject
    /// </summary>
    public class Doer 
    {
        //private IList<IObserver> observers = new List<IObserver>();
        //public string Data { get; private set; }
        // instead of list of observers

        public MulticastNotifier<string> AfterDoSomethingWith;
        public MulticastNotifier<Tuple<string, string>> AfterDoMore;

        private string data = string.Empty;
        public void DoSomethingWith(string data) {
            this.data = data;
            OnAfterDoSomethingWith(this.data);
        }

        private void OnAfterDoSomethingWith(string data)
        {
            if (this.AfterDoSomethingWith != null)
                this.AfterDoSomethingWith.Notify(this, data);
        }

        public void DoMore(string appendedData) {
            this.data += appendedData;
            OnAfterDoMore(this.data, appendedData);
        }

        private void OnAfterDoMore(string data, string appendedData)
        {
            if (AfterDoMore != null)
                this.AfterDoMore.Notify(this,  Tuple.Create(data,appendedData));
        }

        //public void Attach(IObserver observer)
        //{
        //    observers.Add(observer);
        //}

        //public void Detach(IObserver observer)
        //{
        //    observers.Remove(observer);
        //}
        //public void AfterDoSomethingWith(string data)
        //{
        //    foreach (var observer in observers)
        //        observer.AfterDoSomethingWith(this,data);
        //}
        //public void AfterDoMore(string completedData, string appendedData)
        //{

        //    foreach (var observer in observers)
        //        observer.AfterDoMore(this, data,appendedData);
        //}
    }
}
