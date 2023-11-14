namespace EjemplosGraficos
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblMensaje = new Label();
            button2 = new Button();
            button1 = new Button();
            txtPassword = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label3 = new Label();
            button3 = new Button();
            txtContenidoPila = new TextBox();
            tabPage3 = new TabPage();
            label4 = new Label();
            button4 = new Button();
            tabPage4 = new TabPage();
            label8 = new Label();
            button7 = new Button();
            tabPage5 = new TabPage();
            label9 = new Label();
            button8 = new Button();
            label5 = new Label();
            label6 = new Label();
            button5 = new Button();
            button6 = new Button();
            label7 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(-1, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(466, 263);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(192, 192, 255);
            tabPage1.Controls.Add(lblMensaje);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(txtUsuario);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(458, 235);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Login";
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(140, 212);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(191, 182);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += informacion;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 255, 128);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(176, 125);
            button1.Name = "button1";
            button1.Size = new Size(106, 37);
            button1.TabIndex = 4;
            button1.Text = "INICIAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 79);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'X';
            txtPassword.Size = new Size(142, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(191, 34);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(142, 23);
            txtUsuario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(134, 87);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(134, 37);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txtContenidoPila);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(458, 235);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Pilas";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 243);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // button3
            // 
            button3.Location = new Point(68, 34);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "Mostrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtContenidoPila
            // 
            txtContenidoPila.Location = new Point(63, 94);
            txtContenidoPila.Multiline = true;
            txtContenidoPila.Name = "txtContenidoPila";
            txtContenidoPila.Size = new Size(353, 124);
            txtContenidoPila.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(458, 235);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Colas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 100);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 1;
            // 
            // button4
            // 
            button4.Location = new Point(52, 38);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 0;
            button4.Text = "Mostrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label8);
            tabPage4.Controls.Add(button7);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(458, 235);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Listas";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(225, 54);
            label8.Name = "label8";
            label8.Size = new Size(0, 15);
            label8.TabIndex = 1;
            // 
            // button7
            // 
            button7.Location = new Point(78, 47);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 0;
            button7.Text = "Mostrar";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(label11);
            tabPage5.Controls.Add(label10);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(label9);
            tabPage5.Controls.Add(button8);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(458, 235);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Parse";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(142, 152);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 1;
            label9.Text = "label9";
            // 
            // button8
            // 
            button8.Location = new Point(223, 104);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 0;
            button8.Text = "Sumar";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 290);
            label5.Name = "label5";
            label5.Size = new Size(166, 15);
            label5.TabIndex = 1;
            label5.Text = "Pase por referencia y por valor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 391);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 2;
            // 
            // button5
            // 
            button5.Location = new Point(28, 324);
            button5.Name = "button5";
            button5.Size = new Size(115, 23);
            button5.TabIndex = 3;
            button5.Text = "Pase por valor";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(266, 325);
            button6.Name = "button6";
            button6.Size = new Size(136, 23);
            button6.TabIndex = 4;
            button6.Text = "Pase por referencia";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 413);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(198, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(198, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(141, 36);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 4;
            label10.Text = "Num A";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(142, 74);
            label11.Name = "label11";
            label11.Size = new Size(44, 15);
            label11.TabIndex = 5;
            label11.Text = "Num B";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 644);
            Controls.Add(label7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Super ejemplos";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox txtPassword;
        private TextBox txtUsuario;
        private Button button2;
        private Label lblMensaje;
        private Button button3;
        private TextBox txtContenidoPila;
        private Label label3;
        private Button button4;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button5;
        private Button button6;
        private Label label7;
        private TabPage tabPage4;
        private Button button7;
        private Label label8;
        private TabPage tabPage5;
        private Label label9;
        private Button button8;
        private Label label11;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}