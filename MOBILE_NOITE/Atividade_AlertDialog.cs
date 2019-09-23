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
    [Activity(Label = "Atividade_AlertDialog", MainLauncher = false, Icon = "@drawable/PROJETO")]
    public class Atividade_AlertDialog : Activity
    {
        Button btPermissao;
        EditText nome;
        TextView mostra;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Atividade_AlertDialog);
            // Create your application here

            //Campo texto
            nome = FindViewById<EditText>(Resource.Id.CampoNome);

            //Pegar o botao
            btPermissao = FindViewById<Button>(Resource.Id.btPermissao);

            //Pegar Text
            mostra = FindViewById<TextView>(Resource.Id.mostraPerm);
          
            //Evento
            btPermissao.Click += BtPermissao_Click;
        }

        //Evento
        private void BtPermissao_Click(object sender, EventArgs e)
        {
            AlertDialog.Builder alerta = new AlertDialog.Builder(this);

            // Titulo
            alerta.SetTitle("Titulo");
            //Icone
            alerta.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            //Mensagem
            alerta.SetMessage("Deseja mostra");

            //Alerta Positivo
            alerta.SetPositiveButton("YES", (senderAlert, arg)=>{
                // .Text pegar o valo ou atribui
                mostra.Text = nome.Text;
            });
            alerta.SetNegativeButton("NO", (senderAlert , args) => {
                Toast.MakeText(this,"Não Mostrar",ToastLength.Short).Show();
                //nome.Text = "";
                nome.Text = String.Empty;
            });
            alerta.Show();
           
        }
    }
}