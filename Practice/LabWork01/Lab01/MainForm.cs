using System.Windows.Forms;

namespace Lab01
{
  public partial class MainForm : Form
  {
    private List<Student> _list;

    public MainForm()
    {
      InitializeComponent();
      _list = new List<Student>();
    }

    private void loadToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        string[] lines = File.ReadAllLines(@"students.txt");
        // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
        // COOKUS,XUAN ,3 ,107,52,FAFARD,ROCIO
        foreach (string line in lines)
        {
          string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
          //richTextBox1.Text += line + Environment.NewLine;
          Student student = new Student()
          {
            StLastName = data[0],
            StFirstName = data[1],
            Grade = int.Parse(data[2]),
            Classroom = int.Parse(data[3]),
            Bus = int.Parse(data[4]),
            TLastName = data[5],
            TFirstName = data[6]
          };
          _list.Add(student);
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        throw;
      }
      statusStrip1.Items[1].Text = _list.Count.ToString();
    }

    private void task1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      tbResult.Text = "";
      int count = 0;
      foreach (var item in _list)
      {
        var StudentSurname = tbSurname.Text.Trim();
        if (item.StLastName == StudentSurname)
        {
          tbResult.Text += item.ToStringStudentClassTeacher();
          count++;
        }
        if(count > 10)
          break;
      }
    }
  }
}