using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using AFCSTEM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.WebUtilities;
using AFCSTEM.Data;
using System.Linq;
using AFCSTEM.Areas.Identity.Data;

namespace AFCSTEM.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ForgotPasswordModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            public string FirstName { get; set; }
            [Required]
            public string LastName { get; set; }
            [Required]
            public string School { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var users = _userManager.Users.ToList();

                foreach (var login in users)
                {
                    if (Input.FirstName.ToLower().Equals(login.FirstName.ToLower()) && Input.LastName.ToLower().Equals(login.LastName.ToLower()) && Input.School.ToLower().Equals(login.School.ToLower()))
                    {
                        await _signInManager.SignInAsync(login, isPersistent: false);
                        return RedirectToAction("AccountDetails");
                    }
                }
            }
            ModelState.AddModelError(string.Empty, "Unable to find user with the information.");
            return Page();
        }
    }
}
