using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOnInterfaces
{
    class WorkFlow : IWorkFlow
    {

         public IList<IActivity> _Activties;

        public WorkFlow()
        {
            _Activties = new List<IActivity>();
        }

        public IEnumerable<IActivity> GetActivities()
        {
            return _Activties;
        }

        public void RegisterActivity(IActivity Activity)
        {
            _Activties.Add(Activity);

        }

    }
}
