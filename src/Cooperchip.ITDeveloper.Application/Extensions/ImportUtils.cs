using System;
using System.IO;
using System.Reflection;

namespace Cooperchip.ITDeveloper.Application.Extensions
{
    public static class ImportUtils
    {

        //retorna caminho do arquivo
        public static string GetFilePath(string raiz, string finename, string extension)
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var csvPath = Path.Combine(outPutDirectory, $"{raiz}\\{finename}{extension}");
            return new Uri(csvPath).LocalPath;
        }

    }
}
