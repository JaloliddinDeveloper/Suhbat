//--------------------------------------------------
// Copyright (c) Coalition Of Good-Hearted Engineers
// Free To Use To Find Comfort And Peace
//--------------------------------------------------
using Suhbat.Web.Models.Foundations.Users;
using System.ComponentModel.DataAnnotations;
using System;

namespace Suhbat.Web.Models.Foundations.Messages
{
    public class Message
    {
        public int Id { get; set; }

        [Required]
        public int SenderId { get; set; }

        [Required]
        public int ReceiverId { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Content { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public User Sender { get; set; }
        public User Receiver { get; set; }
    }
}
