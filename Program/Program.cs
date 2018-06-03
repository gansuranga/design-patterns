using DesignPatterns.Composite;
using DesignPatterns.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var doer = new Doer();

            UserInterface userInterface = new UserInterface();
            Logger logger = new Logger();

            doer.AfterDoSomethingWith += userInterface.AfterDoSomethingWith;
            doer.AfterDoSomethingWith += logger.AfterDoSomethingWith;
            doer.AfterDoMore += logger.AfterDoMore;


            //doer.AfterDoSomethingWith =
            //    new MulticastNotifier<string>(

            //        new DesignPatterns.Observer.IObserver<string>[] {

            //            userInterface.AfterDoSomethingWith,
            //            logger.AfterDoSomethingWith

            //        });
            //doer.AfterDoMore =
            //    new MulticastNotifier<Tuple<string, string>>(
            //    new DesignPatterns.Observer.IObserver<Tuple<string, string>>[]
            //        {
            //            logger.AfterDoMore

            //        });



            doer.DoSomethingWith("my data");
            doer.DoMore("tail");
            
            // composite pattern
            //var drawing = new GraphicObject { Name = "My Drawing" };
            //drawing.Children.Add(new Circle { Color = "Red" });
            //drawing.Children.Add(new Square { Color = "Yelllow" });

            //var group = new GraphicObject();
            //drawing.Children.Add(new Circle { Color = "Blue" });
            //drawing.Children.Add(new Square { Color = "Blue" });
            //drawing.Children.Add(group);
            //Console.WriteLine(drawing);



            Console.ReadLine();

        }
    }
}
