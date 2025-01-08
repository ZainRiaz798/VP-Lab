using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace StudentProgressTracker
{
    public partial class MainWindow : Window
    {
        // Correctly declare the connection string
         string connectionString = @"Data Source=ZAIN-RIAZ\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True";

        public ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Students = new ObservableCollection<Student>
            {
                new Student { Name = "Ahmed", Grade = "A", Subject = "Math", Marks = 92, Attendance = 95 },
                new Student { Name = "Fatima", Grade = "A", Subject = "Science", Marks = 89, Attendance = 88 },
                new Student { Name = "Hassan", Grade = "B", Subject = "English", Marks = 76, Attendance = 82 },
                new Student { Name = "Ayesha", Grade = "A", Subject = "Biology", Marks = 91, Attendance = 87 },
                new Student { Name = "Zain", Grade = "C", Subject = "History", Marks = 68, Attendance = 75 },
                new Student { Name = "Maryam", Grade = "B", Subject = "Chemistry", Marks = 83, Attendance = 86 },
                new Student { Name = "Usman", Grade = "A", Subject = "Physics", Marks = 90, Attendance = 92 },
                new Student { Name = "Sana", Grade = "A", Subject = "Math", Marks = 94, Attendance = 89 },
                new Student { Name = "Ali", Grade = "B", Subject = "Geography", Marks = 81, Attendance = 84 },
                new Student { Name = "Hina", Grade = "A", Subject = "Science", Marks = 87, Attendance = 90 },
                new Student { Name = "Ibrahim", Grade = "C", Subject = "English", Marks = 65, Attendance = 78 },
                new Student { Name = "Noor", Grade = "A", Subject = "Biology", Marks = 92, Attendance = 93 },
                new Student { Name = "Saad", Grade = "B", Subject = "History", Marks = 79, Attendance = 81 },
                new Student { Name = "Zara", Grade = "A", Subject = "Chemistry", Marks = 96, Attendance = 88 },
                new Student { Name = "Bilal", Grade = "D", Subject = "Physics", Marks = 80, Attendance = 85 },
                new Student { Name = "Amina", Grade = "A", Subject = "Math", Marks = 93, Attendance = 90 },
                new Student { Name = "Raza", Grade = "C", Subject = "Geography", Marks = 72, Attendance = 76 },
                new Student { Name = "Mariam", Grade = "B", Subject = "Science", Marks = 84, Attendance = 87 },
                new Student { Name = "Yasir", Grade = "D", Subject = "English", Marks = 90, Attendance = 91 },


            };

            DataContext = this;

            GradeFilter.ItemsSource = Students.Select(s => s.Grade).Distinct().ToList();
            SubjectFilter.ItemsSource = Students.Select(s => s.Subject).Distinct().ToList();
        }

        private void GradeFilter_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedGrade = GradeFilter.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedGrade))
            {
                StudentDataGrid.ItemsSource = Students.Where(s => s.Grade == selectedGrade).ToList();
            }
            else
            {
                StudentDataGrid.ItemsSource = Students;
            }
        }

        private void SubjectFilter_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            string selectedSubject = SubjectFilter.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedSubject))
            {
                StudentDataGrid.ItemsSource = Students.Where(s => s.Subject == selectedSubject).ToList();
            }
            else
            {
                StudentDataGrid.ItemsSource = Students;
            }
        }

        private void AddStudent_Click(object sender, RoutedEventArgs e)
        {
            var newStudent = new Student { Name = "New Student", Grade = "C", Subject = "History", Marks = 60, Attendance = 70 };
            Students.Add(newStudent);
            MessageBox.Show("Student Added!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void EditStudent_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                selectedStudent.Name = "Updated Name";
                MessageBox.Show("Student Updated!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void DeleteStudent_Click(object sender, RoutedEventArgs e)
        {
            if (StudentDataGrid.SelectedItem is Student selectedStudent)
            {
                Students.Remove(selectedStudent);
                MessageBox.Show("Student Deleted!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private async Task SaveDataAsync()
        {
            TaskProgressBar.Visibility = Visibility.Visible;
            await Task.Run(() => { /* Simulate saving data */ Task.Delay(2000).Wait(); });
            TaskProgressBar.Visibility = Visibility.Hidden;
            MessageBox.Show("Data Saved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set { name = value; OnPropertyChanged(nameof(Name)); }
        }

        private string grade;
        public string Grade
        {
            get => grade;
            set { grade = value; OnPropertyChanged(nameof(Grade)); }
        }

        private string subject;
        public string Subject
        {
            get => subject;
            set { subject = value; OnPropertyChanged(nameof(Subject)); }
        }

        private int marks;
        public int Marks
        {
            get => marks;
            set { marks = value; OnPropertyChanged(nameof(Marks)); }
        }

        private int attendance;
        public int Attendance
        {
            get => attendance;
            set { attendance = value; OnPropertyChanged(nameof(Attendance)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
