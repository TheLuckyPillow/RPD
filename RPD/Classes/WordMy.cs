using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace RPD.Classes
{
    class WordMy
    {
        private FileInfo _fileInfo;

        public WordMy(String fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName); //Название файла, путь, и т. д. (Шаблон_РПД_2021.docx)
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool CreateDoc(Dictionary<string, string> items) //Dict example — key: <DocumentName> value: "Название дисциплины 1"
        {
            Word.Application app = null; //Application
            try
            {
                Object missing = Type.Missing;
                Object filePath = _fileInfo.FullName; //Имя файла/путь к файлу

                app = new Word.Application();
                app.Documents.Open(filePath);

                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);
                }

                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("dd_MM_yyyy_") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();

                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if(app != null)
                {
                    app.Quit();
                }
            }
        }//TODO Важно! При запуске проекта создается папка Debug/Resources в которой создается копия Шаблона РПД, хотя файл шаблона лежит в ../../Resources/Шаблон_РПД_2021.docx и сохраняет туда же
        //Возможно косяк в том, что я добавил случайно папку ресурсес в проект с файлом Шаблона, но потом удалил
    }
}
