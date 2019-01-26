using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MessageId { get; set; }
        public int ParentId { get; set; }
        public string Content { get; set; }
        //[ForeignKey("Conversation")]
        public int ConversationId { get; set; }
        //public Conversation Conversation { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }

        //[Required]
        //[ForeignKey("User1")]
        public string OwnerId { get; set; }
       // public User User1 { get; set; }

        //[Required]
        //[ForeignKey("User2")]
        public string RecieverId { get; set; }
       // public User User2 { get; set; }

    }

}