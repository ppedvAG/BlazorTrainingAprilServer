using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTrainingAprilServer.Pages.Modul05
{
    public class Person
    {
        [Range(minimum:140,maximum:200,ErrorMessage ="keine Achterbahn für dich")]
        [Required(ErrorMessage ="muss was rein")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "muss was rein")]
        [StringLength(maximumLength:10,MinimumLength =2,ErrorMessage ="min max")]
        public string  Name { get; set; }

        public DateTime GebDat { get; set; }

    }
}
