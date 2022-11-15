namespace tp_final
{
    partial class Form1
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
            this.listPedidos = new System.Windows.Forms.ListView();
            this.NPedido = new System.Windows.Forms.ColumnHeader();
            this.VolumenPedido = new System.Windows.Forms.ColumnHeader();
            this.PesoPedido = new System.Windows.Forms.ColumnHeader();
            this.NPrioridad = new System.Windows.Forms.ColumnHeader();
            this.Destino = new System.Windows.Forms.ColumnHeader();
            this.btnDinamica = new System.Windows.Forms.Button();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxVolumen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPeso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxVolPedido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxPesoPedido = new System.Windows.Forms.TextBox();
            this.btnGreedy = new System.Windows.Forms.Button();
            this.listRecorrrido = new System.Windows.Forms.ListView();
            this.recorrido = new System.Windows.Forms.ColumnHeader();
            this.errorCombustible = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorCombustible)).BeginInit();
            this.SuspendLayout();
            // 
            // listPedidos
            // 
            this.listPedidos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NPedido,
            this.VolumenPedido,
            this.PesoPedido,
            this.NPrioridad,
            this.Destino});
            this.listPedidos.Location = new System.Drawing.Point(279, 133);
            this.listPedidos.Name = "listPedidos";
            this.listPedidos.Size = new System.Drawing.Size(584, 494);
            this.listPedidos.TabIndex = 0;
            this.listPedidos.UseCompatibleStateImageBehavior = false;
            this.listPedidos.View = System.Windows.Forms.View.Details;
            this.listPedidos.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // NPedido
            // 
            this.NPedido.Text = "Numero";
            this.NPedido.Width = 100;
            // 
            // VolumenPedido
            // 
            this.VolumenPedido.Text = "Volumen";
            this.VolumenPedido.Width = 100;
            // 
            // PesoPedido
            // 
            this.PesoPedido.Text = "Peso";
            this.PesoPedido.Width = 100;
            // 
            // NPrioridad
            // 
            this.NPrioridad.Text = "Numero de prioridad";
            this.NPrioridad.Width = 130;
            // 
            // Destino
            // 
            this.Destino.Text = "Destino";
            this.Destino.Width = 150;
            // 
            // btnDinamica
            // 
            this.btnDinamica.Location = new System.Drawing.Point(12, 23);
            this.btnDinamica.Name = "btnDinamica";
            this.btnDinamica.Size = new System.Drawing.Size(177, 38);
            this.btnDinamica.TabIndex = 1;
            this.btnDinamica.Text = "Iniciar Algoritmo Programacion Dinamica";
            this.btnDinamica.UseVisualStyleBackColor = true;
            this.btnDinamica.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(279, 41);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.ReadOnly = true;
            this.txtBoxID.Size = new System.Drawing.Size(100, 23);
            this.txtBoxID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID vehiculo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Volumen total";
            // 
            // txtBoxVolumen
            // 
            this.txtBoxVolumen.Location = new System.Drawing.Point(385, 41);
            this.txtBoxVolumen.Name = "txtBoxVolumen";
            this.txtBoxVolumen.ReadOnly = true;
            this.txtBoxVolumen.Size = new System.Drawing.Size(100, 23);
            this.txtBoxVolumen.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Peso total";
            // 
            // txtBoxPeso
            // 
            this.txtBoxPeso.Location = new System.Drawing.Point(491, 41);
            this.txtBoxPeso.Name = "txtBoxPeso";
            this.txtBoxPeso.ReadOnly = true;
            this.txtBoxPeso.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPeso.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pedidos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Vehiculo:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(491, 73);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(140, 54);
            this.btnSiguiente.TabIndex = 12;
            this.btnSiguiente.Text = "Entregar pedidos y avanzar al siguiente vehiculo";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(462, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Volumen total";
            // 
            // txtBoxVolPedido
            // 
            this.txtBoxVolPedido.Location = new System.Drawing.Point(279, 104);
            this.txtBoxVolPedido.Name = "txtBoxVolPedido";
            this.txtBoxVolPedido.ReadOnly = true;
            this.txtBoxVolPedido.Size = new System.Drawing.Size(100, 23);
            this.txtBoxVolPedido.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(385, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Peso total";
            // 
            // txtBoxPesoPedido
            // 
            this.txtBoxPesoPedido.Location = new System.Drawing.Point(385, 104);
            this.txtBoxPesoPedido.Name = "txtBoxPesoPedido";
            this.txtBoxPesoPedido.ReadOnly = true;
            this.txtBoxPesoPedido.Size = new System.Drawing.Size(100, 23);
            this.txtBoxPesoPedido.TabIndex = 17;
            // 
            // btnGreedy
            // 
            this.btnGreedy.Location = new System.Drawing.Point(12, 73);
            this.btnGreedy.Name = "btnGreedy";
            this.btnGreedy.Size = new System.Drawing.Size(177, 38);
            this.btnGreedy.TabIndex = 18;
            this.btnGreedy.Text = "Iniciar Algoritmo Voraz";
            this.btnGreedy.UseVisualStyleBackColor = true;
            this.btnGreedy.Click += new System.EventHandler(this.d_Click);
            // 
            // listRecorrrido
            // 
            this.listRecorrrido.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listRecorrrido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recorrido});
            this.listRecorrrido.Location = new System.Drawing.Point(12, 133);
            this.listRecorrrido.Name = "listRecorrrido";
            this.listRecorrrido.Size = new System.Drawing.Size(177, 494);
            this.listRecorrrido.TabIndex = 19;
            this.listRecorrrido.UseCompatibleStateImageBehavior = false;
            this.listRecorrrido.View = System.Windows.Forms.View.Details;
            // 
            // recorrido
            // 
            this.recorrido.Text = "Recorrido";
            this.recorrido.Width = 150;
            // 
            // errorCombustible
            // 
            this.errorCombustible.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(883, 639);
            this.Controls.Add(this.listRecorrrido);
            this.Controls.Add(this.btnGreedy);
            this.Controls.Add(this.txtBoxPesoPedido);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxVolPedido);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listPedidos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPeso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxVolumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.btnDinamica);
            this.Name = "Form1";
            this.Text = "Cocimundo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorCombustible)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listPedidos;
        private Button btnDinamica;
        private ColumnHeader NPedido;
        private ColumnHeader VolumenPedido;
        private ColumnHeader PesoPedido;
        private ColumnHeader NPrioridad;
        private TextBox txtBoxID;
        private Label label1;
        private Label label2;
        private TextBox txtBoxVolumen;
        private Label label3;
        private TextBox txtBoxPeso;
        private Label label4;
        private Label label5;
        private Button btnSiguiente;
        private Label label6;
        private Label label7;
        private TextBox txtBoxVolPedido;
        private Label label8;
        private TextBox txtBoxPesoPedido;
        private Button btnGreedy;
        private ColumnHeader Destino;
        private ListView listRecorrrido;
        private ColumnHeader recorrido;
        private ErrorProvider errorCombustible;
    }
}