﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBookLibraryModel.DTOS
{
   public  class BookToDeleteDto
    {

    
        [Required]
        public int Id { get; set; }


      
    }
}
