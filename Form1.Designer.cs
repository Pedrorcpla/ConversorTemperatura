
namespace ConversorTemperatura
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Graus = new System.Windows.Forms.TextBox();
            this.CF = new System.Windows.Forms.Button();
            this.CK = new System.Windows.Forms.Button();
            this.FC = new System.Windows.Forms.Button();
            this.KC = new System.Windows.Forms.Button();
            this.FK = new System.Windows.Forms.Button();
            this.KF = new System.Windows.Forms.Button();
            this.Temperatura = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(256, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor de Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Graus:";
            // 
            // Graus
            // 
            this.Graus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Graus.Location = new System.Drawing.Point(405, 128);
            this.Graus.Name = "Graus";
            this.Graus.Size = new System.Drawing.Size(100, 33);
            this.Graus.TabIndex = 2;
            // 
            // CF
            // 
            this.CF.BackColor = System.Drawing.Color.Lime;
            this.CF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CF.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CF.Location = new System.Drawing.Point(166, 178);
            this.CF.Name = "CF";
            this.CF.Size = new System.Drawing.Size(233, 55);
            this.CF.TabIndex = 3;
            this.CF.Text = "Celsius para Fahrenheit";
            this.CF.UseVisualStyleBackColor = false;
            this.CF.Click += new System.EventHandler(this.CF_Click);
            // 
            // CK
            // 
            this.CK.BackColor = System.Drawing.Color.RoyalBlue;
            this.CK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CK.Location = new System.Drawing.Point(405, 178);
            this.CK.Name = "CK";
            this.CK.Size = new System.Drawing.Size(233, 55);
            this.CK.TabIndex = 4;
            this.CK.Text = "Celsius para Kelvin";
            this.CK.UseVisualStyleBackColor = false;
            this.CK.Click += new System.EventHandler(this.button2_Click);
            // 
            // FC
            // 
            this.FC.BackColor = System.Drawing.Color.Gold;
            this.FC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FC.Location = new System.Drawing.Point(166, 239);
            this.FC.Name = "FC";
            this.FC.Size = new System.Drawing.Size(233, 55);
            this.FC.TabIndex = 5;
            this.FC.Text = "Fahrenheit para Celsius";
            this.FC.UseVisualStyleBackColor = false;
            this.FC.Click += new System.EventHandler(this.FC_Click);
            // 
            // KC
            // 
            this.KC.BackColor = System.Drawing.Color.OrangeRed;
            this.KC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KC.Location = new System.Drawing.Point(405, 239);
            this.KC.Name = "KC";
            this.KC.Size = new System.Drawing.Size(233, 55);
            this.KC.TabIndex = 6;
            this.KC.Text = "Kelvin para Celsius";
            this.KC.UseVisualStyleBackColor = false;
            this.KC.Click += new System.EventHandler(this.KC_Click);
            // 
            // FK
            // 
            this.FK.BackColor = System.Drawing.Color.DodgerBlue;
            this.FK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FK.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FK.Location = new System.Drawing.Point(166, 300);
            this.FK.Name = "FK";
            this.FK.Size = new System.Drawing.Size(233, 55);
            this.FK.TabIndex = 7;
            this.FK.Text = "Fahrenheit para Kelvin";
            this.FK.UseVisualStyleBackColor = false;
            this.FK.Click += new System.EventHandler(this.FK_Click);
            // 
            // KF
            // 
            this.KF.BackColor = System.Drawing.Color.Green;
            this.KF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.KF.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KF.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KF.Location = new System.Drawing.Point(405, 300);
            this.KF.Name = "KF";
            this.KF.Size = new System.Drawing.Size(233, 55);
            this.KF.TabIndex = 8;
            this.KF.Text = "Kelvin par Fahrenheit";
            this.KF.UseVisualStyleBackColor = false;
            this.KF.Click += new System.EventHandler(this.KF_Click);
            // 
            // Temperatura
            // 
            this.Temperatura.AutoSize = true;
            this.Temperatura.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temperatura.Location = new System.Drawing.Point(332, 87);
            this.Temperatura.Name = "Temperatura";
            this.Temperatura.Size = new System.Drawing.Size(0, 26);
            this.Temperatura.TabIndex = 9;
            // 
            // Sair
            // 
            this.Sair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sair.Location = new System.Drawing.Point(678, 388);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(101, 29);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(791, 429);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.Temperatura);
            this.Controls.Add(this.KF);
            this.Controls.Add(this.FK);
            this.Controls.Add(this.KC);
            this.Controls.Add(this.FC);
            this.Controls.Add(this.CK);
            this.Controls.Add(this.CF);
            this.Controls.Add(this.Graus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Graus;
        private System.Windows.Forms.Button CF;
        private System.Windows.Forms.Button CK;
        private System.Windows.Forms.Button FC;
        private System.Windows.Forms.Button KC;
        private System.Windows.Forms.Button FK;
        private System.Windows.Forms.Button KF;
        private System.Windows.Forms.Label Temperatura;
        private System.Windows.Forms.Button Sair;
    }
}

