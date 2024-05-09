using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DA
{
    public class DepartmentRepository : IDepartmentRepository
    {
        List<Department> listDepartment = new List<Department>()
        {
            new Department(1, "Tasfia"),
            new Department(2, "Adil"),
            new Department(3, "Tanjida"),
            new Department(4, "Saifan")
        };
        public List<Department> Get()
        {
            return listDepartment.OrderBy(x => x.DepartmentName).ToList();
        }

        public Department Get(int id)
        {
            Department oDepartment = listDepartment.Where(x => x.DepartmentId == id).FirstOrDefault();
            return oDepartment;
        }

        public bool Add(Department DepartmentNO)
        {
            listDepartment.Add(DepartmentNO);
            return true;
        }

        public bool Update(Department DepartmentNO)
        {
            bool isExecuted = false;
            Department oDepartment = listDepartment.Where(x => x.DepartmentId == DepartmentNO.DepartmentId).FirstOrDefault();
            if (oDepartment != null)
            {
                listDepartment.Remove(oDepartment);
                listDepartment.Add(DepartmentNO);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Department oDepartment = listDepartment.Where(x => x.DepartmentId == id).FirstOrDefault();
            if (oDepartment != null)
            {
                listDepartment.Remove(oDepartment);
                isExecuted = true;
            }
            return isExecuted;
        }

    }
}
