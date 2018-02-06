using System.Collections.Generic;

namespace JobBoard.Models
{
  public class Contact
  {
    private string _name;
    private string _email;
    private string _phone;

    public Contact(string name, string email, string phone)
    {
      _name = name;
      _email = email;
      _phone = phone;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public string GetEmail()
    {
      return _email;
    }

    public void SetEmail(string email)
    {
      _email = email;
    }

    public string GetPhone()
    {
      return _phone;
    }

    public void SetPhone(string phone)
    {
      _phone = phone;
    }
  }
}
