//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefNeglectedProgramTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefNeglectedProgramType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefNeglectedProgramType"> List
         /// </summary>
        public static List<RefNeglectedProgramType> RefNeglectedProgramTypeList = new List<RefNeglectedProgramType> =
        {
            new RefNeglectedProgramType { Id=Guid.Parse("9e92af6d-ac3c-404f-b217-9191fe6afe8d"), Code="Neglected programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="NeglectedPrograms", Definition="", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("da455b02-35e4-49f0-a856-348c3cde01e1"), Code="Juvenile Detention is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="JuvenileDetention", Definition="", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("25a7d828-f59a-4fc6-95be-0479f1f3d779"), Code="Juvenile Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="JuvenileCorrection", Definition="", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("cd0893cf-dc21-4583-8560-62adbb65cfda"), Code="Adult Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="AdultCorrection", Definition="", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("1413038f-739d-44e5-86e5-c80835fa82fa"), Code="At-risk programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="AtRiskPrograms", Definition="", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("c46f4373-875e-4458-ab2e-227850a25c81"), Code="Other Programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", Description="OtherPrograms", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefNeglectedProgramType Pick List
         /// </summary>
        public static List<RefNeglectedProgramType> RefNeglectedProgramTypePickList = new List<RefNeglectedProgramType> =
        {
            new RefNeglectedProgramType { Id=Guid.Parse("9e92af6d-ac3c-404f-b217-9191fe6afe8d"), Code="Neglected programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("da455b02-35e4-49f0-a856-348c3cde01e1"), Code="Juvenile Detention is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("25a7d828-f59a-4fc6-95be-0479f1f3d779"), Code="Juvenile Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("cd0893cf-dc21-4583-8560-62adbb65cfda"), Code="Adult Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("1413038f-739d-44e5-86e5-c80835fa82fa"), Code="At-risk programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
            new RefNeglectedProgramType { Id=Guid.Parse("c46f4373-875e-4458-ab2e-227850a25c81"), Code="Other Programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=0 },
       };
   }
}
