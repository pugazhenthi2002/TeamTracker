using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LiveCharts;
using LiveCharts.Wpf;
using TeamTracker;
using UserInterface.ViewPage;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("pugazhenthiir2002@gmail.com");
                message.To.Add(new MailAddress("pugazhenthiir@gmail.com"));
                message.Subject = "Test";
                message.IsBodyHtml = true; //to make message body as html
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("pugazhenthiir2002@gmail.com", "rewc jrha npss hrev");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());
            }
        }
    }
}
