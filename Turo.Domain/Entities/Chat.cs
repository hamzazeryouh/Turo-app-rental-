using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turo.Domain.Entities
{
    public class Chat : BaseEntity<string>
    {
        public string CarId { get; set; }  // The car the chat is related to (car being rented)
        public string OwnerId { get; set; }  // The owner of the car (can be an agency or an individual)
        public string UserId { get; set; }  // The user (renter) involved in the conversation

        // Navigation properties
        public Car? Car { get; set; }  // The car being rented
        public User? Owner { get; set; }  // The owner of the car (agency or individual)
        public User? User { get; set; }  // The renter (user)

        // Collection of messages in the chat
        public ICollection<Message>? Messages { get; set; }  // Messages exchanged in the chat
    }
}
