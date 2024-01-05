
using System.ComponentModel.DataAnnotations;
namespace HRPortal.Models;



public class Employee { 
   //Data level Validations

   public int Id{get;set;}
   
   //[Required, MaxLength(80)] 
   public string Name { get; set; } 
}
