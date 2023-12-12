namespace functionsAndDetails
{
    public class Program
    {
        public static void Main()
        {

            int modOutput = 0;
            int result = divide(15, 2, out modOutput);
            Console.WriteLine($"bölümün sonucu: {result}, kalan ise {modOutput}");

            int number = 8;
            doIt(ref number);


            Console.WriteLine($"Main metodundaki sonuç: {number}");

            Console.WriteLine($"Daire'nin alanı: {getArea(5, "Daire")}");
            Console.WriteLine($"Dikdörtgen'in alanı: {getArea(5, 3, "Dikdörtgen")}");

            Console.WriteLine($"Daire'nin alanı: {getAreaOptional(x: 5, shape: "Daire")}");
            Console.WriteLine($"Dikdörtgen'in alanı: {getAreaOptional(x: 5, y: 3, shape: "Dikdörtgen")}");





            /*
             * Adam asmaca
             *  1. Bir kelime listesi içinden rastgele bir kelime seç.,
             *  2. Seçilen kelimeyi bulmacaya dönüştür (****)
             *  3. Kullanıcıdan harf iste
             *  4. Harfin kelime içinde olup olmadığına bak
             *    5.a. Eğer varsa o kelime içindeki yerleri bulmacada göster (a**a)
             *    5.b. Eğer yoksa, harf alma hakkından bir hak düş
             *  6. Bir harf daha girip girmeyeceğini sor Evet ise 3. Adıma git
             *  7. Kelime tahmin etmesini iste.
             *  8. Tahmin edilen ile tutulan kelimeyi karşılaştır.
             *    9.a Eğer doğruysa bildiniz de.
             *    9.b Eğer yanlış ise 3. Adıma geri dön
             *  10. Oyun bittiğinde tekrar isteyip istemediğini sor...  
             */

            do
            {
                List<string> wordCollection = new List<string>();
                string word = getWordInCollection(wordCollection);
                string puzzle = convertToPuzzle(word);
                Console.WriteLine(puzzle);
                do
                {
                    string letter = getLetterFromUser();
                    if (isLetterExistInAWord(letter, word))
                    {
                        puzzle = showLetterInAPuzzle(letter, puzzle);
                    }
                    else
                    {
                        minimizeLetterCount();
                    }
                    //zaman kaybetmemek için atlandı
                    if (compareTwoWords("ayna", word))
                    {
                        Console.WriteLine("Bildiniz");
                    }

                } while (false);
            } while (false);

        }

        static string getWordInCollection(List<string> words)
        {
            return "ayna";
        }

        static string convertToPuzzle(string word)
        {
            return "****";
        }

        static string getLetterFromUser()
        {
            return "a";
        }

        static bool isLetterExistInAWord(string letter, string word)
        {
            return true;
        }

        static string showLetterInAPuzzle(string letter, string puzzle)
        {
            return "a**a";
        }

        static void minimizeLetterCount()
        {
            //haktan bir azaldı
        }

        static bool compareTwoWords(string word1, string word2)
        {
            return true;
        }

        static int divide(int num1, int num2, out int modulo)
        {
            modulo = num1 % num2;
            return num1 / num2;
        }



        static DivideElements divideObject(int num1, int num2)
        {
            return new DivideElements
            {
                Modulo = num1 % num2,
                Result = num1 / num2
            };
        }


        static void doIt(ref int number)
        {
            number *= 2;
            Console.WriteLine($"Burası do it fonksiyonu: {number}");
        }


        /*Daire,        Kare,    Üçgen, Dikdörtgen */
        /*  (a*a)*pi    a*a      (a*h)/2    a*b    */

        /// <summary>
        /// Sadece Daire veya Kare şekillerinin alanını hesaplar.
        /// </summary>
        /// <param name="x">Şeklin birim uzunluğunu giriniz.</param>
        /// <param name="shape">Daire ya da Kare giriniz</param>
        /// <returns>alan değerini döndürür</returns>
        static double getArea(int x, string shape)
        {
            switch (shape)
            {
                case "Kare":
                    return Math.Pow(x, 2);
                case "Daire":
                    return Math.Pow(x, 2) * Math.PI;
                default:
                    return 0;

            }
        }
        /// <summary>
        /// Sadece Üçgen veya Dörtgen şekillerinin alanını hesaplar.
        /// </summary>
        /// <param name="x">Şeklin birim uzunluğunu giriniz.</param>
        /// <param name="y">Şeklin diğer birim uzunluğunu giriniz.</param>
        /// <param name="shape">Üçgen veya....</param>
        /// <returns>...</returns>
        static double getArea(int x, int y, string shape)
        {
            switch (shape)
            {
                case "Üçgen":
                    return (x * y) / 2;
                case "Dikdörtgen":
                    return x * y;
                default:
                    return 0;

            }
        }

        static double getAreaOptional(int x, int y = 1, string shape = "Kare")
        {

            switch (shape)
            {
                case "Kare":
                    return Math.Pow(x, 2);
                case "Daire":
                    return Math.Pow(x, 2) * Math.PI;
                case "Üçgen":
                    return (x * y) / 2;
                case "Dikdörtgen":
                    return x * y;
                default:
                    return 0;

            }
        }

    }


    public class DivideElements
    {
        public int Result { get; set; }
        public int Modulo { get; set; }
    }

}

