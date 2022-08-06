//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityNaturallyOccurringHazardTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityNaturallyOccurringHazardType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityNaturallyOccurringHazardType"> List
         /// </summary>
        public static List<RefFacilityNaturallyOccurringHazardType> RefFacilityNaturallyOccurringHazardTypeList = new List<RefFacilityNaturallyOccurringHazardType>
        {
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("6227993c-643c-4666-a320-ae9b4e581693"), Code="13678", Description="Arsenic", Definition="Arsenic is a semi-metal element in the periodic table. It is odorless and tasteless. It enters drinking water supplies from natural deposits in the earth or from agricultural and industrial practices. Non-cancer effects can include thickening and discoloration of the skin, stomach pain, nausea, vomiting; diarrhea; numbness in hands and feet; partial paralysis; and blindness. Arsenic has been linked to cancer of the bladder, lungs, skin, kidney, nasal passages, liver, and prostate.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("43f4980b-7211-4a5e-adf3-f689c2151c49"), Code="13679", Description="Earthquake prone area", Definition="Building in an earthquake prone area is a structural hazard.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("ce5cce03-bde4-4316-974f-2682c6772b65"), Code="13680", Description="Floodplain", Definition="Building in a floodplain is a structural hazard.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("5929194d-eb4f-4f2c-bdb9-12bf26aee138"), Code="13681", Description="Liquefaction, landslide areas", Definition="Building in a landslide area is a structural hazard.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("a6c5f2fd-1949-4973-b113-8293814d43ed"), Code="13682", Description="Naturally Occurring Asbestos (NOA)", Definition="Naturally occurring asbestos (NOA) includes fibrous minerals found in certain types of rock formations. NOA can take the form of long, thin, separable fibers. Natural weathering or human disturbance can break NOA down to microscopic fibers, easily suspended in air. There is no health threat if NOA remains undisturbed and does not become airborne.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("5b0d908d-ec30-40d8-8fac-0ddf0ffbf699"), Code="13683", Description="Sinkholes, Karst terrain", Definition="Building in a sinkhole is a structural hazard.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefFacilityNaturallyOccurringHazardType Pick List
         /// </summary>
        public static List<RefFacilityNaturallyOccurringHazardType> RefFacilityNaturallyOccurringHazardTypePickList = new List<RefFacilityNaturallyOccurringHazardType>
        {
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("6227993c-643c-4666-a320-ae9b4e581693"), Code="13678", Description="Arsenic", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("43f4980b-7211-4a5e-adf3-f689c2151c49"), Code="13679", Description="Earthquake prone area", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("ce5cce03-bde4-4316-974f-2682c6772b65"), Code="13680", Description="Floodplain", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("5929194d-eb4f-4f2c-bdb9-12bf26aee138"), Code="13681", Description="Liquefaction, landslide areas", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("a6c5f2fd-1949-4973-b113-8293814d43ed"), Code="13682", Description="Naturally Occurring Asbestos (NOA)", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("5b0d908d-ec30-40d8-8fac-0ddf0ffbf699"), Code="13683", Description="Sinkholes, Karst terrain", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
