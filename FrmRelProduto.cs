﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaCL
{
    public partial class FrmRelProduto : Form
    {
        public FrmRelProduto()
        {
            InitializeComponent();
        }

        private void FrmRelProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'DBLojaDSMaster.produto'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoTableAdapter.Fill(this.DBLojaDSMaster.produto);

            this.reportViewer1.RefreshReport();
        }
    }
}
