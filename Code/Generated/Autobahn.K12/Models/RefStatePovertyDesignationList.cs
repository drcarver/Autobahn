//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefStatePovertyDesignationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefStatePovertyDesignation Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStatePovertyDesignation"> List
         /// </summary>
        public static List<RefStatePovertyDesignation> RefStatePovertyDesignationList = new List<RefStatePovertyDesignation>
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("4b9e740e-484f-402f-81ab-1f6e1d00f74c"), Code="HighQuartile", Description=" High poverty quartile school", Definition="The school is a high poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("1.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("989e6463-c126-4527-bbb5-17c9f45cc9e5"), Code="LowQuartile", Description="Low poverty quartile school", Definition="The school is a low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("2.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("da6bacf2-0a06-480d-b99b-dc06697ca782"), Code="Neither", Description="Neither high nor low poverty quartile school", Definition="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefStatePovertyDesignation Pick List
         /// </summary>
        public static List<RefStatePovertyDesignation> RefStatePovertyDesignationPickList = new List<RefStatePovertyDesignation>
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("4b9e740e-484f-402f-81ab-1f6e1d00f74c"), Code="HighQuartile", Description=" High poverty quartile school", SortOrder=Convert.ToDecimal("1.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("989e6463-c126-4527-bbb5-17c9f45cc9e5"), Code="LowQuartile", Description="Low poverty quartile school", SortOrder=Convert.ToDecimal("2.00") },
            new RefStatePovertyDesignation { Id=Guid.Parse("da6bacf2-0a06-480d-b99b-dc06697ca782"), Code="Neither", Description="Neither high nor low poverty quartile school", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
