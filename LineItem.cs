using System;

public class LineItem
{
    public class LineItem
    {
        public string product_id { get; set; }
        public int quantity { get; set; }
        public int variant_id { get; set; }
        public int print_provider_id { get; set; }
        public int cost { get; set; }
        public int shipping_cost { get; set; }
        public string status { get; set; }
        public Metadata metadata { get; set; }
        public string sent_to_production_at { get; set; }
        public string fulfilled_at { get; set; }
    }
}
