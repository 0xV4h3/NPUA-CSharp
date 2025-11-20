using System;

namespace Laborator13
{
    public sealed class TempEventArgs : EventArgs
    {
        public double Current { get; }
        public double Threshold { get; }
        public DateTime Timestamp { get; }

        public TempEventArgs(double current, double threshold)
        {
            Current = current;
            Threshold = threshold;
            Timestamp = DateTime.UtcNow;
        }
    }
}