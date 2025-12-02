namespace GestorDeMovimientos.Forms {
    partial class FormModificar {
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
            dataGridTodos = new DataGridView();
            textBoxDescripcion = new TextBox();
            label4 = new Label();
            buttonVolver = new Button();
            buttonModi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridTodos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(243, 31);
            label1.Name = "label1";
            label1.Size = new Size(331, 60);
            label1.TabIndex = 1;
            label1.Text = "Menu Modificar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(162, 103);
            label2.Name = "label2";
            label2.Size = new Size(467, 18);
            label2.TabIndex = 6;
            label2.Text = "Selecciona un movimiento para modificar su descripcion";
            // 
            // dataGridTodos
            // 
            dataGridTodos.BackgroundColor = Color.Indigo;
            dataGridTodos.BorderStyle = BorderStyle.None;
            dataGridTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTodos.Location = new Point(157, 140);
            dataGridTodos.Name = "dataGridTodos";
            dataGridTodos.Size = new Size(486, 170);
            dataGridTodos.TabIndex = 16;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.BorderStyle = BorderStyle.None;
            textBoxDescripcion.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescripcion.Location = new Point(393, 332);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(250, 19);
            textBoxDescripcion.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(157, 332);
            label4.Name = "label4";
            label4.Size = new Size(173, 18);
            label4.TabIndex = 18;
            label4.Text = "Nueva descripcion:";
            // 
            // buttonVolver
            // 
            buttonVolver.FlatStyle = FlatStyle.Popup;
            buttonVolver.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonVolver.Location = new Point(696, 408);
            buttonVolver.Name = "buttonVolver";
            buttonVolver.Size = new Size(92, 30);
            buttonVolver.TabIndex = 19;
            buttonVolver.Text = "Volver";
            buttonVolver.UseVisualStyleBackColor = true;
            buttonVolver.Click += buttonVolver_Click;
            // 
            // buttonModi
            // 
            buttonModi.FlatStyle = FlatStyle.Popup;
            buttonModi.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModi.ForeColor = Color.Indigo;
            buttonModi.Location = new Point(321, 368);
            buttonModi.Name = "buttonModi";
            buttonModi.Size = new Size(136, 50);
            buttonModi.TabIndex = 20;
            buttonModi.Text = "Modificar";
            buttonModi.UseVisualStyleBackColor = true;
            buttonModi.Click += buttonModi_Click;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(buttonModi);
            Controls.Add(buttonVolver);
            Controls.Add(label4);
            Controls.Add(textBoxDescripcion);
            Controls.Add(dataGridTodos);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormModificar";
            Text = "FormModificar";
            Load += FormModificar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dataGridTodos;
        private TextBox textBoxDescripcion;
        private Label label4;
        private Button buttonVolver;
        private Button buttonModi;
    }
}