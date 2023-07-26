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
        if (patient.SicknessType.Equals("mental"))
        {
            return patient.Gender switch
            {
                "male" => new MaleMentalPredictionState(),
                "female" => new FemaleMentalPredictionState(),
                _ => new UnknownMentalPredictionState()
            };

        }

        if (patient.SicknessType.Equals("physical"))
        {
            return patient.Gender switch
            {
                "male" => new MalePhysicalPredictionState(),
                "female" => new FemalePhysicalPredictionState(),
                _ => new UnknownPhysicalPredictionState()
            };
        }

        return null;
    }
}