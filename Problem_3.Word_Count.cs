using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;


class Problem_3_Word_Count
{
    static void Main()
    {
        using (var wordsReader = new StreamReader("words.txt"))
        {
            List<string> words = new List<string>();
            List<string> statements = new List<string>();
            

            string line = wordsReader.ReadLine();

            while (line != null)
            {
                words.Add(line);
                line = wordsReader.ReadLine();
            }
            

            using (var textReader = new StreamReader("text.txt"))
            {
                string secondLine = textReader.ReadLine();

                while (secondLine != null)
                {
                    statements.Add(secondLine);
                    secondLine = textReader.ReadLine();
                }


                using (var textWriter = new StreamWriter("result.txt"))
                {
                    
                    int wordCounter = 0;

                    for (int i = 0; i < words.Count; i++)
                    {
                        for (int j = 0; j < statements.Count; j++)
                        {
                            if (statements[j].ToLower().Contains(words[i].ToLower()))
                            {
                                wordCounter++;
                            }
                        }
                        textWriter.WriteLine("{0} - {1}",words[i],wordCounter);
                        wordCounter = 0;
                    }
                }
            }
        }
    }
}
