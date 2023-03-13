
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
                if(Q < 0 && points[i] >= points[i - 1])
                  Q = i - 1;
                if ((Q >= 0 && R < 0) &&(points[i] <= points[i - 1] || i + 1 == points.Count() / sizeof(int)))
                {
                    if (points[i] <= points[i - 1])
                        R = i - 1;
                    else
                        R = i;
                    depth = (points[P] - points[Q], points[R] - points[Q]).Item2 + 1;
                    P = i - 1;
                    Q = R = -1;
                }
                if (depth == 0)
                    depth = -1;
            }
            return depth;
        }
    }
}
