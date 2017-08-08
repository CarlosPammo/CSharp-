using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        public static Thread FirstThread { get; set; }
        public static Thread SecondThread { get; set; }
        public static void CallSecondThread()
        {
            var index = 0;
            while (true)
            {
                Console.WriteLine("Process in second Thread {0}",
                    index++);
                Thread.Sleep(2000);
            }
        }

        public static void CallFirstThread()
        {
            SecondThread = new Thread(CallSecondThread);
            SecondThread.Start();
            var index = 0;
            while (true)
            {
                Console.WriteLine("Process in main thread {0}", index++);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            const int maxMenuItems = 4;
            int selector = 0;
            bool good = false;

            while (selector != maxMenuItems)
            {
                Console.Clear();
                DrawTitle();
                DrawMenu(maxMenuItems);
                good = int.TryParse(Console.ReadLine(), out selector);
                if (good)
                {
                    switch (selector)
                    {
                        case 1:
                            FirstThread = new Thread(() =>
                            {
                                var index = 0;
                                while (true)
                                {
                                    Console.WriteLine("First {0}", index++);
                                    Thread.Sleep(1000);
                                }
                            });
                            
                            break;
                        case 2:
                            if (FirstThread == null)
                            {
                                Console.WriteLine("You need to create a main thread");
                            }
                            else
                            {
                                SecondThread = new Thread(CallSecondThread);
                            }
                            break;
                        case 3:
                            if (FirstThread != null && !FirstThread.IsAlive)
                            {
                                if (FirstThread != null && !FirstThread.IsAlive && SecondThread != null &&
                                    !SecondThread.IsAlive)
                                {
                                    FirstThread = new Thread(CallFirstThread);
                                    FirstThread.Start();
                                    Thread.Sleep(5000);
                                    Console.WriteLine("Stopping Process");
                                    SecondThread.Abort();
                                    FirstThread.Abort();
                                }
                                else
                                {
                                    FirstThread.Start();
                                    Thread.Sleep(5000);
                                    Console.WriteLine("Stopping Process");
                                    FirstThread.Abort();
                                }
                                
                            }
                            else
                            {
                                Console.WriteLine("You need to create a main thread");
                            }
                            
                            break;
                        default:
                            if (selector != maxMenuItems)
                            {
                                ErrorMessage();
                            }
                            break;
                    }
                }
                else
                {
                    ErrorMessage();
                }

                Console.WriteLine("Please, press key to continue");
                Console.ReadKey();
            }
        }

        private static void DrawTitle()
        {
            DrawStarLine();
            Console.WriteLine("+++   Example for multithreading process   +++");
            DrawStarLine();
        }

        private static void ErrorMessage()
        {
            Console.WriteLine("Typing error, press key to continue.");
        }

        private static void DrawMenu(int maxMenuItems)
        {
                DrawStarLine();
                Console.WriteLine(" 1. Create main thread");
                Console.WriteLine(" 2. Create secondary thread");
                Console.WriteLine(" 3. Run process");
                Console.WriteLine(" 4. Exit program");
                DrawStarLine();
                Console.WriteLine("Make your choice: type 1, 2, 3,... or {0} for exit", maxMenuItems);
                DrawStarLine();   
        }

        private static void DrawStarLine()
        {
            Console.WriteLine("************************");
        }
    }
}
