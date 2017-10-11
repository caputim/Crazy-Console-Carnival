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
            Random rnd = new Random();
            int rng = 0;
            List<int> used = new List<int>();
            int[] score = new int[2];
            string taken = "";
            // 15 topics
            string[] possibleTopics = new string[]{"geography", "european history", "animals", "weather", "sengoku period", "american history", "gossip girl", "random", "three kingdoms period", "musicians", "jake paul", "spanish words", "tv shows", "video games", "the bachelor"};
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

            writeOut("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeOut("Or rather, just your ability to know random stuff.");
            wait(1);
            writeOut("Pick 5 topics from the list for your game:\nGeography\nEuropean History\nAnimals\nWeather\nSengoku Period\nAmerican History\nGossip Girl\nRandom\nThree Kingdoms Period\nMusicians\nJake Paul\nSpanish Words\nTV Shows\nVideo Games\nThe Bachelor");
            for(int b = 0; b < 5; b++)
                {
                    taken = getInput();
                    topics[b] = taken;
                        for(int x = 0; x < 5; x++)
                        {
                        

                        rng = rnd.Next(9);

                        while(used.Contains(rng)){ 
                        rng = rnd.Next(9); 
                        }
                        
                                                                              
                        questions[b, x] = possibleQuestions[getSlot(taken, possibleTopics), rng];
                        answers[b, x] = possibleAnswers[getSlot(taken, possibleTopics), rng];
                        used.Add(rng);
                        writeOut(questions[b, x]);
                        writeOut(answers[b, x]);

                        }

                    dumbResponse(taken);
                    
                }
            
             
        }

        public void dumbResponse(string inpot)
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
