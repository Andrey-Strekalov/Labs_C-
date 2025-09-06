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

        Par par = new Par();
        par.Load();
        par.Info();
#if !DEBUG
        Console.SetOut(save_out); new_out.Close();
        Console.SetIn(save_in); new_in.Close();
#else
        Console.ReadKey();
#endif

    }
}