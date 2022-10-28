using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;

namespace DataAccessLibrary.Data;
public class PeopleData : IPeopleData
{
    private readonly ISqlDataAccess _db;

    public PeopleData(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<IEnumerable<PersonModel>> GetAllPeopleAsync()
    {
        return await _db.LoadData<PersonModel, dynamic>("[dbo].[spPerson_GetAll]", new { });
    }

    public async Task<PersonModel?> GetPersonAsync(int id)
    {
        var results = await _db.LoadData<PersonModel, dynamic>("[dbo].[spPerson_Get]", new { Id = id });

        return results.FirstOrDefault();
    }

    public async Task<FullPersonModel?> GetFullPersonInfoAsync(int id)
    {
        FullPersonModel? output = new();
        output.Base = await GetPersonAsync(id);
        var addresses = await _db.LoadData<AddressModel, dynamic>(
            "[dbo].[spPerson_GetPersonAddress]", new { Id = id });
        output.Address = addresses.FirstOrDefault();

        return output;
    }

    public async Task InsertPersonAsync(PersonModel person)
    {
        await _db.SaveData("[dbo].[spPerson_Add]", new { person.FirstName, person.LastName });
    }

    public async Task UpdatePersonAsync(PersonModel person)
    {
        await _db.SaveData("[dbo].[spPerson_Update]", person);
    }

    public async Task DeletePersonAsync(int id)
    {
        await _db.SaveData("[dbo].[spPerson_Delete]", new { Id = id });
    }

    public async Task<IEnumerable<AddressModel>> GetAllAddressesAsync()
    {
        return await _db.LoadData<AddressModel, dynamic>("[dbo].[spAddress_GetAll]", new { });
    }

    public async Task<AddressModel?> GetAddressAsync(int id)
    {
        var results = await _db.LoadData<AddressModel, dynamic>("[dbo].[spAddress_Get]", new { Id = id });

        return results.FirstOrDefault();
    }

    public async Task InsertAddressAsync(AddressModel address)
    {
        await _db.SaveData("[dbo].[spAddress_Add]", new { address.StreetAddress, address.City, address.State, address.ZipCode });
    }

    public async Task UpdateAddressAsync(AddressModel address)
    {
        await _db.SaveData("[dbo].[spAddress_Update]", address);
    }
}
