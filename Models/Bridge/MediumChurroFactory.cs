namespace Bridge_DesignPattern.Models.Bridge
{
    public class MediumChurroFactory : ChurroFactory
    {

        public MediumChurroFactory(IChurroMachine churroMachine) : base(churroMachine)
        {
        
        

        }
        public override string MakeChurro()
        {

            return churroMachine.startChurroMachine();

        }

        public string typeOfChurro()
        {

            return "Medium Churro";

        }

        public string getChurro()
        {

            return churroMachine.getChurro();

        }
    }
}
