using System;
using System.Collections.Generic;

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
            int theScore = 0;
            int num = 0;
            string[] halves = new string[2];
            //says which numbers have been used
            bool[,] use = new bool[5, 5];
            Random rnd = new Random();
            int rng = 0;
            List<int> used = new List<int>();
            int[] score = new int[2];
            string taken = "";
            // 15 topics
            string[] possibleTopics = new string[]{"geography", "europeanhist", "animals", "weather", "sengokuperiod", "americanhist", "gossipgirl", "random", "threekingdomsperiod", "musicians", "jakepaul", "spanishwords", "tvshows", "videogames", "thebachelor"};
            // 15 different topics, of 10 (possible) questions each
            string[,] possibleQuestions = new string[15, 10];
            // this array holds the answer to the corresponding questions
            string[,] possibleAnswers = new string[15, 10];
            // Chosen topics
            string[] topics = new string[5];
            //chosen questions
            string[,] questions = new string[5, 5];
            //answers to corresponding questions
            string[,] answers = new string[5, 5];

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
            possibleAnswers[0, 0] = "pacific";
            possibleAnswers[0, 1] = "lesotho";
            possibleAnswers[0, 2] = "sandwich";
            possibleAnswers[0, 3] = "hispaniola";
            possibleAnswers[0, 4] = "nile";
            possibleAnswers[0, 5] = "russia";
            possibleAnswers[0, 6] = "galapagos";
            possibleAnswers[0, 7] = "somalia";
            possibleAnswers[0, 8] = "yellow";
            possibleAnswers[0, 9] = "tokyo";

            //European History
            possibleQuestions[1, 0] = "Napoleon's final battle was ________.";
            possibleQuestions[1, 1] = "The _______ line was the major front at the start of WWII.";
            possibleQuestions[1, 2] = "The assassination of ________ Franz Ferdinard is widely said to have started WWI.";
            possibleQuestions[1, 3] = "Ireland was _______ during WWII.";
            possibleQuestions[1, 4] = "The ________ landings is another name for D-Day.";
            possibleQuestions[1, 5] = "The first Holy Roman Emperor was ____________.";
            possibleQuestions[1, 6] = "The ________ church held great power during the Middle Ages.";
            possibleQuestions[1, 7] = "_____ supremacy declared that the Pope was able to judge all and be judged in return by noone.";
            possibleQuestions[1, 8] = "Attila the ___ was a famous barbarian.";
            possibleQuestions[1, 9] = "______ Mussolini was dictator of Italy during WWII.";

            //European History Answers
            possibleAnswers[1, 0] = "waterloo";
            possibleAnswers[1, 1] = "maginot";
            possibleAnswers[1, 2] = "archduke";
            possibleAnswers[1, 3] = "neutral";
            possibleAnswers[1, 4] = "normandy";
            possibleAnswers[1, 5] = "charlemagne";
            possibleAnswers[1, 6] = "catholic";
            possibleAnswers[1, 7] = "papal";
            possibleAnswers[1, 8] = "hun";
            possibleAnswers[1, 9] = "benito";

            //Animals
            possibleQuestions[2, 0] = "Felus Domesticus is the scientific name for the ___.";
            possibleQuestions[2, 1] = "Canis Familiaris is the scientific name for the ___.";
            possibleQuestions[2, 2] = "The only egg-laying mammal is the ________.";
            possibleQuestions[2, 3] = "_______ is the scientific study of animals.";
            possibleQuestions[2, 4] = "Vertebrates have a ____ bone.";
            possibleQuestions[2, 5] = "True or False: Animals have prokaryotic cells.";
            possibleQuestions[2, 6] = "Turtles hide in their _____ when frightened.";
            possibleQuestions[2, 7] = "A zebroid is a genetic combination of a zebra and a _____.";
            possibleQuestions[2, 8] = "_____ the Sheep was the first cloned mammal from an adult cell.";
            possibleQuestions[2, 9] = "The Incas herded ______.";
        
            //Animals Answers
            possibleAnswers[2, 0] = "cat";
            possibleAnswers[2, 1] = "dog";
            possibleAnswers[2, 2] = "platypus";
            possibleAnswers[2, 3] = "zoology";
            possibleAnswers[2, 4] = "back";
            possibleAnswers[2, 5] = "false";
            possibleAnswers[2, 6] = "shell";
            possibleAnswers[2, 7] = "horse";
            possibleAnswers[2, 8] = "dolly";
            possibleAnswers[2, 9] = "llamas";

            //Weather
            possibleQuestions[3, 0] = "____________ is the transformation of water from a gas into a liquid.";
            possibleQuestions[3, 1] = "Rain or snow is an example of _____________.";
            possibleQuestions[3, 2] = "Humidity is the presence of _____ vapor in the atmosphere.";
            possibleQuestions[3, 3] = "The seasons are caused by a ____ in Earth's axis.";
            possibleQuestions[3, 4] = "Typhoons and hurricanes are regional names for a tropical _______.";
            possibleQuestions[3, 5] = "A ________ is a severe snow storm.";
            possibleQuestions[3, 6] = "A tidal wave is another name for a _______.";
            possibleQuestions[3, 7] = "A rotating formation of air is called a _______.";
            possibleQuestions[3, 8] = "The study of the weather is called ___________.";
            possibleQuestions[3, 9] = "True or False: A waterspout is a tornado over a body of water.";
        
            //Weather Answers
            possibleAnswers[3, 0] = "condensation";
            possibleAnswers[3, 1] = "precipitation";
            possibleAnswers[3, 2] = "water";
            possibleAnswers[3, 3] = "tilt";
            possibleAnswers[3, 4] = "cyclone";
            possibleAnswers[3, 5] = "blizzard";
            possibleAnswers[3, 6] = "tsunami";
            possibleAnswers[3, 7] = "tornado";
            possibleAnswers[3, 8] = "meteorology";
            possibleAnswers[3, 9] = "true";

            //Sengoku Period
            possibleQuestions[4, 0] = "Katsuyori Takeda assured his clan's destruction with his defeat at _________.";
            possibleQuestions[4, 1] = "_______ Kobayakawa betrayed Mitsunari Ishida at the Battle of Sekigahara.";
            possibleQuestions[4, 2] = "The ___ clan hailed from Owari.";
            possibleQuestions[4, 3] = "Motoyasu Matsudaira would later become Ieyasu ________.";
            possibleQuestions[4, 4] = "Yukimura Sanada earned eternal fame with his valiant last stand during the _____ Campaign";
            possibleQuestions[4, 5] = "Nobunaga Oda used a _____ attack to win at Okehazama against all odds.";
            possibleQuestions[4, 6] = "The symbol of the ______ clan was the bellflower.";
            possibleQuestions[4, 7] = "_________ Akechi betrayed Nobunaga Oda.";
            possibleQuestions[4, 8] = "True or False: Kanetsugu Naoe's famous helmet had a symbol that meant love in Japanese.";
            possibleQuestions[4, 9] = "Hideyoshi Hashiba faced off against Ieyasu Tokugawa at the Battles of ______ and Nagakute.";

            //Sengoku Period Answers
            possibleAnswers[4, 0] = "nagashino";
            possibleAnswers[4, 1] = "hideaki";
            possibleAnswers[4, 2] = "oda";
            possibleAnswers[4, 3] = "tokugawa";
            possibleAnswers[4, 4] = "osaka";
            possibleAnswers[4, 5] = "night";
            possibleAnswers[4, 6] = "akechi";
            possibleAnswers[4, 7] = "mitsuhide";
            possibleAnswers[4, 8] = "true";
            possibleAnswers[4, 9] = "komaki";

            showTitle("Welcome to Jeopardy!");

            writeLine("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeLine("Or rather, just your ability to know random stuff.");
            wait(1);
            writeLine("Pick 5 topics from the list for your game:\nGeography\nEuropeanHist\nAnimals\nWeather\nSengokuPeriod\nAmericanHist\nGossipGirl\nRandom\nThreeKingdomsPeriod\nMusicians\nJakePaul\nSpanishWords\nTVShows\nVideoGames\nTheBachelor");
            for(int b = 0; b < 5; b++)
                {
                taken = getInput();
                topics[b] = taken;
                        for(int x = 0; x < 5; x++)
                        {
                            rng = rnd.Next(10);

                            while(used.Contains(rng)){ 
                            rng = rnd.Next(10); 
                            }
                                                        
                            questions[b, x] = possibleQuestions[getSlot(taken, possibleTopics), rng];
                            answers[b, x] = possibleAnswers[getSlot(taken, possibleTopics), rng];
                            used.Add(rng);
                            //will show the questions and answers as theyre selected, uncomment to debug
                            //writeLine(questions[b, x]);
                            //writeLine(answers[b, x]);
                            use[b, x] = true;

                        }

                used.Clear();
                dumbResponse(taken);

                    
                }
            clear();
            writeLine("This game can be played alone, in a race to rack up points, or it can be played by 2 teams, to see who can get the most points. Which will it be?");
            String respuesta = getOption("1", "2");
            if (respuesta == "1")
            {
                for (int e = 0; e < 25; e++)
                {
                    showBoard(use, topics);
                    writeLine("To pick a question, say the topic, followed by one space, and then the points: \"geography 100\".");
                    taken = getInput();
                    clear();
                    halves = taken.Split(' ');
                    writeLine(halves[0]);
                    writeLine(halves[1]);
                    theScore = Convert.ToInt32(halves[1]);
                    //takes the second number, converts to Int, divides it to 100 to be single digit, then subtracts by 1 since arrays start with 0
                    num = ((Convert.ToInt32(halves[1])) / 100) - 1;
                    use[getSlot(halves[0], topics), num] = false;
                    writeLine(questions[getSlot(halves[0], topics), num]);
                    taken = getInput();
                    if (taken == answers[getSlot(halves[0], topics), num])
                    {
                        score[0] += theScore;
                        writeLine("Correct! Your total score is currently: " + score[0]);
                    }
                    else
                    {
                        score[0] -= theScore;
                        writeLine("Incorrect. Your total score is currently: " + score[0]);
                    }
                    writeLine("Say yes when you're ready to continue.");
                    taken = getInput();

                }
                writeLine("Thanks for playing. You finished with: " + score[0]);
            }
                
        }
        public void showBoard(bool[,] beenUsed, String[] pickedTopics)
        {
            int kept = 0;
            clear();
            for (int i = 0; i < 5; i++)
                write(pickedTopics[i] + "     ");
            for (int a = 0; a < 5; a++)
            {
                writeLine("");
                for (int c = 0; c < 5; c++)
                {
                    kept = a + 1;
                    if (beenUsed[c, a] == true)
                        write(kept * 100 + "              ");
                    else write("XXX              ");
                }
            }
            writeLine("");
        }
        public void dumbResponse(string inpot)
            {
                if(inpot == "geography")
                    writeOut("Geography? Really? Eh, lame choice, but whatever.");
                if(inpot == "europeanhist")
                    writeOut("Very good choice. I'd give you some Euros if I wasn't broke.");
                if(inpot == "animals")
                    writeOut("Animals are the greatest! Good choice!");
                if(inpot == "weather")
                    writeOut("If you know what clouds and rain are, you'll be fine with these questions.");
                if(inpot == "sengokuperiod")
                    writeOut("Questions the Three Unifiers would be proud of.");
                if(inpot == "americanhist")
                    writeOut("The shot heard round the world!");
                if(inpot == "gossipgirl")
                    writeOut("I see someone has good tastes in TV.");
                if(inpot == "random")
                    writeOut("Some of these are hard, some of these are easy. Best of luck either way.");
                if(inpot == "threekingdomsperiod")
                    writeOut("If you don't know what Wei, Wu, or Shu is, you already lost these questions.");
                if(inpot == "musicians")
                    writeOut("Hopefully you like alternative, electronic, and pop.");
                if(inpot == "jakepaul")
                    writeOut("Only the greatest Jake Paulers will answer these questions right.");
                if(inpot == "spanishwords")
                    writeOut("Ay que bien!");
                if(inpot == "tvshows")
                    writeOut("Dedicated to all my favorite shows! Hopefully your tastes are just as good as mine.");
                if(inpot == "videogames")
                    writeOut("I have a weird taste in games. These questions won't be easy.");
                if(inpot == "thebachelor")
                    writeOut("If you finish this game quick enough you might not miss the Rose Ceremony!");
            }
        public int getSlot(string enter, string[] tops)
            {
            for (int z = 0; z < 15; z++)
                if (tops[z] == enter)
                    return z;

            return 0;
            }
       
    }
}
