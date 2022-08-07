//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilityApplicableFederalMandateTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilityApplicableFederalMandateType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilityApplicableFederalMandateTypeModel"> List
         /// </summary>
        public static List<RefFacilityApplicableFederalMandateTypeModel> RefFacilityApplicableFederalMandateTypeList = new List<RefFacilityApplicableFederalMandateTypeModel>
        {
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a815adb5-31a3-49d5-abcc-8ba0262af837"), Code="02584", Description="Americans with Disabilities Act (ADA)", Definition="Public Law 101-336 which prohibits discrimination against individuals with disabilities as regards to employment, public accommodations and certain public services. Also known as Americans with Disabilities Act (ADA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("94513320-82a9-4d4f-ba56-ae520af878ce"), Code="02588", Description="Asbestos Hazardous Emergency Response Act (AHERA)", Definition="Asbestos Hazardous Emergency Response Act (AHERA) is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("90c47829-e162-4bf5-9285-5948f74bd73b"), Code="02585", Description="Individuals with Disabilities Education Act (IDEA)", Definition="Public Law 105-17 is designed to insure that all children with disabilities have available to them a free appropriate public education. Public Law. (Formerly called Education of the Handicapped Act P.L. 91-230.) Also known as Individuals with Disabilities Education Act (IDEA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("71f9e0f1-a059-40ae-ba85-f5849a3ba484"), Code="02587", Description="Lead Contamination Control Act", Definition="Lead Contamination Control Act is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a4e39ff4-11d8-47a2-8f2f-1ccd3ba65ad0"), Code="02586", Description="Safe Drinking Water Act", Definition="Safe Drinking Water Act is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("305c78b1-c274-44f2-bf5e-cd8cfa565620"), Code="09999", Description="Other", Definition="Other is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilityApplicableFederalMandateType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilityApplicableFederalMandateTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a815adb5-31a3-49d5-abcc-8ba0262af837"), Description="Americans with Disabilities Act (ADA)", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("94513320-82a9-4d4f-ba56-ae520af878ce"), Description="Asbestos Hazardous Emergency Response Act (AHERA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("90c47829-e162-4bf5-9285-5948f74bd73b"), Description="Individuals with Disabilities Education Act (IDEA)", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("71f9e0f1-a059-40ae-ba85-f5849a3ba484"), Description="Lead Contamination Control Act", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a4e39ff4-11d8-47a2-8f2f-1ccd3ba65ad0"), Description="Safe Drinking Water Act", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("305c78b1-c274-44f2-bf5e-cd8cfa565620"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
