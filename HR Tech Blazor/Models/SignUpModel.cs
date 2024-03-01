using HR_Tech_Blazor.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Tech_Blazor.Models
{
    public class SignUpModel : PageModel {
        private readonly IFirebaseAuthService _authService;

        [BindProperty]
        public SignUpUserDto UserDto { get; set; }

        public SignUpModel(IFirebaseAuthService authService) {
            _authService = authService;
        }

        public async Task<IActionResult> OnPostAsync() {
            if (!ModelState.IsValid) {
                return Page();
            }

            var token = await _authService.SignUp(UserDto.Email, UserDto.Password);

            if (token is not null) {
                HttpContext.Session.SetString("token", token);
                return RedirectToPage("/usuarios");
            }

            return BadRequest();
        }
    }
}
