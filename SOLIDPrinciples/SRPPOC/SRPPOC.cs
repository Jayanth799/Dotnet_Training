using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace SRPPOC
{
    public class Employee
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }
    }

    public class StaticDataOfEmployee
    {
        public static List<Employee> Employees { get; set; } = new List<Employee>();
    }

    public class EmployeeServices
    {
        public async Task RegisterEmployee(Employee employee)
        {
            StaticDataOfEmployee.Employees.Add(employee);
            EmailService emailService = new EmailService();
            await emailService.SendEmail(employee.Email,"Registaration", "Congratulation ! Your are successfully registered.");
        }
    }

    public class EmailService
    {
        public async Task SendEmail(string eMail, string subject, string message)
        {
            var emailMessage = new MimeMessage();
            emailMessage.From.Add(new MailboxAddress("jayanth Kumar", "jayanth.kundala@cognine.com"));
            emailMessage.To.Add(new MailboxAddress(string.Empty,eMail));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };
            using (SmtpClient smtpClient = new SmtpClient())
            {
                smtpClient.LocalDomain = "paathshaala.com";
                await smtpClient.ConnectAsync("smtp.relay.uri", 25, SecureSocketOptions.None).ConfigureAwait(false);
                await smtpClient.SendAsync(emailMessage).ConfigureAwait(false);
                await smtpClient.DisconnectAsync(true).ConfigureAwait(false); 
            }
        }
    }

    class SRPPOC
    {
        public static void Main()
        {
            Employee employee = new Employee()
            {
                FirstName = "veerababu",
                LastName = "Rallabandi",
                Email = "veerababu.rallabandi@cognine.com"
            };
            EmployeeServices employeeService = new EmployeeServices();
            employeeService.RegisterEmployee(employee).Wait();
            Console.ReadKey();
        }
    }
}

