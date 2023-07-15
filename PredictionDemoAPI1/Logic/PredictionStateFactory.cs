using System;
using PredictionDemoAPI1.Interfaces;
using PredictionDemoAPI1.Models;

namespace PredictionDemoAPI1.Logic;

/// <summary>
/// Static class which instantiates and returns the Prediction states classes, simplified Factory method :) 
/// </summary>
public static class PredictionStateFactory 
{
    /// <summary>
    /// Given the patient as input, returns the corresponding Prediction class instance 
    /// </summary>
    /// <param name="patient">Patient</param>
    /// <returns>IPredictionState, or null</returns>
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