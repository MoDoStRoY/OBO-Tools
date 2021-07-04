using OBO_Tools.Scripts.Settings;
using OBO_Tools.Windows.DealerRequest;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace OBO_Tools.Scripts
{
    class CreateRequest
    {
        static DealerRequestWindow dealerRequestWindow = Program.user.dealerRequestWindow;

        //**НЕИЗМЕННЫЕ ПЕРЕМЕННЫЕ ТЕКСТА ЗАПРОСА**//

        private static List<String> listOfSTRForChangeFont = new List<String>()
        {
            "Используйте функцию \"Ответить\" или \"Ответить всем\".",
            "Адрес салона:",
            "Код точки:",
            "Сотрудник:",
            "Дата и время:",
            "Номер абонента:",
            "Суть жалобы абонента:",
            "Что необходимо сделать ТМ:",
            "Ожидаем ответа в обратном письме до УКАЖИСРОК",
            "При ответе на запрос нельзя менять тему письма.",
            "(НЕ МЕНЕЕ 1 СУТОК)."
        };

        //**//

        //**ИЗМЕНЯЕМЫЕ ПЕРЕМЕННЫЕ ТЕКСТА ЗАПРОСА**//

        private static String titleSTR = "";
        private static String themeOfMailSTR = "";
        private static String waitingAnswer = "";

        //**//

        //**ПЕРЕМЕННЫЕ ПОДТЯГИВАЕМЫЕ ИЗ ДРУГИХ ФАЙЛОВ**//
        private static String addressSTR = "";
        public static String codeOfPointSTR = "";
        private static String dealerSTR = "";
        private static String dateSTR = "";
        private static String numberSTR = "";
        private static String themeOfTTSTR = "";
        private static String tmSTR = "";
        private static String rtmSTR = "";
        private static String trainersMailSTR = "";
        private static String dealerMailSTR = "";
        private static String pointMailSTR = "";
        //**//

        public static String createRequest()
        {
            if (!Program.user.repeatRequest)
            {
                dealerSTR = "";
                dateSTR = "";

                String nameOfRow;
                for (int i = 1; i < Program.user.checkList.Count; i++)
                {
                    nameOfRow = Program.user.checkList[i].nameOfRow;

                    if (nameOfRow.StartsWith("Адрес"))
                        addressSTR = Program.user.checkList[i].valueOfRow;
                    else if (nameOfRow.StartsWith("Код точки") && !Program.user.takeErrorCodeOfPoint)
                        codeOfPointSTR = Program.user.checkList[i].valueOfRow;
                    else if (nameOfRow.StartsWith("Имя сотрудника") || nameOfRow.StartsWith("Указать имя"))
                        dealerSTR = dealerSTR + " " + Program.user.checkList[i].valueOfRow;
                    else if (nameOfRow.StartsWith("Дата обращения") || nameOfRow.StartsWith("Время обращения") || nameOfRow.StartsWith("Дата и время"))
                        dateSTR = dateSTR + " " + Program.user.checkList[i].valueOfRow;
                    else if (nameOfRow.StartsWith("Временный номер") || nameOfRow.StartsWith("Номер абонента"))
                        numberSTR = Program.user.checkList[i].valueOfRow;
                    else if (nameOfRow.StartsWith("Описание проблемы") || nameOfRow.StartsWith("В чем заключается некорректность") || nameOfRow.StartsWith("Опиши подробно по какому"))
                        themeOfTTSTR = Program.user.checkList[i].valueOfRow;
                    Program.user.repeatRequest = true; //Постановка маркера повторного запроса по тому же ТТ
                }
            }

            return formatTextRequest();
        }

        public static String formatTextRequest()
        {
            initializeContacts();

            if (dealerRequestWindow.needAnswerCheckbox.Checked)
            {
                titleSTR = "Используйте функцию \"Ответить\" или \"Ответить всем\". При ответе на запрос нельзя менять тему письма.";
                themeOfMailSTR = "Запрос ТМ по претензии к дилеру ТТХХХХХХХ - ТРЕБУЕТСЯ ОТВЕТ";
                waitingAnswer = "\nЧто необходимо сделать ТМ:  \n\nОжидаем ответа в обратном письме до УКАЖИСРОК (НЕ МЕНЕЕ 1 СУТОК).\n";
            }
            else
            {
                titleSTR = "Прошу проверить информацию от абонента, при подтверждении ошибки отработать с сотрудником, провести дополнительное обучение.";
                themeOfMailSTR = "Запрос ТМ по претензии к дилеру ТТХХХХХХХ - для отработки";
                waitingAnswer = "";
            }

            return String.Format(
                "Добрый день!\n" +
                "\n" +
                "{0}\n" +
                "\n" +
                "Адрес салона:  {1}\n" +
                "Код точки:  {2}\n" +
                "Сотрудник:  {3}\n" +
                "Дата и время:  {4}\n" +
                "Номер абонента:  {5}\n" +
                "\n" +
                "Суть жалобы абонента:  {6}\n" +
                "{7}" +
                "\n" +
                "ТМ: {8}\n" +
                "РТМ: {9}\n" +
                "Почта дилера: {10}\n" +
                "Почта точки: {11}\n" +
                "Почта тренеров: {12}\n" +
                "Тема письма: {13}\n", titleSTR, addressSTR, codeOfPointSTR, dealerSTR, dateSTR, numberSTR, themeOfTTSTR, 
                waitingAnswer, tmSTR, rtmSTR, dealerMailSTR, pointMailSTR, trainersMailSTR, themeOfMailSTR);
        }

        public static void changeFont()
        {
            Font boldFont = new Font("Arial", 9, FontStyle.Bold);

            for (int i=0; i<listOfSTRForChangeFont.Count; i++)
            {
                dealerRequestWindow.fxRequestArea.Find(listOfSTRForChangeFont[i]);
                if (i < listOfSTRForChangeFont.Count - 2)
                    dealerRequestWindow.fxRequestArea.SelectionFont = boldFont;
                else if (dealerRequestWindow.needAnswerCheckbox.Checked)
                {
                    dealerRequestWindow.fxRequestArea.SelectionColor = Color.Red;
                    dealerRequestWindow.fxRequestArea.SelectionFont = boldFont;
                }
            }
        }

        public static void initializeContacts()
        {
            Program.user.contacts = RWExcel.getContacts();

            if (Program.user.contacts == null)
            {
                Program.user.contacts = new String[5];
                Program.user.takeErrorCodeOfPoint = true;
            }
            else Program.user.takeErrorCodeOfPoint = false;

            if (!Program.user.transformFIOToEmailSTG)
            {
                tmSTR = Program.user.contacts[0];
                rtmSTR = Program.user.contacts[1];
            }
            else
            {
                try
                {
                    tmSTR = Program.user.contacts[0] + " " + STGofDealerRequest.translitRow(Program.user.contacts[0]);
                    rtmSTR = Program.user.contacts[1] + " " + STGofDealerRequest.translitRow(Program.user.contacts[1]);
                }
                catch (Exception e)
                {
                    tmSTR = "";
                    rtmSTR = "";
                }
            }
            trainersMailSTR = Program.user.contacts[2];
            dealerMailSTR = Program.user.contacts[4];
            pointMailSTR = Program.user.contacts[3];
        }

    }
}
