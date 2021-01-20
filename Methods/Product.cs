﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int StokAdeti { get; set; }

        // encapsulation
        /* ÖNEMLİ: Zamanla değiştirme olasılığından dolayı çoklu 
         * parametreli metodlardan kaçınılmalıdır*/
    }
}
