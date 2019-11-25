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
            this.MainPannelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MemoryRead = new System.Windows.Forms.Button();
            this.MemoryClean = new System.Windows.Forms.Button();
            this.CurrentSubMemory = new System.Windows.Forms.Button();
            this.CurrentAddMemory = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Cotangent = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.Memory_Add_Remove = new System.Windows.Forms.Button();
            this.SQRT = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.NPower = new System.Windows.Forms.Button();
            this.NSQRT = new System.Windows.Forms.Button();
            this.NaturalLogarithm = new System.Windows.Forms.Button();
            this.DecimalLOgarifm = new System.Windows.Forms.Button();
            this.ClothingBracket = new System.Windows.Forms.Button();
            this.OpenningBracket = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.NumberOfPI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPannelLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDisplay
            // 
            this.MainDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainDisplay.Location = new System.Drawing.Point(15, 9);
            this.MainDisplay.Name = "MainDisplay";
            this.MainDisplay.Size = new System.Drawing.Size(371, 29);
            this.MainDisplay.TabIndex = 0;
            this.MainDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MainDisplay.TextChanged += new System.EventHandler(this.MainDisplay_TextChanged);
            // 
            // MemoryDisplay
            // 
            this.MemoryDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MemoryDisplay.Location = new System.Drawing.Point(46, 43);
            this.MemoryDisplay.Name = "MemoryDisplay";
            this.MemoryDisplay.ReadOnly = true;
            this.MemoryDisplay.Size = new System.Drawing.Size(339, 23);
            this.MemoryDisplay.TabIndex = 2;
            // 
            // Comma
            // 
            this.Comma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comma.Location = new System.Drawing.Point(279, 258);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(40, 50);
            this.Comma.TabIndex = 53;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            // 
            // MemorySave
            // 
            this.MemorySave.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemorySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemorySave.Location = new System.Drawing.Point(141, 54);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(40, 45);
            this.MemorySave.TabIndex = 48;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(325, 207);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 45);
            this.Division.TabIndex = 45;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // Multiplication
            // 
            this.Multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiplication.Location = new System.Drawing.Point(325, 156);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(46, 45);
            this.Multiplication.TabIndex = 44;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            // 
            // Subtraction
            // 
            this.Subtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtraction.Location = new System.Drawing.Point(325, 105);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(46, 45);
            this.Subtraction.TabIndex = 43;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            // 
            // Addition
            // 
            this.Addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addition.Location = new System.Drawing.Point(325, 54);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(46, 45);
            this.Addition.TabIndex = 42;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            // 
            // CleanAll
            // 
            this.CleanAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanAll.Location = new System.Drawing.Point(325, 3);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(46, 45);
            this.CleanAll.TabIndex = 40;
            this.CleanAll.Text = "C";
            this.CleanAll.UseVisualStyleBackColor = true;
            // 
            // CleanEntry
            // 
            this.CleanEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanEntry.Location = new System.Drawing.Point(279, 3);
            this.CleanEntry.Name = "CleanEntry";
            this.CleanEntry.Size = new System.Drawing.Size(40, 45);
            this.CleanEntry.TabIndex = 39;
            this.CleanEntry.Text = "CE";
            this.CleanEntry.UseVisualStyleBackColor = true;
            // 
            // Equally
            // 
            this.Equally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equally.Location = new System.Drawing.Point(325, 258);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(46, 50);
            this.Equally.TabIndex = 38;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = true;
            // 
            // Two
            // 
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Location = new System.Drawing.Point(233, 105);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(40, 45);
            this.Two.TabIndex = 37;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            // 
            // Three
            // 
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Location = new System.Drawing.Point(279, 105);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(40, 45);
            this.Three.TabIndex = 36;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            // 
            // Four
            // 
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Location = new System.Drawing.Point(187, 156);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(40, 45);
            this.Four.TabIndex = 35;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            // 
            // Five
            // 
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Location = new System.Drawing.Point(233, 156);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(40, 45);
            this.Five.TabIndex = 34;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            // 
            // Six
            // 
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Location = new System.Drawing.Point(279, 156);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(40, 45);
            this.Six.TabIndex = 33;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            // 
            // Zero
            // 
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Location = new System.Drawing.Point(233, 258);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(40, 50);
            this.Zero.TabIndex = 32;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            // 
            // Seven
            // 
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Location = new System.Drawing.Point(187, 207);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(40, 45);
            this.Seven.TabIndex = 31;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            // 
            // Eight
            // 
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Location = new System.Drawing.Point(233, 207);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(40, 45);
            this.Eight.TabIndex = 30;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            // 
            // Nine
            // 
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Location = new System.Drawing.Point(279, 207);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(40, 45);
            this.Nine.TabIndex = 29;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            // 
            // One
            // 
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Location = new System.Drawing.Point(187, 105);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(40, 45);
            this.One.TabIndex = 28;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            // 
            // MainPannelLayout
            // 
            this.MainPannelLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPannelLayout.ColumnCount = 8;
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.Controls.Add(this.MemoryRead, 5, 0);
            this.MainPannelLayout.Controls.Add(this.MemorySave, 3, 1);
            this.MainPannelLayout.Controls.Add(this.MemoryClean, 4, 0);
            this.MainPannelLayout.Controls.Add(this.CurrentSubMemory, 3, 0);
            this.MainPannelLayout.Controls.Add(this.CurrentAddMemory, 2, 0);
            this.MainPannelLayout.Controls.Add(this.Tangent, 0, 5);
            this.MainPannelLayout.Controls.Add(this.Cotangent, 0, 4);
            this.MainPannelLayout.Controls.Add(this.Sinus, 0, 3);
            this.MainPannelLayout.Controls.Add(this.Memory_Add_Remove, 4, 5);
            this.MainPannelLayout.Controls.Add(this.SQRT, 0, 0);
            this.MainPannelLayout.Controls.Add(this.Power, 1, 0);
            this.MainPannelLayout.Controls.Add(this.Cosinus, 0, 2);
            this.MainPannelLayout.Controls.Add(this.NPower, 1, 1);
            this.MainPannelLayout.Controls.Add(this.NSQRT, 0, 1);
            this.MainPannelLayout.Controls.Add(this.NaturalLogarithm, 1, 3);
            this.MainPannelLayout.Controls.Add(this.DecimalLOgarifm, 1, 2);
            this.MainPannelLayout.Controls.Add(this.Comma, 6, 5);
            this.MainPannelLayout.Controls.Add(this.One, 4, 2);
            this.MainPannelLayout.Controls.Add(this.Two, 5, 2);
            this.MainPannelLayout.Controls.Add(this.Three, 6, 2);
            this.MainPannelLayout.Controls.Add(this.Four, 4, 3);
            this.MainPannelLayout.Controls.Add(this.Five, 5, 3);
            this.MainPannelLayout.Controls.Add(this.Zero, 5, 5);
            this.MainPannelLayout.Controls.Add(this.Six, 6, 3);
            this.MainPannelLayout.Controls.Add(this.Nine, 6, 4);
            this.MainPannelLayout.Controls.Add(this.Eight, 5, 4);
            this.MainPannelLayout.Controls.Add(this.Seven, 4, 4);
            this.MainPannelLayout.Controls.Add(this.Equally, 7, 5);
            this.MainPannelLayout.Controls.Add(this.Division, 7, 4);
            this.MainPannelLayout.Controls.Add(this.Multiplication, 7, 3);
            this.MainPannelLayout.Controls.Add(this.Subtraction, 7, 2);
            this.MainPannelLayout.Controls.Add(this.Addition, 7, 1);
            this.MainPannelLayout.Controls.Add(this.CleanAll, 7, 0);
            this.MainPannelLayout.Controls.Add(this.CleanEntry, 6, 0);
            this.MainPannelLayout.Controls.Add(this.ClothingBracket, 6, 1);
            this.MainPannelLayout.Controls.Add(this.OpenningBracket, 5, 1);
            this.MainPannelLayout.Controls.Add(this.Factorial, 1, 4);
            this.MainPannelLayout.Controls.Add(this.NumberOfPI, 1, 5);
            this.MainPannelLayout.Location = new System.Drawing.Point(12, 68);
            this.MainPannelLayout.Margin = new System.Windows.Forms.Padding(2);
            this.MainPannelLayout.Name = "MainPannelLayout";
            this.MainPannelLayout.RowCount = 6;
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.Size = new System.Drawing.Size(374, 311);
            this.MainPannelLayout.TabIndex = 54;
            this.MainPannelLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MemoryRead
            // 
            this.MemoryRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryRead.Location = new System.Drawing.Point(233, 3);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Size = new System.Drawing.Size(40, 45);
            this.MemoryRead.TabIndex = 68;
            this.MemoryRead.Text = "MR";
            this.MemoryRead.UseVisualStyleBackColor = true;
            // 
            // MemoryClean
            // 
            this.MemoryClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryClean.Location = new System.Drawing.Point(187, 3);
            this.MemoryClean.Name = "MemoryClean";
            this.MemoryClean.Size = new System.Drawing.Size(40, 45);
            this.MemoryClean.TabIndex = 67;
            this.MemoryClean.Text = "MC";
            this.MemoryClean.UseVisualStyleBackColor = true;
            // 
            // CurrentSubMemory
            // 
            this.CurrentSubMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentSubMemory.Location = new System.Drawing.Point(141, 3);
            this.CurrentSubMemory.Name = "CurrentSubMemory";
            this.CurrentSubMemory.Size = new System.Drawing.Size(40, 45);
            this.CurrentSubMemory.TabIndex = 66;
            this.CurrentSubMemory.Text = "M-";
            this.CurrentSubMemory.UseVisualStyleBackColor = true;
            // 
            // CurrentAddMemory
            // 
            this.CurrentAddMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentAddMemory.Location = new System.Drawing.Point(95, 3);
            this.CurrentAddMemory.Name = "CurrentAddMemory";
            this.CurrentAddMemory.Size = new System.Drawing.Size(40, 45);
            this.CurrentAddMemory.TabIndex = 65;
            this.CurrentAddMemory.Text = "M+";
            this.CurrentAddMemory.UseVisualStyleBackColor = true;
            // 
            // Tangent
            // 
            this.Tangent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tangent.Location = new System.Drawing.Point(3, 258);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(40, 50);
            this.Tangent.TabIndex = 57;
            this.Tangent.Text = "TG";
            this.Tangent.UseVisualStyleBackColor = true;
            // 
            // Cotangent
            // 
            this.Cotangent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cotangent.Location = new System.Drawing.Point(3, 207);
            this.Cotangent.Name = "Cotangent";
            this.Cotangent.Size = new System.Drawing.Size(40, 45);
            this.Cotangent.TabIndex = 58;
            this.Cotangent.Text = "CTG";
            this.Cotangent.UseVisualStyleBackColor = true;
            // 
            // Sinus
            // 
            this.Sinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sinus.Location = new System.Drawing.Point(3, 156);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(40, 45);
            this.Sinus.TabIndex = 59;
            this.Sinus.Text = "SIN";
            this.Sinus.UseVisualStyleBackColor = true;
            // 
            // Memory_Add_Remove
            // 
            this.Memory_Add_Remove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Memory_Add_Remove.Location = new System.Drawing.Point(187, 258);
            this.Memory_Add_Remove.Name = "Memory_Add_Remove";
            this.Memory_Add_Remove.Size = new System.Drawing.Size(40, 50);
            this.Memory_Add_Remove.TabIndex = 64;
            this.Memory_Add_Remove.Text = "+/-";
            this.Memory_Add_Remove.UseVisualStyleBackColor = true;
            this.Memory_Add_Remove.Click += new System.EventHandler(this.button10_Click);
            // 
            // SQRT
            // 
            this.SQRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQRT.Location = new System.Drawing.Point(3, 3);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(40, 45);
            this.SQRT.TabIndex = 55;
            this.SQRT.Text = "SQRT";
            this.SQRT.UseVisualStyleBackColor = true;
            // 
            // Power
            // 
            this.Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Power.Location = new System.Drawing.Point(49, 3);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(40, 45);
            this.Power.TabIndex = 60;
            this.Power.Text = "x^2";
            this.Power.UseVisualStyleBackColor = true;
            // 
            // Cosinus
            // 
            this.Cosinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cosinus.Location = new System.Drawing.Point(3, 105);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(40, 45);
            this.Cosinus.TabIndex = 56;
            this.Cosinus.Text = "COS";
            this.Cosinus.UseVisualStyleBackColor = true;
            // 
            // NPower
            // 
            this.NPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NPower.Location = new System.Drawing.Point(49, 54);
            this.NPower.Name = "NPower";
            this.NPower.Size = new System.Drawing.Size(40, 45);
            this.NPower.TabIndex = 61;
            this.NPower.Text = "x^n";
            this.NPower.UseVisualStyleBackColor = true;
            // 
            // NSQRT
            // 
            this.NSQRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSQRT.Location = new System.Drawing.Point(3, 54);
            this.NSQRT.Name = "NSQRT";
            this.NSQRT.Size = new System.Drawing.Size(40, 45);
            this.NSQRT.TabIndex = 62;
            this.NSQRT.Text = "NSQRT";
            this.NSQRT.UseVisualStyleBackColor = true;
            // 
            // NaturalLogarithm
            // 
            this.NaturalLogarithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NaturalLogarithm.Location = new System.Drawing.Point(49, 156);
            this.NaturalLogarithm.Name = "NaturalLogarithm";
            this.NaturalLogarithm.Size = new System.Drawing.Size(40, 45);
            this.NaturalLogarithm.TabIndex = 63;
            this.NaturalLogarithm.Text = "LN";
            this.NaturalLogarithm.UseVisualStyleBackColor = true;
            // 
            // DecimalLOgarifm
            // 
            this.DecimalLOgarifm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecimalLOgarifm.Location = new System.Drawing.Point(49, 105);
            this.DecimalLOgarifm.Name = "DecimalLOgarifm";
            this.DecimalLOgarifm.Size = new System.Drawing.Size(40, 45);
            this.DecimalLOgarifm.TabIndex = 62;
            this.DecimalLOgarifm.Text = "LOG";
            this.DecimalLOgarifm.UseVisualStyleBackColor = true;
            // 
            // ClothingBracket
            // 
            this.ClothingBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClothingBracket.Location = new System.Drawing.Point(279, 54);
            this.ClothingBracket.Name = "ClothingBracket";
            this.ClothingBracket.Size = new System.Drawing.Size(40, 45);
            this.ClothingBracket.TabIndex = 69;
            this.ClothingBracket.Text = ")";
            this.ClothingBracket.UseVisualStyleBackColor = true;
            // 
            // OpenningBracket
            // 
            this.OpenningBracket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenningBracket.Location = new System.Drawing.Point(233, 54);
            this.OpenningBracket.Name = "OpenningBracket";
            this.OpenningBracket.Size = new System.Drawing.Size(40, 45);
            this.OpenningBracket.TabIndex = 73;
            this.OpenningBracket.Text = "(";
            this.OpenningBracket.UseVisualStyleBackColor = true;
            // 
            // Factorial
            // 
            this.Factorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Factorial.Location = new System.Drawing.Point(49, 207);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(40, 45);
            this.Factorial.TabIndex = 75;
            this.Factorial.Text = "N!";
            this.Factorial.UseVisualStyleBackColor = true;
            // 
            // NumberOfPI
            // 
            this.NumberOfPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOfPI.Location = new System.Drawing.Point(48, 257);
            this.NumberOfPI.Margin = new System.Windows.Forms.Padding(2);
            this.NumberOfPI.Name = "NumberOfPI";
            this.NumberOfPI.Size = new System.Drawing.Size(42, 52);
            this.NumberOfPI.TabIndex = 76;
            this.NumberOfPI.Text = "PI";
            this.NumberOfPI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mem";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPannelLayout);
            this.Controls.Add(this.MemoryDisplay);
            this.Controls.Add(this.MainDisplay);
            this.MinimumSize = new System.Drawing.Size(411, 441);
            this.Name = "MainView";
            this.Text = "Калькулятор";
            this.MainPannelLayout.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel MainPannelLayout;
        private System.Windows.Forms.Button SQRT;
        private System.Windows.Forms.Button Cosinus;
        private System.Windows.Forms.Button Tangent;
        private System.Windows.Forms.Button Cotangent;
        private System.Windows.Forms.Button Sinus;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button NPower;
        private System.Windows.Forms.Button DecimalLOgarifm;
        private System.Windows.Forms.Button NaturalLogarithm;
        private System.Windows.Forms.Button Memory_Add_Remove;
        private System.Windows.Forms.Button NSQRT;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemoryClean;
        private System.Windows.Forms.Button CurrentSubMemory;
        private System.Windows.Forms.Button CurrentAddMemory;
        private System.Windows.Forms.Button ClothingBracket;
        private System.Windows.Forms.Button OpenningBracket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button NumberOfPI;
    }
}

