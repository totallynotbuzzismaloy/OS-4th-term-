using System.Text.RegularExpressions;

namespace OS_6thLab
{
    public class myParseString
    {
        public int MyGetIDProcess(string currentID)
        {
            var tempString = Regex.Match(currentID,$"[^ ]*$").ToString();
            var returnNumb = System.Convert.ToInt32(tempString);
            return returnNumb;
        }
    }
}