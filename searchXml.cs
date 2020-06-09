using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace contractorCalculator
{
    public static class searchXml
    {
        public static DataTable returnAllProjects()
        {
            var dataSet = new DataSet();
            string xmlPath = writeXmlData.returnXmlPath();
            dataSet.ReadXml(xmlPath);
            //https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable.merge?view=netcore-3.1
            for (var i = 0; i < (dataSet.Tables.Count); i++)
            {
                dataSet.Tables[0].Merge(dataSet.Tables[i], false, MissingSchemaAction.Add);
            }
            return dataSet.Tables[0];
        }

        public static DataTable returnSearchItem(string searchedItem)
        {
            var dataSet = new DataSet();
            string xmlPath = writeXmlData.returnXmlPath();
            dataSet.ReadXml(xmlPath);
            return dataSet.Tables[searchedItem];
        }

        public static DataTable returnSimilarSearchItem(string searchString)
        {
            var dataTables = returnAllProjects();
            DataTable dtSearchResult = dataTables.Select($"ProjectName Like '%{searchString}%'").CopyToDataTable();
            return dtSearchResult;
        }
    }
}
