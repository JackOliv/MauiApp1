using System.Text.Json;

namespace MauiApp1;

public partial class ItemPage : ContentPage
{
	public ItemPage()
	{
		InitializeComponent();
        LoadItems();

    }
    public async Task<List<Item>> FetchItemsAsync()
    {
        var client = new HttpClient();
        string url = "http://course-project-4-main/api/items";

        var response = await client.GetStringAsync(url);
        var data = JsonSerializer.Deserialize<ApiResponse2>(response);

        return data?.Предметы ?? new List<Item>();
    }
    private async void LoadItems()
    {
        var items = await FetchItemsAsync();

        foreach (var item in items)
        {
            item.Image = $"http://course-project-4-main/public/storage/{item.Image}";
            Console.WriteLine($"Character: {item.Name}, Image URL: {item.Image}");
        }

        ItemsList.ItemsSource = items;
    }
}