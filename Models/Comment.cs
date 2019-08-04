using System;

namespace PremiumAccount

{
    public class Comment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Website {get;set;}
        public string Text { get; set; }
        public DateTime PostedAt { get; set; } = DateTime.Now;
        public Post Post { get; set; }
        public int PostId { get; set; }
        public bool IsApproved { get; set; } = false;
        public string PostTitle { get; set; }

        public void Approve(bool status){
           this.IsApproved = status;
        }
    }
}