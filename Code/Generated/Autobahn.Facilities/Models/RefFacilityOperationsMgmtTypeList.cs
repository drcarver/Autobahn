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
        public static List<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypeList = new List<RefFacilityOperationsMgmtType> =
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("904373de-6984-4a10-bc37-9ee77faa5b62"), Code="The school district supervises and employs district staff for cleaning, maintenance, and repair, but also contracts with a private sector company for support in the cleaning, maintenance, and repair of its schools and other facilities.", Description="02821", Definition="", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("4da26903-8f5b-4382-b7a9-f7281d7848ef"), Code="School district building cleaning, maintenance, and repair are the responsibility of a nonschool governmental agency or public authority.", Description="02822", Definition="", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("7c64a47d-5ac2-4237-ba3f-635c0f1b40c9"), Code="The school district contracts with a private sector company for the supervision and staffing for school-based cleaning, maintenance, and repair.", Description="02820", Definition="", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("cc848c92-3b19-4594-9ddf-505817e88be5"), Code="The school district supervises and employs district staff in the schools and the central office for cleaning, maintenance, and repair.", Description="02819", Definition="", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("3db9fd4b-cb12-4091-9411-1ef5c545fd6f"), Code="Other is specified as the type of management arrangements whereby a district oversees and manages its facilities operations.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityOperationsMgmtType Pick List
         /// </summary>
        public static List<RefFacilityOperationsMgmtType> RefFacilityOperationsMgmtTypePickList = new List<RefFacilityOperationsMgmtType> =
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("904373de-6984-4a10-bc37-9ee77faa5b62"), Code="The school district supervises and employs district staff for cleaning, maintenance, and repair, but also contracts with a private sector company for support in the cleaning, maintenance, and repair of its schools and other facilities.", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("4da26903-8f5b-4382-b7a9-f7281d7848ef"), Code="School district building cleaning, maintenance, and repair are the responsibility of a nonschool governmental agency or public authority.", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("7c64a47d-5ac2-4237-ba3f-635c0f1b40c9"), Code="The school district contracts with a private sector company for the supervision and staffing for school-based cleaning, maintenance, and repair.", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("cc848c92-3b19-4594-9ddf-505817e88be5"), Code="The school district supervises and employs district staff in the schools and the central office for cleaning, maintenance, and repair.", SortOrder=0 },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("3db9fd4b-cb12-4091-9411-1ef5c545fd6f"), Code="Other is specified as the type of management arrangements whereby a district oversees and manages its facilities operations.", SortOrder=0 },
       };
   }
}
