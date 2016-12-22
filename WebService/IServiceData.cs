using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IServiceData" в коде и файле конфигурации.
    [ServiceContract]
    public interface IServiceData
    {
        [OperationContract]
        void AddStudent(int id, string name, DateTime date);

        [OperationContract]
        int AddNumber(int first, int second);

        [OperationContract]
        List<Student> GetStudents();

        [OperationContract]
        void DeleteStudent(Student stud);
    }
}
