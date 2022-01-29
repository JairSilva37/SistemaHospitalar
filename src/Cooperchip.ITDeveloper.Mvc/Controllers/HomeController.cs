
using Cooperchip.ITDeveloper.Application.ViewModels;
using Cooperchip.ITDeveloper.Domain.Interfaces;
using KissLog;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Controllers
{
    [Route("")]
    [Route("gestao-de-paciente")]
    [Route("gestao-de-pacientes")]
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger _logger;
        private readonly IUserInContext _user;
        private readonly IUserInAllLayer _userInAllLayer;
        public HomeController(IEmailSender emailSender, ILogger logger, IUserInContext user, IUserInAllLayer userInAllLayer)
        {
            _emailSender = emailSender;
            _logger = logger;
            _user = user;
            _userInAllLayer = userInAllLayer;
        }

        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index()
        {
            return View();
        }


        [Route("dashboard")]
        [Route("pagina-de-estatistica")]
        //[Authorize(Roles ="Admin")]
        public IActionResult Dashboard()
        {

            var email = "";
            IDictionary<string, string> minhasCaims = new Dictionary<string, string>();

            if (_user.IsAuthenticated())
            {
                var apelido = User.FindFirst(x => x.Type == "Apelido")?.Value;
                email = User.FindFirst(x => x.Type == "Email")?.Value;

                minhasCaims.Add("Apelido", _user.GetUserApelido());
                minhasCaims.Add("Nome Comleto", _user.GetUserNomeCompleto());
                minhasCaims.Add("Imagem do Perfil", _user.GetUserImgProfilePath());
                minhasCaims.Add("Id", _user.GetUserId().ToString());
                minhasCaims.Add("Nome", _user.Name);
                minhasCaims.Add("Email", _user.GetUserEmail());
                minhasCaims.Add("E Administrador", _user.IsInRole("Admin") ? "SIM" : "NÃO");

                var testeUserClaims = minhasCaims;
                var testeDicionaryOfClaims = _userInAllLayer.DictonaryOfCaimss();
                var testeUserListClaims = _userInAllLayer.LisOfClaims();

                var nome = minhasCaims["Nome"];
                email = minhasCaims["Email"];
                var EhAdministrador = minhasCaims["E Administrador"];
            }

                return View();
        }

        [Route("box-init")]
        public IActionResult BoxInit()
        {
            return View();
        }

        [Route("quem-somos")]
        [Route("sobre-nos")]
        [Route("sobre/{id:guid}/{paciente}/{categoria?}")]
        public IActionResult Sobre(Guid id, string paciente, string categoria)
        {
            return View();
        }

        [HttpGet("fale-conosco")]
        public IActionResult Contato()
        {
            return View();
        }

        [HttpPost]
        [Route("fale-conosco")]
        public async Task<IActionResult> Contato(ContatoViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _emailSender.SendEmailAsync(model.Email, model.Subject, model.Message);
                    _logger.Log(LogLevel.Information, "Email enviado com sucesso!");
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception e)
                {
                    _logger.Log(LogLevel.Error, $"Erro tentando enviar email: {e.Message}!");
                    throw;
                }
            }
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("erro")]
        [Route("erro-encontrado")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
