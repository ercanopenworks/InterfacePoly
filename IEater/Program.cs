using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEater
{
    class Program
    {

        interface IEater
        {
            void Eat();
        }

        class Dog : IEater
        {
            public void Eat()
            {
                Console.WriteLine($"{nameof(Dog)} is eating");
            }
        }

        class Cat : IEater
        {
            public void Eat()
            {
                Console.WriteLine($"{nameof(Cat)} is eating");
            }
            public void Meow()
            {
                Console.WriteLine($"{nameof(Cat)} is miyav");
            }
        }

        //abstraction
        private static void Eat(IEater eater)
        {
            eater.Eat();
        }

        //usage of generics 
        private static void Eat<T>(T eater) where T:IEater
        {
            eater.Eat();
        }

        static void Main(string[] args)
        {
            IEater cat = new Cat();
            Eat(cat);

            IEater dog = new Dog();
            Eat(dog);


            Console.ReadKey();





        }
    }
}
