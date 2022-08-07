//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIndividualizedProgramDateTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIndividualizedProgramDateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIndividualizedProgramDateTypeModel"> List
         /// </summary>
        public static List<RefIndividualizedProgramDateTypeModel> RefIndividualizedProgramDateTypeList = new List<RefIndividualizedProgramDateTypeModel>
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("c69ea0d6-b94b-4162-b65e-44f403ee2022"), Code="Development", Description="Development date", Definition="The related Individualized Program Date is a development date.", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ff2fbc73-37c9-4b10-bad1-fce7949bbb2f"), Code="Implementation", Description="Implementation date", Definition="The related Individualized Program Date is an implementation date.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ff3d17f9-c721-4304-8495-a6aec5b80e6d"), Code="TentativeRevision", Description="Tentative revision date", Definition="The related Individualized Program Date is a tentative revision date.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("85b31b70-956a-4943-bbae-26b3c560358c"), Code="Revision", Description="Revision date", Definition="The related Individualized Program Date is an revision date.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("0929705f-2b20-44e1-ba63-5ecddbacd43e"), Code="Other", Description="Other", Definition="The related Individualized Program Date is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefIndividualizedProgramDateType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIndividualizedProgramDateTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIndividualizedProgramDateType { Id=Guid.Parse("c69ea0d6-b94b-4162-b65e-44f403ee2022"), Description="Development date", SortOrder=Convert.ToDecimal("0.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ff2fbc73-37c9-4b10-bad1-fce7949bbb2f"), Description="Implementation date", SortOrder=Convert.ToDecimal("2.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("ff3d17f9-c721-4304-8495-a6aec5b80e6d"), Description="Tentative revision date", SortOrder=Convert.ToDecimal("4.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("85b31b70-956a-4943-bbae-26b3c560358c"), Description="Revision date", SortOrder=Convert.ToDecimal("6.00") },
            new RefIndividualizedProgramDateType { Id=Guid.Parse("0929705f-2b20-44e1-ba63-5ecddbacd43e"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
