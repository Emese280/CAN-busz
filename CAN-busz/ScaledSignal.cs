using System;
using System.Collections.Generic;
using System.Text;

namespace CAN_busz
{
    internal class ScaledSignal : VehicleSignal
    {
        public double MinRange {  get; set; } 
        public double MaxRange { get; set; }

        public ScaledSignal(int signalId, DateTime timestamp, string signalName, string unit, double rawValue, bool isSafetyCritical, double minRange, double maxRange)
        :base(signalId,timestamp,signalName,unit,rawValue,isSafetyCritical){
         this.MinRange = minRange;
         this.MaxRange = maxRange;
        }

        //public abstract bool IsValueValid();
        public override bool IsValueValid()
        {
            if(RawValue >= MinRange && RawValue <= MaxRange){
            return true;
            }
            return false;
        }

        public override string ToString()
        {
            return base.ToString() + $"Range: {MinRange} - {MaxRange}; Status: {IsValueValid()}";
        }
    }
}
