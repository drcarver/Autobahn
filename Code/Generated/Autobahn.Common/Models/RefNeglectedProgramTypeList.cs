//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefNeglectedProgramTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefNeglectedProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNeglectedProgramTypeModel"> List
         /// </summary>
        public static List<RefNeglectedProgramTypeModel> RefNeglectedProgramTypeList = new List<RefNeglectedProgramTypeModel>
        {
            new RefNeglectedProgramType { Id=Guid.Parse("45d96648-4b0b-4110-abf5-7dd1b74f3b12"), Code="NeglectedPrograms", Description="Neglected programs", Definition="Neglected programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("eef2239a-f559-4e7e-91a2-72bcc974cce5"), Code="JuvenileDetention", Description="Juvenile Detention", Definition="Juvenile Detention is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("926a6b1c-d61e-470b-ba98-f4888485a12d"), Code="JuvenileCorrection", Description="Juvenile Correction", Definition="Juvenile Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("41c9e572-7ee7-446a-ae14-9a5178568a62"), Code="AdultCorrection", Description="Adult Correction", Definition="Adult Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("4.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("a1165b4a-2f94-4e5b-b56d-aa28eb7599fc"), Code="AtRiskPrograms", Description="At-risk programs", Definition="At-risk programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("5.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("0811de15-fbd9-4a4b-9451-4f467b9ad45b"), Code="OtherPrograms", Description="Other Programs", Definition="Other Programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefNeglectedProgramType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefNeglectedProgramTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefNeglectedProgramType { Id=Guid.Parse("45d96648-4b0b-4110-abf5-7dd1b74f3b12"), Description="Neglected programs", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("eef2239a-f559-4e7e-91a2-72bcc974cce5"), Description="Juvenile Detention", SortOrder=Convert.ToDecimal("2.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("926a6b1c-d61e-470b-ba98-f4888485a12d"), Description="Juvenile Correction", SortOrder=Convert.ToDecimal("3.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("41c9e572-7ee7-446a-ae14-9a5178568a62"), Description="Adult Correction", SortOrder=Convert.ToDecimal("4.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("a1165b4a-2f94-4e5b-b56d-aa28eb7599fc"), Description="At-risk programs", SortOrder=Convert.ToDecimal("5.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("0811de15-fbd9-4a4b-9451-4f467b9ad45b"), Description="Other Programs", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
