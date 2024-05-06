using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3
{
    public abstract class FoeFactory
    {
        public abstract Wizard CreateWizard();
        public abstract Goblin CreateGoblin();
    }
}
