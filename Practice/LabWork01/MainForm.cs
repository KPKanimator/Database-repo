using System.Diagnostics;

namespace LabWork01
{
  public partial class MainForm : Form
  {
    private List<Student> students;
    public MainForm()
    {
      InitializeComponent();
      students = new List<Student>();
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string filePath = "students.txt"; // шлях до файлу
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      try
      {
        using (StreamReader sr = new StreamReader(filePath))
        {
          string? line;
          while ((line = sr.ReadLine()) != null)
          {
            string[] parts = line.Split(new[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            // Перевірка кількості елементів
            if (parts.Length != 7)
            {
              MessageBox.Show($"Помилка у рядку: {line}", "Некоректний формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              continue;
            }
            try
            {
              Student record = new Student
              {
                StLastName = parts[0],
                StFirstName = parts[1],
                Grade = int.Parse(parts[2]),
                Classroom = int.Parse(parts[3]),
                Bus = int.Parse(parts[4]),
                TLastName = parts[5],
                TFirstName = parts[6]
              };

              students.Add(record);
            }
            catch (FormatException)
            {
              stopwatch.Reset();
              MessageBox.Show($"Помилка перетворення числових даних у рядку: {line}", "Помилка формату", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          }
        }
      }
      catch (Exception ex)
      {
        stopwatch.Reset();
        MessageBox.Show($"Помилка читання файлу: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally {
        stopwatch.Stop();
      }
      // Вивід у toolStripStatusLabel1
      toolStripStatusLabel1.Text = $"Зчитано {students.Count} записів за {stopwatch.ElapsedMilliseconds} мс";
      OutputBox.Clear();
      int counter = 0;
      foreach (var s in students)
      {
        if (counter++ == 20)
          break;
        OutputBox.Text += s;
      }
    }

    private void buttonTask1_Click(object sender, EventArgs e)
    {
      string searchLastName = textBoxTask1.Text.Trim();
      if (string.IsNullOrWhiteSpace(searchLastName))
      {
        MessageBox.Show("Введіть прізвище студента для пошуку.");
        return;
      }
      Stopwatch stopwatch = new Stopwatch();
      stopwatch.Start();
      var results = students
          .Where(s => s.StLastName.Equals(searchLastName, StringComparison.OrdinalIgnoreCase))
          .ToList();
      stopwatch.Stop();
      if (results.Count == 0)
      {
        MessageBox.Show("Студента з таким прізвищем не знайдено.");
      }
      else
      {
        OutputBox.Clear();
        int counter = 0;
        foreach (var s in results)
        {
          if(counter++ == 20) 
            break; 
          OutputBox.Text += s;
        }
      }

      toolStripStatusLabel1.Text = $"Знайдено {results.Count} записів. Пошук завершено за {stopwatch.ElapsedMilliseconds} мс";

    }
  }
}