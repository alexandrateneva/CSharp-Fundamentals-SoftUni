﻿namespace _01.Inheritance___Lab
{
    public class Startup
    {
        public static void Main()
        {
           var dog = new Dog();
            dog.Eat();
            dog.Bark();

            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
