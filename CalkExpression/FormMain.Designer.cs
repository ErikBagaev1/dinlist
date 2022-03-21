namespace CalkExpression
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalkBackExprisstion = new System.Windows.Forms.Button();
            this.CalcExpression = new System.Windows.Forms.Button();
            this.Expesstion = new System.Windows.Forms.TextBox();
            this.BackExpresstion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalkBackExprisstion
            // 
            this.buttonCalkBackExprisstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.buttonCalkBackExprisstion.Location = new System.Drawing.Point(302, 164);
            this.buttonCalkBackExprisstion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCalkBackExprisstion.Name = "buttonCalkBackExprisstion";
            this.buttonCalkBackExprisstion.Size = new System.Drawing.Size(198, 28);
            this.buttonCalkBackExprisstion.TabIndex = 0;
            this.buttonCalkBackExprisstion.Text = "Получить польску запись";
            this.buttonCalkBackExprisstion.UseVisualStyleBackColor = true;
            this.buttonCalkBackExprisstion.Click += new System.EventHandler(this.buttonCalkBackExprisstion_Click);
            // 
            // CalcExpression
            // 
            this.CalcExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.CalcExpression.Location = new System.Drawing.Point(302, 292);
            this.CalcExpression.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalcExpression.Name = "CalcExpression";
            this.CalcExpression.Size = new System.Drawing.Size(198, 28);
            this.CalcExpression.TabIndex = 1;
            this.CalcExpression.Text = "Вычислить по обратной запис";
            this.CalcExpression.UseVisualStyleBackColor = true;
            this.CalcExpression.Click += new System.EventHandler(this.Back_Click);
            // 
            // Expesstion
            // 
            this.Expesstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.Expesstion.Location = new System.Drawing.Point(302, 135);
            this.Expesstion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Expesstion.Name = "Expesstion";
            this.Expesstion.Size = new System.Drawing.Size(198, 21);
            this.Expesstion.TabIndex = 2;
            this.Expesstion.Text = "(2*3-(7+1)/(4-5))*(4+2*3)";
            this.Expesstion.TextChanged += new System.EventHandler(this.Expesstion_TextChanged);
            // 
            // BackExpresstion
            // 
            this.BackExpresstion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.BackExpresstion.Location = new System.Drawing.Point(302, 263);
            this.BackExpresstion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackExpresstion.Name = "BackExpresstion";
            this.BackExpresstion.Size = new System.Drawing.Size(198, 21);
            this.BackExpresstion.TabIndex = 3;
            this.BackExpresstion.TextChanged += new System.EventHandler(this.BackExpresstion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(155, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввести выражение ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(158, 263);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Польская запись";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(158, 344);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(15, 16);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 554);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackExpresstion);
            this.Controls.Add(this.Expesstion);
            this.Controls.Add(this.CalcExpression);
            this.Controls.Add(this.buttonCalkBackExprisstion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalkBackExprisstion;
        private System.Windows.Forms.Button CalcExpression;
        private System.Windows.Forms.TextBox Expesstion;
        private System.Windows.Forms.TextBox BackExpresstion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelResult;
    }
}

