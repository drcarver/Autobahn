//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingJointUseRationaleTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingJointUseRationaleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingJointUseRationaleType"> List
         /// </summary>
        public static List<RefBuildingJointUseRationaleType> RefBuildingJointUseRationaleTypeList = new List<RefBuildingJointUseRationaleType>
        {
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("3ec3e841-fda2-4e8a-b400-de03c6f45302"), Code="13710", Description="Increase programs and services for students", Definition="Increase programs and services for students is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("8f9c29f5-bf0b-4c9a-a055-d841eb2e5293"), Code="13711", Description="Increase programs and services for the community", Definition="Increase programs and services for the community is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("08689566-8332-4fff-92bd-d19e297bf76f"), Code="13712", Description="Increase utilization of under used space", Definition="Increase utilization of under used space is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("797482c3-9837-4070-887f-b2bebbda6a37"), Code="13709", Description="Raise revenue", Definition="Raise revenue is specified as the reasons for permitting and participating in joint-use.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefBuildingJointUseRationaleType Pick List
         /// </summary>
        public static List<RefBuildingJointUseRationaleType> RefBuildingJointUseRationaleTypePickList = new List<RefBuildingJointUseRationaleType>
        {
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("3ec3e841-fda2-4e8a-b400-de03c6f45302"), Code="13710", Description="Increase programs and services for students", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("8f9c29f5-bf0b-4c9a-a055-d841eb2e5293"), Code="13711", Description="Increase programs and services for the community", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("08689566-8332-4fff-92bd-d19e297bf76f"), Code="13712", Description="Increase utilization of under used space", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingJointUseRationaleType { Id=Guid.Parse("797482c3-9837-4070-887f-b2bebbda6a37"), Code="13709", Description="Raise revenue", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
