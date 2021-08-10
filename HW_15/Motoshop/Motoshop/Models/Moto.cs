using System;

namespace Motoshop.Models
{
    public class Moto
    {
        public Guid Id { get; set; }
        public int Odometer { get; set; }
        public string Model { get; set; }
        public string ImagePreview { get; set; }
    }
}
