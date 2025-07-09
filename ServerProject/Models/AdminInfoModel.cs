using System.ComponentModel.DataAnnotations;

namespace ServerProject.Models
{
    public class AdminInfoModel
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public int ModelId { get; set; }
        [Required]
        public string firstName { get; set; } = string.Empty;
        [Required]
        public string MiddleName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public string FullName { get; set; } = string.Empty;
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required]
        public string ProfilePicture { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Province { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; } = string.Empty;


    }
}
