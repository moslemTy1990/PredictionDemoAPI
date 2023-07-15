using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

/// <summary>
/// This class sets the state of the prediction given the right instance returned by factory and calls the predict label of the instance
/// </summary>
public class PredictionContext
{
    private IPredictionState _currentState;

    public PredictionContext(IPredictionState initialState)
    {
        _currentState = initialState;
    }

    public string PredictLabel(int age)
    {
        return _currentState.PredictLabel(age);
    }

    public void SetState(IPredictionState newState)
    {
        _currentState = newState;
    }
    
    public IPredictionState GetState()
    {
       return _currentState;
    }
}