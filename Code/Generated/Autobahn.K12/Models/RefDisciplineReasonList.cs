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
        /// The complete <see cref="RefDisciplineReasonModel"> List
         /// </summary>
        public static List<RefDisciplineReasonModel> RefDisciplineReasonList = new List<RefDisciplineReasonModel>
        {
            new RefDisciplineReason { Id=Guid.Parse("92b75dc8-fbe9-492b-904e-ae6c834630c3"), Code="DrugRelated", Description="Illicit drug related", Definition="Illicit drug related is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineReason { Id=Guid.Parse("fa829e12-2e26-4875-8348-69dd177d2129"), Code="AlcoholRelated", Description="Alcohol related", Definition="Alcohol related is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineReason { Id=Guid.Parse("ce716fcb-33c2-4ab6-8ac4-8cf4bba5bc25"), Code="WeaponsPossession", Description="Weapons possession", Definition="Weapons possession is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineReason { Id=Guid.Parse("04d6584c-0e7a-4778-b565-d51f76020460"), Code="WithPhysicalInjury", Description="Violent Incident (with Physical Injury)", Definition="Violent Incident (with Physical Injury) is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineReason { Id=Guid.Parse("0c7e8bba-d790-49c2-8acf-122b78969d54"), Code="WithoutPhysicalInjury", Description="Violent Incident (without Physical Injury)", Definition="Violent Incident (without Physical Injury) is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineReason { Id=Guid.Parse("511a8a7c-d658-436f-858d-fcc86c525f86"), Code="Other", Description="Other reasons for out of school suspensions related to drug use and violence", Definition="Other reasons for out of school suspensions related to drug use and violence is the reason why the student was disciplined.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefDisciplineReason Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisciplineReasonViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisciplineReason { Id=Guid.Parse("92b75dc8-fbe9-492b-904e-ae6c834630c3"), Description="Illicit drug related", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisciplineReason { Id=Guid.Parse("fa829e12-2e26-4875-8348-69dd177d2129"), Description="Alcohol related", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisciplineReason { Id=Guid.Parse("ce716fcb-33c2-4ab6-8ac4-8cf4bba5bc25"), Description="Weapons possession", SortOrder=Convert.ToDecimal("3.00") },
            new RefDisciplineReason { Id=Guid.Parse("04d6584c-0e7a-4778-b565-d51f76020460"), Description="Violent Incident (with Physical Injury)", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisciplineReason { Id=Guid.Parse("0c7e8bba-d790-49c2-8acf-122b78969d54"), Description="Violent Incident (without Physical Injury)", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisciplineReason { Id=Guid.Parse("511a8a7c-d658-436f-858d-fcc86c525f86"), Description="Other reasons for out of school suspensions related to drug use and violence", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
