using Microsoft.AspNetCore.Mvc;
using PredictionDemoAPI2.Models;

namespace PredictionDemoAPI2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PredictionController : ControllerBase
    {
        private readonly ILogger<PredictionController> _logger;

        public PredictionController(ILogger<PredictionController> logger)
        {
            _logger = logger;
        }

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