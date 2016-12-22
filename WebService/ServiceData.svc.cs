using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "ServiceData" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы ServiceData.svc или ServiceData.svc.cs в обозревателе решений и начните отладку.
    public class ServiceData : IServiceData
    {
        public int AddNumber(int first, int second)
        {
            return first + second;
        }

        public void AddStudent(int id, string name, DateTime date)
        {
            using (ConnectDB connect = new ConnectDB())
            {
                connect.Students.Add(new Student { Id = 1, Name = name, Date = date });
                connect.SaveChanges();
            }
        }

        public List<Student> GetStudents()
        {
            List<Student> list = new List<Student>();
            using (ConnectDB connect = new ConnectDB())
            {
                list = connect.Students.Where(x => x.Name.Length > 0).ToList();
            }
            int count = 1;
            foreach (var l in list)
            {
                l.Id = count;
                count++;
            }
            return list;
        }

        public void DeleteStudent(Student stud)
        {
            List<Student> list = new List<Student>();
            using (ConnectDB connect = new ConnectDB())
            {
                connect.Students.Attach(stud);
                connect.Students.Remove(stud);
                connect.SaveChanges();
                list = connect.Students.Where(x => x.Name.Length > 0).ToList();
            }
            int count = 1;
            foreach (var l in list)
            {
                l.Id = count;
                count++;
            }
        }
    }
}
