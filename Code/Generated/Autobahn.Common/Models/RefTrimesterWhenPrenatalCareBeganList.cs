//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTrimesterWhenPrenatalCareBeganList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTrimesterWhenPrenatalCareBegan Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTrimesterWhenPrenatalCareBeganModel"> List
         /// </summary>
        public static List<RefTrimesterWhenPrenatalCareBeganModel> RefTrimesterWhenPrenatalCareBeganList = new List<RefTrimesterWhenPrenatalCareBeganModel>
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("82fe1c85-4b6a-486a-90bb-1175d35bc811"), Code="FirstTrimester", Description="First trimester", Definition="The  child's mother began receiving prenatal health care in the first trimester.", SortOrder=Convert.ToDecimal("1.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("aa3d0a07-c9d0-4ce4-8e5b-5069a01e5957"), Code="SecondTrimester", Description="Second trimester", Definition="The  child's mother began receiving prenatal health care in the second trimester.", SortOrder=Convert.ToDecimal("3.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("f4dc30eb-7f8f-460b-82c3-bcd53a4d68a0"), Code="ThirdTrimester", Description="Third trimester", Definition="The  child's mother began receiving prenatal health care in the third trimester.", SortOrder=Convert.ToDecimal("5.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a2020aa6-b8d1-4e30-b812-ab8aad0c3032"), Code="NoPrenatalHealthCare", Description="No prenatal health care", Definition="The  child's mother did not receive prenatal health care.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefTrimesterWhenPrenatalCareBegan Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTrimesterWhenPrenatalCareBeganViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("82fe1c85-4b6a-486a-90bb-1175d35bc811"), Description="First trimester", SortOrder=Convert.ToDecimal("1.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("aa3d0a07-c9d0-4ce4-8e5b-5069a01e5957"), Description="Second trimester", SortOrder=Convert.ToDecimal("3.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("f4dc30eb-7f8f-460b-82c3-bcd53a4d68a0"), Description="Third trimester", SortOrder=Convert.ToDecimal("5.00") },
            new RefTrimesterWhenPrenatalCareBegan { Id=Guid.Parse("a2020aa6-b8d1-4e30-b812-ab8aad0c3032"), Description="No prenatal health care", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
