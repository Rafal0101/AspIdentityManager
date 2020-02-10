using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspIdentityManager.Models
{
    public class EditRoleModel
    {
        public EditRoleModel()
        {
            Users = new List<string>();
        }
        public string Id { get; set; }

        [Required(ErrorMessage ="Nazwa Roli jest wymagana")]
        public string RoleName { get; set; }
        public List<string> Users { get; set; }
    }
}
