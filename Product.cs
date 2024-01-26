using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

public class Product
{
    public class Product
    {
        public string id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> tags { get; set; }
        public List<Option> options { get; set; }
        public List<Variant> variants { get; set; }
        public List<Image> images { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public bool visible { get; set; }
        public bool is_locked { get; set; }
        public bool is_printify_express_eligible { get; set; }
        public bool is_printify_express_enabled { get; set; }
        public int blueprint_id { get; set; }
        public int user_id { get; set; }
        public int shop_id { get; set; }
        public int print_provider_id { get; set; }
        public List<PrintArea> print_areas { get; set; }
        public List<object> sales_channel_properties { get; set; }
    }
}
