using NPOI.HSSF.UserModel;
using NPOI.POIFS.FileSystem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OBO_Tools.Scripts
{
    class RWExcel
    {
        //**ЧТЕНИЕ XLS ФАЙЛА**//
        public static HSSFWorkbook getBook()
        {
            try
            {
                FileStream reader = new FileStream(Program.user.pathToContacts, FileMode.Open, FileAccess.Read);

                return new HSSFWorkbook(reader);
            }
            catch (Exception e) {return null;}
        }
        //**//

        public static String[] getContacts()
        {


            HSSFSheet sheet = (HSSFSheet) Program.user.contactsFile.GetSheetAt(0);
            HSSFRow row;
            HSSFCell cell = null;
            int counter = 1;
            while (true)
            {
                row = (HSSFRow) sheet.GetRow(counter);
                try { cell = (HSSFCell)row.GetCell(7); }
                catch (Exception e) 
                {
                    Program.user.textError = "DealerRequest|RWEXCEL #39 \n\nОшибка при поиске контактов ТМ и дилера.\n\nВероятные причины: \n*Некорректный код точки\n*Некорректный файл с контактами";
                    Program.user.errorWindow.Show();
                    break;
                }

                if (cell.NumericCellValue == Convert.ToInt32(CreateRequest.codeOfPointSTR.Trim()))
                {
                    return GetResultFromRow(row);
                }
                counter++;
            }

            return null;
        }

        private static String[] GetResultFromRow(HSSFRow row)
        {
            var result = new String[5];
            for (var i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    result[i] = row.GetCell(11 + 5).StringCellValue;
                    i++;
                }
                result[i] = row.GetCell(11 + i).StringCellValue;
            }
            return result;
        }

    }
}
