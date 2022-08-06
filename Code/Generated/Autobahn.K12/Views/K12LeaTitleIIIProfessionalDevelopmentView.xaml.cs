//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentView.cs
//**********************************************************

using Autobahn.K12.ViewModels;

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaTitleIIIProfessionalDevelopmentView : ContentPage
    {
        /// <summary>
        /// Inject the K12LeaTitleIIIProfessionalDevelopmentViewModel as the data context for the view
        /// </summary>
        public K12LeaTitleIIIProfessionalDevelopmentView(K12LeaTitleIIIProfessionalDevelopmentViewModel vm)
        {
            BindingContext  = vm;
        }
    }
}
