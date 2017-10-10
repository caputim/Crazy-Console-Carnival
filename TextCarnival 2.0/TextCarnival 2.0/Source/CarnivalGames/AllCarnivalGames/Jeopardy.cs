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
            String taken = "";
            // 15 topics
            String[] possibleTopics = new String[]{"geography", "european history", "animals", "weather", "sengoku period", "american history", "gossip girl", "random", "three kingdoms period", "musicians", "jake paul", "spanish words", "tv shows", "video games", "the bachelor"};
            // 15 different topics, of 10 (possible) questions each
            String[,] possibleQuestions = new String[15, 10];
            // this array holds the answer to the corresponding questions
            String[,] possibleAnswers = new String[15, 10];
            // Chosen topics
            String[] topics = new String[5];
            //chosen questions
            String[,] questions = new String[5, 5];
            //answers to corresponding answers
            String[,] answers = new String[5, 5];
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

            //Geography Answers

            showTitle("Welcome to Jeopardy!");

            writeOut("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeOut("Or rather, just your ability to know random stuff.");
            wait(1);
            writeOut("Pick 5 topics from the list for your game:\nGeography\nEuropean History\nAnimals\nWeather\nSengoku Period\nAmerican History\nGossip Girl\nRandom\nThree Kingdoms Period\nMusicians\nJake Paul\nSpanish Words\nTV Shows\nVideo Games\nThe Bachelor");
            for(int b = 0; b < 5; b++)
                {
                    taken = getInput();
                    dumbResponse(taken);
                }
            writeLine("This game can be played with 2 teams, or you can try and go at it alone and see how many points you can get!");
            writeOut("How do you want to play? [1] or [2]?");
            
             
        }

        public void dumbResponse(String inpot)
            {
                if(inpot == "geography")
                    writeOut("Geography? Really? Eh, lame choice, but whatever.");
                if(inpot == "european history")
                    writeOut("Very good choice. I'd give you some Euros if I wasn't broke.");
                if(inpot == "animals")
                    writeOut("Animals are the greatest! Good choice!");
                if(inpot == "weather")
                    writeOut("If you know what clouds and rain are, you'll be fine with these questions.");
                if(inpot == "sengoku period")
                    writeOut("Questions the Three Unifiers would be proud of.");
                if(inpot == "american history")
                    writeOut("The shot heard round the world!");
                if(inpot == "gossip girl")
                    writeOut("I see someone has good tastes in TV.");
                if(inpot == "random")
                    writeOut("Some of these are hard, some of these are easy. Best of luck either way.");
                if(inpot == "three kingdoms period")
                    writeOut("If you don't know what Wei, Wu, or Shu is, you already lost these questions.");
                if(inpot == "musicians")
                    writeOut("Hopefully you like alternative, electronic, and pop.");
                if(inpot == "jake paul")
                    writeOut("Only the greatest Jake Paulers will answer these questions right.");
                if(inpot == "spanish words")
                    writeOut("Ay que bien!");
                if(inpot == "tv shows")
                    writeOut("Dedicated to all my favorite shows! Hopefully your tastes are just as good as mine.");
                if(inpot == "video games")
                    writeOut("I have a weird taste in games. These questions won't be easy.");
                if(inpot == "the bachelor")
                    writeOut("If you finish this game quick enough you might not miss the Rose Ceremony!");

                else writeOut("Okay then.");
            }
       
    }
}
