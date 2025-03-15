namespace testhesapmakinesi6
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBox_Result;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();

            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_Result.Location = new System.Drawing.Point(12, 12);
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(260, 38);
            this.textBox_Result.TabIndex = 0;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Creating buttons for numbers and operations
            int xPos = 12, yPos = 60;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    CreateButton((i * 3) - (3 - j), ref xPos, yPos, button_Click);
                }
                xPos = 12;
                yPos += 45;
            }

            CreateButton(0, ref xPos, yPos, button_Click);
            CreateOperatorButton("+", ref xPos, yPos, operator_Click);
            yPos -= 45;
            xPos += 58;
            CreateOperatorButton("-", ref xPos, yPos, operator_Click);
            CreateOperatorButton("*", ref xPos, yPos, operator_Click);
            CreateOperatorButton("/", ref xPos, yPos, operator_Click);
            xPos += 58;
            CreateEqualsButton(ref xPos, yPos, buttonEquals_Click);

            // Clear button
            CreateClearButton(ref xPos, yPos, buttonClear_Click);

            // CalculatorForm
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.textBox_Result);
            this.Name = "CalculatorForm";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void CreateButton(int number, ref int xPos, int yPos, EventHandler onClick)
        {
            Button button = new Button
            {
                Text = number.ToString(),
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20F),
                Size = new System.Drawing.Size(45, 45),
                Location = new System.Drawing.Point(xPos, yPos),
            };
            button.Click += onClick;
            this.Controls.Add(button);
            xPos += 58;
        }

        private void CreateOperatorButton(string operation, ref int xPos, int yPos, EventHandler onClick)
        {
            Button button = new Button
            {
                Text = operation,
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20F),
                Size = new System.Drawing.Size(45, 45),
                Location = new System.Drawing.Point(xPos, yPos),
            };
            button.Click += onClick;
            this.Controls.Add(button);
            xPos = 12;
            yPos += 45;
        }

        private void CreateEqualsButton(ref int xPos, int yPos, EventHandler onClick)
        {
            Button button = new Button
            {
                Text = "=",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20F),
                Size = new System.Drawing.Size(45, 90),
                Location = new System.Drawing.Point(xPos, yPos),
            };
            button.Click += onClick;
            this.Controls.Add(button);
        }

        private void CreateClearButton(ref int xPos, int yPos, EventHandler onClick)
        {
            Button button = new Button
            {
                Text = "C",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 20F),
                Size = new System.Drawing.Size(45, 45),
                Location = new System.Drawing.Point(xPos, yPos),
            };
            button.Click += onClick;
            this.Controls.Add(button);
        }
    }
}