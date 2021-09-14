
namespace SQLCSHARPCRUD {
    public class Employee : IEmployee {
        private int _id;
        private string _firstName;
        private string _lastName;

        public int Id { get => _id; set => _id = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string FullName {
            get => $"{_firstName} {_lastName}";
        }
    }
}
