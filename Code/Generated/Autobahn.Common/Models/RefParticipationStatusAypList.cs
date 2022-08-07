//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefParticipationStatusAypList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefParticipationStatusAyp Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefParticipationStatusAypModel"> List
         /// </summary>
        public static List<RefParticipationStatusAypModel> RefParticipationStatusAypList = new List<RefParticipationStatusAypModel>
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("54856504-2eb6-41ed-8ad3-57a64f2ccfd6"), Code="Met", Description="Met 95%", Definition="The school or district met the 95 percent participation requirement.", SortOrder=Convert.ToDecimal("1.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("c56f846c-5589-4384-8e46-e8259abd4c20"), Code="DidNotMeet", Description="Did not Meet 95%", Definition="The school or district did NOT meet the 95 percent participation requirement.", SortOrder=Convert.ToDecimal("2.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("73a69d5d-4a68-4480-9cbe-5805904b6ae3"), Code="TooFewStudents", Description="Too Few Students for Reliability", Definition="There were too Few Students for Reliability.", SortOrder=Convert.ToDecimal("3.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("58bf18e3-365a-4f6e-9b76-f578c70580fd"), Code="NoStudents", Description="No Students in the subgroup", Definition="There were no Students in the subgroup.", SortOrder=Convert.ToDecimal("4.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("be8ac3e5-5943-4acc-b23c-4fb42870334b"), Code="NA", Description="Not applicable", Definition="The 95 percent participation status does Not apply.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefParticipationStatusAyp Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefParticipationStatusAypViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefParticipationStatusAyp { Id=Guid.Parse("54856504-2eb6-41ed-8ad3-57a64f2ccfd6"), Description="Met 95%", SortOrder=Convert.ToDecimal("1.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("c56f846c-5589-4384-8e46-e8259abd4c20"), Description="Did not Meet 95%", SortOrder=Convert.ToDecimal("2.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("73a69d5d-4a68-4480-9cbe-5805904b6ae3"), Description="Too Few Students for Reliability", SortOrder=Convert.ToDecimal("3.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("58bf18e3-365a-4f6e-9b76-f578c70580fd"), Description="No Students in the subgroup", SortOrder=Convert.ToDecimal("4.00") },
            new RefParticipationStatusAyp { Id=Guid.Parse("be8ac3e5-5943-4acc-b23c-4fb42870334b"), Description="Not applicable", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
