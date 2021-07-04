using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Scripts.DealerRequest
{

    class DealerRequestController
    {
        static MainWindow mainWindow = Program.user.mainWindow;
        public static void loadContactsBtn()
        {
            if (Methods.checkFile(Program.user.pathToContacts))
            {
                mainWindow.fxContactsLabel.Text = "Состояние: Файл найден.";
                Program.user.contactsFile = RWExcel.getBook();
            }
            else mainWindow.fxContactsLabel.Text = "Состояние: Ошибка!";
        }

        public static void loadCheckListBtn()
        {
            if (Methods.checkFile(Program.user.pathToCheckList))
            {
                mainWindow.fxCheckListLabel.Text = "Состояние: Файл найден.";
                Program.user.checkList = ReadCheckList.bufferedReaderTableCSV();
                Program.user.repeatRequest = false;
            }
            else mainWindow.fxCheckListLabel.Text = "Состояние: Ошибка!";
        }

        public static void getRequestBtn()
        {
            if (Program.user.checkList != null && Program.user.contactsFile != null)
            {
                mainWindow.fxRequestArea.Text = CreateRequest.createRequest();
                CreateRequest.changeFont();

                if (Program.user.takeErrorCodeOfPoint)
                {
                    if (!mainWindow.fxCodeOfPoint.Visible && !mainWindow.fxCodeOfPointBtn.Visible)
                    {
                        mainWindow.fxCodeOfPoint.Show();
                        mainWindow.fxCodeOfPointBtn.Show();
                    }
                }
                else
                {
                    mainWindow.fxCodeOfPoint.Text = "";
                    mainWindow.fxCodeOfPoint.Hide();
                    mainWindow.fxCodeOfPointBtn.Hide();
                }
            }
            else
            {
                Program.user.textError = "DealerRequestController #38\n\nФайл с контактами и/или чек-листом не загружен.\n\nВозможные варианты:\n*Файл не загружен\n*Файл повреждён";
                Program.user.errorWindow.ShowWindow();
            }
        }

        public static void copyRtfTextBtn()
        {
            Clipboard.SetText(Program.user.mainWindow.fxRequestArea.Rtf, TextDataFormat.Rtf);
        }

        public static void needAnswerBtn()
        {
            if (mainWindow.needAnswerCheckbox.Checked)
                Program.user.needAnswer = true;
            else Program.user.needAnswer = false;
        }

        public static void changeCodeOfPointBtn()
        {
            CreateRequest.codeOfPointSTR = mainWindow.fxCodeOfPoint.Text;
        }

    }
}
