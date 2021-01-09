using System;
using System.Collections.Generic;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    class VonNeumannRobot: Robot
    {
        /// <summary>
        /// The constructor for VonNeumannRobot.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="purpose"></param>
        public VonNeumannRobot(string name, string purpose)
        {
            Name = name;
            Purpose = purpose;
        }

        /// <summary>
        /// Function to copy the passed in robot with a specific modifier to the name.
        /// </summary>
        /// <param name="robot">The robot to copy.</param>
        /// <param name="nameMod">The modifier to the Name.</param>
        /// <returns></returns>
        public Robot CopyRobot(Robot robot, string nameMod = "")
        {
            // I debated doing this differently based on the wording of the assignment, but decided to do it this way so that
            // the name could not be changed publicly by anything. If the Name property was completely public, I would have had that name change happen here
            // instead of inside each robot's MakeCopy function. In that case, the MakeCopy function would only *only* make a copy, with no modifications.
            Robot temp = robot.MakeCopy(nameMod);

            return temp;
        }

        /// <summary>
        /// Make new robot that has the same information as this robot, with a name modifier.
        /// </summary>
        /// <param name="nameMod">The modifier to append to the Name.</param>
        /// <returns></returns>
        public override Robot MakeCopy(string nameMod)
        {
            VonNeumannRobot temp = new VonNeumannRobot(Name + nameMod, Purpose);
            return temp;
        }
    }
}
