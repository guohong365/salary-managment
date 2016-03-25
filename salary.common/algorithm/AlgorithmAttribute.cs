using System;

namespace salary.algorithm
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AlgorithmAttribute : Attribute
    {
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}