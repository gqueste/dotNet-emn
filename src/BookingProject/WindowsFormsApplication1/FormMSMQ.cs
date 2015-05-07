using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_Commandes;
using System.Messaging;

namespace WindowsFormsApplication1
{
    public partial class FormMSMQ : Form
    {
        public FormMSMQ()
        {
            InitializeComponent();
        }

        private bool reservation(int volID, int hotelID, DateTime date, String nomUtilisateur)
        {
            bool ret = true;
            clsCommandes myCommandes = new clsCommandes();
            try
            {
                myCommandes.reserveVol(volID, date, nomUtilisateur);
                myCommandes.reserveHotel(hotelID, date, nomUtilisateur);
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

        private void btnLireTransfert_Click(object sender, EventArgs e)
        {
            //ouverture de la file MSMQ
            MessageQueue MyMQ = new MessageQueue(@".\private$\flightBooking");
            //récupération sans vider la file d'un message, de type TransfertInfo
            MyMQ.Formatter = new XmlMessageFormatter(new Type[] { typeof(ReservationInfo) });

            var message = (ReservationInfo)MyMQ.Peek().Body;

            //Tranfert en mode transactionnel
            bool ResT = reservation(message.ID_VOL, message.ID_HOTEL, message.DATE, message.NOM_UTILISATEUR);


            //Transaction OK
            if (ResT == true)
            {
                tbMessages.AppendText("Réservation du vol " + message.ID_VOL + " et de l'hotel " + message.ID_HOTEL + " à la date " + message.DATE + " pour " + message.NOM_UTILISATEUR + "\n");
                //Zone critique : le Receive devrait être sous forme de composant lui aussi dans le serveu d'application
                MyMQ.Receive();
            }
            //Transaction KO
            else
            {
                tbMessages.AppendText("Impossible de réserver le vol " + message.ID_VOL + " et de l'hotel " + message.ID_HOTEL + " à la date " + message.DATE + " pour " + message.NOM_UTILISATEUR + "\n");
            }
            MyMQ.Close();

        }


    }
}
