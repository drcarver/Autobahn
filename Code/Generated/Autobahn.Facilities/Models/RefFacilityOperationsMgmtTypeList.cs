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
        /// The complete <see cref="RefFacilityOperationsMgmtTypeModel"> List
         /// </summary>
        public static List<RefFacilityOperationsMgmtTypeModel> RefFacilityOperationsMgmtTypeList = new List<RefFacilityOperationsMgmtTypeModel>
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("893388de-ce02-470d-9459-e30e8c555532"), Code="02821", Description="District and private sector management", Definition="The school district supervises and employs district staff for cleaning, maintenance, and repair, but also contracts with a private sector company for support in the cleaning, maintenance, and repair of its schools and other facilities.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("bfeb2817-29c8-4128-a7f0-a937cc642559"), Code="02822", Description="Nonschool public sector management", Definition="School district building cleaning, maintenance, and repair are the responsibility of a nonschool governmental agency or public authority.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("538f4b00-ae9e-4bfd-bffe-bed8a75b896e"), Code="02820", Description="Private sector management", Definition="The school district contracts with a private sector company for the supervision and staffing for school-based cleaning, maintenance, and repair.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("3e9f2acb-8afd-41f5-baa0-8c567b1a3542"), Code="02819", Description="School district management", Definition="The school district supervises and employs district staff in the schools and the central office for cleaning, maintenance, and repair.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("49ec9893-e3e3-4a02-883a-baea61cc9010"), Code="09999", Description="Other", Definition="Other is specified as the type of management arrangements whereby a district oversees and manages its facilities operations.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityOperationsMgmtType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityOperationsMgmtTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("893388de-ce02-470d-9459-e30e8c555532"), Description="District and private sector management", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("bfeb2817-29c8-4128-a7f0-a937cc642559"), Description="Nonschool public sector management", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("538f4b00-ae9e-4bfd-bffe-bed8a75b896e"), Description="Private sector management", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("3e9f2acb-8afd-41f5-baa0-8c567b1a3542"), Description="School district management", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityOperationsMgmtType { Id=Guid.Parse("49ec9893-e3e3-4a02-883a-baea61cc9010"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
