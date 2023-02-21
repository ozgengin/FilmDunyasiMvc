using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MvcFilmDunyasi.Data
{
    public class Film
    {
        public int Id { get; set; }

        [Required, MaxLength(400)]
        public string Ad { get; set; }

        public int Yil { get; set; }

        [Precision(3,1)]
        public decimal Puan { get; set; }
        public List<Tur> Turler { get; set; } = new();
    }
}
