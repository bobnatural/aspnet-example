﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace NameDirectoryService.Models
{
    public class NameDirectory
    {
        public int ID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String CreatedTimestamp { get; set; }
   }
}