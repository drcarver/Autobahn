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
        /// The complete <see cref="RefFacilityNaturallyOccurringHazardTypeModel"> List
         /// </summary>
        public static List<RefFacilityNaturallyOccurringHazardTypeModel> RefFacilityNaturallyOccurringHazardTypeList = new List<RefFacilityNaturallyOccurringHazardTypeModel>
        {
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("08494115-0377-404a-8787-fd43871c5bea"), Code="13678", Description="Arsenic", Definition="Arsenic is a semi-metal element in the periodic table. It is odorless and tasteless. It enters drinking water supplies from natural deposits in the earth or from agricultural and industrial practices. Non-cancer effects can include thickening and discoloration of the skin, stomach pain, nausea, vomiting; diarrhea; numbness in hands and feet; partial paralysis; and blindness. Arsenic has been linked to cancer of the bladder, lungs, skin, kidney, nasal passages, liver, and prostate.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("6891510d-61e8-4b8d-adc1-1938f2e38538"), Code="13679", Description="Earthquake prone area", Definition="Building in an earthquake prone area is a structural hazard.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("de9fc35b-bcf7-4120-8264-332a557c55d8"), Code="13680", Description="Floodplain", Definition="Building in a floodplain is a structural hazard.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("1e34ec9f-9143-4d28-af20-fe130842a9aa"), Code="13681", Description="Liquefaction, landslide areas", Definition="Building in a landslide area is a structural hazard.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("91955be8-a9be-4bb9-b0ec-062d6d84ad51"), Code="13682", Description="Naturally Occurring Asbestos (NOA)", Definition="Naturally occurring asbestos (NOA) includes fibrous minerals found in certain types of rock formations. NOA can take the form of long, thin, separable fibers. Natural weathering or human disturbance can break NOA down to microscopic fibers, easily suspended in air. There is no health threat if NOA remains undisturbed and does not become airborne.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("3a79af0e-6f7c-4a97-adbc-633c61fd6399"), Code="13683", Description="Sinkholes, Karst terrain", Definition="Building in a sinkhole is a structural hazard.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefFacilityNaturallyOccurringHazardType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityNaturallyOccurringHazardTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("08494115-0377-404a-8787-fd43871c5bea"), Description="Arsenic", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("6891510d-61e8-4b8d-adc1-1938f2e38538"), Description="Earthquake prone area", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("de9fc35b-bcf7-4120-8264-332a557c55d8"), Description="Floodplain", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("1e34ec9f-9143-4d28-af20-fe130842a9aa"), Description="Liquefaction, landslide areas", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("91955be8-a9be-4bb9-b0ec-062d6d84ad51"), Description="Naturally Occurring Asbestos (NOA)", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityNaturallyOccurringHazardType { Id=Guid.Parse("3a79af0e-6f7c-4a97-adbc-633c61fd6399"), Description="Sinkholes, Karst terrain", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
