﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookids
{
    public partial class GestaoCompras : Form
    {
        public GestaoCompras()
        {
            InitializeComponent();
        }

        private void btnNovaCompra_Click(object sender, EventArgs e)
        {
            var formNovaCompra = new FormNovaCompra();
            formNovaCompra.ShowDialog();
        }
    }
}