//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefDisciplineReasonList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefDisciplineReason Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisciplineReason"> List
         /// </summary>
        public static List<RefDisciplineReason> RefDisciplineReasonList = new List<RefDisciplineReason> =
        {
            new RefDisciplineReason { Id=Guid.Parse("99e26bf7-c544-4eba-ab9e-4211d27a9493"), Code="Illicit drug related is the reason why the student was disciplined.", Description="DrugRelated", Definition="", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("418ff867-1e2d-441c-9551-4efe6d047916"), Code="Alcohol related is the reason why the student was disciplined.", Description="AlcoholRelated", Definition="", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("cf158136-1fe8-43bd-a7a0-d8d1755131ec"), Code="Weapons possession is the reason why the student was disciplined.", Description="WeaponsPossession", Definition="", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("61262a37-eb9d-46ed-a232-b1748089c28a"), Code="Violent Incident (with Physical Injury) is the reason why the student was disciplined.", Description="WithPhysicalInjury", Definition="", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("7a9fa63e-3c91-4e55-867a-fb24030386da"), Code="Violent Incident (without Physical Injury) is the reason why the student was disciplined.", Description="WithoutPhysicalInjury", Definition="", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("4068e58c-59fd-4079-9f13-efd36be968ae"), Code="Other reasons for out of school suspensions related to drug use and violence is the reason why the student was disciplined.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefDisciplineReason Pick List
         /// </summary>
        public static List<RefDisciplineReason> RefDisciplineReasonPickList = new List<RefDisciplineReason> =
        {
            new RefDisciplineReason { Id=Guid.Parse("99e26bf7-c544-4eba-ab9e-4211d27a9493"), Code="Illicit drug related is the reason why the student was disciplined.", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("418ff867-1e2d-441c-9551-4efe6d047916"), Code="Alcohol related is the reason why the student was disciplined.", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("cf158136-1fe8-43bd-a7a0-d8d1755131ec"), Code="Weapons possession is the reason why the student was disciplined.", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("61262a37-eb9d-46ed-a232-b1748089c28a"), Code="Violent Incident (with Physical Injury) is the reason why the student was disciplined.", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("7a9fa63e-3c91-4e55-867a-fb24030386da"), Code="Violent Incident (without Physical Injury) is the reason why the student was disciplined.", SortOrder=0 },
            new RefDisciplineReason { Id=Guid.Parse("4068e58c-59fd-4079-9f13-efd36be968ae"), Code="Other reasons for out of school suspensions related to drug use and violence is the reason why the student was disciplined.", SortOrder=0 },
       };
   }
}
