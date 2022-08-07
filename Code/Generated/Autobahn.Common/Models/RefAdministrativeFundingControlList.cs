//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAdministrativeFundingControlList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAdministrativeFundingControl Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdministrativeFundingControlModel"> List
         /// </summary>
        public static List<RefAdministrativeFundingControlModel> RefAdministrativeFundingControlList = new List<RefAdministrativeFundingControlModel>
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("3422fb6b-6f98-4087-8dfd-4d862d2e4516"), Code="Public", Description="Public School", Definition="Public School is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("df61a885-156d-47e3-8fd4-9234f1d6e729"), Code="Private", Description="Private School", Definition="Private School is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("e151f26c-2f44-4adb-b4cc-ab9d159f8d42"), Code="Other", Description="Other", Definition="Other is specified as the type of education institution as classified by its funding source.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefAdministrativeFundingControl Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdministrativeFundingControlViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdministrativeFundingControl { Id=Guid.Parse("3422fb6b-6f98-4087-8dfd-4d862d2e4516"), Description="Public School", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("df61a885-156d-47e3-8fd4-9234f1d6e729"), Description="Private School", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdministrativeFundingControl { Id=Guid.Parse("e151f26c-2f44-4adb-b4cc-ab9d159f8d42"), Description="Other", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
