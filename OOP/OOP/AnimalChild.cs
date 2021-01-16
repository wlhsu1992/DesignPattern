using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Cat : Animal, IShoutAnnounce
    {
        public Cat() : base() { }
        public Cat(string name) : base(name) { }

        public override string getShoutSound()
        {
            return "喵";
        }

        //宣告委託 CatShoutEventHandler
        public delegate void CatShoutEventHandler(object sender, CatShoutEventArgs args);

        //宣告事件 CatShout，事件類型是委託CatShoutEventHandler
        public event CatShoutEventHandler CatShout;

        public void ShoutAnnounce()
        {
            Console.WriteLine($"{name}:喵");

            //當Shout執行方法時，如果CatShout中有物件登記事件，則執行CatShout
            if (CatShout != null)
            {
                CatShoutEventArgs e = new CatShoutEventArgs();
                e.Name = this.name;
                CatShout(this, e);
            }
        }
    }

    public class CatShoutEventArgs : EventArgs
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }

    class Dog : Animal
    {
        public Dog() : base() { }
        public Dog(string name) : base(name) { }

        public override string getShoutSound()
        {
            return "汪";
        }
    }

    class Monkey : Animal
    {
        public Monkey() : base() { }
        public Monkey(string name) : base(name) { }

        public override string getShoutSound()
        {
            return "吱吱";
        }
    }

    class Mouse : Animal
    {
        public Mouse() : base() { }
        public Mouse(string name) : base(name) { }

        public override string getShoutSound()
        {
            return "吱";
        }

        public void Run(object sender, CatShoutEventArgs args)
        {
            Console.WriteLine($"老貓{args.Name}來了，{name}快跑");
        }
    }
}
