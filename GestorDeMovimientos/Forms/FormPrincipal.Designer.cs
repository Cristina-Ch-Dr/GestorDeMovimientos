namespace GestorDeMovimientos.Forms {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            buttonAgregar = new Button();
            buttonEli = new Button();
            buttonModi = new Button();
            label2 = new Label();
            buttonAct = new Button();
            dataGridResumen = new DataGridView();
            buttonTodos = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridResumen).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(181, 38);
            label1.Name = "label1";
            label1.Size = new Size(478, 60);
            label1.TabIndex = 0;
            label1.Text = "Gestor de Movimientos";
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregar.ForeColor = Color.Indigo;
            buttonAgregar.Location = new Point(43, 352);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(207, 47);
            buttonAgregar.TabIndex = 2;
            buttonAgregar.Text = "Menu Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonEli
            // 
            buttonEli.FlatStyle = FlatStyle.Popup;
            buttonEli.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEli.ForeColor = Color.Indigo;
            buttonEli.Location = new Point(295, 352);
            buttonEli.Name = "buttonEli";
            buttonEli.Size = new Size(207, 47);
            buttonEli.TabIndex = 3;
            buttonEli.Text = "Menu Eliminar";
            buttonEli.UseVisualStyleBackColor = true;
            buttonEli.Click += buttonEli_Click;
            // 
            // buttonModi
            // 
            buttonModi.FlatStyle = FlatStyle.Popup;
            buttonModi.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModi.ForeColor = Color.Indigo;
            buttonModi.Location = new Point(551, 352);
            buttonModi.Name = "buttonModi";
            buttonModi.Size = new Size(207, 47);
            buttonModi.TabIndex = 4;
            buttonModi.Text = "Menu Modificar";
            buttonModi.UseVisualStyleBackColor = true;
            buttonModi.Click += buttonModi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(181, 137);
            label2.Name = "label2";
            label2.Size = new Size(182, 18);
            label2.TabIndex = 5;
            label2.Text = "Ultimos movimientos";
            // 
            // buttonAct
            // 
            buttonAct.FlatStyle = FlatStyle.Popup;
            buttonAct.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAct.Location = new Point(475, 136);
            buttonAct.Name = "buttonAct";
            buttonAct.Size = new Size(89, 23);
            buttonAct.TabIndex = 6;
            buttonAct.Text = "Actualizar";
            buttonAct.UseVisualStyleBackColor = true;
            buttonAct.Click += buttonAct_Click;
            // 
            // dataGridResumen
            // 
            dataGridResumen.BackgroundColor = Color.Indigo;
            dataGridResumen.BorderStyle = BorderStyle.None;
            dataGridResumen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridResumen.Location = new Point(173, 165);
            dataGridResumen.Name = "dataGridResumen";
            dataGridResumen.Size = new Size(486, 170);
            dataGridResumen.TabIndex = 7;
            // 
            // buttonTodos
            // 
            buttonTodos.FlatStyle = FlatStyle.Popup;
            buttonTodos.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonTodos.Location = new Point(570, 136);
            buttonTodos.Name = "buttonTodos";
            buttonTodos.Size = new Size(89, 23);
            buttonTodos.TabIndex = 8;
            buttonTodos.Text = "Ver Todos";
            buttonTodos.UseVisualStyleBackColor = true;
            buttonTodos.Click += buttonTodos_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonTodos);
            Controls.Add(dataGridResumen);
            Controls.Add(buttonAct);
            Controls.Add(label2);
            Controls.Add(buttonModi);
            Controls.Add(buttonEli);
            Controls.Add(buttonAgregar);
            Controls.Add(label1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load_1;
            ((System.ComponentModel.ISupportInitialize)dataGridResumen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonAgregar;
        private Button buttonEli;
        private Button buttonModi;
        private Label label2;
        private Button buttonAct;
        private DataGridView dataGridResumen;
        private Button buttonTodos;
    }
}