using NPOI.HSSF.UserModel;
using OBO_Tools.Objects.SettingsObject;
using OBO_Tools.Scripts.DealerRequest;
using OBO_Tools.Windows.DealerRequest;
using OBO_Tools.Windows.ErrorWindow;
using OBO_Tools.Windows.PaymentCorrectionWindow;
using OBO_Tools.Windows.SettingsWindow;
using System;
using System.Collections.Generic;
using System.IO;

namespace OBO_Tools.Objects
{
    class User
    {

        //**ОБЩИЕ ПЕРЕМЕННЫЕ**//
        public MainWindow mainWindow = new MainWindow(); //Главное окно
        public ErrorWindow errorWindow = new ErrorWindow(); //Окно ошибки
        public SettingsWindow settingsWindow = new SettingsWindow(); //Окно настроек
        public DealerRequestWindow dealerRequestWindow = new DealerRequestWindow(); //Окно запросов по дилерам
        public PaymentCorrectionWindow paymentCorrectionWindow = new PaymentCorrectionWindow(); //Окно корректировок платежей

        public String textError = "Неизвестная ошибка!"; //Стартовый текст ошибки
        public bool takeErrorCodeOfPoint = false; //Маркер получения ошибки по коду точки
        //**//

        //**ПЕРЕМЕННЫЕ НАСТРОЕК**//

        public List<Translit> listOfChar; //Лист русских и английских Char для перевода текста в транзлит

        //DealerRequest
        public bool transformFIOToEmailSTG = false; //Настройка преобразования ФИО ТМ/РТМ в email
        public bool secretOptionSTG = false; //Говно для теста
        //**//

        //**ПЕРЕМЕННЫЕ ЗАПРОСА ДИЛЕРАМ**//
        public String pathToContacts = Path.GetFullPath("InputFiles/ALL_MB_POS_REP.xls"); //Путь к контактам
        public String pathToCheckList = Path.GetFullPath("InputFiles/DescriptionInIncident.csv"); //Путь к чек-листу ТТ
        public HSSFWorkbook contactsFile; //Книга контактов после чтения NPOI
        public List<RowOfTicket> checkList; //Чек-лист после прочтения CSV
        public bool needAnswer = false; //Маркер необходимости ответа на запрос
        public String[] contacts; //Буферный массив нужных контактов из книги контактов
        public bool repeatRequest = false;
        //**//

        public User()
        {

        }
    }
}
