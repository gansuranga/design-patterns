using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Observer
{
    public class Logger 
    {
        // needs 2 observer fields
        public readonly IObserver<string> AfterDoSomethingWith;
        public readonly IObserver<Tuple<string, string>> AfterDoMore;

        public Logger() 
        {
            // 1 field delegates to AfterDoSomethingWith
            this.AfterDoSomethingWith = new NotificationSink<string>(
                (sender, data) => this.AfterDoSomethingWithHandler(sender, data));

            // 2 field delegates to AfterDoMore
            this.AfterDoMore = new NotificationSink<Tuple<string, string>>(
                (sender, data) => AfterDoMoreHandler(sender, data));
                    
        }

        private void AfterDoMoreHandler(object sender, Tuple<string, string> data)
        {
            Console.WriteLine("writing down apended {0}", data.Item2.ToUpper());
        }

        private void AfterDoSomethingWithHandler(object sender, string data)
        {
            Console.WriteLine("writing down {0}", data.ToUpper());
        }

        //public void AfterDoSomethingWith(ISubject sender, string data)
        //{
        //    Console.WriteLine("writing down {0}", data.ToUpper());
        //}
        //public void AfterDoMore(ISubject sender, string completedData, string appendedData) {
        //    Console.WriteLine("writing down apended {0}", appendedData.ToUpper());
        //}
    }
}
