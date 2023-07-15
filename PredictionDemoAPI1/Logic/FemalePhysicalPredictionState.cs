using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

public class FemalePhysicalPredictionState: IPredictionState
{
    public string PredictLabel(int age)
    {
        if (age < 25)
        {
            return "1";
        }
        else if (age >= 25 && age <= 44)
        {
            return "2";
        }
        else if (age >= 45 )
        {
            return "3";
        }
        return null;
    }
}