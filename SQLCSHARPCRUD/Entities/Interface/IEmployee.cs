namespace SQLCSHARPCRUD {
    public interface IEmployee {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; }
    }
}