using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

/// <summary>
/// State class for female gender who suffers from physical sickness
/// </summary>
public class FemalePhysicalPredictionState: IPredictionState
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