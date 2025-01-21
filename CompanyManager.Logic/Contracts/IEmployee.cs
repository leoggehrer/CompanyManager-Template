namespace CompanyManager.Logic.Contracts
{
    public interface IEmployee : IIdentifiable
    {
        int CompanyId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
