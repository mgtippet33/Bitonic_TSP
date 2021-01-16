using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitonicTour
{

    class PersistentStack
    {
        public List<VersionStack> versions;

        public PersistentStack()
        {
            this.versions = new List<VersionStack>();
            //versions.Add(new VersionStack(-1, -1, 0));
        }

        public void Push(int ver, int firstPoint, int secondPoint)
        {
            versions.Add(new VersionStack(firstPoint, secondPoint, ver));
        }

        public void Pop(int ver)
        {
            versions.RemoveAt(ver);
        }
    }
}