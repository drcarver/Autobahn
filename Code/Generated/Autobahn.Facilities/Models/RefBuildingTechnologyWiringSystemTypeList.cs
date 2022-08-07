//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingTechnologyWiringSystemTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingTechnologyWiringSystemType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingTechnologyWiringSystemTypeModel"> List
         /// </summary>
        public static List<RefBuildingTechnologyWiringSystemTypeModel> RefBuildingTechnologyWiringSystemTypeList = new List<RefBuildingTechnologyWiringSystemTypeModel>
        {
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("ed953a8d-3686-421d-aa78-dfbfab7cfd50"), Code="02504", Description="Coaxial cable", Definition="Coaxial cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f70c4549-8056-40d6-be94-8bd8a1bde35f"), Code="02503", Description="Fiber optic cable", Definition="Fiber optic cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("cc474ff8-0bd1-4385-b1ce-003c363b424d"), Code="02506", Description="Twisted pair", Definition="Twisted pair is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("dc0073c5-4c28-4083-b28a-7b5528cf6e50"), Code="02502", Description="Wire cable", Definition="Wire cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("af8c607b-efcb-4178-a232-f82ee755015d"), Code="02505", Description="Wireless", Definition="Wireless is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("48574e91-d1a0-4b6a-b8bc-c6c7170fcf9f"), Code="09999", Description="Other", Definition="Other is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingTechnologyWiringSystemType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingTechnologyWiringSystemTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("ed953a8d-3686-421d-aa78-dfbfab7cfd50"), Description="Coaxial cable", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f70c4549-8056-40d6-be94-8bd8a1bde35f"), Description="Fiber optic cable", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("cc474ff8-0bd1-4385-b1ce-003c363b424d"), Description="Twisted pair", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("dc0073c5-4c28-4083-b28a-7b5528cf6e50"), Description="Wire cable", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("af8c607b-efcb-4178-a232-f82ee755015d"), Description="Wireless", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("48574e91-d1a0-4b6a-b8bc-c6c7170fcf9f"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
