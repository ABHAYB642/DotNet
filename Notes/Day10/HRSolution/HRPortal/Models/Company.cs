
using System.ComponentModel.DataAnnotations;
namespace HRPortal.Models;
public class Company { 
   //Data level Validations
   [Required, MaxLength(80)] 
    public string CompanyName { get; set; } 
    public string ContactName { get; set; } 
    public int EmployeeCount{get;set;}
}
