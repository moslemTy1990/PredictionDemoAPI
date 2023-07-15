using Microsoft.AspNetCore.Mvc;
using PredictionDemoAPI1.Logic;
using PredictionDemoAPI1.Models;

namespace PredictionDemoAPI1.Controllers;

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