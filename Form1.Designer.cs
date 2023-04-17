namespace activitat11
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
            label1 = new Label();
            label2 = new Label();
            textBox31 = new TextBox();
            button29 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(129, 9);
            label1.Name = "label1";
            label1.Size = new Size(108, 39);
            label1.TabIndex = 1;
            label1.Text = "Wordle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(38, 57);
            label2.Name = "label2";
            label2.Size = new Size(290, 17);
            label2.TabIndex = 2;
            label2.Text = "Introdueix una paraula de 5 lletres per començar";
            // 
            // textBox31
            // 
            textBox31.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox31.Location = new Point(65, 94);
            textBox31.Name = "textBox31";
            textBox31.PasswordChar = '*';
            textBox31.Size = new Size(111, 27);
            textBox31.TabIndex = 61;
            textBox31.Text = "prova";
            // 
            // button29
            // 
            button29.Font = new Font("MV Boli", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button29.Location = new Point(202, 93);
            button29.Name = "button29";
            button29.Size = new Size(94, 28);
            button29.TabIndex = 62;
            button29.Text = "Enviar";
            button29.UseVisualStyleBackColor = true;
            button29.Click += button29_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 133);
            Controls.Add(button29);
            Controls.Add(textBox31);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox31;
        private Button button29;
    }
}