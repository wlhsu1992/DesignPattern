using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //OOP 動物叫聲比賽==========================================
            //List<Animal> animalList = new List<Animal>();
            //animalList.Add(new Cat("咪咪"));
            //animalList.Add(new Dog("旺財"));
            //animalList.Add(new Monkey("猴哥"));

            //foreach (Animal animal in animalList)
            //    Console.WriteLine(animal.Shout());

            //Console.ReadLine();

            //委派與事件=================================================
            Cat cat = new Cat("Tom");
            Mouse mouse1 = new Mouse("Jerry");
            Mouse mouse2 = new Mouse("Jack");

            cat.CatShout += new Cat.CatShoutEventHandler(mouse1.Run);
            cat.CatShout += new Cat.CatShoutEventHandler(mouse2.Run);

            cat.ShoutAnnounce();
            Console.Read();
        }
    }
}
