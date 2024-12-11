using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }  // Unique identifier for the message
        public int ChatId { get; set; }  // The chat this message belongs to
        public int SenderId { get; set; }  // The sender of the message (User or Owner)
        public string Content { get; set; }  // The content of the message
        public DateTime SentAt { get; set; }  // Timestamp when the message was sent

        // Navigation properties
        public Chat Chat { get; set; }  // The chat to which this message belongs
        public User Sender { get; set; }  // The user (renter) or owner (agency/individual) sending the message
    }
}
