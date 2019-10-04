using System;
using System.Collections.Generic;
using System.Text;

namespace Url_nicer
{
    class Url
    {
        // rebuilds the string when encounters a hyphened character it changes it the correspondant char.
        internal static string Clean(string url)
        {
            url = url.ToLower();
            string nice_url = "";
            foreach (var c in url)
            {
                if (c is 'á')
                {
                    nice_url += 'a';
                }
                else if (c is 'é')
                {
                    nice_url += 'e';
                }
                else if (c is 'í')
                {
                    nice_url += 'i';
                }
                else if (c is 'ó' || c is 'ö' || c is 'ő')
                {
                    nice_url += 'o';
                }
                else if (c is 'ú' || c is 'ü' || c is 'ű')
                {
                    nice_url += 'u';
                }
                // etc with french chars...
                else if (c is '.' || c is '-' || c is ' ')
                {
                    nice_url += '_';
                }
                else
                {
                    nice_url += c;
                }
            }
            return nice_url;
        }
    }
}
