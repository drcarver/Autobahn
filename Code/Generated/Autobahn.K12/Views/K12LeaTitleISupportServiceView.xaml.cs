//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceView.cs
//**********************************************************

namespace Autobahn.K12.Views
{
     /// <summary>
     /// The K12LeaTitleISupportServiceView
     /// </summary>
     [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K12LeaTitleISupportServiceView : ContentPage
    {
        /// <summary>
        /// Inject the IK12LeaTitleISupportService View Model as the data context for the view
        /// </summary>
        public K12LeaTitleISupportServiceView(Interfaces.IK12LeaTitleISupportService vm)
        {
            BindingContext  = vm;
        }
    }
}
