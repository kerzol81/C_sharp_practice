static void URL_Nicer(string s) {
            s = s.ToLower();
            string cleaned = "";

            foreach (var item in s)
            {
                if (item is 'á')
                {
                    cleaned += 'a';
                }
                else if (item is 'é')
                {
                    cleaned += 'e';
                }
                else if (item is 'í')
                {
                    cleaned += 'i';
                }
                else if (item is 'ó' || item is 'ő' || item is 'ö')
                {
                    cleaned += 'o';
                }
                else if (item is 'ú' || item is 'ü' || item is 'ű')
                {
                    cleaned += 'u';
                }
                else if (item is ' ' || item is '.')
                {
                    cleaned += '_';
                }
                else
                {
                    cleaned += item;
                }
            }
            
            Console.WriteLine(cleaned);
        }
