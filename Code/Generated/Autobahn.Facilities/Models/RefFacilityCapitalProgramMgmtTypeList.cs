//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityCapitalProgramMgmtTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityCapitalProgramMgmtType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityCapitalProgramMgmtType"> List
         /// </summary>
        public static List<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypeList = new List<RefFacilityCapitalProgramMgmtType> =
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("072b092e-0e4e-4e35-80c4-4629acc9ded6"), Code="The school district procures and oversees the design and construction services for its capital projects.", Description="02913", Definition="", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("2731c0ff-df8a-4d77-a239-c2f1ca140861"), Code="A nonschool governmental agency procures and oversees the design and construction of the school district's capital projects. May be a municipal clerk of the works, separate building authority, or even the Army Corps of Engineers.", Description="02824", Definition="", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("0a45f40b-2ab4-48fb-9bbd-a373e1dd985d"), Code="The school district contracts with private program managers who procure and oversee the design and construction of its capital projects.", Description="02823", Definition="", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("22ae7096-6aa6-4aaa-aa38-7cc0246be1f5"), Code="Other is specified as the type of management organization for planning, design, and construction of major capital projects.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilityCapitalProgramMgmtType Pick List
         /// </summary>
        public static List<RefFacilityCapitalProgramMgmtType> RefFacilityCapitalProgramMgmtTypePickList = new List<RefFacilityCapitalProgramMgmtType> =
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("072b092e-0e4e-4e35-80c4-4629acc9ded6"), Code="The school district procures and oversees the design and construction services for its capital projects.", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("2731c0ff-df8a-4d77-a239-c2f1ca140861"), Code="A nonschool governmental agency procures and oversees the design and construction of the school district's capital projects. May be a municipal clerk of the works, separate building authority, or even the Army Corps of Engineers.", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("0a45f40b-2ab4-48fb-9bbd-a373e1dd985d"), Code="The school district contracts with private program managers who procure and oversee the design and construction of its capital projects.", SortOrder=0 },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("22ae7096-6aa6-4aaa-aa38-7cc0246be1f5"), Code="Other is specified as the type of management organization for planning, design, and construction of major capital projects.", SortOrder=0 },
       };
   }
}
