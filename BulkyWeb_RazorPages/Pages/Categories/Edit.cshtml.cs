using BulkyWeb_RazorPages.Data;
using BulkyWeb_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb_RazorPages.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public Category Category { get; set; }

        public void OnGet(int id)
        {
            Category = _db.Categories.FirstOrDefault(u => u.Id == id);
        }
        public IActionResult OnPost()
        {
            _db.Categories.Update(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
