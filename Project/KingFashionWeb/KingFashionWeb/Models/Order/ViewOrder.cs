﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KingFashionWeb.Models.Order
{
    public class ViewOrder
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionId { get; set; }
        public string Token { get; set; }
        public int Status { get; set; }
        public float SubTotal { get; set; }
        public float ItemDiscount { get; set; }
        public float Tax { get; set; }
        public float Shipping { get; set; }
        public float Total { get; set; }
        public string Promo { get; set; }
        public float Discount { get; set; }
        public float GrandTotal { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Country { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }
      
    }
}
