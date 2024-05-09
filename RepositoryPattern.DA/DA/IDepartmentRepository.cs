using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DA
{
    public interface IDepartmentRepository
    {
        List<Department> Get();
        Department Get(int id);
        bool Add(Department DepartmentNO);
        bool Update(Department DepartmentNO);
        bool Delete(int id);
    }
}
