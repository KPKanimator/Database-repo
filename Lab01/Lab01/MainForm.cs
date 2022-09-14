using System.Windows.Forms;

namespace Lab01
{
  public partial class MainForm : Form
  {
    private List<Student> Students;
    private readonly int ColumnCount;
    public MainForm()
    {
      InitializeComponent();
      Students = new List<Student>();
      ColumnCount = 7;
    }
    private void btnTask1_Click(object sender, EventArgs e)
    {
      string result = string.Empty;
      foreach (var item in Students)
      {
        if (item.StLastName == tbTask1.Text)
          result += string.Format($"Student: {item.StLastName} Classroom: {item.Classroom} {Environment.NewLine}");
      }
      richTextBox1.Text = result;
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        string[] lines = File.ReadAllLines(@"students.txt");
        // StLastName, StFirstName,Grade,Classroom,Bus,TLastName,TFirstName
        // COOKUS,XUAN,3,107,52,FAFARD,ROCIO
        foreach (string line in lines)
        {
          string[] data = line.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
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
          Students.Add(student);
        }
      }
      catch (Exception)
      {

        throw;
      }
    }
  }
}