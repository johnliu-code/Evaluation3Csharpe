using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation3_Yongjiang
{
    interface IComportement
    {
        double Accelerer(double speed);
        DateTime Arreter(DateTime stoptime);
    }
}
