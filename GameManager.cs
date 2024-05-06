using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3
{
    public class GameManager
    {
        private Wizard wizard;
        private Goblin goblin;

        public GameManager(FoeFactory foeFactory)
        {
            wizard = foeFactory.CreateWizard();
            goblin = foeFactory.CreateGoblin();
        }
         public void Run()
        {
            wizard.DoMagic();
            goblin.DoDamage();

        }
    }
}
