using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contractorCalculator
{
    public class projectInformation
    {
        public decimal wallHeight { get; set; }

        public decimal wallLength { get; set; }

        public decimal blockLength { get; set; }

        public decimal blockHeight { get; set; }

        public decimal costOfCap { get; set; }

        public bool includeCaps { get; set; }

        public decimal capsNeeded
        {
            get
            {
                return this.numberOfColumns;
            }
        }

        public string projectName { get; set; }

        public decimal costOfBlock { get; set; }

        public decimal totalCost
        {
            get
            {
                if(this.includeCaps)
                {
                    return this.costOfAllBlocks + this.costOfAllCaps;
                }
                else
                {
                    return this.costOfAllBlocks;
                }
            }
        }

        public decimal costOfAllBlocks
        {
            get
            {
                return this.costOfBlock * this.blocksNeeded;
            }
        }

        public decimal costOfAllCaps
        {
            get
            {
                return this.costOfCap * this.capsNeeded;
            }
        }

        public decimal numberOfRows
        {
            get
            {
                return this.wallHeight / (this.blockHeight / 12);
            }
        }

        //https://stackoverflow.com/questions/2030636/c-sharp-read-only-calculated-properties-should-they-be-methods
        public decimal numberOfColumns
        {
            get
            {
                return this.wallLength / (this.blockLength / 12);
            }
        }

        public decimal blocksNeeded
        {
            get
            {
                return this.numberOfColumns * this.numberOfRows;
            }
        }

        public decimal blockNeededWithCaps
        {
            get
            {
                return this.numberOfColumns * (this.numberOfRows - 1);
            }
        }
    }
}
