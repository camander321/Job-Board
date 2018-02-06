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
    private bool _posted = true;

    public JobOpening(string title, string desc, string company, string startDate, string salary)
    {
      _title = title;
      _description = desc;
      _company = company;
      _startDate = startDate;
      _salary = salary;
      _id = _instances.Count;

      if (_title.Length == 0 || _description.Length == 0 || _company.Length == 0 || _startDate.Length == 0 || _salary.Length == 0)
      {
        _posted = false;
        return;
      }

      foreach (JobOpening job in _instances)
      {
        if (_title == job._title && _description == job._description && _company == job._company && _startDate == job._startDate && _salary == job._salary)
        {
          _posted = false;
          return;
        }
      }




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

    public int GetId()
    {
      return _id;
    }

    public bool GetIsPosted()
    {
      return _posted;
    }

    public static JobOpening Find(int id)
    {
      return _instances[id];
    }

    public static List<JobOpening> GetAll()
    {
      return _instances;
    }


  }
}
