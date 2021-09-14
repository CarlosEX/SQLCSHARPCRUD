using System.Collections.Generic;
using System.Data;

namespace SQLCSHARPCRUD {
    public interface IEmployeeRepository {
        IList<IEmployee> GetAll();
        DataTable GetGenderDataTable();
        void Add(IEmployee employee);
        void Update(IEmployee employee);
        void Delete(int id);
    }
}