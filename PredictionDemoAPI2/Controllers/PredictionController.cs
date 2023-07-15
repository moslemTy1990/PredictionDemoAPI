using Microsoft.AspNetCore.Mvc;
using PredictionDemoAPI2.Models;

namespace PredictionDemoAPI2.Controllers
{
    /// <summary>
    /// This controller is responsible for predicting the status of the patient with ML model and has only one POST predict method which receives the patient model from body
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PredictionController : ControllerBase
    {
        private readonly ILogger<PredictionController> _logger;

        public PredictionController(ILogger<PredictionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Post method for predicting the status of the patient
        /// </summary>
        /// <param name="patient"></param>
        /// <returns>status</returns>
        [HttpPost(Name = "api/predictstatus")]
        public async Task<IActionResult> Predict([FromBody] Patient patient)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            MLModel.ModelInput sampleData = new MLModel.ModelInput()
            {
                Gender = patient.Gender.ToLower(),
                SicknessType = patient.SicknessType.ToLower(),
                Age = (float)patient.Age,
            };

            var scoresWithLabel = MLModel.PredictAllLabels(sampleData);

            return Ok(scoresWithLabel.First());
        }
    }
}