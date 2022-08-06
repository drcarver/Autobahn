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
        /// The complete <see cref="RefFacilityApplicableFederalMandateType"> List
         /// </summary>
        public static List<RefFacilityApplicableFederalMandateType> RefFacilityApplicableFederalMandateTypeList = new List<RefFacilityApplicableFederalMandateType>
        {
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("bc1123a6-502d-4233-97cd-df4e85de3ccb"), Code="02584", Description="Americans with Disabilities Act (ADA)", Definition="Public Law 101-336 which prohibits discrimination against individuals with disabilities as regards to employment, public accommodations and certain public services. Also known as Americans with Disabilities Act (ADA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("5e04dbe7-2732-4977-9807-65a62d25aff7"), Code="02588", Description="Asbestos Hazardous Emergency Response Act (AHERA)", Definition="Asbestos Hazardous Emergency Response Act (AHERA) is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("d1facf01-9325-498b-a247-aba9d824adc7"), Code="02585", Description="Individuals with Disabilities Education Act (IDEA)", Definition="Public Law 105-17 is designed to insure that all children with disabilities have available to them a free appropriate public education. Public Law. (Formerly called Education of the Handicapped Act P.L. 91-230.) Also known as Individuals with Disabilities Education Act (IDEA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("b6b9644b-9272-47cb-8755-a8c3e64cb26e"), Code="02587", Description="Lead Contamination Control Act", Definition="Lead Contamination Control Act is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("761909af-5e53-4c5e-9984-b256be009eb7"), Code="02586", Description="Safe Drinking Water Act", Definition="Safe Drinking Water Act is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a3ca329e-d29f-42a5-968c-1213d35c1689"), Code="09999", Description="Other", Definition="Other is specified as the particular federal law, regulation, or standard that pertains to a school facility.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilityApplicableFederalMandateType Pick List
         /// </summary>
        public static List<RefFacilityApplicableFederalMandateType> RefFacilityApplicableFederalMandateTypePickList = new List<RefFacilityApplicableFederalMandateType>
        {
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("bc1123a6-502d-4233-97cd-df4e85de3ccb"), Code="02584", Description="Americans with Disabilities Act (ADA)", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("5e04dbe7-2732-4977-9807-65a62d25aff7"), Code="02588", Description="Asbestos Hazardous Emergency Response Act (AHERA)", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("d1facf01-9325-498b-a247-aba9d824adc7"), Code="02585", Description="Individuals with Disabilities Education Act (IDEA)", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("b6b9644b-9272-47cb-8755-a8c3e64cb26e"), Code="02587", Description="Lead Contamination Control Act", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("761909af-5e53-4c5e-9984-b256be009eb7"), Code="02586", Description="Safe Drinking Water Act", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilityApplicableFederalMandateType { Id=Guid.Parse("a3ca329e-d29f-42a5-968c-1213d35c1689"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
