using RPD.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

using System.Windows.Forms;


namespace RPD
{
    class Serializer
    {
        string path_teachers = "../../Resources/save_teachers.json";
        string path_competence = "../../Resources/save_competence.json";
        string path_discipline = "../../Resources/save_discipline.json";
        //возвращает список объектов класса Discipline из файла save_discipline.json
        public List<Discipline> Deserialize_List_discipline()
        {
            try
            {
                using (FileStream fileStream = new FileStream(path_discipline, FileMode.Open))
                {
                    List<Discipline> d_list = JsonSerializer.Deserialize<List<Discipline>>(fileStream);
                    return d_list;
                }
            }
            catch (FileNotFoundException e)
            {
                List<Discipline> d_list = new List<Discipline>();
                return d_list;
            }
        }
        //перезаписывает список объектов класса Discipline в файл save_discipline.json
        public void Serialize_list_discipline(List<Discipline> d)
        {
            string json = JsonSerializer.Serialize(d);
            try
            {
                using (FileStream fileStream = new FileStream(path_discipline, FileMode.Truncate))
                {
                    JsonSerializer.Serialize(fileStream, d);
                }
            }
            catch (FileNotFoundException e)
            {
                using (FileStream fileStream = new FileStream(path_discipline, FileMode.CreateNew))
                {
                    JsonSerializer.Serialize(fileStream, d);
                }
            }
        }

        //возвращает список объектов класса Teachers из файла save_teachers.json
        public List<Teachers> Deserialize_List_teachers()
        {
            try
            {
                using (FileStream fileStream = new FileStream(path_teachers, FileMode.Open))
                {
                    List<Teachers> t_list = JsonSerializer.Deserialize<List<Teachers>>(fileStream);
                    return t_list;
                }
            }
            catch (FileNotFoundException e)
            {
                List<Teachers> t_list = new List<Teachers>();
                return t_list;
            }
        }

        //перезаписывает список объектов класса Teachers в файл save_teachers.json
        public void Serialize_list_teachers(List<Teachers> t)
        {
            string json = JsonSerializer.Serialize(t);
            try
            {
                using (FileStream fileStream = new FileStream(path_teachers, FileMode.Truncate))
                {
                    JsonSerializer.Serialize(fileStream, t);
                }
            }
            catch (FileNotFoundException)
            {
                using (FileStream fileStream = new FileStream(path_teachers, FileMode.CreateNew))
                {
                    JsonSerializer.Serialize(fileStream, t);
                }
            }
        }

        public List<Competence> Deserialize_List_competence()
        {
            //try
            //{
                using (FileStream fileStream = new FileStream(path_competence, FileMode.Open))
                {
                    List<Competence> c_list = JsonSerializer.Deserialize<List<Competence>>(fileStream);
                    return c_list;
                }
            //}
            //catch (FileNotFoundException e)
            //{
            //    List<Competence> c_list = new List<Competence>();
            //    return c_list;
            //}
        }

        //перезаписывает список объектов класса Teachers в файл save_teachers.json
        public void Serialize_list_competence(List<Competence> c)
        {
            string json = JsonSerializer.Serialize(c);
            try
            {
                using (FileStream fileStream = new FileStream(path_competence, FileMode.Truncate))
                {
                    JsonSerializer.Serialize(fileStream, c);
                }
            }
            catch (FileNotFoundException e)
            {
                using (FileStream fileStream = new FileStream(path_competence, FileMode.CreateNew))
                {
                    JsonSerializer.Serialize(fileStream, c);
                }
            }
        }

    }
}
