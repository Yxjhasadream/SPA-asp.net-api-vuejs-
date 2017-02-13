﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MBO_API.Models
{
    public class Message
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Message()
        {
            Time = Time == null ? DateTime.Now : Time;
            IsRead = false;
        }

        [Key]
        public int MessageID { get; set; }

        public string Description { get; set; }

        public DateTime Time { get; set; }

        public string SenderID { get; set; }

        public string ReceiverID { get; set; }

        public bool IsRead { get; set; }

        [InverseProperty("MessagesSent")]
        public virtual ApplicationUser Sender { get; set; }

        [InverseProperty("MessagesReceived")]
        public virtual ApplicationUser Receiver { get; set; }        
    }
}