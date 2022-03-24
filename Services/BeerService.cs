namespace SzakdogApp.Services;

public class BeerService : IBeerService
{
	private readonly HttpClient _client;

	public BeerService(HttpClient client)
	{
		_client = client;
	}

	public async Task<IEnumerable<Beer>> GetAllBeersAsync() =>
		await _client.GetFromJsonAsync<IEnumerable<Beer>>("/beers");

	public async Task PostBeersAsync(AddBeer addBeer) =>
		await _client.PostAsJsonAsync($"/beers", addBeer);
}