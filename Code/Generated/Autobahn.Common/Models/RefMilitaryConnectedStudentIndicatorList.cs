//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryConnectedStudentIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryConnectedStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryConnectedStudentIndicatorModel"> List
         /// </summary>
        public static List<RefMilitaryConnectedStudentIndicatorModel> RefMilitaryConnectedStudentIndicatorList = new List<RefMilitaryConnectedStudentIndicatorModel>
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("4962bee4-34b9-45b0-8515-a06dae11f7fc"), Code="NotMilitaryConnected", Description="Not Military Connected", Definition="Student is not military-connected.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("b170aad4-1f59-4990-9993-717051f5f9b2"), Code="ActiveDuty", Description="Active Duty", Definition="Student is a dependent of a member of the Active Duty Forces (full-time) Army, Navy, Air Force, Marine Corps, or Coast Guard or is a dependent of a member on Full-Time National Guard Duty.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("bcceb970-9a04-4c09-9cdc-2b14ce11797a"), Code="NationalGuardOrReserve", Description="National Guard Or Reserve", Definition="Student is a dependent of a member of the National Guard (not full-time duty) or Reserve Forces (Army, Navy, Air Force, Marine Corps, or Coast Guard).", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("b9a00446-0b74-4bbd-a5f5-eb11f13d6c60"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the student is military-connected.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefMilitaryConnectedStudentIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMilitaryConnectedStudentIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("4962bee4-34b9-45b0-8515-a06dae11f7fc"), Description="Not Military Connected", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("b170aad4-1f59-4990-9993-717051f5f9b2"), Description="Active Duty", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("bcceb970-9a04-4c09-9cdc-2b14ce11797a"), Description="National Guard Or Reserve", SortOrder=Convert.ToDecimal("5.00") },
            new RefMilitaryConnectedStudentIndicator { Id=Guid.Parse("b9a00446-0b74-4bbd-a5f5-eb11f13d6c60"), Description="Unknown", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
