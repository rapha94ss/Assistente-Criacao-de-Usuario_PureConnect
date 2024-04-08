namespace CriadorDeUsers
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDiretorio = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtConcentrix = new System.Windows.Forms.RadioButton();
            this.rbtPointAtento = new System.Windows.Forms.RadioButton();
            this.rbtAtento = new System.Windows.Forms.RadioButton();
            this.Roles = new System.Windows.Forms.Panel();
            this.rbtAgentConcentrix = new System.Windows.Forms.RadioButton();
            this.rbtAgentAtentoPoint = new System.Windows.Forms.RadioButton();
            this.rbtAgentAtento = new System.Windows.Forms.RadioButton();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrimeiroNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Roles.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(296, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar usuário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username: ";
            // 
            // panel1
            // 
            this.panel1.AccessibleDescription = "Criação de Usuário";
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDiretorio);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Roles);
            this.panel1.Controls.Add(this.txtExtension);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtSobrenome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPrimeiroNome);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(38, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 573);
            this.panel1.TabIndex = 2;
            // 
            // btnDiretorio
            // 
            this.btnDiretorio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiretorio.Location = new System.Drawing.Point(460, 27);
            this.btnDiretorio.Name = "btnDiretorio";
            this.btnDiretorio.Size = new System.Drawing.Size(179, 37);
            this.btnDiretorio.TabIndex = 13;
            this.btnDiretorio.Text = "Escolher Diretório";
            this.btnDiretorio.UseVisualStyleBackColor = true;
            this.btnDiretorio.Click += new System.EventHandler(this.btnDiretorio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(349, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Workgroup";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Role";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.rbtConcentrix);
            this.panel2.Controls.Add(this.rbtPointAtento);
            this.panel2.Controls.Add(this.rbtAtento);
            this.panel2.Location = new System.Drawing.Point(58, 359);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 84);
            this.panel2.TabIndex = 10;
            // 
            // rbtConcentrix
            // 
            this.rbtConcentrix.AutoSize = true;
            this.rbtConcentrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtConcentrix.Location = new System.Drawing.Point(432, 34);
            this.rbtConcentrix.Name = "rbtConcentrix";
            this.rbtConcentrix.Size = new System.Drawing.Size(169, 29);
            this.rbtConcentrix.TabIndex = 10;
            this.rbtConcentrix.TabStop = true;
            this.rbtConcentrix.Text = "CONCENTRIX";
            this.rbtConcentrix.UseVisualStyleBackColor = true;
            // 
            // rbtPointAtento
            // 
            this.rbtPointAtento.AutoSize = true;
            this.rbtPointAtento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtPointAtento.Location = new System.Drawing.Point(223, 34);
            this.rbtPointAtento.Name = "rbtPointAtento";
            this.rbtPointAtento.Size = new System.Drawing.Size(192, 29);
            this.rbtPointAtento.TabIndex = 9;
            this.rbtPointAtento.TabStop = true;
            this.rbtPointAtento.Text = "POINT_ATENTO";
            this.rbtPointAtento.UseVisualStyleBackColor = true;
            // 
            // rbtAtento
            // 
            this.rbtAtento.AutoSize = true;
            this.rbtAtento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAtento.Location = new System.Drawing.Point(43, 34);
            this.rbtAtento.Name = "rbtAtento";
            this.rbtAtento.Size = new System.Drawing.Size(120, 29);
            this.rbtAtento.TabIndex = 8;
            this.rbtAtento.TabStop = true;
            this.rbtAtento.Text = "ATENTO";
            this.rbtAtento.UseVisualStyleBackColor = true;
            // 
            // Roles
            // 
            this.Roles.AccessibleName = "Roles";
            this.Roles.BackColor = System.Drawing.Color.Transparent;
            this.Roles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Roles.Controls.Add(this.rbtAgentConcentrix);
            this.Roles.Controls.Add(this.rbtAgentAtentoPoint);
            this.Roles.Controls.Add(this.rbtAgentAtento);
            this.Roles.Location = new System.Drawing.Point(58, 227);
            this.Roles.Name = "Roles";
            this.Roles.Size = new System.Drawing.Size(671, 84);
            this.Roles.TabIndex = 9;
            // 
            // rbtAgentConcentrix
            // 
            this.rbtAgentConcentrix.AutoSize = true;
            this.rbtAgentConcentrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAgentConcentrix.Location = new System.Drawing.Point(450, 30);
            this.rbtAgentConcentrix.Name = "rbtAgentConcentrix";
            this.rbtAgentConcentrix.Size = new System.Drawing.Size(183, 29);
            this.rbtAgentConcentrix.TabIndex = 7;
            this.rbtAgentConcentrix.TabStop = true;
            this.rbtAgentConcentrix.Text = "AgentConcentrix";
            this.rbtAgentConcentrix.UseVisualStyleBackColor = true;
            // 
            // rbtAgentAtentoPoint
            // 
            this.rbtAgentAtentoPoint.AutoSize = true;
            this.rbtAgentAtentoPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAgentAtentoPoint.Location = new System.Drawing.Point(238, 30);
            this.rbtAgentAtentoPoint.Name = "rbtAgentAtentoPoint";
            this.rbtAgentAtentoPoint.Size = new System.Drawing.Size(190, 29);
            this.rbtAgentAtentoPoint.TabIndex = 6;
            this.rbtAgentAtentoPoint.TabStop = true;
            this.rbtAgentAtentoPoint.Text = "AgentAtentoPoint";
            this.rbtAgentAtentoPoint.UseVisualStyleBackColor = true;
            // 
            // rbtAgentAtento
            // 
            this.rbtAgentAtento.AutoSize = true;
            this.rbtAgentAtento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtAgentAtento.Location = new System.Drawing.Point(58, 30);
            this.rbtAgentAtento.Name = "rbtAgentAtento";
            this.rbtAgentAtento.Size = new System.Drawing.Size(146, 29);
            this.rbtAgentAtento.TabIndex = 5;
            this.rbtAgentAtento.TabStop = true;
            this.rbtAgentAtento.Text = "AgentAtento";
            this.rbtAgentAtento.UseVisualStyleBackColor = true;
            // 
            // txtExtension
            // 
            this.txtExtension.AccessibleDescription = "Only numbers";
            this.txtExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(166, 152);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(204, 30);
            this.txtExtension.TabIndex = 8;
            this.txtExtension.Text = "Only numbers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Extension: ";
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSobrenome.Location = new System.Drawing.Point(166, 109);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(204, 30);
            this.txtSobrenome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sobrenome: ";
            // 
            // txtPrimeiroNome
            // 
            this.txtPrimeiroNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimeiroNome.Location = new System.Drawing.Point(166, 73);
            this.txtPrimeiroNome.Name = "txtPrimeiroNome";
            this.txtPrimeiroNome.Size = new System.Drawing.Size(204, 30);
            this.txtPrimeiroNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primeiro nome: ";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(166, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(204, 30);
            this.txtUsername.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 644);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Cadastro de Usuário";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Roles.ResumeLayout(false);
            this.Roles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrimeiroNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtConcentrix;
        private System.Windows.Forms.RadioButton rbtPointAtento;
        private System.Windows.Forms.RadioButton rbtAtento;
        private System.Windows.Forms.Panel Roles;
        private System.Windows.Forms.RadioButton rbtAgentConcentrix;
        private System.Windows.Forms.RadioButton rbtAgentAtentoPoint;
        private System.Windows.Forms.RadioButton rbtAgentAtento;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnDiretorio;
    }
}

