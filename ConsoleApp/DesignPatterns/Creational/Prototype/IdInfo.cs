using System;

namespace ConsoleApp.DesignPatterns.Creational.Prototype
{
    public class IdInfo : ICloneable
    {
        public Guid IdNumber { get; set; }

        public IdInfo()
        {
            IdNumber = Guid.NewGuid();
        }

        public object Clone()
        {
            var clone = (IdInfo)MemberwiseClone();
            clone.IdNumber = Guid.Parse(IdNumber.ToString());
            return clone;
        }
    }
}