using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork01
{
  internal class Student
  {
    public string StLastName { get; set; } = string.Empty;
    public string StFirstName { get; set; } = string.Empty;
    public int Grade { get; set; }
    public int Classroom { get; set; }
    public int Bus { get; set; }
    public string TLastName { get; set; } = string.Empty;
    public string TFirstName { get; set; } = string.Empty;

    public override string ToString()
    {
      return $"Студент: {StLastName} {StFirstName}, Клас: {Classroom}, Викладач: {TLastName} {TFirstName}\n";
    }
  }

}
