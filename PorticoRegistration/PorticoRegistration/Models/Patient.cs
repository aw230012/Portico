using System;
using System.ComponentModel.DataAnnotations;

namespace PorticoRegistration.Models
{
   public class Patient
   {
      [Key]
      public int ID { get; set; }

      [StringLength(20)]
      public string PatientID { get; set; }

      [StringLength(60)]
      public string LastName { get; set; }

      [StringLength(20)]
      public string Suffix { get; set; }

      [StringLength(35)]
      public string FirstName { get; set; }

      [StringLength(30)]
      public string MiddleName { get; set; }

      public DateTime DateOfBirth { get; set; }

      [StringLength(4)]
      public string SsnLastFour { get; set; }

      [StringLength(255)]
      public string EmailAddress { get; set; }

      [StringLength(255)]
      public string UserToken { get; set; }

      [StringLength(255)]
      public string UserSecret { get; set; }
   }
}