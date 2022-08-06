//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityType"> List
         /// </summary>
        public static List<RefPDActivityType> RefPDActivityTypeList = new List<RefPDActivityType> =
        {
            new RefPDActivityType { Id=Guid.Parse("f57b72a0-3e32-4775-b2a2-81578bed6b55"), Code="The type of professional development activity is a College Course.", Description="CollegeCourse", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("ed4807c1-4711-486f-af37-6e95cbe86053"), Code="The type of professional development activity is Coaching.", Description="Coaching", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("379a58ae-9ef4-4db3-9654-e1363b160d6a"), Code="The type of professional development activity is Mentoring.", Description="Mentoring", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("421492a5-0d5b-4373-b369-b11c66225bf1"), Code="The type of professional development activity is Consultation.", Description="Consultation", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("882d3b1b-df3a-4e8f-bf0b-7b173f8c4906"), Code="The type of professional development activity is Person-to-Person.", Description="P2P", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("955d351a-cdae-4c1d-8ed5-81e233ec4aa4"), Code="The type of professional development activity is Technical Assistance.", Description="TechnicalAssistance", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("356d7ded-87b6-45a9-ba37-cbd1aef0e5ca"), Code="The type of professional development activity is Advisement.", Description="Advisement", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("f0588bea-1b49-4d7b-9e0e-38f9dd1d2987"), Code="The type of professional development activity is One-time Workshop Training.", Description="OneTimeWorkshopTraining", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("68070151-bbe7-4eee-bc79-528fa63bb999"), Code="The type of professional development activity is Series of Workshops Training.", Description="SeriesOfWorkshopsTraining", Definition="", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("9be61da0-23e8-4802-86fa-9c9a6f17d554"), Code="The type of professional development activity is in a category not yet defined by CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPDActivityType Pick List
         /// </summary>
        public static List<RefPDActivityType> RefPDActivityTypePickList = new List<RefPDActivityType> =
        {
            new RefPDActivityType { Id=Guid.Parse("f57b72a0-3e32-4775-b2a2-81578bed6b55"), Code="The type of professional development activity is a College Course.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("ed4807c1-4711-486f-af37-6e95cbe86053"), Code="The type of professional development activity is Coaching.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("379a58ae-9ef4-4db3-9654-e1363b160d6a"), Code="The type of professional development activity is Mentoring.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("421492a5-0d5b-4373-b369-b11c66225bf1"), Code="The type of professional development activity is Consultation.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("882d3b1b-df3a-4e8f-bf0b-7b173f8c4906"), Code="The type of professional development activity is Person-to-Person.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("955d351a-cdae-4c1d-8ed5-81e233ec4aa4"), Code="The type of professional development activity is Technical Assistance.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("356d7ded-87b6-45a9-ba37-cbd1aef0e5ca"), Code="The type of professional development activity is Advisement.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("f0588bea-1b49-4d7b-9e0e-38f9dd1d2987"), Code="The type of professional development activity is One-time Workshop Training.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("68070151-bbe7-4eee-bc79-528fa63bb999"), Code="The type of professional development activity is Series of Workshops Training.", SortOrder=0 },
            new RefPDActivityType { Id=Guid.Parse("9be61da0-23e8-4802-86fa-9c9a6f17d554"), Code="The type of professional development activity is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
