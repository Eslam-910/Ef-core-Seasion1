using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef_core_Seasion1.Entities
{
    //Ef core:-Support 4 ways for Mapping Classes in Database[table,view,function]
    //1.By Convention(Default Behaviour)
    //2.Data Annotation[set of Attributes used for data validation]
    //3.fluent Apis
    //4.Class Configuration



    //Entity
    //Poco
    //Plain old clr Object
    //internal class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public double Salary { get; set; }
    //    public string Email { get; set; }
    //    public DateTime CreationAt { get; set; }
    //}

    //class Emlpoyee
    //{
    //    [Key]
    //    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    //    public int EmpId { get; set; }
    //    [Required]
    //    [Column("EmpName", TypeName = "varchar")]
    //    public string? Name { get; set; }
    //    [Column("money")]
    //    public int Salary { get; set; }
    //    [Phone]
    //    public int Phone { get; set; }
    //    [EmailAddress]
    //    public string Email { get; set; }
    //}
    class Employee
    {
        
        public string EmpId { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public double Salary { get; set; }
        public string Email { get; set; }
        public DateTime DateOfCreation { get; set; }
    }

}
