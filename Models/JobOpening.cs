using System.Collections.Generic;

namespace JobBoard.Models
{
  public class JobOpening
  {
    private static List<JobOpening> _instances = new List<JobOpening>{};

    private int _id;
    private string _title;
    private string _description;
    private string _company;
    private string _startDate;
    private string _salary;

    public JobOpening(string title, string desc, string company, string startDate, string salary)
    {
      _title = title;
      _description = desc;
      _company = company;
      _startDate = startDate;
      _salary = salary;

      _id = _instances.Count;
      _instances.Add(this);
    }

    public void SetTitle(string title)
    {
      _title = title;
    }

    public string GetTitle()
    {
      return _title;
    }


    public void SetDescription(string description)
    {
      _description = description;
    }

    public string GetDescription()
    {
      return _description;
    }


    public void SetCompany(string company)
    {
      _company = company;
    }

    public string GetCompany()
    {
      return _company;
    }

    public void SetStartDate(string startDate)
    {
      _startDate = startDate;
    }

    public string GetStartDate()
    {
      return _startDate;
    }


    public void SetSalary(string salary)
    {
      _salary = salary;
    }

    public string GetSalary()
    {
      return _salary;
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }
  }
}
