namespace hr.Absractions.Services.Emails
{
    public interface IEmailService
    {
        public void Send(string email, string name);
    }
}
