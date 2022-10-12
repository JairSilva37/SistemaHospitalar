namespace Cooperchip.ITDeveloper.Domain.Validations.Helpers
{
    public class StringUtils
    {
        public static string ApenasNumeros(string valor)
        {
            var onyNumber = "";
            foreach (var s in valor)
            {
                if (char.IsDigit(s))
                {
                    onyNumber += s;
                }
            }
            return onyNumber;
        }
    }
}
