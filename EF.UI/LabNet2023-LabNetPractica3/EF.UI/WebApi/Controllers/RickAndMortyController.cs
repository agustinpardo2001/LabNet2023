using EF.Entities.RickAndMorty;
using Newtonsoft.Json;
using System.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class RickAndMortyController : Controller
    {
        // GET: RickAndMorty
        public async Task<ActionResult> index()
        {
            var httpClient = new HttpClient();
            var json = await httpClient.GetStringAsync("https://rickandmortyapi.com/api/character");

            RickAndMortyEntity characters = JsonConvert.DeserializeObject<RickAndMortyEntity> (json);
            var result = characters.Results.Select(s => new RickAndMortyModel { Name = s.Name, Gender = s.Gender, Image = s.Image, Origin = s.Origin.Name, Species = s.Species }).ToList();

            return View(result);
       

        }
    }
}