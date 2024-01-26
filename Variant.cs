using System;
using System.Collections.Generic;

public class Variant
{
    public class Variant
    {
        public int id { get; set; }
        public string sku { get; set; }
        public int cost { get; set; }
        public int price { get; set; }
        public string title { get; set; }
        public int grams { get; set; }
        public bool is_enabled { get; set; }
        public bool is_default { get; set; }
        public bool is_available { get; set; }
        public bool is_printify_express_eligible { get; set; }
        public List<int> options { get; set; }
    }
}
