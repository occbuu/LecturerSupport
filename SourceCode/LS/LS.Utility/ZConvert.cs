using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Globalization;

namespace LS.Utility
{
    /// <summary>
    /// Convert data type
    /// </summary>
    public static class ZConvert
    {
        #region -- Methods --

        #region -- Numeric --
        /// <summary>
        /// Converts the specified string representation of a number to an equivalent 32-bit signed integer
        /// </summary>
        /// <param name="s">String number</param>
        /// <returns>Return the number</returns>
        public static int ToInt32(this string s)
        {
            int i = 0;
            Int32.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified nullable int representation of a number to an equivalent string 32-bit signed integer
        /// </summary>
        /// <param name="i">Nullable number</param>
        /// <returns>Return the string number</returns>
        public static string ToInt32Empty(this int? i)
        {
            var j = i.ToInt32();
            return j == 0 ? string.Empty : j.ToString();
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent 32-bit signed integer
        /// </summary>
        /// <param name="o">Object number</param>
        /// <returns>Return the number</returns>
        public static int ToInt32(this object o)
        {
            int i = 0;
            var s = o + string.Empty;
            Int32.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent 64-bit signed integer
        /// </summary>
        /// <param name="s">String number</param>
        /// <returns>Return the number</returns>
        public static long ToInt64(this string s)
        {
            long i = 0;
            Int64.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent 64-bit signed integer
        /// </summary>
        /// <param name="o">Object number</param>
        /// <returns>Return the number</returns>
        public static long ToInt64(this object o)
        {
            long i = 0;
            var s = o + string.Empty;
            Int64.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent float number
        /// </summary>
        /// <param name="s">String number</param>
        /// <returns>Return the number</returns>
        public static float ToFloat(this string s)
        {
            float i = 0;
            Single.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent float number
        /// </summary>
        /// <param name="o">Object number</param>
        /// <returns>Return the number</returns>
        public static float ToFloat(this object o)
        {
            float i = 0;
            var s = o + string.Empty;
            Single.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent double number
        /// </summary>
        /// <param name="s">String number</param>
        /// <returns>Return the number</returns>
        public static double ToDouble(this string s)
        {
            double i = 0;
            Double.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent double number
        /// </summary>
        /// <param name="o">Object number</param>
        /// <returns>Return the number</returns>
        public static double ToDouble(this object o)
        {
            double i = 0;
            var s = o + string.Empty;
            Double.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent decimal number
        /// </summary>
        /// <param name="s">String number</param>
        /// <returns>Return the number</returns>
        public static decimal ToDecimal(this string s)
        {
            decimal i = 0;
            Decimal.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent decimal number
        /// </summary>
        /// <param name="o">Object number</param>
        /// <returns>Return the number</returns>
        public static decimal ToDecimal(this object o)
        {
            decimal i = 0;
            var s = o + string.Empty;
            Decimal.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent boolean
        /// </summary>
        /// <param name="s">String boolean</param>
        /// <returns>Return the boolean</returns>
        public static bool ToBoolean(this string s)
        {
            bool i = false;
            Boolean.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent boolean
        /// </summary>
        /// <param name="o">Object boolean</param>
        /// <returns>Return the boolean</returns>
        public static bool ToBoolean(this object o)
        {
            bool i = false;
            var s = o + string.Empty;
            Boolean.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Convert Yes or No to boolean
        /// </summary>
        /// <param name="s">Input Yes or No</param>
        /// <returns>Return a boolean value</returns>
        public static bool ToBool(this string s)
        {
            var a = PRAction.Yes.ToString().ToLower();
            var b = (s + string.Empty).ToLower();
            return a.Equals(b);
        }

        /// <summary>
        /// Convert boolean to Yes or No
        /// </summary>
        /// <param name="b">Boolean value</param>
        /// <returns>Return a string Yes or No</returns>
        public static string ToYesNo(this bool? b)
        {
            var a = (b ?? false) ? PRAction.Yes : PRAction.No;
            return a.ToString();
        }
        #endregion

        #region -- DateTime --
        /// <summary>
        /// Converts the specified string representation of a number to an equivalent date and time
        /// </summary>
        /// <param name="s">String DateTime</param>
        /// <returns>Return the DateTime</returns>
        public static DateTime ToDateTime(this string s)
        {
            var i = DateTime.Now;
            DateTime.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent date and time
        /// </summary>
        /// <param name="o">Object DateTime</param>
        /// <returns>Return the DateTime</returns>
        public static DateTime ToDateTime(this object o)
        {
            var i = DateTime.Now;
            var s = o + string.Empty;
            DateTime.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Convert DateTime to string with format dd-MMM-yyyy
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrDate(this DateTime d)
        {
            var res = d.ToString(DateTimeFormat.Date);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format hh:mm tt
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrTime(this DateTime d)
        {
            var res = d.ToString(DateTimeFormat.TimeNoSec);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format dd-MMM-yyyy hh:mm:ss tt
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrDateTime(this DateTime d)
        {
            var res = d.ToString(DateTimeFormat.DateTime);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format dd-MMM-yyyy
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrDate(this DateTime? d)
        {
            if (d == null)
            {
                return string.Empty;
            }
            var res = d.Value.ToString(DateTimeFormat.Date);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrSqlDateTime(this DateTime d)
        {
            var res = d.ToString(DateTimeFormat.SqlDateTime);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrSqlDateTime(this DateTime? d)
        {
            var res = d == null ? string.Empty : d.Value.ToString(DateTimeFormat.SqlDateTime);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrIsoDateTime(this DateTime d)
        {
            var res = d.ToString(DateTimeFormat.IsoDateTime);
            return res;
        }

        /// <summary>
        /// Convert DateTime to string with format yyyy/MM/dd HH:mm:ss
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return the string</returns>
        public static string ToStrIsoDateTime(this DateTime? d)
        {
            var res = d == null ? string.Empty : d.Value.ToString(DateTimeFormat.IsoDateTime, CultureInfo.InvariantCulture);
            return res;
        }

        /// <summary>
        /// Convert DateTime to start of day
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return start of day</returns>
        public static DateTime ToStartDay(this DateTime d)
        {
            return d.Date;
        }

        /// <summary>
        /// Convert DateTime to end of day
        /// </summary>
        /// <param name="d">DateTime object</param>
        /// <returns>Return end of day</returns>
        public static DateTime ToEndDay(this DateTime d)
        {
            d = d.Date.AddDays(1).AddSeconds(-1);
            return d;
        }
        #endregion

        #region -- String --
        /// <summary>
        /// Return a copy of this string with first letter converted to uppercase
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>Return uppercase first letter</returns>
        public static string ToUpperFirst(this string s)
        {
            try
            {
                s = s.Trim();
                if (String.IsNullOrEmpty(s)) return String.Empty;
                return Char.ToUpper(s[0]) + s.Substring(1).ToLower();
            }
            catch { return s; }
        }

        /// <summary>
        /// Return a copy of this string with first letter of each word converted to uppercase
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>Return uppercase first letter of any words</returns>
        public static string ToUpperWords(this string s)
        {
            try
            {
                s = s.Trim();
                var arr = s.ToCharArray();
                if (arr.Length >= 1)
                    if (Char.IsLower(arr[0]))
                        arr[0] = Char.ToUpper(arr[0]);
                for (var i = 1; i < arr.Length; i++)
                {
                    if (arr[i - 1] == SpecialChar.Space)
                        if (Char.IsLower(arr[i]))
                            arr[i] = Char.ToUpper(arr[i]);
                }
                return new string(arr);
            }
            catch { return s; }
        }

        /// <summary>
        /// Convert the object to string with format
        /// </summary>
        /// <param name="o">Object</param>
        /// <param name="f">Format type</param>
        /// <returns>Return the string</returns>
        public static string ToStr(this object o, Format f = Format.Orginal)
        {
            try
            {
                var c = o.ToStr();
                switch (f)
                {
                    case Format.Sentence: return c.ToUpperFirst();
                    case Format.Lower: return c.ToLower();
                    case Format.Upper: return c.ToUpper();
                    case Format.Capitalized: return c.ToUpperWords();
                    default: return c;
                }
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Convert the object to string
        /// </summary>
        /// <param name="o">Object</param>
        /// <returns>Return the string</returns>
        public static string ToStr(this object o)
        {
            var s = o == null ? string.Empty : o.ToString();
            return s;
        }

        /// <summary>
        /// Add one space AbCd to Ab Cd
        /// </summary>
        /// <param name="s">Input string</param>
        /// <returns>Return string with space</returns>
        public static string ToAddSpace(this string s)
        {
            var c = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if ('A' <= s[i] && s[i] <= 'Z')
                {
                    c += SpecialString.Space;
                }
                c += s[i];
            }
            return c.Trim();
        }

        /// <summary>
        /// Standardize string
        /// </summary>
        /// <param name="s">A string</param>
        /// <returns>Return the standardized string</returns>
        public static string Standardize(this string s)
        {
            s = s + string.Empty;
            s = s.Replace(SpecialString.Quotation, string.Empty);
            s = s.Replace(SpecialString.LeftSquare, string.Empty);
            s = s.Replace(SpecialString.RightSquare, string.Empty);
            return s;
        }
        #endregion

        #region -- Guid --

        /// <summary>
        /// Converts the specified string representation of a number to an equivalent Guid
        /// </summary>
        /// <param name="s">String</param>
        /// <returns>Return Guid (if error Guid.Empty)</returns>
        public static Guid ToGuid(this string s)
        {
            var i = Guid.Empty;
            Guid.TryParse(s, out i);
            return i;
        }

        /// <summary>
        /// Converts the specified object representation of a number to an equivalent Guid
        /// </summary>
        /// <param name="o">Object</param>
        /// <returns>Return Guid (if error Guid.Empty)</returns>
        public static Guid ToGuid(this object o)
        {
            var i = Guid.Empty;
            Guid.TryParse(o + SpecialString.Space, out i);
            return i;
        }

        #endregion

        #region -- Data --

        /// <summary>
        /// Get enum description
        /// </summary>
        /// <param name="value">Value of enum</param>
        /// <returns>Return the description</returns>
        public static string ToDescription(this Enum value)
        {
            var val = value.ToString();
            var fi = value.GetType().GetField(val);
            var attributes = (DescriptionAttribute[])fi
                .GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes != null && attributes.Length > 0)
            {
                val = attributes[0].Description;
            }
            return val;
        }

        /// <summary>
        /// Convert a string number separation with semicolon
        /// </summary>
        /// <param name="s">String number separation with semicolon</param>
        /// <returns>Return list int</returns>
        public static List<int> ToListInt32(this string s)
        {
            var list = new List<int>();
            var arr = s.Split(new char[] { SpecialChar.Semicolon }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var i in arr)
            {
                list.Add(i.ToInt32());
            }
            return list;
        }

        /// <summary>
        /// Convert from IEnumerable (LINQ, List object) to DataTable
        /// </summary>
        /// <typeparam name="T">Class</typeparam>
        /// <param name="d">Data</param>
        /// <param name="s">Table name</param>
        /// <returns>Return a DataTable</returns>
        public static DataTable ToDataTable<T>(this IEnumerable<T> d, string s = SpecialString.Blank)
        {
            var properties = typeof(T).GetProperties();
            var tb = new DataTable(s);

            foreach (var prop in properties)
            {
                Type type = prop.PropertyType;
                if ((type.IsGenericType) && (type.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    type = type.GetGenericArguments()[0];
                tb.Columns.Add(new DataColumn(prop.Name, type));
            }

            foreach (var item in d)
            {
                var r = tb.NewRow();
                foreach (var prop in properties)
                    r[prop.Name] = prop.GetValue(item, null) ?? DBNull.Value; ;
                tb.Rows.Add(r);
            }

            tb.AcceptChanges();
            return tb;
        }
        #endregion

        #region -- Enums --

        /// <summary>
        /// Convert string module code to enum module code
        /// </summary>
        /// <param name="s">String module code</param>
        /// <returns>Return the enum module code</returns>
        //public static ModuleCode ToModuleCode(this string s)
        //{
        //    var e = ModuleCode.anno;
        //    Enum.TryParse(s, out e);
        //    return e;
        //}

        /// <summary>
        /// Convert string pr code to enum pr code
        /// </summary>
        /// <param name="s">String pr code</param>
        /// <returns>Return the enum pr code</returns>
        //public static PRCode ToPRCode(this string s)
        //{
        //    var e = PRCode.LYP;
        //    Enum.TryParse(s, out e);
        //    return e;
        //}

        #endregion

        #endregion
    }
}