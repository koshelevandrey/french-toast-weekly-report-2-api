﻿using CM.WeeklyTeamReport.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CM.WeeklyTeamReport.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CompaniesController : RESTController<Company>
    {
        public override string EntitiesEndpoint => "/api/Companies";
        public CompaniesController(IRepository<Company> repository) : base(repository) { }
    }
}