//**********************************************************
//* DomainName: Common Models
//* FileName:   PDActivityEducationLevelView.cs
//**********************************************************

namespace Autobahn.Common.Views
{
     /// <summary>
     /// The PDActivityEducationLevelView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PDActivityEducationLevelView : ContentPage
    {
        /// <summary>
        /// Inject the IPDActivityEducationLevel View Model as the data context for the view
        /// </summary>
        public PDActivityEducationLevelView(Interfaces.IPDActivityEducationLevel vm)
        {
            BindingContext  = vm;
        }
    }
}