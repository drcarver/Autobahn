//**********************************************************
//* DomainName: Autobahn.LearningResource
//* FileName:   RefLearningResourceAccessAPITypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.LearningResource.Models
{
     /// <summary>
     /// The list of RefLearningResourceAccessAPIType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefLearningResourceAccessAPITypeModel"> List
         /// </summary>
        public static List<RefLearningResourceAccessAPITypeModel> RefLearningResourceAccessAPITypeList = new List<RefLearningResourceAccessAPITypeModel>
        {
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("127740d7-e407-4b13-9e39-82db896ce83c"), Code="AndroidAccessibility", Description="Android Accessibility", Definition="The learning resource is compatible with Android Accessibility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("e2c7382c-5684-482b-8c33-41572b5ac622"), Code="ARIA", Description="ARIA", Definition="The learning resource is compatible with ARIA for accessibility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("5e7c2d8d-692a-4cec-b46c-37eed25ace29"), Code="ATK", Description="ATK", Definition="The learning resource is compatible with ATK for accessibility.", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("7aa4985e-ea3a-4e48-b6e8-66c48abd545a"), Code="AT-SPI", Description="AT-SPI", Definition="The learning resource is compatible with AT-SPI for accessibility.", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("07c400c2-b235-43f5-938e-6395f6587dda"), Code="BlackberryAccessibility", Description="Blackberry Accessibility", Definition="The learning resource is compatible with Blackberry Accessibility.", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("d22503c2-318d-49bb-9c29-0c897d47bd95"), Code="iAccessible2", Description="I Accessible2", Definition="The learning resource is compatible with I Accessible2.", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("6db64084-71e6-4de0-835d-e224e6ed81a0"), Code="iOSAccessibility", Description="iOS Accessibility", Definition="The learning resource is compatible with iOS Accessibility.", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("2c4ab380-4dce-41d9-bf41-d84c07ccd9b0"), Code="JavaAccessibility", Description="Java Accessibility", Definition="The learning resource is compatible with Java Accessibility.", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("9745567b-13e0-4adf-8bd2-4a051d823f4e"), Code="MacOSXAccessibility", Description="Mac OSX Accessibility", Definition="The learning resource is compatible with Mac OSX Accessibility.", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("68273818-2d1a-4193-a5ac-7a0969edcfef"), Code="MSAA", Description="MSAA", Definition="The learning resource is compatible with MSAA.", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("dbab0ad8-4327-4a36-9ece-8f89811ea703"), Code="UIAutomation", Description="UI Automation", Definition="The learning resource is compatible with the UI Automation.", SortOrder=Convert.ToDecimal("22.00") },
        };

        /// <summary>
        /// The Reference RefLearningResourceAccessAPIType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefLearningResourceAccessAPITypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("127740d7-e407-4b13-9e39-82db896ce83c"), Description="Android Accessibility", SortOrder=Convert.ToDecimal("2.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("e2c7382c-5684-482b-8c33-41572b5ac622"), Description="ARIA", SortOrder=Convert.ToDecimal("4.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("5e7c2d8d-692a-4cec-b46c-37eed25ace29"), Description="ATK", SortOrder=Convert.ToDecimal("6.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("7aa4985e-ea3a-4e48-b6e8-66c48abd545a"), Description="AT-SPI", SortOrder=Convert.ToDecimal("8.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("07c400c2-b235-43f5-938e-6395f6587dda"), Description="Blackberry Accessibility", SortOrder=Convert.ToDecimal("10.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("d22503c2-318d-49bb-9c29-0c897d47bd95"), Description="I Accessible2", SortOrder=Convert.ToDecimal("12.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("6db64084-71e6-4de0-835d-e224e6ed81a0"), Description="iOS Accessibility", SortOrder=Convert.ToDecimal("14.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("2c4ab380-4dce-41d9-bf41-d84c07ccd9b0"), Description="Java Accessibility", SortOrder=Convert.ToDecimal("16.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("9745567b-13e0-4adf-8bd2-4a051d823f4e"), Description="Mac OSX Accessibility", SortOrder=Convert.ToDecimal("18.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("68273818-2d1a-4193-a5ac-7a0969edcfef"), Description="MSAA", SortOrder=Convert.ToDecimal("20.00") },
            new RefLearningResourceAccessAPIType { Id=Guid.Parse("dbab0ad8-4327-4a36-9ece-8f89811ea703"), Description="UI Automation", SortOrder=Convert.ToDecimal("22.00") },
       };
   }
}
