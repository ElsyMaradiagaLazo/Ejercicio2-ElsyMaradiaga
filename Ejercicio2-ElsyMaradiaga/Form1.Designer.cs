namespace Ejercicio2_ElsyMaradiaga
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Guardarbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EstudiantetextBox1 = new System.Windows.Forms.TextBox();
            this.EdadtextBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guardarbutton1
            // 
            this.Guardarbutton1.Location = new System.Drawing.Point(271, 176);
            this.Guardarbutton1.Name = "Guardarbutton1";
            this.Guardarbutton1.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton1.TabIndex = 0;
            this.Guardarbutton1.Text = "Guardar ";
            this.Guardarbutton1.UseVisualStyleBackColor = true;
            this.Guardarbutton1.Click += new System.EventHandler(this.Guardarbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(149, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre del estudiante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Edad:";
            // 
            // EstudiantetextBox1
            // 
            this.EstudiantetextBox1.Location = new System.Drawing.Point(286, 95);
            this.EstudiantetextBox1.Name = "EstudiantetextBox1";
            this.EstudiantetextBox1.Size = new System.Drawing.Size(100, 23);
            this.EstudiantetextBox1.TabIndex = 4;
            // 
            // EdadtextBox2
            // 
            this.EdadtextBox2.Location = new System.Drawing.Point(286, 136);
            this.EdadtextBox2.Name = "EdadtextBox2";
            this.EdadtextBox2.Size = new System.Drawing.Size(100, 23);
            this.EdadtextBox2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(179, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 199);
            this.listBox1.TabIndex = 12;
            this.listBox1.UseTabStops = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(385, 248);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 199);
            this.listBox2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Estudiantes:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Edades:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EdadtextBox2);
            this.Controls.Add(this.EstudiantetextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guardarbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Guardarbutton1;
        private Label label1;
        private Label label2;
        private TextBox EstudiantetextBox1;
        private TextBox EdadtextBox2;
        private Label label3;
        private Label label5;
        private TextBox CantidadtextBox3;
        private ListBox listBox1;
        private ListBox listBox2;
        private Label label4;
        private Label label6;
    }
}