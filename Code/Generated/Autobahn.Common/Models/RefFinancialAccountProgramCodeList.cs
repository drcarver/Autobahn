//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFinancialAccountProgramCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFinancialAccountProgramCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFinancialAccountProgramCode"> List
         /// </summary>
        public static List<RefFinancialAccountProgramCode> RefFinancialAccountProgramCodeList = new List<RefFinancialAccountProgramCode>
        {
            new RefFinancialAccountProgramCode { Id=Guid.Parse("4ab4744f-0d24-4d4a-ba81-70b5bac477ed"), Code="100", Description="Regular Elementary/Secondary Education Programs", Definition="Regular Elementary/Secondary Education Programs the program category used for financial accounting.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("df3de5f5-3142-45b7-8375-d14a9d233756"), Code="200", Description="Special Programs", Definition="Special Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("f9c9a15b-0b4b-4aec-88ab-49f06905948c"), Code="300", Description="Vocational and Technical Programs", Definition="Vocational and Technical Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("5669a536-4c90-4671-b1a8-dbe057670a09"), Code="400", Description="Other Instructional Programs-Elementary/Secondary", Definition="Other Instructional Programs-Elementary/Secondary is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("61a42a0c-2887-4019-8cde-3f1b2a925abe"), Code="500", Description="Nonpublic School Programs", Definition="Nonpublic School Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("1d3a52a3-c252-4613-b92e-63987724be59"), Code="600", Description="Adult/Continuing Education Programs", Definition="Adult/Continuing Education Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("c988b7c8-5f3a-46b1-a50e-2b867a2d4559"), Code="700", Description="Community/Junior College Education Programs", Definition="Community/Junior College Education Programs is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("cfbd79c5-0678-4d0a-8b2a-84cacd351ecd"), Code="800", Description="Community Services Programs", Definition="Community Services Programs financial accounts.", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("89b1e105-71dc-4ff5-be44-d2e0d2c2bd3d"), Code="900", Description="Cocurricular and Extracurricular Activities", Definition="Cocurricular and Extracurricular Activities is the program category used for financial accounting.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefFinancialAccountProgramCode Pick List
         /// </summary>
        public static List<RefFinancialAccountProgramCode> RefFinancialAccountProgramCodePickList = new List<RefFinancialAccountProgramCode>
        {
            new RefFinancialAccountProgramCode { Id=Guid.Parse("4ab4744f-0d24-4d4a-ba81-70b5bac477ed"), Code="100", Description="Regular Elementary/Secondary Education Programs", SortOrder=Convert.ToDecimal("1.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("df3de5f5-3142-45b7-8375-d14a9d233756"), Code="200", Description="Special Programs", SortOrder=Convert.ToDecimal("2.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("f9c9a15b-0b4b-4aec-88ab-49f06905948c"), Code="300", Description="Vocational and Technical Programs", SortOrder=Convert.ToDecimal("3.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("5669a536-4c90-4671-b1a8-dbe057670a09"), Code="400", Description="Other Instructional Programs-Elementary/Secondary", SortOrder=Convert.ToDecimal("4.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("61a42a0c-2887-4019-8cde-3f1b2a925abe"), Code="500", Description="Nonpublic School Programs", SortOrder=Convert.ToDecimal("5.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("1d3a52a3-c252-4613-b92e-63987724be59"), Code="600", Description="Adult/Continuing Education Programs", SortOrder=Convert.ToDecimal("6.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("c988b7c8-5f3a-46b1-a50e-2b867a2d4559"), Code="700", Description="Community/Junior College Education Programs", SortOrder=Convert.ToDecimal("7.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("cfbd79c5-0678-4d0a-8b2a-84cacd351ecd"), Code="800", Description="Community Services Programs", SortOrder=Convert.ToDecimal("8.00") },
            new RefFinancialAccountProgramCode { Id=Guid.Parse("89b1e105-71dc-4ff5-be44-d2e0d2c2bd3d"), Code="900", Description="Cocurricular and Extracurricular Activities", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
