namespace Chat
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
            textBoxMensaje = new TextBox();
            label1 = new Label();
            richTextBoxRespuesta = new RichTextBox();
            label2 = new Label();
            buttonEnviar = new Button();
            SuspendLayout();
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(140, 41);
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(515, 31);
            textBoxMensaje.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 41);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 1;
            label1.Text = "Mensaje:";
            // 
            // richTextBoxRespuesta
            // 
            richTextBoxRespuesta.Location = new Point(53, 152);
            richTextBoxRespuesta.Name = "richTextBoxRespuesta";
            richTextBoxRespuesta.Size = new Size(673, 144);
            richTextBoxRespuesta.TabIndex = 3;
            richTextBoxRespuesta.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 111);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 4;
            label2.Text = "Respuesta:";
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(676, 39);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(112, 34);
            buttonEnviar.TabIndex = 5;
            buttonEnviar.Text = "ENVIAR";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEnviar);
            Controls.Add(label2);
            Controls.Add(richTextBoxRespuesta);
            Controls.Add(label1);
            Controls.Add(textBoxMensaje);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMensaje;
        private Label label1;
        private RichTextBox richTextBoxRespuesta;
        private Label label2;
        private Button buttonEnviar;
    }
}
