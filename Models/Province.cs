using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace labW03.Models;
public class Province
{
    [Key]
    [StringLength(2)]
    [Display(Name = "Province Code")]
    public string? ProvinceCode { get; set; }
    
    [Display(Name = "Province")]
    public string? ProvinceName { get; set; }

    public List<City>? Cities { get; set; }
}
