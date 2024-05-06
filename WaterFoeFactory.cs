using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3
{
    public  class WaterFoeFactory : FoeFactory
    {
        public override Goblin CreateGoblin()
        {
            return new WaterGoblin();
        }
        public override Wizard CreateWizard()
        {
            return new WaterWizard();
        }
    }
}
