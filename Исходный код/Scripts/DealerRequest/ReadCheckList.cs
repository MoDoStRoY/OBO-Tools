using OBO_Tools.Scripts.DealerRequest;
using System;
using System.Collections.Generic;
using System.IO;

namespace OBO_Tools.Scripts
{
    class ReadCheckList
    {
        public static List<RowOfTicketObject> bufferedReaderTableCSV()
            //**ЧТЕНИЕ CSV ТАБЛИЦЫ**//
        {
            StreamReader reader = null;
            try { reader = new StreamReader(Program.user.pathToCheckList); }
            catch (Exception e) { }

            int y = 0;
            List<String> rowList = new List<String>();
            while (true)
            {
                rowList.Add(reader.ReadLine());

                if (String.IsNullOrEmpty(rowList[y]))
                {
                    rowList.RemoveAt(y);
                    break;
                }
                y++;
            }

            try { reader.Close(); }
            catch (Exception e) { }

            return formatTableCSV(rowList);
        }

        public static List<RowOfTicketObject> formatTableCSV(List<String> rowList)
            //**ФОРМАТИРОВАНИЕ ТАБЛИЦЫ ДЛЯ ДАЛЬНЕЙШЕГО ИСПОЛЬЗОВАНИЯ**//
        {
            int y = rowList.Count;
            String[] bufferStrMas;
            String bufferStr;
            List<RowOfTicketObject> result = new List<RowOfTicketObject>();
            y = 0;
            while (y < rowList.Count)
            {
                //**ЧАСТЬ КОДА, ОТВЕЧАЮЩАЯ ЗА СКЛЕИВАНИЕ ОШИБОЧНО РАЗБИТЫХ СТРОК**//

                if (rowList[y].EndsWith("\"") && !rowList[y].StartsWith("\"") && rowList[y].Split(";").Length != 3)
                {
                    bufferStr = rowList[y - 1] + " " + rowList[y];
                    rowList[y - 1] = bufferStr;
                    rowList.RemoveAt(y);
                    y--;
                }
                //**//

                //**СБОР, СКЛЕИВАНИЕ, ФОРМАТИРОВАНИЕ И ПЕРЕНОС СТРОКИ В ДВУМЕРНЫЙ МАССИВ**//

                rowList[y] = rowList[y].Replace('\"', ' ');
                rowList[y] = rowList[y].Trim();

                bufferStrMas = rowList[y].Split(";");

                result.Add(new RowOfTicketObject(bufferStrMas));

                y++;
                //**//
            }

            return result;
        }
    }
}
