namespace ThatsAllFolks
{
    partial class ProjectInstaller
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
            this.ThatsAllFolksServiceInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.ThatsAllFolksInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // ThatsAllFolksServiceInstaller
            // 
            this.ThatsAllFolksServiceInstaller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.ThatsAllFolksServiceInstaller.Password = null;
            this.ThatsAllFolksServiceInstaller.Username = null;
            // 
            // ThatsAllFolksInstaller
            // 
            this.ThatsAllFolksInstaller.ServiceName = "That\'s all folks ! service";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.ThatsAllFolksServiceInstaller,
            this.ThatsAllFolksInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller ThatsAllFolksServiceInstaller;
        private System.ServiceProcess.ServiceInstaller ThatsAllFolksInstaller;
    }
}