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
                    return "Январь";
                break;
                case 2:
                    return "Март";
                break;
                case 3:
                    return "Март";
                break;
                case 4:
                    return "Апрель";
                break;
                case 5:
                    return "Май";
                break;
                case 6:
                    return "Июнь";
                break;
                case 7:
                    return "Июль";
                break;
                case 8:
                    return "Август";
                break;
                case 9:
                    return "Сентябрь";
                break;
                case 10:
                    return "Октябрь";
                break;
                case 11:
                    return "Ноябрь";
                break;
                case 12:
                    return "Декабрь";
                break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. значние {n}");
            }
        }
    }
}
