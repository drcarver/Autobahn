//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsEnrollmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsEnrollmentTypeModel"> List
         /// </summary>
        public static List<RefPsEnrollmentTypeModel> RefPsEnrollmentTypeList = new List<RefPsEnrollmentTypeModel>
        {
            new RefPsEnrollmentType { Id=Guid.Parse("8e6f1511-88f5-4143-b480-e129ccceef51"), Code="FirstTime", Description="First time at institution, non-transfer in", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: First time at institution, non-transfer in.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("9e393150-7018-4078-a957-f695c87d165d"), Code="Continuing", Description="Continuing", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Continuing.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("0c48caa9-159a-4465-901f-559efc6bc540"), Code="Re-admit", Description="Re-admit", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Re-admit.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("6e6377bb-cb54-47d1-992b-7041bcf71dee"), Code="TransferIn", Description="Transfer in", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Transfer in.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefPsEnrollmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefPsEnrollmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefPsEnrollmentType { Id=Guid.Parse("8e6f1511-88f5-4143-b480-e129ccceef51"), Description="First time at institution, non-transfer in", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("9e393150-7018-4078-a957-f695c87d165d"), Description="Continuing", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("0c48caa9-159a-4465-901f-559efc6bc540"), Description="Re-admit", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("6e6377bb-cb54-47d1-992b-7041bcf71dee"), Description="Transfer in", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
