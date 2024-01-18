namespace Bridge_DesignPattern.Models.Bridge
{
    public abstract class ChurroFactory
    {

        protected IChurroMachine churroMachine;

        public ChurroFactory(IChurroMachine churroMachine)
        {
            this.churroMachine = churroMachine;
        }

        public abstract string MakeChurro();

    }
}
