﻿using Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.Helpers;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDeveloper.Mvc.Extensions.ViewComponents.Cabecalho
{
    [ViewComponent(Name = "Cabecalho")]
    public class CabecalhoViewComponents : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string titulo, string subtitulo)
        {
            var model = new Modulo()
            {
                Titulo = titulo,
                Subtitulo = subtitulo
            };

            return View(model);
        }
    }
}
