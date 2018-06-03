using DesignPatterns.Observer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// manage list of observers, responsiblity move away from the subject, this class is reponsible for 
    /// notify all observers, hence named MulticasrNotifier
    /// </summary>
    public class MulticastNotifier<T>
    {
        private IList<IObserver<T>> invocationList;
        //public MulticastNotifier(IEnumerable<IObserver<T>> observers) {

        //    this.invocationList = new List<IObserver<T>>(observers);
        //}
        private MulticastNotifier(IObserver<T> observer) {
            this.invocationList = new List<IObserver<T>>();
            this.invocationList.Add(observer);
        }

        private MulticastNotifier(MulticastNotifier<T> notifier, IObserver<T> observer)
        {
            this.invocationList = new List<IObserver<T>>(notifier.invocationList);
            this.invocationList.Add(observer);
        }
        public void Notify(object sender, T data)
        {
            foreach (IObserver<T> observer in invocationList)
                observer.Update(this, data);
        }
        /// <summary>
        /// remove the public contructor, the only way to subscribe is the via + operator
        /// </summary>
        /// <param name="notifier"></param>
        /// <param name="observer"></param>
        /// <returns></returns>
        public static MulticastNotifier<T> operator + (MulticastNotifier<T> notifier, IObserver<T> observer) {
            if (notifier == null)
                return new MulticastNotifier<T>(observer);
            return new MulticastNotifier<T>(notifier, observer);
        }
       
    }
}
