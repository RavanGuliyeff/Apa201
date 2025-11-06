using SerializeDeserialize.Models;
using SerializeDeserialize.Services;

namespace SerializeDeserialize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ravan Guliyev\Desktop\Apa201\SerializeDeserialize\Data\Jsons\students.json";

            Directory.CreateDirectory(Path.GetDirectoryName(path));

            List<Student> students = new()
            {
                new Student { Name = "Sevda", Age = 20, Group = new Group { Name = "APA201" } },
                new Student { Name = "Rəşad", Age = 22, Group = new Group { Name = "APA202" } }
            };

            StudentService.WriteStudentsToFile(path, students);
            Console.WriteLine("İlkin tələbələr fayla yazıldı.");

            Student newStudent = new Student { Name = "Nihad", Age = 21, Group = new Group { Name = "BP201" } };
            StudentService.AddStudentToFile(path, newStudent);
            Console.WriteLine("Yeni tələbə əlavə olundu.");

            StudentService.RemoveStudentFromFile(path, "Rəşad");
            Console.WriteLine("Rəşad silindi.");

            Console.WriteLine("Bütün əməliyyatlar tamamlandı ");
        }
    }
    }
