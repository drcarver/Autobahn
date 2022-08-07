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
        /// The complete <see cref="RefFacilityCapitalProgramMgmtTypeModel"> List
         /// </summary>
        public static List<RefFacilityCapitalProgramMgmtTypeModel> RefFacilityCapitalProgramMgmtTypeList = new List<RefFacilityCapitalProgramMgmtTypeModel>
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("fa13ca89-197b-4f9d-931d-b75d456d7987"), Code="02913", Description="District management", Definition="The school district procures and oversees the design and construction services for its capital projects.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("86e7cb18-b01f-48ea-969e-1255676d37a2"), Code="02824", Description="Nonschool public agency management", Definition="A nonschool governmental agency procures and oversees the design and construction of the school district's capital projects. May be a municipal clerk of the works, separate building authority, or even the Army Corps of Engineers.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("a99bb240-efb5-4957-82df-329f965889ca"), Code="02823", Description="Private management", Definition="The school district contracts with private program managers who procure and oversee the design and construction of its capital projects.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("f2441eed-22d4-41f7-8680-dbb621475274"), Code="09999", Description="Other", Definition="Other is specified as the type of management organization for planning, design, and construction of major capital projects.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityCapitalProgramMgmtType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityCapitalProgramMgmtTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("fa13ca89-197b-4f9d-931d-b75d456d7987"), Description="District management", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("86e7cb18-b01f-48ea-969e-1255676d37a2"), Description="Nonschool public agency management", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("a99bb240-efb5-4957-82df-329f965889ca"), Description="Private management", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityCapitalProgramMgmtType { Id=Guid.Parse("f2441eed-22d4-41f7-8680-dbb621475274"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
