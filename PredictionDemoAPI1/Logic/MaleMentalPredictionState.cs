
using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;
public class MaleMentalPredictionState: IPredictionState
{
    public string PredictLabel(int age)
    {
        if (age < 25)
        {
            return "5";
        }
        else if (age >= 25 && age <= 34)
        {
            return "7";
        }
        else if (age > 34 && age <= 44)
        {
            return "8";
        }
        else if (age >= 45 && age <= 60)
        {
            return "10";
        }
        else if (age > 60)
        {
            return "11";
        }
        return null;
    }
}