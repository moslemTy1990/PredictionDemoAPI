using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

public class UnknownMentalPredictionState: IPredictionState
{
    public string PredictLabel(int age)
    {
        if (age < 25)
        {
            return "3";
        }
        else if (age >= 25 && age <= 34)
        {
            return "4";
        }
        else if (age > 34 && age <= 44)
        {
            return "5";
        }
        else if (age >= 45 && age <= 60)
        {
            return "6";
        }
        else if (age > 60)
        {
            return "12";
        }
        return null;
    }
}