using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HivAPIStatistics
{
    public interface IHivStatisticsService
    {
	    Task<HivStatistic> GetHivStatisticAsync(DateTime date);
    }
}
