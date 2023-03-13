
namespace Inoxico.TechnicalQuestions.Answers
{
    public class QuestionTwo
    {
        public static int GetPitDepth(int[] points)
        {
            int depth = 0;
            int P = 0, Q = -1, R = -1;
            for (int i = 1; i < points.Count() / sizeof(int); i++)
            {
                depth += points[i];
            }
            return depth;
        }
    }
}
