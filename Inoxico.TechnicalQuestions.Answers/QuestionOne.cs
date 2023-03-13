
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
                string[] Words = strSentence.Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                if (WordsCount < Words.Length)
                {
                    WordsCount = Words.Length;
                    sentencewithwords = strSentence ;
                }
            }

            return WordsCount;
        }

    }
}



