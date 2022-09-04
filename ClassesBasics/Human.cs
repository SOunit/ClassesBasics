using System;

namespace ClassesBasics
{
    internal class Human
    {
        // member variable
        private string firstName;
        private string lastName;

        // ctor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi I'm {0} {1}", firstName, lastName);
        }
    }
}
