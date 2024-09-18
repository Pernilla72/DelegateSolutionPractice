
namespace Delegater01
{
    internal class Program
    {
        //[Övning 1]
        //        Syftet med denna övning är se hur vi kan tilldela olika metoder till samma delegatvariabel och anropa
        //        dessa metoder via delegatvariabeln.
        //1. Skapa ett Console projekt med namnet Delegater01.
        //2. I klassen Program, skapa två statiska metoder som matchar delegaten Action med namnen
        //Accelerate och Decelerate.
        //3. I programmets Main metod, deklarera en variabel av typen Action med namnet carAction.
        //Tilldela carAction metoden Accelerate, och anropa sedan Accelerate via carAction. Tilldela
        //därefter carAction metoden Decelerate, och anropa sedan Decelerate via carAction.

        static void Accelerate()
        {
            Console.WriteLine("Kör Görfort!");
        }

        static void Decelerate()
        {
            Console.WriteLine("Sakta in!!");
        }


        static void Main(string[] args)
        {

            Action carAction = Accelerate;
            carAction();
            

            carAction = Decelerate;
            carAction(); 
        }
    }      
}


  
