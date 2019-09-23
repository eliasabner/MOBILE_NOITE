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
    [Activity(Label = "ViewsRadioButtons",MainLauncher = true)]
    public class ViewsRadioButtons : Activity
    {
        RadioButton rdbPhp;
        RadioButton rdbMysql;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Chamar xml
            SetContentView(Resource.Layout.ViewsRadioButton);
            //referencias
            rdbPhp = FindViewById<RadioButton>(Resource.Id.rD03);
            rdbMysql = FindViewById<RadioButton>(Resource.Id.rD04);

            // rdbPhp.Click += RdbPhp_Click;
            // rdbMysql.Click += RdbMysql_Click;

            rdbPhp.Click += rdPhpMysql;
            rdbMysql.Click += rdPhpMysql;
        }

        private void rdPhpMysql(object sender, EventArgs e)
        {
            if (rdbPhp.Checked == true)
            {
                Toast.MakeText(this, rdbPhp.Text, ToastLength.Short).Show();
            }
            if(rdbMysql.Checked == true)
            {
                Toast.MakeText(this, rdbMysql.Text, ToastLength.Short).Show();
            }
        }


        //RdpMysql
        private void RdbMysql_Click(object sender, EventArgs e)
        {
           if(rdbMysql.Checked == true)
            {
                Toast.MakeText(this, rdbMysql.Text, ToastLength.Short).Show();
            }
        }

        //rdpPhp
        private void RdbPhp_Click(object sender, EventArgs e)
        {
           if (rdbPhp.Checked == true)
            {
                Toast.MakeText(this,rdbPhp.Text,ToastLength.Short).Show();
            }
        }
    }
}