//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSexList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSex Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSex"> List
         /// </summary>
        public static List<RefSex> RefSexList = new List<RefSex>
        {
            new RefSex { Id=Guid.Parse("205542c4-88f6-47ea-bf44-31a23deb51c7"), Code="Male", Description="Male", Definition="Male", SortOrder=Convert.ToDecimal("1.00") },
            new RefSex { Id=Guid.Parse("fb109723-73c0-4894-8c1a-d526b4ae98cb"), Code="Female", Description="Female", Definition="Female", SortOrder=Convert.ToDecimal("2.00") },
            new RefSex { Id=Guid.Parse("60015713-3dea-4dda-87b8-4a64df25b3a2"), Code="NotSelected", Description="Not selected", Definition="Gender is not selected", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefSex Pick List
         /// </summary>
        public static List<RefSex> RefSexPickList = new List<RefSex>
        {
            new RefSex { Id=Guid.Parse("205542c4-88f6-47ea-bf44-31a23deb51c7"), Code="Male", Description="Male", SortOrder=Convert.ToDecimal("1.00") },
            new RefSex { Id=Guid.Parse("fb109723-73c0-4894-8c1a-d526b4ae98cb"), Code="Female", Description="Female", SortOrder=Convert.ToDecimal("2.00") },
            new RefSex { Id=Guid.Parse("60015713-3dea-4dda-87b8-4a64df25b3a2"), Code="NotSelected", Description="Not selected", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
