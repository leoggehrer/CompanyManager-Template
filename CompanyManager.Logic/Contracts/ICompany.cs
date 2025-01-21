namespace CompanyManager.Logic.Contracts
{
    public interface ICompany : IIdentifiable
    {
        string Name { get; set; }
        string Address { get; set; }
    }
}
