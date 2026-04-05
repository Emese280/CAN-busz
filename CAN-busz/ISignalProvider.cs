using System;
using System.Collections.Generic;
using System.Text;

namespace CAN_busz
{
    internal interface ISignalProvider
    {
    List<VehicleSignal> GetSignals();
    }
}
