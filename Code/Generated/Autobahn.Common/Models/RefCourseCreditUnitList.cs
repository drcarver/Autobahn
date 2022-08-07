//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseCreditUnitList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseCreditUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseCreditUnitModel"> List
         /// </summary>
        public static List<RefCourseCreditUnitModel> RefCourseCreditUnitList = new List<RefCourseCreditUnitModel>
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d462c718-1c4a-459f-9c81-7bc25b19c206"), Code="NoCredit", Description="No Credit", Definition="No Credit is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("3f5038f6-c456-4996-ad19-1523e80ebd3c"), Code="Quarter", Description="Quarter ", Definition="Quarter is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("d972c627-610e-42c5-95d6-c9ccaf408059"), Code="Semester", Description="Semester ", Definition="Semester is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("7da8b942-a4a4-4edb-98b9-ed23eee2e216"), Code="Units", Description="Units ", Definition="Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("9aa2c6a3-409d-4cb7-bfb3-1d4a40adce60"), Code="CarnegieUnits", Description="Carnegie Units ", Definition="Carnegie Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("d47e8255-29d7-48c4-805f-6519061cf609"), Code="ContinuingEducationUnits", Description="Continuing Education Units ", Definition="Continuing Education Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("eb610c7e-f697-4252-82ed-81861551489a"), Code="ClockHours", Description="Clock Hours ", Definition="Clock Hours is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("58c93cbf-ad7f-48b6-afbc-a220b91bdac6"), Code="Other", Description="Other", Definition="Other is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("c2d345ba-b53b-4c8c-a426-5aeec060ff4a"), Code="Unreported", Description="Unreported", Definition="Unreported is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefCourseCreditUnit Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseCreditUnitViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d462c718-1c4a-459f-9c81-7bc25b19c206"), Description="No Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("3f5038f6-c456-4996-ad19-1523e80ebd3c"), Description="Quarter ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("d972c627-610e-42c5-95d6-c9ccaf408059"), Description="Semester ", SortOrder=Convert.ToDecimal("3.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("7da8b942-a4a4-4edb-98b9-ed23eee2e216"), Description="Units ", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("9aa2c6a3-409d-4cb7-bfb3-1d4a40adce60"), Description="Carnegie Units ", SortOrder=Convert.ToDecimal("5.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("d47e8255-29d7-48c4-805f-6519061cf609"), Description="Continuing Education Units ", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("eb610c7e-f697-4252-82ed-81861551489a"), Description="Clock Hours ", SortOrder=Convert.ToDecimal("7.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("58c93cbf-ad7f-48b6-afbc-a220b91bdac6"), Description="Other", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditUnit { Id=Guid.Parse("c2d345ba-b53b-4c8c-a426-5aeec060ff4a"), Description="Unreported", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
