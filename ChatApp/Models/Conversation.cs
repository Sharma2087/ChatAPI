using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChatApp.Models
{
    public class Conversation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConversationId { get; set; }
        [Required]
       // [ForeignKey("User1")]
        public string UserId1 { get; set; }
        //public User User1 { get; set; }

        [Required]
        //[ForeignKey("User2")]
        public string UserId2 { get; set; }
        //public User User2 { get; set; }

    }

   

}