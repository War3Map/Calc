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
            this.CurrentAddMemory = new System.Windows.Forms.Button();
            this.Tangent = new System.Windows.Forms.Button();
            this.Cotangent = new System.Windows.Forms.Button();
            this.Sinus = new System.Windows.Forms.Button();
            this.NegatePositiveButton = new System.Windows.Forms.Button();
            this.SQRT = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Cosinus = new System.Windows.Forms.Button();
            this.NPower = new System.Windows.Forms.Button();
            this.NSQRT = new System.Windows.Forms.Button();
            this.NaturalLogarithm = new System.Windows.Forms.Button();
            this.DecimalLOgarifm = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.NumberOfPI = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentSubMemory = new System.Windows.Forms.Button();
            this.MainPannelLayout.SuspendLayout();
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
            this.MainDisplay.TextChanged += new System.EventHandler(this.MainDisplayTextChanged);
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
            this.MemoryDisplay.Size = new System.Drawing.Size(506, 30);
            this.MemoryDisplay.TabIndex = 2;
            this.MemoryDisplay.TextChanged += new System.EventHandler(this.MemoryDisplayTextChanged);
            // 
            // Comma
            // 
            this.Comma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comma.Location = new System.Drawing.Point(376, 420);
            this.Comma.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Comma.Name = "Comma";
            this.Comma.Size = new System.Drawing.Size(85, 76);
            this.Comma.TabIndex = 53;
            this.Comma.Text = ",";
            this.Comma.UseVisualStyleBackColor = true;
            this.Comma.Click += new System.EventHandler(this.DisplayInput);
            // 
            // MemorySave
            // 
            this.MemorySave.Cursor = System.Windows.Forms.Cursors.Default;
            this.MemorySave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemorySave.Location = new System.Drawing.Point(376, 88);
            this.MemorySave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemorySave.Name = "MemorySave";
            this.MemorySave.Size = new System.Drawing.Size(85, 73);
            this.MemorySave.TabIndex = 48;
            this.MemorySave.Text = "MS";
            this.MemorySave.UseVisualStyleBackColor = true;
            this.MemorySave.Click += new System.EventHandler(this.SaveNumber);
            // 
            // Division
            // 
            this.Division.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Division.Location = new System.Drawing.Point(469, 337);
            this.Division.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(88, 73);
            this.Division.TabIndex = 45;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Multiplication
            // 
            this.Multiplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Multiplication.Location = new System.Drawing.Point(469, 254);
            this.Multiplication.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Multiplication.Name = "Multiplication";
            this.Multiplication.Size = new System.Drawing.Size(88, 73);
            this.Multiplication.TabIndex = 44;
            this.Multiplication.Text = "*";
            this.Multiplication.UseVisualStyleBackColor = true;
            this.Multiplication.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Subtraction
            // 
            this.Subtraction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Subtraction.Location = new System.Drawing.Point(469, 171);
            this.Subtraction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Subtraction.Name = "Subtraction";
            this.Subtraction.Size = new System.Drawing.Size(88, 73);
            this.Subtraction.TabIndex = 43;
            this.Subtraction.Text = "-";
            this.Subtraction.UseVisualStyleBackColor = true;
            this.Subtraction.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Addition
            // 
            this.Addition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Addition.Location = new System.Drawing.Point(469, 88);
            this.Addition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(88, 73);
            this.Addition.TabIndex = 42;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.OperationCompute);
            // 
            // CleanAll
            // 
            this.CleanAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanAll.Location = new System.Drawing.Point(469, 5);
            this.CleanAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanAll.Name = "CleanAll";
            this.CleanAll.Size = new System.Drawing.Size(88, 73);
            this.CleanAll.TabIndex = 40;
            this.CleanAll.Text = "C";
            this.CleanAll.UseVisualStyleBackColor = true;
            this.CleanAll.Click += new System.EventHandler(this.CleanAllClick);
            // 
            // CleanEntry
            // 
            this.CleanEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CleanEntry.Location = new System.Drawing.Point(376, 5);
            this.CleanEntry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CleanEntry.Name = "CleanEntry";
            this.CleanEntry.Size = new System.Drawing.Size(85, 73);
            this.CleanEntry.TabIndex = 39;
            this.CleanEntry.Text = "CE";
            this.CleanEntry.UseVisualStyleBackColor = true;
            this.CleanEntry.Click += new System.EventHandler(this.CleanEntryClick);
            // 
            // Equally
            // 
            this.Equally.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Equally.Location = new System.Drawing.Point(469, 420);
            this.Equally.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Equally.Name = "Equally";
            this.Equally.Size = new System.Drawing.Size(88, 76);
            this.Equally.TabIndex = 38;
            this.Equally.Text = "=";
            this.Equally.UseVisualStyleBackColor = true;
            this.Equally.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Two
            // 
            this.Two.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Two.Location = new System.Drawing.Point(283, 171);
            this.Two.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(85, 73);
            this.Two.TabIndex = 37;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Three
            // 
            this.Three.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Three.Location = new System.Drawing.Point(376, 171);
            this.Three.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(85, 73);
            this.Three.TabIndex = 36;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Four
            // 
            this.Four.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Four.Location = new System.Drawing.Point(190, 254);
            this.Four.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(85, 73);
            this.Four.TabIndex = 35;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Five
            // 
            this.Five.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Five.Location = new System.Drawing.Point(283, 254);
            this.Five.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(85, 73);
            this.Five.TabIndex = 34;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Six
            // 
            this.Six.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Six.Location = new System.Drawing.Point(376, 254);
            this.Six.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(85, 73);
            this.Six.TabIndex = 33;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Zero
            // 
            this.Zero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Zero.Location = new System.Drawing.Point(283, 420);
            this.Zero.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(85, 76);
            this.Zero.TabIndex = 32;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Seven
            // 
            this.Seven.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Seven.Location = new System.Drawing.Point(190, 337);
            this.Seven.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(85, 73);
            this.Seven.TabIndex = 31;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Eight
            // 
            this.Eight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Eight.Location = new System.Drawing.Point(283, 337);
            this.Eight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(85, 73);
            this.Eight.TabIndex = 30;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.DisplayInput);
            // 
            // Nine
            // 
            this.Nine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nine.Location = new System.Drawing.Point(376, 337);
            this.Nine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(85, 73);
            this.Nine.TabIndex = 29;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.DisplayInput);
            // 
            // One
            // 
            this.One.Dock = System.Windows.Forms.DockStyle.Fill;
            this.One.Location = new System.Drawing.Point(190, 171);
            this.One.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(85, 73);
            this.One.TabIndex = 28;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.DisplayInput);
            // 
            // MainPannelLayout
            // 
            this.MainPannelLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPannelLayout.ColumnCount = 6;
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.MainPannelLayout.Controls.Add(this.MemoryRead, 3, 0);
            this.MainPannelLayout.Controls.Add(this.MemoryClean, 2, 0);
            this.MainPannelLayout.Controls.Add(this.Tangent, 0, 5);
            this.MainPannelLayout.Controls.Add(this.Cotangent, 0, 4);
            this.MainPannelLayout.Controls.Add(this.Sinus, 0, 3);
            this.MainPannelLayout.Controls.Add(this.NegatePositiveButton, 2, 5);
            this.MainPannelLayout.Controls.Add(this.SQRT, 0, 0);
            this.MainPannelLayout.Controls.Add(this.Power, 1, 0);
            this.MainPannelLayout.Controls.Add(this.Cosinus, 0, 2);
            this.MainPannelLayout.Controls.Add(this.NPower, 1, 1);
            this.MainPannelLayout.Controls.Add(this.NSQRT, 0, 1);
            this.MainPannelLayout.Controls.Add(this.NaturalLogarithm, 1, 3);
            this.MainPannelLayout.Controls.Add(this.DecimalLOgarifm, 1, 2);
            this.MainPannelLayout.Controls.Add(this.Comma, 4, 5);
            this.MainPannelLayout.Controls.Add(this.One, 2, 2);
            this.MainPannelLayout.Controls.Add(this.Two, 3, 2);
            this.MainPannelLayout.Controls.Add(this.Three, 4, 2);
            this.MainPannelLayout.Controls.Add(this.Four, 2, 3);
            this.MainPannelLayout.Controls.Add(this.Five, 3, 3);
            this.MainPannelLayout.Controls.Add(this.Zero, 3, 5);
            this.MainPannelLayout.Controls.Add(this.Six, 4, 3);
            this.MainPannelLayout.Controls.Add(this.Nine, 4, 4);
            this.MainPannelLayout.Controls.Add(this.Eight, 3, 4);
            this.MainPannelLayout.Controls.Add(this.Seven, 2, 4);
            this.MainPannelLayout.Controls.Add(this.Equally, 5, 5);
            this.MainPannelLayout.Controls.Add(this.Division, 5, 4);
            this.MainPannelLayout.Controls.Add(this.Multiplication, 5, 3);
            this.MainPannelLayout.Controls.Add(this.Subtraction, 5, 2);
            this.MainPannelLayout.Controls.Add(this.Addition, 5, 1);
            this.MainPannelLayout.Controls.Add(this.CleanAll, 5, 0);
            this.MainPannelLayout.Controls.Add(this.CleanEntry, 4, 0);
            this.MainPannelLayout.Controls.Add(this.Factorial, 1, 4);
            this.MainPannelLayout.Controls.Add(this.NumberOfPI, 1, 5);
            this.MainPannelLayout.Controls.Add(this.MemorySave, 4, 1);
            this.MainPannelLayout.Controls.Add(this.CurrentSubMemory, 3, 1);
            this.MainPannelLayout.Controls.Add(this.CurrentAddMemory, 2, 1);
            this.MainPannelLayout.Location = new System.Drawing.Point(18, 105);
            this.MainPannelLayout.Name = "MainPannelLayout";
            this.MainPannelLayout.RowCount = 6;
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.MainPannelLayout.Size = new System.Drawing.Size(561, 501);
            this.MainPannelLayout.TabIndex = 54;
            // 
            // MemoryRead
            // 
            this.MemoryRead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryRead.Location = new System.Drawing.Point(283, 5);
            this.MemoryRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Size = new System.Drawing.Size(85, 73);
            this.MemoryRead.TabIndex = 68;
            this.MemoryRead.Text = "MR";
            this.MemoryRead.UseVisualStyleBackColor = true;
            this.MemoryRead.Click += new System.EventHandler(this.MemoryReadClick);
            // 
            // MemoryClean
            // 
            this.MemoryClean.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemoryClean.Location = new System.Drawing.Point(190, 5);
            this.MemoryClean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MemoryClean.Name = "MemoryClean";
            this.MemoryClean.Size = new System.Drawing.Size(85, 73);
            this.MemoryClean.TabIndex = 67;
            this.MemoryClean.Text = "MC";
            this.MemoryClean.UseVisualStyleBackColor = true;
            this.MemoryClean.Click += new System.EventHandler(this.MemoryCleanClick);
            // 
            // CurrentAddMemory
            // 
            this.CurrentAddMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentAddMemory.Location = new System.Drawing.Point(190, 88);
            this.CurrentAddMemory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentAddMemory.Name = "CurrentAddMemory";
            this.CurrentAddMemory.Size = new System.Drawing.Size(85, 73);
            this.CurrentAddMemory.TabIndex = 65;
            this.CurrentAddMemory.Text = "M+";
            this.CurrentAddMemory.UseVisualStyleBackColor = true;
            this.CurrentAddMemory.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Tangent
            // 
            this.Tangent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tangent.Location = new System.Drawing.Point(4, 420);
            this.Tangent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tangent.Name = "Tangent";
            this.Tangent.Size = new System.Drawing.Size(85, 76);
            this.Tangent.TabIndex = 57;
            this.Tangent.Text = "TG";
            this.Tangent.UseVisualStyleBackColor = true;
            this.Tangent.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Cotangent
            // 
            this.Cotangent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cotangent.Location = new System.Drawing.Point(4, 337);
            this.Cotangent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cotangent.Name = "Cotangent";
            this.Cotangent.Size = new System.Drawing.Size(85, 73);
            this.Cotangent.TabIndex = 58;
            this.Cotangent.Text = "CTG";
            this.Cotangent.UseVisualStyleBackColor = true;
            this.Cotangent.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Sinus
            // 
            this.Sinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Sinus.Location = new System.Drawing.Point(4, 254);
            this.Sinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sinus.Name = "Sinus";
            this.Sinus.Size = new System.Drawing.Size(85, 73);
            this.Sinus.TabIndex = 59;
            this.Sinus.Text = "SIN";
            this.Sinus.UseVisualStyleBackColor = true;
            this.Sinus.Click += new System.EventHandler(this.OperationCompute);
            // 
            // NegatePositiveButton
            // 
            this.NegatePositiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NegatePositiveButton.Location = new System.Drawing.Point(190, 420);
            this.NegatePositiveButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NegatePositiveButton.Name = "NegatePositiveButton";
            this.NegatePositiveButton.Size = new System.Drawing.Size(85, 76);
            this.NegatePositiveButton.TabIndex = 64;
            this.NegatePositiveButton.Text = "+/-";
            this.NegatePositiveButton.UseVisualStyleBackColor = true;
            this.NegatePositiveButton.Click += new System.EventHandler(this.OperationCompute);
            // 
            // SQRT
            // 
            this.SQRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SQRT.Location = new System.Drawing.Point(4, 5);
            this.SQRT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SQRT.Name = "SQRT";
            this.SQRT.Size = new System.Drawing.Size(85, 73);
            this.SQRT.TabIndex = 55;
            this.SQRT.Text = "SQRT";
            this.SQRT.UseVisualStyleBackColor = true;
            this.SQRT.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Power
            // 
            this.Power.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Power.Location = new System.Drawing.Point(97, 5);
            this.Power.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(85, 73);
            this.Power.TabIndex = 60;
            this.Power.Text = "x^2";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Cosinus
            // 
            this.Cosinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cosinus.Location = new System.Drawing.Point(4, 171);
            this.Cosinus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Cosinus.Name = "Cosinus";
            this.Cosinus.Size = new System.Drawing.Size(85, 73);
            this.Cosinus.TabIndex = 56;
            this.Cosinus.Text = "COS";
            this.Cosinus.UseVisualStyleBackColor = true;
            this.Cosinus.Click += new System.EventHandler(this.OperationCompute);
            // 
            // NPower
            // 
            this.NPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NPower.Location = new System.Drawing.Point(97, 88);
            this.NPower.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NPower.Name = "NPower";
            this.NPower.Size = new System.Drawing.Size(85, 73);
            this.NPower.TabIndex = 61;
            this.NPower.Text = "x^n";
            this.NPower.UseVisualStyleBackColor = true;
            this.NPower.Click += new System.EventHandler(this.OperationCompute);
            // 
            // NSQRT
            // 
            this.NSQRT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NSQRT.Location = new System.Drawing.Point(4, 88);
            this.NSQRT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NSQRT.Name = "NSQRT";
            this.NSQRT.Size = new System.Drawing.Size(85, 73);
            this.NSQRT.TabIndex = 62;
            this.NSQRT.Text = "NSQRT";
            this.NSQRT.UseVisualStyleBackColor = true;
            this.NSQRT.Click += new System.EventHandler(this.OperationCompute);
            // 
            // NaturalLogarithm
            // 
            this.NaturalLogarithm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NaturalLogarithm.Location = new System.Drawing.Point(97, 254);
            this.NaturalLogarithm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NaturalLogarithm.Name = "NaturalLogarithm";
            this.NaturalLogarithm.Size = new System.Drawing.Size(85, 73);
            this.NaturalLogarithm.TabIndex = 63;
            this.NaturalLogarithm.Text = "LN";
            this.NaturalLogarithm.UseVisualStyleBackColor = true;
            this.NaturalLogarithm.Click += new System.EventHandler(this.OperationCompute);
            // 
            // DecimalLOgarifm
            // 
            this.DecimalLOgarifm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecimalLOgarifm.Location = new System.Drawing.Point(97, 171);
            this.DecimalLOgarifm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DecimalLOgarifm.Name = "DecimalLOgarifm";
            this.DecimalLOgarifm.Size = new System.Drawing.Size(85, 73);
            this.DecimalLOgarifm.TabIndex = 62;
            this.DecimalLOgarifm.Text = "LOG";
            this.DecimalLOgarifm.UseVisualStyleBackColor = true;
            this.DecimalLOgarifm.Click += new System.EventHandler(this.OperationCompute);
            // 
            // Factorial
            // 
            this.Factorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Factorial.Location = new System.Drawing.Point(97, 337);
            this.Factorial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(85, 73);
            this.Factorial.TabIndex = 75;
            this.Factorial.Text = "N!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.OperationCompute);
            // 
            // NumberOfPI
            // 
            this.NumberOfPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumberOfPI.Location = new System.Drawing.Point(96, 418);
            this.NumberOfPI.Name = "NumberOfPI";
            this.NumberOfPI.Size = new System.Drawing.Size(87, 80);
            this.NumberOfPI.TabIndex = 76;
            this.NumberOfPI.Text = "PI";
            this.NumberOfPI.UseVisualStyleBackColor = true;
            this.NumberOfPI.Click += new System.EventHandler(this.OperationCompute);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mem";
            // 
            // CurrentSubMemory
            // 
            this.CurrentSubMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentSubMemory.Location = new System.Drawing.Point(283, 88);
            this.CurrentSubMemory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrentSubMemory.Name = "CurrentSubMemory";
            this.CurrentSubMemory.Size = new System.Drawing.Size(85, 73);
            this.CurrentSubMemory.TabIndex = 66;
            this.CurrentSubMemory.Text = "M-";
            this.CurrentSubMemory.UseVisualStyleBackColor = true;
            this.CurrentSubMemory.Click += new System.EventHandler(this.OperationCompute);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 618);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MainPannelLayout);
            this.Controls.Add(this.MemoryDisplay);
            this.Controls.Add(this.MainDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(602, 639);
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
        private System.Windows.Forms.Button NegatePositiveButton;
        private System.Windows.Forms.Button NSQRT;
        private System.Windows.Forms.Button MemoryRead;
        private System.Windows.Forms.Button MemoryClean;
        private System.Windows.Forms.Button CurrentAddMemory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button NumberOfPI;
        private System.Windows.Forms.Button CurrentSubMemory;
    }
}

