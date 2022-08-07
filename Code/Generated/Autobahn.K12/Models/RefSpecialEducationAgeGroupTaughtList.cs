//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSpecialEducationAgeGroupTaughtList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefSpecialEducationAgeGroupTaught Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSpecialEducationAgeGroupTaughtModel"> List
         /// </summary>
        public static List<RefSpecialEducationAgeGroupTaughtModel> RefSpecialEducationAgeGroupTaughtList = new List<RefSpecialEducationAgeGroupTaughtModel>
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("a9e0e550-d125-46e5-8b08-53659cc65a92"), Code="3TO5", Description="3 through 5", Definition="The age range of special education students taught is 3 through 5.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("5b17765b-4dd7-44f8-a520-becf95a8c6c7"), Code="6TO21", Description="6 through 21", Definition="The age range of special education students taught is 6 through 21.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefSpecialEducationAgeGroupTaught Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSpecialEducationAgeGroupTaughtViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("a9e0e550-d125-46e5-8b08-53659cc65a92"), Description="3 through 5", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationAgeGroupTaught { Id=Guid.Parse("5b17765b-4dd7-44f8-a520-becf95a8c6c7"), Description="6 through 21", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
