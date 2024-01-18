namespace Bridge_DesignPattern.Models.Bridge
{
    public class SmallChurroFactory : ChurroFactory
    {

        public SmallChurroFactory(IChurroMachine churroMachine) : base(churroMachine)
        {



        }   

        public override string MakeChurro()
        {   

            return churroMachine.startChurroMachine();

        }

        public string typeOfChurro()
        {

            return "Small Churro";

        }

        public string getChurro()
        {

            return churroMachine.getChurro();

        }
    }
}
