//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIPEDSFASBScholarshipsandFellowshipsRevenueList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIPEDSFASBScholarshipsandFellowshipsRevenue Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIPEDSFASBScholarshipsandFellowshipsRevenueModel"> List
         /// </summary>
        public static List<RefIPEDSFASBScholarshipsandFellowshipsRevenueModel> RefIPEDSFASBScholarshipsandFellowshipsRevenueList = new List<RefIPEDSFASBScholarshipsandFellowshipsRevenueModel>
        {
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("31b1b6fb-cdeb-4e59-ad70-8f96e3663ff8"), Code="Discountsallowancesappliedtoauxiliary", Description="Discounts and allowances applied to auxiliary enterprise revenues", Definition="The amount of allowances (scholarships) applied to auxiliary enterprise revenues (e.g., dormitory charges).", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("52dcdc22-9447-45b5-8fd5-6047136caae1"), Code="Discountsallowancesappliedtotuitionfees", Description="Discounts and allowances applied to tuition and fees", Definition="The amount of allowances (scholarships) applied to tuition and fees.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("3a25696e-1812-4f6d-b8ff-d3855c5cc786"), Code="Grantsbylocalgovernment", Description="Grants by local government", Definition="Local government grants include scholarships or gift-aid awarded directly to the student.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("385d2f2c-9a42-45cd-8992-144afeffc54d"), Code="Grantsbystategovernment", Description="Grants by state government", Definition="Grant monies provided by the state such as Leveraging Educational Assistance Partnerships (LEAP) (formerly SSIG's); merit scholarships provided by the state; and tuition and fee waivers for which the institution was reimbursed by a state agency.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("7b03150d-8759-4d5f-beec-c618cb572d67"), Code="Institutionalgrantsrestricted", Description="Institutional grants (restricted)", Definition="Scholarships and fellowships awarded to students from institutional resources that are restricted to student aid. Private institutions generally report these grants as allowances. If control over these resources passes to the student, the amount is reported as an expense.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("e22c55cb-2c6b-403c-b2ca-6bc914b3fd9f"), Code="Institutionalgrantsunrestricted", Description="Institutional grants (unrestricted)", Definition="Scholarships and fellowships awarded to students from unrestricted institutional resources. Private institutions generally report these grants as allowances. If control over these resources passes to the student, the amount is reported as an expense.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("db37826d-4201-4cfb-82a9-d000762da406"), Code="Otherfederalgrants", Description="Other federal grants", Definition="Federal monies awarded to the institution under federal government student aid programs, such as the Federal Supplemental Educational Opportunity Grants (FSEOG), DHHS training grants (aid portion only), the Leveraging Education Assistance Partnership (LEAP) program, and other federal student aid programs. Pell Grants are not included in this classification. Note: if the federal government selects the student recipients and simply transmits the funds to the institution for disbursement to the student, the amounts are not considered as revenues and subsequently there are no discounts and allowances or scholarships and fellowships expenses. If the funds are made available to the institution for selection of student recipients, then the amounts received are considered as nonoperating revenues and subsequently as discounts and allowances or scholarships and fellowships expenses.", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("5ad3a978-4b73-4d6c-b7e4-0a469279a04a"), Code="Pellgrants", Description="Pell grants", Definition="The gross amount of Pell Grants made available to recipients by your institution. This is the gross Pell Grants received as federal grant revenue for the fiscal year.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefIPEDSFASBScholarshipsandFellowshipsRevenue Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIPEDSFASBScholarshipsandFellowshipsRevenueViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("31b1b6fb-cdeb-4e59-ad70-8f96e3663ff8"), Description="Discounts and allowances applied to auxiliary enterprise revenues", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("52dcdc22-9447-45b5-8fd5-6047136caae1"), Description="Discounts and allowances applied to tuition and fees", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("3a25696e-1812-4f6d-b8ff-d3855c5cc786"), Description="Grants by local government", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("385d2f2c-9a42-45cd-8992-144afeffc54d"), Description="Grants by state government", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("7b03150d-8759-4d5f-beec-c618cb572d67"), Description="Institutional grants (restricted)", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("e22c55cb-2c6b-403c-b2ca-6bc914b3fd9f"), Description="Institutional grants (unrestricted)", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("db37826d-4201-4cfb-82a9-d000762da406"), Description="Other federal grants", SortOrder=Convert.ToDecimal("") },
            new RefIPEDSFASBScholarshipsandFellowshipsRevenue { Id=Guid.Parse("5ad3a978-4b73-4d6c-b7e4-0a469279a04a"), Description="Pell grants", SortOrder=Convert.ToDecimal("") },
       };
   }
}
