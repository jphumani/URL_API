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
    public partial class MLA_URL : Form
    {
        private CN_MLA _CN_MLA;
        public MLA_URL()
        {
            InitializeComponent();
            _CN_MLA = new CN_MLA();
        }
        #region EVENTOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OpenMLAadd();
        }
        #endregion

        #region Metodos Privados
        private void OpenMLAadd()
        {
            AgregarMLA agregarMLA = new AgregarMLA();
            agregarMLA.ShowDialog(this);
        }
        #endregion

        private void MLA_URL_Load(object sender, EventArgs e)
        {
            Populate();
        }
        public void Populate(string Buscar = null)
        {
            List<tablaMLA> consulta = _CN_MLA.GetMLAs(Buscar);
            MLA.DataSource = consulta;
        }

        private void MLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)MLA.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cell.Value.ToString() == "EDITAR")
            {
                AgregarMLA agregarMLA = new AgregarMLA();
                agregarMLA.LoadContact(new tablaMLA
                {

                    URL_ID = int.Parse(MLA.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    URL_QUERY = (MLA.Rows[e.RowIndex].Cells[1]).Value.ToString()
                });
                agregarMLA.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "BORRAR")
            {

                BorrarMLA(int.Parse(MLA.Rows[e.RowIndex].Cells[0].Value.ToString()));
                Populate();
            }
        }
        private void BorrarMLA (int URL_ID)
        {
            _CN_MLA.BorrarMLA(URL_ID);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Populate(txtSearch.Text);
            txtSearch.Text= string.Empty;
        }
    }
}
