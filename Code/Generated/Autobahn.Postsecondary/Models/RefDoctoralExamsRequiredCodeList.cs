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
        /// The complete <see cref="RefDoctoralExamsRequiredCodeModel"> List
         /// </summary>
        public static List<RefDoctoralExamsRequiredCodeModel> RefDoctoralExamsRequiredCodeList = new List<RefDoctoralExamsRequiredCodeModel>
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("bb7dcd35-8d40-44a3-8719-5d608fd0e19b"), Code="Qualifying", Description="Qualifying exam", Definition="Qualifying exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("4a4dc6b2-d8f5-4a93-8a43-48d9c12deb1a"), Code="OralComprehensive", Description="Oral comprehensive exam", Definition="Oral comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("a162cbf1-41f8-49b0-a45a-fb0e6ac6d142"), Code="WrittenComprehensive", Description="Written comprehensive exam", Definition="Written comprehensive exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("47700c4b-756c-49b8-9beb-1aefcc2edbbd"), Code="Candidacy", Description="Candidacy exam", Definition="Candidacy exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("7.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("3b5274a7-8a72-4a4b-86ab-e8608e6a2061"), Code="Other", Description="Other departmental or institutional exam", Definition="Other departmental or institutional exam is a type of exam required of doctoral level individuals.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefDoctoralExamsRequiredCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDoctoralExamsRequiredCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("bb7dcd35-8d40-44a3-8719-5d608fd0e19b"), Description="Qualifying exam", SortOrder=Convert.ToDecimal("1.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("4a4dc6b2-d8f5-4a93-8a43-48d9c12deb1a"), Description="Oral comprehensive exam", SortOrder=Convert.ToDecimal("3.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("a162cbf1-41f8-49b0-a45a-fb0e6ac6d142"), Description="Written comprehensive exam", SortOrder=Convert.ToDecimal("5.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("47700c4b-756c-49b8-9beb-1aefcc2edbbd"), Description="Candidacy exam", SortOrder=Convert.ToDecimal("7.00") },
            new RefDoctoralExamsRequiredCode { Id=Guid.Parse("3b5274a7-8a72-4a4b-86ab-e8608e6a2061"), Description="Other departmental or institutional exam", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
