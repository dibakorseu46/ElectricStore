﻿using ElectricStore.Models.Models;
using ElectricStore.Utility;
using System.Collections.Generic;

namespace ElectricStore.Models.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Product> ProductList { get; set; }
        public int SortById { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public int MaximumPrice { get; set; }
        public int MinimumPrice { get; set; }
        public Pager Pager { get; set; }
        public string Search { get; set; }

    }
}
