namespace GestorDeTareasWinForms
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
            add_btn = new Button();
            titulo_txt = new Label();
            titulo_field = new TextBox();
            listBox1 = new ListBox();
            desc_txt = new Label();
            datetime_field = new DateTimePicker();
            desc_field = new TextBox();
            label1 = new Label();
            modify_btn = new Button();
            delete_btn = new Button();
            complete_btn = new Button();
            priority_chkbox = new CheckBox();
            priority_text = new Label();
            SuspendLayout();
            // 
            // add_btn
            // 
            add_btn.Location = new Point(113, 225);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(113, 38);
            add_btn.TabIndex = 4;
            add_btn.Text = "Añadir Tarea";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // titulo_txt
            // 
            titulo_txt.AutoSize = true;
            titulo_txt.Location = new Point(12, 12);
            titulo_txt.Name = "titulo_txt";
            titulo_txt.Size = new Size(37, 15);
            titulo_txt.TabIndex = 1;
            titulo_txt.Text = "Titulo";
            // 
            // titulo_field
            // 
            titulo_field.Location = new Point(113, 9);
            titulo_field.Name = "titulo_field";
            titulo_field.Size = new Size(274, 23);
            titulo_field.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Consolas", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(486, 9);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 184);
            listBox1.TabIndex = 3;
            // 
            // desc_txt
            // 
            desc_txt.AutoSize = true;
            desc_txt.Location = new Point(12, 46);
            desc_txt.Name = "desc_txt";
            desc_txt.Size = new Size(69, 15);
            desc_txt.TabIndex = 4;
            desc_txt.Text = "Descripción";
            // 
            // datetime_field
            // 
            datetime_field.Location = new Point(113, 163);
            datetime_field.Name = "datetime_field";
            datetime_field.Size = new Size(274, 23);
            datetime_field.TabIndex = 3;
            // 
            // desc_field
            // 
            desc_field.Location = new Point(113, 43);
            desc_field.Multiline = true;
            desc_field.Name = "desc_field";
            desc_field.Size = new Size(274, 103);
            desc_field.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 163);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 7;
            label1.Text = "Fecha y Hora";
            // 
            // modify_btn
            // 
            modify_btn.Location = new Point(486, 199);
            modify_btn.Name = "modify_btn";
            modify_btn.Size = new Size(74, 38);
            modify_btn.TabIndex = 8;
            modify_btn.Text = "Modificar Tarea";
            modify_btn.UseVisualStyleBackColor = true;
            modify_btn.Click += modificar_btn_Click;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(566, 199);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(71, 38);
            delete_btn.TabIndex = 9;
            delete_btn.Text = "Eliminar Tarea";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
            // 
            // complete_btn
            // 
            complete_btn.Location = new Point(643, 199);
            complete_btn.Name = "complete_btn";
            complete_btn.Size = new Size(71, 38);
            complete_btn.TabIndex = 10;
            complete_btn.Text = "Marcar Completada";
            complete_btn.UseVisualStyleBackColor = true;
            complete_btn.Click += complete_btn_Click;
            // 
            // priority_chkbox
            // 
            priority_chkbox.AutoSize = true;
            priority_chkbox.Location = new Point(113, 198);
            priority_chkbox.Name = "priority_chkbox";
            priority_chkbox.Size = new Size(15, 14);
            priority_chkbox.TabIndex = 11;
            priority_chkbox.UseVisualStyleBackColor = true;
            // 
            // priority_text
            // 
            priority_text.AutoSize = true;
            priority_text.Location = new Point(12, 198);
            priority_text.Name = "priority_text";
            priority_text.Size = new Size(58, 15);
            priority_text.TabIndex = 12;
            priority_text.Text = "Prioritaria";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 275);
            Controls.Add(priority_text);
            Controls.Add(priority_chkbox);
            Controls.Add(complete_btn);
            Controls.Add(delete_btn);
            Controls.Add(modify_btn);
            Controls.Add(label1);
            Controls.Add(desc_field);
            Controls.Add(datetime_field);
            Controls.Add(desc_txt);
            Controls.Add(listBox1);
            Controls.Add(titulo_field);
            Controls.Add(titulo_txt);
            Controls.Add(add_btn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_btn;
        private Label titulo_txt;
        private TextBox titulo_field;
        private ListBox listBox1;
        private Label desc_txt;
        private DateTimePicker datetime_field;
        private TextBox desc_field;
        private Label label1;
        private Button modify_btn;
        private Button delete_btn;
        private Button complete_btn;
        private CheckBox priority_chkbox;
        private Label priority_text;
    }
}
