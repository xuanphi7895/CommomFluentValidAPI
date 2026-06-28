
using System.Text.RegularExpressions;

namespace CommonFluentValidAPI
{

    public delegate bool RequiredValidDel(string fieldVal);
    public delegate bool StringLengthValidDel(string fieldVal, int min, int max);
    public delegate bool DateValidDel(string fieldVal, out DateTime validDateTime);
    public delegate bool PatternMatchValidDel(string fieldVal, string pattern);
    public delegate bool CompareFieldsValidDel(string fieldVal, string fieldValCompare);
    public class CommonFieldValidatorFunctions
    {
        public static bool RequiredFieldValidDel(string fieldVal)
        {
            if (!string.IsNullOrEmpty(fieldVal))
            {
                return true;
            }
            return false;
        }
        public static bool LengthFieldValidDel(string fieldVal, int min, int max)
        {
            if (fieldVal.Length >= min && fieldVal.Length <= max)
            {
                return true;
            }
            return false;
        }

        public static bool DateFieldValidDel(string datetime, out DateTime validDateTime)
        {
            if (!DateTime.TryParse(datetime, out validDateTime))
            {
                return true;
            }
            return false;
        }

        public static bool PatternMatchValidDel(string fieldVal, string pattern)
        {
            var regex = new Regex(pattern);
            if (regex.IsMatch(fieldVal))
            {
                return true;
            }
            return false;
        }

        public static bool CompareFieldsValidDel(string fieldVal1, string filedVal2)
        {
            if (filedVal2.Equals(fieldVal1))
            {
                return true;
            }
            return false;
        }
    }
}
