using CAN_busz;
using System;

namespace VehicleSignal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CsvSignalParser parser = new CsvSignalParser("signals.txt");

                List<CAN_busz.VehicleSignal> signals = parser.GetSignals();

                Console.WriteLine($"===========================================");
                Console.WriteLine($"              CAN-BUS DIAGNOSIS            ");
                Console.WriteLine($"===========================================");
                Console.WriteLine($"        SCANNED CODE NUMBER: {signals.Count}   ");
                Console.WriteLine($"===========================================");

                foreach (var signal in signals)
                {
                    Console.WriteLine(signal.ToString());

                    if (signal.IsSafetyCritical && !signal.IsValueValid())
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("WARNING: Safety Critical Signal Out of Range!");
                        Console.ResetColor();
                    }
                }

                Console.WriteLine("Diagnosis finished. Push any button to quit...");
            }
            catch (FileNotFoundException)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Error: file not found!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Unexpected error: {ex.Message}");
                Console.ResetColor();
            }

            Console.ReadKey();
        }
    }
}
    
