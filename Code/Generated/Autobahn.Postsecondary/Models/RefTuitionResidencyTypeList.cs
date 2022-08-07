//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTuitionResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTuitionResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTuitionResidencyTypeModel"> List
         /// </summary>
        public static List<RefTuitionResidencyTypeModel> RefTuitionResidencyTypeList = new List<RefTuitionResidencyTypeModel>
        {
            new RefTuitionResidencyType { Id=Guid.Parse("10ceee90-6772-4220-9ae3-d77cf9840b7f"), Code="InDistrict", Description="In-district", Definition="The person's residency status for tuition purposes is: In-district.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("620c1cd7-6fb6-4776-b978-e528c0822a93"), Code="InState", Description="In-state", Definition="The person's residency status for tuition purposes is: In-state.", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("8ab40cf3-b626-4117-b2da-1bf21d6793ff"), Code="OutOfState", Description="Out-of-state", Definition="The person's residency status for tuition purposes is: Out-of-state.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("52a4d681-a3fc-41fb-a147-cb1b53352aa7"), Code="NoDifferential", Description="No differential tuition based on residency", Definition="No differential tuition based on residency is provided.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefTuitionResidencyType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTuitionResidencyTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTuitionResidencyType { Id=Guid.Parse("10ceee90-6772-4220-9ae3-d77cf9840b7f"), Description="In-district", SortOrder=Convert.ToDecimal("1.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("620c1cd7-6fb6-4776-b978-e528c0822a93"), Description="In-state", SortOrder=Convert.ToDecimal("2.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("8ab40cf3-b626-4117-b2da-1bf21d6793ff"), Description="Out-of-state", SortOrder=Convert.ToDecimal("3.00") },
            new RefTuitionResidencyType { Id=Guid.Parse("52a4d681-a3fc-41fb-a147-cb1b53352aa7"), Description="No differential tuition based on residency", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
