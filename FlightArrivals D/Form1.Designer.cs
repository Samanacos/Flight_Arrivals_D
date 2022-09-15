namespace FlightArrivals_D
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
            this.lstArrivals = new System.Windows.Forms.ListBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAllFlights = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtAirport = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblDesign = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstArrivals
            // 
            this.lstArrivals.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold);
            this.lstArrivals.FormattingEnabled = true;
            this.lstArrivals.ItemHeight = 16;
            this.lstArrivals.Location = new System.Drawing.Point(160, 45);
            this.lstArrivals.Name = "lstArrivals";
            this.lstArrivals.Size = new System.Drawing.Size(300, 372);
            this.lstArrivals.TabIndex = 25;
            this.lstArrivals.SelectedIndexChanged += new System.EventHandler(this.lstArrivals_SelectedIndexChanged);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.BackColor = System.Drawing.Color.Transparent;
            this.lblFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.ForeColor = System.Drawing.Color.White;
            this.lblFlight.Location = new System.Drawing.Point(165, 20);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(49, 18);
            this.lblFlight.TabIndex = 26;
            this.lblFlight.Text = "Flight";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.BackColor = System.Drawing.Color.Transparent;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblDeparture.ForeColor = System.Drawing.Color.White;
            this.lblDeparture.Location = new System.Drawing.Point(280, 20);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(82, 18);
            this.lblDeparture.TabIndex = 27;
            this.lblDeparture.Text = "Departure";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(400, 20);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(45, 18);
            this.lblTime.TabIndex = 28;
            this.lblTime.Text = "Time";
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(15, 250);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(100, 30);
            this.btnAddFlight.TabIndex = 29;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click_1);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(15, 280);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(100, 30);
            this.btnRemove.TabIndex = 30;
            this.btnRemove.Text = "Remove Flight";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnAllFlights
            // 
            this.btnAllFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllFlights.Location = new System.Drawing.Point(15, 310);
            this.btnAllFlights.Name = "btnAllFlights";
            this.btnAllFlights.Size = new System.Drawing.Size(100, 30);
            this.btnAllFlights.TabIndex = 31;
            this.btnAllFlights.Text = "All Flights";
            this.btnAllFlights.UseVisualStyleBackColor = true;
            this.btnAllFlights.Click += new System.EventHandler(this.btnAllFlights_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(30, 130);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 30);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtAirport
            // 
            this.txtAirport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAirport.Location = new System.Drawing.Point(15, 100);
            this.txtAirport.Name = "txtAirport";
            this.txtAirport.Size = new System.Drawing.Size(100, 23);
            this.txtAirport.TabIndex = 33;
            this.txtAirport.TextChanged += new System.EventHandler(this.txtAirport_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelLogo);
            this.panel1.Controls.Add(this.txtAirport);
            this.panel1.Controls.Add(this.btnAllFlights);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.btnAddFlight);
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 450);
            this.panel1.TabIndex = 12;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(35, 410);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 30);
            this.btnExit.TabIndex = 35;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Location = new System.Drawing.Point(8, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 2);
            this.panel2.TabIndex = 34;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Coral;
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(130, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.Location = new System.Drawing.Point(4, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(118, 39);
            this.lblLogo.TabIndex = 1;
            this.lblLogo.Text = "Arrivals";
            // 
            // lblDesign
            // 
            this.lblDesign.AutoSize = true;
            this.lblDesign.BackColor = System.Drawing.Color.Transparent;
            this.lblDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesign.ForeColor = System.Drawing.Color.Black;
            this.lblDesign.Location = new System.Drawing.Point(246, 425);
            this.lblDesign.Name = "lblDesign";
            this.lblDesign.Size = new System.Drawing.Size(214, 16);
            this.lblDesign.TabIndex = 29;
            this.lblDesign.Text = "Designed by Ioannis Terzakis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::FlightArrivals_D.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.lblDesign);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.lstArrivals);
            this.Name = "Form1";
            this.Text = "Arrivals Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstArrivals;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAllFlights;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtAirport;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDesign;
    }
}

