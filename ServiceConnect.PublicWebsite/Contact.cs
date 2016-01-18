using System.ComponentModel.DataAnnotations;

namespace ServiceConnect.PublicWebsite
{
    public class Contact
    {
        [MaxLength(1000)]
        public string Name { get; set; }
        [MaxLength(1000)]
        public string Email { get; set; }
        [MaxLength(1000)]
        public string Subject { get; set; }
        [Required]
        [MaxLength(10000)]
        public string Message { get; set; }
    }
}