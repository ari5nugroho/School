using login.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using login.Model.Entity;
namespace login.View
{
    public delegate void CreateUpdateEventTcrHandler(Teacher tcr);
    public partial class Teachers : UserControl
    {
        private List<Teacher> ListOfTeacher = new List<Teacher>();
        public event CreateUpdateEventTcrHandler OnCreate;
        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventTcrHandler OnUpdate;
        // deklarasi event ketika terjadi proses hapus data
        public event CreateUpdateEventTcrHandler OnDelete;
        private TeacherController controller;
        private bool isNewData = true;
        private Teacher tcr;
        public Teachers()
        {
            InitializeComponent();
            controller = new TeacherController();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTcr_Click(object sender, EventArgs e)
        {
            if (isNewData) tcr = new Teacher();
            tcr.tcName = txtNameTcr.Text;
            tcr.tcGen = cmbGenTcr.SelectedItem.ToString();
            tcr.tcDOB = dtDOBTcr.Text;
            tcr.tcPhone = txtPhoneStd.Text;
            tcr.tcSubject = cmbSubjectTcr.Text;
            tcr.tcAdrs = txtAdrsTcr.Text;

            int result = 0;

            if (isNewData)
            {
                result = controller.Create(tcr);
                if (result > 0)
                {
                    OnCreate(tcr);

                    txtNameTcr.Clear();
                    cmbGenTcr.SelectedIndex = -1;
                    dtDOBTcr.Value = DateTime.Now;
                    txtPhoneStd.Clear();
                    cmbSubjectTcr.SelectedIndex = -1;
                    txtAdrsTcr.Clear();

                    txtNameTcr.Focus();
                }

            }
            else
            {
                result = controller.Update(tcr);
                if (result > 0)
                {
                    OnUpdate(tcr);
                    //this.Close();
                }
            }
        }
    }
}
