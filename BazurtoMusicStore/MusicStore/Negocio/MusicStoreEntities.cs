using System.Data.Entity;
using MusicStore.Negocio;

namespace MusicStore.Negocio
{
    public class MusicStoreEntities : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}