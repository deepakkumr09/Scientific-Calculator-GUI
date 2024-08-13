namespace Scientific_Calculator_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnBS = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPM = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnSqr = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.btnSinh = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.btnX3 = new System.Windows.Forms.Button();
            this.btnCosh = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTanh = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnBin = new System.Windows.Forms.Button();
            this.btnHex = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnlnx = new System.Windows.Forms.Button();
            this.btnExp = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnOct = new System.Windows.Forms.Button();
            this.btnPer = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.LightGray;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(17, 92);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(773, 58);
            this.txtResult.TabIndex = 0;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtResult.TextChanged += new System.EventHandler(this.txtResult_TextChanged);
            // 
            // btnBS
            // 
            this.btnBS.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBS.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBS.Location = new System.Drawing.Point(17, 160);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(89, 80);
            this.btnBS.TabIndex = 1;
            this.btnBS.Text = "Õ";
            this.btnBS.UseVisualStyleBackColor = false;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearEntry.Location = new System.Drawing.Point(110, 156);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(89, 80);
            this.btnClearEntry.TabIndex = 1;
            this.btnClearEntry.Text = "CE";
            this.btnClearEntry.UseVisualStyleBackColor = false;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(205, 156);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(89, 80);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPM.Location = new System.Drawing.Point(299, 156);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(89, 80);
            this.btnPM.TabIndex = 1;
            this.btnPM.Text = "±";
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.btnPM_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(17, 241);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(89, 80);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(205, 241);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(89, 80);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(110, 241);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(89, 80);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(299, 241);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 80);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.numberOper);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(17, 328);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(89, 80);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(205, 328);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(89, 80);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(17, 415);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(89, 80);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(110, 328);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(89, 80);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(205, 415);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(89, 80);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(110, 415);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(89, 80);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSub.Location = new System.Drawing.Point(299, 328);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(89, 80);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.numberOper);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMult.Location = new System.Drawing.Point(299, 415);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(89, 80);
            this.btnMult.TabIndex = 1;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.numberOper);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(17, 501);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(89, 80);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEquals.Location = new System.Drawing.Point(205, 500);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(89, 80);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(110, 500);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(89, 80);
            this.btnDot.TabIndex = 1;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.EnterNumbers);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Tan;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(837, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.scientificToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(56, 32);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.standardToolStripMenuItem.Text = "Standard";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // scientificToolStripMenuItem
            // 
            this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
            this.scientificToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.scientificToolStripMenuItem.Text = "Scientific";
            this.scientificToolStripMenuItem.Click += new System.EventHandler(this.scientificToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnPi
            // 
            this.btnPi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPi.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPi.Location = new System.Drawing.Point(416, 156);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(89, 80);
            this.btnPi.TabIndex = 1;
            this.btnPi.Text = "π";
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(511, 156);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(89, 80);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // btnSqr
            // 
            this.btnSqr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSqr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSqr.Location = new System.Drawing.Point(606, 156);
            this.btnSqr.Name = "btnSqr";
            this.btnSqr.Size = new System.Drawing.Size(89, 80);
            this.btnSqr.TabIndex = 1;
            this.btnSqr.Text = "Sqrt";
            this.btnSqr.UseVisualStyleBackColor = false;
            this.btnSqr.Click += new System.EventHandler(this.btnSqr_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX2.Location = new System.Drawing.Point(701, 156);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(89, 80);
            this.btnX2.TabIndex = 1;
            this.btnX2.Text = "x^2";
            this.btnX2.UseVisualStyleBackColor = false;
            this.btnX2.Click += new System.EventHandler(this.btnX2_Click);
            // 
            // btnSinh
            // 
            this.btnSinh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinh.Location = new System.Drawing.Point(416, 242);
            this.btnSinh.Name = "btnSinh";
            this.btnSinh.Size = new System.Drawing.Size(89, 80);
            this.btnSinh.TabIndex = 1;
            this.btnSinh.Text = "Sinh";
            this.btnSinh.UseVisualStyleBackColor = false;
            this.btnSinh.Click += new System.EventHandler(this.btnSinh_Click);
            // 
            // btnSin
            // 
            this.btnSin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSin.Location = new System.Drawing.Point(511, 242);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(89, 80);
            this.btnSin.TabIndex = 1;
            this.btnSin.Text = "Sin";
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.btnSin_Click);
            // 
            // btnDec
            // 
            this.btnDec.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDec.Location = new System.Drawing.Point(606, 242);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(89, 80);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Dec";
            this.btnDec.UseVisualStyleBackColor = false;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // btnX3
            // 
            this.btnX3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnX3.Location = new System.Drawing.Point(701, 242);
            this.btnX3.Name = "btnX3";
            this.btnX3.Size = new System.Drawing.Size(89, 80);
            this.btnX3.TabIndex = 1;
            this.btnX3.Text = "x^3";
            this.btnX3.UseVisualStyleBackColor = false;
            this.btnX3.Click += new System.EventHandler(this.btnX3_Click);
            // 
            // btnCosh
            // 
            this.btnCosh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCosh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCosh.Location = new System.Drawing.Point(416, 328);
            this.btnCosh.Name = "btnCosh";
            this.btnCosh.Size = new System.Drawing.Size(89, 80);
            this.btnCosh.TabIndex = 1;
            this.btnCosh.Text = "Cosh";
            this.btnCosh.UseVisualStyleBackColor = false;
            this.btnCosh.Click += new System.EventHandler(this.btnCosh_Click);
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCos.Location = new System.Drawing.Point(511, 328);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(89, 80);
            this.btnCos.TabIndex = 1;
            this.btnCos.Text = "Cos";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            // 
            // btnTanh
            // 
            this.btnTanh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTanh.Location = new System.Drawing.Point(416, 414);
            this.btnTanh.Name = "btnTanh";
            this.btnTanh.Size = new System.Drawing.Size(89, 80);
            this.btnTanh.TabIndex = 1;
            this.btnTanh.Text = "Tanh";
            this.btnTanh.UseVisualStyleBackColor = false;
            this.btnTanh.Click += new System.EventHandler(this.btnTanh_Click);
            // 
            // btnTan
            // 
            this.btnTan.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTan.Location = new System.Drawing.Point(511, 414);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(89, 80);
            this.btnTan.TabIndex = 1;
            this.btnTan.Text = "Tan";
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.btnTan_Click);
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBin.Location = new System.Drawing.Point(606, 328);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(89, 80);
            this.btnBin.TabIndex = 1;
            this.btnBin.Text = "Bin";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // btnHex
            // 
            this.btnHex.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHex.Location = new System.Drawing.Point(606, 414);
            this.btnHex.Name = "btnHex";
            this.btnHex.Size = new System.Drawing.Size(89, 80);
            this.btnHex.TabIndex = 1;
            this.btnHex.Text = "Hex";
            this.btnHex.UseVisualStyleBackColor = false;
            this.btnHex.Click += new System.EventHandler(this.btnHex_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn1x.Location = new System.Drawing.Point(701, 328);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(89, 80);
            this.btn1x.TabIndex = 1;
            this.btn1x.Text = "1x";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.btn1x_Click);
            // 
            // btnlnx
            // 
            this.btnlnx.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnlnx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnlnx.Location = new System.Drawing.Point(701, 414);
            this.btnlnx.Name = "btnlnx";
            this.btnlnx.Size = new System.Drawing.Size(89, 80);
            this.btnlnx.TabIndex = 1;
            this.btnlnx.Text = "lnx";
            this.btnlnx.UseVisualStyleBackColor = false;
            this.btnlnx.Click += new System.EventHandler(this.btnlnx_Click);
            // 
            // btnExp
            // 
            this.btnExp.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExp.Location = new System.Drawing.Point(416, 500);
            this.btnExp.Name = "btnExp";
            this.btnExp.Size = new System.Drawing.Size(89, 80);
            this.btnExp.TabIndex = 1;
            this.btnExp.Text = "Exp";
            this.btnExp.UseVisualStyleBackColor = false;
            this.btnExp.Click += new System.EventHandler(this.numberOper);
            // 
            // btnMod
            // 
            this.btnMod.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMod.Location = new System.Drawing.Point(511, 500);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(89, 80);
            this.btnMod.TabIndex = 1;
            this.btnMod.Text = "Mod";
            this.btnMod.UseVisualStyleBackColor = false;
            this.btnMod.Click += new System.EventHandler(this.numberOper);
            // 
            // btnOct
            // 
            this.btnOct.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOct.Location = new System.Drawing.Point(606, 500);
            this.btnOct.Name = "btnOct";
            this.btnOct.Size = new System.Drawing.Size(89, 80);
            this.btnOct.TabIndex = 1;
            this.btnOct.Text = "Oct";
            this.btnOct.UseVisualStyleBackColor = false;
            this.btnOct.Click += new System.EventHandler(this.btnOct_Click);
            // 
            // btnPer
            // 
            this.btnPer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPer.Location = new System.Drawing.Point(701, 500);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(89, 80);
            this.btnPer.TabIndex = 1;
            this.btnPer.Text = "%";
            this.btnPer.UseVisualStyleBackColor = false;
            this.btnPer.Click += new System.EventHandler(this.btnPer_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Location = new System.Drawing.Point(299, 500);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(89, 80);
            this.btnDiv.TabIndex = 1;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.numberOper);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Location = new System.Drawing.Point(17, 44);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 25);
            this.lblShowOp.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(837, 601);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnPer);
            this.Controls.Add(this.btnlnx);
            this.Controls.Add(this.btnX3);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnOct);
            this.Controls.Add(this.btnHex);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnBin);
            this.Controls.Add(this.btnSqr);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnTan);
            this.Controls.Add(this.btnExp);
            this.Controls.Add(this.btnSin);
            this.Controls.Add(this.btnTanh);
            this.Controls.Add(this.btnSinh);
            this.Controls.Add(this.btnCos);
            this.Controls.Add(this.btnCosh);
            this.Controls.Add(this.btnLog);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnBS);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scientific Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Button btnBS;
        private Button btnClearEntry;
        private Button btnClear;
        private Button btnPM;
        private Button btn7;
        private Button btn9;
        private Button btn8;
        private Button btnAdd;
        private Button btn4;
        private Button btn6;
        private Button btn1;
        private Button btn5;
        private Button btn3;
        private Button btn2;
        private Button btnSub;
        private Button btnMult;
        private Button btn0;
        private Button btnEquals;
        private Button btnDot;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem standardToolStripMenuItem;
        private ToolStripMenuItem scientificToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button btnPi;
        private Button btnLog;
        private Button btnSqr;
        private Button btnX2;
        private Button btnSinh;
        private Button btnSin;
        private Button btnDec;
        private Button btnX3;
        private Button btnCosh;
        private Button btnCos;
        private Button btnTanh;
        private Button btnTan;
        private Button btnBin;
        private Button btnHex;
        private Button btn1x;
        private Button btnlnx;
        private Button btnExp;
        private Button btnMod;
        private Button btnOct;
        private Button btnPer;
        private Button btnDiv;
        private Label lblShowOp;
    }
}