
namespace WindowsFormsAppAula1702
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
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.val1 = new System.Windows.Forms.Label();
            this.val2 = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "somar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(325, 157);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(100, 20);
            this.txtval2.TabIndex = 1;
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(325, 110);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(100, 20);
            this.txtval1.TabIndex = 2;
            // 
            // val1
            // 
            this.val1.AutoSize = true;
            this.val1.Location = new System.Drawing.Point(280, 113);
            this.val1.Name = "val1";
            this.val1.Size = new System.Drawing.Size(39, 13);
            this.val1.TabIndex = 3;
            this.val1.Text = "valor 1";
            this.val1.Click += new System.EventHandler(this.label1_Click);
            // 
            // val2
            // 
            this.val2.AutoSize = true;
            this.val2.Location = new System.Drawing.Point(280, 160);
            this.val2.Name = "val2";
            this.val2.Size = new System.Drawing.Size(39, 13);
            this.val2.TabIndex = 4;
            this.val2.Text = "valor 2";
            this.val2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(351, 277);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(30, 13);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "total ";
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.Location = new System.Drawing.Point(366, 191);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(75, 23);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "subtrair";
            this.btnSubtrair.UseVisualStyleBackColor = true;
            this.btnSubtrair.Click += new System.EventHandler(this.btnSubtrair_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(283, 235);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(75, 23);
            this.btnDividir.TabIndex = 8;
            this.btnDividir.Text = "Divisão";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(366, 235);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 9;
            this.btnMult.Text = "multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.val2);
            this.Controls.Add(this.val1);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.Label val1;
        private System.Windows.Forms.Label val2;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMult;
    }
}

