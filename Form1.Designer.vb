<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HovedTab = New System.Windows.Forms.TabControl()
        Me.StartTab = New System.Windows.Forms.TabPage()
        Me.UtleieTab = New System.Windows.Forms.TabPage()
        Me.KDTab = New System.Windows.Forms.TabPage()
        Me.InventarTab = New System.Windows.Forms.TabPage()
        Me.ISTab = New System.Windows.Forms.TabPage()
        Me.LogiTab = New System.Windows.Forms.TabPage()
        Me.StatTab = New System.Windows.Forms.TabPage()
        Me.AdminTab = New System.Windows.Forms.TabPage()
        Me.StartLogo = New System.Windows.Forms.PictureBox()
        Me.StartVelkommenLabel = New System.Windows.Forms.Label()
        Me.StartRettigheterLabel = New System.Windows.Forms.Label()
        Me.StartMOTDLabel = New System.Windows.Forms.Label()
        Me.AdminNyBrukerGroup = New System.Windows.Forms.GroupBox()
        Me.AdminNBBIDL = New System.Windows.Forms.Label()
        Me.AdminNBPassordL = New System.Windows.Forms.Label()
        Me.AdminNBFornavnL = New System.Windows.Forms.Label()
        Me.AdminNBEtternavnL = New System.Windows.Forms.Label()
        Me.AdminNBAvdelingL = New System.Windows.Forms.Label()
        Me.AdminNBStillingL = New System.Windows.Forms.Label()
        Me.AdminNBTimelonnL = New System.Windows.Forms.Label()
        Me.AdminNBTelefonL = New System.Windows.Forms.Label()
        Me.AdminNBSPL = New System.Windows.Forms.Label()
        Me.AdminNBEpostL = New System.Windows.Forms.Label()
        Me.AdminNBAdminL = New System.Windows.Forms.Label()
        Me.AdminNBAdminCB = New System.Windows.Forms.CheckBox()
        Me.AdminNBTimeCB = New System.Windows.Forms.CheckBox()
        Me.AdminNBPassordTB = New System.Windows.Forms.TextBox()
        Me.AdminNBFornavnTB = New System.Windows.Forms.TextBox()
        Me.AdminNBEtternavnTB = New System.Windows.Forms.TextBox()
        Me.AdminNBTelefonTB = New System.Windows.Forms.TextBox()
        Me.AdminNBEpostTB = New System.Windows.Forms.TextBox()
        Me.AdminNBAvdelingCB = New System.Windows.Forms.ComboBox()
        Me.AdminNBStillingCB = New System.Windows.Forms.ComboBox()
        Me.AdminNBSPCB = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AdminEndreBrukerGroup = New System.Windows.Forms.GroupBox()
        Me.AdminEBSPCB = New System.Windows.Forms.ComboBox()
        Me.AdminEBStillingCB = New System.Windows.Forms.ComboBox()
        Me.AdminEBAvdelingCB = New System.Windows.Forms.ComboBox()
        Me.AdminEBEpostTB = New System.Windows.Forms.TextBox()
        Me.AdminEBTelefonTB = New System.Windows.Forms.TextBox()
        Me.AdminEBEtternavnTB = New System.Windows.Forms.TextBox()
        Me.AdminEBFornavnTB = New System.Windows.Forms.TextBox()
        Me.AdminEBPassordTB = New System.Windows.Forms.TextBox()
        Me.AdminEBTimeCB = New System.Windows.Forms.CheckBox()
        Me.AdminEBAdminCB = New System.Windows.Forms.CheckBox()
        Me.AdminEBAdminL = New System.Windows.Forms.Label()
        Me.AdminEBEpostL = New System.Windows.Forms.Label()
        Me.AdminEBSPL = New System.Windows.Forms.Label()
        Me.AdminEBTelefonL = New System.Windows.Forms.Label()
        Me.AdminEBTimeL = New System.Windows.Forms.Label()
        Me.AdminEBStillingL = New System.Windows.Forms.Label()
        Me.AdminEBAvdelingL = New System.Windows.Forms.Label()
        Me.AdminEBEtternavnL = New System.Windows.Forms.Label()
        Me.AdminEBFornavnL = New System.Windows.Forms.Label()
        Me.AdminEBPassordL = New System.Windows.Forms.Label()
        Me.AdminEBBIDL = New System.Windows.Forms.Label()
        Me.AdminEBBIDTB = New System.Windows.Forms.TextBox()
        Me.AdminEBLastInnB = New System.Windows.Forms.Button()
        Me.AdminNBOpprettB = New System.Windows.Forms.Button()
        Me.AdminEBEndreB = New System.Windows.Forms.Button()
        Me.AdminNBTimeTB = New System.Windows.Forms.TextBox()
        Me.AdminEBTimeTB = New System.Windows.Forms.TextBox()
        Me.AdminBrukerSokGroup = New System.Windows.Forms.GroupBox()
        Me.AdminBSFeltL = New System.Windows.Forms.Label()
        Me.AdminBSFeltTB = New System.Windows.Forms.TextBox()
        Me.AdminBSEtterL = New System.Windows.Forms.Label()
        Me.AdminBSEtterCB = New System.Windows.Forms.ComboBox()
        Me.AdminBSResultatLB = New System.Windows.Forms.ListBox()
        Me.AdminMOTDGroup = New System.Windows.Forms.GroupBox()
        Me.AdminMOTDTB = New System.Windows.Forms.TextBox()
        Me.AdminMOTDEndreB = New System.Windows.Forms.Button()
        Me.AdminBSSokB = New System.Windows.Forms.Button()
        Me.HovedTab.SuspendLayout()
        Me.StartTab.SuspendLayout()
        Me.AdminTab.SuspendLayout()
        CType(Me.StartLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminNyBrukerGroup.SuspendLayout()
        Me.AdminEndreBrukerGroup.SuspendLayout()
        Me.AdminBrukerSokGroup.SuspendLayout()
        Me.AdminMOTDGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'HovedTab
        '
        Me.HovedTab.Controls.Add(Me.StartTab)
        Me.HovedTab.Controls.Add(Me.UtleieTab)
        Me.HovedTab.Controls.Add(Me.KDTab)
        Me.HovedTab.Controls.Add(Me.InventarTab)
        Me.HovedTab.Controls.Add(Me.ISTab)
        Me.HovedTab.Controls.Add(Me.LogiTab)
        Me.HovedTab.Controls.Add(Me.StatTab)
        Me.HovedTab.Controls.Add(Me.AdminTab)
        Me.HovedTab.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HovedTab.Location = New System.Drawing.Point(12, 12)
        Me.HovedTab.Name = "HovedTab"
        Me.HovedTab.SelectedIndex = 0
        Me.HovedTab.Size = New System.Drawing.Size(984, 570)
        Me.HovedTab.TabIndex = 0
        '
        'StartTab
        '
        Me.StartTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartTab.Controls.Add(Me.StartMOTDLabel)
        Me.StartTab.Controls.Add(Me.StartRettigheterLabel)
        Me.StartTab.Controls.Add(Me.StartVelkommenLabel)
        Me.StartTab.Controls.Add(Me.StartLogo)
        Me.StartTab.Location = New System.Drawing.Point(4, 32)
        Me.StartTab.Name = "StartTab"
        Me.StartTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StartTab.Size = New System.Drawing.Size(976, 534)
        Me.StartTab.TabIndex = 0
        Me.StartTab.Text = "Start"
        Me.StartTab.UseVisualStyleBackColor = True
        '
        'UtleieTab
        '
        Me.UtleieTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UtleieTab.Location = New System.Drawing.Point(4, 32)
        Me.UtleieTab.Name = "UtleieTab"
        Me.UtleieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UtleieTab.Size = New System.Drawing.Size(976, 534)
        Me.UtleieTab.TabIndex = 1
        Me.UtleieTab.Text = "Utleie"
        Me.UtleieTab.UseVisualStyleBackColor = True
        '
        'KDTab
        '
        Me.KDTab.Location = New System.Drawing.Point(4, 32)
        Me.KDTab.Name = "KDTab"
        Me.KDTab.Size = New System.Drawing.Size(976, 534)
        Me.KDTab.TabIndex = 2
        Me.KDTab.Text = "Kundedatabase"
        Me.KDTab.UseVisualStyleBackColor = True
        '
        'InventarTab
        '
        Me.InventarTab.Location = New System.Drawing.Point(4, 32)
        Me.InventarTab.Name = "InventarTab"
        Me.InventarTab.Size = New System.Drawing.Size(976, 534)
        Me.InventarTab.TabIndex = 3
        Me.InventarTab.Text = "Inventar"
        Me.InventarTab.UseVisualStyleBackColor = True
        '
        'ISTab
        '
        Me.ISTab.Location = New System.Drawing.Point(4, 32)
        Me.ISTab.Name = "ISTab"
        Me.ISTab.Size = New System.Drawing.Size(976, 534)
        Me.ISTab.TabIndex = 4
        Me.ISTab.Text = "Inventar Søk"
        Me.ISTab.UseVisualStyleBackColor = True
        '
        'LogiTab
        '
        Me.LogiTab.Location = New System.Drawing.Point(4, 32)
        Me.LogiTab.Name = "LogiTab"
        Me.LogiTab.Size = New System.Drawing.Size(976, 534)
        Me.LogiTab.TabIndex = 5
        Me.LogiTab.Text = "Logistikk"
        Me.LogiTab.UseVisualStyleBackColor = True
        '
        'StatTab
        '
        Me.StatTab.Location = New System.Drawing.Point(4, 32)
        Me.StatTab.Name = "StatTab"
        Me.StatTab.Size = New System.Drawing.Size(976, 534)
        Me.StatTab.TabIndex = 6
        Me.StatTab.Text = "Statistikk"
        Me.StatTab.UseVisualStyleBackColor = True
        '
        'AdminTab
        '
        Me.AdminTab.Controls.Add(Me.AdminMOTDGroup)
        Me.AdminTab.Controls.Add(Me.AdminBrukerSokGroup)
        Me.AdminTab.Controls.Add(Me.AdminEndreBrukerGroup)
        Me.AdminTab.Controls.Add(Me.AdminNyBrukerGroup)
        Me.AdminTab.Location = New System.Drawing.Point(4, 32)
        Me.AdminTab.Name = "AdminTab"
        Me.AdminTab.Size = New System.Drawing.Size(976, 534)
        Me.AdminTab.TabIndex = 7
        Me.AdminTab.Text = "Admin"
        Me.AdminTab.UseVisualStyleBackColor = True
        '
        'StartLogo
        '
        Me.StartLogo.Image = CType(resources.GetObject("StartLogo.Image"), System.Drawing.Image)
        Me.StartLogo.InitialImage = CType(resources.GetObject("StartLogo.InitialImage"), System.Drawing.Image)
        Me.StartLogo.Location = New System.Drawing.Point(348, 121)
        Me.StartLogo.Name = "StartLogo"
        Me.StartLogo.Size = New System.Drawing.Size(257, 260)
        Me.StartLogo.TabIndex = 0
        Me.StartLogo.TabStop = False
        '
        'StartVelkommenLabel
        '
        Me.StartVelkommenLabel.AutoSize = True
        Me.StartVelkommenLabel.Location = New System.Drawing.Point(361, 34)
        Me.StartVelkommenLabel.Name = "StartVelkommenLabel"
        Me.StartVelkommenLabel.Size = New System.Drawing.Size(244, 23)
        Me.StartVelkommenLabel.TabIndex = 1
        Me.StartVelkommenLabel.Text = "Velkommen, Navn Navnesson"
        '
        'StartRettigheterLabel
        '
        Me.StartRettigheterLabel.AutoSize = True
        Me.StartRettigheterLabel.Location = New System.Drawing.Point(374, 73)
        Me.StartRettigheterLabel.Name = "StartRettigheterLabel"
        Me.StartRettigheterLabel.Size = New System.Drawing.Size(211, 23)
        Me.StartRettigheterLabel.TabIndex = 2
        Me.StartRettigheterLabel.Text = "Brukerrettigheter: Admin"
        '
        'StartMOTDLabel
        '
        Me.StartMOTDLabel.AutoSize = True
        Me.StartMOTDLabel.Location = New System.Drawing.Point(210, 445)
        Me.StartMOTDLabel.Name = "StartMOTDLabel"
        Me.StartMOTDLabel.Size = New System.Drawing.Size(539, 23)
        Me.StartMOTDLabel.TabIndex = 3
        Me.StartMOTDLabel.Text = "Message of the Day: Per, kunne du kjøpe erstatnings hjulene i dag?"
        '
        'AdminNyBrukerGroup
        '
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBTimeTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBOpprettB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.Label1)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBSPCB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBStillingCB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBAvdelingCB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBEpostTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBTelefonTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBEtternavnTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBFornavnTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBPassordTB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBTimeCB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBAdminCB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBAdminL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBEpostL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBSPL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBTelefonL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBTimelonnL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBStillingL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBAvdelingL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBEtternavnL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBFornavnL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBPassordL)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBBIDL)
        Me.AdminNyBrukerGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNyBrukerGroup.Location = New System.Drawing.Point(3, 3)
        Me.AdminNyBrukerGroup.Name = "AdminNyBrukerGroup"
        Me.AdminNyBrukerGroup.Size = New System.Drawing.Size(301, 528)
        Me.AdminNyBrukerGroup.TabIndex = 0
        Me.AdminNyBrukerGroup.TabStop = False
        Me.AdminNyBrukerGroup.Text = "Ny Bruker"
        '
        'AdminNBBIDL
        '
        Me.AdminNBBIDL.AutoSize = True
        Me.AdminNBBIDL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBBIDL.Location = New System.Drawing.Point(6, 36)
        Me.AdminNBBIDL.Name = "AdminNBBIDL"
        Me.AdminNBBIDL.Size = New System.Drawing.Size(69, 18)
        Me.AdminNBBIDL.TabIndex = 0
        Me.AdminNBBIDL.Text = "Bruker ID:"
        '
        'AdminNBPassordL
        '
        Me.AdminNBPassordL.AutoSize = True
        Me.AdminNBPassordL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBPassordL.Location = New System.Drawing.Point(6, 75)
        Me.AdminNBPassordL.Name = "AdminNBPassordL"
        Me.AdminNBPassordL.Size = New System.Drawing.Size(60, 18)
        Me.AdminNBPassordL.TabIndex = 1
        Me.AdminNBPassordL.Text = "Passord:"
        '
        'AdminNBFornavnL
        '
        Me.AdminNBFornavnL.AutoSize = True
        Me.AdminNBFornavnL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBFornavnL.Location = New System.Drawing.Point(6, 114)
        Me.AdminNBFornavnL.Name = "AdminNBFornavnL"
        Me.AdminNBFornavnL.Size = New System.Drawing.Size(62, 18)
        Me.AdminNBFornavnL.TabIndex = 2
        Me.AdminNBFornavnL.Text = "Fornavn:"
        '
        'AdminNBEtternavnL
        '
        Me.AdminNBEtternavnL.AutoSize = True
        Me.AdminNBEtternavnL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBEtternavnL.Location = New System.Drawing.Point(6, 156)
        Me.AdminNBEtternavnL.Name = "AdminNBEtternavnL"
        Me.AdminNBEtternavnL.Size = New System.Drawing.Size(72, 18)
        Me.AdminNBEtternavnL.TabIndex = 3
        Me.AdminNBEtternavnL.Text = "Etternavn:"
        '
        'AdminNBAvdelingL
        '
        Me.AdminNBAvdelingL.AutoSize = True
        Me.AdminNBAvdelingL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBAvdelingL.Location = New System.Drawing.Point(6, 198)
        Me.AdminNBAvdelingL.Name = "AdminNBAvdelingL"
        Me.AdminNBAvdelingL.Size = New System.Drawing.Size(67, 18)
        Me.AdminNBAvdelingL.TabIndex = 4
        Me.AdminNBAvdelingL.Text = "Avdeling:"
        '
        'AdminNBStillingL
        '
        Me.AdminNBStillingL.AutoSize = True
        Me.AdminNBStillingL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBStillingL.Location = New System.Drawing.Point(6, 240)
        Me.AdminNBStillingL.Name = "AdminNBStillingL"
        Me.AdminNBStillingL.Size = New System.Drawing.Size(54, 18)
        Me.AdminNBStillingL.TabIndex = 5
        Me.AdminNBStillingL.Text = "Stilling:"
        '
        'AdminNBTimelonnL
        '
        Me.AdminNBTimelonnL.AutoSize = True
        Me.AdminNBTimelonnL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBTimelonnL.Location = New System.Drawing.Point(6, 282)
        Me.AdminNBTimelonnL.Name = "AdminNBTimelonnL"
        Me.AdminNBTimelonnL.Size = New System.Drawing.Size(71, 18)
        Me.AdminNBTimelonnL.TabIndex = 6
        Me.AdminNBTimelonnL.Text = "Timelønn:"
        '
        'AdminNBTelefonL
        '
        Me.AdminNBTelefonL.AutoSize = True
        Me.AdminNBTelefonL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBTelefonL.Location = New System.Drawing.Point(7, 366)
        Me.AdminNBTelefonL.Name = "AdminNBTelefonL"
        Me.AdminNBTelefonL.Size = New System.Drawing.Size(59, 18)
        Me.AdminNBTelefonL.TabIndex = 7
        Me.AdminNBTelefonL.Text = "Telefon:"
        '
        'AdminNBSPL
        '
        Me.AdminNBSPL.AutoSize = True
        Me.AdminNBSPL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBSPL.Location = New System.Drawing.Point(6, 323)
        Me.AdminNBSPL.Name = "AdminNBSPL"
        Me.AdminNBSPL.Size = New System.Drawing.Size(108, 18)
        Me.AdminNBSPL.TabIndex = 8
        Me.AdminNBSPL.Text = "Stillingsprosent:"
        '
        'AdminNBEpostL
        '
        Me.AdminNBEpostL.AutoSize = True
        Me.AdminNBEpostL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBEpostL.Location = New System.Drawing.Point(7, 405)
        Me.AdminNBEpostL.Name = "AdminNBEpostL"
        Me.AdminNBEpostL.Size = New System.Drawing.Size(46, 18)
        Me.AdminNBEpostL.TabIndex = 9
        Me.AdminNBEpostL.Text = "Epost:"
        '
        'AdminNBAdminL
        '
        Me.AdminNBAdminL.AutoSize = True
        Me.AdminNBAdminL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBAdminL.Location = New System.Drawing.Point(7, 445)
        Me.AdminNBAdminL.Name = "AdminNBAdminL"
        Me.AdminNBAdminL.Size = New System.Drawing.Size(53, 18)
        Me.AdminNBAdminL.TabIndex = 10
        Me.AdminNBAdminL.Text = "Admin:"
        '
        'AdminNBAdminCB
        '
        Me.AdminNBAdminCB.AutoSize = True
        Me.AdminNBAdminCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBAdminCB.Location = New System.Drawing.Point(123, 444)
        Me.AdminNBAdminCB.Name = "AdminNBAdminCB"
        Me.AdminNBAdminCB.Size = New System.Drawing.Size(39, 22)
        Me.AdminNBAdminCB.TabIndex = 11
        Me.AdminNBAdminCB.Text = "Ja"
        Me.AdminNBAdminCB.UseVisualStyleBackColor = True
        '
        'AdminNBTimeCB
        '
        Me.AdminNBTimeCB.AutoSize = True
        Me.AdminNBTimeCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBTimeCB.Location = New System.Drawing.Point(123, 282)
        Me.AdminNBTimeCB.Name = "AdminNBTimeCB"
        Me.AdminNBTimeCB.Size = New System.Drawing.Size(39, 22)
        Me.AdminNBTimeCB.TabIndex = 12
        Me.AdminNBTimeCB.Text = "Ja"
        Me.AdminNBTimeCB.UseVisualStyleBackColor = True
        '
        'AdminNBPassordTB
        '
        Me.AdminNBPassordTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBPassordTB.Location = New System.Drawing.Point(123, 72)
        Me.AdminNBPassordTB.Name = "AdminNBPassordTB"
        Me.AdminNBPassordTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBPassordTB.TabIndex = 13
        '
        'AdminNBFornavnTB
        '
        Me.AdminNBFornavnTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBFornavnTB.Location = New System.Drawing.Point(123, 111)
        Me.AdminNBFornavnTB.Name = "AdminNBFornavnTB"
        Me.AdminNBFornavnTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBFornavnTB.TabIndex = 14
        '
        'AdminNBEtternavnTB
        '
        Me.AdminNBEtternavnTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBEtternavnTB.Location = New System.Drawing.Point(123, 153)
        Me.AdminNBEtternavnTB.Name = "AdminNBEtternavnTB"
        Me.AdminNBEtternavnTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBEtternavnTB.TabIndex = 15
        '
        'AdminNBTelefonTB
        '
        Me.AdminNBTelefonTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBTelefonTB.Location = New System.Drawing.Point(123, 363)
        Me.AdminNBTelefonTB.Name = "AdminNBTelefonTB"
        Me.AdminNBTelefonTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBTelefonTB.TabIndex = 16
        '
        'AdminNBEpostTB
        '
        Me.AdminNBEpostTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBEpostTB.Location = New System.Drawing.Point(123, 402)
        Me.AdminNBEpostTB.Name = "AdminNBEpostTB"
        Me.AdminNBEpostTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBEpostTB.TabIndex = 17
        '
        'AdminNBAvdelingCB
        '
        Me.AdminNBAvdelingCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBAvdelingCB.FormattingEnabled = True
        Me.AdminNBAvdelingCB.Location = New System.Drawing.Point(123, 195)
        Me.AdminNBAvdelingCB.Name = "AdminNBAvdelingCB"
        Me.AdminNBAvdelingCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminNBAvdelingCB.TabIndex = 18
        '
        'AdminNBStillingCB
        '
        Me.AdminNBStillingCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBStillingCB.FormattingEnabled = True
        Me.AdminNBStillingCB.Location = New System.Drawing.Point(123, 237)
        Me.AdminNBStillingCB.Name = "AdminNBStillingCB"
        Me.AdminNBStillingCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminNBStillingCB.TabIndex = 19
        '
        'AdminNBSPCB
        '
        Me.AdminNBSPCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBSPCB.FormattingEnabled = True
        Me.AdminNBSPCB.Location = New System.Drawing.Point(123, 320)
        Me.AdminNBSPCB.Name = "AdminNBSPCB"
        Me.AdminNBSPCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminNBSPCB.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "xxxxxx"
        '
        'AdminEndreBrukerGroup
        '
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBTimeTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEndreB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBLastInnB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBBIDTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBSPCB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBStillingCB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBAvdelingCB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEpostTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBTelefonTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEtternavnTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBFornavnTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBPassordTB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBTimeCB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBAdminCB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBAdminL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEpostL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBSPL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBTelefonL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBTimeL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBStillingL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBAvdelingL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEtternavnL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBFornavnL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBPassordL)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBBIDL)
        Me.AdminEndreBrukerGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEndreBrukerGroup.Location = New System.Drawing.Point(310, 3)
        Me.AdminEndreBrukerGroup.Name = "AdminEndreBrukerGroup"
        Me.AdminEndreBrukerGroup.Size = New System.Drawing.Size(301, 528)
        Me.AdminEndreBrukerGroup.TabIndex = 22
        Me.AdminEndreBrukerGroup.TabStop = False
        Me.AdminEndreBrukerGroup.Text = "Endre Bruker"
        '
        'AdminEBSPCB
        '
        Me.AdminEBSPCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBSPCB.FormattingEnabled = True
        Me.AdminEBSPCB.Location = New System.Drawing.Point(123, 320)
        Me.AdminEBSPCB.Name = "AdminEBSPCB"
        Me.AdminEBSPCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminEBSPCB.TabIndex = 20
        '
        'AdminEBStillingCB
        '
        Me.AdminEBStillingCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBStillingCB.FormattingEnabled = True
        Me.AdminEBStillingCB.Location = New System.Drawing.Point(123, 237)
        Me.AdminEBStillingCB.Name = "AdminEBStillingCB"
        Me.AdminEBStillingCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminEBStillingCB.TabIndex = 19
        '
        'AdminEBAvdelingCB
        '
        Me.AdminEBAvdelingCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBAvdelingCB.FormattingEnabled = True
        Me.AdminEBAvdelingCB.Location = New System.Drawing.Point(123, 195)
        Me.AdminEBAvdelingCB.Name = "AdminEBAvdelingCB"
        Me.AdminEBAvdelingCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminEBAvdelingCB.TabIndex = 18
        '
        'AdminEBEpostTB
        '
        Me.AdminEBEpostTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBEpostTB.Location = New System.Drawing.Point(123, 402)
        Me.AdminEBEpostTB.Name = "AdminEBEpostTB"
        Me.AdminEBEpostTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBEpostTB.TabIndex = 17
        '
        'AdminEBTelefonTB
        '
        Me.AdminEBTelefonTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBTelefonTB.Location = New System.Drawing.Point(123, 363)
        Me.AdminEBTelefonTB.Name = "AdminEBTelefonTB"
        Me.AdminEBTelefonTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBTelefonTB.TabIndex = 16
        '
        'AdminEBEtternavnTB
        '
        Me.AdminEBEtternavnTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBEtternavnTB.Location = New System.Drawing.Point(123, 153)
        Me.AdminEBEtternavnTB.Name = "AdminEBEtternavnTB"
        Me.AdminEBEtternavnTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBEtternavnTB.TabIndex = 15
        '
        'AdminEBFornavnTB
        '
        Me.AdminEBFornavnTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBFornavnTB.Location = New System.Drawing.Point(123, 111)
        Me.AdminEBFornavnTB.Name = "AdminEBFornavnTB"
        Me.AdminEBFornavnTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBFornavnTB.TabIndex = 14
        '
        'AdminEBPassordTB
        '
        Me.AdminEBPassordTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBPassordTB.Location = New System.Drawing.Point(123, 72)
        Me.AdminEBPassordTB.Name = "AdminEBPassordTB"
        Me.AdminEBPassordTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBPassordTB.TabIndex = 13
        '
        'AdminEBTimeCB
        '
        Me.AdminEBTimeCB.AutoSize = True
        Me.AdminEBTimeCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBTimeCB.Location = New System.Drawing.Point(123, 282)
        Me.AdminEBTimeCB.Name = "AdminEBTimeCB"
        Me.AdminEBTimeCB.Size = New System.Drawing.Size(39, 22)
        Me.AdminEBTimeCB.TabIndex = 12
        Me.AdminEBTimeCB.Text = "Ja"
        Me.AdminEBTimeCB.UseVisualStyleBackColor = True
        '
        'AdminEBAdminCB
        '
        Me.AdminEBAdminCB.AutoSize = True
        Me.AdminEBAdminCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBAdminCB.Location = New System.Drawing.Point(123, 444)
        Me.AdminEBAdminCB.Name = "AdminEBAdminCB"
        Me.AdminEBAdminCB.Size = New System.Drawing.Size(39, 22)
        Me.AdminEBAdminCB.TabIndex = 11
        Me.AdminEBAdminCB.Text = "Ja"
        Me.AdminEBAdminCB.UseVisualStyleBackColor = True
        '
        'AdminEBAdminL
        '
        Me.AdminEBAdminL.AutoSize = True
        Me.AdminEBAdminL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBAdminL.Location = New System.Drawing.Point(7, 445)
        Me.AdminEBAdminL.Name = "AdminEBAdminL"
        Me.AdminEBAdminL.Size = New System.Drawing.Size(53, 18)
        Me.AdminEBAdminL.TabIndex = 10
        Me.AdminEBAdminL.Text = "Admin:"
        '
        'AdminEBEpostL
        '
        Me.AdminEBEpostL.AutoSize = True
        Me.AdminEBEpostL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBEpostL.Location = New System.Drawing.Point(7, 405)
        Me.AdminEBEpostL.Name = "AdminEBEpostL"
        Me.AdminEBEpostL.Size = New System.Drawing.Size(46, 18)
        Me.AdminEBEpostL.TabIndex = 9
        Me.AdminEBEpostL.Text = "Epost:"
        '
        'AdminEBSPL
        '
        Me.AdminEBSPL.AutoSize = True
        Me.AdminEBSPL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBSPL.Location = New System.Drawing.Point(6, 323)
        Me.AdminEBSPL.Name = "AdminEBSPL"
        Me.AdminEBSPL.Size = New System.Drawing.Size(108, 18)
        Me.AdminEBSPL.TabIndex = 8
        Me.AdminEBSPL.Text = "Stillingsprosent:"
        '
        'AdminEBTelefonL
        '
        Me.AdminEBTelefonL.AutoSize = True
        Me.AdminEBTelefonL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBTelefonL.Location = New System.Drawing.Point(7, 366)
        Me.AdminEBTelefonL.Name = "AdminEBTelefonL"
        Me.AdminEBTelefonL.Size = New System.Drawing.Size(59, 18)
        Me.AdminEBTelefonL.TabIndex = 7
        Me.AdminEBTelefonL.Text = "Telefon:"
        '
        'AdminEBTimeL
        '
        Me.AdminEBTimeL.AutoSize = True
        Me.AdminEBTimeL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBTimeL.Location = New System.Drawing.Point(6, 282)
        Me.AdminEBTimeL.Name = "AdminEBTimeL"
        Me.AdminEBTimeL.Size = New System.Drawing.Size(71, 18)
        Me.AdminEBTimeL.TabIndex = 6
        Me.AdminEBTimeL.Text = "Timelønn:"
        '
        'AdminEBStillingL
        '
        Me.AdminEBStillingL.AutoSize = True
        Me.AdminEBStillingL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBStillingL.Location = New System.Drawing.Point(6, 240)
        Me.AdminEBStillingL.Name = "AdminEBStillingL"
        Me.AdminEBStillingL.Size = New System.Drawing.Size(54, 18)
        Me.AdminEBStillingL.TabIndex = 5
        Me.AdminEBStillingL.Text = "Stilling:"
        '
        'AdminEBAvdelingL
        '
        Me.AdminEBAvdelingL.AutoSize = True
        Me.AdminEBAvdelingL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBAvdelingL.Location = New System.Drawing.Point(6, 198)
        Me.AdminEBAvdelingL.Name = "AdminEBAvdelingL"
        Me.AdminEBAvdelingL.Size = New System.Drawing.Size(67, 18)
        Me.AdminEBAvdelingL.TabIndex = 4
        Me.AdminEBAvdelingL.Text = "Avdeling:"
        '
        'AdminEBEtternavnL
        '
        Me.AdminEBEtternavnL.AutoSize = True
        Me.AdminEBEtternavnL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBEtternavnL.Location = New System.Drawing.Point(6, 156)
        Me.AdminEBEtternavnL.Name = "AdminEBEtternavnL"
        Me.AdminEBEtternavnL.Size = New System.Drawing.Size(72, 18)
        Me.AdminEBEtternavnL.TabIndex = 3
        Me.AdminEBEtternavnL.Text = "Etternavn:"
        '
        'AdminEBFornavnL
        '
        Me.AdminEBFornavnL.AutoSize = True
        Me.AdminEBFornavnL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBFornavnL.Location = New System.Drawing.Point(6, 114)
        Me.AdminEBFornavnL.Name = "AdminEBFornavnL"
        Me.AdminEBFornavnL.Size = New System.Drawing.Size(62, 18)
        Me.AdminEBFornavnL.TabIndex = 2
        Me.AdminEBFornavnL.Text = "Fornavn:"
        '
        'AdminEBPassordL
        '
        Me.AdminEBPassordL.AutoSize = True
        Me.AdminEBPassordL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBPassordL.Location = New System.Drawing.Point(6, 75)
        Me.AdminEBPassordL.Name = "AdminEBPassordL"
        Me.AdminEBPassordL.Size = New System.Drawing.Size(60, 18)
        Me.AdminEBPassordL.TabIndex = 1
        Me.AdminEBPassordL.Text = "Passord:"
        '
        'AdminEBBIDL
        '
        Me.AdminEBBIDL.AutoSize = True
        Me.AdminEBBIDL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBBIDL.Location = New System.Drawing.Point(6, 36)
        Me.AdminEBBIDL.Name = "AdminEBBIDL"
        Me.AdminEBBIDL.Size = New System.Drawing.Size(69, 18)
        Me.AdminEBBIDL.TabIndex = 0
        Me.AdminEBBIDL.Text = "Bruker ID:"
        '
        'AdminEBBIDTB
        '
        Me.AdminEBBIDTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBBIDTB.Location = New System.Drawing.Point(123, 33)
        Me.AdminEBBIDTB.Name = "AdminEBBIDTB"
        Me.AdminEBBIDTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBBIDTB.TabIndex = 21
        '
        'AdminEBLastInnB
        '
        Me.AdminEBLastInnB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBLastInnB.Location = New System.Drawing.Point(229, 36)
        Me.AdminEBLastInnB.Name = "AdminEBLastInnB"
        Me.AdminEBLastInnB.Size = New System.Drawing.Size(37, 23)
        Me.AdminEBLastInnB.TabIndex = 22
        Me.AdminEBLastInnB.Text = "Gå!"
        Me.AdminEBLastInnB.UseVisualStyleBackColor = True
        '
        'AdminNBOpprettB
        '
        Me.AdminNBOpprettB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBOpprettB.Location = New System.Drawing.Point(94, 487)
        Me.AdminNBOpprettB.Name = "AdminNBOpprettB"
        Me.AdminNBOpprettB.Size = New System.Drawing.Size(110, 23)
        Me.AdminNBOpprettB.TabIndex = 23
        Me.AdminNBOpprettB.Text = "Opprett Bruker"
        Me.AdminNBOpprettB.UseVisualStyleBackColor = True
        '
        'AdminEBEndreB
        '
        Me.AdminEBEndreB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBEndreB.Location = New System.Drawing.Point(103, 487)
        Me.AdminEBEndreB.Name = "AdminEBEndreB"
        Me.AdminEBEndreB.Size = New System.Drawing.Size(100, 23)
        Me.AdminEBEndreB.TabIndex = 23
        Me.AdminEBEndreB.Text = "Endre Bruker"
        Me.AdminEBEndreB.UseVisualStyleBackColor = True
        '
        'AdminNBTimeTB
        '
        Me.AdminNBTimeTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNBTimeTB.Location = New System.Drawing.Point(168, 279)
        Me.AdminNBTimeTB.Name = "AdminNBTimeTB"
        Me.AdminNBTimeTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminNBTimeTB.TabIndex = 24
        '
        'AdminEBTimeTB
        '
        Me.AdminEBTimeTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEBTimeTB.Location = New System.Drawing.Point(166, 279)
        Me.AdminEBTimeTB.Name = "AdminEBTimeTB"
        Me.AdminEBTimeTB.Size = New System.Drawing.Size(100, 26)
        Me.AdminEBTimeTB.TabIndex = 25
        '
        'AdminBrukerSokGroup
        '
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSSokB)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSResultatLB)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSEtterCB)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSEtterL)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSFeltTB)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSFeltL)
        Me.AdminBrukerSokGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBrukerSokGroup.Location = New System.Drawing.Point(626, 3)
        Me.AdminBrukerSokGroup.Name = "AdminBrukerSokGroup"
        Me.AdminBrukerSokGroup.Size = New System.Drawing.Size(347, 300)
        Me.AdminBrukerSokGroup.TabIndex = 23
        Me.AdminBrukerSokGroup.TabStop = False
        Me.AdminBrukerSokGroup.Text = "Brukersøk"
        '
        'AdminBSFeltL
        '
        Me.AdminBSFeltL.AutoSize = True
        Me.AdminBSFeltL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSFeltL.Location = New System.Drawing.Point(6, 36)
        Me.AdminBSFeltL.Name = "AdminBSFeltL"
        Me.AdminBSFeltL.Size = New System.Drawing.Size(64, 18)
        Me.AdminBSFeltL.TabIndex = 1
        Me.AdminBSFeltL.Text = "Søkefelt:"
        '
        'AdminBSFeltTB
        '
        Me.AdminBSFeltTB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSFeltTB.Location = New System.Drawing.Point(101, 33)
        Me.AdminBSFeltTB.Name = "AdminBSFeltTB"
        Me.AdminBSFeltTB.Size = New System.Drawing.Size(191, 26)
        Me.AdminBSFeltTB.TabIndex = 22
        '
        'AdminBSEtterL
        '
        Me.AdminBSEtterL.AutoSize = True
        Me.AdminBSEtterL.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSEtterL.Location = New System.Drawing.Point(6, 75)
        Me.AdminBSEtterL.Name = "AdminBSEtterL"
        Me.AdminBSEtterL.Size = New System.Drawing.Size(68, 18)
        Me.AdminBSEtterL.TabIndex = 23
        Me.AdminBSEtterL.Text = "Søk etter:"
        '
        'AdminBSEtterCB
        '
        Me.AdminBSEtterCB.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSEtterCB.FormattingEnabled = True
        Me.AdminBSEtterCB.Location = New System.Drawing.Point(101, 72)
        Me.AdminBSEtterCB.Name = "AdminBSEtterCB"
        Me.AdminBSEtterCB.Size = New System.Drawing.Size(121, 26)
        Me.AdminBSEtterCB.TabIndex = 26
        '
        'AdminBSResultatLB
        '
        Me.AdminBSResultatLB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSResultatLB.FormattingEnabled = True
        Me.AdminBSResultatLB.ItemHeight = 15
        Me.AdminBSResultatLB.Location = New System.Drawing.Point(6, 114)
        Me.AdminBSResultatLB.Name = "AdminBSResultatLB"
        Me.AdminBSResultatLB.Size = New System.Drawing.Size(335, 169)
        Me.AdminBSResultatLB.TabIndex = 27
        '
        'AdminMOTDGroup
        '
        Me.AdminMOTDGroup.Controls.Add(Me.AdminMOTDEndreB)
        Me.AdminMOTDGroup.Controls.Add(Me.AdminMOTDTB)
        Me.AdminMOTDGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMOTDGroup.Location = New System.Drawing.Point(626, 310)
        Me.AdminMOTDGroup.Name = "AdminMOTDGroup"
        Me.AdminMOTDGroup.Size = New System.Drawing.Size(347, 221)
        Me.AdminMOTDGroup.TabIndex = 24
        Me.AdminMOTDGroup.TabStop = False
        Me.AdminMOTDGroup.Text = "MOTD"
        '
        'AdminMOTDTB
        '
        Me.AdminMOTDTB.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMOTDTB.Location = New System.Drawing.Point(9, 31)
        Me.AdminMOTDTB.Multiline = True
        Me.AdminMOTDTB.Name = "AdminMOTDTB"
        Me.AdminMOTDTB.Size = New System.Drawing.Size(321, 128)
        Me.AdminMOTDTB.TabIndex = 0
        '
        'AdminMOTDEndreB
        '
        Me.AdminMOTDEndreB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMOTDEndreB.Location = New System.Drawing.Point(113, 180)
        Me.AdminMOTDEndreB.Name = "AdminMOTDEndreB"
        Me.AdminMOTDEndreB.Size = New System.Drawing.Size(100, 23)
        Me.AdminMOTDEndreB.TabIndex = 26
        Me.AdminMOTDEndreB.Text = "Endre MOTD"
        Me.AdminMOTDEndreB.UseVisualStyleBackColor = True
        '
        'AdminBSSokB
        '
        Me.AdminBSSokB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBSSokB.Location = New System.Drawing.Point(252, 73)
        Me.AdminBSSokB.Name = "AdminBSSokB"
        Me.AdminBSSokB.Size = New System.Drawing.Size(62, 23)
        Me.AdminBSSokB.TabIndex = 28
        Me.AdminBSSokB.Text = "Søk!"
        Me.AdminBSSokB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 594)
        Me.Controls.Add(Me.HovedTab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SykkelUtleie DB"
        Me.HovedTab.ResumeLayout(False)
        Me.StartTab.ResumeLayout(False)
        Me.StartTab.PerformLayout()
        Me.AdminTab.ResumeLayout(False)
        CType(Me.StartLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminNyBrukerGroup.ResumeLayout(False)
        Me.AdminNyBrukerGroup.PerformLayout()
        Me.AdminEndreBrukerGroup.ResumeLayout(False)
        Me.AdminEndreBrukerGroup.PerformLayout()
        Me.AdminBrukerSokGroup.ResumeLayout(False)
        Me.AdminBrukerSokGroup.PerformLayout()
        Me.AdminMOTDGroup.ResumeLayout(False)
        Me.AdminMOTDGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HovedTab As TabControl
    Friend WithEvents StartTab As TabPage
    Friend WithEvents UtleieTab As TabPage
    Friend WithEvents KDTab As TabPage
    Friend WithEvents InventarTab As TabPage
    Friend WithEvents ISTab As TabPage
    Friend WithEvents LogiTab As TabPage
    Friend WithEvents StatTab As TabPage
    Friend WithEvents AdminTab As TabPage
    Friend WithEvents StartMOTDLabel As Label
    Friend WithEvents StartRettigheterLabel As Label
    Friend WithEvents StartVelkommenLabel As Label
    Friend WithEvents StartLogo As PictureBox
    Friend WithEvents AdminEndreBrukerGroup As GroupBox
    Friend WithEvents AdminEBTimeTB As TextBox
    Friend WithEvents AdminEBEndreB As Button
    Friend WithEvents AdminEBLastInnB As Button
    Friend WithEvents AdminEBBIDTB As TextBox
    Friend WithEvents AdminEBSPCB As ComboBox
    Friend WithEvents AdminEBStillingCB As ComboBox
    Friend WithEvents AdminEBAvdelingCB As ComboBox
    Friend WithEvents AdminEBEpostTB As TextBox
    Friend WithEvents AdminEBTelefonTB As TextBox
    Friend WithEvents AdminEBEtternavnTB As TextBox
    Friend WithEvents AdminEBFornavnTB As TextBox
    Friend WithEvents AdminEBPassordTB As TextBox
    Friend WithEvents AdminEBTimeCB As CheckBox
    Friend WithEvents AdminEBAdminCB As CheckBox
    Friend WithEvents AdminEBAdminL As Label
    Friend WithEvents AdminEBEpostL As Label
    Friend WithEvents AdminEBSPL As Label
    Friend WithEvents AdminEBTelefonL As Label
    Friend WithEvents AdminEBTimeL As Label
    Friend WithEvents AdminEBStillingL As Label
    Friend WithEvents AdminEBAvdelingL As Label
    Friend WithEvents AdminEBEtternavnL As Label
    Friend WithEvents AdminEBFornavnL As Label
    Friend WithEvents AdminEBPassordL As Label
    Friend WithEvents AdminEBBIDL As Label
    Friend WithEvents AdminNyBrukerGroup As GroupBox
    Friend WithEvents AdminNBTimeTB As TextBox
    Friend WithEvents AdminNBOpprettB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents AdminNBSPCB As ComboBox
    Friend WithEvents AdminNBStillingCB As ComboBox
    Friend WithEvents AdminNBAvdelingCB As ComboBox
    Friend WithEvents AdminNBEpostTB As TextBox
    Friend WithEvents AdminNBTelefonTB As TextBox
    Friend WithEvents AdminNBEtternavnTB As TextBox
    Friend WithEvents AdminNBFornavnTB As TextBox
    Friend WithEvents AdminNBPassordTB As TextBox
    Friend WithEvents AdminNBTimeCB As CheckBox
    Friend WithEvents AdminNBAdminCB As CheckBox
    Friend WithEvents AdminNBAdminL As Label
    Friend WithEvents AdminNBEpostL As Label
    Friend WithEvents AdminNBSPL As Label
    Friend WithEvents AdminNBTelefonL As Label
    Friend WithEvents AdminNBTimelonnL As Label
    Friend WithEvents AdminNBStillingL As Label
    Friend WithEvents AdminNBAvdelingL As Label
    Friend WithEvents AdminNBEtternavnL As Label
    Friend WithEvents AdminNBFornavnL As Label
    Friend WithEvents AdminNBPassordL As Label
    Friend WithEvents AdminNBBIDL As Label
    Friend WithEvents AdminBrukerSokGroup As GroupBox
    Friend WithEvents AdminBSResultatLB As ListBox
    Friend WithEvents AdminBSEtterCB As ComboBox
    Friend WithEvents AdminBSEtterL As Label
    Friend WithEvents AdminBSFeltTB As TextBox
    Friend WithEvents AdminBSFeltL As Label
    Friend WithEvents AdminMOTDGroup As GroupBox
    Friend WithEvents AdminMOTDEndreB As Button
    Friend WithEvents AdminMOTDTB As TextBox
    Friend WithEvents AdminBSSokB As Button
End Class
