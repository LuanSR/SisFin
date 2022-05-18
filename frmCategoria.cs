using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SisFin
{
    public partial class frmCategoria : Form
    {

        private bool Insercao = false;
        private bool Edicao = false;


        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

            txtNome.Text = "combustivel";
            txtDescricao.Text = "consumo de combustivel";
            rdDespesa.Checked = true;
            chkStatus.Checked = true;
            grpCategoria.Enabled = false;
            btnSalvar.Visible = false;
        }   

        private void limparCampos()
        {
            txtNome.Clear();
            txtDescricao.Clear();
            rdDespesa.Checked = false;
            rdReceita.Checked = false;
            chkStatus.Checked = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Receita_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdDespesa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void novoRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            limparCampos();
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
            chkStatus.Checked = true;
        }

        private void alterarRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = false;
            Edicao = true;
        }

        private void excluirRegistro(object sender, EventArgs e)
        {
            grpCategoria.Enabled = true;
            DialogResult resp;
            resp = MessageBox.Show("Confirma Exclusão?", "Aviso do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); 
            if (resp==DialogResult.Yes)
            {
                limparCampos();
                MessageBox.Show("Registro excluído com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            txtNome.Focus();
            btnAlterar.Enabled = false;
            btnCancelar.Visible = true;
            btnSalvar.Visible = true;
            btnExcluir.Visible = false;
            btnNovo.Enabled = false;
            Insercao = true;
            Edicao = false;
        }

        private void salvarRegistro(object sender, EventArgs e)
        {
            MessageBox.Show("Registro gravado com sucesso!", "Aviso do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnNovo.Focus();
            grpCategoria.Enabled = false;
            btnAlterar.Enabled = true;
            btnCancelar.Visible = false;
            btnSalvar.Visible = false;
            btnExcluir.Visible = true;
            btnExcluir.Visible = true;
            Insercao = false;
            Edicao = false;
        }

        private void fecharForm(object sender, FormClosingEventArgs e)
        {
            if (Edicao || Insercao)
            {
                e.Cancel = true;
                MessageBox.Show("Salve os dados primeiro", "Aviso do sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnNovo.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Visible = true;
            btnSalvar.Visible = false;
            btnCancelar.Visible = false;
            grpCategoria.Enabled = false;
            btnNovo.Focus();
            Insercao = false;
            Edicao = false;
        }
    }
}
