ConsoleKeyInfo cki = new ConsoleKeyInfo();
string exit = "";

            while (true)
            {
                Console.Write("1 ");
                if (Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey(true);
                    exit += cki.KeyChar.ToString();
                }
                if (exit.Contains("exit")) break;                  
            }
                            
            Console.Write("Цикл завершился");
            Console.ReadKey();