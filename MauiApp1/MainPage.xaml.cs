using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadCharacters();
        }
        public async Task<List<Character>> FetchCharactersAsync()
        {
            using var client = new HttpClient();
            string url = "http://course-project-4-main/api/characters";

            var response = await client.GetStringAsync(url);
            var data = JsonSerializer.Deserialize<ApiResponse>(response);

            return data?.Персонажи ?? new List<Character>();
        }
        private async void LoadCharacters()
        {
            var characters = await FetchCharactersAsync();

            foreach (var character in characters)
            {
                character.Image = $"http://course-project-4-main/public/storage/{character.Image}";
                Console.WriteLine($"Character: {character.Name}, Image URL: {character.Image}");
            }

            CharactersList.ItemsSource = characters;
        }

    }

}
