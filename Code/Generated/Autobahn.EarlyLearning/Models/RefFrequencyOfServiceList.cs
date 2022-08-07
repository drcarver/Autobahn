//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefFrequencyOfServiceList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefFrequencyOfService Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFrequencyOfServiceModel"> List
         /// </summary>
        public static List<RefFrequencyOfServiceModel> RefFrequencyOfServiceList = new List<RefFrequencyOfServiceModel>
        {
            new RefFrequencyOfService { Id=Guid.Parse("e395e303-4069-46b4-9879-5e2689321a7d"), Code="Daily", Description="Daily", Definition="Daily service is planned to occur.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFrequencyOfService { Id=Guid.Parse("0a34c8eb-be30-4f7e-a09f-c63081c95be6"), Code="Weekly", Description="Weekly", Definition="Weekly service is planned to occur.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFrequencyOfService { Id=Guid.Parse("8ce74708-452a-47cd-9420-c0e3fc8a7144"), Code="Monthly", Description="Monthly", Definition="Monthly service is planned to occur.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFrequencyOfService { Id=Guid.Parse("7667a85f-09df-4cdc-8fa3-d748210dd794"), Code="Quarterly", Description="Quarterly", Definition="Quarterly service is planned to occur.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFrequencyOfService { Id=Guid.Parse("ef581912-8b03-4037-ac04-1ddc1625b559"), Code="Annually", Description="Annually", Definition="Annually service is planned to occur.", SortOrder=Convert.ToDecimal("9.00") },
            new RefFrequencyOfService { Id=Guid.Parse("fcd0cd9b-0935-420e-8d3c-b96bb57abd34"), Code="OneTime", Description="One Time", Definition="The service is planned to occur one time.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefFrequencyOfService Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFrequencyOfServiceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFrequencyOfService { Id=Guid.Parse("e395e303-4069-46b4-9879-5e2689321a7d"), Description="Daily", SortOrder=Convert.ToDecimal("1.00") },
            new RefFrequencyOfService { Id=Guid.Parse("0a34c8eb-be30-4f7e-a09f-c63081c95be6"), Description="Weekly", SortOrder=Convert.ToDecimal("3.00") },
            new RefFrequencyOfService { Id=Guid.Parse("8ce74708-452a-47cd-9420-c0e3fc8a7144"), Description="Monthly", SortOrder=Convert.ToDecimal("5.00") },
            new RefFrequencyOfService { Id=Guid.Parse("7667a85f-09df-4cdc-8fa3-d748210dd794"), Description="Quarterly", SortOrder=Convert.ToDecimal("7.00") },
            new RefFrequencyOfService { Id=Guid.Parse("ef581912-8b03-4037-ac04-1ddc1625b559"), Description="Annually", SortOrder=Convert.ToDecimal("9.00") },
            new RefFrequencyOfService { Id=Guid.Parse("fcd0cd9b-0935-420e-8d3c-b96bb57abd34"), Description="One Time", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
