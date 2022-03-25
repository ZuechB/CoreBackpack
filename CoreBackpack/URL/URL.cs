using System;
using System.IO;

namespace CoreBackpack.URL
{
    public class URL
    {
        public static string GetFileName(string url)
        {
            return Path.GetFileName(url);
        }
    }
}