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
        public static List<RefNeglectedProgramType> RefNeglectedProgramTypeList = new List<RefNeglectedProgramType>
        {
            new RefNeglectedProgramType { Id=Guid.Parse("beb2da86-637f-4929-9803-f2c1092d5207"), Code="NeglectedPrograms", Description="Neglected programs", Definition="Neglected programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("6f4f8219-9b8b-4130-b63e-3b491ad6491e"), Code="JuvenileDetention", Description="Juvenile Detention", Definition="Juvenile Detention is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("2c61dc59-9761-4d67-affe-f895598a4fa3"), Code="JuvenileCorrection", Description="Juvenile Correction", Definition="Juvenile Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("01e54f00-5f46-4431-9110-8f5b5b64c9a7"), Code="AdultCorrection", Description="Adult Correction", Definition="Adult Correction is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("4.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("b28befb6-62be-41ee-9827-f461851024fe"), Code="AtRiskPrograms", Description="At-risk programs", Definition="At-risk programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("5.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("a58c00fd-bde7-4be6-9e87-9cc90c8ccefe"), Code="OtherPrograms", Description="Other Programs", Definition="Other Programs is the type of program under ESEA Title I, Part D, Subpart 1 (state programs) or Subpart 2 (LEA).", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefNeglectedProgramType Pick List
         /// </summary>
        public static List<RefNeglectedProgramType> RefNeglectedProgramTypePickList = new List<RefNeglectedProgramType>
        {
            new RefNeglectedProgramType { Id=Guid.Parse("beb2da86-637f-4929-9803-f2c1092d5207"), Code="NeglectedPrograms", Description="Neglected programs", SortOrder=Convert.ToDecimal("1.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("6f4f8219-9b8b-4130-b63e-3b491ad6491e"), Code="JuvenileDetention", Description="Juvenile Detention", SortOrder=Convert.ToDecimal("2.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("2c61dc59-9761-4d67-affe-f895598a4fa3"), Code="JuvenileCorrection", Description="Juvenile Correction", SortOrder=Convert.ToDecimal("3.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("01e54f00-5f46-4431-9110-8f5b5b64c9a7"), Code="AdultCorrection", Description="Adult Correction", SortOrder=Convert.ToDecimal("4.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("b28befb6-62be-41ee-9827-f461851024fe"), Code="AtRiskPrograms", Description="At-risk programs", SortOrder=Convert.ToDecimal("5.00") },
            new RefNeglectedProgramType { Id=Guid.Parse("a58c00fd-bde7-4be6-9e87-9cc90c8ccefe"), Code="OtherPrograms", Description="Other Programs", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
