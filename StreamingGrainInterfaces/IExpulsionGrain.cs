﻿using DTOData;
using Orleans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingGrainInterfaces
{
    public interface IExpulsionGrain : IGrainWithStringKey
    {
        Task LinkToDigestion(Guid streamId);

        Task<List<Waste>> Dump();
    }



}
