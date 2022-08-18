//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonCareerEducationPlanView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PersonCareerEducationPlanView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonCareerEducationPlanView : ContentPage
    {
        /// <summary>
        /// Inject the IPersonCareerEducationPlan View Model as the data context for the view
        /// </summary>
        public PersonCareerEducationPlanView(Interfaces.IPersonCareerEducationPlan vm)
        {
            BindingContext  = vm;
        }
    }
}
