using BulkyWeb_RazorPages.Data;
using BulkyWeb_RazorPages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb_RazorPages.Pages.Categories
{
    [BindProperties]
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public Category Category { get; set; }
        public DeleteModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet(int id)
        {
            Category = _db.Categories.FirstOrDefault(C => C.Id == id);
        }
        public IActionResult OnPost()
        {
            _db.Categories.Remove(Category);
            _db.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
