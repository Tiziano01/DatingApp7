using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
     //facciamo derivare la classe da DbContext grazie a E.F.
        public class DataContext : DbContext
    {
    
        public DataContext(DbContextOptions options) : base(options)//passa la stringa di connessione come opzione per creare una connessione al database
        {

        }

        public DbSet<AppUser> Users {get; set;}//una tabella nel db con le colonne specificate nella classe AppUser (id e username)
    }
}