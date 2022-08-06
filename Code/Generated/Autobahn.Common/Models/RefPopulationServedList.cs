//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPopulationServedList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPopulationServed Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPopulationServed"> List
         /// </summary>
        public static List<RefPopulationServed> RefPopulationServedList = new List<RefPopulationServed>
        {
            new RefPopulationServed { Id=Guid.Parse("031edcbf-aa5b-4848-96aa-921309608133"), Code="ELL", Description="English language learners", Definition="The program provides services to meet the needs of English language learners.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPopulationServed { Id=Guid.Parse("1657f833-4375-4427-bda7-342e1b1ce766"), Code="CWD", Description="Children with disabilities", Definition="The program provides services to meet the needs of children with disabilities.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPopulationServed { Id=Guid.Parse("040418bd-d70e-4076-9f16-2168f023a0a1"), Code="Homeless", Description="Homeless", Definition="The program provides services to meet the needs of homeless.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPopulationServed { Id=Guid.Parse("b647cf2f-ca99-4337-8000-623f15388eb2"), Code="MentalHealth", Description="Mental health", Definition="The program provides mental health services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefPopulationServed { Id=Guid.Parse("29a27fd6-e972-45e7-9407-eb9174db191f"), Code="SpecialHealthNeeds", Description="Special health needs", Definition="The program provides services to meet the needs of learners with special health needs.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPopulationServed { Id=Guid.Parse("27c606ea-8733-448a-924a-4bc75597cbc9"), Code="Foster", Description="Foster", Definition="The program provides services to meet the needs of foster children and families.", SortOrder=Convert.ToDecimal("7.00") },
            new RefPopulationServed { Id=Guid.Parse("2da2b994-7710-45cf-a6c1-b1cb89b587c3"), Code="Other", Description="Other", Definition="The program provides services to meet the needs of learners in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The RefPopulationServed Pick List
         /// </summary>
        public static List<RefPopulationServed> RefPopulationServedPickList = new List<RefPopulationServed>
        {
            new RefPopulationServed { Id=Guid.Parse("031edcbf-aa5b-4848-96aa-921309608133"), Code="ELL", Description="English language learners", SortOrder=Convert.ToDecimal("1.00") },
            new RefPopulationServed { Id=Guid.Parse("1657f833-4375-4427-bda7-342e1b1ce766"), Code="CWD", Description="Children with disabilities", SortOrder=Convert.ToDecimal("2.00") },
            new RefPopulationServed { Id=Guid.Parse("040418bd-d70e-4076-9f16-2168f023a0a1"), Code="Homeless", Description="Homeless", SortOrder=Convert.ToDecimal("4.00") },
            new RefPopulationServed { Id=Guid.Parse("b647cf2f-ca99-4337-8000-623f15388eb2"), Code="MentalHealth", Description="Mental health", SortOrder=Convert.ToDecimal("5.00") },
            new RefPopulationServed { Id=Guid.Parse("29a27fd6-e972-45e7-9407-eb9174db191f"), Code="SpecialHealthNeeds", Description="Special health needs", SortOrder=Convert.ToDecimal("6.00") },
            new RefPopulationServed { Id=Guid.Parse("27c606ea-8733-448a-924a-4bc75597cbc9"), Code="Foster", Description="Foster", SortOrder=Convert.ToDecimal("7.00") },
            new RefPopulationServed { Id=Guid.Parse("2da2b994-7710-45cf-a6c1-b1cb89b587c3"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
