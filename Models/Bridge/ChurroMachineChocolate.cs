namespace Bridge_DesignPattern.Models.Bridge
{
    public class ChurroMachineChocolate : IChurroMachine
    {

        public string startChurroMachine()
        {
            
            return "Starting churro machine with chocolate";
            
        }

        public string getChurro()
        {

            return "Churro with chocolate";
            
        }

    }
}
