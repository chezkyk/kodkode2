using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFriends.DAL;
using MyFriends.Models;
using System.Collections.Generic;
using System.Diagnostics;

namespace MyFriends.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(Data.Get.friends.ToList());
        }
        public IActionResult CreateFriend()
        {
            return View(new Friend());
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult CreateFriend(Friend friend)
        {
            if (friend == null) return RedirectToAction("Index");
            Data.Get.friends.Add(friend);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var friend = Data.Get.friends.Include(f => f.images).FirstOrDefault(f => f.ID == id);//Find(f => f.ID == id) במקום ראשון או ברירת מחדל
            if (friend == null)
            {
                return NotFound();
            }
            return View(friend);
        }

        public IActionResult UpdateFriend(int id)
        {
            var friend = Data.Get.friends.Include(f => f.images).FirstOrDefault(f => f.ID == id);
            if (friend == null)
            {
                return NotFound();
            }
            return View(friend);
        }
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult UpdateFriend(Friend friend)
        {
            Friend existingFriend = Data.Get.friends.Find(friend.ID);
            if (existingFriend == null)
            {
                return NotFound();
            }

            existingFriend.FirstName = friend.FirstName;
            existingFriend.LastName = friend.LastName;
            existingFriend.PhoneNumber = friend.PhoneNumber;
            existingFriend.EmailAddress = friend.EmailAddress;
            existingFriend.images.AddRange(friend.images);
            Data.Get.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var friendToDelete = Data.Get.friends.FirstOrDefault(f => f.ID == id);
            if (friendToDelete != null)
            {
                Data.Get.friends.Remove(friendToDelete);
                Data.Get.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public IActionResult DeleteImage(int id ,int friendId)
        {
            // Retrieve the friend with the specific ID including the images
            var friend = Data.Get.friends
                              .Include(f => f.images)
                              .FirstOrDefault(f => f.ID == friendId);

            if (friend == null)
            {
                return NotFound();
            }

            // Find the image to delete by its ID
            var imageToDelete = friend.images.FirstOrDefault(img => img.Id == id);
            if (imageToDelete != null)
            {
                friend.images.Remove(imageToDelete);
                Data.Get.SaveChanges();
            }

            // Redirect back to the UpdateFriend view
            return RedirectToAction("UpdateFriend", new { id = friendId });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
