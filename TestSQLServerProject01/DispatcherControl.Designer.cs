namespace ParcelDeliveryCompanyApplication
{
    partial class DispatcherControl
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
            this.display_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dictionaryManagement_button
            // 
            this.dictionaryManagement_button.Enabled = false;
            this.dictionaryManagement_button.Visible = false;
            this.dictionaryManagement_button.EnabledChanged += new System.EventHandler(this.DictionaryManagement_button_EnabledChanged);
            // 
            // DispatcherControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "DispatcherControl";
            this.Controls.SetChildIndex(this.display_panel, 0);
            this.display_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
