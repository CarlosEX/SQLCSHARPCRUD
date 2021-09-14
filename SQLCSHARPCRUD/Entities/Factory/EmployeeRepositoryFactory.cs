
namespace SQLCSHARPCRUD {
    public class EmployeeRepositoryFactory {
        public static IEmployeeRepository Create() {
            return new EmployeeRepository();
        }
    }
}
