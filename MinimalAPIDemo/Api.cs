namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        // API endpoint mapping
        app.MapGet("/api/People", GetPeople);
        app.MapGet("/api/People/{id}", GetPerson);
        app.MapGet("/api/People/Address/{id}", GetFullPerson);
        app.MapPost("/api/People", InsertPerson);
        app.MapPut("/api/People", UpdatePerson);
        app.MapDelete("/api/People", DeletePerson);
        app.MapGet("/api/Addresses", GetAddresses);
        app.MapGet("/api/Addresses/{id}", GetAddress);
        app.MapPost("/api/Addresses", InsertAddress);
        app.MapPut("/api/Addresses", UpdateAddress);
    }

    private static async Task<IResult> GetPeople(IPeopleData data)
    {
        try
        {
            return Results.Ok(await data.GetAllPeopleAsync());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetPerson(IPeopleData data, int id)
    {
        try
        {
            var person = await data.GetPersonAsync(id);
            if (person == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(person);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetFullPerson(IPeopleData data, int id)
    {
        try
        {
            var person = await data.GetFullPersonInfoAsync(id);
            if (person == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(person);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertPerson(PersonModel person, IPeopleData data)
    {
        try
        {
            await data.InsertPersonAsync(person);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdatePerson(PersonModel person, IPeopleData data)
    {
        try
        {
            await data.UpdatePersonAsync(person);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeletePerson(IPeopleData data, int id)
    {
        try
        {
            await data.DeletePersonAsync(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetAddresses(IPeopleData data)
    {
        try
        {
            return Results.Ok(await data.GetAllAddressesAsync());
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetAddress(IPeopleData data, int id)
    {
        try
        {
            var person = await data.GetAddressAsync(id);
            if (person == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(person);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertAddress(AddressModel address, IPeopleData data)
    {
        try
        {
            await data.InsertAddressAsync(address);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdateAddress(AddressModel address, IPeopleData data)
    {
        try
        {
            await data.UpdateAddressAsync(address);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
}
