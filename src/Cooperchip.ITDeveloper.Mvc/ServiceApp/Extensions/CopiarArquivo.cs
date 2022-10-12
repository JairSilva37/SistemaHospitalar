using Microsoft.AspNetCore.Http;
using System.IO;

namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public static class CopiarArquivo
    {
        public static void Copiar(IFormFile file, string filePath)
        {
            //if (!File.Exists(filePath))
            //{
            using (FileStream fileStream = File.Create(filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
            }
            //}
        }
    }
}
