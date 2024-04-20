using BulkyWeb_RazorPages.Data;
using BulkyWeb_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb_RazorPages.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet() // GET METHOD TO DISPLAY CATEGORY TO CREATE NEW CATEGORY (Name and Display Order)
        {
        }
        public IActionResult OnPost() // POST METHOD TO ADD NEW CATEGORY IN CATEGORIES TABLE
        {
            _db.Categories.Add(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
