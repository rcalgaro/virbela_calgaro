using System;
using System.Collections.Generic;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The robot that stores the amount of butter tabs.
    /// </summary>
    class ButterRobot: Robot
    {
        /// <summary>
        /// The butter count tracked by the robot.
        /// </summary>
        public int ButterCount { get; protected set; }

        /// <summary>
        /// The constructor for the butter robot.
        /// </summary>
        /// <param name="name">The robot name.</param>
        /// <param name="purpose">The robot's purpose.</param>
        /// <param name="butterCount">The current butter count.</param>
        public ButterRobot(string name, string purpose, int butterCount = 0)
        {
            Name = name;
            Purpose = purpose;
            ButterCount = butterCount;
        }

        /// <summary>
        /// Function to decrement the butter count, as the property is mutator protected.
        /// </summary>
        public void DecrementButterCount()
        {
            ButterCount--;
        }

        /// <summary>
        /// Function to increment the butter count, as the property is mutator protected.
        /// </summary>
        public void IncrementButterCount()
        {
            ButterCount++;
        }

        /// <summary>
        /// The override for MakeCopy function, to include the ButterCount.
        /// </summary>
        /// <param name="nameMod">The modifier for the Name.</param>
        /// <returns></returns>
        public override Robot MakeCopy(string nameMod)
        {
            ButterRobot temp = new ButterRobot(Name + nameMod, Purpose, ButterCount);
            return temp;
        }

        /// <summary>
        /// The override of the ToString function, to include the ButterCount.
        /// </summary>
        /// <returns>The robot information string.</returns>
        public override string ToString()
        {
            return string.Format("Name: {0} {1}Purpose: {2} {3}Butter Count: {4}{5}", Name, Environment.NewLine, Purpose, 
                Environment.NewLine, ButterCount, Environment.NewLine);
        }
    }
}
