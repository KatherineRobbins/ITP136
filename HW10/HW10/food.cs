using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10
{
    internal class food
    {

        int fID;
        string fName;
        string fdescription;
        double fcost;

        public int FoodId
        {
            get { return fID; }
            set { fID = value; }
        }

        public string FoodName
        {
            get { return fName; }
            set { fName = value; }
        }

        public string FoodDescription
        {
            get { return fdescription; }
            set { fdescription = value; }

        }

        public double FoodCost
        {
            get { return fcost; }
            set { fcost = value; }
        }

    }
}
