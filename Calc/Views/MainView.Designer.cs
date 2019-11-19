namespace Calc
{
    partial class MainView
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
            this.MainDisplay = new System.Windows.Forms.TextBox();
            this.MemoryDisplay = new System.Windows.Forms.TextBox();
            this.Comma = new System.Windows.Forms.Button();
            this.MemorySave = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplication = new System.Windows.Forms.Button();
            this.Subtraction = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.CleanAll = new System.Windows.Forms.Button();
            this.CleanEntry = new System.Windows.Forms.Button();
            this.Equally = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.CurrentAddMemory = new System.Windows.Forms.Button();
            this.CurrentSubMemory = new System.Windows.Forms.Button();
            this.MemoryClean = new System.Windows.Forms.Button();
            this.MemoryRead = new System.Windows.Forms.Button();
            this.ClothingBracket = new System.Windows.Forms.Button();
            this.OpenningBracket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDisplay.Location = new System.Drawing.Point(22, 14);
            this.MainDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(554, 39);
            this.MainDisplay.TabIndex = 0;
            this.MainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainDisplay.TextChanged += new System.EventHandler(this.MainDisplay_TextChanged);
            // 
            // MemoryDisplay
            // 
            this.MemoryDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryDisplay.Location = new System.Drawing.Point(69, 66);
            this.MemoryDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryDisplay.Name = "MemoryDisplay";
            this.MemoryDisplay.ReadOnly = true;
            this.MemoryDisplay.Size = new System.Drawing.Size(507, 30);
            this.MemoryDisplay.TabIndex = 2;
            // 
            // Comma
            // 
            this.Comma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comma.Location = new System.Drawing.Point(418, 410);
            this.Comma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(61, 71);
            this.Comma.TabIndex = 53;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // MemorySave
            // 
            this.MemorySave.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemorySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemorySave.Location = new System.Drawing.Point(211, 86);
            this.MemorySave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(61, 71);
            this.MemorySave.TabIndex = 48;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(487, 329);
            this.Division.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(63, 71);
            this.Division.TabIndex = 45;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            this.Multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiplication.Location = new System.Drawing.Point(487, 248);
            this.Multiplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(63, 71);
            this.Multiplication.TabIndex = 44;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            // 
            // Subtraction
            // 
            this.Subtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtraction.Location = new System.Drawing.Point(487, 167);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(63, 71);
            this.Subtraction.TabIndex = 43;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            // 
            // Addition
            // 
            this.Addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addition.Location = new System.Drawing.Point(487, 86);
            this.Addition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(63, 71);
            this.Addition.TabIndex = 42;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            // 
            // CleanAll
            // 
            this.CleanAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanAll.Location = new System.Drawing.Point(487, 5);
            this.CleanAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(63, 71);
            this.CleanAll.TabIndex = 40;
            this.CleanAll.Text = "C";
            this.CleanAll.UseVisualStyleBackColor = true;
            // 
            // CleanEntry
            // 
            this.CleanEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanEntry.Location = new System.Drawing.Point(418, 5);
            this.CleanEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanEntry.Name = "CleanEntry";
            this.CleanEntry.Size = new System.Drawing.Size(61, 71);
            this.CleanEntry.TabIndex = 39;
            this.CleanEntry.Text = "CE";
            this.CleanEntry.UseVisualStyleBackColor = true;
            // 
            // Equally
            // 
            this.Equally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equally.Location = new System.Drawing.Point(487, 410);
            this.Equally.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(63, 71);
            this.Equally.TabIndex = 38;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = true;
            // 
            // Two
            // 
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Location = new System.Drawing.Point(349, 167);
            this.Two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(61, 71);
            this.Two.TabIndex = 37;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            // 
            // Three
            // 
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Location = new System.Drawing.Point(418, 167);
            this.Three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(61, 71);
            this.Three.TabIndex = 36;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            // 
            // Four
            // 
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Location = new System.Drawing.Point(280, 248);
            this.Four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(61, 71);
            this.Four.TabIndex = 35;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            // 
            // Five
            // 
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Location = new System.Drawing.Point(349, 248);
            this.Five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(61, 71);
            this.Five.TabIndex = 34;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            // 
            // Six
            // 
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Location = new System.Drawing.Point(418, 248);
            this.Six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(61, 71);
            this.Six.TabIndex = 33;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Location = new System.Drawing.Point(349, 410);
            this.Zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(61, 71);
            this.Zero.TabIndex = 32;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            // 
            // Seven
            // 
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Location = new System.Drawing.Point(280, 329);
            this.Seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(61, 71);
            this.Seven.TabIndex = 31;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            // 
            // Eight
            // 
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Location = new System.Drawing.Point(349, 329);
            this.Eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(61, 71);
            this.Eight.TabIndex = 30;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            // 
            // Nine
            // 
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Location = new System.Drawing.Point(418, 329);
            this.Nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(61, 71);
            this.Nine.TabIndex = 29;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            // 
            // One
            // 
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Location = new System.Drawing.Point(280, 167);
            this.One.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(61, 71);
            this.One.TabIndex = 28;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.MemoryRead, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.MemorySave, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.MemoryClean, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentSubMemory, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrentAddMemory, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button10, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button9, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Comma, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.One, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.Two, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.Three, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.Four, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.Five, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.Zero, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.Six, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.Nine, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.Eight, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.Seven, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.Equally, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.Division, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.Multiplication, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.Subtraction, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.Addition, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.CleanAll, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.CleanEntry, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClothingBracket, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenningBracket, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button13, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(554, 486);
            this.tableLayoutPanel1.TabIndex = 54;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 71);
            this.button1.TabIndex = 55;
            this.button1.Text = "SQRT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(4, 167);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 71);
            this.button2.TabIndex = 56;
            this.button2.Text = "COS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(4, 410);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 71);
            this.button3.TabIndex = 57;
            this.button3.Text = "TG";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(4, 329);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 71);
            this.button4.TabIndex = 58;
            this.button4.Text = "CTG";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.Location = new System.Drawing.Point(4, 248);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(61, 71);
            this.button5.TabIndex = 59;
            this.button5.Text = "SIN";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.Location = new System.Drawing.Point(73, 5);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(61, 71);
            this.button6.TabIndex = 60;
            this.button6.Text = "x^2";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.Location = new System.Drawing.Point(73, 86);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(61, 71);
            this.button7.TabIndex = 61;
            this.button7.Text = "x^n";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.Location = new System.Drawing.Point(73, 167);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 71);
            this.button8.TabIndex = 62;
            this.button8.Text = "LOG";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.Location = new System.Drawing.Point(73, 248);
            this.button9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(61, 71);
            this.button9.TabIndex = 63;
            this.button9.Text = "LN";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.Location = new System.Drawing.Point(280, 410);
            this.button10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(61, 71);
            this.button10.TabIndex = 64;
            this.button10.Text = "+/-";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.Location = new System.Drawing.Point(4, 86);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(61, 71);
            this.button11.TabIndex = 62;
            this.button11.Text = "SQRT";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // CurrentAddMemory
            // 
            this.CurrentAddMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentAddMemory.Location = new System.Drawing.Point(142, 5);
            this.CurrentAddMemory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentAddMemory.Name = "CurrentAddMemory";
            this.CurrentAddMemory.Size = new System.Drawing.Size(61, 71);
            this.CurrentAddMemory.TabIndex = 65;
            this.CurrentAddMemory.Text = "M+";
            this.CurrentAddMemory.UseVisualStyleBackColor = true;
            // 
            // CurrentSubMemory
            // 
            this.CurrentSubMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentSubMemory.Location = new System.Drawing.Point(211, 5);
            this.CurrentSubMemory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentSubMemory.Name = "CurrentSubMemory";
            this.CurrentSubMemory.Size = new System.Drawing.Size(61, 71);
            this.CurrentSubMemory.TabIndex = 66;
            this.CurrentSubMemory.Text = "M-";
            this.CurrentSubMemory.UseVisualStyleBackColor = true;
            // 
            // MemoryClean
            // 
            this.MemoryClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryClean.Location = new System.Drawing.Point(280, 5);
            this.MemoryClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryClean.Name = "MemoryClean";
            this.MemoryClean.Size = new System.Drawing.Size(61, 71);
            this.MemoryClean.TabIndex = 67;
            this.MemoryClean.Text = "MC";
            this.MemoryClean.UseVisualStyleBackColor = true;
            // 
            // MemoryRead
            // 
            this.MemoryRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryRead.Location = new System.Drawing.Point(349, 5);
            this.MemoryRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Size = new System.Drawing.Size(61, 71);
            this.MemoryRead.TabIndex = 68;
            this.MemoryRead.Text = "MR";
            this.MemoryRead.UseVisualStyleBackColor = true;
            // 
            // ClothingBracket
            // 
            this.ClothingBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClothingBracket.Location = new System.Drawing.Point(418, 86);
            this.ClothingBracket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClothingBracket.Name = "ClothingBracket";
            this.ClothingBracket.Size = new System.Drawing.Size(61, 71);
            this.ClothingBracket.TabIndex = 69;
            this.ClothingBracket.Text = ")";
            this.ClothingBracket.UseVisualStyleBackColor = true;
            // 
            // OpenningBracket
            // 
            this.OpenningBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenningBracket.Location = new System.Drawing.Point(349, 86);
            this.OpenningBracket.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OpenningBracket.Name = "OpenningBracket";
            this.OpenningBracket.Size = new System.Drawing.Size(61, 71);
            this.OpenningBracket.TabIndex = 73;
            this.OpenningBracket.Text = "(";
            this.OpenningBracket.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mem";
            // 
            // button12
            // 
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.Location = new System.Drawing.Point(73, 329);
            this.button12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(61, 71);
            this.button12.TabIndex = 75;
            this.button12.Text = "N!";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.Location = new System.Drawing.Point(72, 408);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(63, 75);
            this.button13.TabIndex = 76;
            this.button13.Text = "PI";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 602);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.MemoryDisplay);
            this.Controls.Add(this.MainDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(609, 658);
            this.Name = "MainView";
            this.Text = "Калькулятор";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MainDisplay;
        private System.Windows.Forms.TextBox MemoryDisplay;
        private System.Windows.Forms.Button Comma;
        private System.Windows.Forms.Button MemorySave;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplication;
        private System.Windows.Forms.Button Subtraction;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button CleanAll;
        private System.Windows.Forms.Button CleanEntry;
        private System.Windows.Forms.Button Equally;
        private System.Windows.Forms.Button Two;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Zero;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemoryClean;
        private System.Windows.Forms.Button CurrentSubMemory;
        private System.Windows.Forms.Button CurrentAddMemory;
        private System.Windows.Forms.Button ClothingBracket;
        private System.Windows.Forms.Button OpenningBracket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
    }
}

