using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastBeats.DB;
using FastBeats.Utilities;
using MetroFramework;

namespace FastBeats.View
{
    public partial class frmPagamento : MetroFramework.Forms.MetroForm
    {
        frmPrincipal contexto = new frmPrincipal();
        frmCaixa contextoCaixa = new frmCaixa();
        Pagamento pgto = new Pagamento();
        Caixa caixa = new Caixa();
        Comanda coman = new Comanda();
        PropriedadesTextBox propTxt = new PropriedadesTextBox();
        Limpar limpar = new Limpar();
        

        decimal valorTotal = 0, valorPagar = 0;
        public frmPagamento(frmCaixa contextoCaixa,frmPrincipal contexto)
        {
               
            InitializeComponent();
            this.contextoCaixa = contextoCaixa;
            this.contexto = contexto;
            this.StyleManager = metroStyleManager;
           
        }

        public frmPagamento()
        {
            // TODO: Complete member initialization
        }

        private void mTileVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            if (contexto.mlblNivel.Text == "Administrador")
            {
                mbtnAddFormaPgto.Visible = true;
            }
            else
            {
                mbtnAddFormaPgto.Visible = false;
            }
            mcboFormaPgto.DataSource = pgto.consPagamento().Tables[0];
            mcboFormaPgto.DisplayMember = "FORMA_PAGAMENTO";
            mcboFormaPgto.ValueMember = "FORMA_PAGAMENTO";
            mcboFormaPgto.SelectedIndex = -1;
            propTxt.aplicarDinheiro(mtxtValorFPgto);
            Pagamento();
        }

        private void mbtnAddFormaPgto_Click(object sender, EventArgs e)
        {
            frmFormaPagamento formaPgto = new frmFormaPagamento(this);

            formaPgto.metroStyleManager.Theme = this.metroStyleManager.Theme;
            formaPgto.metroStyleManager.Style = this.metroStyleManager.Style;
            formaPgto.ShowDialog();
        }

        private void Pagamento()
        {
            valorTotal = 0;

            valorPagar = Convert.ToDecimal(mtxtValorTotal.Text.Replace("R$", "").Trim());
                for (int i = 0; i < mdgvFormaPgto.Rows.Count; i++)
                {
                    decimal valor = Convert.ToDecimal(mdgvFormaPgto.Rows[i].Cells[1].Value);
                    valorTotal += valor;
                }
                mtxtValorRecebido.Text = valorTotal.ToString();
                mtxtValorRecebido.Text = double.Parse(mtxtValorRecebido.Text).ToString("C2");
                valorTotal -= valorPagar;
                if (valorTotal > 0)
                {
                    mtxtTroco.Text = valorTotal.ToString();
                    mtxtTroco.Text = double.Parse(mtxtTroco.Text).ToString("C2");
                }
                else
                {
                    mtxtTroco.Text = "";
                    
                }
                
            
            
        }
        private void mTileAddPgto_Click(object sender, EventArgs e)
        {
            if ((mcboFormaPgto.SelectedIndex != -1) && (mtxtValorFPgto.Text != ""))
            {
                mdgvFormaPgto.Rows.Add(mcboFormaPgto.Text, Convert.ToDecimal(mtxtValorFPgto.Text.Replace("R$", "").Trim()).ToString("#.00"));
                Pagamento();
                mtxtValorFPgto.Clear();
                mcboFormaPgto.SelectedIndex = -1;
                mlblAvisos.Text = "";
            }
            else
            {
                mlblAvisos.Text = "Selecione a forma de pagamento e digite o valor Pago";
            }
            
        }

        private void mdgvFormaPgto_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Pagamento();
        }


        private void mbtnFinalizar_Click(object sender, EventArgs e)
        {
            if (valorTotal >= 0)
            {
                propTxt.tirarMascara(mtxtValorTotal);
                int codCaixa = caixa.cadCaixa(contexto.cpf, mtxtValorTotal.Text);
                for (int i = 0; i < contextoCaixa.mdgvComandas.Rows.Count; i++)
                {
                    caixa.cadComandaCaixa(codCaixa, Convert.ToInt32(contextoCaixa.mdgvComandas.Rows[i].Cells[1].Value));
                    coman.desativaComanda(Convert.ToInt32(contextoCaixa.mdgvComandas.Rows[i].Cells[1].Value),Convert.ToDouble(mtxtValorTotal.Text));
                }
                for (int i = 0; i < mdgvFormaPgto.Rows.Count; i++)
                {
                    pgto.cadPagamento(mdgvFormaPgto.Rows[i].Cells[0].Value.ToString(), Convert.ToDouble(mdgvFormaPgto.Rows[i].Cells[1].Value), codCaixa);

                }
                mlblAvisos.Text = "";
                MetroMessageBox.Show(contexto, "Caixa concluido com sucesso.", "Concluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar.limpar(contextoCaixa.mPanel);
                limpar.limpar(contextoCaixa.mPanel1);
                Close();
            }
            else
            {
                mlblAvisos.Text = "Não é possivel finalizar, enquanto há pagamento pendente.";
            }

           

            
        }

        private void mtxtValorFPgto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                mTileAddPgto_Click(sender,e);
            }
        }


 
       
    }
}
