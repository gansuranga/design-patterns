using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{

    /// <summary>
    /// this will recieve single notification for a single concrete observer ,this bridges gap between 
    /// the sender and function handles 
    /// IObserver implenments seperate end-point for each notification
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NotificationSink<T>:IObserver<T>
    {

        private Action<object, T> action;

        public NotificationSink(Action<object,T> action) {
            this.action = action;
        }
        public void Update(object sender, T data)
        {
            this.action(sender, data);
        }
    }
}
