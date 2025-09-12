using System;
using System.IO;


namespace Labs_C_;



public class MainClass
{

    public static void Main()
    {


#if !DEBUG

        TextWriter save_out = Console.Out;
        TextReader save_in = Console.In;
        var new_out = new StreamWriter(@"par_output.txt");
        var new_in = new StreamReader(@"par_input.txt");
        Console.SetOut(new_out);
        Console.SetIn(new_in);

#endif
        Par p1, p2;

#if DEBUG
        p2 = new Par(5.7, 11, 18);
        p2.Info(ConsoleColor.Yellow, ConsoleColor.Blue);
#endif
#if !DEBUG
        p1 = Par.CreateParFromFile();
        p1.Info(); ;
        p2 = new Par(5.6, 5.11, 10.5);
        p2.Info();
#endif
#if !DEBUG
        Console.SetOut(save_out); new_out.Close();
        Console.SetIn(save_in); new_in.Close();
#endif
#if !DEBUG
        Console.ReadKey();
#endif

    }
}