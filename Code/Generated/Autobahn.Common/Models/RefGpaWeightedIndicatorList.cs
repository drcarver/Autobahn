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
        public static List<RefGpaWeightedIndicator> RefGpaWeightedIndicatorList = new List<RefGpaWeightedIndicator> =
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("2d856421-e1d1-4ecb-9562-8a2039d4499f"), Code="The reported Grade Point Average is weighted.", Description="Weighted", Definition="", SortOrder=0 },
            new RefGpaWeightedIndicator { Id=Guid.Parse("8885e061-3af4-42bb-b1ee-d2167f376597"), Code="The reported Grade Point Average is unweighted.", Description="Unweighted", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefGpaWeightedIndicator Pick List
         /// </summary>
        public static List<RefGpaWeightedIndicator> RefGpaWeightedIndicatorPickList = new List<RefGpaWeightedIndicator> =
        {
            new RefGpaWeightedIndicator { Id=Guid.Parse("2d856421-e1d1-4ecb-9562-8a2039d4499f"), Code="The reported Grade Point Average is weighted.", SortOrder=0 },
            new RefGpaWeightedIndicator { Id=Guid.Parse("8885e061-3af4-42bb-b1ee-d2167f376597"), Code="The reported Grade Point Average is unweighted.", SortOrder=0 },
       };
   }
}
