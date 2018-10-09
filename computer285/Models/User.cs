namespace computer285.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage ="username is required.")]
        [StringLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(128)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(50)]
        public string Email { get; set; }

            
        [Required(ErrorMessage = "Firstname is required.")]
        [Display(Name ="First name")]
        [StringLength(100)]
        public string FirstName { get; set; }

        

        [Required(ErrorMessage = "Lastname is required.")]
        [StringLength(100)]
        public string LastName { get; set; }
    }
}
