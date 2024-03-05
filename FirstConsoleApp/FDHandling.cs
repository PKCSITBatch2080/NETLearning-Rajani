

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Loop to create 10 files
        for (int i = 1; i <= 10; i++)
        {
            // Define the filename for each iteration
            string filename = $"file{i}.cs";

            // Write the byte variable "age" with corresponding value to the file
            string content = $"byte age = {i};";

            // Write content to the file
            File.WriteAllText(filename, content);

            //reading
            string content = filename.ReadAllText("please enter the path of a file in want to display")
            var words = content.split ([",", '.', ';', '-'])
            console.Writeline()
        }
    }
}
