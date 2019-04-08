namespace TestGmapProject01
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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.ExampleMarkersButton1 = new System.Windows.Forms.Button();
            this.ExampleRouteButton1 = new System.Windows.Forms.Button();
            this.SearchLocationTextBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.CurrentPosMarker_button1 = new System.Windows.Forms.Button();
            this.MarkerRoutes_button1 = new System.Windows.Forms.Button();
            this.clearAllMarkRou_Button = new System.Windows.Forms.Button();
            this.clearAllRoutes_button = new System.Windows.Forms.Button();
            this.markersListLabel = new System.Windows.Forms.Label();
            this.routesListLabel = new System.Windows.Forms.Label();
            this.markersList1 = new System.Windows.Forms.ListView();
            this.ID_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.posX_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.posY_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.routesList1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markerID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markerID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark1pos_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark1pos_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark2pos_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark2pos_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mapControler1 = new TestGmapProject01.MapControler();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.Enabled = false;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 12);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 18;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(538, 327);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Visible = false;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.OnLoad);
            // 
            // ExampleMarkersButton1
            // 
            this.ExampleMarkersButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExampleMarkersButton1.Enabled = false;
            this.ExampleMarkersButton1.Location = new System.Drawing.Point(12, 461);
            this.ExampleMarkersButton1.Name = "ExampleMarkersButton1";
            this.ExampleMarkersButton1.Size = new System.Drawing.Size(75, 42);
            this.ExampleMarkersButton1.TabIndex = 1;
            this.ExampleMarkersButton1.Text = "Example markers";
            this.ExampleMarkersButton1.UseVisualStyleBackColor = true;
            this.ExampleMarkersButton1.Visible = false;
            this.ExampleMarkersButton1.Click += new System.EventHandler(this.ExampleMarkers);
            // 
            // ExampleRouteButton1
            // 
            this.ExampleRouteButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ExampleRouteButton1.Enabled = false;
            this.ExampleRouteButton1.Location = new System.Drawing.Point(93, 461);
            this.ExampleRouteButton1.Name = "ExampleRouteButton1";
            this.ExampleRouteButton1.Size = new System.Drawing.Size(75, 42);
            this.ExampleRouteButton1.TabIndex = 2;
            this.ExampleRouteButton1.Text = "Example route";
            this.ExampleRouteButton1.UseVisualStyleBackColor = true;
            this.ExampleRouteButton1.Visible = false;
            this.ExampleRouteButton1.Click += new System.EventHandler(this.ExampleRouteButton1_Click);
            // 
            // SearchLocationTextBox1
            // 
            this.SearchLocationTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SearchLocationTextBox1.Enabled = false;
            this.SearchLocationTextBox1.Location = new System.Drawing.Point(174, 473);
            this.SearchLocationTextBox1.Name = "SearchLocationTextBox1";
            this.SearchLocationTextBox1.Size = new System.Drawing.Size(294, 20);
            this.SearchLocationTextBox1.TabIndex = 3;
            this.SearchLocationTextBox1.Text = "Search for location...";
            this.SearchLocationTextBox1.Visible = false;
            this.SearchLocationTextBox1.Click += new System.EventHandler(this.SearchLocTxtBox1_Click);
            this.SearchLocationTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchLocationTextBox1_KeyDown);
            this.SearchLocationTextBox1.Leave += new System.EventHandler(this.SearchLocTxtBox1_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(475, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // CurrentPosMarker_button1
            // 
            this.CurrentPosMarker_button1.Enabled = false;
            this.CurrentPosMarker_button1.Location = new System.Drawing.Point(13, 346);
            this.CurrentPosMarker_button1.Name = "CurrentPosMarker_button1";
            this.CurrentPosMarker_button1.Size = new System.Drawing.Size(94, 54);
            this.CurrentPosMarker_button1.TabIndex = 5;
            this.CurrentPosMarker_button1.Text = "Marker on current position";
            this.CurrentPosMarker_button1.UseVisualStyleBackColor = true;
            this.CurrentPosMarker_button1.Visible = false;
            this.CurrentPosMarker_button1.Click += new System.EventHandler(this.CurrentPosMarker_button1_Click);
            // 
            // MarkerRoutes_button1
            // 
            this.MarkerRoutes_button1.Enabled = false;
            this.MarkerRoutes_button1.Location = new System.Drawing.Point(113, 345);
            this.MarkerRoutes_button1.Name = "MarkerRoutes_button1";
            this.MarkerRoutes_button1.Size = new System.Drawing.Size(96, 54);
            this.MarkerRoutes_button1.TabIndex = 6;
            this.MarkerRoutes_button1.Text = "Make route on markers";
            this.MarkerRoutes_button1.UseVisualStyleBackColor = true;
            this.MarkerRoutes_button1.Visible = false;
            this.MarkerRoutes_button1.Click += new System.EventHandler(this.MarkerRoutes_button1_Click);
            // 
            // clearAllMarkRou_Button
            // 
            this.clearAllMarkRou_Button.Enabled = false;
            this.clearAllMarkRou_Button.Location = new System.Drawing.Point(444, 345);
            this.clearAllMarkRou_Button.Name = "clearAllMarkRou_Button";
            this.clearAllMarkRou_Button.Size = new System.Drawing.Size(96, 54);
            this.clearAllMarkRou_Button.TabIndex = 7;
            this.clearAllMarkRou_Button.Text = "Clear all markers and routes";
            this.clearAllMarkRou_Button.UseVisualStyleBackColor = true;
            this.clearAllMarkRou_Button.Visible = false;
            this.clearAllMarkRou_Button.Click += new System.EventHandler(this.clearAllMarkRou_Button_Click);
            // 
            // clearAllRoutes_button
            // 
            this.clearAllRoutes_button.Enabled = false;
            this.clearAllRoutes_button.Location = new System.Drawing.Point(342, 345);
            this.clearAllRoutes_button.Name = "clearAllRoutes_button";
            this.clearAllRoutes_button.Size = new System.Drawing.Size(96, 54);
            this.clearAllRoutes_button.TabIndex = 7;
            this.clearAllRoutes_button.Text = "Clear all routes";
            this.clearAllRoutes_button.UseVisualStyleBackColor = true;
            this.clearAllRoutes_button.Visible = false;
            this.clearAllRoutes_button.Click += new System.EventHandler(this.clearAllRoutes_button_Click);
            // 
            // markersListLabel
            // 
            this.markersListLabel.AutoSize = true;
            this.markersListLabel.Enabled = false;
            this.markersListLabel.Location = new System.Drawing.Point(546, 12);
            this.markersListLabel.Name = "markersListLabel";
            this.markersListLabel.Size = new System.Drawing.Size(45, 13);
            this.markersListLabel.TabIndex = 9;
            this.markersListLabel.Text = "Markers";
            this.markersListLabel.Visible = false;
            // 
            // routesListLabel
            // 
            this.routesListLabel.AutoSize = true;
            this.routesListLabel.Enabled = false;
            this.routesListLabel.Location = new System.Drawing.Point(546, 177);
            this.routesListLabel.Name = "routesListLabel";
            this.routesListLabel.Size = new System.Drawing.Size(41, 13);
            this.routesListLabel.TabIndex = 10;
            this.routesListLabel.Text = "Routes";
            this.routesListLabel.Visible = false;
            // 
            // markersList1
            // 
            this.markersList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_col,
            this.posX_col,
            this.posY_col});
            this.markersList1.Enabled = false;
            this.markersList1.Location = new System.Drawing.Point(546, 28);
            this.markersList1.Name = "markersList1";
            this.markersList1.Size = new System.Drawing.Size(229, 146);
            this.markersList1.TabIndex = 12;
            this.markersList1.UseCompatibleStateImageBehavior = false;
            this.markersList1.View = System.Windows.Forms.View.Details;
            this.markersList1.Visible = false;
            this.markersList1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MarkerList1_ItemSelectionChanged);
            // 
            // ID_col
            // 
            this.ID_col.Text = "ID";
            this.ID_col.Width = 35;
            // 
            // posX_col
            // 
            this.posX_col.Text = "Position X";
            this.posX_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.posX_col.Width = 90;
            // 
            // posY_col
            // 
            this.posY_col.Text = "Position Y";
            this.posY_col.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.posY_col.Width = 89;
            // 
            // routesList1
            // 
            this.routesList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.markerID1,
            this.markerID2,
            this.mark1pos_X,
            this.mark1pos_Y,
            this.mark2pos_X,
            this.mark2pos_Y});
            this.routesList1.Enabled = false;
            this.routesList1.Location = new System.Drawing.Point(546, 193);
            this.routesList1.Name = "routesList1";
            this.routesList1.Size = new System.Drawing.Size(229, 146);
            this.routesList1.TabIndex = 13;
            this.routesList1.UseCompatibleStateImageBehavior = false;
            this.routesList1.View = System.Windows.Forms.View.Details;
            this.routesList1.Visible = false;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 41;
            // 
            // markerID1
            // 
            this.markerID1.Text = "M1 ID";
            this.markerID1.Width = 41;
            // 
            // markerID2
            // 
            this.markerID2.Text = "M2 ID";
            this.markerID2.Width = 43;
            // 
            // mark1pos_X
            // 
            this.mark1pos_X.Text = "M1 X";
            this.mark1pos_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mark1pos_X.Width = 65;
            // 
            // mark1pos_Y
            // 
            this.mark1pos_Y.Text = "M1 Y";
            this.mark1pos_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mark1pos_Y.Width = 57;
            // 
            // mark2pos_X
            // 
            this.mark2pos_X.Text = "M2 X";
            this.mark2pos_X.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mark2pos_X.Width = 24;
            // 
            // mark2pos_Y
            // 
            this.mark2pos_Y.Text = "M2 Y";
            this.mark2pos_Y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mark2pos_Y.Width = 37;
            // 
            // mapControler1
            // 
            this.mapControler1.Location = new System.Drawing.Point(1, 12);
            this.mapControler1.MinimumSize = new System.Drawing.Size(797, 507);
            this.mapControler1.Name = "mapControler1";
            this.mapControler1.Size = new System.Drawing.Size(797, 507);
            this.mapControler1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 515);
            this.Controls.Add(this.mapControler1);
            this.Controls.Add(this.routesList1);
            this.Controls.Add(this.markersList1);
            this.Controls.Add(this.routesListLabel);
            this.Controls.Add(this.markersListLabel);
            this.Controls.Add(this.clearAllRoutes_button);
            this.Controls.Add(this.clearAllMarkRou_Button);
            this.Controls.Add(this.MarkerRoutes_button1);
            this.Controls.Add(this.CurrentPosMarker_button1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchLocationTextBox1);
            this.Controls.Add(this.ExampleRouteButton1);
            this.Controls.Add(this.ExampleMarkersButton1);
            this.Controls.Add(this.gMapControl1);
            this.MinimumSize = new System.Drawing.Size(813, 527);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Button ExampleMarkersButton1;
        private System.Windows.Forms.Button ExampleRouteButton1;
        private System.Windows.Forms.TextBox SearchLocationTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CurrentPosMarker_button1;
        private System.Windows.Forms.Button MarkerRoutes_button1;
        private System.Windows.Forms.Button clearAllMarkRou_Button;
        private System.Windows.Forms.Button clearAllRoutes_button;
        private System.Windows.Forms.Label markersListLabel;
        private System.Windows.Forms.Label routesListLabel;
        private System.Windows.Forms.ListView markersList1;
        private System.Windows.Forms.ColumnHeader ID_col;
        private System.Windows.Forms.ListView routesList1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader posX_col;
        private System.Windows.Forms.ColumnHeader posY_col;
        private System.Windows.Forms.ColumnHeader mark1pos_X;
        private System.Windows.Forms.ColumnHeader mark1pos_Y;
        private System.Windows.Forms.ColumnHeader mark2pos_X;
        private System.Windows.Forms.ColumnHeader mark2pos_Y;
        private System.Windows.Forms.ColumnHeader markerID1;
        private System.Windows.Forms.ColumnHeader markerID2;
        private MapControler mapControler1;
    }
}

