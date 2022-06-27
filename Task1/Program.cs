using System;

namespace Task1
{
    class program
    {
        static void Main()
        {
            Word w1 = new Word("Не");
            Word w2 = new Word("Я");
            Word w3 = new Word("Б`ю");
            Word w4 = new Word("Верба");
            Word w5 = new Word("Б'є");

            Sentence s1 = new Sentence();
            s1.CreateSentence(w1);
            s1.CreateSentence(w2);
            s1.CreateSentence(w3);
            s1.PrintS();
            Console.WriteLine();
            
            Sentence s2 = new Sentence();
            s2.CreateSentence(w4);
            s2.CreateSentence(w5);
            s2.PrintS();
            Console.WriteLine();

            Text text = new Text();
            text.CreateText(s1.sentences);
            text.CreateText(s2.sentences);
            text.ShowText();
            Console.WriteLine();
            text.AddText("З Вербною Неділею!");
            text.ShowText();
            Console.WriteLine();
            text.HeaderOfText("Зі святом!");
            Console.WriteLine();




        }
    }
}
