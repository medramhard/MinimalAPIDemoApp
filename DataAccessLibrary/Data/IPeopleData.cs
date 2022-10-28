using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;
public interface IPeopleData
{
    Task DeletePersonAsync(int id);
    Task<AddressModel?> GetAddressAsync(int id);
    Task<IEnumerable<AddressModel>> GetAllAddressesAsync();
    Task<IEnumerable<PersonModel>> GetAllPeopleAsync();
    Task<FullPersonModel?> GetFullPersonInfoAsync(int id);
    Task<PersonModel?> GetPersonAsync(int id);
    Task InsertAddressAsync(AddressModel address);
    Task InsertPersonAsync(PersonModel person);
    Task UpdateAddressAsync(AddressModel address);
    Task UpdatePersonAsync(PersonModel person);
}