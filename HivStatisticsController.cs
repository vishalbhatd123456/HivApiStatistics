using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HivAPIStatistics
{
    public class HivStatisticsController : ControllerBase
    {
	    private readonly IHivStatisticsService _hivStatisticsService;

	    public HivStatisticsController(IHivStatisticsService hivStatisticsService)
	    {
		    _hivStatisticsService = hivStatisticsService;
	    }

	    [HttpGet("{date")]
	    public async Task<IActionResult> Get(DateTime date)
	    {
		    var result = await _hivStatisticsService.GetHivStatisticAsync(date);

		    if (result == null)
		    {
			    return NotFound();
		    }

		    return Ok(result);
	    }
    }
}
