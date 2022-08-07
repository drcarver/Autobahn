//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdditionalCreditTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAdditionalCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdditionalCreditTypeModel"> List
         /// </summary>
        public static List<RefAdditionalCreditTypeModel> RefAdditionalCreditTypeList = new List<RefAdditionalCreditTypeModel>
        {
            new RefAdditionalCreditType { Id=Guid.Parse("316b905f-d905-4011-ba59-fc92e406a9b0"), Code="AdvancedPlacement", Description="Advanced Placement", Definition="Advanced Placement is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("df478b3f-91a7-42ab-86be-adfa5ebeeef6"), Code="ApprenticeshipCredit", Description="Apprenticeship Credit", Definition="Apprenticeship Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("ea20b90f-9d24-4a2d-b36f-435469786c1d"), Code="CTE", Description="Career and Technical Education", Definition="Career and Technical Education is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("752a8116-6386-4a01-8f26-71912f0b845c"), Code="DualCredit", Description="Dual Credit", Definition="Dual Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("2ba786d6-23e0-45e7-80fb-f31efce594fe"), Code="InternationalBaccalaureate", Description="International Baccalaureate", Definition="International Baccalaureate is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("d20c7378-4707-446b-98f3-d6248a6502a4"), Code="Other", Description="Other", Definition="Other is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("bb6322c5-a265-4828-97d2-d17ebedc67af"), Code="QualifiedAdmission", Description="Qualified Admission", Definition="Qualified Admission is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("c4b0091e-ec16-49e4-ba5a-1d4b77dd5ee5"), Code="STEM", Description="Science, Technology, Engineering and Mathematics", Definition="Science, Technology, Engineering and Mathematics is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("972b2a96-6650-4932-b066-442c821e6ac8"), Code="CTEAndAcademic", Description="Simultaneous CTE and Academic Credit", Definition="Simultaneous CTE and Academic Credit is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("e57611da-794d-49c7-9a42-fdce85cd0d4d"), Code="StateScholarship", Description="State Scholarship", Definition="State Scholarship is specified as the type of credits or units of value available for the completion of a course in addition to Carnegie Units.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The Reference RefAdditionalCreditType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdditionalCreditTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdditionalCreditType { Id=Guid.Parse("316b905f-d905-4011-ba59-fc92e406a9b0"), Description="Advanced Placement", SortOrder=Convert.ToDecimal("0.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("df478b3f-91a7-42ab-86be-adfa5ebeeef6"), Description="Apprenticeship Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("ea20b90f-9d24-4a2d-b36f-435469786c1d"), Description="Career and Technical Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("752a8116-6386-4a01-8f26-71912f0b845c"), Description="Dual Credit", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("2ba786d6-23e0-45e7-80fb-f31efce594fe"), Description="International Baccalaureate", SortOrder=Convert.ToDecimal("4.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("d20c7378-4707-446b-98f3-d6248a6502a4"), Description="Other", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("bb6322c5-a265-4828-97d2-d17ebedc67af"), Description="Qualified Admission", SortOrder=Convert.ToDecimal("10.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("c4b0091e-ec16-49e4-ba5a-1d4b77dd5ee5"), Description="Science, Technology, Engineering and Mathematics", SortOrder=Convert.ToDecimal("14.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("972b2a96-6650-4932-b066-442c821e6ac8"), Description="Simultaneous CTE and Academic Credit", SortOrder=Convert.ToDecimal("16.00") },
            new RefAdditionalCreditType { Id=Guid.Parse("e57611da-794d-49c7-9a42-fdce85cd0d4d"), Description="State Scholarship", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
