using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DA
{
    public class Department
    {
        public int DepartmentId;
        public string DepartmentName;

        public Department()
        {
        }
        public Department(int id, string name)
        {
            DepartmentId = id;
            DepartmentName = name;

        }
    }
}
