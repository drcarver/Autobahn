//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIncidentPersonRoleTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIncidentPersonRoleType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIncidentPersonRoleTypeModel"> List
         /// </summary>
        public static List<RefIncidentPersonRoleTypeModel> RefIncidentPersonRoleTypeList = new List<RefIncidentPersonRoleTypeModel>
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("4b6e648b-f8f4-43a3-a346-38a7b596b07a"), Code="Victim", Description="Victim", Definition="Victim is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("adfc1b4e-37cd-4624-81ed-eb41eda5fe04"), Code="Perpetrator", Description="Perpetrator", Definition="Perpetrator is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("83d598d1-7b83-4ab3-bd35-54d771b3fd54"), Code="Witness", Description="Witness", Definition="Witness is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("c6b39d6e-2baf-4604-b965-ba06b0e204a3"), Code="Reporter", Description="Reporter", Definition="Reporter is the role or type of participation of the person in the discipline incident.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefIncidentPersonRoleType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIncidentPersonRoleTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIncidentPersonRoleType { Id=Guid.Parse("4b6e648b-f8f4-43a3-a346-38a7b596b07a"), Description="Victim", SortOrder=Convert.ToDecimal("1.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("adfc1b4e-37cd-4624-81ed-eb41eda5fe04"), Description="Perpetrator", SortOrder=Convert.ToDecimal("3.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("83d598d1-7b83-4ab3-bd35-54d771b3fd54"), Description="Witness", SortOrder=Convert.ToDecimal("5.00") },
            new RefIncidentPersonRoleType { Id=Guid.Parse("c6b39d6e-2baf-4604-b965-ba06b0e204a3"), Description="Reporter", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
