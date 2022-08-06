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
        public static List<RefDisciplineReason> RefDisciplineReasonList = new List<RefDisciplineReason>
        {
            new RefDisciplineReason { Id=Guid.Parse("a6ab218e-3de6-4014-9306-06087339a64c"), Code="DrugRelated", Description="Illicit drug related", Definition="Illicit drug related is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineReason { Id=Guid.Parse("2cffc78a-66dc-487b-9d6f-00326c2fa0bc"), Code="AlcoholRelated", Description="Alcohol related", Definition="Alcohol related is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineReason { Id=Guid.Parse("96c23d54-4beb-4387-904e-bd35f4a74b42"), Code="WeaponsPossession", Description="Weapons possession", Definition="Weapons possession is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineReason { Id=Guid.Parse("82bc3357-dc7b-4555-ae67-11eda218da91"), Code="WithPhysicalInjury", Description="Violent Incident (with Physical Injury)", Definition="Violent Incident (with Physical Injury) is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineReason { Id=Guid.Parse("ed76b452-b8d0-4b47-8bae-691b675b2fd7"), Code="WithoutPhysicalInjury", Description="Violent Incident (without Physical Injury)", Definition="Violent Incident (without Physical Injury) is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineReason { Id=Guid.Parse("ef6901af-44dc-49b7-9aaa-e85b3afe133f"), Code="Other", Description="Other reasons for out of school suspensions related to drug use and violence", Definition="Other reasons for out of school suspensions related to drug use and violence is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The RefDisciplineReason Pick List
         /// </summary>
        public static List<RefDisciplineReason> RefDisciplineReasonPickList = new List<RefDisciplineReason>
        {
            new RefDisciplineReason { Id=Guid.Parse("a6ab218e-3de6-4014-9306-06087339a64c"), Code="DrugRelated", Description="Illicit drug related", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineReason { Id=Guid.Parse("2cffc78a-66dc-487b-9d6f-00326c2fa0bc"), Code="AlcoholRelated", Description="Alcohol related", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineReason { Id=Guid.Parse("96c23d54-4beb-4387-904e-bd35f4a74b42"), Code="WeaponsPossession", Description="Weapons possession", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineReason { Id=Guid.Parse("82bc3357-dc7b-4555-ae67-11eda218da91"), Code="WithPhysicalInjury", Description="Violent Incident (with Physical Injury)", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineReason { Id=Guid.Parse("ed76b452-b8d0-4b47-8bae-691b675b2fd7"), Code="WithoutPhysicalInjury", Description="Violent Incident (without Physical Injury)", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineReason { Id=Guid.Parse("ef6901af-44dc-49b7-9aaa-e85b3afe133f"), Code="Other", Description="Other reasons for out of school suspensions related to drug use and violence", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
