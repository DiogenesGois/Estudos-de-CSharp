﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1 {
    public partial class formulario : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void tbn_enviar_Click(object sender, EventArgs e) {
            Response.Redirect("Destino.aspx");
        }
    }
}