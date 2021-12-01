
namespace Propuesto01
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
            this.components = new System.ComponentModel.Container();
            this.btn1 = new System.Windows.Forms.Button();
            this.lstbox = new System.Windows.Forms.ListBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(49, 20);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(176, 46);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "De 0 a X numero";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lstbox
            // 
            this.lstbox.FormattingEnabled = true;
            this.lstbox.ItemHeight = 15;
            this.lstbox.Location = new System.Drawing.Point(270, 20);
            this.lstbox.Name = "lstbox";
            this.lstbox.Size = new System.Drawing.Size(314, 274);
            this.lstbox.TabIndex = 1;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(49, 72);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(176, 46);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "De 0 a -X numero";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(49, 124);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(176, 46);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "De Y a X numero";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(49, 176);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(176, 46);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Pares de Y a X numero";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(49, 228);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(88, 46);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "Y a X \r\nPar";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(70, 301);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(125, 31);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numero Max :";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(401, 342);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(113, 23);
            this.txtnumero.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(401, 306);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(113, 23);
            this.txtMenor.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero Min :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Y a X \r\nImpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.lstbox);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Actividad001";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.ListBox lstbox;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

