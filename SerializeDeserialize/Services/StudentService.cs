using Newtonsoft.Json;
using SerializeDeserialize.Models;

namespace SerializeDeserialize.Services;

public class StudentService
{
    public static void WriteStudentsToFile(string path, List<Student> students)
    {

        string json = JsonConvert.SerializeObject(students, Formatting.Indented);

        using (StreamWriter sw = new StreamWriter(path, false))
        {
            sw.Write(json);
        }
    }

    public static void AddStudentToFile(string path, Student student)
    {
        List<Student> students = new();


            using (StreamReader sr = new StreamReader(path))
            {
                string json = sr.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(json))
                    students = JsonConvert.DeserializeObject<List<Student>>(json);
            }
        

        students.Add(student);
        WriteStudentsToFile(path, students);
    }

    public static void RemoveStudentFromFile(string path, string studentName)
    {
        string json;
        using (StreamReader sr = new StreamReader(path))
        {
            json = sr.ReadToEnd();
        }

        if (string.IsNullOrWhiteSpace(json))
        {
            Console.WriteLine("Fayl boşdur.");
            return;
        }

        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(json);

        Student studentToRemove = students.Find(s => s.Name == studentName);
        if (studentToRemove == null)
        {
            Console.WriteLine("Bu adda tələbə tapılmadı.");
            return;
        }

        students.Remove(studentToRemove);
        WriteStudentsToFile(path, students);
    }
}
