using Bridge_DesignPattern.Models.Bridge;

namespace Bridge_DesignPattern.Utils
{
    public static class Util
    {

        // Create Machines
        public static ChurroMachineChocolate cmChocolate = new ChurroMachineChocolate();
        public static ChurroMachineStrawberry cmStrawberry = new ChurroMachineStrawberry();

        // Create Factories
        public static SmallChurroFactory smallChurroFactory = new SmallChurroFactory(cmChocolate);
        public static MediumChurroFactory mediumChurroFactory = new MediumChurroFactory(cmStrawberry);
        public static LargeChurroFactory largeChurroFactory = new LargeChurroFactory(cmChocolate);

    }
}
