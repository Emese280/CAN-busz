using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Globalization;

namespace CAN_busz
{
    internal class CsvSignalParser : ISignalProvider
    {
        private List<VehicleSignal> datas = new List<VehicleSignal>();

        public List<VehicleSignal> GetSignals() => datas;

        public CsvSignalParser(string fileName){
        foreach (var item in File.ReadAllLines(fileName).Skip(1)){
        var fields = item.Split(';');

                //int signalId, DateTime timestamp, string signalName, string unit, double rawValue, bool isSafetyCritical, double minRange, double maxRange

                int signalId = Convert.ToInt32(fields[0]);
                DateTime timeStamp = DateTime.Parse(fields[1]); // or Convert.ToDateTime(fields[1]
                string signalName = fields[2];
                double rawValue = Convert.ToDouble(fields[3], CultureInfo.InvariantCulture);
                string unit = fields[4];
                double minRange = Convert.ToDouble(fields[5], CultureInfo.InvariantCulture);
                double maxRange = Convert.ToDouble(fields[6], CultureInfo.InvariantCulture);
                bool isSafetyCritical = bool.Parse(fields[7].ToLower());

                datas.Add(new ScaledSignal(signalId, timeStamp, signalName, unit, rawValue, isSafetyCritical, minRange, maxRange));
        }
        }
    }
}
