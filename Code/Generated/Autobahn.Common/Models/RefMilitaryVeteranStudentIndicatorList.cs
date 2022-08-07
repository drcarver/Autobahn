//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryVeteranStudentIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryVeteranStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryVeteranStudentIndicatorModel"> List
         /// </summary>
        public static List<RefMilitaryVeteranStudentIndicatorModel> RefMilitaryVeteranStudentIndicatorList = new List<RefMilitaryVeteranStudentIndicatorModel>
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("f8b16c22-b091-48ad-92de-8fc653947ce2"), Code="NotVeteran", Description="Not a Veteran", Definition="Student is not a veteran of the military.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("a9f51893-d9f6-49af-9e33-e702a0b1fcb8"), Code="Veteran", Description="Veteran", Definition="Student is a Veteran of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("2a7e4c49-4ce9-44ce-a813-b82a955a236b"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is a veteran of the military.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefMilitaryVeteranStudentIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMilitaryVeteranStudentIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("f8b16c22-b091-48ad-92de-8fc653947ce2"), Description="Not a Veteran", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("a9f51893-d9f6-49af-9e33-e702a0b1fcb8"), Description="Veteran", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryVeteranStudentIndicator { Id=Guid.Parse("2a7e4c49-4ce9-44ce-a813-b82a955a236b"), Description="Unknown", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
