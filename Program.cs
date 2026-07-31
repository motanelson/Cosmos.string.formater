using System;
class formarter {
    public static String spaces(int i) {
        String s = "";
        for (int j = 0; j < i; j++)
        {
            s=s+" ";
        }
        return s;
    }

    public static void writer(String s,int backs,int nexts) {
        Console.Write(spaces(backs));
        Console.Write(s);
        Console.Write(spaces(nexts));
    }
    public static void rows(String[] s, int backs, int nexts)
    {
        foreach (var ss in s)
        {
            writer(ss, backs-ss.Length, nexts);
            Console.Write("|");
        }
    }
    public static void tables(String[] s,int backs,int nexts) 
    {
        int counter = 0;
        foreach (var ss in s) {
            if ((counter & 1) == 1)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                rows(ss.Split(","), backs, nexts);
                Console.WriteLine("");
            }
            else
            {

                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                rows(ss.Split(","), backs, nexts);
                Console.WriteLine("");
            }
            counter++;
        }
    }
    public static void files(String s,int backs, int nexts)
    {
        String[] ss;
        ss = s.Split("\r\n");
        tables(ss, backs, nexts);
    }
}
    

class strings {
    static void Main()
    {
        String[] s ;
        String ss = "";
        String f = "";
        Console.BackgroundColor= ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        Console.Clear();
        Console.WriteLine("give me a file .csv to read");
        ss = Console.ReadLine();
        Console.Clear();
        f= File.ReadAllText(ss);
        
        formarter.files(f,10,1);
                
    }
}
