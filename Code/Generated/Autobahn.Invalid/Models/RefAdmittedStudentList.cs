//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefAdmittedStudentList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefAdmittedStudent Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdmittedStudentModel"> List
         /// </summary>
        public static List<RefAdmittedStudentModel> RefAdmittedStudentList = new List<RefAdmittedStudentModel>
        {
        };

        /// <summary>
        /// The Reference RefAdmittedStudent Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdmittedStudentViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
