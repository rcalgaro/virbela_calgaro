using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The class that handles the logging behaviour.
    /// </summary>
    class Logger
    {
        /// <summary>
        /// The current directory path.
        /// </summary>
        private string _path = Directory.GetCurrentDirectory() + @"\";
        /// <summary>
        /// The default output file name.
        /// </summary>
        private const string _fileName = "loggerOutput.txt";

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Logger()
        {

        }

        /// <summary>
        /// Print the robot information to the console.
        /// </summary>
        /// <param name="robot">The robot.</param>
        public void Print(Robot robot)
        {
            Console.WriteLine(robot.ToString());
        }

        /// <summary>
        /// Print the robot information to a new file with specified filename.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="fileName">The filename to print to.</param>
        public void PrintToNewFile(Robot robot, string fileName = _fileName)
        {
            try
            {
                // Use stream writer to open new file, write string, then close.
                StreamWriter sw = new StreamWriter(_path + fileName);
                sw.Write(robot.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                // if something goes wrong, print message.
                Console.WriteLine("Could not write to file: " + e.Message);
            }
            finally
            {
                // Print out where the file was saved, or attempted to save.
                Console.WriteLine("Wrote robot to file: " + _path + fileName);
            }
        }

        /// <summary>
        /// Print the robot information to the specified filename. If the file already exists, append the text.
        /// </summary>
        /// <param name="robot">The robot.</param>
        /// <param name="fileName">The filename to print to.</param>
        public void PrintToFile(Robot robot, string fileName = _fileName)
        {
            try
            {
                // Use stream writer to open new or existing file, append string to file, then close.
                StreamWriter sw = File.AppendText(_path + fileName);
                sw.Write(robot.ToString());
                sw.Close();
            }
            catch (Exception e)
            {
                // if something goes wrong, print message.
                Console.WriteLine("Could not write to file: " + e.Message);
            }
            finally
            {
                // Print out where the file was saved, or attempted to save.
                Console.WriteLine("Wrote robot to file: " + _path + fileName);
            }
        }
    }
}
