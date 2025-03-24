using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OmnichannelFront.Models;

namespace OmnichannelFront.Controllers
{
    public class UserController: Controller
    {
         private readonly HttpClient _httpClient;
        private const string ApiUrl = "http://localhost:5154/api/Users"; // Substitua pelo endpoint da sua API

        public UserController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _httpClient.GetStringAsync(ApiUrl);
            var users = JsonConvert.DeserializeObject<List<User>>(response);
            return View(users);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(ApiUrl, content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var response = await _httpClient.GetStringAsync($"{ApiUrl}/{id}");
            var user = JsonConvert.DeserializeObject<User>(response);
            return View(user);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"{ApiUrl}/{id}", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _httpClient.DeleteAsync($"{ApiUrl}/{id}");
            return RedirectToAction(nameof(Index));
        }
    }
}