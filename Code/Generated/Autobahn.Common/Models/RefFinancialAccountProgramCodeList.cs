//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountProgramCodeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountProgramCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountProgramCodeModel"> List
         /// </summary>
        public static List<RefFinancialAccountProgramCodeModel> RefFinancialAccountProgramCodeList = new List<RefFinancialAccountProgramCodeModel>
        {
            new RefFinancialAccountProgramCode { Id=Guid.Parse("e0622587-8ae2-4bf0-881d-c6e42b482cfe"), Code="100", Description="Regular Elementary/Secondary Education Programs", Definition="Regular Elementary/Secondary Education Programs the program category used for financial accounting.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("23dfcb85-34f2-4926-9f9e-1143f2aac3b4"), Code="200", Description="Special Programs", Definition="Special Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("36e7c199-9502-4886-8a2b-4b0253d3b94f"), Code="300", Description="Vocational and Technical Programs", Definition="Vocational and Technical Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("a957e6c8-78da-48f6-a6c6-ca52f24acdf3"), Code="400", Description="Other Instructional Programs-Elementary/Secondary", Definition="Other Instructional Programs-Elementary/Secondary is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("c8363b93-d4ff-4cb8-9c80-ba030f06753e"), Code="500", Description="Nonpublic School Programs", Definition="Nonpublic School Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("98eb551b-9ce3-43b9-904d-0ee4d119a2b0"), Code="600", Description="Adult/Continuing Education Programs", Definition="Adult/Continuing Education Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("5c73c28e-40e0-431e-9508-d43ce5507f2d"), Code="700", Description="Community/Junior College Education Programs", Definition="Community/Junior College Education Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("1f40c341-cdd1-4d45-a173-852687af838c"), Code="800", Description="Community Services Programs", Definition="Community Services Programs financial accounts.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("2f711cdd-1cef-4976-a0bc-a575b18cf70b"), Code="900", Description="Cocurricular and Extracurricular Activities", Definition="Cocurricular and Extracurricular Activities is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefFinancialAccountProgramCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFinancialAccountProgramCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFinancialAccountProgramCode { Id=Guid.Parse("e0622587-8ae2-4bf0-881d-c6e42b482cfe"), Description="Regular Elementary/Secondary Education Programs", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("23dfcb85-34f2-4926-9f9e-1143f2aac3b4"), Description="Special Programs", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("36e7c199-9502-4886-8a2b-4b0253d3b94f"), Description="Vocational and Technical Programs", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("a957e6c8-78da-48f6-a6c6-ca52f24acdf3"), Description="Other Instructional Programs-Elementary/Secondary", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("c8363b93-d4ff-4cb8-9c80-ba030f06753e"), Description="Nonpublic School Programs", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("98eb551b-9ce3-43b9-904d-0ee4d119a2b0"), Description="Adult/Continuing Education Programs", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("5c73c28e-40e0-431e-9508-d43ce5507f2d"), Description="Community/Junior College Education Programs", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("1f40c341-cdd1-4d45-a173-852687af838c"), Description="Community Services Programs", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("2f711cdd-1cef-4976-a0bc-a575b18cf70b"), Description="Cocurricular and Extracurricular Activities", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
