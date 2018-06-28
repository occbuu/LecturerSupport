namespace LS.Web.Common
{
    public class StringDateTime
    {
        /// <summary>
        /// Convert a string to a datetime string  with formatting month/day/year 
        /// </summary>
        /// <param name="str">a string</param>
        /// <returns>string with MM/dd/yyyy format</returns>
        public static string StringToFormatDate(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            var nStr = str.Split('/');
            if (nStr.Length != 3 || nStr[0].Length!=2 || nStr[1].Length!=2 || nStr[2].Length!=4)
            {
                return null;
            }
            try
            {
                var month = int.Parse(nStr[0]);
                var day = int.Parse(nStr[1]);
                var year = int.Parse(nStr[2]);
                if(month>12 || day > 31)
                {
                    return null;
                }
                var stringDate = (month + "/" + day + "/" + year).ToString();
                return stringDate;
            }
            catch
            {
                return null;
            }
        }
    }
}