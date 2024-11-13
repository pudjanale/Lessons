using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace task4.Model
{
    public class Book
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Title { get; init; }
        [Required]
        public int Pages { get; init; }
        [Required]
        public string Authtor { get; init; }

        public new string ToString()
            => $"{Title} {Authtor} {Pages}";
    }
}
