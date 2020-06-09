namespace Passaparola_Oyunu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblBos = new System.Windows.Forms.Label();
            this.LblYanlis = new System.Windows.Forms.Label();
            this.LblDogru = new System.Windows.Forms.Label();
            this.LblSoruNo = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BtnZ = new Passaparola_Game.yuvarlakbuton();
            this.BtnY = new Passaparola_Game.yuvarlakbuton();
            this.BtnV = new Passaparola_Game.yuvarlakbuton();
            this.BtnU = new Passaparola_Game.yuvarlakbuton();
            this.BtnT = new Passaparola_Game.yuvarlakbuton();
            this.BtnS = new Passaparola_Game.yuvarlakbuton();
            this.BtnR = new Passaparola_Game.yuvarlakbuton();
            this.BtnP = new Passaparola_Game.yuvarlakbuton();
            this.BtnO = new Passaparola_Game.yuvarlakbuton();
            this.BtnM = new Passaparola_Game.yuvarlakbuton();
            this.BtnL = new Passaparola_Game.yuvarlakbuton();
            this.BtnK = new Passaparola_Game.yuvarlakbuton();
            this.BtnI = new Passaparola_Game.yuvarlakbuton();
            this.BtnH = new Passaparola_Game.yuvarlakbuton();
            this.BtnG = new Passaparola_Game.yuvarlakbuton();
            this.BtnF = new Passaparola_Game.yuvarlakbuton();
            this.BtnE = new Passaparola_Game.yuvarlakbuton();
            this.BtnC = new Passaparola_Game.yuvarlakbuton();
            this.BtnD = new Passaparola_Game.yuvarlakbuton();
            this.BtnB = new Passaparola_Game.yuvarlakbuton();
            this.BtnA = new Passaparola_Game.yuvarlakbuton();
            this.label1 = new System.Windows.Forms.Label();
            this.LblKasa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Stencil", 67.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(229, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(821, 133);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSAPAROLA";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(781, 165);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(478, 313);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(781, 500);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 42);
            this.textBox1.TabIndex = 33;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(138, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(304, 68);
            this.label2.TabIndex = 35;
            this.label2.Text = "Soru No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(216, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 68);
            this.label4.TabIndex = 36;
            this.label4.Text = "Doğru:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(216, 528);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 68);
            this.label5.TabIndex = 37;
            this.label5.Text = "Yanlış:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(257, 621);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 68);
            this.label6.TabIndex = 38;
            this.label6.Text = "Boş:";
            this.label6.Visible = false;
            // 
            // LblBos
            // 
            this.LblBos.AutoSize = true;
            this.LblBos.BackColor = System.Drawing.Color.Transparent;
            this.LblBos.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LblBos.Location = new System.Drawing.Point(404, 621);
            this.LblBos.Name = "LblBos";
            this.LblBos.Size = new System.Drawing.Size(69, 68);
            this.LblBos.TabIndex = 39;
            this.LblBos.Text = "0";
            this.LblBos.Visible = false;
            // 
            // LblYanlis
            // 
            this.LblYanlis.AutoSize = true;
            this.LblYanlis.BackColor = System.Drawing.Color.Transparent;
            this.LblYanlis.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblYanlis.ForeColor = System.Drawing.Color.Red;
            this.LblYanlis.Location = new System.Drawing.Point(459, 528);
            this.LblYanlis.Name = "LblYanlis";
            this.LblYanlis.Size = new System.Drawing.Size(69, 68);
            this.LblYanlis.TabIndex = 40;
            this.LblYanlis.Text = "0";
            this.LblYanlis.Visible = false;
            // 
            // LblDogru
            // 
            this.LblDogru.AutoSize = true;
            this.LblDogru.BackColor = System.Drawing.Color.Transparent;
            this.LblDogru.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDogru.ForeColor = System.Drawing.Color.Lime;
            this.LblDogru.Location = new System.Drawing.Point(446, 425);
            this.LblDogru.Name = "LblDogru";
            this.LblDogru.Size = new System.Drawing.Size(69, 68);
            this.LblDogru.TabIndex = 41;
            this.LblDogru.Text = "0";
            this.LblDogru.Visible = false;
            // 
            // LblSoruNo
            // 
            this.LblSoruNo.AutoSize = true;
            this.LblSoruNo.BackColor = System.Drawing.Color.Transparent;
            this.LblSoruNo.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSoruNo.Location = new System.Drawing.Point(424, 307);
            this.LblSoruNo.Name = "LblSoruNo";
            this.LblSoruNo.Size = new System.Drawing.Size(69, 68);
            this.LblSoruNo.TabIndex = 42;
            this.LblSoruNo.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(935, 543);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(162, 46);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "BAŞLA";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BtnZ
            // 
            this.BtnZ.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnZ.BackgroundImage")));
            this.BtnZ.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnZ.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZ.Location = new System.Drawing.Point(240, 123);
            this.BtnZ.Name = "BtnZ";
            this.BtnZ.Size = new System.Drawing.Size(81, 81);
            this.BtnZ.TabIndex = 29;
            this.BtnZ.Text = "Z";
            this.BtnZ.UseVisualStyleBackColor = true;
            // 
            // BtnY
            // 
            this.BtnY.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnY.BackgroundImage")));
            this.BtnY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnY.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnY.Location = new System.Drawing.Point(152, 160);
            this.BtnY.Name = "BtnY";
            this.BtnY.Size = new System.Drawing.Size(81, 81);
            this.BtnY.TabIndex = 28;
            this.BtnY.Text = "Y";
            this.BtnY.UseVisualStyleBackColor = true;
            // 
            // BtnV
            // 
            this.BtnV.BackColor = System.Drawing.Color.Transparent;
            this.BtnV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnV.BackgroundImage")));
            this.BtnV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnV.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnV.Location = new System.Drawing.Point(81, 223);
            this.BtnV.Name = "BtnV";
            this.BtnV.Size = new System.Drawing.Size(81, 81);
            this.BtnV.TabIndex = 27;
            this.BtnV.Text = "V";
            this.BtnV.UseVisualStyleBackColor = false;
            // 
            // BtnU
            // 
            this.BtnU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnU.BackgroundImage")));
            this.BtnU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnU.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnU.Location = new System.Drawing.Point(36, 294);
            this.BtnU.Name = "BtnU";
            this.BtnU.Size = new System.Drawing.Size(81, 81);
            this.BtnU.TabIndex = 26;
            this.BtnU.Text = "U";
            this.BtnU.UseVisualStyleBackColor = true;
            // 
            // BtnT
            // 
            this.BtnT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnT.BackgroundImage")));
            this.BtnT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnT.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnT.Location = new System.Drawing.Point(20, 381);
            this.BtnT.Name = "BtnT";
            this.BtnT.Size = new System.Drawing.Size(81, 81);
            this.BtnT.TabIndex = 25;
            this.BtnT.Text = "T";
            this.BtnT.UseVisualStyleBackColor = true;
            // 
            // BtnS
            // 
            this.BtnS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnS.BackgroundImage")));
            this.BtnS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnS.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnS.Location = new System.Drawing.Point(20, 471);
            this.BtnS.Name = "BtnS";
            this.BtnS.Size = new System.Drawing.Size(81, 81);
            this.BtnS.TabIndex = 24;
            this.BtnS.Text = "S";
            this.BtnS.UseVisualStyleBackColor = true;
            // 
            // BtnR
            // 
            this.BtnR.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnR.BackgroundImage")));
            this.BtnR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnR.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnR.Location = new System.Drawing.Point(54, 557);
            this.BtnR.Name = "BtnR";
            this.BtnR.Size = new System.Drawing.Size(81, 81);
            this.BtnR.TabIndex = 23;
            this.BtnR.Text = "R";
            this.BtnR.UseVisualStyleBackColor = true;
            // 
            // BtnP
            // 
            this.BtnP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnP.BackgroundImage")));
            this.BtnP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnP.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP.Location = new System.Drawing.Point(114, 629);
            this.BtnP.Name = "BtnP";
            this.BtnP.Size = new System.Drawing.Size(81, 81);
            this.BtnP.TabIndex = 22;
            this.BtnP.Text = "P";
            this.BtnP.UseVisualStyleBackColor = true;
            // 
            // BtnO
            // 
            this.BtnO.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnO.BackgroundImage")));
            this.BtnO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnO.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnO.Location = new System.Drawing.Point(188, 683);
            this.BtnO.Name = "BtnO";
            this.BtnO.Size = new System.Drawing.Size(81, 81);
            this.BtnO.TabIndex = 21;
            this.BtnO.Text = "O";
            this.BtnO.UseVisualStyleBackColor = true;
            // 
            // BtnM
            // 
            this.BtnM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnM.BackgroundImage")));
            this.BtnM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnM.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnM.Location = new System.Drawing.Point(285, 717);
            this.BtnM.Name = "BtnM";
            this.BtnM.Size = new System.Drawing.Size(81, 81);
            this.BtnM.TabIndex = 20;
            this.BtnM.Text = "M";
            this.BtnM.UseVisualStyleBackColor = true;
            // 
            // BtnL
            // 
            this.BtnL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnL.BackgroundImage")));
            this.BtnL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnL.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnL.Location = new System.Drawing.Point(383, 717);
            this.BtnL.Name = "BtnL";
            this.BtnL.Size = new System.Drawing.Size(81, 81);
            this.BtnL.TabIndex = 19;
            this.BtnL.Text = "L";
            this.BtnL.UseVisualStyleBackColor = true;
            // 
            // BtnK
            // 
            this.BtnK.BackgroundImage = global::Passaparola_Oyunu.Properties.Resources.para1;
            this.BtnK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnK.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnK.Location = new System.Drawing.Point(471, 683);
            this.BtnK.Name = "BtnK";
            this.BtnK.Size = new System.Drawing.Size(81, 81);
            this.BtnK.TabIndex = 18;
            this.BtnK.Text = "K";
            this.BtnK.UseVisualStyleBackColor = true;
            // 
            // BtnI
            // 
            this.BtnI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnI.BackgroundImage")));
            this.BtnI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnI.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnI.Location = new System.Drawing.Point(543, 629);
            this.BtnI.Name = "BtnI";
            this.BtnI.Size = new System.Drawing.Size(81, 81);
            this.BtnI.TabIndex = 17;
            this.BtnI.Text = "İ";
            this.BtnI.UseVisualStyleBackColor = true;
            // 
            // BtnH
            // 
            this.BtnH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnH.BackgroundImage")));
            this.BtnH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnH.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnH.Location = new System.Drawing.Point(596, 552);
            this.BtnH.Name = "BtnH";
            this.BtnH.Size = new System.Drawing.Size(81, 81);
            this.BtnH.TabIndex = 16;
            this.BtnH.Text = "H";
            this.BtnH.UseVisualStyleBackColor = true;
            // 
            // BtnG
            // 
            this.BtnG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnG.BackgroundImage")));
            this.BtnG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnG.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnG.Location = new System.Drawing.Point(628, 471);
            this.BtnG.Name = "BtnG";
            this.BtnG.Size = new System.Drawing.Size(81, 81);
            this.BtnG.TabIndex = 15;
            this.BtnG.Text = "G";
            this.BtnG.UseVisualStyleBackColor = true;
            // 
            // BtnF
            // 
            this.BtnF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnF.BackgroundImage")));
            this.BtnF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnF.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnF.Location = new System.Drawing.Point(628, 381);
            this.BtnF.Name = "BtnF";
            this.BtnF.Size = new System.Drawing.Size(81, 81);
            this.BtnF.TabIndex = 14;
            this.BtnF.Text = "F";
            this.BtnF.UseVisualStyleBackColor = true;
            // 
            // BtnE
            // 
            this.BtnE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnE.BackgroundImage")));
            this.BtnE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnE.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnE.Location = new System.Drawing.Point(607, 294);
            this.BtnE.Name = "BtnE";
            this.BtnE.Size = new System.Drawing.Size(81, 81);
            this.BtnE.TabIndex = 13;
            this.BtnE.Text = "E";
            this.BtnE.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnC.BackgroundImage")));
            this.BtnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnC.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnC.Location = new System.Drawing.Point(499, 160);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(81, 81);
            this.BtnC.TabIndex = 12;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = true;
            // 
            // BtnD
            // 
            this.BtnD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnD.BackgroundImage")));
            this.BtnD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnD.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnD.Location = new System.Drawing.Point(563, 223);
            this.BtnD.Name = "BtnD";
            this.BtnD.Size = new System.Drawing.Size(81, 81);
            this.BtnD.TabIndex = 11;
            this.BtnD.Text = "D";
            this.BtnD.UseVisualStyleBackColor = true;
            // 
            // BtnB
            // 
            this.BtnB.BackgroundImage = global::Passaparola_Oyunu.Properties.Resources.para1;
            this.BtnB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnB.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnB.Location = new System.Drawing.Point(412, 123);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(81, 81);
            this.BtnB.TabIndex = 10;
            this.BtnB.Text = "B";
            this.BtnB.UseVisualStyleBackColor = true;
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.Transparent;
            this.BtnA.BackgroundImage = global::Passaparola_Oyunu.Properties.Resources.para1;
            this.BtnA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnA.Font = new System.Drawing.Font("Elephant", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnA.Location = new System.Drawing.Point(327, 106);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(81, 81);
            this.BtnA.TabIndex = 9;
            this.BtnA.Text = "A";
            this.BtnA.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 54);
            this.label1.TabIndex = 44;
            this.label1.Text = "KASA:";
            // 
            // LblKasa
            // 
            this.LblKasa.AutoSize = true;
            this.LblKasa.BackColor = System.Drawing.Color.Transparent;
            this.LblKasa.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKasa.Location = new System.Drawing.Point(397, 222);
            this.LblKasa.Name = "LblKasa";
            this.LblKasa.Size = new System.Drawing.Size(55, 54);
            this.LblKasa.TabIndex = 45;
            this.LblKasa.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::Passaparola_Oyunu.Properties.Resources.a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1272, 817);
            this.Controls.Add(this.LblKasa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LblSoruNo);
            this.Controls.Add(this.LblDogru);
            this.Controls.Add(this.LblYanlis);
            this.Controls.Add(this.LblBos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnZ);
            this.Controls.Add(this.BtnY);
            this.Controls.Add(this.BtnV);
            this.Controls.Add(this.BtnU);
            this.Controls.Add(this.BtnT);
            this.Controls.Add(this.BtnS);
            this.Controls.Add(this.BtnR);
            this.Controls.Add(this.BtnP);
            this.Controls.Add(this.BtnO);
            this.Controls.Add(this.BtnM);
            this.Controls.Add(this.BtnL);
            this.Controls.Add(this.BtnK);
            this.Controls.Add(this.BtnI);
            this.Controls.Add(this.BtnH);
            this.Controls.Add(this.BtnG);
            this.Controls.Add(this.BtnF);
            this.Controls.Add(this.BtnE);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnD);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private Passaparola_Game.yuvarlakbuton BtnA;
        private Passaparola_Game.yuvarlakbuton BtnB;
        private Passaparola_Game.yuvarlakbuton BtnD;
        private Passaparola_Game.yuvarlakbuton BtnC;
        private Passaparola_Game.yuvarlakbuton BtnE;
        private Passaparola_Game.yuvarlakbuton BtnF;
        private Passaparola_Game.yuvarlakbuton BtnG;
        private Passaparola_Game.yuvarlakbuton BtnH;
        private Passaparola_Game.yuvarlakbuton BtnI;
        private Passaparola_Game.yuvarlakbuton BtnK;
        private Passaparola_Game.yuvarlakbuton BtnL;
        private Passaparola_Game.yuvarlakbuton BtnM;
        private Passaparola_Game.yuvarlakbuton BtnO;
        private Passaparola_Game.yuvarlakbuton BtnP;
        private Passaparola_Game.yuvarlakbuton BtnR;
        private Passaparola_Game.yuvarlakbuton BtnS;
        private Passaparola_Game.yuvarlakbuton BtnT;
        private Passaparola_Game.yuvarlakbuton BtnU;
        private Passaparola_Game.yuvarlakbuton BtnV;
        private Passaparola_Game.yuvarlakbuton BtnY;
        private Passaparola_Game.yuvarlakbuton BtnZ;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblBos;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblKasa;
    }
}

