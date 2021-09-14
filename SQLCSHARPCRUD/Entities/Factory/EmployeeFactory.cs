
namespace SQLCSHARPCRUD {
    public class EmployeeFactory {
        public static IEmployee Create() {
            return new Employee();
        }
    }
}
