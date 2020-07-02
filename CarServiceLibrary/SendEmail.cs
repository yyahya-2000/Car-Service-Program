using System;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.ComponentModel;
using System.Windows.Forms;


namespace CarServiceLibrary
{
    //this delegate help to callback some methods at SendOrder form.
    public delegate void Del();

    /// <summary>
    /// class sending an email
    /// </summary>
    public class SendEmail
    {
        /*
        * variables help in sending an email
        */
        Del del;
        DataGridView order;
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;
        string userName, password, message, receiver, subject, smtp;
        int port;
        bool ssl;

        //constrocter (the names of the variables represent their function)
        public SendEmail(string userName, string password, string message, string receiver,
        string subject, string smtp, int port, bool ssl, DataGridView grid)
        {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.receiver = receiver;
            this.subject = subject;
            this.smtp = smtp;
            this.port = port;
            this.ssl = ssl;
            this.order = grid;
        }

        /// <summary>
        /// the main process of sending an email
        /// </summary>
        public void Send(Del del)
        {
            this.del = del;
            try
            {
                /*
                * you can know the function of every class or property by turning the mouse cursour over the code.
                */
                login = new NetworkCredential(userName, password);//get login and password
                client = new SmtpClient(smtp, port);//initialization for SmtpClient class which sends email (smtp: smtp server)
                client.EnableSsl = ssl;
                client.Credentials = login;
                msg = new MailMessage { From = new MailAddress(userName + smtp.Replace("smtp.", "@"), "Car Service", Encoding.UTF8) };
                msg.To.Add(new MailAddress(receiver));
                msg.Body = message + "\n\n" + GetTabaleOrders();
                msg.Subject = subject;
                msg.BodyEncoding = Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.Priority = MailPriority.Normal;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
                string userstate = "sending....";
                client.SendAsync(msg, userstate);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show($"Sorry you have forgot to fill some information please check it!!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            /// <summary>
            /// creating a order table to send it in readable form.
            /// </summary>
            string GetTabaleOrders()
            {
                string tableOrders = "<table width='100%' style='border:Solid 1px Black;'>";
                tableOrders += "<tr>" + "<td stlye='color:blue;'>" + "Tool Name" + "</td>" + "<td stlye='color:blue;'>" +
                "Tool Unit" + "</td>" + "<td stlye='color:blue;'>" + "Quantity" + "</td>" + "<td stlye='color:blue;'>"
                + "Note" + "</td>" + "<tr>";
                foreach (DataGridViewRow row in order.Rows)
                {
                    tableOrders += "<tr>";
                    for (int i = 0; i < 5; i++)
                    {
                        if (i != 2)
                            tableOrders += "<td stlye='color:blue;'>" + row.Cells[i].Value + "</td>";
                    }
                    tableOrders += "</tr>";
                }
                tableOrders += "</table>";
                return tableOrders;
            }

            //gives information about the result of sending an email.
            void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
            {
                if (e.Cancelled)
                    MessageBox.Show($"{e.UserState} send cancelled", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (e.Error != null)
                    MessageBox.Show($"Incorrect User Name or Password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    MessageBox.Show($"Your message has been seccessfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.del?.Invoke();
                }

            }

        }

    }
}