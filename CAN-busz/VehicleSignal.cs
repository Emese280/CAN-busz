using System;
using System.Collections.Generic;
using System.Text;

namespace CAN_busz
{
    abstract class VehicleSignal
    {
        private int signalId;
        public DateTime timestamp;
        private string signalName, unit;
        public double rawValue;
        public bool isSafetyCritical;

        public int SignalId
        {
            get => signalId;
            set
            {
            if(value <= 0){
                    throw new Exception("The ID can't be 0 or lower!");
            }
            signalId = value;
            }
        }

        public DateTime TimeStamp { get; set; }
        

        public string SignalName{
            get => signalName;
            set{
            if(string.IsNullOrEmpty(value)){
                    throw new Exception("The name can't be empty");
            }
            signalName = value;
            }
        }

       

        public double RawValue { get; set; }

        public string Unit{
            get => unit;
            set{
            if(string.IsNullOrEmpty(value)){
                    throw new Exception("Unit can't be empty!");
            }
            unit = value;
            }
        }

        public bool IsSafetyCritical { get; set; }

        public VehicleSignal(int signalId, DateTime timestamp, string signalName, string unit, double rawValue, bool isSafetyCritical)
        {
            SignalId = signalId;
            TimeStamp = timestamp;
            SignalName = signalName;
            Unit = unit;
            RawValue = rawValue;
            IsSafetyCritical = isSafetyCritical;
        }

        public abstract bool IsValueValid();

        public override string ToString()
        {
            return $"Time: {TimeStamp}; Vehicle ID: {SignalId}; Name:{SignalName}: {RawValue} {Unit}";
        }
    }
}
