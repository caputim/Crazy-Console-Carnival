using System;

namespace TextCarnivalV2.Source.CarnivalGames.AllCarnivalGames
{
    class TriviaMania : CarnivalGame
    {
        public TriviaMania() : base()
        {

        }

        public override string getName()
        {
            return "Question Mania";
        }

        public override void play()
        {
            showTitle("WELCOME TO QUESTION MANIA!");
            wait(1);
            write("Hello, and welcome to Question Mania.");
            write("Here, I will test your intellect, or rather, your knowledge on random topics.")
        }

    }

}
