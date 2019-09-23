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
    [Activity(Label = "WiewAlertDialog",MainLauncher = false,Icon ="@drawable/PROJETO")]
    public class WiewAlertDialog : Activity
    {
        Button btAlert, btToast,btYesNo;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            // super class

            base.OnCreate(savedInstanceState);
            //cs chamar xml
            SetContentView(Resource.Layout.WiewAlertDialog);
          

            //Pegar o botao toast
            btToast = FindViewById<Button>(Resource.Id.btToast);

            //Pegar o botao btAlert
            btAlert = FindViewById<Button>(Resource.Id.btAlert);
            //btYesNo
            btYesNo = FindViewById<Button>(Resource.Id.btAlertOkNo);


            //EVENTO do botton btToast
            btToast.Click += BtToast_Click;

            //EVENTO do botton btAlert
            btAlert.Click += BtAlert_Click;

            //EVENTO do botton btAlert
            btYesNo.Click += BtYesNo_Click; 



        }

        //BtToast evento btYesNO
        private void BtYesNo_Click(object sender, EventArgs e)
        {
            //Objeto
            AlertDialog.Builder alerta =new AlertDialog.Builder(this);
            //Titulo
            alerta.SetTitle("Yes NO");
            //icon
            alerta.SetIcon(Android.Resource.Drawable.IcLockIdleLock);
            //ms
            alerta.SetMessage("Mensagem");
            //evento

            //positivo
            alerta.SetPositiveButton("YES",(senderAlert,arg)=> { Toast.MakeText(this, "Clicou em   yes", ToastLength.Short).Show(); });

            //negativo
            alerta.SetNegativeButton("NO", (senderAlert, args) => { Toast.MakeText(this, "Clicou em no", ToastLength.Short).Show(); });

            //neutro
            alerta.SetNeutralButton("Neutro", (senderAlert, args) => { Toast.MakeText(this, "Clicou em no", ToastLength.Short).Show(); });
            //mostra
            alerta.Show();
        }

        //BtToast evento BtAlert
        private void BtAlert_Click(object sender, EventArgs e)
        {
            //Obejeto Alerta
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);
            //Titulo da caixa do alert
            alerta.SetTitle("Alerta");
            //Mensagem da caixa de Alerta
            alerta.SetMessage("Alerta de mensagem");
            //Icones
            alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);

            //Exibir
            alerta.Show();
        }

        //BtToast evento BtToast
        private void BtToast_Click(object sender, EventArgs e)
        {
            //Mensagem exibição em nuvem
            Toast.MakeText(this,"Alerta Mensagem",ToastLength.Long).Show();
        }
    }
}