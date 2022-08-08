using System.ComponentModel.DataAnnotations;

namespace OData.Application
{
    public class ProjetDto
    {
        [Key]
        public Guid Id { get; set; }
        public string? Nom { get; set; }
        public long DateDebut { get; set; }
    }
}