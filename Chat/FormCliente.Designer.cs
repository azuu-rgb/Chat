namespace Chat
{
    partial class FormCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonEnviar = new Button();
            label2 = new Label();
            richTextBoxRespuesta = new RichTextBox();
            label1 = new Label();
            textBoxMensaje = new TextBox();
            listBoxMesaje = new ListBox();
            SuspendLayout();
            // 
            // buttonEnviar
            // 
            buttonEnviar.Location = new Point(656, 97);
            buttonEnviar.Name = "buttonEnviar";
            buttonEnviar.Size = new Size(112, 34);
            buttonEnviar.TabIndex = 10;
            buttonEnviar.Text = "ENVIAR";
            buttonEnviar.UseVisualStyleBackColor = true;
            buttonEnviar.Click += buttonEnviar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 169);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 9;
            label2.Text = "Respuesta:";
            // 
            // richTextBoxRespuesta
            // 
            richTextBoxRespuesta.Location = new Point(33, 210);
            richTextBoxRespuesta.Name = "richTextBoxRespuesta";
            richTextBoxRespuesta.Size = new Size(673, 144);
            richTextBoxRespuesta.TabIndex = 8;
            richTextBoxRespuesta.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 99);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 7;
            label1.Text = "Mensaje:";
            // 
            // textBoxMensaje
            // 
            textBoxMensaje.Location = new Point(120, 99);
            textBoxMensaje.Name = "textBoxMensaje";
            textBoxMensaje.Size = new Size(515, 31);
            textBoxMensaje.TabIndex = 6;
            // 
            // listBoxMesaje
            // 
            listBoxMesaje.FormattingEnabled = true;
            listBoxMesaje.ItemHeight = 25;
            listBoxMesaje.Location = new Point(33, 395);
            listBoxMesaje.Name = "listBoxMesaje";
            listBoxMesaje.Size = new Size(180, 129);
            listBoxMesaje.TabIndex = 11;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 575);
            Controls.Add(listBoxMesaje);
            Controls.Add(buttonEnviar);
            Controls.Add(label2);
            Controls.Add(richTextBoxRespuesta);
            Controls.Add(label1);
            Controls.Add(textBoxMensaje);
            Name = "FormCliente";
            Text = "FormCliente";
            Load += FormCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnviar;
        private Label label2;
        private RichTextBox richTextBoxRespuesta;
        private Label label1;
        private TextBox textBoxMensaje;
        private ListBox listBoxMesaje;
    }
}