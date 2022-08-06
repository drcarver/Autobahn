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
        /// The complete <see cref="RefBuildingTechnologyWiringSystemType"> List
         /// </summary>
        public static List<RefBuildingTechnologyWiringSystemType> RefBuildingTechnologyWiringSystemTypeList = new List<RefBuildingTechnologyWiringSystemType>
        {
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("dce3ac37-624a-4905-83fb-fb37b1fdf190"), Code="02504", Description="Coaxial cable", Definition="Coaxial cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("134d0851-5bf1-4957-9cad-6114c4725989"), Code="02503", Description="Fiber optic cable", Definition="Fiber optic cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f759ae72-dae7-4dc5-b673-aabce5ad878f"), Code="02506", Description="Twisted pair", Definition="Twisted pair is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("8af78c20-a231-47bf-af0b-5379522436a0"), Code="02502", Description="Wire cable", Definition="Wire cable is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("2baf4422-b737-4364-85cc-ad01124602a7"), Code="02505", Description="Wireless", Definition="Wireless is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f05f3af4-4028-4850-904e-6cb17248996a"), Code="09999", Description="Other", Definition="Other is specified as the means through which voice, video, audio, and data information are conveyed.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefBuildingTechnologyWiringSystemType Pick List
         /// </summary>
        public static List<RefBuildingTechnologyWiringSystemType> RefBuildingTechnologyWiringSystemTypePickList = new List<RefBuildingTechnologyWiringSystemType>
        {
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("dce3ac37-624a-4905-83fb-fb37b1fdf190"), Code="02504", Description="Coaxial cable", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("134d0851-5bf1-4957-9cad-6114c4725989"), Code="02503", Description="Fiber optic cable", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f759ae72-dae7-4dc5-b673-aabce5ad878f"), Code="02506", Description="Twisted pair", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("8af78c20-a231-47bf-af0b-5379522436a0"), Code="02502", Description="Wire cable", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("2baf4422-b737-4364-85cc-ad01124602a7"), Code="02505", Description="Wireless", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingTechnologyWiringSystemType { Id=Guid.Parse("f05f3af4-4028-4850-904e-6cb17248996a"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
