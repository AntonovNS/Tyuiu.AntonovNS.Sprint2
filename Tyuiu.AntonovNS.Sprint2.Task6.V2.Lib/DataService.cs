using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.AntonovNS.Sprint2.Task6.V2.Lib
{
    public class DataService : ISprint2Task6V2
    {
        public string FindMonthSeason(int value)
        {
            switch (value)
            {
                case 1:
                    return "зима";
                    break;
                case 2:
                    return "зима";
                    break;
                case 3:
                    return "весна";
                    break;
                case 4:
                    return "весна";
                    break;
                case 5:
                    return "весна";
                    break;
                case 6:
                    return "лето";
                    break;
                case 7:
                    return "лето";
                    break;
                case 8:
                    return "лето";
                    break;
                case 9:
                    return "осень";
                    break;
                case 10:
                    return "осень";
                    break;
                case 11:
                    return "осень";
                    break;
                case 12:
                    return "зима";
                    break;
                default:
                    throw new ArgumentException($"Месяц должен быть от 1 до 12. значние {value}");
            }
        }
    }
}
