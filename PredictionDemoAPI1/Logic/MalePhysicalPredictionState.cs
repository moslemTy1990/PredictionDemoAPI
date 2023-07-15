using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

/// <summary>
/// State class for male gender who suffers from Physical sickness
/// </summary>
public class MalePhysicalPredictionState: IPredictionState
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
            return "2";
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