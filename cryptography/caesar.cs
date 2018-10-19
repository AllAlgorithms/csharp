        // Encode a char
        static char EncodeCaractere(char caractere, char encodeur)
        {
            int asciiCaractere = (int)caractere;
            int asciiEncodeur = (int)encodeur;
            int asciiCaractereCode = ((asciiCaractere - 97) + (asciiEncodeur - 97)) % 26;
            char caractereCode = (char)(asciiCaractereCode + 97);

            return caractereCode;
        }

        // Decode a char
        static char DecodeCaractere(char caractere, char encodeur)
        {
            int asciiCaractere = (int)caractere;
            int asciiEncodeur = (int)encodeur;
            int asciiCaractereCode = ((asciiCaractere - 97) - (asciiEncodeur - 97)) % 26;
            char caractereCode = (char)(asciiCaractereCode + 97);

            return caractereCode;
        }

        // Encode a word
        static String EncodeMot(String mot, Char encodeur)
        {
            char[] retour = new char[mot.Length];
            for(int i = 0; i < retour.Length; i++)
            {
                retour[i] = EncodeCaractere(mot[i], encodeur);
            }
            string str = new string(retour);
            return str;
        }

        // Decode a word
        static String DecodeMot(String mot, Char encodeur)
        {
            char[] retour = new char[mot.Length];
            for (int i = 0; i < retour.Length; i++)
            {
                retour[i] = DecodeCaractere(mot[i], encodeur);
            }
            string str = new string(retour);
            return str;
        }

        // Encode a sentence
        static String EncodePhrase(String phrase, Char encodeur)
        {
            String[] ph = phrase.Split(' ');
            String[] retour = ph;
            for (int i = 0; i < ph.Length; i++)
            {
                retour[i] = EncodeMot(ph[i], encodeur);
            }
            StringBuilder builder = new StringBuilder();
            foreach(string str in retour)
            {
                builder.Append(str);
                builder.Append(" ");
            }
            return builder.ToString();
        }

        // Decode a sentence
        static String DecodePhrase(String phrase, Char encodeur)
        {
            String[] ph = phrase.Split(' ');
            String[] retour = ph;
            for (int i = 0; i < ph.Length; i++)
            {
                retour[i] = DecodeMot(ph[i], encodeur);
            }
            StringBuilder builder = new StringBuilder();
            foreach (string str in retour)
            {
                builder.Append(str);
                builder.Append(" ");
            }
            return builder.ToString();
        }

        // Main method to encode any text input
        static void CesarEncode()
        {
            String userInput = Console.ReadLine();
            String crypt = EncodePhrase(userInput, 'c');
            Console.WriteLine("La phrase cryptée est la suivante :");
            Console.WriteLine(crypt);
        }

        // Main method to decode any text input
        static void CesarDecode()
        {
            StreamReader sr = new StreamReader(fichier, true);
            StringBuilder builder = new StringBuilder();
            while (sr.Peek() > 0)
            {
                builder.Append(sr.ReadLine());
                builder.Append(" ");
            }
            sr.Close();
            String code = builder.ToString();
            String dcode = DecodePhrase(code, 'c');
            Console.WriteLine("La phrase décryptée est la suivante :");
            Console.WriteLine(dcode);

        }
