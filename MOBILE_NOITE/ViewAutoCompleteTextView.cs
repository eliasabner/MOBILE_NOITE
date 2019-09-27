using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MOBILE_NOITE
{
    
    [Activity(Label = "ViewAutoCompleteTextView")]
    public class ViewAutoCompleteTextView : Activity
    {
        static string[] estado = new string[] {"Acre", "Alagoas","Amapa","Amazonas","Bahia","Ceara"};
        AutoCompleteTextView AutoC;
        static ArrayAdapter<string> adaptador;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ViewAutoCompleteTextView);

            AutoC = FindViewById<AutoCompleteTextView>(Resource.Id.estado);
            adaptador = new ArrayAdapter<string>(this,Android.Resource.Layout.SimpleListItem1,estado);

            AutoC.Adapter = adaptador;

            //Evento AutoCompleteView

            AutoC.ItemSelected += AutoC_ItemSelected;
        }

        private void AutoC_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            
        }
    }
}