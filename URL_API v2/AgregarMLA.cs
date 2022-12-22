using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace URL_API_v2
{
    public partial class AgregarMLA : Form
    {
        private CN_MLA _CNMLA;
        private tablaMLA _contact;
        public AgregarMLA()
        {
            InitializeComponent();
            _CNMLA= new CN_MLA();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            SaveMLA();
            this.Close();
            ((MLA_URL)this.Owner).Populate();
        }
        private void SaveMLA()
        {
            tablaMLA consulta = new tablaMLA();
            //Con el comando de abajo asocio textbox a campo de clase
            consulta.URL_QUERY = txtAddform.Text;
            consulta.URL_ID = _contact != null ? _contact.URL_ID : 0;
            _CNMLA.SaveMLA(consulta);
        }

        public void LoadContact (tablaMLA consulta)
        {
            _contact = consulta;
            if (consulta != null) 
            {
                ClearForm();
                txtAddform.Text= consulta.URL_QUERY;
            }
        }

        private void ClearForm()
        {
            txtAddform.Text= string.Empty;
        }
    }
}
