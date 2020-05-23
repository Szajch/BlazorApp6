using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp6.Data
{
    public class TestNumbers
    {
        [Required(ErrorMessage = "Brak liczby 1")]
        [Range(1, 10, ErrorMessage = "Liczba 1 musi być pomiędzy 1 i 10")]
        public int? Number1 { get; set; }
        [Required(ErrorMessage = "Brak liczby 2")]
        [Range(1, 10, ErrorMessage = "Liczba 2 musi być pomiędzy 1 i 10")]
        public int? Number2 { get; set; }
    }
}
