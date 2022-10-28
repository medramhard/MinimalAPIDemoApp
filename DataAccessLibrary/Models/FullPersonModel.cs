namespace DataAccessLibrary.Models;
public class FullPersonModel
{
    public PersonModel? Base { get; set; }
    public AddressModel? Address { get; set; } = new();
}
