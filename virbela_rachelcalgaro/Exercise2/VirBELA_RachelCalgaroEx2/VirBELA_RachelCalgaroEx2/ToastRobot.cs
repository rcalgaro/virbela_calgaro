using System;
using System.Collections.Generic;
using System.Text;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The robot that stores the amount of bread being toasted.
    /// </summary>
    class ToastRobot : Robot
    {
        /// <summary>
        /// The toast count tracked by the robot.
        /// </summary>
        public int ToastCount { get; protected set; }

        /// <summary>
        /// The constructor for the toast robot.
        /// </summary>
        /// <param name="name">The name of the robot.</param>
        /// <param name="purpose">The purpose of the robot.</param>
        /// <param name="toastCount">The amount of bread being toasted.</param>
        public ToastRobot(string name, string purpose, int toastCount = 0)
        {
            Name = name;
            Purpose = purpose;
            ToastCount = toastCount;
        }

        /// <summary>
        /// Function to decrement the toast count, as the property is mutator protected.
        /// </summary>
        public void DecrementToastCount()
        {
            ToastCount--;
        }

        /// <summary>
        /// Function to increment the toast count, as the property is mutator protected.
        /// </summary>
        public void IncrementToastCount()
        {
            ToastCount++;
        }

        /// <summary>
        /// The override for MakeCopy function, to include the ToastCount.
        /// </summary>
        /// <param name="nameMod">The modifier for the Name.</param>
        /// <returns></returns>
        public override Robot MakeCopy(string nameMod)
        {
            ToastRobot temp = new ToastRobot(Name + nameMod, Purpose, ToastCount);
            return temp;
        }

        /// <summary>
        /// The override of the ToString function, to include the ToastCount.
        /// </summary>
        /// <returns>The robot information string.</returns>
        public override string ToString()
        {
            return string.Format("Name: {0} {1}Purpose: {2} {3}Toast Count: {4}{5}", Name, Environment.NewLine, Purpose,
                Environment.NewLine, ToastCount, Environment.NewLine);
        }
    }
}
