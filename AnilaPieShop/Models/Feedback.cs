﻿using System;
namespace AnilaPieShop.Models
{
    public class Feedback
    {
        public int FeedbackId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public bool ContactMe { get; set;  }

        public Feedback()
        {
        }
    }
}
