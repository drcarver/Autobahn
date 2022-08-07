//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMilitaryActiveStudentIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMilitaryActiveStudentIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMilitaryActiveStudentIndicatorModel"> List
         /// </summary>
        public static List<RefMilitaryActiveStudentIndicatorModel> RefMilitaryActiveStudentIndicatorList = new List<RefMilitaryActiveStudentIndicatorModel>
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("73b34876-e4b9-4cb8-9d35-3a1e6577d2a0"), Code="NotActive", Description="Not Active", Definition="Student is not active in the military.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("a3694d5b-9fdb-4449-ac7b-39a23a9a03a6"), Code="Active", Description="Active", Definition="Student is an Active member of the Active Duty Forces, National Guard, or Reserve Forces.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("7328d239-6026-4d8f-a387-37713469d0b2"), Code="Unknown", Description="Unknown", Definition="It is unknown whether or not the Student is active in the military.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefMilitaryActiveStudentIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMilitaryActiveStudentIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("73b34876-e4b9-4cb8-9d35-3a1e6577d2a0"), Description="Not Active", SortOrder=Convert.ToDecimal("1.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("a3694d5b-9fdb-4449-ac7b-39a23a9a03a6"), Description="Active", SortOrder=Convert.ToDecimal("3.00") },
            new RefMilitaryActiveStudentIndicator { Id=Guid.Parse("7328d239-6026-4d8f-a387-37713469d0b2"), Description="Unknown", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
