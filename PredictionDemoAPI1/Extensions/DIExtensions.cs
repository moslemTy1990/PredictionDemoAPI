using Microsoft.Extensions.DependencyInjection;
using PredictionDemoAPI1.Interfaces;
using PredictionDemoAPI1.Logic;

namespace PredictionDemoAPI1.Extensions;

/// <summary>
/// Extension for DI purpose
/// </summary>
public static class DiExtensions
{
    public static void AddDiExtensions(this IServiceCollection services)
        {
            services.AddScoped<IPredictionState, FemalePhysicalPredictionState>();
            services.AddScoped<IPredictionState, FemaleMentalPredictionState>();
            services.AddScoped<IPredictionState, MaleMentalPredictionState>();
            services.AddScoped<IPredictionState, MalePhysicalPredictionState>();
            services.AddScoped<IPredictionState, UnknownMentalPredictionState>();
            services.AddScoped<IPredictionState, UnknownPhysicalPredictionState>();

            // Register the PredictionContext
            services.AddScoped<PredictionContext>();
        }
    }