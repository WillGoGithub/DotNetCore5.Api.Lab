using System.ComponentModel.DataAnnotations;

namespace DotNetCore5.Api.Lab.Models
{
    public class Product
    {
            public int Id { get; set; }

            [Required]
            public string Name { get; set; }

            [Range(0.01, 9999.99)]
            public decimal Price { get; set; }
    }
}
