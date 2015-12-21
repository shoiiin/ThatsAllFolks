namespace ThatsAllFolks
{
    partial class ThatsAllFolksService
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.eventLogging = new System.Diagnostics.EventLog();
            this.usageTimer = new System.Timers.Timer(30000);
            ((System.ComponentModel.ISupportInitialize)(this.eventLogging)).BeginInit();
            // 
            // ThatsAllFolksService
            // 
            this.ServiceName = "That's all folks ! service";
            ((System.ComponentModel.ISupportInitialize)(this.eventLogging)).EndInit();

        }

        #endregion

        private System.Diagnostics.EventLog eventLogging;
        private System.Timers.Timer usageTimer;
    }
}
