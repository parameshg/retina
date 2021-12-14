using Retina.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retina.Services
{
    public class Endpoint : IApi<Scan>
    {
        public async Task<bool> Send(Scan scan)
        {
            return await Task.FromResult(true);
        }
    }
}