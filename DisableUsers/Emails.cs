using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DisableUsers
{
    public class Emails
    {
        string messagebody15day { get; set; } 
        public Emails() 
        {
            messagebody15day = "";

            
        }
        public void FifteenDayEmails(MailMessage message)
        {
            message.BodyEncoding = Encoding.UTF8;
            message.IsBodyHtml= true;               
        }

    }
}




//using System.Net;  
//using System.Net.Mail;  


//string to = " "; //To address    
//string from = ""; //From address    
//MailMessage message = new MailMessage(from, to);

//string mailbody = "In this article you will learn how to send a email using Asp.Net & C#";
//message.Subject = "Sending Email Using Asp.Net & C#";
//message.Body = mailbody;
//message.BodyEncoding = Encoding.UTF8;
//message.IsBodyHtml = true;
//SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp    
//System.Net.NetworkCredential basicCredential1 = new
//System.Net.NetworkCredential("yourmail id", "Password");
//client.EnableSsl = true;
//client.UseDefaultCredentials = false;
//client.Credentials = basicCredential1;
//try
//{
//    client.Send(message);
//}

//catch (Exception ex)
//{
//    throw ex;
//}