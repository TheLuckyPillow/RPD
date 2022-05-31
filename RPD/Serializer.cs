using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

using System.Windows.Forms;

namespace RPD_1
{
    class Serializer
    {

        public List<Discipline> Deserialize_List_discipline()
        {
            using (FileStream fileStream = new FileStream("save_discipline.json", FileMode.Open))
            {
                List<Discipline> d_list = JsonSerializer.Deserialize<List<Discipline>>(fileStream);
                return d_list;
            }


        } //возвращает список объектов класса Discipline из файла save_discipline.json

        public void Serialize_list_discipline(List<Discipline> d)
        {
            string json = JsonSerializer.Serialize(d);

            using (FileStream fileStream = new FileStream("save_discipline.json", FileMode.Truncate))
            {
                JsonSerializer.Serialize(fileStream, d);
            }
        } //перезаписывает список объектов класса Discipline в файл save_discipline.json

        public List<Teachers> Deserialize_List_teachers()
        {
            using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Open))
            {
                List<Teachers> t_list = JsonSerializer.Deserialize<List<Teachers>>(fileStream);
                return t_list;
            }
        } //возвращает список объектов класса Teachers из файла save_teachers.json

        public void Serialize_list_teachers(List<Teachers> t)
        {
            string json = JsonSerializer.Serialize(t);

            using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Truncate))
            {
                JsonSerializer.Serialize(fileStream, t);
            }
        } //перезаписывает список объектов класса Teachers в файл save_teachers.json

        //public void Update(List<Discipline> lst)
        //{
        //    using (FileStream fileStream = new FileStream("save.json", FileMode.Open, FileAccess.ReadWrite))
        //    {
        //        fileStream.SetLength(0);
        //    } //очистка файла "save"
        //    foreach (Discipline d in lst)
        //    {
        //        Serialize(d);
        //    } // запись в файл обновлненных значений из списка
        //}
        //public void Update(List<Teachers> lst)
        //{
        //    using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Open, FileAccess.ReadWrite))
        //    {
        //        fileStream.SetLength(0);
        //    } //очистка файла "save"
        //    foreach (Discipline d in lst)
        //    {
        //        Serialize(d);
        //    } // запись в файл обновлненных значений из списка
        //}
    }
}
