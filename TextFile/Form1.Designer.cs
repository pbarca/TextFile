namespace TextFile
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.B_Gravar = new System.Windows.Forms.Button();
            this.B_Eliminar = new System.Windows.Forms.Button();
            this.B_Abrir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(519, 329);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // B_Gravar
            // 
            this.B_Gravar.Location = new System.Drawing.Point(368, 384);
            this.B_Gravar.Name = "B_Gravar";
            this.B_Gravar.Size = new System.Drawing.Size(162, 53);
            this.B_Gravar.TabIndex = 1;
            this.B_Gravar.Text = "Gravar";
            this.B_Gravar.UseVisualStyleBackColor = true;
            this.B_Gravar.Click += new System.EventHandler(this.B_Gravar_Click);
            // 
            // B_Eliminar
            // 
            this.B_Eliminar.Location = new System.Drawing.Point(190, 384);
            this.B_Eliminar.Name = "B_Eliminar";
            this.B_Eliminar.Size = new System.Drawing.Size(162, 53);
            this.B_Eliminar.TabIndex = 2;
            this.B_Eliminar.Text = "Eliminar";
            this.B_Eliminar.UseVisualStyleBackColor = true;
            this.B_Eliminar.Click += new System.EventHandler(this.B_Eliminar_Click);
            // 
            // B_Abrir
            // 
            this.B_Abrir.Location = new System.Drawing.Point(12, 384);
            this.B_Abrir.Name = "B_Abrir";
            this.B_Abrir.Size = new System.Drawing.Size(162, 53);
            this.B_Abrir.TabIndex = 3;
            this.B_Abrir.Text = "Abrir";
            this.B_Abrir.UseVisualStyleBackColor = true;
            this.B_Abrir.Click += new System.EventHandler(this.B_Abrir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 53);
            this.button1.TabIndex = 6;
            this.button1.Text = "MAIÚSCULAS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "minúsculas";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 469);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 53);
            this.button3.TabIndex = 4;
            this.button3.Text = "Iniciais Maiúsculas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.B_Abrir);
            this.Controls.Add(this.B_Eliminar);
            this.Controls.Add(this.B_Gravar);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button B_Gravar;
        private System.Windows.Forms.Button B_Eliminar;
        private System.Windows.Forms.Button B_Abrir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

