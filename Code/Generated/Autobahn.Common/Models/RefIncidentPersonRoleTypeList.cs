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
        public static List<RefIncidentPersonRoleType> RefIncidentPersonRoleTypeList = new List<RefIncidentPersonRoleType> =
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("ef289c14-0925-4cf3-a922-df67b78dccc6"), Code="Victim is the role or type of participation of the person in the discipline incident.", Description="Victim", Definition="", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("4c05aa04-76c7-4158-8179-b281dfa4b9f7"), Code="Perpetrator is the role or type of participation of the person in the discipline incident.", Description="Perpetrator", Definition="", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("f89d2976-233f-4d03-b2ef-b9681487a098"), Code="Witness is the role or type of participation of the person in the discipline incident.", Description="Witness", Definition="", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("ebf49020-97e0-4cde-8abc-7dd07ba17eb6"), Code="Reporter is the role or type of participation of the person in the discipline incident.", Description="Reporter", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefIncidentPersonRoleType Pick List
         /// </summary>
        public static List<RefIncidentPersonRoleType> RefIncidentPersonRoleTypePickList = new List<RefIncidentPersonRoleType> =
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("ef289c14-0925-4cf3-a922-df67b78dccc6"), Code="Victim is the role or type of participation of the person in the discipline incident.", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("4c05aa04-76c7-4158-8179-b281dfa4b9f7"), Code="Perpetrator is the role or type of participation of the person in the discipline incident.", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("f89d2976-233f-4d03-b2ef-b9681487a098"), Code="Witness is the role or type of participation of the person in the discipline incident.", SortOrder=0 },
            new RefIncidentPersonRoleType { Id=Guid.Parse("ebf49020-97e0-4cde-8abc-7dd07ba17eb6"), Code="Reporter is the role or type of participation of the person in the discipline incident.", SortOrder=0 },
       };
   }
}
