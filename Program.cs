using System;
using System.Text;
using System;
using System.Reflection.Metadata.Ecma335;

namespace AppolyonKnight
{
    partial class Program
    {
        static void Main(params string[] parameters)
        {
            string ipv4 = "192.168.137.50";
            int port = 7073;
            int teamIndex = 1;
            if (parameters.Length >= 1) ipv4 = parameters[0];
            if (parameters.Length >= 2) port = int.Parse(parameters[1]);
            if (parameters.Length >= 3) teamIndex = int.Parse(parameters[2]);

            //Add the ip of the teacher local computer.
            //Documentation:
            //https://github.com/EloiStree/2024_08_29_ScratchToWarcraft

            WowInteger wow = new WowInteger(teamIndex, ipv4, port);

            int spaceStart = 1032;
            int spaceStop = 2032;
            int waitingTime = 2000;
            int waitingTimeMove = 1000;
            int forward = 1090;
            int stopForward = 2090;
            int back = 1083;
            int stopBack = 2083;
            int moveLeft = 1087;
            int stopMoveLeft = 2087;
            int moveRight = 1088;
            int stopMoveRight = 2088;
            int turnLeft = 1081;
            int turnRight = 1068;
            int stopTurnLeft = 2081;
            int stopTurnRight = 2068;
            int assoir = 1067;
            int stopAssoir = 2067;
            int changeCible = 1009;
            int stopChangeCible = 2009;
            int interactCible = 1070;
            int stopInteractCible = 2070;
            int lanceSortOne = 1049;
            int stopLanceSortOne = 2049;
            int lanceSortTwo = 1050;
            int stopLanceSortTwo = 2050;
            int lanceSortThree = 1051;
            int stopLanceSortThree = 2051;
            int lanceSortFour = 1052;
            int stopLanceSortFour = 2052;
            int lanceSortFive = 1053;
            int stopLanceSortFive = 2053;
            int lanceSortSix = 1054;
            int stopLanceSortSix = 2054;
            int lanceSortSeven = 1055;
            int stopLanceSortSeven = 2055;
            int lanceSortEight = 1056;
            int stopLanceSortEight = 2056;
            int lanceSortNine = 1057;
            int stopLanceSortNine = 2057;


            //Action(wow, waitingTime, turnRight, stopTurnRight);
            //Action(wow, waitingTime, turnLeft, stopTurnLeft);
            //Action(wow, waitingTime, moveLeft, stopMoveLeft);
            //Action(wow, waitingTime, moveRight, stopMoveRight);
            //Action(wow, waitingTime, back, stopBack);
            //Action(wow, waitingTime, forward, stopForward);
            //Action(wow, waitingTime, spaceStart, spaceStop);
            //Action(wow, waitingTime, interactCible, stopInteractCible);
            //Action(wow, waitingTime, changeCible, stopChangeCible);
            //Action(wow, waitingTime, lanceSortOne, stopLanceSortOne);
            //Action(wow, waitingTime, lanceSortTwo, stopLanceSortTwo);
            //Action(wow, waitingTime, lanceSortThree, stopLanceSortThree);
            //Action(wow, waitingTime, lanceSortFour, stopLanceSortFour);
            //Action(wow, waitingTime, lanceSortFive, stopLanceSortFive);
            //Action(wow, waitingTime, lanceSortSix, stopLanceSortSix);
            //Action(wow, waitingTime, lanceSortSeven, stopLanceSortSeven);
            //Action(wow, waitingTime, lanceSortEight, stopLanceSortEight);
            //Action(wow, waitingTime, lanceSortNine, stopLanceSortNine);



            while (true)
            {
                int key = Console.Read();
                switch (key)
                {

                    case 122:

                        Action(wow, 1000, forward, stopForward);

                        break;

                    case 115:

                        Action(wow, 1000, back, stopBack);

                        break;

                    case 113:

                        Action(wow, 1000, moveLeft, stopMoveLeft);

                        break;

                    case 100:

                        Action(wow, 1000, moveRight, stopMoveRight);

                        break;

                    case 97:

                        Action(wow, 500, turnLeft, stopTurnLeft);

                        break;

                    case 101:

                        Action(wow, 500, turnRight, stopTurnRight);

                        break;

                    case 102:

                        Action(wow, waitingTime, interactCible, stopInteractCible);

                        break;

                    case 9:

                        Action(wow, waitingTime, changeCible, stopChangeCible);

                        break;

                    case 32:

                        Action(wow, waitingTime, spaceStart, spaceStop);

                        break;

                    case 49:

                        Action(wow, waitingTime, lanceSortOne, stopLanceSortOne);

                        break;

                    case 50:

                        Action(wow, waitingTime, lanceSortTwo, stopLanceSortTwo);

                        break;

                    case 51:

                        Action(wow, waitingTime, lanceSortThree, stopLanceSortThree);

                        break;

                    case 52:

                        Action(wow, waitingTime, lanceSortFour, stopLanceSortFour);

                        break;

                    case 53:

                        Action(wow, waitingTime, lanceSortFive, stopLanceSortFive);

                        break;

                    case 54:

                        Action(wow, waitingTime, lanceSortSix, stopLanceSortSix);

                        break;

                    case 55:

                        Action(wow, waitingTime, lanceSortSeven, stopLanceSortSeven);

                        break;

                    case 56:

                        Action(wow, waitingTime, lanceSortEight, stopLanceSortEight);

                        break;

                    case 57:

                        Action(wow, waitingTime, lanceSortNine, stopLanceSortNine);

                        break;
                }
            }

            //for (int i = 0; i < 1; i++)
            //{
            //    //Action(wow, 250, turnLeft, stopTurnLeft);
            //    //Action(wow, 500, turnRight, stopTurnRight);
            //    //Action(wow, 100, moveRight, stopMoveRight);
            //    //Action(wow, 500, moveLeft, stopMoveLeft);
            //    //Action(wow, 600, forward, stopForward);
            //    //Action(wow, waitingTime, interactCible, stopInteractCible);
            //    //Action(wow, waitingTime, changeCible, stopChangeCible);
            //    //Action(wow, waitingTime, lanceSortOne, stopLanceSortOne);
            //    //Action(wow, waitingTime, lanceSortOne, stopLanceSortOne);
            //}

            //while (true)
            //{
            //    wow.Push(spaceStart);
            //    Console.WriteLine("Jump");
            //    Thread.Sleep(waitingTime);
            //    wow.Push(spaceStop);
            //    Thread.Sleep(waitingTime);
            //}
        }

        private static void Action(WowInteger wow, int waitingTime, int action, int stopAction)
        {
            wow.Push(action);
            Console.WriteLine("Action");
            Thread.Sleep(waitingTime);
            wow.Push(stopAction);
            Thread.Sleep(waitingTime);
        }


    }
}
