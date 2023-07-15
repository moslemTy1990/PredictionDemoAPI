using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PredictionDemoAPI1.Logic;
using PredictionDemoAPI1.Models;

namespace PredictionDemoAPI1.Controllers;

/// <summary>
/// This controller is responsible for predicting the status of the patient and has only one POST predict method which receives the patient model from body
/// </summary>
[ApiController]
public class PatientStatusPredictionController : ControllerBase
{
    private readonly ILogger<PatientStatusPredictionController> _logger;
    private readonly PredictionContext _predictionContext;

    public PatientStatusPredictionController(ILogger<PatientStatusPredictionController> logger, PredictionContext predictionContext)
    {
        _logger = logger;
        _predictionContext = predictionContext;
    }

    /// <summary>
    /// Post method for predicting the status of the patient
    /// </summary>
    /// <param name="patient"></param>
    /// <returns>status</returns>
    [HttpPost]
    [Route("api/predictstatus")]
    public async Task<IActionResult> Predict([FromBody] Patient patient)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var predictionState = PredictionStateFactory.GetPredictionState(patient);
        
        if (predictionState==null)
            return BadRequest("Wow Bro! There is an error in your input.");
        
        _predictionContext.SetState(predictionState);

        // Perform label prediction using the current state
        string label = _predictionContext.PredictLabel(patient.Age);

        if (label == null)
        {
            return BadRequest("Wow Bro! Age is not in the range.");
        }
        
        return Ok(label);
    }
}