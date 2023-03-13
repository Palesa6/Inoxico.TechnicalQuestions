
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionOne
    {
        
        public static int GetLongestSentance(string s)
        {
            int WordsCount = 0;
            string sentencewithwords = string.Empty;
            string[] arrAllSentences = s.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string strSentence in arrAllSentences)
            {
                string[] arrWords = strSentence.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                if (WordsCount < arrWords.Length)
                {
                    WordsCount = arrWords.Length;
                    sentencewithwords = strSentence + ".";
                }
            }

            return WordsCount;
        }

    }
}



