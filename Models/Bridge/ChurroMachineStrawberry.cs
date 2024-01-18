
namespace Bridge_DesignPattern.Models.Bridge
{
    public class ChurroMachineStrawberry : IChurroMachine
    {

        public string startChurroMachine()
        {

            return "Starting churro machine with Strawberry";

        }

        public string getChurro()
        {

            return "Churro with Strawberry";

        }

    }
}
