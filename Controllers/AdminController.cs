using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PremiumAccount.Data;

namespace PremiumAccount.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _user;
        public AdminController(ApplicationDbContext context, UserManager<IdentityUser> user)
        {
            _context = context;
            _user = user;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Newpost(Post post, string description2)
        {

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {

                    var file = Image;
                    var uploads = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/postimages");

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse
                            (file.ContentDisposition).FileName.Trim('"');

                        System.Console.WriteLine(fileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            post.PhotoUrl = file.FileName;
                        }


                    }
                }
            }


            post.Author = _user.GetUserName(HttpContext.User);
           post.Description = description2;


            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
            // _client.AddToastNotification("Posted",NotificationType.success, null);

            return RedirectToAction("all", "admin");
        }
        public IActionResult All(string search)
        {
            var s = _context.Posts.Where(x => x.Title.Contains(search) || search == null).OrderByDescending(x => x.Id).ToList();
            ViewBag.count = _context.Posts.Count();
            return View(s);
        }
        
        public IActionResult Delete(int id)
        {
            var delete = _context.Posts.FirstOrDefault(x => x.Id == id);
            var image = delete.PhotoUrl;
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\postimages", image);

          if(System.IO.File.Exists(path))
             {
    System.IO.File.Delete(path);
     _context.Posts.Remove(delete);
             _context.SaveChanges();
            return RedirectToAction(nameof(All));
             }
             else
             {
                 return View("All");
             }
            
        }




        public async Task<IActionResult> Update(Post post, string description2)
        {
            

            var files = HttpContext.Request.Form.Files;
            foreach (var Image in files)
            {
                if (Image != null && Image.Length > 0)
                {

                    var file = Image;
                    var uploads = System.IO.Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/postimages");

                    if (file.Length > 0)
                    {
                        var fileName = ContentDispositionHeaderValue.Parse
                            (file.ContentDisposition).FileName.Trim('"');

                        System.Console.WriteLine(fileName);
                        using (var fileStream = new FileStream(Path.Combine(uploads, file.FileName), FileMode.Create))
                        {
                            await file.CopyToAsync(fileStream);
                            post.PhotoUrl = file.FileName;
                        }


                    }
                }
            }


           
            post.Description = description2;


            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            // _client.AddToastNotification("Posted",NotificationType.success, null);

            return RedirectToAction("all", "admin");
        }
        public IActionResult Edit(int id)
        {
          var edit =  _context.Posts.FirstOrDefault(x => x.Id == id);
             var image = edit.PhotoUrl;
 var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\postimages", image);
          if(!System.IO.File.Exists(path))
             {
            return Content("No Image");
             
             }
             else
             {
              
              System.IO.File.Delete(path);
             return View(edit); 
             }

        }

        public IActionResult View(int id)
        {
            var view = _context.Posts.FirstOrDefault(x => x.Id == id);
            var comments = _context.Comments.Where(x => x.PostId == id);
            ViewBag.Comments = comments;
            return View(view);
        }
        public IActionResult Comments()
        {
            var s = _context.Comments.OrderByDescending(x => x.PostedAt).ToList();
            return View(s);
        }
        public IActionResult DeleteComment(int id)
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);
            _context.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Comments", "Admin");
        }
        public IActionResult MyPosts()
        {

            var username = _user.GetUserName(HttpContext.User);
            var posts = _context.Posts.Where(x => x.Author.Equals(username)).ToList();
            ViewBag.Count = posts.Count();
            if (ViewBag.Count > 1)
            {
                ViewBag.two = "Posts";
            }
            return View(posts);
        }
        public IActionResult ApproveComment(int id)
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);
            comment.Approve(true);
            _context.Comments.Update(comment);
            _context.SaveChanges();

            return RedirectToAction(nameof(Comments));
        }
        public IActionResult RejectComment(int id)
        {
            var comment = _context.Comments.FirstOrDefault(x => x.Id == id);

            comment.Approve(false);
            _context.Comments.Update(comment);
            _context.SaveChanges();

            return RedirectToAction(nameof(Comments));
        }
        public IActionResult Contact()
        {
            var contacts = _context.Contacts.ToList();
            return View(contacts);
        }
        
          

}
}