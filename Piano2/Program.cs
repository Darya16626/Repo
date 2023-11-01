internal class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo txt = Console.ReadKey();
        do
        {
            Console.WriteLine("Актава 1 - F1, Актава 2 - F2, Актава 3 - F3. Выход - Enter");
            txt = Console.ReadKey();
            switch (txt.Key)
            {
                case ConsoleKey.F1:
                    {
                        
                        foreach (int muz in Muz())
                        {
                            muzic(muz * 2);
                            Console.ReadKey();
                            Console.Write(" \r");
                        }
                        Console.WriteLine();
                        break;
                    }
                case ConsoleKey.F2:
                    {
                        
                        foreach (int muz in Muz())
                        {
                            muzic(muz * 3);
                            Console.ReadKey();
                            Console.Write(" \r");
                        }
                        Console.WriteLine();
                        break;
                    }
                case ConsoleKey.F3:
                    {
                        
                        foreach (int muz in Muz())
                        {
                            muzic(muz * 4);
                            Console.ReadKey();
                            Console.Write(" \r");
                        }
                        Console.WriteLine();
                        break;
                    }
            }
        }
        while (txt.Key != ConsoleKey.Enter);
    }
    static void muzic(int muz)
    {
        Console.Beep(muz, 400);
    }
    static int[] Muz()
    {
        int[] muz001 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
        return muz001;
    }
}