namespace Cal_formas
{
    partial class Cal
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
            cua = new RadioButton();
            rec = new RadioButton();
            tri = new RadioButton();
            cir = new RadioButton();
            acept = new Button();
            cua1 = new Label();
            num1 = new TextBox();
            rec1 = new Label();
            num2 = new TextBox();
            res = new Button();
            ar = new Label();
            pe = new Label();
            back = new Button();
            penta = new RadioButton();
            act = new Button();
            SuspendLayout();
            // 
            // cua
            // 
            cua.AutoSize = true;
            cua.Location = new Point(80, 50);
            cua.Name = "cua";
            cua.Size = new Size(77, 19);
            cua.TabIndex = 0;
            cua.TabStop = true;
            cua.Text = "Cuadrado";
            cua.UseVisualStyleBackColor = true;
            // 
            // rec
            // 
            rec.AutoSize = true;
            rec.Location = new Point(240, 50);
            rec.Name = "rec";
            rec.Size = new Size(85, 19);
            rec.TabIndex = 1;
            rec.TabStop = true;
            rec.Text = "Rectángulo";
            rec.UseVisualStyleBackColor = true;
            // 
            // tri
            // 
            tri.AutoSize = true;
            tri.Location = new Point(80, 120);
            tri.Name = "tri";
            tri.Size = new Size(74, 19);
            tri.TabIndex = 2;
            tri.TabStop = true;
            tri.Text = "Triángulo";
            tri.UseVisualStyleBackColor = true;
            // 
            // cir
            // 
            cir.AutoSize = true;
            cir.Location = new Point(240, 120);
            cir.Name = "cir";
            cir.Size = new Size(63, 19);
            cir.TabIndex = 3;
            cir.TabStop = true;
            cir.Text = "Círculo";
            cir.UseVisualStyleBackColor = true;
            // 
            // acept
            // 
            acept.Location = new Point(160, 225);
            acept.Name = "acept";
            acept.Size = new Size(75, 23);
            acept.TabIndex = 4;
            acept.Text = "Aceptar";
            acept.UseVisualStyleBackColor = true;
            acept.Click += acept_Click;
            // 
            // cua1
            // 
            cua1.AutoSize = true;
            cua1.Location = new Point(114, 52);
            cua1.Name = "cua1";
            cua1.Size = new Size(177, 15);
            cua1.TabIndex = 5;
            cua1.Text = "Medida del lado en centímetros:";
            cua1.Visible = false;
            // 
            // num1
            // 
            num1.Location = new Point(147, 76);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 6;
            num1.Visible = false;
            // 
            // rec1
            // 
            rec1.AutoSize = true;
            rec1.Location = new Point(128, 122);
            rec1.Name = "rec1";
            rec1.Size = new Size(144, 15);
            rec1.TabIndex = 7;
            rec1.Text = "Medida del segundo lado:";
            rec1.Visible = false;
            // 
            // num2
            // 
            num2.Location = new Point(147, 149);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 8;
            num2.Visible = false;
            // 
            // res
            // 
            res.Location = new Point(160, 196);
            res.Name = "res";
            res.Size = new Size(75, 23);
            res.TabIndex = 9;
            res.Text = "Calcular";
            res.UseVisualStyleBackColor = true;
            res.Visible = false;
            res.Click += res_Click;
            // 
            // ar
            // 
            ar.AutoSize = true;
            ar.Location = new Point(119, 229);
            ar.Name = "ar";
            ar.Size = new Size(38, 15);
            ar.TabIndex = 10;
            ar.Text = "label1";
            ar.Visible = false;
            // 
            // pe
            // 
            pe.AutoSize = true;
            pe.Location = new Point(137, 251);
            pe.Name = "pe";
            pe.Size = new Size(38, 15);
            pe.TabIndex = 11;
            pe.Text = "label1";
            pe.Visible = false;
            // 
            // back
            // 
            back.Location = new Point(12, 9);
            back.Name = "back";
            back.Size = new Size(27, 23);
            back.TabIndex = 12;
            back.Text = "←";
            back.UseVisualStyleBackColor = true;
            back.Visible = false;
            back.Click += back_Click;
            // 
            // penta
            // 
            penta.AutoSize = true;
            penta.Location = new Point(152, 178);
            penta.Name = "penta";
            penta.Size = new Size(83, 19);
            penta.TabIndex = 13;
            penta.TabStop = true;
            penta.Text = "Pentagono";
            penta.UseVisualStyleBackColor = true;
            // 
            // act
            // 
            act.Location = new Point(373, 271);
            act.Name = "act";
            act.Size = new Size(26, 23);
            act.TabIndex = 14;
            act.Text = "...";
            act.UseVisualStyleBackColor = true;
            act.Click += act_Click;
            // 
            // Cal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 306);
            Controls.Add(act);
            Controls.Add(penta);
            Controls.Add(back);
            Controls.Add(pe);
            Controls.Add(ar);
            Controls.Add(res);
            Controls.Add(num2);
            Controls.Add(rec1);
            Controls.Add(num1);
            Controls.Add(cua1);
            Controls.Add(acept);
            Controls.Add(cir);
            Controls.Add(tri);
            Controls.Add(rec);
            Controls.Add(cua);
            Name = "Cal";
            Text = "Calcular perímentros ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton cua;
        private RadioButton rec;
        private RadioButton tri;
        private RadioButton cir;
        private Button acept;
        private Label cua1;
        private TextBox num1;
        private Label rec1;
        private TextBox num2;
        private Button res;
        private Label ar;
        private Label pe;
        private Button back;
        private RadioButton penta;
        private Button act;
    }
}
