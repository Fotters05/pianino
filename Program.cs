
       while (true)
       {
Console.WriteLine("Белые клавиши: Q,W,E,A,S,D");
Console.WriteLine("Чёрные клавиши: R,T,Y,F,G,H");
Console.WriteLine("Октавы: F1, F2, F3, F4");
Console.WriteLine("Выход - Escape");
Console.WriteLine("Выбери октаву");
ConsoleKeyInfo key = Console.ReadKey();
Console.Clear();
Noti(key.Key);

static void Noti(ConsoleKey key)
{
        (int[] whiteKeysOctave1, int[] whiteKeysOctave2, int[] blackKeysOctave1, int[] blackKeysOctave2) = GetOctaves();

        int[] octave;

        switch (key)
        {
            case ConsoleKey.F1:
                octave = whiteKeysOctave1;
                break;
            case ConsoleKey.F2:
                octave = blackKeysOctave1;
                break;
            case ConsoleKey.F3:
                octave = whiteKeysOctave2;
                break;
            case ConsoleKey.F4:
                octave = blackKeysOctave2;
                break;
            default:
                return;
        }

        Console.WriteLine("Если вы хотите вернуться в меню к выбору октавы, нажмите клавишу Backspace");
        Console.WriteLine("Для выхода программы нажмите клавишу Escape");

        while (true)
        {
            ConsoleKeyInfo noteKey = Console.ReadKey();
            Console.Clear();

            if (noteKey.Key == ConsoleKey.Escape)
                break;

            switch (noteKey.Key)
            {
                case ConsoleKey.A:
                    Console.Beep(octave[0], 150);
                    break;
                case ConsoleKey.S:
                    Console.Beep(octave[1], 150);
                    break;
                case ConsoleKey.D:
                    Console.Beep(octave[2], 150);
                    break;
                case ConsoleKey.F:
                    Console.Beep(octave[3], 150);
                    break;
                case ConsoleKey.G:
                    Console.Beep(octave[4], 150);
                    break;
                case ConsoleKey.H:
                    Console.Beep(octave[5], 150);
                    break;
                case ConsoleKey.W:
                    Console.Beep(octave[0],  150);
                    break;
                case ConsoleKey.E:
                    Console.Beep(octave[1], 150);
                    break;
                case ConsoleKey.R:
                    Console.Beep(octave[3], 150);
                    break;
                case ConsoleKey.T:
                    Console.Beep(octave[4], 150);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(octave[5], 150);
                    break;
            }
        }
    }

    static (int[], int[], int[], int[]) GetOctaves()
    {
        int[] whiteKeysOctave1 = { 1635, 1835, 2060, 2312, 2596, 2914 };
        int[] whiteKeysOctave2 = { 1732, 1945, 2183, 2450, 2750, 3087 };
        int[] blackKeysOctave1 = { 3270, 3671, 4120, 4625, 5191, 5827 };
        int[] blackKeysOctave2 = { 3465, 3889, 4365, 4900, 5500, 6174 };

        return (whiteKeysOctave1, whiteKeysOctave2, blackKeysOctave1, blackKeysOctave2);
    }
}