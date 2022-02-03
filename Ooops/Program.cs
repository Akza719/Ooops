using System;
using System.Collections.Generic;

namespace Ooops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c = new Customer("Mahatma", "Gandhi");
            //c.display();

            //StaticDemo.calculate();

            //Dimension_Shape rt = new Rectangle("Blue",50,2);
            //Console.WriteLine($" Rectangle color is {rt.GetColour()} and room area is { rt.GetArea() } ");

            //Dimension_Shape cir = new Circle("Red", 22);
            //Console.WriteLine($" Circle color is {cir.GetColour()} and room area is { cir.GetArea() } ");


            //Dimension_Shape sq = new Square("White", 10);
            //Console.WriteLine($" Square color is {sq.GetColour()} and room area is { sq.GetArea() } ");

            //Creator yt = new Youtuber();
            //yt.Create();
            //Console.WriteLine();
            //Creator pg = new Programmer();
            //pg.Create();


            //   DYNAMIC POLYMORPHISM



            //List<Creator> cr = new List<Creator>() { new Youtuber(), new Programmer() };
            //foreach(var creators in cr)
            //{
            //    Console.WriteLine(creators.GetType().Name);
            //    creators.Create();
            //    Console.WriteLine();
            //}


            Encapsulation en = new Encapsulation();
            en.Login("Ramu", "Raj@124");

            Animal an = new Animal();
            an.Voice();
            Animal dg = new Dog();
            dg.Voice();
            Animal ct = new Cat();
            ct.Voice();
            Animal gt = new Goat();
            gt.Voice();


            Console.WriteLine(Generics<string, int>.AreEqual(2, 3));
            Generics<string, int>.Display("Hello", "Guys");
        }
    }
}
