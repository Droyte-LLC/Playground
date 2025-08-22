public class TestCamp : ITest
{
  public string PubString { get; set; } = string.Empty;
  private string PriString { get; set; } = string.Empty;
  protected string ProString { get; set; } = string.Empty;
  internal string IntString { get; set; } = string.Empty;
  protected internal string ProIntString { get; set; } = string.Empty;

  internal void CheckMyAccess()
  {

  }
}

public class TestCamp2 : TestCamp
{
  TestCamp2()
  {
    IntString = "";
    ProIntString = "";
    ProString = "";
    ProIntString = "";
  }

  public void MyMethod()
  {
    CheckMyAccess();
  }
}

public class UserService
{
    private readonly IEmailSender Sender;

  public UserService(IEmailSender sender)
  {
    Sender = sender;
  }

  public void RegisterUser(User1 user)
  {
    //register logic
    //send email
    EmailSender sender = new EmailSender();
    sender.SendEmail("Welcome to our platform");
  }
}

public class User1
{
  public string UserName { get; set; }
  public string Email { get; set; }
}

public interface IEmailSender
{
  void SendEmail(string message);
}

public class EmailSender : IEmailSender
{
  public void SendEmail(string message)
  {

  }
}
