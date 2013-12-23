using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace DataLayer.Models
{
    public class ContactMethod
    {
        [Key]
        public int CMId { get; set; }
        public string Value { get; set; }
        public int ContactId { get; set; }
        public int KeywordId { get; set; }

    }
}
