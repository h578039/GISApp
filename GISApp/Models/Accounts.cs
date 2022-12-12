using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace GISApp.Models
{
    public class Accounts
    {
        public int Id { get; set; }
        [DisplayName("User name")]
        public string UserName { get; set; }
        [DisplayName("Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
