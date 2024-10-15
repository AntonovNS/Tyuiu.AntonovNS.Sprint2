using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AntonovNS.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            switch (n)
            {
                case 1:
                    return "январь";
                break;
                case 2:
                    return "март";
                break;
                case 3:
                    return "март";
                break;
                case 4:
                    return "апрель";
                break;
                case 5:
                    return "май";
                break;
                case 6:
                    return "июнь";
                break;
                case 7:
                    return "июль";
                break;
                case 8:
                    return "август";
                break;
                case 9:
                    return "сентябрь";
                break;
                case 10:
                    return "октябрь";
                break;
                case 11:
                    return "ноябрь";
                break;
                case 12:
                    return "декабрь";
                break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. значние {n}");
            }
        }
    }
}
