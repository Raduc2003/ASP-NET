using System;
using System.Diagnostics.CodeAnalysis;

namespace lab1
{
    public class App
    {
        private class Pets
        {   //props
            protected string name;
            protected int age;
            protected List<string> toys;
            //Constr
            public Pets(string name, int age)
            {
                this.name = name;
                this.age = age;
            }


            //methods
            public string Name { get { return name; } }
            public int Age { get { return age; } }

            public virtual string Does()
            {
                return "mizerie";
            }


        }

        private class Cat : Pets
        {
            public Cat(string name, int age) : base(name, age)
            {
            }

            public string Does()
            {
                return "miau";
            }

        }
        private class Dog : Pets
        {
            public Dog(string name, int age) : base(name, age)
            {
            }

            public string Does()
            {
                return "Ham";
            }

        }
        public static void Main(string[] args)
        {
            Dog myDog = new Dog("Azorel", 3);

            Console.WriteLine($"The dog named {myDog.Name}, aged {myDog.Age}, says {myDog.Does()}!");
        }


    }
}