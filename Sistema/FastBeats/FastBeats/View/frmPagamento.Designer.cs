namespace FastBeats.View
{
    partial class frmPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPagamento));
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.mdgvFormaPgto = new MetroFramework.Controls.MetroGrid();
            this.txtFPGT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtxtTroco = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorRecebido = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorTotal = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.mcboFormaPgto = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtxtValorFPgto = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.mPanel = new MetroFramework.Controls.MetroPanel();
            this.mlblAvisos = new MetroFramework.Controls.MetroLabel();
            this.mbtnFinalizar = new MetroFramework.Controls.MetroButton();
            this.mbtnAddFormaPgto = new MetroFramework.Controls.MetroButton();
            this.mTileAddPgto = new MetroFramework.Controls.MetroTile();
            this.mTileVoltar = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvFormaPgto)).BeginInit();
            this.mPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // mdgvFormaPgto
            // 
            this.mdgvFormaPgto.AllowUserToAddRows = false;
            this.mdgvFormaPgto.AllowUserToResizeRows = false;
            this.mdgvFormaPgto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.mdgvFormaPgto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvFormaPgto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mdgvFormaPgto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mdgvFormaPgto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvFormaPgto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mdgvFormaPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mdgvFormaPgto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtFPGT,
            this.txtValor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mdgvFormaPgto.DefaultCellStyle = dataGridViewCellStyle2;
            this.mdgvFormaPgto.EnableHeadersVisualStyles = false;
            this.mdgvFormaPgto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mdgvFormaPgto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mdgvFormaPgto.Location = new System.Drawing.Point(17, 86);
            this.mdgvFormaPgto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mdgvFormaPgto.Name = "mdgvFormaPgto";
            this.mdgvFormaPgto.ReadOnly = true;
            this.mdgvFormaPgto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mdgvFormaPgto.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mdgvFormaPgto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mdgvFormaPgto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mdgvFormaPgto.Size = new System.Drawing.Size(417, 187);
            this.mdgvFormaPgto.TabIndex = 13;
            this.mdgvFormaPgto.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.mdgvFormaPgto_RowsRemoved);
            // 
            // txtFPGT
            // 
            this.txtFPGT.HeaderText = "Forma de Pagamento";
            this.txtFPGT.Name = "txtFPGT";
            this.txtFPGT.ReadOnly = true;
            // 
            // txtValor
            // 
            this.txtValor.HeaderText = "Valor (R$)";
            this.txtValor.Name = "txtValor";
            this.txtValor.ReadOnly = true;
            // 
            // mtxtTroco
            // 
            this.mtxtTroco.Lines = new string[0];
            this.mtxtTroco.Location = new System.Drawing.Point(532, 186);
            this.mtxtTroco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtTroco.MaxLength = 32767;
            this.mtxtTroco.Name = "mtxtTroco";
            this.mtxtTroco.PasswordChar = '\0';
            this.mtxtTroco.ReadOnly = true;
            this.mtxtTroco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtTroco.SelectedText = "";
            this.mtxtTroco.Size = new System.Drawing.Size(224, 28);
            this.mtxtTroco.TabIndex = 17;
            this.mtxtTroco.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(532, 153);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(46, 20);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "Troco:";
            // 
            // mtxtValorRecebido
            // 
            this.mtxtValorRecebido.Lines = new string[0];
            this.mtxtValorRecebido.Location = new System.Drawing.Point(532, 114);
            this.mtxtValorRecebido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtValorRecebido.MaxLength = 32767;
            this.mtxtValorRecebido.Name = "mtxtValorRecebido";
            this.mtxtValorRecebido.PasswordChar = '\0';
            this.mtxtValorRecebido.ReadOnly = true;
            this.mtxtValorRecebido.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorRecebido.SelectedText = "";
            this.mtxtValorRecebido.Size = new System.Drawing.Size(224, 28);
            this.mtxtValorRecebido.TabIndex = 15;
            this.mtxtValorRecebido.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(532, 81);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(104, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Valor Recebido:";
            // 
            // mtxtValorTotal
            // 
            this.mtxtValorTotal.Lines = new string[0];
            this.mtxtValorTotal.Location = new System.Drawing.Point(532, 43);
            this.mtxtValorTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtValorTotal.MaxLength = 32767;
            this.mtxtValorTotal.Name = "mtxtValorTotal";
            this.mtxtValorTotal.PasswordChar = '\0';
            this.mtxtValorTotal.ReadOnly = true;
            this.mtxtValorTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorTotal.SelectedText = "";
            this.mtxtValorTotal.Size = new System.Drawing.Size(224, 28);
            this.mtxtValorTotal.TabIndex = 31;
            this.mtxtValorTotal.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(532, 10);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(74, 20);
            this.metroLabel2.TabIndex = 30;
            this.metroLabel2.Text = "Valor Total:";
            // 
            // mcboFormaPgto
            // 
            this.mcboFormaPgto.FormattingEnabled = true;
            this.mcboFormaPgto.ItemHeight = 24;
            this.mcboFormaPgto.Location = new System.Drawing.Point(17, 43);
            this.mcboFormaPgto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mcboFormaPgto.Name = "mcboFormaPgto";
            this.mcboFormaPgto.Size = new System.Drawing.Size(201, 30);
            this.mcboFormaPgto.TabIndex = 32;
            this.mcboFormaPgto.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(17, 16);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(144, 20);
            this.metroLabel1.TabIndex = 33;
            this.metroLabel1.Text = "Forma de Pagamento:";
            // 
            // mtxtValorFPgto
            // 
            this.mtxtValorFPgto.Lines = new string[0];
            this.mtxtValorFPgto.Location = new System.Drawing.Point(228, 47);
            this.mtxtValorFPgto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mtxtValorFPgto.MaxLength = 32767;
            this.mtxtValorFPgto.Name = "mtxtValorFPgto";
            this.mtxtValorFPgto.PasswordChar = '\0';
            this.mtxtValorFPgto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtxtValorFPgto.SelectedText = "";
            this.mtxtValorFPgto.Size = new System.Drawing.Size(165, 28);
            this.mtxtValorFPgto.TabIndex = 35;
            this.mtxtValorFPgto.UseSelectable = true;
            this.mtxtValorFPgto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtValorFPgto_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(228, 16);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 20);
            this.metroLabel5.TabIndex = 34;
            this.metroLabel5.Text = "Valor:";
            // 
            // mPanel
            // 
            this.mPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mPanel.Controls.Add(this.mlblAvisos);
            this.mPanel.Controls.Add(this.mbtnFinalizar);
            this.mPanel.Controls.Add(this.mbtnAddFormaPgto);
            this.mPanel.Controls.Add(this.mTileAddPgto);
            this.mPanel.Controls.Add(this.metroLabel5);
            this.mPanel.Controls.Add(this.mtxtValorFPgto);
            this.mPanel.Controls.Add(this.metroLabel1);
            this.mPanel.Controls.Add(this.metroLabel3);
            this.mPanel.Controls.Add(this.mcboFormaPgto);
            this.mPanel.Controls.Add(this.mtxtValorRecebido);
            this.mPanel.Controls.Add(this.mtxtValorTotal);
            this.mPanel.Controls.Add(this.metroLabel4);
            this.mPanel.Controls.Add(this.metroLabel2);
            this.mPanel.Controls.Add(this.mtxtTroco);
            this.mPanel.Controls.Add(this.mdgvFormaPgto);
            this.mPanel.HorizontalScrollbarBarColor = true;
            this.mPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mPanel.HorizontalScrollbarSize = 12;
            this.mPanel.Location = new System.Drawing.Point(112, 78);
            this.mPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mPanel.Name = "mPanel";
            this.mPanel.Size = new System.Drawing.Size(789, 315);
            this.mPanel.TabIndex = 36;
            this.mPanel.VerticalScrollbarBarColor = true;
            this.mPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mPanel.VerticalScrollbarSize = 13;
            // 
            // mlblAvisos
            // 
            this.mlblAvisos.AutoSize = true;
            this.mlblAvisos.Location = new System.Drawing.Point(213, 286);
            this.mlblAvisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mlblAvisos.Name = "mlblAvisos";
            this.mlblAvisos.Size = new System.Drawing.Size(0, 0);
            this.mlblAvisos.TabIndex = 37;
            // 
            // mbtnFinalizar
            // 
            this.mbtnFinalizar.Location = new System.Drawing.Point(532, 241);
            this.mbtnFinalizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbtnFinalizar.Name = "mbtnFinalizar";
            this.mbtnFinalizar.Size = new System.Drawing.Size(224, 43);
            this.mbtnFinalizar.TabIndex = 38;
            this.mbtnFinalizar.Text = "Finalizar";
            this.mbtnFinalizar.UseSelectable = true;
            this.mbtnFinalizar.Click += new System.EventHandler(this.mbtnFinalizar_Click);
            // 
            // mbtnAddFormaPgto
            // 
            this.mbtnAddFormaPgto.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.mbtnAddFormaPgto.Location = new System.Drawing.Point(17, 281);
            this.mbtnAddFormaPgto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mbtnAddFormaPgto.Name = "mbtnAddFormaPgto";
            this.mbtnAddFormaPgto.Size = new System.Drawing.Size(188, 28);
            this.mbtnAddFormaPgto.TabIndex = 37;
            this.mbtnAddFormaPgto.Text = "Nova Forma de Pagamento";
            this.mbtnAddFormaPgto.UseSelectable = true;
            this.mbtnAddFormaPgto.Click += new System.EventHandler(this.mbtnAddFormaPgto_Click);
            // 
            // mTileAddPgto
            // 
            this.mTileAddPgto.ActiveControl = null;
            this.mTileAddPgto.Location = new System.Drawing.Point(401, 47);
            this.mTileAddPgto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTileAddPgto.Name = "mTileAddPgto";
            this.mTileAddPgto.Size = new System.Drawing.Size(33, 31);
            this.mTileAddPgto.TabIndex = 36;
            this.mTileAddPgto.Text = "+";
            this.mTileAddPgto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddPgto.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileAddPgto.UseSelectable = true;
            this.mTileAddPgto.UseTileImage = true;
            this.mTileAddPgto.Click += new System.EventHandler(this.mTileAddPgto_Click);
            // 
            // mTileVoltar
            // 
            this.mTileVoltar.ActiveControl = null;
            this.mTileVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mTileVoltar.Location = new System.Drawing.Point(31, 383);
            this.mTileVoltar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mTileVoltar.Name = "mTileVoltar";
            this.mTileVoltar.Size = new System.Drawing.Size(53, 49);
            this.mTileVoltar.TabIndex = 29;
            this.mTileVoltar.TileImage = ((System.Drawing.Image)(resources.GetObject("mTileVoltar.TileImage")));
            this.mTileVoltar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mTileVoltar.UseSelectable = true;
            this.mTileVoltar.UseTileImage = true;
            this.mTileVoltar.Click += new System.EventHandler(this.mTileVoltar_Click);
            // 
            // frmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 460);
            this.ControlBox = false;
            this.Controls.Add(this.mPanel);
            this.Controls.Add(this.mTileVoltar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "frmPagamento";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pagamento";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmPagamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdgvFormaPgto)).EndInit();
            this.mPanel.ResumeLayout(false);
            this.mPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroGrid mdgvFormaPgto;
        private MetroFramework.Controls.MetroTextBox mtxtTroco;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox mtxtValorRecebido;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTile mTileVoltar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroTextBox mtxtValorTotal;
        private MetroFramework.Controls.MetroTextBox mtxtValorFPgto;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel mPanel;
        private MetroFramework.Controls.MetroButton mbtnAddFormaPgto;
        private MetroFramework.Controls.MetroTile mTileAddPgto;
        public MetroFramework.Controls.MetroComboBox mcboFormaPgto;
        private MetroFramework.Controls.MetroButton mbtnFinalizar;
        private MetroFramework.Controls.MetroLabel mlblAvisos;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtFPGT;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtValor;
    }
}