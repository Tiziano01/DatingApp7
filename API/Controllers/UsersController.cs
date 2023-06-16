using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{//la richiesta http chiede a questo controller e all'endpoint httpget di restituire e mostrare la lista di utenti
    [Authorize]
    public class UsersController : BaseApiController
    {
        
        private readonly DataContext _context;
//creo il costruttore per la dependency injection del servizio dbcontext che sta in program.cs
        public UsersController(DataContext context)
        {
            _context = context;
        
        }
        //creo gli endpoint per prendere le richieste
        [AllowAnonymous]
        [HttpGet]
        public async Task <ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var users = await _context.Users.ToListAsync();//questo lista tutti gli utenti del db

            return users;
        }
        
        [HttpGet("{id}")]
        public async Task <ActionResult<AppUser>> GetUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}