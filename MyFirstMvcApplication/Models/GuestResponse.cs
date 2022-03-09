using System.ComponentModel.DataAnnotations;
namespace PartyInvites.Models
{
    public class GuestResponse
    {
        public int id { get; set; }

        [Required(ErrorMessage = "please enter your name")]
        public string name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "please enter a valid email address")]
        public string email { get; set; } 
        [Required (ErrorMessage = "please enter your phone number")]
        public string phone { get; set; }
        [Required(ErrorMessage ="please specify whether you'll attend")]
        public bool? willAttend { get; set; }
    }
}
