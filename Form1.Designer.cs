
namespace GeneticAlg
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generationAmount = new System.Windows.Forms.TextBox();
            this.mutationP = new System.Windows.Forms.TextBox();
            this.crossbreedingP = new System.Windows.Forms.TextBox();
            this.fightingAmount = new System.Windows.Forms.TextBox();
            this.individualAmount = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Count = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число поколений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Число особей в поколении";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Число особей, участвующих в турнире";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Вероятность скрещивания";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Вероятность мутации";
            // 
            // generationAmount
            // 
            this.generationAmount.Location = new System.Drawing.Point(300, 7);
            this.generationAmount.Name = "generationAmount";
            this.generationAmount.Size = new System.Drawing.Size(122, 22);
            this.generationAmount.TabIndex = 5;
            this.generationAmount.Text = "5";
            this.generationAmount.TextChanged += new System.EventHandler(this.generationAmount_TextChanged);
            // 
            // mutationP
            // 
            this.mutationP.Location = new System.Drawing.Point(300, 147);
            this.mutationP.Name = "mutationP";
            this.mutationP.Size = new System.Drawing.Size(122, 22);
            this.mutationP.TabIndex = 6;
            this.mutationP.Text = "0,5";
            this.mutationP.TextChanged += new System.EventHandler(this.mutationP_TextChanged);
            // 
            // crossbreedingP
            // 
            this.crossbreedingP.Location = new System.Drawing.Point(300, 112);
            this.crossbreedingP.Name = "crossbreedingP";
            this.crossbreedingP.Size = new System.Drawing.Size(122, 22);
            this.crossbreedingP.TabIndex = 7;
            this.crossbreedingP.Text = "0,5";
            this.crossbreedingP.TextChanged += new System.EventHandler(this.crossbreedingP_TextChanged);
            // 
            // fightingAmount
            // 
            this.fightingAmount.Location = new System.Drawing.Point(300, 77);
            this.fightingAmount.Name = "fightingAmount";
            this.fightingAmount.Size = new System.Drawing.Size(122, 22);
            this.fightingAmount.TabIndex = 8;
            this.fightingAmount.Text = "5";
            this.fightingAmount.TextChanged += new System.EventHandler(this.fightingAmount_TextChanged);
            // 
            // individualAmount
            // 
            this.individualAmount.Location = new System.Drawing.Point(300, 42);
            this.individualAmount.Name = "individualAmount";
            this.individualAmount.Size = new System.Drawing.Size(122, 22);
            this.individualAmount.TabIndex = 9;
            this.individualAmount.Text = "10";
            this.individualAmount.TextChanged += new System.EventHandler(this.individualAmount_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(428, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 522);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(12, 202);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(410, 35);
            this.Count.TabIndex = 11;
            this.Count.Text = "Рассчитать";
            this.Count.UseVisualStyleBackColor = true;
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 546);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.individualAmount);
            this.Controls.Add(this.fightingAmount);
            this.Controls.Add(this.crossbreedingP);
            this.Controls.Add(this.mutationP);
            this.Controls.Add(this.generationAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox generationAmount;
        private System.Windows.Forms.TextBox mutationP;
        private System.Windows.Forms.TextBox crossbreedingP;
        private System.Windows.Forms.TextBox fightingAmount;
        private System.Windows.Forms.TextBox individualAmount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Count;
    }
}

