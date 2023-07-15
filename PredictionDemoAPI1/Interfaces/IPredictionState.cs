namespace PredictionDemoAPI1.Interfaces;

/// <summary>
/// State pattern interface for creating a state contract that has to be followed by all sub types
/// </summary>
public interface IPredictionState
{
    string PredictLabel(int age);
}