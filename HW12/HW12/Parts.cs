using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12
{
    public class Parts
    {

        int partNum;
        string partName, partDescription;
        double partCost;

        public Parts(int pNum, string pName, string pDescription, double pCost)
        {
            partNum = pNum;
            partName = pName;
            partDescription = pDescription;
            partCost = pCost;
        }

        public int PartNumber
        {
            get { return partNum; }
            set { partNum = value; }
        }

        public string PartName
        {
            get { return partName;}
            set { partName = value; }
        }

        public string PartDescription
        {
            get { return partDescription;}
            set { partDescription = value; }
        }

        public double PartCost
        {
            get { return partCost;}
            set { partCost = value; }
        }
    }
}
