namespace TestGmapProject01
{
    partial class MapControler
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.routesList1 = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markerID1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markerID2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark1pos_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark1pos_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark2pos_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mark2pos_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.markersList1 = new System.Windows.Forms.ListView();
            this.ID_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consignmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.posX_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.posY_col = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.routesListLabel = new System.Windows.Forms.Label();
            this.markersListLabel = new System.Windows.Forms.Label();
            this.clearAllRoutes_button = new System.Windows.Forms.Button();
            this.clearAllMarkRou_Button = new System.Windows.Forms.Button();
            this.MarkerRoutes_button1 = new System.Windows.Forms.Button();
            this.CurrentPosMarker_button1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SearchLocationTextBox1 = new System.Windows.Forms.TextBox();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.removeMarkerButton = new System.Windows.Forms.Button();
            this.markerUp_button = new System.Windows.Forms.Button();
            this.markerDown_button = new System.Windows.Forms.Button();
            this.routePlannerPanel1 = new System.Windows.Forms.Panel();
            this.travelingSalesmanRoute_button = new System.Windows.Forms.Button();
            this.currentStatus_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.zoomOut_button = new System.Windows.Forms.Button();
            this.zoomIn_button = new System.Windows.Forms.Button();
            this.routePlannerPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // routesList1
            // 
            this.routesList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.routesList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.markerID1,
            this.markerID2,
            this.mark1pos_X,
            this.mark1pos_Y,
            this.mark2pos_X,
            this.mark2pos_Y});
            this.routesList1.FullRowSelect = true;
            this.routesList1.HideSelection = false;
            this.routesList1.Location = new System.Drawing.Point(537, 183);
            this.routesList1.MultiSelect = false;
            this.routesList1.Name = "routesList1";
            this.routesList1.Size = new System.Drawing.Size(229, 146);
            this.routesList1.TabIndex = 26;
            this.routesList1.UseCompatibleStateImageBehavior = false;
            this.routesList1.View = System.Windows.Forms.View.Details;
            this.routesList1.SelectedIndexChanged += new System.EventHandler(this.RoutesList1_SelectedIndexChanged);
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
            // markersList1
            // 
            this.markersList1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.markersList1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_col,
            this.consignmentID,
            this.posX_col,
            this.posY_col});
            this.markersList1.FullRowSelect = true;
            this.markersList1.HideSelection = false;
            this.markersList1.Location = new System.Drawing.Point(537, 18);
            this.markersList1.MultiSelect = false;
            this.markersList1.Name = "markersList1";
            this.markersList1.Size = new System.Drawing.Size(229, 146);
            this.markersList1.TabIndex = 25;
            this.markersList1.UseCompatibleStateImageBehavior = false;
            this.markersList1.View = System.Windows.Forms.View.Details;
            this.markersList1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.MarkerList1_ItemSelectionChanged);
            // 
            // ID_col
            // 
            this.ID_col.Text = "ID";
            this.ID_col.Width = 35;
            // 
            // consignmentID
            // 
            this.consignmentID.Text = "Consignment ID";
            this.consignmentID.Width = 93;
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
            // routesListLabel
            // 
            this.routesListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.routesListLabel.AutoSize = true;
            this.routesListLabel.Location = new System.Drawing.Point(537, 167);
            this.routesListLabel.Name = "routesListLabel";
            this.routesListLabel.Size = new System.Drawing.Size(41, 13);
            this.routesListLabel.TabIndex = 24;
            this.routesListLabel.Text = "Routes";
            // 
            // markersListLabel
            // 
            this.markersListLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.markersListLabel.AutoSize = true;
            this.markersListLabel.Location = new System.Drawing.Point(537, 2);
            this.markersListLabel.Name = "markersListLabel";
            this.markersListLabel.Size = new System.Drawing.Size(45, 13);
            this.markersListLabel.TabIndex = 23;
            this.markersListLabel.Text = "Markers";
            // 
            // clearAllRoutes_button
            // 
            this.clearAllRoutes_button.Location = new System.Drawing.Point(213, 3);
            this.clearAllRoutes_button.Name = "clearAllRoutes_button";
            this.clearAllRoutes_button.Size = new System.Drawing.Size(96, 51);
            this.clearAllRoutes_button.TabIndex = 21;
            this.clearAllRoutes_button.Text = "Clear all routes";
            this.clearAllRoutes_button.UseVisualStyleBackColor = true;
            this.clearAllRoutes_button.Click += new System.EventHandler(this.ClearAllRoutes_button_Click);
            // 
            // clearAllMarkRou_Button
            // 
            this.clearAllMarkRou_Button.Location = new System.Drawing.Point(315, 3);
            this.clearAllMarkRou_Button.Name = "clearAllMarkRou_Button";
            this.clearAllMarkRou_Button.Size = new System.Drawing.Size(96, 51);
            this.clearAllMarkRou_Button.TabIndex = 22;
            this.clearAllMarkRou_Button.Text = "Clear all markers and routes";
            this.clearAllMarkRou_Button.UseVisualStyleBackColor = true;
            this.clearAllMarkRou_Button.Click += new System.EventHandler(this.ClearAllMarkRou_Button_Click);
            // 
            // MarkerRoutes_button1
            // 
            this.MarkerRoutes_button1.Enabled = false;
            this.MarkerRoutes_button1.Location = new System.Drawing.Point(103, 2);
            this.MarkerRoutes_button1.Name = "MarkerRoutes_button1";
            this.MarkerRoutes_button1.Size = new System.Drawing.Size(104, 52);
            this.MarkerRoutes_button1.TabIndex = 20;
            this.MarkerRoutes_button1.Text = "Make route on markers (in order of list)";
            this.MarkerRoutes_button1.UseVisualStyleBackColor = true;
            this.MarkerRoutes_button1.Click += new System.EventHandler(this.MarkerRoutes_button1_Click);
            // 
            // CurrentPosMarker_button1
            // 
            this.CurrentPosMarker_button1.Location = new System.Drawing.Point(3, 2);
            this.CurrentPosMarker_button1.Name = "CurrentPosMarker_button1";
            this.CurrentPosMarker_button1.Size = new System.Drawing.Size(94, 52);
            this.CurrentPosMarker_button1.TabIndex = 19;
            this.CurrentPosMarker_button1.Text = "Marker on current position";
            this.CurrentPosMarker_button1.UseVisualStyleBackColor = true;
            this.CurrentPosMarker_button1.Click += new System.EventHandler(this.CurrentPosMarker_button1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.Location = new System.Drawing.Point(452, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchLocationTextBox1
            // 
            this.SearchLocationTextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SearchLocationTextBox1.Location = new System.Drawing.Point(3, 119);
            this.SearchLocationTextBox1.Name = "SearchLocationTextBox1";
            this.SearchLocationTextBox1.Size = new System.Drawing.Size(443, 20);
            this.SearchLocationTextBox1.TabIndex = 17;
            this.SearchLocationTextBox1.Text = "Search for location...";
            this.SearchLocationTextBox1.Click += new System.EventHandler(this.SearchLocTxtBox1_Click);
            this.SearchLocationTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchLocationTextBox1_KeyDown);
            this.SearchLocationTextBox1.Leave += new System.EventHandler(this.SearchLocTxtBox1_Leave);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(3, 3);
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
            this.gMapControl1.Size = new System.Drawing.Size(528, 326);
            this.gMapControl1.TabIndex = 14;
            this.gMapControl1.Zoom = 13D;
            this.gMapControl1.Load += new System.EventHandler(this.OnLoad);
            // 
            // removeMarkerButton
            // 
            this.removeMarkerButton.Enabled = false;
            this.removeMarkerButton.Location = new System.Drawing.Point(315, 60);
            this.removeMarkerButton.Name = "removeMarkerButton";
            this.removeMarkerButton.Size = new System.Drawing.Size(96, 53);
            this.removeMarkerButton.TabIndex = 27;
            this.removeMarkerButton.Text = "Remove selected marker";
            this.removeMarkerButton.UseVisualStyleBackColor = true;
            this.removeMarkerButton.Click += new System.EventHandler(this.RemoveMarkerButton_Click);
            // 
            // markerUp_button
            // 
            this.markerUp_button.Enabled = false;
            this.markerUp_button.Location = new System.Drawing.Point(417, 3);
            this.markerUp_button.Name = "markerUp_button";
            this.markerUp_button.Size = new System.Drawing.Size(107, 51);
            this.markerUp_button.TabIndex = 28;
            this.markerUp_button.Text = "Move selected marker up";
            this.markerUp_button.UseVisualStyleBackColor = true;
            this.markerUp_button.Click += new System.EventHandler(this.MarkerUp_button_Click);
            // 
            // markerDown_button
            // 
            this.markerDown_button.Enabled = false;
            this.markerDown_button.Location = new System.Drawing.Point(417, 60);
            this.markerDown_button.Name = "markerDown_button";
            this.markerDown_button.Size = new System.Drawing.Size(107, 53);
            this.markerDown_button.TabIndex = 29;
            this.markerDown_button.Text = "Move selected marker down";
            this.markerDown_button.UseVisualStyleBackColor = true;
            this.markerDown_button.Click += new System.EventHandler(this.MarkerDown_button_Click);
            // 
            // routePlannerPanel1
            // 
            this.routePlannerPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.routePlannerPanel1.AutoScroll = true;
            this.routePlannerPanel1.Controls.Add(this.zoomOut_button);
            this.routePlannerPanel1.Controls.Add(this.zoomIn_button);
            this.routePlannerPanel1.Controls.Add(this.travelingSalesmanRoute_button);
            this.routePlannerPanel1.Controls.Add(this.CurrentPosMarker_button1);
            this.routePlannerPanel1.Controls.Add(this.markerDown_button);
            this.routePlannerPanel1.Controls.Add(this.removeMarkerButton);
            this.routePlannerPanel1.Controls.Add(this.markerUp_button);
            this.routePlannerPanel1.Controls.Add(this.MarkerRoutes_button1);
            this.routePlannerPanel1.Controls.Add(this.button1);
            this.routePlannerPanel1.Controls.Add(this.clearAllRoutes_button);
            this.routePlannerPanel1.Controls.Add(this.SearchLocationTextBox1);
            this.routePlannerPanel1.Controls.Add(this.clearAllMarkRou_Button);
            this.routePlannerPanel1.Location = new System.Drawing.Point(4, 335);
            this.routePlannerPanel1.Name = "routePlannerPanel1";
            this.routePlannerPanel1.Size = new System.Drawing.Size(527, 169);
            this.routePlannerPanel1.TabIndex = 30;
            // 
            // travelingSalesmanRoute_button
            // 
            this.travelingSalesmanRoute_button.Enabled = false;
            this.travelingSalesmanRoute_button.Location = new System.Drawing.Point(3, 61);
            this.travelingSalesmanRoute_button.Name = "travelingSalesmanRoute_button";
            this.travelingSalesmanRoute_button.Size = new System.Drawing.Size(94, 52);
            this.travelingSalesmanRoute_button.TabIndex = 30;
            this.travelingSalesmanRoute_button.Text = "Determine the shortest route";
            this.travelingSalesmanRoute_button.UseVisualStyleBackColor = true;
            this.travelingSalesmanRoute_button.Click += new System.EventHandler(this.TravelingSalesmanRoute_button_Click);
            // 
            // currentStatus_label
            // 
            this.currentStatus_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.currentStatus_label.AutoSize = true;
            this.currentStatus_label.Location = new System.Drawing.Point(537, 376);
            this.currentStatus_label.Name = "currentStatus_label";
            this.currentStatus_label.Size = new System.Drawing.Size(94, 13);
            this.currentStatus_label.TabIndex = 31;
            this.currentStatus_label.Text = "Current status: idle";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Hold right mouse button to move map around";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(537, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Use mouse wheel to zoom in or zoom out map view";
            // 
            // zoomOut_button
            // 
            this.zoomOut_button.Location = new System.Drawing.Point(103, 60);
            this.zoomOut_button.Name = "zoomOut_button";
            this.zoomOut_button.Size = new System.Drawing.Size(104, 53);
            this.zoomOut_button.TabIndex = 34;
            this.zoomOut_button.Text = "Zoom out";
            this.zoomOut_button.UseVisualStyleBackColor = true;
            this.zoomOut_button.Click += new System.EventHandler(this.ZoomOut_button_Click);
            // 
            // zoomIn_button
            // 
            this.zoomIn_button.Location = new System.Drawing.Point(213, 61);
            this.zoomIn_button.Name = "zoomIn_button";
            this.zoomIn_button.Size = new System.Drawing.Size(96, 52);
            this.zoomIn_button.TabIndex = 35;
            this.zoomIn_button.Text = "Zoom in";
            this.zoomIn_button.UseVisualStyleBackColor = true;
            this.zoomIn_button.Click += new System.EventHandler(this.ZoomIn_button_Click);
            // 
            // MapControler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentStatus_label);
            this.Controls.Add(this.routePlannerPanel1);
            this.Controls.Add(this.routesList1);
            this.Controls.Add(this.markersList1);
            this.Controls.Add(this.routesListLabel);
            this.Controls.Add(this.markersListLabel);
            this.Controls.Add(this.gMapControl1);
            this.MinimumSize = new System.Drawing.Size(797, 507);
            this.Name = "MapControler";
            this.Size = new System.Drawing.Size(797, 507);
            this.routePlannerPanel1.ResumeLayout(false);
            this.routePlannerPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView routesList1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader markerID1;
        private System.Windows.Forms.ColumnHeader markerID2;
        private System.Windows.Forms.ColumnHeader mark1pos_X;
        private System.Windows.Forms.ColumnHeader mark1pos_Y;
        private System.Windows.Forms.ColumnHeader mark2pos_X;
        private System.Windows.Forms.ColumnHeader mark2pos_Y;
        private System.Windows.Forms.ListView markersList1;
        private System.Windows.Forms.ColumnHeader ID_col;
        private System.Windows.Forms.ColumnHeader posX_col;
        private System.Windows.Forms.ColumnHeader posY_col;
        private System.Windows.Forms.Label routesListLabel;
        private System.Windows.Forms.Label markersListLabel;
        private System.Windows.Forms.Button clearAllRoutes_button;
        private System.Windows.Forms.Button clearAllMarkRou_Button;
        private System.Windows.Forms.Button MarkerRoutes_button1;
        private System.Windows.Forms.Button CurrentPosMarker_button1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox SearchLocationTextBox1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ColumnHeader consignmentID;
        private System.Windows.Forms.Button removeMarkerButton;
        private System.Windows.Forms.Button markerUp_button;
        private System.Windows.Forms.Button markerDown_button;
        private System.Windows.Forms.Panel routePlannerPanel1;
        private System.Windows.Forms.Button travelingSalesmanRoute_button;
        private System.Windows.Forms.Label currentStatus_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button zoomOut_button;
        private System.Windows.Forms.Button zoomIn_button;
    }
}
