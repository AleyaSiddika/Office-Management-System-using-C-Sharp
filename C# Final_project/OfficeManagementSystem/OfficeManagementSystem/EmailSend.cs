using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Speech.Synthesis;

namespace OfficeManagementSystem
{
    public partial class EmailSend : Form
    {
        public EmailSend()
        {
            InitializeComponent();
            textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminHome a1 = new AdminHome();
            a1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();

                message.From = new MailAddress(textBox2.Text);
                message.To.Add(new MailAddress(textBox1.Text));
                message.Subject = textBox3.Text;
                message.Body = richTextBox1.Text;
                /*message.From = new MailAddress("socket1socket@gmail.com");
                message.To.Add(new MailAddress("socket02socket@gmail.com"));
                message.Subject = "Test";
                message.Body = "Content";*/

                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(textBox1.Text, textBox4.Text);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);

                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10

               // MessageBox.Show("Email Send");
                synthesizer.SpeakAsync("Email Send");
                MessageBox.Show("Email Send");
            }
            catch (Exception ex)
            {
                /*SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10
                */
                // Synchronous
                // synthesizer.Speak("Well Come to Office Management System");

                // Asynchronous
               // synthesizer.SpeakAsync("Register Yourself");
              //  MessageBox.Show("err: " + ex.Message);
                SpeechSynthesizer synthesizer = new SpeechSynthesizer();
                synthesizer.Volume = 100;  // 0...100
                synthesizer.Rate = -2;     // -10...10
                synthesizer.SpeakAsync("err: " + ex.Message);
                MessageBox.Show("err: " + ex.Message);
            }
        }

       
    }
}