namespace CGTask6
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.OpenBTN = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.inputGB = new System.Windows.Forms.GroupBox();
            this.angleInputTB = new System.Windows.Forms.TextBox();
            this.AddBTN = new System.Windows.Forms.Button();
            this.xInputTB = new System.Windows.Forms.TextBox();
            this.yInputTB = new System.Windows.Forms.TextBox();
            this.yInputLBL = new System.Windows.Forms.Label();
            this.xInputLBL = new System.Windows.Forms.Label();
            this.heightInputLBL = new System.Windows.Forms.Label();
            this.widthInputLBL = new System.Windows.Forms.Label();
            this.heightInputTB = new System.Windows.Forms.TextBox();
            this.widthInputTB = new System.Windows.Forms.TextBox();
            this.sizeLBL = new System.Windows.Forms.Label();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.inputPB = new System.Windows.Forms.PictureBox();
            this.changeGB = new System.Windows.Forms.GroupBox();
            this.insertLBL = new System.Windows.Forms.Label();
            this.insertBTN = new System.Windows.Forms.Button();
            this.insertTb = new System.Windows.Forms.TextBox();
            this.applyBTN = new System.Windows.Forms.Button();
            this.heightTB = new System.Windows.Forms.TextBox();
            this.widthTB = new System.Windows.Forms.TextBox();
            this.heightLBL = new System.Windows.Forms.Label();
            this.widthLBL = new System.Windows.Forms.Label();
            this.mainSizeLBL = new System.Windows.Forms.Label();
            this.RotateBT = new System.Windows.Forms.Button();
            this.angleTB = new System.Windows.Forms.TextBox();
            this.photoCB = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lightPanel = new System.Windows.Forms.Panel();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.autoChooseCB = new System.Windows.Forms.CheckBox();
            this.moveLightRBT = new System.Windows.Forms.RadioButton();
            this.photoMoveRBTN = new System.Windows.Forms.RadioButton();
            this.setBackLightingBTN = new System.Windows.Forms.Button();
            this.backLighting = new System.Windows.Forms.Label();
            this.backLightingNUD = new System.Windows.Forms.NumericUpDown();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.selectColorBTN = new System.Windows.Forms.Button();
            this.lightCB = new System.Windows.Forms.ComboBox();
            this.applyLightBTN = new System.Windows.Forms.Button();
            this.AddLightBTN = new System.Windows.Forms.Button();
            this.angleLightLBL = new System.Windows.Forms.Label();
            this.positionLBL = new System.Windows.Forms.Label();
            this.yLightLBL = new System.Windows.Forms.Label();
            this.zLightLBL = new System.Windows.Forms.Label();
            this.lookTo = new System.Windows.Forms.Label();
            this.xLookToLBL = new System.Windows.Forms.Label();
            this.yLookToLBL = new System.Windows.Forms.Label();
            this.yLightTB = new System.Windows.Forms.TextBox();
            this.zLightTB = new System.Windows.Forms.TextBox();
            this.xLookToTB = new System.Windows.Forms.TextBox();
            this.yLookToTB = new System.Windows.Forms.TextBox();
            this.angleLightTB = new System.Windows.Forms.TextBox();
            this.xLightTB = new System.Windows.Forms.TextBox();
            this.xLightLBL = new System.Windows.Forms.Label();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.inputGB.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPB)).BeginInit();
            this.changeGB.SuspendLayout();
            this.lightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backLightingNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenBTN
            // 
            this.OpenBTN.Location = new System.Drawing.Point(207, 21);
            this.OpenBTN.Name = "OpenBTN";
            this.OpenBTN.Size = new System.Drawing.Size(75, 23);
            this.OpenBTN.TabIndex = 0;
            this.OpenBTN.Text = "Open";
            this.OpenBTN.UseVisualStyleBackColor = true;
            this.OpenBTN.Click += new System.EventHandler(this.OpenBTN_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // inputGB
            // 
            this.inputGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGB.Controls.Add(this.angleInputTB);
            this.inputGB.Controls.Add(this.AddBTN);
            this.inputGB.Controls.Add(this.xInputTB);
            this.inputGB.Controls.Add(this.yInputTB);
            this.inputGB.Controls.Add(this.yInputLBL);
            this.inputGB.Controls.Add(this.xInputLBL);
            this.inputGB.Controls.Add(this.heightInputLBL);
            this.inputGB.Controls.Add(this.widthInputLBL);
            this.inputGB.Controls.Add(this.heightInputTB);
            this.inputGB.Controls.Add(this.widthInputTB);
            this.inputGB.Controls.Add(this.sizeLBL);
            this.inputGB.Controls.Add(this.inputPanel);
            this.inputGB.Controls.Add(this.OpenBTN);
            this.inputGB.Location = new System.Drawing.Point(1116, 12);
            this.inputGB.Name = "inputGB";
            this.inputGB.Size = new System.Drawing.Size(288, 448);
            this.inputGB.TabIndex = 2;
            this.inputGB.TabStop = false;
            this.inputGB.Text = "inputGB";
            this.inputGB.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // angleInputTB
            // 
            this.angleInputTB.Location = new System.Drawing.Point(10, 389);
            this.angleInputTB.Name = "angleInputTB";
            this.angleInputTB.Size = new System.Drawing.Size(100, 22);
            this.angleInputTB.TabIndex = 12;
            this.angleInputTB.Text = "0";
            // 
            // AddBTN
            // 
            this.AddBTN.Location = new System.Drawing.Point(231, 296);
            this.AddBTN.Name = "AddBTN";
            this.AddBTN.Size = new System.Drawing.Size(51, 75);
            this.AddBTN.TabIndex = 11;
            this.AddBTN.Text = "Add";
            this.AddBTN.UseVisualStyleBackColor = true;
            this.AddBTN.Click += new System.EventHandler(this.AddBTN_Click);
            // 
            // xInputTB
            // 
            this.xInputTB.Location = new System.Drawing.Point(10, 341);
            this.xInputTB.Name = "xInputTB";
            this.xInputTB.Size = new System.Drawing.Size(100, 22);
            this.xInputTB.TabIndex = 10;
            this.xInputTB.Text = "0";
            // 
            // yInputTB
            // 
            this.yInputTB.Location = new System.Drawing.Point(125, 341);
            this.yInputTB.Name = "yInputTB";
            this.yInputTB.Size = new System.Drawing.Size(100, 22);
            this.yInputTB.TabIndex = 9;
            this.yInputTB.Text = "0";
            // 
            // yInputLBL
            // 
            this.yInputLBL.AutoSize = true;
            this.yInputLBL.Location = new System.Drawing.Point(129, 325);
            this.yInputLBL.Name = "yInputLBL";
            this.yInputLBL.Size = new System.Drawing.Size(17, 17);
            this.yInputLBL.TabIndex = 8;
            this.yInputLBL.Text = "Y";
            // 
            // xInputLBL
            // 
            this.xInputLBL.AutoSize = true;
            this.xInputLBL.Location = new System.Drawing.Point(10, 321);
            this.xInputLBL.Name = "xInputLBL";
            this.xInputLBL.Size = new System.Drawing.Size(17, 17);
            this.xInputLBL.TabIndex = 7;
            this.xInputLBL.Text = "X";
            // 
            // heightInputLBL
            // 
            this.heightInputLBL.AutoSize = true;
            this.heightInputLBL.Location = new System.Drawing.Point(129, 276);
            this.heightInputLBL.Name = "heightInputLBL";
            this.heightInputLBL.Size = new System.Drawing.Size(49, 17);
            this.heightInputLBL.TabIndex = 6;
            this.heightInputLBL.Text = "Height";
            // 
            // widthInputLBL
            // 
            this.widthInputLBL.AutoSize = true;
            this.widthInputLBL.Location = new System.Drawing.Point(10, 276);
            this.widthInputLBL.Name = "widthInputLBL";
            this.widthInputLBL.Size = new System.Drawing.Size(44, 17);
            this.widthInputLBL.TabIndex = 5;
            this.widthInputLBL.Text = "Width";
            // 
            // heightInputTB
            // 
            this.heightInputTB.Location = new System.Drawing.Point(125, 296);
            this.heightInputTB.Name = "heightInputTB";
            this.heightInputTB.Size = new System.Drawing.Size(100, 22);
            this.heightInputTB.TabIndex = 4;
            // 
            // widthInputTB
            // 
            this.widthInputTB.Location = new System.Drawing.Point(10, 296);
            this.widthInputTB.Name = "widthInputTB";
            this.widthInputTB.Size = new System.Drawing.Size(100, 22);
            this.widthInputTB.TabIndex = 3;
            // 
            // sizeLBL
            // 
            this.sizeLBL.AutoSize = true;
            this.sizeLBL.Location = new System.Drawing.Point(7, 27);
            this.sizeLBL.Name = "sizeLBL";
            this.sizeLBL.Size = new System.Drawing.Size(43, 17);
            this.sizeLBL.TabIndex = 2;
            this.sizeLBL.Text = "Size: ";
            // 
            // inputPanel
            // 
            this.inputPanel.AutoScroll = true;
            this.inputPanel.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.inputPanel.AutoScrollMinSize = new System.Drawing.Size(5, 5);
            this.inputPanel.AutoSize = true;
            this.inputPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.inputPanel.Controls.Add(this.inputPB);
            this.inputPanel.Location = new System.Drawing.Point(6, 60);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(276, 209);
            this.inputPanel.TabIndex = 1;
            // 
            // inputPB
            // 
            this.inputPB.Location = new System.Drawing.Point(4, 4);
            this.inputPB.Name = "inputPB";
            this.inputPB.Size = new System.Drawing.Size(257, 191);
            this.inputPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.inputPB.TabIndex = 0;
            this.inputPB.TabStop = false;
            // 
            // changeGB
            // 
            this.changeGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changeGB.Controls.Add(this.insertLBL);
            this.changeGB.Controls.Add(this.insertBTN);
            this.changeGB.Controls.Add(this.insertTb);
            this.changeGB.Controls.Add(this.applyBTN);
            this.changeGB.Controls.Add(this.heightTB);
            this.changeGB.Controls.Add(this.widthTB);
            this.changeGB.Controls.Add(this.heightLBL);
            this.changeGB.Controls.Add(this.widthLBL);
            this.changeGB.Controls.Add(this.mainSizeLBL);
            this.changeGB.Controls.Add(this.RotateBT);
            this.changeGB.Controls.Add(this.angleTB);
            this.changeGB.Controls.Add(this.photoCB);
            this.changeGB.Location = new System.Drawing.Point(1117, 467);
            this.changeGB.Name = "changeGB";
            this.changeGB.Size = new System.Drawing.Size(287, 278);
            this.changeGB.TabIndex = 4;
            this.changeGB.TabStop = false;
            this.changeGB.Text = "Change";
            // 
            // insertLBL
            // 
            this.insertLBL.AutoSize = true;
            this.insertLBL.Location = new System.Drawing.Point(7, 181);
            this.insertLBL.Name = "insertLBL";
            this.insertLBL.Size = new System.Drawing.Size(58, 17);
            this.insertLBL.TabIndex = 25;
            this.insertLBL.Text = "Position";
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(172, 178);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(75, 23);
            this.insertBTN.TabIndex = 24;
            this.insertBTN.Text = "Insert";
            this.insertBTN.UseVisualStyleBackColor = true;
            this.insertBTN.Click += new System.EventHandler(this.insertBTN_Click);
            // 
            // insertTb
            // 
            this.insertTb.Location = new System.Drawing.Point(66, 177);
            this.insertTb.Name = "insertTb";
            this.insertTb.Size = new System.Drawing.Size(100, 22);
            this.insertTb.TabIndex = 23;
            this.insertTb.Text = "0";
            // 
            // applyBTN
            // 
            this.applyBTN.Location = new System.Drawing.Point(211, 43);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(70, 42);
            this.applyBTN.TabIndex = 21;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // heightTB
            // 
            this.heightTB.Location = new System.Drawing.Point(124, 63);
            this.heightTB.Name = "heightTB";
            this.heightTB.Size = new System.Drawing.Size(81, 22);
            this.heightTB.TabIndex = 20;
            // 
            // widthTB
            // 
            this.widthTB.Location = new System.Drawing.Point(9, 63);
            this.widthTB.Name = "widthTB";
            this.widthTB.Size = new System.Drawing.Size(100, 22);
            this.widthTB.TabIndex = 19;
            // 
            // heightLBL
            // 
            this.heightLBL.AutoSize = true;
            this.heightLBL.Location = new System.Drawing.Point(128, 43);
            this.heightLBL.Name = "heightLBL";
            this.heightLBL.Size = new System.Drawing.Size(49, 17);
            this.heightLBL.TabIndex = 18;
            this.heightLBL.Text = "Height";
            // 
            // widthLBL
            // 
            this.widthLBL.AutoSize = true;
            this.widthLBL.Location = new System.Drawing.Point(9, 43);
            this.widthLBL.Name = "widthLBL";
            this.widthLBL.Size = new System.Drawing.Size(44, 17);
            this.widthLBL.TabIndex = 17;
            this.widthLBL.Text = "Width";
            // 
            // mainSizeLBL
            // 
            this.mainSizeLBL.AutoSize = true;
            this.mainSizeLBL.Location = new System.Drawing.Point(12, 22);
            this.mainSizeLBL.Name = "mainSizeLBL";
            this.mainSizeLBL.Size = new System.Drawing.Size(111, 17);
            this.mainSizeLBL.TabIndex = 16;
            this.mainSizeLBL.Text = "Main photo size:";
            // 
            // RotateBT
            // 
            this.RotateBT.Location = new System.Drawing.Point(112, 121);
            this.RotateBT.Name = "RotateBT";
            this.RotateBT.Size = new System.Drawing.Size(75, 23);
            this.RotateBT.TabIndex = 15;
            this.RotateBT.Text = "Rotate";
            this.RotateBT.UseVisualStyleBackColor = true;
            this.RotateBT.Click += new System.EventHandler(this.RotateBT_Click);
            // 
            // angleTB
            // 
            this.angleTB.Location = new System.Drawing.Point(6, 121);
            this.angleTB.Name = "angleTB";
            this.angleTB.Size = new System.Drawing.Size(100, 22);
            this.angleTB.TabIndex = 14;
            this.angleTB.Text = "0";
            // 
            // photoCB
            // 
            this.photoCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.photoCB.FormattingEnabled = true;
            this.photoCB.Location = new System.Drawing.Point(0, 91);
            this.photoCB.Name = "photoCB";
            this.photoCB.Size = new System.Drawing.Size(275, 24);
            this.photoCB.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lightPanel
            // 
            this.lightPanel.Controls.Add(this.deleteBTN);
            this.lightPanel.Controls.Add(this.autoChooseCB);
            this.lightPanel.Controls.Add(this.moveLightRBT);
            this.lightPanel.Controls.Add(this.photoMoveRBTN);
            this.lightPanel.Controls.Add(this.lightCB);
            this.lightPanel.Controls.Add(this.setBackLightingBTN);
            this.lightPanel.Controls.Add(this.backLighting);
            this.lightPanel.Controls.Add(this.backLightingNUD);
            this.lightPanel.Controls.Add(this.colorPanel);
            this.lightPanel.Controls.Add(this.selectColorBTN);
            this.lightPanel.Controls.Add(this.AddLightBTN);
            this.lightPanel.Controls.Add(this.applyLightBTN);
            this.lightPanel.Controls.Add(this.angleLightLBL);
            this.lightPanel.Controls.Add(this.positionLBL);
            this.lightPanel.Controls.Add(this.yLightLBL);
            this.lightPanel.Controls.Add(this.zLightLBL);
            this.lightPanel.Controls.Add(this.lookTo);
            this.lightPanel.Controls.Add(this.xLookToLBL);
            this.lightPanel.Controls.Add(this.yLookToLBL);
            this.lightPanel.Controls.Add(this.yLightTB);
            this.lightPanel.Controls.Add(this.zLightTB);
            this.lightPanel.Controls.Add(this.xLookToTB);
            this.lightPanel.Controls.Add(this.yLookToTB);
            this.lightPanel.Controls.Add(this.angleLightTB);
            this.lightPanel.Controls.Add(this.xLightTB);
            this.lightPanel.Controls.Add(this.xLightLBL);
            this.lightPanel.Location = new System.Drawing.Point(15, 622);
            this.lightPanel.Name = "lightPanel";
            this.lightPanel.Size = new System.Drawing.Size(1096, 123);
            this.lightPanel.TabIndex = 6;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(939, 94);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(157, 23);
            this.deleteBTN.TabIndex = 29;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // autoChooseCB
            // 
            this.autoChooseCB.AutoSize = true;
            this.autoChooseCB.Checked = true;
            this.autoChooseCB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoChooseCB.Location = new System.Drawing.Point(3, 99);
            this.autoChooseCB.Name = "autoChooseCB";
            this.autoChooseCB.Size = new System.Drawing.Size(151, 21);
            this.autoChooseCB.TabIndex = 28;
            this.autoChooseCB.Text = "Auto choose object";
            this.autoChooseCB.UseVisualStyleBackColor = true;
            // 
            // moveLightRBT
            // 
            this.moveLightRBT.AutoSize = true;
            this.moveLightRBT.Location = new System.Drawing.Point(18, 37);
            this.moveLightRBT.Name = "moveLightRBT";
            this.moveLightRBT.Size = new System.Drawing.Size(93, 21);
            this.moveLightRBT.TabIndex = 27;
            this.moveLightRBT.Text = "Move light";
            this.moveLightRBT.UseVisualStyleBackColor = true;
            // 
            // photoMoveRBTN
            // 
            this.photoMoveRBTN.AutoSize = true;
            this.photoMoveRBTN.Checked = true;
            this.photoMoveRBTN.Location = new System.Drawing.Point(18, 12);
            this.photoMoveRBTN.Name = "photoMoveRBTN";
            this.photoMoveRBTN.Size = new System.Drawing.Size(103, 21);
            this.photoMoveRBTN.TabIndex = 26;
            this.photoMoveRBTN.TabStop = true;
            this.photoMoveRBTN.Text = "Move photo";
            this.photoMoveRBTN.UseVisualStyleBackColor = true;
            // 
            // setBackLightingBTN
            // 
            this.setBackLightingBTN.Location = new System.Drawing.Point(989, -1);
            this.setBackLightingBTN.Name = "setBackLightingBTN";
            this.setBackLightingBTN.Size = new System.Drawing.Size(75, 43);
            this.setBackLightingBTN.TabIndex = 23;
            this.setBackLightingBTN.Text = "Set back lighting";
            this.setBackLightingBTN.UseVisualStyleBackColor = true;
            this.setBackLightingBTN.Click += new System.EventHandler(this.setBackLightingBTN_Click);
            // 
            // backLighting
            // 
            this.backLighting.AutoSize = true;
            this.backLighting.Location = new System.Drawing.Point(860, 0);
            this.backLighting.Name = "backLighting";
            this.backLighting.Size = new System.Drawing.Size(88, 17);
            this.backLighting.TabIndex = 22;
            this.backLighting.Text = "Back lighting";
            // 
            // backLightingNUD
            // 
            this.backLightingNUD.DecimalPlaces = 2;
            this.backLightingNUD.Increment = new decimal(new int[] {
            3,
            0,
            0,
            131072});
            this.backLightingNUD.Location = new System.Drawing.Point(863, 20);
            this.backLightingNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.backLightingNUD.Name = "backLightingNUD";
            this.backLightingNUD.Size = new System.Drawing.Size(85, 22);
            this.backLightingNUD.TabIndex = 21;
            this.backLightingNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.White;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorPanel.Location = new System.Drawing.Point(653, 70);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(30, 23);
            this.colorPanel.TabIndex = 20;
            // 
            // selectColorBTN
            // 
            this.selectColorBTN.Location = new System.Drawing.Point(709, 71);
            this.selectColorBTN.Name = "selectColorBTN";
            this.selectColorBTN.Size = new System.Drawing.Size(130, 23);
            this.selectColorBTN.TabIndex = 19;
            this.selectColorBTN.Text = "Select color";
            this.selectColorBTN.UseVisualStyleBackColor = true;
            this.selectColorBTN.Click += new System.EventHandler(this.selectColorBTN_Click);
            // 
            // lightCB
            // 
            this.lightCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightCB.FormattingEnabled = true;
            this.lightCB.Location = new System.Drawing.Point(939, 48);
            this.lightCB.Name = "lightCB";
            this.lightCB.Size = new System.Drawing.Size(157, 24);
            this.lightCB.TabIndex = 16;
            this.lightCB.SelectedIndexChanged += new System.EventHandler(this.lightCB_SelectedIndexChanged);
            // 
            // applyLightBTN
            // 
            this.applyLightBTN.Location = new System.Drawing.Point(939, 69);
            this.applyLightBTN.Name = "applyLightBTN";
            this.applyLightBTN.Size = new System.Drawing.Size(157, 27);
            this.applyLightBTN.TabIndex = 15;
            this.applyLightBTN.Text = "Apply";
            this.applyLightBTN.UseVisualStyleBackColor = true;
            this.applyLightBTN.Click += new System.EventHandler(this.applyLightBTN_Click);
            // 
            // AddLightBTN
            // 
            this.AddLightBTN.Location = new System.Drawing.Point(764, 23);
            this.AddLightBTN.Name = "AddLightBTN";
            this.AddLightBTN.Size = new System.Drawing.Size(75, 36);
            this.AddLightBTN.TabIndex = 14;
            this.AddLightBTN.Text = "Add";
            this.AddLightBTN.UseVisualStyleBackColor = true;
            this.AddLightBTN.Click += new System.EventHandler(this.AddLightBTN_Click);
            // 
            // angleLightLBL
            // 
            this.angleLightLBL.AutoSize = true;
            this.angleLightLBL.Location = new System.Drawing.Point(471, 74);
            this.angleLightLBL.Name = "angleLightLBL";
            this.angleLightLBL.Size = new System.Drawing.Size(48, 17);
            this.angleLightLBL.TabIndex = 13;
            this.angleLightLBL.Text = "Angle:";
            // 
            // positionLBL
            // 
            this.positionLBL.AutoSize = true;
            this.positionLBL.Location = new System.Drawing.Point(256, 16);
            this.positionLBL.Name = "positionLBL";
            this.positionLBL.Size = new System.Drawing.Size(58, 17);
            this.positionLBL.TabIndex = 12;
            this.positionLBL.Text = "Position";
            // 
            // yLightLBL
            // 
            this.yLightLBL.AutoSize = true;
            this.yLightLBL.Location = new System.Drawing.Point(471, 19);
            this.yLightLBL.Name = "yLightLBL";
            this.yLightLBL.Size = new System.Drawing.Size(21, 17);
            this.yLightLBL.TabIndex = 11;
            this.yLightLBL.Text = "Y:";
            // 
            // zLightLBL
            // 
            this.zLightLBL.AutoSize = true;
            this.zLightLBL.Location = new System.Drawing.Point(612, 19);
            this.zLightLBL.Name = "zLightLBL";
            this.zLightLBL.Size = new System.Drawing.Size(21, 17);
            this.zLightLBL.TabIndex = 10;
            this.zLightLBL.Text = "Z:";
            // 
            // lookTo
            // 
            this.lookTo.AutoSize = true;
            this.lookTo.Location = new System.Drawing.Point(132, 79);
            this.lookTo.Name = "lookTo";
            this.lookTo.Size = new System.Drawing.Size(56, 17);
            this.lookTo.TabIndex = 9;
            this.lookTo.Text = "LootTO";
            // 
            // xLookToLBL
            // 
            this.xLookToLBL.AutoSize = true;
            this.xLookToLBL.Location = new System.Drawing.Point(194, 77);
            this.xLookToLBL.Name = "xLookToLBL";
            this.xLookToLBL.Size = new System.Drawing.Size(21, 17);
            this.xLookToLBL.TabIndex = 8;
            this.xLookToLBL.Text = "X:";
            // 
            // yLookToLBL
            // 
            this.yLookToLBL.AutoSize = true;
            this.yLookToLBL.Location = new System.Drawing.Point(338, 76);
            this.yLookToLBL.Name = "yLookToLBL";
            this.yLookToLBL.Size = new System.Drawing.Size(21, 17);
            this.yLookToLBL.TabIndex = 7;
            this.yLookToLBL.Text = "Y:";
            // 
            // yLightTB
            // 
            this.yLightTB.Location = new System.Drawing.Point(504, 16);
            this.yLightTB.Name = "yLightTB";
            this.yLightTB.Size = new System.Drawing.Size(100, 22);
            this.yLightTB.TabIndex = 6;
            this.yLightTB.Text = "0";
            // 
            // zLightTB
            // 
            this.zLightTB.Location = new System.Drawing.Point(639, 16);
            this.zLightTB.Name = "zLightTB";
            this.zLightTB.Size = new System.Drawing.Size(100, 22);
            this.zLightTB.TabIndex = 5;
            this.zLightTB.Text = "50";
            // 
            // xLookToTB
            // 
            this.xLookToTB.Location = new System.Drawing.Point(232, 74);
            this.xLookToTB.Name = "xLookToTB";
            this.xLookToTB.Size = new System.Drawing.Size(100, 22);
            this.xLookToTB.TabIndex = 4;
            this.xLookToTB.Text = "100";
            // 
            // yLookToTB
            // 
            this.yLookToTB.Location = new System.Drawing.Point(365, 74);
            this.yLookToTB.Name = "yLookToTB";
            this.yLookToTB.Size = new System.Drawing.Size(100, 22);
            this.yLookToTB.TabIndex = 3;
            this.yLookToTB.Text = "100";
            // 
            // angleLightTB
            // 
            this.angleLightTB.Location = new System.Drawing.Point(533, 71);
            this.angleLightTB.Name = "angleLightTB";
            this.angleLightTB.Size = new System.Drawing.Size(100, 22);
            this.angleLightTB.TabIndex = 2;
            this.angleLightTB.Text = "15";
            // 
            // xLightTB
            // 
            this.xLightTB.Location = new System.Drawing.Point(355, 16);
            this.xLightTB.Name = "xLightTB";
            this.xLightTB.Size = new System.Drawing.Size(100, 22);
            this.xLightTB.TabIndex = 1;
            this.xLightTB.Text = "0";
            // 
            // xLightLBL
            // 
            this.xLightLBL.AutoSize = true;
            this.xLightLBL.Location = new System.Drawing.Point(320, 19);
            this.xLightLBL.Name = "xLightLBL";
            this.xLightLBL.Size = new System.Drawing.Size(21, 17);
            this.xLightLBL.TabIndex = 0;
            this.xLightLBL.Text = "X:";
            // 
            // paintPanel
            // 
            this.paintPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.paintPanel.Location = new System.Drawing.Point(13, 12);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(1097, 604);
            this.paintPanel.TabIndex = 7;
            this.paintPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseDown);
            this.paintPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseMove);
            this.paintPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 757);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.lightPanel);
            this.Controls.Add(this.changeGB);
            this.Controls.Add(this.inputGB);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPB_MouseUp);
            this.inputGB.ResumeLayout(false);
            this.inputGB.PerformLayout();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputPB)).EndInit();
            this.changeGB.ResumeLayout(false);
            this.changeGB.PerformLayout();
            this.lightPanel.ResumeLayout(false);
            this.lightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backLightingNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OpenBTN;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.GroupBox inputGB;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.PictureBox inputPB;
        private System.Windows.Forms.Button AddBTN;
        private System.Windows.Forms.TextBox xInputTB;
        private System.Windows.Forms.TextBox yInputTB;
        private System.Windows.Forms.Label yInputLBL;
        private System.Windows.Forms.Label xInputLBL;
        private System.Windows.Forms.Label heightInputLBL;
        private System.Windows.Forms.Label widthInputLBL;
        private System.Windows.Forms.TextBox heightInputTB;
        private System.Windows.Forms.TextBox widthInputTB;
        private System.Windows.Forms.Label sizeLBL;
        private System.Windows.Forms.TextBox angleInputTB;
        private System.Windows.Forms.GroupBox changeGB;
        private System.Windows.Forms.TextBox angleTB;
        private System.Windows.Forms.ComboBox photoCB;
        private System.Windows.Forms.Button RotateBT;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.TextBox heightTB;
        private System.Windows.Forms.TextBox widthTB;
        private System.Windows.Forms.Label heightLBL;
        private System.Windows.Forms.Label widthLBL;
        private System.Windows.Forms.Label mainSizeLBL;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel lightPanel;
        private System.Windows.Forms.ComboBox lightCB;
        private System.Windows.Forms.Button applyLightBTN;
        private System.Windows.Forms.Button AddLightBTN;
        private System.Windows.Forms.Label angleLightLBL;
        private System.Windows.Forms.Label positionLBL;
        private System.Windows.Forms.Label yLightLBL;
        private System.Windows.Forms.Label zLightLBL;
        private System.Windows.Forms.Label lookTo;
        private System.Windows.Forms.Label xLookToLBL;
        private System.Windows.Forms.Label yLookToLBL;
        private System.Windows.Forms.TextBox yLightTB;
        private System.Windows.Forms.TextBox zLightTB;
        private System.Windows.Forms.TextBox xLookToTB;
        private System.Windows.Forms.TextBox yLookToTB;
        private System.Windows.Forms.TextBox angleLightTB;
        private System.Windows.Forms.TextBox xLightTB;
        private System.Windows.Forms.Label xLightLBL;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button selectColorBTN;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.Button setBackLightingBTN;
        private System.Windows.Forms.Label backLighting;
        private System.Windows.Forms.NumericUpDown backLightingNUD;
        private System.Windows.Forms.RadioButton moveLightRBT;
        private System.Windows.Forms.RadioButton photoMoveRBTN;
        private System.Windows.Forms.CheckBox autoChooseCB;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Label insertLBL;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.TextBox insertTb;
    }
}

