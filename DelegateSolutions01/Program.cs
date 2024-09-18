namespace DelegateExamples01
{
    internal class Program
    {
        static void MyMethod() 
        {
            Console.WriteLine("Hello World");
        }

        static void HittePå()
        {
            Console.Beep(400, 1000);
        }

    
        static void Main(string[] args)
        {
            //Tilldela variabeln a av typen Action metoden MyMetod
            Action metod = MyMethod;

            //Anropa metoden som variebeln a tilldelats.
            MyMethod();
            metod();

           
        }
        
    }
}
