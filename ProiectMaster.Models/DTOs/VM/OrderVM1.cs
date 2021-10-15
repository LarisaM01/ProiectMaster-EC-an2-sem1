using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs.VM
{
    public class OrderVM1
    {


        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { get; set; }
        [Required]
        [MaxLength(2000)]
        public string CustomerPhoneNumber { get; set; }
        [Required]
        [MaxLength(13)]
        public string CustomerEmail { get; set; }
        [Required]
        [MaxLength(2000)]

        public string CustomerAddress { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Date { get; set; }

    }
}
