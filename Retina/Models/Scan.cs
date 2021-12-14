using System;

namespace Retina.Models
{
    public class Scan
    {
        public DateTime Timestamp { get; set; }

        public string Text { get; set; }

        public string Format { get; set; }
    }
}