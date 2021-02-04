using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindRFront.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class HousingController : ControllerBase
    {
        private readonly ILogger<HousingController> _logger;

        public HousingController(ILogger<HousingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Housing> Get()
        {
            List<Housing> housings = new List<Housing>();
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/garsoniera-de-inchiriat-IDeq6lo.html#bb6f20793c;promoted", Price = 1100, NoOfRooms = 1, Location = "Brasov" });
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/inchiriez-apartament-2-camere-studio-coresi-avantgarden-brasov-IDer4E6.html#c48a4bf265;promoted", Price = 1900, NoOfRooms = 2, Location = "Brasov" });
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/chirie-apartament-3-camere-lujerului-IDenLrR.html#0ede99b094;promoted", Price = 1900, NoOfRooms = 3, Location = "Bucuresti" });
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/chirie-apartament-3-camere-unirii-camera-de-comert-caut-coleg-IDeh0B5.html#0ede99b094;promoted", Price = 950, NoOfRooms = 3, Location = "Bucuresti" });
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/garsoniera-chirie-IDdVUEb.html#0abeddb25a;promoted", Price = 900, NoOfRooms = 1, Location = "Bucuresti" });
            housings.Add(new Housing { Link = "https://www.storia.ro/ro/oferta/apartament-2-camere-semidecomandat-gheorgheni-aleea-padis-IDkiYO.html", Price = 1500, NoOfRooms = 2, Location = "Cluj-Napoca" });
            housings.Add(new Housing { Link = "https://www.olx.ro/oferta/inchiriere-apartament-IDereOH.html#9d238f6d60;promoted", Price = 2400, NoOfRooms = 4, Location = "Constanta" });

            return housings.ToArray();
        }
    }
}
