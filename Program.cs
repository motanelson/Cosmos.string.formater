using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Xml.Serialization;
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
}
    

class strings {
    static void Main()
    {
        String[] s = "x86,8086\nx86,80186\nx86,80286\nx86,80386\nx86,80486".Split("\n");
        Console.BackgroundColor= ConsoleColor.White;
        Console.ForegroundColor= ConsoleColor.Black;
        Console.Clear();
        formarter.tables(s,10,10);
                
    }
}
