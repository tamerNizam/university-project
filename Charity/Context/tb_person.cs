//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Charity.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tb_person
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Required")]
        public string FName { get; set; }
        [Required(ErrorMessage = "Required")]
        public string LName { get; set; }
        [Required(ErrorMessage = "Required")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Required")]
        [MinLength(10,ErrorMessage ="Mobile No should be 10 digit")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "Required")]
        public Nullable<double> Price { get; set; }
    }
}
