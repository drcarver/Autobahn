//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   RefAuthorizerTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.AuthenticationandAuthorization.Models
{
     /// <summary>
     /// The list of RefAuthorizerType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAuthorizerTypeModel"> List
         /// </summary>
        public static List<RefAuthorizerTypeModel> RefAuthorizerTypeList = new List<RefAuthorizerTypeModel>
        {
            new RefAuthorizerType { Id=Guid.Parse("03fcc6d9-d3a2-46ee-9d8c-6dbb808cc445"), Code="LEARepresentative", Description="LEA Representative", Definition="LEA Representative is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("6f37d01c-148d-43e2-82b2-f7b5d9308539"), Code="OutsideAgencySupportRepresentative", Description="Outside Agency Support Representative", Definition="Outside Agency Support Representative is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("a76ba5bb-98fe-476d-aa1a-b3307df1a6b2"), Code="Parent/Guardian", Description="Parent/Guardian", Definition="Parent/Guardian is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("53642377-1b6b-49b4-94cc-c14522d30ad6"), Code="Staff", Description="Staff", Definition="Staff is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("e17f073c-109c-4bc4-9834-c75e5d2390a0"), Code="Student", Description="Student", Definition="Student is specified as the type of person who authorized the decision or document.", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefAuthorizerType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAuthorizerTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAuthorizerType { Id=Guid.Parse("03fcc6d9-d3a2-46ee-9d8c-6dbb808cc445"), Description="LEA Representative", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("6f37d01c-148d-43e2-82b2-f7b5d9308539"), Description="Outside Agency Support Representative", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("a76ba5bb-98fe-476d-aa1a-b3307df1a6b2"), Description="Parent/Guardian", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("53642377-1b6b-49b4-94cc-c14522d30ad6"), Description="Staff", SortOrder=Convert.ToDecimal("") },
            new RefAuthorizerType { Id=Guid.Parse("e17f073c-109c-4bc4-9834-c75e5d2390a0"), Description="Student", SortOrder=Convert.ToDecimal("") },
       };
   }
}
