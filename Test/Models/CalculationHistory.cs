using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Test.Models
{
    [Table("CalculationHistory")]
    public class CalculationHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal field1 { get; set; }
        public decimal field2 { get; set; }
        public int operationTypeId { get; set; }
        public decimal result { get; set; }
        public DateTime calcDate { get; set; }
        [NotMapped]
        public string operationTypeDesc { get; set; }
    }
}
