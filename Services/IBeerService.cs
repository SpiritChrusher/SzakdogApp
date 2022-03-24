namespace SzakdogApp.Services;

public interface IBeerService
{
	public Task<IEnumerable<Beer>> GetAllBeersAsync();
	public Task PostBeersAsync(AddBeer addBeer);
}
