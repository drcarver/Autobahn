//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefInstructionalStaffContractLengthList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefInstructionalStaffContractLength Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionalStaffContractLengthModel"> List
         /// </summary>
        public static List<RefInstructionalStaffContractLengthModel> RefInstructionalStaffContractLengthList = new List<RefInstructionalStaffContractLengthModel>
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("2524ec8e-4ec0-4733-89fb-19f01112284e"), Code="LessThan9-Month", Description="Less than 9-Month", Definition="The contracted teaching period for the faculty member is less than 9-Months.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("0ec24577-47d3-4c9a-bfd5-55fbd0fdc4d3"), Code="9-Month", Description="9-Month", Definition="The contracted teaching period for the faculty member 9-Months.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("e8df52da-5f29-4246-b75a-5e4bd9f874ea"), Code="10-Month", Description="10-Month", Definition="The contracted teaching period for the faculty member 10-Months.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("441196d3-b4eb-4c06-a62d-0d37426a5a0a"), Code="11-Month", Description="11-Month", Definition="The contracted teaching period for the faculty member 11-Months.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("05f464c0-8ba2-4419-96e3-38e32acf9551"), Code="12-Month", Description="12-Month", Definition="The contracted teaching period for the faculty member 12-Months.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefInstructionalStaffContractLength Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInstructionalStaffContractLengthViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInstructionalStaffContractLength { Id=Guid.Parse("2524ec8e-4ec0-4733-89fb-19f01112284e"), Description="Less than 9-Month", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("0ec24577-47d3-4c9a-bfd5-55fbd0fdc4d3"), Description="9-Month", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("e8df52da-5f29-4246-b75a-5e4bd9f874ea"), Description="10-Month", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("441196d3-b4eb-4c06-a62d-0d37426a5a0a"), Description="11-Month", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionalStaffContractLength { Id=Guid.Parse("05f464c0-8ba2-4419-96e3-38e32acf9551"), Description="12-Month", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
