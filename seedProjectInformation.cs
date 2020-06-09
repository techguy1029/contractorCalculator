using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace contractorCalculator
{
    public class seedProjectInformation
    {
        public decimal rectangleWidth;
        public decimal rectangleLength;
        public decimal rectangleCoverageRate;
        public decimal circleRadius;
        public decimal circleCoverageRate;
        public decimal ellipsisAAxis;
        public decimal ellipsisBAxis;
        public decimal ellipsisCoverageRate;
        public decimal triangleHeight;
        public decimal triangleBase;
        public decimal triangleCoverageRate;
        public decimal seedNeeded;
        public string projectName;
        public decimal seedCost;
        public decimal seedTotalCost
        {
            get
            {
                return this.seedNeeded * this.seedCost;
            }
        }
    }
}
