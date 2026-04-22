using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursovaya;
interface WorkAlgorytm
{
    public IEnumerable StepByStep();
    public bool SaveMinCost(string path = null);
    public int LoadMinCost(string path = null);
}

