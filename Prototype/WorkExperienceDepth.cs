using System;

namespace Prototype
{
    public class WorkExperienceDepth : ICloneable
    {

        public string WorkDate { get; set; }

        public string Company { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
