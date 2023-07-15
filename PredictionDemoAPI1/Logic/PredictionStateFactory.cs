using PredictionDemoAPI1.Interfaces;
using PredictionDemoAPI1.Models;

namespace PredictionDemoAPI1.Logic;

public static class PredictionStateFactory 
{
    public static IPredictionState GetPredictionState(Patient patient)
    {
        if (patient.SicknessType.Equals("mental", StringComparison.OrdinalIgnoreCase))
        {
            if (patient.Gender.Equals("male", StringComparison.OrdinalIgnoreCase))
            {
                return new MaleMentalPredictionState();
            }
            else if (patient.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
            {
                return new FemaleMentalPredictionState();
            }
            else if (patient.Gender.Equals("unknown", StringComparison.OrdinalIgnoreCase))
            {
                return new UnknownMentalPredictionState();
            }
        }
        else if (patient.SicknessType.Equals("physical", StringComparison.OrdinalIgnoreCase))
        {
            if (patient.Gender.Equals("male", StringComparison.OrdinalIgnoreCase))
            {
                return new MalePhysicalPredictionState();
            }
            else if (patient.Gender.Equals("female", StringComparison.OrdinalIgnoreCase))
            {
               return new FemalePhysicalPredictionState();
            }
            else if (patient.Gender.Equals("unknown", StringComparison.OrdinalIgnoreCase))
            {
                return new  UnknownPhysicalPredictionState();
            }
        }
        return null;
    }
    
}