﻿using System.ComponentModel.DataAnnotations;

namespace CrudOperationInNetCore.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        /*  public object ID { get; internal set; }*/
        public string? Name { get; set; }
        public string? Category { get; set; }

        public int IsActive { get; set; }
    }
}