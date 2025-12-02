namespace GestorDeMovimientos.Forms {
    partial class FormMostrar {
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
            buttonVolver = new Button();
            label2 = new Label();
            comboBoxTipo = new ComboBox();
            buttonFiltrar = new Button();
            dataGridTodo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTodo).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(478, 60);
            label1.TabIndex = 1;
            label1.Text = "Todos los Movimientos";
            // 
            // buttonVolver
            // 
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVolver.Location = new Point(696, 408);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(92, 30);
            buttonVolver.TabIndex = 14;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 160);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 15;
            label2.Text = "Añadir filtro:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FlatStyle = FlatStyle.Popup;
            comboBoxTipo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(21, 193);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 26);
            comboBoxTipo.TabIndex = 17;
            // 
            // buttonFiltrar
            // 
            buttonFiltrar.FlatStyle = FlatStyle.Popup;
            buttonFiltrar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonFiltrar.ForeColor = Color.Indigo;
            buttonFiltrar.Location = new Point(21, 266);
            buttonFiltrar.Name = "buttonFiltrar";
            buttonFiltrar.Size = new Size(112, 41);
            buttonFiltrar.TabIndex = 18;
            buttonFiltrar.Text = "Filtrar";
            buttonFiltrar.UseVisualStyleBackColor = true;
            buttonFiltrar.Click += buttonFiltrar_Click;
            // 
            // dataGridTodo
            // 
            dataGridTodo.BackgroundColor = Color.Indigo;
            dataGridTodo.BorderStyle = BorderStyle.None;
            dataGridTodo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTodo.Location = new Point(187, 97);
            dataGridTodo.Name = "dataGridTodo";
            dataGridTodo.Size = new Size(486, 279);
            dataGridTodo.TabIndex = 19;
            // 
            // FormMostrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridTodo);
            Controls.Add(buttonFiltrar);
            Controls.Add(comboBoxTipo);
            Controls.Add(label2);
            Controls.Add(buttonVolver);
            Controls.Add(label1);
            Name = "FormMostrar";
            Text = "FormMostrar";
            Load += FormMostrar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTodo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonVolver;
        private Label label2;
        private ComboBox comboBoxTipo;
        private Button buttonFiltrar;
        private DataGridView dataGridTodo;
    }
}