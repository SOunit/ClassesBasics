namespace ClassesBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // instance of Human class
            Human jack = new Human("Jack", "Pearson");

            // call method of a class
            jack.IntroduceMyself();

            Human bec = new Human("Bec", "Pearson");
            bec.IntroduceMyself();
        }
    }
}
