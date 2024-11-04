using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFCode.Models
{
    internal class Workstation
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }

        public Employee Employee { get; set; }

        public override string ToString()
        {
            return $"WorkstationId:{Id}\n" +
                $"WorkstationName:{Code}\n" +
                $"=======================";
        }

    }
}