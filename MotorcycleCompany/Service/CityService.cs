﻿using Contracts;
using Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal sealed class CityService : ICityService
    {
        private readonly IRepositoryManager repository;
        private readonly IloggerManager loggerManager;

        public CityService(IRepositoryManager repository, IloggerManager loggerManager)
        {
            this.repository = repository;
            this.loggerManager = loggerManager;
        }
    }
}
