using OBO_Tools.Objects;
using OBO_Tools.Scripts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.DealerRequest
{
    class DealerRequestLogic
    {
        static User user = Program.user;

        public static void ShowWindow()
        {
            user.dealerRequestWindow.Show();
        }

        public static void ClosedForm()
        {
            user.settingsWindow.Dispose();
            Application.Exit();
        }

        public static void BackBtn()
        {
            user.dealerRequestWindow.Hide();
            user.mainWindow.ShowWindow();
        }

        public static void LoadContactsBtn()
        {
            if (Methods.checkFile(user.pathToContacts))
            {
                user.dealerRequestWindow.fxContactsLabel.Text = "Состояние: Файл найден.";
                user.contactsFile = RWExcel.getBook();
            }
            else user.dealerRequestWindow.fxContactsLabel.Text = "Состояние: Ошибка!";
        }

        public static void LoadCheckListBtn()
        {
            if (Methods.checkFile(user.pathToCheckList))
            {
                user.dealerRequestWindow.fxCheckListLabel.Text = "Состояние: Файл найден.";
                user.checkList = ReadCheckList.bufferedReaderTableCSV();
                user.repeatRequest = false;
            }
            else user.dealerRequestWindow.fxCheckListLabel.Text = "Состояние: Ошибка!";
        }

        public static void GetRequestBtn()
        {
            if (user.checkList != null && Program.user.contactsFile != null)
            {
                user.dealerRequestWindow.fxRequestArea.Text = CreateRequest.createRequest();
                CreateRequest.changeFont();

                if (user.takeErrorCodeOfPoint)
                {
                    if (!user.dealerRequestWindow.fxCodeOfPoint.Visible && !user.dealerRequestWindow.fxCodeOfPointBtn.Visible)
                    {
                        user.dealerRequestWindow.fxCodeOfPoint.Show();
                        user.dealerRequestWindow.fxCodeOfPointBtn.Show();
                    }
                }
                else
                {
                    user.dealerRequestWindow.fxCodeOfPoint.Text = "";
                    user.dealerRequestWindow.fxCodeOfPoint.Hide();
                    user.dealerRequestWindow.fxCodeOfPointBtn.Hide();
                }
            }
            else
            {
                user.textError = "DealerRequestController #38\n\nФайл с контактами и/или чек-листом не загружен.\n\nВозможные варианты:\n*Файл не загружен\n*Файл повреждён";
                user.errorWindow.ShowWindow();
            }
        }

        public static void CopyRtfTextBtn()
        {
            Clipboard.SetData(DataFormats.Text, (Object)user.dealerRequestWindow.fxRequestArea.Text);
        }

        public static void NeedAnswerBtn()
        {
            if (user.dealerRequestWindow.needAnswerCheckbox.Checked)
                user.needAnswer = true;
            else user.needAnswer = false;
        }

        public static void ChangeCodeOfPointBtn()
        {
            CreateRequest.codeOfPointSTR = user.dealerRequestWindow.fxCodeOfPoint.Text;
        }
    }
}
