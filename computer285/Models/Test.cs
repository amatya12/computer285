namespace computer285.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;



    [Table("Test")]
    public partial class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
