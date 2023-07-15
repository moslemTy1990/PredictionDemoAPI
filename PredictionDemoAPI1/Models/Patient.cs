using System.ComponentModel.DataAnnotations;

namespace PredictionDemoAPI1.Models;

/// <summary>
/// Patient model class with .NET Core validation to check the inputs and validates it
/// </summary>
public class Patient
{
    [Required(ErrorMessage = "Age must be provided")]
    [Range(14, 100, ErrorMessage = "Age must be more than 14 and less than 100")]
    public int Age { get; set; }
    
    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }
    
    [RegularExpression("^(Male|Female|male|female|Unknown|unknown)$", ErrorMessage = "Gender must be either 'Male' or 'Female' or 'Unknown'.")]
    public string Gender { get; set; }
    
    [RegularExpression("^(Mental|mental|Physical|physical)$", ErrorMessage = "Sickness type must be either 'Mental' or 'Physical' .")]
    public string SicknessType { get; set; }
}