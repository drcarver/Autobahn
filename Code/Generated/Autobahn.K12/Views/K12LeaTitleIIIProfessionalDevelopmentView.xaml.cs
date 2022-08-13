//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaTitleIIIProfessionalDevelopmentView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaTitleIIIProfessionalDevelopment View Model as the data context for the view
        /// </summary>
        public K12LeaTitleIIIProfessionalDevelopmentView(Interfaces.IK12LeaTitleIIIProfessionalDevelopment vm)
        {
            BindingContext  = vm;
        }
    }
}
