using MvcFilmDunyasi.Data;

namespace MvcFilmDunyasi.Models
{
    public class HomeViewModel
    {
        public List<Film> Filmler { get; set; } = new();
        public int? TurId { get; set; }
    }
}
