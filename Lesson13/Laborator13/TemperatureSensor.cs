using System;

namespace Laborator13
{
    public class TemperatureSensor
    {
        private double _current;

        public double Current
        {
            get => _current;
            private set => _current = value;
        }

        public double Threshold { get; }

        public event EventHandler<TempEventArgs>? Overheated;

        public TemperatureSensor(double threshold) => Threshold = threshold;

        public void Increase(double delta)
        {
            Current += delta;
            Console.WriteLine($"Sensor: Current = {Current:0.00} (threshold {Threshold:0.00})");
            if (Current > Threshold)
            {
                Overheated?.Invoke(this, new TempEventArgs(Current, Threshold));
            }
        }
    }

    public static class TemperatureSensorDemo
    {
        public static void Run()
        {
            var sensor = new TemperatureSensor(threshold: 75.0);

            sensor.Overheated += (s, e) =>
                Console.WriteLine($"[Console Handler] Overheated! {e.Current:0.00} at {e.Timestamp:O}");

            sensor.Overheated += (s, e) =>
                System.IO.File.AppendAllText("temperature_events.txt",
                    $"[File Handler] {e.Current:0.00} > {e.Threshold:0.00} at {e.Timestamp:O}{Environment.NewLine}");

            sensor.Increase(10);
            sensor.Increase(30);
            sensor.Increase(40);
        }
    }
}