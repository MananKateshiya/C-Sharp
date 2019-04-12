using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace MyApp
{
    public partial class Email : UserControl
    {

        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;


        public Email()
        {
            InitializeComponent();
        }

        private void send_Click(object sender, EventArgs e)
        {
        
            login = new NetworkCredential(uname.Text, passwd.Text);
            client = new SmtpClient(smtp.Text);
            client.Port = Convert.ToInt32(port.Text);
            client.EnableSsl = ssl.Checked;
            client.Credentials = login;

            msg = new MailMessage { From = new MailAddress(uname.Text + smtp.Text.Replace("smtp.", "@"), "Manan", Encoding.UTF8) };
            msg.To.Add(new MailAddress(to.Text));

            if (!string.IsNullOrEmpty(cc.Text))
                msg.To.Add(new MailAddress(cc.Text));
            msg.Subject = subject.Text;
            msg.Body = message.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending...";
            client.SendAsync(msg, userstate);
        }

        private static void SendCompletedCallback(Object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled) 
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1} ", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email Sent Successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
