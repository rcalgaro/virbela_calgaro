using System;

namespace VirBELA_RachelCalgaroEx2
{
    /// <summary>
    /// The program class to do the work.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main function.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Create all the robots.
            Robot robot = new Robot();
            ToastRobot toastRobot = new ToastRobot("Toasty", "To Toast", 2);
            ButterRobot butterRobot = new ButterRobot("Butterfingers", "Butter Toast", 5);
            VonNeumannRobot vonNeumannRobot = new VonNeumannRobot("Vonny", "Copy the Robots");
            DeliveryRobot deliveryRobot1 = new DeliveryRobot("Weatherboy", "Deliver those packages", "Wouldnt you like to know");
            DeliveryRobot deliveryRobot2 = new DeliveryRobot("Postman", "Deliver this package", "The fires of Mount Doom");

            Logger logger = new Logger();

            // Print all the robots to the console.
            logger.Print(robot);
            logger.Print(toastRobot);
            logger.Print(butterRobot);
            logger.Print(vonNeumannRobot);
            logger.Print(deliveryRobot1);
            logger.Print(deliveryRobot2);

            // Print the copied robots to the console.
            logger.Print(vonNeumannRobot.CopyRobot(butterRobot, "_copy"));
            logger.Print(vonNeumannRobot.CopyRobot(toastRobot, "_copy"));
            logger.Print(vonNeumannRobot.CopyRobot(deliveryRobot1, "_2"));
            logger.Print(vonNeumannRobot.CopyRobot(deliveryRobot2, "_2"));

            // Print some robots to text files.
            logger.PrintToNewFile(butterRobot, "butterRobot.txt");
            logger.PrintToFile(vonNeumannRobot.CopyRobot(butterRobot, "_2"), "butterRobot.txt");
            logger.PrintToNewFile(toastRobot);
            logger.PrintToFile(vonNeumannRobot);
            logger.PrintToFile(deliveryRobot1);
            logger.PrintToFile(deliveryRobot2);

            // TODO any further tests can be added here.
        }
    }
}
