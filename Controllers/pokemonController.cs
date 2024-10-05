using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using test_pokeApi.Models;

namespace test_pokeApi.Controllers
{

    public class pokemonController : Controller
    {

        /* accede directamente al metodo sin crear una instancia */
        private static readonly HttpClient _httpClient = new HttpClient();

        public async Task<IActionResult> pokemonView(int id = 1)
        {

            try
            {

                /* sitio donde realizaremos las peticiones */
                var url = $"https://pokeapi.co/api/v2/pokemon/{id}";

                /* realiza la solicitud HTTP
                 * almacena una lista en tipo json */
                var response = await _httpClient.GetStringAsync(url);

                /* deserializa la respuesta JSON en el modelo
                 * pasamos la lista al modelo */
                var pokemonModel = JsonConvert.DeserializeObject<pokemonModel>(response);

                return View(pokemonModel);

            }
            catch (Exception)
            {

                return null;

            }

        }

    }

}
