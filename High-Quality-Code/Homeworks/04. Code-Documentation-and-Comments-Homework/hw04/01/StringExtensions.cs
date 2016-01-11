using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

/// <summary>
/// Utility classe which provides static string derivates methods.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// I don't know what it does, but probably it transoforms a given string in md5Hash inserting "x2" after each simbol of the md5hashed
    /// </summary>
    /// <param name="input">The string which will be transformed in md5Hash</param>
    /// <returns></returns>
    public static string ToMd5Hash(this string input)
    {
        var md5Hash = MD5.Create();
        var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
        var builder = new StringBuilder();

        for (int i = 0; i < data.Length; i++)
        {
            builder.Append(data[i].ToString("x2"));
        }

        return builder.ToString();
    }
    /// <summary>
    /// Interpretates if a given string is in some fixed array with values
    /// </summary>
    /// <param name="input">The string which will be interpretated</param>
    /// <returns></returns>
    public static bool ToBoolean(this string input)
    {
        var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
        return stringTrueValues.Contains(input.ToLower());
    }
    /// <summary>
    /// Interpretates if a given string is a short type number and returns the result of the interpretation.
    /// </summary>
    /// <param name="input">The string which will be interpretated</param>
    /// <returns></returns>
    public static short ToShort(this string input)
    {
        short shortValue;
        short.TryParse(input, out shortValue);
        return shortValue;
    }
    /// <summary>
    /// Interpretates if a given string is an integer type number and returns the result of the interpretation.
    /// </summary>
    /// <param name="input">The string which will be interpretated</param>
    /// <returns></returns>
    public static int ToInteger(this string input)
    {
        int integerValue;
        int.TryParse(input, out integerValue);
        return integerValue;
    }
    /// <summary>
    /// Interpretates if a given string is a long type number and returns the result of the interpretation.
    /// </summary>
    /// <param name="input">The string which will be interpretated</param>
    /// <returns></returns>
    public static long ToLong(this string input)
    {
        long longValue;
        long.TryParse(input, out longValue);
        return longValue;
    }
    /// <summary>
    /// Interpretates if a given string is a DateTime type value and returns the result of the interpretation.
    /// </summary>
    /// <param name="input">The string which will be interpretated</param>
    /// <returns></returns>
    public static DateTime ToDateTime(this string input)
    {
        DateTime dateTimeValue;
        DateTime.TryParse(input, out dateTimeValue);
        return dateTimeValue;
    }
    /// <summary>
    /// Returns the given string with CapitalizedLetter
    /// </summary>
    /// <param name="input">The string which first letter will be Capitalized</param>
    /// <returns></returns>
    public static string CapitalizeFirstLetter(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }

        return 
            input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + 
            input.Substring(1, input.Length - 1);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="input">The string of which will be cut a part</param>
    /// <param name="startString">The first string found in the given string after the "startFrom" parameter position from which the result string to starts</param>
    /// <param name="endString">the first string found in the given string after the "startFrom" parameter position to which the result string to ends</param>
    /// <param name="startFrom">from which position of the given string to start searching for the substring determined by the first occurances of the "startString" and "endString" parameters</param>
    /// <returns></returns>
    public static string GetStringBetween(
        this string input, string startString, string endString, int startFrom = 0)
    {
        input = input.Substring(startFrom);
        startFrom = 0;
        if (!input.Contains(startString) || !input.Contains(endString))
        {
            return string.Empty;
        }

        var startPosition = 
            input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
        if (startPosition == -1)
        {
            return string.Empty;
        }

        var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
        if (endPosition == -1)
        {
            return string.Empty;
        }

        return input.Substring(startPosition, endPosition - startPosition);
    }
    /// <summary>
    /// The name of the method is too good :)
    /// </summary>
    /// <param name="input">The string that will be converted</param>
    /// <returns></returns>
    public static string ConvertCyrillicToLatinLetters(this string input)
    {
        var bulgarianLetters = new[]
        {
            "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о",
            "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
        };
        var latinRepresentationsOfBulgarianLetters = new[]
        {
            "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
            "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
            "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
        };
        for (var i = 0; i < bulgarianLetters.Length; i++)
        {
            input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
            input = input.Replace(bulgarianLetters[i].ToUpper(),
                latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
        }

        return input;
    }
    /// <summary>
    /// The name of the method is too good  probably change in it keyboard with letters :)
    /// </summary>
    /// <param name="input">The string that will be converted</param>
    /// <returns></returns>
    public static string ConvertLatinToCyrillicKeyboard(this string input)
    {
        var latinLetters = new[]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
            "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        var bulgarianRepresentationOfLatinKeyboard = new[]
        {
            "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
            "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
            "в", "ь", "ъ", "з"
        };

        for (int i = 0; i < latinLetters.Length; i++)
        {
            input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
            input = input.Replace(latinLetters[i].ToUpper(),
                bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
        }

        return input;
    }
    /// <summary>
    /// The name of the method is too good :)
    /// </summary>
    /// <param name="input">the string which will be transformed in valid form and returned</param>
    /// <returns></returns>
    public static string ToValidUsername(this string input)
    {
        input = input.ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
    }
    /// <summary>
    /// The name of the method is too good :)
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static string ToValidLatinFileName(this string input)
    {
        input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
        return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
    }
    /// <summary>
    /// Returns the begining part of a given string
    /// </summary>
    /// <param name="input">the string from which to be returned only the first part with length the "charsCount" parameter</param>
    /// <param name="charsCount">how many letters from the begining of the given string to be returned</param>
    /// <returns></returns>
    public static string GetFirstCharacters(this string input, int charsCount)
    {
        return input.Substring(0, Math.Min(input.Length, charsCount));
    }
    /// <summary>
    /// The name of the method is too good :)
    /// </summary>
    /// <param name="fileName">given string which must have a "." and extension of a file name</param>
    /// <returns></returns>
    public static string GetFileExtension(this string fileName)
    {
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return string.Empty;
        }

        string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
        if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
        {
            return string.Empty;
        }

        return fileParts.Last().Trim().ToLower();
    }
    /// <summary>
    /// Checks if the given string is from a specific file extension and if it is it returns the content type, if not it returns "application/octet-stream"
    /// </summary>
    /// <param name="fileExtension">the string that will be checked if it is extension from known type</param>
    /// <returns></returns>
    public static string ToContentType(this string fileExtension)
    {
        var fileExtensionToContentType = new Dictionary<string, string>
        {
            { "jpg", "image/jpeg" },
            { "jpeg", "image/jpeg" },
            { "png", "image/x-png" },
            { "docx", "application/vnd.openxmlformats-officedocument.wordprocessingml.document" },
            { "doc", "application/msword" },
            { "pdf", "application/pdf" },
            { "txt", "text/plain" },
            { "rtf", "application/rtf" }
        };
        if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
        {
            return fileExtensionToContentType[fileExtension.Trim()];
        }

        return "application/octet-stream";
    }
    /// <summary>
    /// Transforms a string into bytes array
    /// </summary>
    /// <param name="input">the string that will be transformed into bytes array</param>
    /// <returns></returns>
    public static byte[] ToByteArray(this string input)
    {
        var bytesArray = new byte[input.Length * sizeof(char)];
        Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
        return bytesArray;
    }
}
