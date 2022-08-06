//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentPersonRoleTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentPersonRoleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentPersonRoleType"> List
         /// </summary>
        public static List<RefIncidentPersonRoleType> RefIncidentPersonRoleTypeList = new List<RefIncidentPersonRoleType>
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("f83a0e70-5507-474f-9b3f-e711c7932704"), Code="Victim", Description="Victim", Definition="Victim is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("2fe3dae2-ca5a-4525-94fd-4530292639c7"), Code="Perpetrator", Description="Perpetrator", Definition="Perpetrator is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("39250c80-3311-4828-9ac0-073e4894c929"), Code="Witness", Description="Witness", Definition="Witness is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("8269c2e8-23fe-4cb3-9bb7-654583c08613"), Code="Reporter", Description="Reporter", Definition="Reporter is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefIncidentPersonRoleType Pick List
         /// </summary>
        public static List<RefIncidentPersonRoleType> RefIncidentPersonRoleTypePickList = new List<RefIncidentPersonRoleType>
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("f83a0e70-5507-474f-9b3f-e711c7932704"), Code="Victim", Description="Victim", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("2fe3dae2-ca5a-4525-94fd-4530292639c7"), Code="Perpetrator", Description="Perpetrator", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("39250c80-3311-4828-9ac0-073e4894c929"), Code="Witness", Description="Witness", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("8269c2e8-23fe-4cb3-9bb7-654583c08613"), Code="Reporter", Description="Reporter", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
