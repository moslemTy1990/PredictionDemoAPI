using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

public class UnknownPhysicalPredictionState: IPredictionState
{
    public string PredictLabel( int age)
    {
        if (age < 25)
        {
            return "1";
        }
        else if (age >= 25 && age <= 34)
        {
            return "2";
        }
        else if (age > 34 && age <= 60)
        {
            return "3";
        }
        else if (age > 60)
        {
            return "4";
        }
        return null;
    }
}