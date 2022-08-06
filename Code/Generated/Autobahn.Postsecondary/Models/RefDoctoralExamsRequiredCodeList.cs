//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefDoctoralExamsRequiredCodeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefDoctoralExamsRequiredCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDoctoralExamsRequiredCode"> List
         /// </summary>
        public static List<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodeList = new List<RefDoctoralExamsRequiredCode>
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("80067bc4-4159-435d-a0ec-3776c91769eb"), Code="Qualifying", Description="Qualifying exam", Definition="Qualifying exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("f4f4e86d-3386-46df-9809-5bf1262c1096"), Code="OralComprehensive", Description="Oral comprehensive exam", Definition="Oral comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("9897eea5-9caa-478a-b4e7-a3642d198c89"), Code="WrittenComprehensive", Description="Written comprehensive exam", Definition="Written comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("b9e3b4a4-ecab-4c04-86eb-670c8f76de24"), Code="Candidacy", Description="Candidacy exam", Definition="Candidacy exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("37523f6a-2c6f-4570-96a4-9381dbf846a6"), Code="Other", Description="Other departmental or institutional exam", Definition="Other departmental or institutional exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefDoctoralExamsRequiredCode Pick List
         /// </summary>
        public static List<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodePickList = new List<RefDoctoralExamsRequiredCode>
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("80067bc4-4159-435d-a0ec-3776c91769eb"), Code="Qualifying", Description="Qualifying exam", SortOrder=Convert.ToDecimal("1.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("f4f4e86d-3386-46df-9809-5bf1262c1096"), Code="OralComprehensive", Description="Oral comprehensive exam", SortOrder=Convert.ToDecimal("3.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("9897eea5-9caa-478a-b4e7-a3642d198c89"), Code="WrittenComprehensive", Description="Written comprehensive exam", SortOrder=Convert.ToDecimal("5.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("b9e3b4a4-ecab-4c04-86eb-670c8f76de24"), Code="Candidacy", Description="Candidacy exam", SortOrder=Convert.ToDecimal("7.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("37523f6a-2c6f-4570-96a4-9381dbf846a6"), Code="Other", Description="Other departmental or institutional exam", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
