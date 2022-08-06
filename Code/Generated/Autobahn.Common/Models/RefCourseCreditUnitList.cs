//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCourseCreditUnitList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCourseCreditUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseCreditUnit"> List
         /// </summary>
        public static List<RefCourseCreditUnit> RefCourseCreditUnitList = new List<RefCourseCreditUnit> =
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d1d2f3b7-1f26-4b49-9bc1-127c7cb10a2e"), Code="No Credit is specified as the type of credit associated with the credit hours earned for the course.", Description="NoCredit", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("be1b1f79-081d-4837-b1c9-5187d5dbf0f8"), Code="Quarter is specified as the type of credit associated with the credit hours earned for the course.", Description="Quarter", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("056e05b8-2742-491a-b899-38b1c4fab729"), Code="Semester is specified as the type of credit associated with the credit hours earned for the course.", Description="Semester", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("f50e6feb-3217-4b5d-b1a4-68feb497a38e"), Code="Units is specified as the type of credit associated with the credit hours earned for the course.", Description="Units", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("55613389-3722-4b99-b931-2af4821e9361"), Code="Carnegie Units is specified as the type of credit associated with the credit hours earned for the course.", Description="CarnegieUnits", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("40e4eebc-3457-4bfd-acd6-14b98295d1f7"), Code="Continuing Education Units is specified as the type of credit associated with the credit hours earned for the course.", Description="ContinuingEducationUnits", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("1cb6c76f-ed28-40bf-b7f8-dab6a6ba159a"), Code="Clock Hours is specified as the type of credit associated with the credit hours earned for the course.", Description="ClockHours", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("02c5573e-6f46-4ada-bf16-156341554177"), Code="Other is specified as the type of credit associated with the credit hours earned for the course.", Description="Other", Definition="", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("725ac5bc-7e76-47e9-a6fc-cf59a0ef4e85"), Code="Unreported is specified as the type of credit associated with the credit hours earned for the course.", Description="Unreported", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCourseCreditUnit Pick List
         /// </summary>
        public static List<RefCourseCreditUnit> RefCourseCreditUnitPickList = new List<RefCourseCreditUnit> =
        {
            new RefCourseCreditUnit { Id=Guid.Parse("d1d2f3b7-1f26-4b49-9bc1-127c7cb10a2e"), Code="No Credit is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("be1b1f79-081d-4837-b1c9-5187d5dbf0f8"), Code="Quarter is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("056e05b8-2742-491a-b899-38b1c4fab729"), Code="Semester is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("f50e6feb-3217-4b5d-b1a4-68feb497a38e"), Code="Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("55613389-3722-4b99-b931-2af4821e9361"), Code="Carnegie Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("40e4eebc-3457-4bfd-acd6-14b98295d1f7"), Code="Continuing Education Units is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("1cb6c76f-ed28-40bf-b7f8-dab6a6ba159a"), Code="Clock Hours is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("02c5573e-6f46-4ada-bf16-156341554177"), Code="Other is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
            new RefCourseCreditUnit { Id=Guid.Parse("725ac5bc-7e76-47e9-a6fc-cf59a0ef4e85"), Code="Unreported is specified as the type of credit associated with the credit hours earned for the course.", SortOrder=0 },
       };
   }
}
