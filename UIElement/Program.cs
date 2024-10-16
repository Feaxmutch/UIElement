﻿namespace UIElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float health = 40;
            float mana = 23;
            int healthBarLenght = 15;
            int manaBarLenght = 10;

            DrawBar(health, 0, 0, healthBarLenght, ConsoleColor.Green, ConsoleColor.Red);
            DrawBar(mana, 0, 1, manaBarLenght, ConsoleColor.Blue, ConsoleColor.Red);

            Console.ReadKey(true);
        }

        private static void DrawBar(float present, int positionX, int positionY, int length, ConsoleColor barColor = ConsoleColor.Red, ConsoleColor frameColor = ConsoleColor.White)
        {
            char leftSideOfFrame = '[';
            char rightSideOfFrame = ']';
            char emptyBarPart = '_';
            char barPart = '#';
            float maxPresent = 100;
            float lastPartOfBar = present * (length / maxPresent);
            ConsoleColor defaltForegroundColor = Console.ForegroundColor;

            Console.ForegroundColor = frameColor;
            Console.SetCursorPosition(positionX, positionY);
            Console.Write(leftSideOfFrame);
            Console.ForegroundColor = barColor;

            DrawSymbols(1, lastPartOfBar, barPart);
            DrawSymbols(lastPartOfBar, length, emptyBarPart);

            Console.ForegroundColor = frameColor;
            Console.Write(rightSideOfFrame);
            Console.ForegroundColor = defaltForegroundColor;
        }

        private static void DrawSymbols(float startIteration, float lastIteration, char sumbol)
        {
            for (float i = startIteration; i <= lastIteration; i++)
            {
                Console.Write(sumbol);
            }
        }
    }
}
