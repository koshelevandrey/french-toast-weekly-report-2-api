﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.Domain.Entities.Interfaces
{
    public interface ITeamLink
    {
        public int ReportingTMId { get; set; }
        public int LeaderTMId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int Id { get; set; }
    }
}
