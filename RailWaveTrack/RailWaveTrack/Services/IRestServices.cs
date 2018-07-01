using RailWaveTrack.Modal;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace RailWaveTrack.Services
{
    public interface IRestServices
    {
        Task<PNRRootobject> RefreshDataAsync(string pnrNumber);
    }
}
