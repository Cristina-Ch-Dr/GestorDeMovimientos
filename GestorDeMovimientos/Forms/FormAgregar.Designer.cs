namespace GestorDeMovimientos.Forms {
    partial class FormAgregar {
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
            label2 = new Label();
            comboBoxTipo = new ComboBox();
            label3 = new Label();
            textBoxImporte = new TextBox();
            label4 = new Label();
            textBoxDescripcion = new TextBox();
            buttonAgregar = new Button();
            buttonVolver = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(199, 35);
            label1.Name = "label1";
            label1.Size = new Size(423, 60);
            label1.TabIndex = 1;
            label1.Text = "Agregar Movimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(246, 153);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 6;
            label2.Text = "Tipo:";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.FlatStyle = FlatStyle.Popup;
            comboBoxTipo.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Location = new Point(372, 150);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(121, 26);
            comboBoxTipo.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(212, 204);
            label3.Name = "label3";
            label3.Size = new Size(86, 18);
            label3.TabIndex = 8;
            label3.Text = "Importe:";
            // 
            // textBoxImporte
            // 
            textBoxImporte.BorderStyle = BorderStyle.None;
            textBoxImporte.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxImporte.Location = new Point(372, 201);
            textBoxImporte.Name = "textBoxImporte";
            textBoxImporte.Size = new Size(121, 19);
            textBoxImporte.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(184, 245);
            label4.Name = "label4";
            label4.Size = new Size(114, 18);
            label4.TabIndex = 10;
            label4.Text = "Descripcion:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescripcion.Location = new Point(372, 245);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(250, 19);
            textBoxDescripcion.TabIndex = 11;
            // 
            // buttonAgregar
            // 
            buttonAgregar.FlatStyle = FlatStyle.Popup;
            buttonAgregar.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAgregar.ForeColor = Color.Indigo;
            buttonAgregar.Location = new Point(318, 353);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(136, 50);
            buttonAgregar.TabIndex = 12;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += button1_Click;
            // 
            // buttonVolver
            // 
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVolver.Location = new Point(696, 408);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(92, 30);
            buttonVolver.TabIndex = 13;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += button2_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonVolver);
            Controls.Add(buttonAgregar);
            Controls.Add(textBoxDescripcion);
            Controls.Add(label4);
            Controls.Add(textBoxImporte);
            Controls.Add(label3);
            Controls.Add(comboBoxTipo);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAgregar";
            Text = "FormAgregar";
            Load += FormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBoxTipo;
        private Label label3;
        private TextBox textBoxImporte;
        private Label label4;
        private TextBox textBoxDescripcion;
        private Button buttonAgregar;
        private Button buttonVolver;
    }
}