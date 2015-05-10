using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using lib_Commandes;

namespace LireMSMQ
{
    public partial class FormLireMSMQ : Form
    {
        public FormLireMSMQ()
        {
            InitializeComponent();
        }

        private bool Reservation(String idVol, String idHotel, String date, String nomUtilisateur)
        {
            bool ret = true;

            clsCommandes myC = new clsCommandes();

            try
            {
                myC.reservation(Convert.ToInt32(idVol), Convert.ToInt16(idHotel), Convert.ToDateTime(date), Convert.ToString(nomUtilisateur));          
            }
            catch (SystemException error)
            {
                ret = false;
            }
            finally
            {
            }
            return ret;
        }


        private void btnLireMSMQ_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\flightBooking");
            //récupération sans vider la file d'un message, de type TransfertInfo          
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(ReservationInfo) });

            var message = (ReservationInfo)MyMQ.Peek().Body;

            //Tranfert en mode transactionnel
            bool ResT = Reservation(message.ID_VOL, message.ID_HOTEL, message.DATE, message.NOM_UTILISATEUR);


            //Transaction OK
            if (ResT == true)
            {
                textBoxMessages.AppendText("Reservation du vol " + message.ID_VOL + " et de l'hotel " + message.ID_HOTEL + " à la date " + message.DATE + " pour : " + message.NOM_UTILISATEUR + "\n");
                //Zone critique : le Receive devrait être sous forme de composant lui aussi dans le serveu d'application
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                textBoxMessages.AppendText("Impossible de réserver le vol " + message.ID_VOL + " et l'hotel " + message.ID_HOTEL + " à la date " + message.DATE + " pour : " + message.NOM_UTILISATEUR + "\n");
            }
            MyMQ.Close();

        }

        private void btnCreationMSMQ_Click(object sender, EventArgs e)
        {
            clsCommandes clsC = new clsCommandes();
            clsC.reservation(10,20, DateTime.Now, "Joris");
        }
    }
}
