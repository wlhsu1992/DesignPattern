using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    //實體化Animal沒有太大意義，因此改為抽象
    abstract class Animal
    {
        //將欄位由 private 改為 protected 使子類別可以使用
        protected string name = "";
        protected int shoutNum = 3;

        public int ShoutNum
        {
            get { return ShoutNum; }
            set { shoutNum = value <= 10 ? value : 10; }
        }

        public Animal()
        {
            this.name = "無名";
        }

        public Animal(string name)
        {
            this.name = name;
        }

        public string Shout()
        {
            string result = "";
            for (int i = 0; i < shoutNum; i++)
                result += $"{getShoutSound()} ";

            return $"{name}:{result}";
        }

        public abstract string getShoutSound();
    }
}
