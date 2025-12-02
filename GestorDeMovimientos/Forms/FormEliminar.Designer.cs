namespace GestorDeMovimientos.Forms {
    partial class FormEliminar {
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
            buttonEli = new Button();
            buttonVolver = new Button();
            dataGridTodos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridTodos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Indigo;
            label1.Location = new Point(187, 47);
            label1.Name = "label1";
            label1.Size = new Size(428, 60);
            label1.TabIndex = 1;
            label1.Text = "Eliminar Movimiento";
            // 
            // buttonEli
            // 
            buttonEli.FlatStyle = FlatStyle.Popup;
            buttonEli.Font = new Font("Impact", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonEli.ForeColor = Color.Indigo;
            buttonEli.Location = new Point(327, 358);
            buttonEli.Name = "buttonEli";
            buttonEli.Size = new Size(136, 50);
            buttonEli.TabIndex = 13;
            buttonEli.Text = "Eliminar";
            buttonEli.UseVisualStyleBackColor = true;
            buttonEli.Click += buttonEli_Click;
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
            // dataGridTodos
            // 
            dataGridTodos.BackgroundColor = Color.Indigo;
            dataGridTodos.BorderStyle = BorderStyle.None;
            dataGridTodos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridTodos.Location = new Point(157, 140);
            dataGridTodos.Name = "dataGridTodos";
            dataGridTodos.Size = new Size(486, 170);
            dataGridTodos.TabIndex = 15;
            // 
            // FormEliminar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridTodos);
            Controls.Add(buttonVolver);
            Controls.Add(buttonEli);
            Controls.Add(label1);
            Name = "FormEliminar";
            Text = "FormEliminar";
            Load += FormEliminar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridTodos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button buttonEli;
        private Button buttonVolver;
        private DataGridView dataGridTodos;
    }
}