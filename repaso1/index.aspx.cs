using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidad2;
using Controlador;

namespace repaso1
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Btn_Guardar_Click(object sender, EventArgs e)
        {
            Entidad2.Cliente cli = new Entidad2.Cliente();
            cli.nombre = txtNombre.Text;
            cli.edad = txtEdad.Text;
            Controlador.Cliente.Guardar(cli);

        }
    }
}