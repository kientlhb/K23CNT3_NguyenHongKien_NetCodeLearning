using System.ComponentModel.DataAnnotations;

namespace NhkLab06.Models
{
    public class NhkEmployee
    {
        public long NhkId { get; set; }

        [Required]
        public string NhkName { get; set; }

        public DateTime? NhkBirthDay { get; set; }

        [EmailAddress]
        public string NhkEmail { get; set; }

        public string NhkPhone { get; set; }

        public double NhkSalary { get; set; }

        public bool NhkStatus { get; set; }
    }
}
