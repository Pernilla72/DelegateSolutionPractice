﻿namespace DelegatesExample02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
                // Tilldela variabeln a av typen Action<string> metoden MyParameterAction.
                Action<string> a = MyParameterAction;
                
                // Anropa metoden som variabeln a tilldelats.
                a("Uddevalla YH Rules!");
        }

            static void MyParameterAction(string s)
            {
                Console.WriteLine(s);
            }
        
    }
}
