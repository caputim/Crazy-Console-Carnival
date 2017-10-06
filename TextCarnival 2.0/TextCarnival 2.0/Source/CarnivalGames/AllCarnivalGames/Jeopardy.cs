using System;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class Jeopardy : CarnivalGame
    {
        public Jeopardy() : base()
        {

        }

        public override string getName()
        {
            return "Jeopardy";
        }

        public override void play()
        {
            int[] score = new int[2];
            // 15 different topics, of 5 questions each
            String[,] possibleQuestions = new String[15][10];
            //Geography
            possibleQuestions[0, 0] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 1] = "_______ lies landlocked inside South Africa.";
            possibleQuestions[0, 2] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 3] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 4] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 5] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 6] = "The _______ Ocean lies west of Ecuador.";


            showTitle("Welcome to Jeopardy!");

            writeOut("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeOut("Or rather, just your ability to know random stuff.");
            writeOut("This game can be played with 2 teams, or you can try and go at it alone and see how many points you can get!");
        }

        public void displayBoard(int[] b)
        {
            write("")
        }
    }
}
