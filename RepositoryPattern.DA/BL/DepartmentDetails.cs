using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.DA
{
    public class DepartmentDetails
    {
        IDepartmentRepository _repository;

        public DepartmentDetails(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public List<Department> Get()
        {
            return _repository.Get();
        }

        public Department Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Department DepartmentNO)
        {
            return _repository.Add(DepartmentNO);
        }

        public bool Update(Department DepartmentNO)
        {
            return _repository.Update(DepartmentNO);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

    }
}
