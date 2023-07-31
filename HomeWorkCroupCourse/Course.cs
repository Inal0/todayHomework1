using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkCroupCourse
{
    internal class Course
    {
       
      
            public string name;
            public Group[] groups = new Group[0];


            public void AddGroup(Group group)
            {
                Array.Resize(ref groups, groups.Length + 1);
                groups[groups.Length - 1] = group;
            }
        }
}
