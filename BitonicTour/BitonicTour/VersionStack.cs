using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitonicTour
{
    class VersionStack
    {
        public int firstPoint;
        public int secondPoint;
        public int prev;

        public VersionStack(int firstPoint, int secondPoint, int prev)
        {
            this.firstPoint = firstPoint;
            this.secondPoint = secondPoint;
            this.prev = prev;
        }

        static public VersionStack Copy(VersionStack ver)
        {
            VersionStack copy = new VersionStack(ver.firstPoint, ver.secondPoint, ver.prev);
            return copy;
        }
    }
}
