//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefProgramLengthHoursTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefProgramLengthHoursType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProgramLengthHoursTypeModel"> List
         /// </summary>
        public static List<RefProgramLengthHoursTypeModel> RefProgramLengthHoursTypeList = new List<RefProgramLengthHoursTypeModel>
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("75028d92-00e3-4b7b-b770-2604e0fb077d"), Code="Credit", Description="Credit", Definition="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramLengthHoursType { Id=Guid.Parse("8e8295fd-585f-423b-b616-613410b38a06"), Code="Contact", Description="Contact", Definition="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefProgramLengthHoursType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProgramLengthHoursTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProgramLengthHoursType { Id=Guid.Parse("75028d92-00e3-4b7b-b770-2604e0fb077d"), Description="Credit", SortOrder=Convert.ToDecimal("1.00") },
            new RefProgramLengthHoursType { Id=Guid.Parse("8e8295fd-585f-423b-b616-613410b38a06"), Description="Contact", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
