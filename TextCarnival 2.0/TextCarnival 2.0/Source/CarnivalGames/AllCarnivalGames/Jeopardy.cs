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
            // 15 different topics, of 10 (possible) questions each
            String[,] possibleQuestions = new String[15][10];
            // this array holds the answer to the corresponding questions
            String[,] possibleAnswers = new String[15][10];
            //Geography
            possibleQuestions[0, 0] = "The _______ Ocean lies west of Ecuador.";
            possibleQuestions[0, 1] = "_______ lies landlocked inside South Africa.";
            possibleQuestions[0, 2] = "South Georgia and the South ________ islands is located near Antarctica.";
            possibleQuestions[0, 3] = "__________ is the island that Haiti and the Dominican Republic make up.";
            possibleQuestions[0, 4] = "The ____ river runs through Egypt.";
            possibleQuestions[0, 5] = "______ is the largest country in the world in terms of size.";
            possibleQuestions[0, 6] = "The _________ islands lay far off the coast of their mother country Ecuador.";
            possibleQuestions[0, 7] = "_______ rules over the horn of Africa.";
            possibleQuestions[0, 8] = "The ______ river runs through Northern China";
            possibleQuestions[0, 9] = "_____ Bay lies directly near Tokyo.";

            String f = getInput();
            writeLine(f);



            showTitle("Welcome to Jeopardy!");

            writeOut("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeOut("Or rather, just your ability to know random stuff.");
            writeOut("This game can be played with 2 teams, or you can try and go at it alone and see how many points you can get!");
            writeOut("How do you want to play? [1] or [2]?")
        }
       
    }
}
