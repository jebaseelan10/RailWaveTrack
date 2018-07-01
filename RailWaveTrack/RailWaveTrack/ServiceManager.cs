using RailWaveTrack.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RailWaveTrack.Services
{
    public class ServiceManager
    {
        IRestServices RestServices;
        public ServiceManager(IRestServices restServices)
        {
            RestServices = restServices;
        }

        public async Task<PNRRootobject> RefreshDataAsync(string pnrNumber)
        {
            return await RestServices.RefreshDataAsync(pnrNumber);
        }
    }
}
