//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityOperationsMgmtTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityOperationsMgmtType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityOperationsMgmtType"> List
         /// </summary>
        public static List<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypeList = new List<RefFacilityOperationsMgmtType>
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("5608e83d-a074-4542-a320-6ae3cd2afda7"), Code="02821", Description="District and private sector management", Definition="The school district supervises and employs district staff for cleaning, maintenance, and repair, but also contracts with a private sector company for support in the cleaning, maintenance, and repair of its schools and other facilities.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("7dd93a6c-74ce-487a-8660-a4d9f514a872"), Code="02822", Description="Nonschool public sector management", Definition="School district building cleaning, maintenance, and repair are the responsibility of a nonschool governmental agency or public authority.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("b89b9897-79a0-4f2d-839a-3f6917a10897"), Code="02820", Description="Private sector management", Definition="The school district contracts with a private sector company for the supervision and staffing for school-based cleaning, maintenance, and repair.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("a6c166d2-d7a9-44ba-800d-d9c04fa25587"), Code="02819", Description="School district management", Definition="The school district supervises and employs district staff in the schools and the central office for cleaning, maintenance, and repair.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("75228c39-e94f-4cc7-bd9a-bf322261c67a"), Code="09999", Description="Other", Definition="Other is specified as the type of management arrangements whereby a district oversees and manages its facilities operations.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityOperationsMgmtType Pick List
         /// </summary>
        public static List<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypePickList = new List<RefFacilityOperationsMgmtType>
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("5608e83d-a074-4542-a320-6ae3cd2afda7"), Code="02821", Description="District and private sector management", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("7dd93a6c-74ce-487a-8660-a4d9f514a872"), Code="02822", Description="Nonschool public sector management", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("b89b9897-79a0-4f2d-839a-3f6917a10897"), Code="02820", Description="Private sector management", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("a6c166d2-d7a9-44ba-800d-d9c04fa25587"), Code="02819", Description="School district management", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("75228c39-e94f-4cc7-bd9a-bf322261c67a"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
