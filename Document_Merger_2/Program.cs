using System;
using System.IO;

namespace Document_Merger_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "";
            if (args.Length < 3)
            {
                Console.WriteLine("DocumentMerger2 <input_file_1> <input_file_2> ... <input_file_n> <output_file>");
                Console.WriteLine("Supply a list of text files to merge followed by the name of the resulting merged text file as command line arguments.");
            }
            else
            {
                for (int i = 0; i < args.Length - 1; i++)
                {
                    try
                    {
                        string t = System.IO.File.ReadAllText(args[i] + ".txt");
                        text += t + "\n";
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The file didn't exist");
                        Environment.Exit(0);
                    }
                }
                string file_name= args[args.Length - 1];
                StreamWriter streamWriter = new StreamWriter(file_name+".txt");
                streamWriter.WriteLine(text);
                streamWriter.Close();
                Console.WriteLine(file_name + ".txt is saved");

            }
        }
    }
}
