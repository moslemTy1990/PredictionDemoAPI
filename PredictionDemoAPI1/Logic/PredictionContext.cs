using PredictionDemoAPI1.Interfaces;

namespace PredictionDemoAPI1.Logic;

public class PredictionContext
{
    private IPredictionState currentState;

    public PredictionContext(IPredictionState initialState)
    {
        currentState = initialState;
    }

    public string PredictLabel(int age)
    {
        return currentState.PredictLabel(age);
    }

    public void SetState(IPredictionState newState)
    {
        currentState = newState;
    }
    
    public IPredictionState GetState()
    {
       return currentState;
    }
}