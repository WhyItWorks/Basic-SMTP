using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SMTP_Example
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string From = txtFrom.Text;
            string To = txtTo.Text;
            string Body = txtBody.Text;
            string Subject = "TEST";

            //Host info
            const string SMTP_USERNAME = "Your user name";
            const string SMTP_PASSWORD = "Your password";
            const string HOST = "Your host";
            const int PORT = 0;

            SmtpClient Client = new SmtpClient(HOST, PORT);
            Client.Credentials = new System.Net.NetworkCredential(SMTP_USERNAME, SMTP_PASSWORD);
            Client.EnableSsl = true;
            Client.Send(From, To, Subject, Body);                                               

            //You can use HTML in the body 
        }
    }
}
