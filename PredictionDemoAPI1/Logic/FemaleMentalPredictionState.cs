using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

/// <summary>
/// State class for female gender who suffers from mental sickness
/// </summary>
public class FemaleMentalPredictionState: IPredictionState
{
    /// <summary>
    /// given the age, checks the label category
    /// </summary>
    /// <param name="age"></param>
    /// <returns>label string</returns>
    public string PredictLabel(int age)
    {
        if (age < 25)
        {
            return "4";
        }
        else if (age >= 25 && age <= 34)
        {
            return "6";
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
            return "12";
        }
        return null;
    }
}