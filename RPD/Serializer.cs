using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace RPD_1
{
    class Serializer
    {

        public void Serialize(Discipline disc)
        {
            string json = JsonSerializer.Serialize(disc);

            using (FileStream fileStream = new FileStream("save.json", FileMode.Append))
            {
                JsonSerializer.Serialize(fileStream, disc);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine();
                streamWriter.Close();
            }
        } //запись в файл одного объекта Discipline
        public void Serialize(Teachers t)
        {
            string json = JsonSerializer.Serialize(t);

            using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Append))
            {
                JsonSerializer.Serialize(fileStream, t);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine();
                streamWriter.Close();
            }
        }

        public List<Discipline> Deserialize()
        {

            using (StreamReader streamReader = new StreamReader("save.json"))
            {
                string str;
                List<Discipline> disc_list = new List<Discipline>();
                while ((str = streamReader.ReadLine()) != null)
                {
                    Discipline disc = JsonSerializer.Deserialize<Discipline>(str);
                    disc_list.Add(disc);
                }
                streamReader.Close();
                return disc_list;
            }
        } //возвращает список с объектави Discipline
        public List<Teachers> Deserialize_teachers()
        {

            using (StreamReader streamReader = new StreamReader("save_teachers.json"))
            {
                string str;
                List<Teachers> t_list = new List<Teachers>();
                while ((str = streamReader.ReadLine()) != null)
                {
                    Teachers t = JsonSerializer.Deserialize<Teachers>(str);
                    t_list.Add(t);
                }
                streamReader.Close();
                return t_list;
            }
        }

        public List<Teachers> Deserialize_List_teachers()
        {
            using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Open))
            {
                List<Teachers> t_list = JsonSerializer.Deserialize<List<Teachers>>(fileStream);
                return t_list;
            }
        }

        public void Serialize_list_teachers(List<Teachers> t)
        {
            string json = JsonSerializer.Serialize(t);

            using (FileStream fileStream = new FileStream("save_teachers.json", FileMode.Truncate))
            {
                JsonSerializer.Serialize(fileStream, t);
            }
        }

        public void Update(List<Discipline> lst)
        {
            using (FileStream fileStream = new FileStream("save.json", FileMode.Open, FileAccess.ReadWrite))
            {
                fileStream.SetLength(0);
            } //очистка файла "save"
            foreach (Discipline d in lst)
            {
                Serialize(d);
            } // запись в файл обновлненных значений из списка
        }
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
