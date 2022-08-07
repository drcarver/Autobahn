//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPopulationServedList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPopulationServed Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPopulationServedModel"> List
         /// </summary>
        public static List<RefPopulationServedModel> RefPopulationServedList = new List<RefPopulationServedModel>
        {
            new RefPopulationServed { Id=Guid.Parse("5ae3add0-549d-47b6-afbd-a82aece566f2"), Code="ELL", Description="English language learners", Definition="The program provides services to meet the needs of English language learners.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPopulationServed { Id=Guid.Parse("b1f64104-322b-4162-9889-0daa394bcc55"), Code="CWD", Description="Children with disabilities", Definition="The program provides services to meet the needs of children with disabilities.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPopulationServed { Id=Guid.Parse("2e89422d-940b-453f-9380-80ee7d9b582f"), Code="Homeless", Description="Homeless", Definition="The program provides services to meet the needs of homeless.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPopulationServed { Id=Guid.Parse("98c59d03-b858-495c-abb8-d95ad7cc72b0"), Code="MentalHealth", Description="Mental health", Definition="The program provides mental health services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPopulationServed { Id=Guid.Parse("6bb96e38-caae-4f31-823f-68fad013be88"), Code="SpecialHealthNeeds", Description="Special health needs", Definition="The program provides services to meet the needs of learners with special health needs.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPopulationServed { Id=Guid.Parse("7be0adb4-352e-4eaa-805d-7c9138bbc29e"), Code="Foster", Description="Foster", Definition="The program provides services to meet the needs of foster children and families.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPopulationServed { Id=Guid.Parse("6c84515f-198c-4b1a-b9d7-7ec7962a0b83"), Code="Other", Description="Other", Definition="The program provides services to meet the needs of learners in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefPopulationServed Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPopulationServedViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPopulationServed { Id=Guid.Parse("5ae3add0-549d-47b6-afbd-a82aece566f2"), Description="English language learners", SortOrder=Convert.ToDecimal("1.00") },
            new RefPopulationServed { Id=Guid.Parse("b1f64104-322b-4162-9889-0daa394bcc55"), Description="Children with disabilities", SortOrder=Convert.ToDecimal("2.00") },
            new RefPopulationServed { Id=Guid.Parse("2e89422d-940b-453f-9380-80ee7d9b582f"), Description="Homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefPopulationServed { Id=Guid.Parse("98c59d03-b858-495c-abb8-d95ad7cc72b0"), Description="Mental health", SortOrder=Convert.ToDecimal("5.00") },
            new RefPopulationServed { Id=Guid.Parse("6bb96e38-caae-4f31-823f-68fad013be88"), Description="Special health needs", SortOrder=Convert.ToDecimal("6.00") },
            new RefPopulationServed { Id=Guid.Parse("7be0adb4-352e-4eaa-805d-7c9138bbc29e"), Description="Foster", SortOrder=Convert.ToDecimal("7.00") },
            new RefPopulationServed { Id=Guid.Parse("6c84515f-198c-4b1a-b9d7-7ec7962a0b83"), Description="Other", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
