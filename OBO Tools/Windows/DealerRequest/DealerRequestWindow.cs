using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OBO_Tools.Windows.DealerRequest
{
    public partial class DealerRequestWindow : Form
    {
        public DealerRequestWindow()
        {
            InitializeComponent();
        }

        public void ShowWindow()
        {
            DealerRequestLogic.ShowWindow();
        }

        private void ClosedForm(object sender, FormClosedEventArgs e)
        {
            DealerRequestLogic.ClosedForm();
        }

        private void BackBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.BackBtn();
        }

        private void LoadContactsBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.LoadContactsBtn();
        }

        private void LoadCheckListBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.LoadCheckListBtn();
        }

        private void GetRequestBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.GetRequestBtn();
        }

        private void NeedAnswerBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.NeedAnswerBtn();
        }

        private void ChangeCodeOfPointBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.ChangeCodeOfPointBtn();
        }

        private void CopyRtfTextBtn(object sender, EventArgs e)
        {
            DealerRequestLogic.CopyRtfTextBtn();
        }
    }
}
