using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    public class WorkFlowEngine
    {  public void Run(IWorkFlow workFlow)
        {
            foreach (var Activity in workFlow.GetActivities())
            {
                Activity.Execute();
            }
        }

    }
}

