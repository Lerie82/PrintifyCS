using System;
using System.Collections.Generic;

public class OrderDetail
{
    public class OrderDetail
    {
        public string id { get; set; }
        public AddressTo address_to { get; set; }
        public List<LineItem> line_items { get; set; }
        public Metadata metadata { get; set; }
        public int total_price { get; set; }
        public int total_shipping { get; set; }
        public int total_tax { get; set; }
        public string status { get; set; }
        public int shipping_method { get; set; }
        public bool is_printify_express { get; set; }
        public List<Shipment> shipments { get; set; }
        public string created_at { get; set; }
        public string sent_to_production_at { get; set; }
        public string fulfilled_at { get; set; }
        public PrintifyConnect printify_connect { get; set; }
    }
}
