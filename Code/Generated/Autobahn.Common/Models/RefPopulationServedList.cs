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
        public static List<RefPopulationServed> RefPopulationServedList = new List<RefPopulationServed> =
        {
            new RefPopulationServed { Id=Guid.Parse("d97e094d-985e-4bf7-919f-aa62361ecf04"), Code="The program provides services to meet the needs of English language learners.", Description="ELL", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("400a0096-dde9-41fc-9c36-2c87254ff25c"), Code="The program provides services to meet the needs of children with disabilities.", Description="CWD", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("6e61f8fb-1adc-4e05-ad98-84b5927a1705"), Code="The program provides services to meet the needs of homeless.", Description="Homeless", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("5c50be01-2a09-4825-a36c-286ac725024a"), Code="The program provides mental health services.", Description="MentalHealth", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("77a2a93a-ed8e-46f4-aa81-0c183bd2c262"), Code="The program provides services to meet the needs of learners with special health needs.", Description="SpecialHealthNeeds", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("4278a5c7-9030-4c77-91b0-8d256fe60d99"), Code="The program provides services to meet the needs of foster children and families.", Description="Foster", Definition="", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("79f79877-accb-45ba-b6f8-cae7ae2bdda4"), Code="The program provides services to meet the needs of learners in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPopulationServed Pick List
         /// </summary>
        public static List<RefPopulationServed> RefPopulationServedPickList = new List<RefPopulationServed> =
        {
            new RefPopulationServed { Id=Guid.Parse("d97e094d-985e-4bf7-919f-aa62361ecf04"), Code="The program provides services to meet the needs of English language learners.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("400a0096-dde9-41fc-9c36-2c87254ff25c"), Code="The program provides services to meet the needs of children with disabilities.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("6e61f8fb-1adc-4e05-ad98-84b5927a1705"), Code="The program provides services to meet the needs of homeless.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("5c50be01-2a09-4825-a36c-286ac725024a"), Code="The program provides mental health services.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("77a2a93a-ed8e-46f4-aa81-0c183bd2c262"), Code="The program provides services to meet the needs of learners with special health needs.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("4278a5c7-9030-4c77-91b0-8d256fe60d99"), Code="The program provides services to meet the needs of foster children and families.", SortOrder=0 },
            new RefPopulationServed { Id=Guid.Parse("79f79877-accb-45ba-b6f8-cae7ae2bdda4"), Code="The program provides services to meet the needs of learners in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
