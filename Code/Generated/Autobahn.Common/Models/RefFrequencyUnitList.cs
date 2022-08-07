//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefFrequencyUnitList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefFrequencyUnit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFrequencyUnitModel"> List
         /// </summary>
        public static List<RefFrequencyUnitModel> RefFrequencyUnitList = new List<RefFrequencyUnitModel>
        {
            new RefFrequencyUnit { Id=Guid.Parse("9a086d62-2f04-4057-80da-987741dda5e5"), Code="Day", Description="Day", Definition="Day is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("d6c0394f-8dcb-4d97-aeb7-de641596c079"), Code="Hour", Description="Hour", Definition="Hour is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("8ccb7064-8fd3-46ec-98fc-87a9c0459f30"), Code="Minute", Description="Minute", Definition="Minute is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("7b4ac4b3-ac04-4c0c-bea9-8c9e36a353c9"), Code="Month", Description="Month", Definition="Month is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("1901375a-945c-4564-8f48-9a0eb8991c63"), Code="Week", Description="Week", Definition="Week is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("e23790d4-b4dc-4fa1-9ddb-16cc55a01d0e"), Code="Year", Description="Year", Definition="Year is the unit of time by which a cycle is defined.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefFrequencyUnit Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFrequencyUnitViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFrequencyUnit { Id=Guid.Parse("9a086d62-2f04-4057-80da-987741dda5e5"), Description="Day", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("d6c0394f-8dcb-4d97-aeb7-de641596c079"), Description="Hour", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("8ccb7064-8fd3-46ec-98fc-87a9c0459f30"), Description="Minute", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("7b4ac4b3-ac04-4c0c-bea9-8c9e36a353c9"), Description="Month", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("1901375a-945c-4564-8f48-9a0eb8991c63"), Description="Week", SortOrder=Convert.ToDecimal("") },
            new RefFrequencyUnit { Id=Guid.Parse("e23790d4-b4dc-4fa1-9ddb-16cc55a01d0e"), Description="Year", SortOrder=Convert.ToDecimal("") },
       };
   }
}
