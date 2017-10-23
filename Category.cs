﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Text;

namespace LiveCode4
{
    class Category
    {
        [Column("categoryid")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }

}
