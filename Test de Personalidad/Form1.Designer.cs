namespace Test_de_Personalidad
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleANDQuestions = new System.Windows.Forms.Label();
            this.LabelInst = new System.Windows.Forms.Label();
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleANDQuestions
            // 
            this.TitleANDQuestions.Font = new System.Drawing.Font("Constantia", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleANDQuestions.Location = new System.Drawing.Point(12, 9);
            this.TitleANDQuestions.Name = "TitleANDQuestions";
            this.TitleANDQuestions.Size = new System.Drawing.Size(776, 197);
            this.TitleANDQuestions.TabIndex = 0;
            this.TitleANDQuestions.Text = "Bienvenido al Test de Personalidad";
            this.TitleANDQuestions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelInst
            // 
            this.LabelInst.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LabelInst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInst.Location = new System.Drawing.Point(12, 235);
            this.LabelInst.Name = "LabelInst";
            this.LabelInst.Size = new System.Drawing.Size(464, 206);
            this.LabelInst.TabIndex = 1;
            this.LabelInst.Text = resources.GetString("LabelInst.Text");
            // 
            // BtnStart
            // 
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(598, 308);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(113, 51);
            this.BtnStart.TabIndex = 2;
            this.BtnStart.Text = "¡ Iniciar Test !";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // BtnYes
            // 
            this.BtnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnYes.Location = new System.Drawing.Point(1, 1);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(1, 1);
            this.BtnYes.TabIndex = 3;
            this.BtnYes.UseVisualStyleBackColor = false;
            this.BtnYes.Click += new System.EventHandler(this.BtnYes_Click);
            // 
            // BtnNo
            // 
            this.BtnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNo.Location = new System.Drawing.Point(1, 1);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(1, 1);
            this.BtnNo.TabIndex = 4;
            this.BtnNo.UseVisualStyleBackColor = false;
            this.BtnNo.Click += new System.EventHandler(this.BtnNo_Click);
            // 
            // LabelResult
            // 
            this.LabelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LabelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.Location = new System.Drawing.Point(1, 1);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(1, 1);
            this.LabelResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.LabelInst);
            this.Controls.Add(this.TitleANDQuestions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TitleANDQuestions;
        private System.Windows.Forms.Label LabelInst;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
        private System.Windows.Forms.Label LabelResult;
    }
}

