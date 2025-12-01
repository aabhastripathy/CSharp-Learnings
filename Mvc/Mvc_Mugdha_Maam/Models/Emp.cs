using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mvc_Mugdha_Maam.Models
{
    [Table("Emp")]
    public class Emp
    {
        //[Column("no")] <- Not needed if property name matches column name
        [Key]//This class is automatically auto incrimented
        public int no { get; set; }
        public string name { get; set; }
        public string address { get; set; }
    }
}
