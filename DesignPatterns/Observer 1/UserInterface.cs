using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    /// <summary>
    /// IObserver is removed, there can be similar method signatures Ex :- which takes one param as the argument
    /// but a diiferent notification, so the notification handlers must be seperated.
    /// </summary>
    public class UserInterface
    {
        public readonly IObserver<string> AfterDoSomethingWith;
        public UserInterface() {

            //Console.WriteLine("Hey user, look at this {0}", data.ToUpper());
            //every notification handler is handled by single notificationsink object, to seperate the notification handlers
            this.AfterDoSomethingWith = new NotificationSink<string>((sender, data) 
                => this.AfterDoSomethingWithHandler(sender, data));
        }

        private void AfterDoSomethingWithHandler(object sender, string data)
        {
            Console.WriteLine("Hey user, look at this {0}", data.ToUpper());
        }

    }
}
