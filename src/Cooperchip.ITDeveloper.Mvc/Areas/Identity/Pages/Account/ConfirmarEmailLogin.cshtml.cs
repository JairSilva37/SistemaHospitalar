using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Cooperchip.ITDeveloper.Mvc.Extensions.Identity;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cooperchip.ITDeveloper.Mvc.Areas.Identity.Pages.Account
{
    public class ConfirmarEmailLoginModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;

        public ConfirmarEmailLoginModel(IEmailSender emailSender, UserManager<ApplicationUser> userManager)
        {
            _emailSender = emailSender;
            _userManager = userManager;
        }

        public string Username { get; set; }

        public bool IsEmailConfirmed { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostSendVerificationEmailAsync()
        {
            if (!ModelState.IsValid)
            {
                StatusMessage = "Email inválido ou inexistente";
                return Page();
            }

            var user = await _userManager.FindByEmailAsync(Input.Email);
            if (user == null)
            {
                return NotFound($"Não existe usuário com email {Input.Email} cadastrado!");
            }

            var userId = await _userManager.GetUserIdAsync(user);
            var email = await _userManager.GetEmailAsync(user);
            var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var callbackUrl = Url.Page(
                "/Account/COnfirmEmail",
                pageHandler: null,
                values: new { userId = userId, code = code },
                protocol: Request.Scheme);

            StatusMessage = "Verificação de conta enviada.Por gentileza verifique seu email";

            await _emailSender.SendEmailAsync(email, "Confirme seu Email antes de logar", $"Por gentileza, confirme sua conta <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>Clicando aqui</a>.");

            return Page();
        }
    }
}
