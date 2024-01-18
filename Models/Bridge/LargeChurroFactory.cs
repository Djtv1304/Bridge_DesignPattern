namespace Bridge_DesignPattern.Models.Bridge
{
    public class LargeChurroFactory : ChurroFactory
    {

        public LargeChurroFactory(IChurroMachine churroMachine) : base(churroMachine)
        {
        
        
        }
        public override string MakeChurro()
        {

            return churroMachine.startChurroMachine();

        }

        public string typeOfChurro()
        {

            return "Large Churro";

        }

        public string getChurro()
        {

            return churroMachine.getChurro();

        }
    }
}
