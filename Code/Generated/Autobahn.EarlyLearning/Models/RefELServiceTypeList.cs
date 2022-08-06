//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELServiceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELServiceType"> List
         /// </summary>
        public static List<RefELServiceType> RefELServiceTypeList = new List<RefELServiceType> =
        {
            new RefELServiceType { Id=Guid.Parse("4b29fd05-b35c-44e3-b95f-c235efa8e2f5"), Code="Mental health is the type of service provided to a child.", Description="MentalHealth", Definition="", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("5faa45d6-5ccb-4d43-866f-78597f927c64"), Code="Nutritional is the type of service provided to a child.", Description="Nutritional", Definition="", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("4ea0b20c-7f57-449f-84c0-eae2eee9945e"), Code="Educational is the type of service provided to a child.", Description="Educational", Definition="", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("b1cebc53-143b-49c4-a1b9-77717476295f"), Code="Physical rehabilitation", Description="PhysicalRehabilitation", Definition="", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("8d5dacf5-26b5-4b7e-9b10-d6d7f9ad70da"), Code="Dental Health is the type of service provided to a child.", Description="DentalHealth", Definition="", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("30cf5869-e658-4393-abad-580f65d32ce2"), Code="The type of service provided to a child is in a category not yet defined in CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefELServiceType Pick List
         /// </summary>
        public static List<RefELServiceType> RefELServiceTypePickList = new List<RefELServiceType> =
        {
            new RefELServiceType { Id=Guid.Parse("4b29fd05-b35c-44e3-b95f-c235efa8e2f5"), Code="Mental health is the type of service provided to a child.", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("5faa45d6-5ccb-4d43-866f-78597f927c64"), Code="Nutritional is the type of service provided to a child.", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("4ea0b20c-7f57-449f-84c0-eae2eee9945e"), Code="Educational is the type of service provided to a child.", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("b1cebc53-143b-49c4-a1b9-77717476295f"), Code="Physical rehabilitation", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("8d5dacf5-26b5-4b7e-9b10-d6d7f9ad70da"), Code="Dental Health is the type of service provided to a child.", SortOrder=0 },
            new RefELServiceType { Id=Guid.Parse("30cf5869-e658-4393-abad-580f65d32ce2"), Code="The type of service provided to a child is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
