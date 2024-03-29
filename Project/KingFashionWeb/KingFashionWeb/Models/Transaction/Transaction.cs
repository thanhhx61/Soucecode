﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KingFashionWeb.Models.Transaction
{
    public class Transaction
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
        public string Code { get; set; }
        public int Type { get; set; }
        public int Mode { get; set; }
        public int Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Content { get; set; }
    }
}
