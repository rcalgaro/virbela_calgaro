using System;
using System.Collections.Generic;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The delivery robot class.
    /// </summary>
    class DeliveryRobot: Robot
    {
        /// <summary>
        /// The destination for the delivery robot.
        /// </summary>
        protected string Destination { get; set; }

        /// <summary>
        /// The delivery robot constructor.
        /// </summary>
        /// <param name="name">The name of the robot.</param>
        /// <param name="purpose">The purpose of the robot.</param>
        /// <param name="destination">The destination of the robot.</param>
        public DeliveryRobot(string name, string purpose, string destination)
        {
            Name = name;
            Purpose = purpose;
            Destination = destination;
        }

        /// <summary>
        /// The override for MakeCopy function, to include the Desination.
        /// </summary>
        /// <param name="nameMod">The modifier for the Name.</param>
        /// <returns></returns>
        public override Robot MakeCopy(string nameMod)
        {
            DeliveryRobot temp = new DeliveryRobot(Name + nameMod, Purpose, Destination);
            return temp;
        }

        /// <summary>
        /// The override of the ToString function, to include the Destination.
        /// </summary>
        /// <returns>The robot information string.</returns>
        public override string ToString()
        {
            return string.Format("Name: {0} {1}Purpose: {2} {3}Destination: {4}{5}", Name, Environment.NewLine,
                Purpose, Environment.NewLine, Destination, Environment.NewLine);
        }
    }
}
