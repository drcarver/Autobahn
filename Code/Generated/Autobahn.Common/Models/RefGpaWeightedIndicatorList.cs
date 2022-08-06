//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefGpaWeightedIndicatorList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefGpaWeightedIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGpaWeightedIndicator"> List
         /// </summary>
        public static List<RefGpaWeightedIndicator> RefGpaWeightedIndicatorList = new List<RefGpaWeightedIndicator>
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("13825181-3541-4c1b-af00-8f08cf76e81e"), Code="Weighted", Description="Weighted", Definition="The reported Grade Point Average is weighted.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGpaWeightedIndicator { Id=Guid.Parse("6ece3b73-80a3-4915-9916-0fbedd99c29b"), Code="Unweighted", Description="Unweighted", Definition="The reported Grade Point Average is unweighted.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The RefGpaWeightedIndicator Pick List
         /// </summary>
        public static List<RefGpaWeightedIndicator> RefGpaWeightedIndicatorPickList = new List<RefGpaWeightedIndicator>
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("13825181-3541-4c1b-af00-8f08cf76e81e"), Code="Weighted", Description="Weighted", SortOrder=Convert.ToDecimal("1.00") },
            new RefGpaWeightedIndicator { Id=Guid.Parse("6ece3b73-80a3-4915-9916-0fbedd99c29b"), Code="Unweighted", Description="Unweighted", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
