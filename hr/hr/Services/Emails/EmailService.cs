using hr.Absractions.Services.Emails;

namespace hr.Services.Emails
{
    public class EmailService : IEmailService
    {
        public void Send(string email, string name)
        {
            Console.WriteLine($"TO Email {email}: Wellcome to company {name}");
        }
    }
}
