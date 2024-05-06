using System;

namespace Zadaca3
{
    public class Test
    {
        public static void Main(string[] args)
        {
            FoeFactory WaterFactory = new WaterFoeFactory();
           GameManager manager = new GameManager(WaterFactory);
            manager.Run();

            FoeFactory FireFactory = new FireFoeFactory();
            manager = new GameManager(FireFactory);
            manager.Run();

        }
    }
}
