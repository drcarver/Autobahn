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
        public static List<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodeList = new List<RefDoctoralExamsRequiredCode> =
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("4b683b8d-7997-4037-9726-fce6a7f7744c"), Code="Qualifying exam is a type of exam required of doctoral level individuals.", Description="Qualifying", Definition="", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("8c2cee88-27e9-434a-8944-e092b3767ef5"), Code="Oral comprehensive exam is a type of exam required of doctoral level individuals.", Description="OralComprehensive", Definition="", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("67296d20-c052-4e7d-8130-450f51bdc202"), Code="Written comprehensive exam is a type of exam required of doctoral level individuals.", Description="WrittenComprehensive", Definition="", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("d3ed05fb-287f-4639-a2fa-4b7f0a7885e8"), Code="Candidacy exam is a type of exam required of doctoral level individuals.", Description="Candidacy", Definition="", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("6bebcd8d-3127-4004-bef2-bdf62aae4441"), Code="Other departmental or institutional exam is a type of exam required of doctoral level individuals.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDoctoralExamsRequiredCode Pick List
         /// </summary>
        public static List<RefDoctoralExamsRequiredCode> RefDoctoralExamsRequiredCodePickList = new List<RefDoctoralExamsRequiredCode> =
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("4b683b8d-7997-4037-9726-fce6a7f7744c"), Code="Qualifying exam is a type of exam required of doctoral level individuals.", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("8c2cee88-27e9-434a-8944-e092b3767ef5"), Code="Oral comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("67296d20-c052-4e7d-8130-450f51bdc202"), Code="Written comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("d3ed05fb-287f-4639-a2fa-4b7f0a7885e8"), Code="Candidacy exam is a type of exam required of doctoral level individuals.", SortOrder=0 },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("6bebcd8d-3127-4004-bef2-bdf62aae4441"), Code="Other departmental or institutional exam is a type of exam required of doctoral level individuals.", SortOrder=0 },
       };
   }
}
