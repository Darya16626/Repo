internal class Program
{
    static void Main(string[] args)
    {
        ConsoleKeyInfo txt = Console.ReadKey(true);
        do
        {
            txt = Console.ReadKey();
            switch (txt.Key)
            {
                case ConsoleKey.F1:
                    {
                        int[] muz01 = new int[12] { 65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123 };
                        foreach (int muz in muz01)
                        {
                            muzic(muz);
                        }
                        break;
                    }
                case ConsoleKey.F2:
                    {
                        int[] muz02 = new int[12] { 130, 138, 146, 155, 164, 174, 185, 196, 207, 220, 233, 246 };
                        foreach (int muz in muz02)
                        {
                            muzic(muz);
                        }
                        break;
                    }
                case ConsoleKey.F3:
                    {
                        int[] muz03 = new int[12] { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
                        foreach (int muz in muz03)
                        {
                            muzic(muz);
                        }
                        break;
                    }
            }
        }
        while (txt.Key != ConsoleKey.Enter);
    }
    static void muzic(int muz)
    {
        Console.Beep(muz, 300);
    }
}