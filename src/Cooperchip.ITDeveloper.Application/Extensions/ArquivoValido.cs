using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public static class ArquivoValido
    {
        public static bool EhValido(IFormFile file, string arquivoParametro)
        {
            return file != null && !string.IsNullOrEmpty(file.FileName)
                && (arquivoParametro.ToUpper() == file.FileName.ToUpper());
        }
    }
}
