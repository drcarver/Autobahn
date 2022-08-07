//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPrimaryLearningDeviceProviderList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPrimaryLearningDeviceProvider Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPrimaryLearningDeviceProviderModel"> List
         /// </summary>
        public static List<RefPrimaryLearningDeviceProviderModel> RefPrimaryLearningDeviceProviderList = new List<RefPrimaryLearningDeviceProviderModel>
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("59da3321-b77b-426a-bf07-1109f41f476e"), Code="Personal", Description="Personal", Definition="The provider of the primary learning device is the student or guardian.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("2d03731d-0ced-4ba2-b621-df5f9b593cc8"), Code="School", Description="School", Definition="The provider of the primary learning device is the school.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("dfe4daf3-cbd7-4337-a0c5-cecd517d105e"), Code="Other", Description="Other", Definition="The provider of the primary learning device is not yet defined.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefPrimaryLearningDeviceProvider Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPrimaryLearningDeviceProviderViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("59da3321-b77b-426a-bf07-1109f41f476e"), Description="Personal", SortOrder=Convert.ToDecimal("1.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("2d03731d-0ced-4ba2-b621-df5f9b593cc8"), Description="School", SortOrder=Convert.ToDecimal("2.00") },
            new RefPrimaryLearningDeviceProvider { Id=Guid.Parse("dfe4daf3-cbd7-4337-a0c5-cecd517d105e"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
