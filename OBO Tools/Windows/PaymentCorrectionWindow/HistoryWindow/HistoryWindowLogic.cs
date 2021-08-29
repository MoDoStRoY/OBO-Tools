using OBO_Tools.Objects;
using OBO_Tools.Objects.PaymentCorrection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.PaymentCorrectionWindow.HistoryWindow
{
    class HistoryWindowLogic
    {
        static User user = Program.user;
        static HistoryWindow window = user.historyWindow;

        public static void ShowWindow()
        {
            window.Show();
            RefreshHistory();
        }

        public static void ClosedForm()
        {
            user.settingsWindow.Dispose();
            Application.Exit();
        }

        public static void BackBtn()
        {
            window.Hide();
            user.paymentCorrectionWindow.ShowWindow();
        }

        public static void SearchBtn()
        {

        }

        public static void RefreshHistory()
        {
            List<Payment> paymentList = Program.user.paymentList;
            window.HistoryDGV.Rows.Clear();

            for (int i = 0; i < user.paymentList.Count; i++)
            {
                window.HistoryDGV.Rows.Add();

                window.HistoryDGV.Rows[i].Cells[0].Value = i;
                window.HistoryDGV.Rows[i].Cells[1].Value = paymentList[i].TTNumber;
                window.HistoryDGV.Rows[i].Cells[2].Value = paymentList[i].paymentSum;
                window.HistoryDGV.Rows[i].Cells[3].Value = paymentList[i].paymentDate;

                if (paymentList[i].fullCorrection)
                    window.HistoryDGV.Rows[i].Cells[4].Value = paymentList[i].paymentSum;
                else
                    window.HistoryDGV.Rows[i].Cells[4].Value = paymentList[i].correctionSum;

                if (paymentList[i].correctionRefuse)
                    window.HistoryDGV.Rows[i].Cells[5].Value = "Отказ";
                else
                    window.HistoryDGV.Rows[i].Cells[5].Value = "Корректировка";

                if (paymentList[i].incorrectTicket)
                    window.HistoryDGV.Rows[i].Cells[6].Value = "Да";
                else
                    window.HistoryDGV.Rows[i].Cells[6].Value = "Нет";

                window.HistoryDGV.Rows[i].Cells[7].Value = paymentList[i].sourceTicket;
            }
        }

        public static void ChosePaymentDGV(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                user.paymentWindow.ShowWindow(user.paymentList[e.RowIndex]);
            }
        }
    }
}
