using System;
using System.Collections.Generic;

namespace PremiumAccount
{
  public class Post
  {
      public int Id { get; set; }
      public string Title { get; set; }
      public string PhotoUrl { get; set; }
      public string Category { get; set; }
      public string Author { get; set; }
      public string Description { get; set; }
      public DateTime CreatedAt { get; set;} = DateTime.Now ;
      public List<Comment> Comments { get; set; }
  }  
}