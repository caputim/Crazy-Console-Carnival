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

        public int turn = 1;

        public override void play()
        {
            
            int theScore = 0;
            int num = 0;
            string[] halves = new string[1];
            //says which numbers have been used
            bool[,] use = new bool[5, 5];
            Random rnd = new Random();
            int rng = 0;
            List<int> used = new List<int>();
            int[] score = new int[3];
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
            possibleQuestions[4, 4] = "Yukimura Sanada earned eternal fame with his valiant last stand during the _____ Campaign.";
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

            //American History
            possibleQuestions[5, 0] = "________ Arnold famously betrayed the Patriots for the British.";
            possibleQuestions[5, 1] = "Washington's Army spent the winter at ______ Forge.";
            possibleQuestions[5, 2] = "The British surrendered at Yorktown, ________.";
            possibleQuestions[5, 3] = "Washington was in command of the ___________ Army.";
            possibleQuestions[5, 4] = "The Patriots strategically retreated during the Battle of ______ Hill.";
            possibleQuestions[5, 5] = "____ Hancock was the first to sign the Declaration of Independence.";
            possibleQuestions[5, 6] = "Redcoats fired into a crowd in what would later be known as the Boston ________.";
            possibleQuestions[5, 7] = "The battle of ________ is often considered the turning point of the war.";
            possibleQuestions[5, 8] = "The ____ of Liberty led the Patriot resistance to British policies in Boston.";
            possibleQuestions[5, 9] = "Marquis de _________ led the French in support of the Patriots.";

            //American History Answers
            possibleAnswers[5, 0] = "benedict";
            possibleAnswers[5, 1] = "valley";
            possibleAnswers[5, 2] = "virginia";
            possibleAnswers[5, 3] = "continental";
            possibleAnswers[5, 4] = "bunker";
            possibleAnswers[5, 5] = "john";
            possibleAnswers[5, 6] = "massacre";
            possibleAnswers[5, 7] = "saratoga";
            possibleAnswers[5, 8] = "sons";
            possibleAnswers[5, 9] = "lafayette";

            //Gossip Girl
            possibleQuestions[6, 0] = "Ivy Dickens impersonated Charlie Rhodes, whose real name is Charlotte '____' Rhodes";
            possibleQuestions[6, 1] = "Penelope was a minion of _____'s.";
            possibleQuestions[6, 2] = "Serena arrived back in Manhattan in the first episode via _____.";
            possibleQuestions[6, 3] = "Lily and Rufus' son was named _____.";
            possibleQuestions[6, 4] = "_____ was Cyrus' son, and briefly Serena's boyfriend in Season 2.";
            possibleQuestions[6, 5] = "Carter Baizen left Serena to work on the Buckley's ___ plant to pay off his debt.";
            possibleQuestions[6, 6] = "____ ultimately ends up with nobody.";
            possibleQuestions[6, 7] = "____ was the daughter of Steven in the final season.";
            possibleQuestions[6, 8] = "Serena left to boarding school after she believed she and Georgina ______ a man.";
            possibleQuestions[6, 9] = "Ultimately, it was revealed that ___ was Gossip Girl.";

            //Gossip Girl Answers
            possibleAnswers[6, 0] = "lola";
            possibleAnswers[6, 1] = "blair";
            possibleAnswers[6, 2] = "train";
            possibleAnswers[6, 3] = "scott";
            possibleAnswers[6, 4] = "aaron";
            possibleAnswers[6, 5] = "oil";
            possibleAnswers[6, 6] = "nate";
            possibleAnswers[6, 7] = "sage";
            possibleAnswers[6, 8] = "killed";
            possibleAnswers[6, 9] = "dan";

            //Random
            possibleQuestions[7, 0] = "This game was created by _______.";
            possibleQuestions[7, 1] = "The Gods in The Good Place are called __________.";
            possibleQuestions[7, 2] = "This game was created at ______ Area High School.";
            possibleQuestions[7, 3] = "12 x 12 = ___ (Don't you dare pull out a calculator!)";
            possibleQuestions[7, 4] = "The goal was to get at least a _ on the AP test.";
            possibleQuestions[7, 5] = "Tanczos teaches ________ Data Structures.";
            possibleQuestions[7, 6] = "______ insisted on being in this game as a question, and now is.";
            possibleQuestions[7, 7] = "The Middle School's address is 1010 ____ Trail.";
            possibleQuestions[7, 8] = "ACSL stands for American Computer Science ______.";
            possibleQuestions[7, 9] = "This game is called ________.";

            //Random Answers
            possibleAnswers[7, 0] = "michael";
            possibleAnswers[7, 1] = "architects";
            possibleAnswers[7, 2] = "easton";
            possibleAnswers[7, 3] = "144";
            possibleAnswers[7, 4] = "4";
            possibleAnswers[7, 5] = "advanced";
            possibleAnswers[7, 6] = "alyssa";
            possibleAnswers[7, 7] = "echo";
            possibleAnswers[7, 8] = "league";
            possibleAnswers[7, 9] = "jeopardy";

            //Three Kingdoms
            possibleQuestions[8, 0] = "___ Cao was the first ruler of Wei.";
            possibleQuestions[8, 1] = "Yuan Shao's defeat was assured at Guan Du when his ________ were burned.";
            possibleQuestions[8, 2] = "Sun Ce was _______ to death by Yu Ji.";
            possibleQuestions[8, 3] = "Sun Jian was shot by an arrow in a plot by _____ Zu.";
            possibleQuestions[8, 4] = "Zhuge Liang was known as The ________ Dragon.";
            possibleQuestions[8, 5] = "Xiahou Dun famously ate his ___ after it was struck by an arrow shot by Cao Xing.";
            possibleQuestions[8, 6] = "Liu Bei famously said his friendship with Zhuge Liang was \"like fish and _____.\"";
            possibleQuestions[8, 7] = "Sima Yi's rise to power within the kingdom of Wei set the stage for Sima Yan to usurp the Wei throne and found the ___ dynasty.";
            possibleQuestions[8, 8] = "The Sleeping Dragon ultimately fell at the Wu Zhang Plains in a decisive battle against ____ Yi of Wei.";
            possibleQuestions[8, 9] = "\"_______ of the Three Kingdoms\" is a Chinese historical novel which tells the tale of the Three Kingdoms Period.";

            //Three Kingdoms Answers
            possibleAnswers[8, 0] = "cao";
            possibleAnswers[8, 1] = "supplies";
            possibleAnswers[8, 2] = "haunted";
            possibleAnswers[8, 3] = "huang";
            possibleAnswers[8, 4] = "sleeping";
            possibleAnswers[8, 5] = "eye";
            possibleAnswers[8, 6] = "water";
            possibleAnswers[8, 7] = "jin";
            possibleAnswers[8, 8] = "sima";
            possibleAnswers[8, 9] = "romance";

            //Musicians
            possibleQuestions[9, 0] = "_____ is a stellar Australian DJ.";
            possibleQuestions[9, 1] = "Mo is a ______ singer.";
            possibleQuestions[9, 2] = "Lana Del Rey's most recent album is Lust for ____.";
            possibleQuestions[9, 3] = "Runaround Sue is a song from the '60s by ____.";
            possibleQuestions[9, 4] = "\"Hello, it's me.\" is the opening line on an _____ song.";
            possibleQuestions[9, 5] = "______ Space is the highly depressing but extraordinarily beautiful debut EP by George Maple.";
            possibleQuestions[9, 6] = "Marina and the ________ released her latest album Froot back in 2015.";
            possibleQuestions[9, 7] = "Banks' second album is called The _____.";
            possibleQuestions[9, 8] = "Ellie ________ is an English singer/songwriter.";
            possibleQuestions[9, 9] = "iDubbbz's Ricegum diss track is titled _____ Jake Paul.";

            //Musicians Answers
            possibleAnswers[9, 0] = "flume";
            possibleAnswers[9, 1] = "danish";
            possibleAnswers[9, 2] = "life";
            possibleAnswers[9, 3] = "dion";
            possibleAnswers[9, 4] = "adele";
            possibleAnswers[9, 5] = "vacant";
            possibleAnswers[9, 6] = "diamonds";
            possibleAnswers[9, 7] = "altar";
            possibleAnswers[9, 8] = "goulding";
            possibleAnswers[9, 9] = "asian";

            //Jake Paul
            possibleQuestions[10, 0] = "True or False: Jake Paul is #1.";
            possibleQuestions[10, 1] = "Finish the sentence: It's ________ bro.";
            possibleQuestions[10, 2] = "The Content Cop on Jake Paul was actually on _______.";
            possibleQuestions[10, 3] = "Jake Paul dated ______ before Erika.";
            possibleQuestions[10, 4] = "Jake Paul is the ___ god.";
            possibleQuestions[10, 5] = "Logan Paul is a false _______.";
            possibleQuestions[10, 6] = "Finish the sentence: Selling like a ___ church.";
            possibleQuestions[10, 7] = "In the Jake Paulers song, Jake Paul says \"its everyday bro, tatted on our ______\".";
            possibleQuestions[10, 8] = "Nick Crompton passes it to ______.";
            possibleQuestions[10, 9] = "The Martinez Twins ______ the language to Spanish.";

            //Jake Paul answers
            possibleAnswers[10, 0] = "true";
            possibleAnswers[10, 1] = "everyday";
            possibleAnswers[10, 2] = "aicegum";
            possibleAnswers[10, 3] = "alissa";
            possibleAnswers[10, 4] = "rap";
            possibleAnswers[10, 5] = "prophet";
            possibleAnswers[10, 6] = "god";
            possibleAnswers[10, 7] = "shirts";
            possibleAnswers[10, 8] = "chance";
            possibleAnswers[10, 9] = "switch";

            //Spanish Words
            possibleQuestions[11, 0] = "Spanish in Spanish is _______.";
            possibleQuestions[11, 1] = "Chair in Spanish is _____.";
            possibleQuestions[11, 2] = "Police in Spanish is _______.";
            possibleQuestions[11, 3] = "Beach in Spanish is _____.";
            possibleQuestions[11, 4] = "Pool in Spanish is _______.";
            possibleQuestions[11, 5] = "The infinitive form of the verb run in Spanish is ______.";
            possibleQuestions[11, 6] = "Keyboard in Spanish is _______.";
            possibleQuestions[11, 7] = "Raton in English is a _____.";
            possibleQuestions[11, 8] = "Gato in English is a ___.";
            possibleQuestions[11, 9] = "Perra in English is a ___.";

            //Spanish Words Answers
            possibleAnswers[11, 0] = "espanol";
            possibleAnswers[11, 1] = "silla";
            possibleAnswers[11, 2] = "policia";
            possibleAnswers[11, 3] = "playa";
            possibleAnswers[11, 4] = "piscina";
            possibleAnswers[11, 5] = "correr";
            possibleAnswers[11, 6] = "teclado";
            possibleAnswers[11, 7] = "mouse";
            possibleAnswers[11, 8] = "cat";
            possibleAnswers[11, 9] = "dog";

            //TV Shows
            possibleQuestions[12, 0] = "Eleanor Shellstrop is played by _______ Bell on The Good Place.";
            possibleQuestions[12, 1] = "Leslie Knope was the ______ Parks and Recreation Director.";
            possibleQuestions[12, 2] = "Dirk ______ is a holistic detective.";
            possibleQuestions[12, 3] = "Tahani from The Good Place was born in ________.";
            possibleQuestions[12, 4] = "Jake Paul starred in the greatest show of all time, ____________.";
            possibleQuestions[12, 5] = "Jessica Day is the \"___ Girl\".";
            possibleQuestions[12, 6] = "Archer's daughter's name is _________.";
            possibleQuestions[12, 7] = "____ is Francesca's true boyfriend on Master of None.";
            possibleQuestions[12, 8] = "_____ Black D'Elia plays Sage on Gossip Girl and Sabrina Pemberton on The Mick.";
            possibleQuestions[12, 9] = "Kaitlin _____ plays the titular character on The Mick and Dee on IASIP.";

            //TV Shows answers
            possibleAnswers[12, 0] = "kristen";
            possibleAnswers[12, 1] = "pawnee";
            possibleAnswers[12, 2] = "gently";
            possibleAnswers[12, 3] = "pakistan";
            possibleAnswers[12, 4] = "bizaardvaark";
            possibleAnswers[12, 5] = "new";
            possibleAnswers[12, 6] = "abbiejean";
            possibleAnswers[12, 7] = "pino";
            possibleAnswers[12, 8] = "sofia";
            possibleAnswers[12, 9] = "olson";

            //Video Games
            possibleQuestions[13, 0] = "The true identity of the Shadowman is _____.";
            possibleQuestions[13, 1] = "Kanetsugu, Mitsunari, and Yukimura swear an ____ of justice together in Samurai Warriors 4.";
            possibleQuestions[13, 2] = "The newest class in WoW is the _____ Hunter.";
            possibleQuestions[13, 3] = "In LEGO games, the money is _____.";
            possibleQuestions[13, 4] = "Dynasty Warriors tells the tale of the _____ Kingdoms Period.";
            possibleQuestions[13, 5] = "You can _____ jump in BO3 Multiplayer.";
            possibleQuestions[13, 6] = "COD Zombies has large hidden side quests known as ______ eggs.";
            possibleQuestions[13, 7] = "The goal in Nobunaga's Ambition is to unify _____.";
            possibleQuestions[13, 8] = "The goal in Romance of the Three Kingdoms is to unify _____.";
            possibleQuestions[13, 9] = "In Plants vs Zombies, the leader of the Zombies is known as Dr. _______.";

            //Video Games Answers
            possibleAnswers[13, 0] = "adele";
            possibleAnswers[13, 1] = "oath";
            possibleAnswers[13, 2] = "demon";
            possibleAnswers[13, 3] = "studs";
            possibleAnswers[13, 4] = "three";
            possibleAnswers[13, 5] = "boost";
            possibleAnswers[13, 6] = "easter";
            possibleAnswers[13, 7] = "japan";
            possibleAnswers[13, 8] = "china";
            possibleAnswers[13, 9] = "zomboss";

            //The Bachelor
            possibleQuestions[14, 0] = "The most recent Bachelor was Nick _____.";
            possibleQuestions[14, 1] = "______ was eliminated on the two-on-one date during Ben's season.";
            possibleQuestions[14, 2] = "The most recent Bachelorette was ______ Lindsay.";
            possibleQuestions[14, 3] = "Bachelor in ________ is the summer spinoff show of the Bachelor franchise.";
            possibleQuestions[14, 4] = "Taylor and _____ are one of the remaining couples from this season of Bachelor in Paradise.";
            possibleQuestions[14, 5] = "_____ was the runner up on Nick's season.";
            possibleQuestions[14, 6] = "On the two-on-one date on Chris' season, Ashley and Kelsey were ___ eliminated.";
            possibleQuestions[14, 7] = "Carly and ____ from Bachelor in Paradise Season 3 are now married.";
            possibleQuestions[14, 8] = "A new spinoff, the Bachelor ______ Games was announced earlier this year.";
            possibleQuestions[14, 9] = "___ and Lauren's show was called Happily Ever After.";

            //The Bachelor answers
            possibleAnswers[14, 0] = "viall";
            possibleAnswers[14, 1] = "olivia";
            possibleAnswers[14, 2] = "rachel";
            possibleAnswers[14, 3] = "paradise";
            possibleAnswers[14, 4] = "derek";
            possibleAnswers[14, 5] = "raven";
            possibleAnswers[14, 6] = "both";
            possibleAnswers[14, 7] = "evan";
            possibleAnswers[14, 8] = "winter";
            possibleAnswers[14, 9] = "ben";

            showTitle("Welcome to Jeopardy!");

            writeOut("Hello, and welcome to Jeopardy. Here, we will test your intelligence...");
            wait(1);
            writeOut("Or rather, just your ability to know random stuff.");
            wait(1);
            writeOut("Pick 5 topics from the list for your game:\nGeography\nEuropeanHist\nAnimals\nWeather\nSengokuPeriod\nAmericanHist\nGossipGirl\nRandom\nThreeKingdomsPeriod\nMusicians\nJakePaul\nSpanishWords\nTVShows\nVideoGames\nTheBachelor");
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
            wait(1);
            clear();
            writeLine("This game can be played alone, in a race to rack up points, or it can be played by 2 teams, to see who can get the most points. Which will it be? 1 or 2?");
            String respuesta = getOption("1", "2");
            if (respuesta == "1")
            {
                for (int e = 0; e < 25; e++)
                {
                    showBoard(use, topics);
                    writeLine("It's Player 1's turn. To pick a question, say the topic, followed by one space, and then the points: \"geography 100\".");
                    taken = getInput();
                    clear();
                    halves = taken.Split(' ');
                    writeLine(halves[0]);
                    writeLine(halves[1]);
                    theScore = Convert.ToInt32(halves[1]);
                    //takes the second number, converts to Int, divides it to 100 to be single digit, then subtracts by 1 since arrays start with 0
                    num = ((Convert.ToInt32(halves[1])) / 100) - 1;
                    use[getSlot(halves[0], topics), num] = false;
                    writeOut(questions[getSlot(halves[0], topics), num]);
                    taken = getInput();
                    if (taken == answers[getSlot(halves[0], topics), num])
                    {
                        score[0] += theScore;
                        writeLine("Correct! Your total score is currently: " + score[0]);
                    }
                    else
                    {
                        score[0] -= theScore;
                        writeLine("Incorrect. Your total score is currently: " + score[0] + "\nThe correct answer was " + answers[getSlot(halves[0], topics), num] + ".");
                    }
                    writeLine("Say yes when you're ready to continue.");
                    taken = getInput();

                }
                writeLine("Thanks for playing. You finished with: " + score[0]);
            }

            else {
                for (int e = 0; e < 25; e++)
                {
                    showBoard(use, topics);
                    if(turn == 1)
                    writeLine("It's Player 1's turn. To pick a question, say the topic, followed by one space, and then the points: \"geography 100\".");
                    else writeLine("It's Player 2's turn. To pick a question, say the topic, followed by one space, and then the points: \"geography 100\".");
                    taken = getInput();
                    clear();
                    halves = taken.Split(' ');
                    writeLine(halves[0]);
                    writeLine(halves[1]);
                    theScore = Convert.ToInt32(halves[1]);
                    //takes the second number, converts to Int, divides it to 100 to be single digit, then subtracts by 1 since arrays start with 0
                    num = ((Convert.ToInt32(halves[1])) / 100) - 1;
                    use[getSlot(halves[0], topics), num] = false;
                    writeOut(questions[getSlot(halves[0], topics), num]);
                    taken = getInput();
                    if (taken == answers[getSlot(halves[0], topics), num])
                    {
                        score[turn] += theScore;
                        writeLine("Correct! Player " + turn + ", your total score is currently: " + score[turn]);
                    }
                    else
                    {
                        score[turn] -= theScore;
                        writeLine("Incorrect. Player " + turn + ", your total is currently: " + score[turn]);
                        switchTurn();
                        writeOut("Player " + turn + ", the question has passed to you. The question was:\n" + questions[getSlot(halves[0], topics), num]);
                        taken = getInput();
                        if (taken == answers[getSlot(halves[0], topics), num])
                        {
                            score[turn] += theScore;
                            writeLine("Correct! Player "+turn+", your total score is currently: " + score[turn]);
                        }
                        else
                        {
                            writeLine("Incorrect. Player " + turn + ", your total score is currently: " + score[turn] + "\nThe correct answer was " + answers[getSlot(halves[0], topics), num] + ".");
                            switchTurn();
                        }
                    }
                    writeLine("Player " + turn + ", say yes when you're ready to continue.");
                    taken = getInput();

                }
                writeLine("Thanks for playing. Player 1 finished with " + score[1] + " and Player 2 finished with " + score[2] + ".");
                if (score[1] > score[2])
                    writeOut("Player 1 has won with " + score[1] + " points.");
                if (score[2] > score[1])
                    writeOut("Player 2 has won with " + score[2] + " points.");

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

        public void switchTurn()
            {
            if(turn == 1)
                turn = 2;
            else turn = 1;
}
       
    }
}
