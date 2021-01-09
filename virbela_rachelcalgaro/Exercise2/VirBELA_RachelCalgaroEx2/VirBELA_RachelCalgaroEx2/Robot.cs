using System;
using System.Collections.Generic;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The base Robot class that is the parent of all robots. I decided to use basic inheritance because Name and Purpose are something that all robots have in common.
    /// All of the robots also need to be able to be copied, and print out their info. This could have been done in other ways as well, but this made the most sense to me in this scenario.
    /// </summary>
    class Robot
    {
        /// <summary>
        /// The robot's name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// The robot's purpose.
        /// </summary>
        public string Purpose { get; protected set; }

        /// <summary>
        /// The Robot constructor.
        /// </summary>
        public Robot()
        {
            Name = "Robot";
            Purpose = "Destroy All Humans";
        }

        /// <summary>
        /// The overloaded Robot constructor.
        /// </summary>
        /// <param name="name">The name of the robot.</param>
        /// <param name="purpose">The purpose of the robot.</param>
        public Robot(string name, string purpose)
        {
            Name = name;
            Purpose = purpose;
        }

        /// <summary>
        /// Function to make a new Robot with the same Name and Purpose values.
        /// </summary>
        /// <returns></returns>
        public virtual Robot MakeCopy(string nameMod)
        {
            Robot temp = new Robot(Name + nameMod, Purpose);
            return temp;
        }

        /// <summary>
        /// Function to print the information stored in the Robot.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Name: {0} {1}Purpose: {2} {3}", Name, Environment.NewLine, Purpose, Environment.NewLine);
        }

    }
}
