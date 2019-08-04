using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PremiumAccount.Data;
using PremiumAccount.Models;

namespace PremiumAccount.Controllers
{
    public class Postcontroller : Controller
    {
        private ApplicationDbContext _context;
        public Postcontroller(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {

            var s = _context.Posts.OrderByDescending(x => x.Id).ToList();


            ViewBag.post = _context.Posts.OrderByDescending(x => x.Id).Take(2).ToList();



            ViewBag.post2 = _context.Posts.OrderByDescending(x => x.Id).Take(8).Skip(2).ToList();

            if (s.Count >= 9)
            {
                ViewBag.post3 = _context.Posts.OrderByDescending(x => x.Id).Take(9).Skip(8).Single();
            }

            ViewBag.post4 = _context.Posts.OrderByDescending(x => x.Id).Take(15).Skip(9).ToList();

            ViewBag.post5 = _context.Posts.OrderByDescending(x => x.Id).Take(19).Skip(15).ToList();
            ViewBag.post6 = _context.Posts.OrderByDescending(x => x.Id).Take(22).Skip(19).ToList();
            ViewBag.post7 = _context.Posts.OrderByDescending(x => x.Id).Take(25).Skip(22).ToList();
            ViewBag.post8 = _context.Posts.OrderByDescending(x => x.Id).Take(29).Skip(25).ToList();
            ViewBag.count = (from c in _context.Posts
                             where c.Category == "Technology"
                             select c).Count();

            return View();







        }








        public IActionResult Details(int id, string cat, string title)
        {
            var post = _context.Posts.FirstOrDefault(x => x.Title.Equals(title));
            var comments = _context.Comments.Where(x => x.PostId == id && x.IsApproved == true);
            //(x=>x.IsApprove.Equals("Yes"));

            // var data = from c in _context.Posts
            //            join p in _context.PostViewCount on c.Id equals p.PostId
            //            select new PostsModel
            //            {
            //                Id = p.Id,
            //                Count = p.Count,
            //                Title = c.Title,
            //                Photo = c.PhotoUrl,
            //                Author = c.Author,
            //                Date = c.CreatedAt

            //                // etc...
            //            };
            // var dat = data.OrderByDescending(x => x.Count).Take(4).ToList();
            // ViewBag.data2 = dat;
              ViewBag.related = _context.Posts.OrderByDescending(x=>x.Id).Take(3);
         
            
            ViewBag.popular = _context.Posts.OrderByDescending(x => x.Id).Take(7).Skip(3).ToList();



            ViewBag.Comments = comments;
            ViewBag.Count = _context.Comments.Where(x => x.PostId == id).Count();

            AddCount(id);
            return View(post);




        }
       
        public IActionResult CommentAdd(Comment comment, string postTitle, string website, string name, string email, string commentTxt, int postId)
        {
            comment.PostId = postId;
            //comment.IsApprove = "No"
            comment.PostTitle = postTitle;
            comment.Name = name;
            comment.Email = email;
            comment.Text = commentTxt;
            comment.Website = website;
            _context.Comments.Add(comment);
            _context.SaveChanges();
            return RedirectToAction(nameof(Details), new { Id = postId, Title = postTitle });
        }

       

        public void AddCount(int postId)
        {
            if (_context.PostViewCount.Any(x => x.PostId == postId))
            {
                var postCount = _context.PostViewCount.FirstOrDefault(x => x.PostId == postId);
                postCount.Count += 1;
                _context.PostViewCount.Update(postCount);
            }
            else
            {
                var pc = new PostViewCount { PostId = postId, Count = 1 };

                _context.PostViewCount.Add(pc);
            }
            _context.SaveChanges();
        }
        // public IActionResult Popular()
        // {
           
        //     var data = from c in _context.Posts
        //                join p in _context.PostViewCount on c.Id equals p.PostId
        //                select new PostsModel
        //                {
        //                    Id = p.Id,
        //                    Count = p.Count,
        //                    Title = c.Title,
        //                    Photo = c.PhotoUrl,
        //                    Author = c.Author,
        //                    Date = c.CreatedAt

                           
        //                };
        //     var dat = data.OrderByDescending(x => x.Count).Take(6).ToList();
        //     ViewBag.data2 = dat;

        //     return View();
        // }

        public IActionResult Become_author()
        {

            return View();
        }
       
        public IActionResult Category(string category)
        {
            var posts = _context.Posts.Where(x => x.Category.Equals(category)).OrderByDescending(x => x.Id).ToList();
            if(posts.Count>=1)
            {
            ViewBag.one = posts.Take(1).Single();
            }
            ViewBag.two = posts.Take(3).Skip(1).ToList();
            ViewBag.three = posts.Take(7).Skip(3).ToList();
            ViewBag.four = posts.Take(11).Skip(7).ToList();
             ViewBag.Ca = category;



            return View(posts);
        }
        public IActionResult Search(string search)
        {
            TempData["search"] = search;
         var search1 = _context.Posts.OrderByDescending(x=>x.Id).Where(x => x.Title.Contains(search) || x.Description.Contains(search)).ToList();
        
            return View(search1);
        }
        public IActionResult Checker()
        {
            return View();
        }
       
    }

}

