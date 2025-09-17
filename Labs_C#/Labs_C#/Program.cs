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
        var new_out = new StreamWriter(@"graph_output.txt");
        var new_in = new StreamReader(@"graph_input.txt");
        Console.SetOut(new_out);
        Console.SetIn(new_in);

#endif
        Graph graph = new Graph();

#if DEBUG
        graph = new Graph(-3.5, 11);
        graph.PrintInfo(ConsoleColor.Yellow, ConsoleColor.Blue);
#endif
#if !DEBUG
        graph = graph.CreateGraphFromFile();
        graph.PrintInfo(graph.a, graph.b);
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