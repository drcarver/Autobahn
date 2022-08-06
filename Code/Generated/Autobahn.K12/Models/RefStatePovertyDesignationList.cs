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
        public static List<RefStatePovertyDesignation> RefStatePovertyDesignationList = new List<RefStatePovertyDesignation> =
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("2455951e-0331-4ae7-bbd9-b007bcf90ae9"), Code="The school is a high poverty quartile school according to state's indicator of poverty.", Description="HighQuartile", Definition="", SortOrder=0 },
            new RefStatePovertyDesignation { Id=Guid.Parse("2cbcc2a1-4511-4643-a329-673f51a6983d"), Code="The school is a low poverty quartile school according to state's indicator of poverty.", Description="LowQuartile", Definition="", SortOrder=0 },
            new RefStatePovertyDesignation { Id=Guid.Parse("ffc3740f-d4cb-4f4e-b66b-dcbb2470c0dd"), Code="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", Description="Neither", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefStatePovertyDesignation Pick List
         /// </summary>
        public static List<RefStatePovertyDesignation> RefStatePovertyDesignationPickList = new List<RefStatePovertyDesignation> =
        {
            new RefStatePovertyDesignation { Id=Guid.Parse("2455951e-0331-4ae7-bbd9-b007bcf90ae9"), Code="The school is a high poverty quartile school according to state's indicator of poverty.", SortOrder=0 },
            new RefStatePovertyDesignation { Id=Guid.Parse("2cbcc2a1-4511-4643-a329-673f51a6983d"), Code="The school is a low poverty quartile school according to state's indicator of poverty.", SortOrder=0 },
            new RefStatePovertyDesignation { Id=Guid.Parse("ffc3740f-d4cb-4f4e-b66b-dcbb2470c0dd"), Code="The school is neither high nor low poverty quartile school according to state's indicator of poverty.", SortOrder=0 },
       };
   }
}
