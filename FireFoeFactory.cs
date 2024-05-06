using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3
{
    public class FireFoeFactory : FoeFactory
    {
        public override Goblin CreateGoblin()
        {
            return new FireGoblin();
        }

        public override Wizard CreateWizard()
        {
            return new FireWizard();
        }
    }
}
