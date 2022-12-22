using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URL_API_v2
{
    public class CN_MLA
    {
        private CD_MLA _CDMLA;

        public CN_MLA()
        {
            _CDMLA = new CD_MLA();
        }
        public tablaMLA SaveMLA(tablaMLA consulta)
        {
            if (consulta.URL_ID == 0)
                _CDMLA.InsertaMLA(consulta);
            else
                _CDMLA.EditarMLA(consulta);

                return consulta;
        }
        public List<tablaMLA> GetMLAs(string Buscar = null)
        {
           return _CDMLA.GetMLAs(Buscar);
        }
        public void BorrarMLA(int URL_ID)
        {
            _CDMLA.BorrarMLA(URL_ID);
        }
    }
}
