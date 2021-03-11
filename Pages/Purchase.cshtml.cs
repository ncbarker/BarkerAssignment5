using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BarkerAssignment5.Infrastructure;
using BarkerAssignment5.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BarkerAssignment5.Pages
{
    public class PurchaseModel : PageModel
    {
        private IBookStoreRepository repository;
        //Constructor
        public PurchaseModel(IBookStoreRepository repo)
        {
            repository = repo;
        }
        //Properties
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        //Methods
        public void OnGet(string returnUrl)
        {
            //slash if nothing is passed in
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long bookId, string returnUrl)
        {
            //First thing that happens when there is a match
            Project project = repository.Projects.FirstOrDefault(p => p.BookId == bookId);

            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();

            Cart.AddItem(project, 1);

            HttpContext.Session.SetJson("cart", Cart);

            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
