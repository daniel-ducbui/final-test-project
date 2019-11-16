using ExaminationManagement.Presenters;
using ExaminationManagement.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExaminationManagement
{
    public partial class frmQuestion : Form,IQuestionView
    {
        QuestionPresenter presenter;

        public DataTable dt { get; set ; }

        public frmQuestion()
        {
            InitializeComponent();
            Load += FrmQuestion_Load;
        }

        private void FrmQuestion_Load(object sender, EventArgs e)
        {
            presenter = new QuestionPresenter(this);
            dgvListQuestion.DataSource = dt;

            btnNew.Click += BtnNew_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public event EventHandler NewQuestion;
        public event EventHandler UpdateQuestion;
        public event EventHandler DeleteQuestion;
        public event EventHandler<SelectedChangedEventArgs> SelectedChangeQuestion;
    }
}
