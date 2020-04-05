﻿using System;
using System.Collections.Generic;
using CovidTracer.Models;

namespace CovidTracer.Services
{
    public interface IBLEServer
    {
        /** Creates a new BLE  service that advertize the provided read-only
         * characteristics.
         */
        void AddReadOnlyService(
            Guid serviceName, Dictionary<Guid, byte[]> characteristics);
    }
}