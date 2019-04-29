<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.HovedTab = New System.Windows.Forms.TabControl()
        Me.StartTab = New System.Windows.Forms.TabPage()
        Me.LblStartMOTD = New System.Windows.Forms.Label()
        Me.StartRettigheterLabel = New System.Windows.Forms.Label()
        Me.StartVelkommenLabel = New System.Windows.Forms.Label()
        Me.StartLogo = New System.Windows.Forms.PictureBox()
        Me.UtleieTab = New System.Windows.Forms.TabPage()
        Me.GrpUtleieKundeInfo = New System.Windows.Forms.GroupBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.KundeID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Fornavn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Etternavn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Adresse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tlf = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Epost = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpUtleieKunde = New System.Windows.Forms.GroupBox()
        Me.BtnUtleieNyKunde = New System.Windows.Forms.Button()
        Me.BtnUtleieKundeSok = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblUtleieKundesok = New System.Windows.Forms.Label()
        Me.GrpUtleieSelger = New System.Windows.Forms.GroupBox()
        Me.LblUtleieSelger = New System.Windows.Forms.Label()
        Me.GrpUtleieAvd = New System.Windows.Forms.GroupBox()
        Me.LblUtleieKlokke = New System.Windows.Forms.Label()
        Me.LblUtleieKlokkeTxt = New System.Windows.Forms.Label()
        Me.LblUtleieDatoTxt = New System.Windows.Forms.Label()
        Me.LblUtleieAvdTxt = New System.Windows.Forms.Label()
        Me.LblUtleieDato = New System.Windows.Forms.Label()
        Me.LblUtleieAvd = New System.Windows.Forms.Label()
        Me.KDTab = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtKndEndreHF = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreRbt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnKndEndre = New System.Windows.Forms.Button()
        Me.BtnKndKundeID = New System.Windows.Forms.Button()
        Me.TxtKndKundeID = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreEP = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreTlf = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreAdr = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreEN = New System.Windows.Forms.TextBox()
        Me.TxtKndEndreFN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BtnKndRegistrer = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtKndEpost = New System.Windows.Forms.TextBox()
        Me.TxtKndTlf = New System.Windows.Forms.TextBox()
        Me.TxtKndAdresse = New System.Windows.Forms.TextBox()
        Me.TxtKndEtternavn = New System.Windows.Forms.TextBox()
        Me.TxtKndFornavn = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LvKndSok = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnKndSok = New System.Windows.Forms.Button()
        Me.CmbKndSok = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKndSok = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InventarTab = New System.Windows.Forms.TabPage()
        Me.GrpInvSok = New System.Windows.Forms.GroupBox()
        Me.LvInvSok = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Produktnavn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Varenummer = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Kategori = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Ramme = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Girsystem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Hjulstørrelse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Innkjøpspris = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Avdeling = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Forhandler = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Status = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Skadet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Savnet = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GrpInvRegistrerEndre = New System.Windows.Forms.GroupBox()
        Me.BtnInvTest = New System.Windows.Forms.Button()
        Me.BtnInvAvbrytEndre = New System.Windows.Forms.Button()
        Me.BtnInvTom = New System.Windows.Forms.Button()
        Me.LblInvAktivProdukt = New System.Windows.Forms.Label()
        Me.BtnInvSok = New System.Windows.Forms.Button()
        Me.LblInvHentID = New System.Windows.Forms.Label()
        Me.TxtInvHentID = New System.Windows.Forms.TextBox()
        Me.BtnInvHent = New System.Windows.Forms.Button()
        Me.BtnInvEndre = New System.Windows.Forms.Button()
        Me.LblInvSavnet = New System.Windows.Forms.Label()
        Me.LblInvSkadet = New System.Windows.Forms.Label()
        Me.LblInvStatus = New System.Windows.Forms.Label()
        Me.CboInvStatus = New System.Windows.Forms.ComboBox()
        Me.CboInvSkadet = New System.Windows.Forms.ComboBox()
        Me.CboInvSavnet = New System.Windows.Forms.ComboBox()
        Me.CboInvSubkategori = New System.Windows.Forms.ComboBox()
        Me.LblInvSubkategori = New System.Windows.Forms.Label()
        Me.TxtInvGirsystem = New System.Windows.Forms.TextBox()
        Me.TxtInvHjulstorrelse = New System.Windows.Forms.TextBox()
        Me.TxtInvRamme = New System.Windows.Forms.TextBox()
        Me.LblInvGirsystem = New System.Windows.Forms.Label()
        Me.LblInvHjulstorrelse = New System.Windows.Forms.Label()
        Me.LblInvRamme = New System.Windows.Forms.Label()
        Me.CboInvAvdeling = New System.Windows.Forms.ComboBox()
        Me.CboInvKategori = New System.Windows.Forms.ComboBox()
        Me.TxtInvInnkjopspris = New System.Windows.Forms.TextBox()
        Me.BtnInvRegistrer = New System.Windows.Forms.Button()
        Me.CboInvForhandler = New System.Windows.Forms.ComboBox()
        Me.TxtInvVareNummer = New System.Windows.Forms.TextBox()
        Me.TxtInvProduktnavn = New System.Windows.Forms.TextBox()
        Me.LblInvForhandler = New System.Windows.Forms.Label()
        Me.LblInvInnkjopspris = New System.Windows.Forms.Label()
        Me.LblInvVarenummer = New System.Windows.Forms.Label()
        Me.LblInvProduktnavn = New System.Windows.Forms.Label()
        Me.LblInvAvdeling = New System.Windows.Forms.Label()
        Me.LblInvKategori = New System.Windows.Forms.Label()
        Me.ISTab = New System.Windows.Forms.TabPage()
        Me.LogiTab = New System.Windows.Forms.TabPage()
        Me.StatTab = New System.Windows.Forms.TabPage()
        Me.AdminTab = New System.Windows.Forms.TabPage()
        Me.AdminMOTDGroup = New System.Windows.Forms.GroupBox()
        Me.AdminMOTDEndreB = New System.Windows.Forms.Button()
        Me.TxtAdminMOTD = New System.Windows.Forms.TextBox()
        Me.AdminBrukerSokGroup = New System.Windows.Forms.GroupBox()
        Me.LvAdminBS = New System.Windows.Forms.ListView()
        Me.LvAdminBID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVAdminFornavn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVAdminEtternavn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LVAdminSoekefelt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AdminBSSokB = New System.Windows.Forms.Button()
        Me.CboAdminBSEtter = New System.Windows.Forms.ComboBox()
        Me.LblAdminBSEtter = New System.Windows.Forms.Label()
        Me.TxtAdminBSFelt = New System.Windows.Forms.TextBox()
        Me.LblAdminBSFelt = New System.Windows.Forms.Label()
        Me.AdminEndreBrukerGroup = New System.Windows.Forms.GroupBox()
        Me.TxtAdminEBTime = New System.Windows.Forms.TextBox()
        Me.AdminEBEndreB = New System.Windows.Forms.Button()
        Me.AdminEBLastInnB = New System.Windows.Forms.Button()
        Me.TxtAdminEBBID = New System.Windows.Forms.TextBox()
        Me.CboAdminEBSP = New System.Windows.Forms.ComboBox()
        Me.CboAdminEBStilling = New System.Windows.Forms.ComboBox()
        Me.CboAdminEBAvdeling = New System.Windows.Forms.ComboBox()
        Me.TxtAdminEBEpost = New System.Windows.Forms.TextBox()
        Me.TxtAdminEBTelefon = New System.Windows.Forms.TextBox()
        Me.TxtAdminEBEtternavn = New System.Windows.Forms.TextBox()
        Me.TxtAdminEBFornavn = New System.Windows.Forms.TextBox()
        Me.TxtAdminEBPassord = New System.Windows.Forms.TextBox()
        Me.ChkAdminEBTime = New System.Windows.Forms.CheckBox()
        Me.ChkAdminEBAdmin = New System.Windows.Forms.CheckBox()
        Me.LblAdminEBAdmin = New System.Windows.Forms.Label()
        Me.LblAdminEBEpost = New System.Windows.Forms.Label()
        Me.LblAdminEBSP = New System.Windows.Forms.Label()
        Me.LblAdminEBTelefon = New System.Windows.Forms.Label()
        Me.LblAdminEBTime = New System.Windows.Forms.Label()
        Me.LblAdminEBStilling = New System.Windows.Forms.Label()
        Me.LblAdminEBAvdeling = New System.Windows.Forms.Label()
        Me.LblAdminEBEtternavn = New System.Windows.Forms.Label()
        Me.LblAdminEBFornavn = New System.Windows.Forms.Label()
        Me.LblAdminEBPassord = New System.Windows.Forms.Label()
        Me.LblAdminEBBID = New System.Windows.Forms.Label()
        Me.AdminNyBrukerGroup = New System.Windows.Forms.GroupBox()
        Me.TxtAdminNBTime = New System.Windows.Forms.TextBox()
        Me.AdminNBOpprettB = New System.Windows.Forms.Button()
        Me.LblBrukerIDNBVis = New System.Windows.Forms.Label()
        Me.CboAdminNBSP = New System.Windows.Forms.ComboBox()
        Me.CboAdminNBStilling = New System.Windows.Forms.ComboBox()
        Me.CboAdminNBAvdeling = New System.Windows.Forms.ComboBox()
        Me.TxtAdminNBEpost = New System.Windows.Forms.TextBox()
        Me.TxtAdminNBTelefon = New System.Windows.Forms.TextBox()
        Me.TxtAdminNBEtternavn = New System.Windows.Forms.TextBox()
        Me.TxtAdminNBFornavn = New System.Windows.Forms.TextBox()
        Me.TxtAdminNBPassord = New System.Windows.Forms.TextBox()
        Me.ChkAdminNBTime = New System.Windows.Forms.CheckBox()
        Me.ChkAdminNBAdmin = New System.Windows.Forms.CheckBox()
        Me.LblAdminNBAdmin = New System.Windows.Forms.Label()
        Me.LblAdminNBEpost = New System.Windows.Forms.Label()
        Me.LblAdminNBSP = New System.Windows.Forms.Label()
        Me.LblAdminNBTelefon = New System.Windows.Forms.Label()
        Me.LblAdminNBTimelonn = New System.Windows.Forms.Label()
        Me.LblAdminNBStilling = New System.Windows.Forms.Label()
        Me.LblAdminNBAvdeling = New System.Windows.Forms.Label()
        Me.LblAdminNBEtternavn = New System.Windows.Forms.Label()
        Me.LblAdminNBFornavn = New System.Windows.Forms.Label()
        Me.LblAdminNBPassord = New System.Windows.Forms.Label()
        Me.LblAdminNBBID = New System.Windows.Forms.Label()
        Me.DBAdminTab = New System.Windows.Forms.TabPage()
        Me.LblKndFdato = New System.Windows.Forms.Label()
        Me.DateKndFdato = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HovedTab.SuspendLayout()
        Me.StartTab.SuspendLayout()
        CType(Me.StartLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UtleieTab.SuspendLayout()
        Me.GrpUtleieKundeInfo.SuspendLayout()
        Me.GrpUtleieKunde.SuspendLayout()
        Me.GrpUtleieSelger.SuspendLayout()
        Me.GrpUtleieAvd.SuspendLayout()
        Me.KDTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.InventarTab.SuspendLayout()
        Me.GrpInvSok.SuspendLayout()
        Me.GrpInvRegistrerEndre.SuspendLayout()
        Me.AdminTab.SuspendLayout()
        Me.AdminMOTDGroup.SuspendLayout()
        Me.AdminBrukerSokGroup.SuspendLayout()
        Me.AdminEndreBrukerGroup.SuspendLayout()
        Me.AdminNyBrukerGroup.SuspendLayout()
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
        Me.HovedTab.Controls.Add(Me.DBAdminTab)
        Me.HovedTab.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HovedTab.Location = New System.Drawing.Point(12, 12)
        Me.HovedTab.Name = "HovedTab"
        Me.HovedTab.SelectedIndex = 0
        Me.HovedTab.Size = New System.Drawing.Size(1424, 780)
        Me.HovedTab.TabIndex = 0
        '
        'StartTab
        '
        Me.StartTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartTab.Controls.Add(Me.LblStartMOTD)
        Me.StartTab.Controls.Add(Me.StartRettigheterLabel)
        Me.StartTab.Controls.Add(Me.StartVelkommenLabel)
        Me.StartTab.Controls.Add(Me.StartLogo)
        Me.StartTab.Location = New System.Drawing.Point(4, 32)
        Me.StartTab.Name = "StartTab"
        Me.StartTab.Padding = New System.Windows.Forms.Padding(3)
        Me.StartTab.Size = New System.Drawing.Size(1416, 744)
        Me.StartTab.TabIndex = 0
        Me.StartTab.Text = "Start"
        Me.StartTab.UseVisualStyleBackColor = True
        '
        'LblStartMOTD
        '
        Me.LblStartMOTD.Location = New System.Drawing.Point(19, 426)
        Me.LblStartMOTD.Name = "LblStartMOTD"
        Me.LblStartMOTD.Size = New System.Drawing.Size(1192, 50)
        Me.LblStartMOTD.TabIndex = 3
        Me.LblStartMOTD.Text = "Message of the Day: Per, kunne du kjøpe erstatnings hjulene i dag?"
        Me.LblStartMOTD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'StartRettigheterLabel
        '
        Me.StartRettigheterLabel.AutoSize = True
        Me.StartRettigheterLabel.Location = New System.Drawing.Point(507, 72)
        Me.StartRettigheterLabel.Name = "StartRettigheterLabel"
        Me.StartRettigheterLabel.Size = New System.Drawing.Size(211, 23)
        Me.StartRettigheterLabel.TabIndex = 2
        Me.StartRettigheterLabel.Text = "Brukerrettigheter: Admin"
        '
        'StartVelkommenLabel
        '
        Me.StartVelkommenLabel.AutoSize = True
        Me.StartVelkommenLabel.Location = New System.Drawing.Point(489, 28)
        Me.StartVelkommenLabel.Name = "StartVelkommenLabel"
        Me.StartVelkommenLabel.Size = New System.Drawing.Size(244, 23)
        Me.StartVelkommenLabel.TabIndex = 1
        Me.StartVelkommenLabel.Text = "Velkommen, Navn Navnesson"
        '
        'StartLogo
        '
        Me.StartLogo.Image = CType(resources.GetObject("StartLogo.Image"), System.Drawing.Image)
        Me.StartLogo.InitialImage = CType(resources.GetObject("StartLogo.InitialImage"), System.Drawing.Image)
        Me.StartLogo.Location = New System.Drawing.Point(476, 129)
        Me.StartLogo.Name = "StartLogo"
        Me.StartLogo.Size = New System.Drawing.Size(257, 260)
        Me.StartLogo.TabIndex = 0
        Me.StartLogo.TabStop = False
        '
        'UtleieTab
        '
        Me.UtleieTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UtleieTab.Controls.Add(Me.GrpUtleieKundeInfo)
        Me.UtleieTab.Controls.Add(Me.GrpUtleieKunde)
        Me.UtleieTab.Controls.Add(Me.GrpUtleieSelger)
        Me.UtleieTab.Controls.Add(Me.GrpUtleieAvd)
        Me.UtleieTab.Location = New System.Drawing.Point(4, 32)
        Me.UtleieTab.Name = "UtleieTab"
        Me.UtleieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UtleieTab.Size = New System.Drawing.Size(1416, 744)
        Me.UtleieTab.TabIndex = 1
        Me.UtleieTab.Text = "Utleie"
        Me.UtleieTab.UseVisualStyleBackColor = True
        '
        'GrpUtleieKundeInfo
        '
        Me.GrpUtleieKundeInfo.Controls.Add(Me.ListView1)
        Me.GrpUtleieKundeInfo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline)
        Me.GrpUtleieKundeInfo.Location = New System.Drawing.Point(6, 150)
        Me.GrpUtleieKundeInfo.Name = "GrpUtleieKundeInfo"
        Me.GrpUtleieKundeInfo.Size = New System.Drawing.Size(573, 141)
        Me.GrpUtleieKundeInfo.TabIndex = 3
        Me.GrpUtleieKundeInfo.TabStop = False
        Me.GrpUtleieKundeInfo.Text = "Kundeinfo:"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.KundeID, Me.Fornavn, Me.Etternavn, Me.Adresse, Me.Tlf, Me.Epost})
        Me.ListView1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(15, 30)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(547, 99)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'KundeID
        '
        Me.KundeID.Text = "KundeID"
        Me.KundeID.Width = 59
        '
        'Fornavn
        '
        Me.Fornavn.Text = "Fornavn"
        Me.Fornavn.Width = 91
        '
        'Etternavn
        '
        Me.Etternavn.Text = "Etternavn"
        Me.Etternavn.Width = 77
        '
        'Adresse
        '
        Me.Adresse.Text = "Adresse"
        Me.Adresse.Width = 72
        '
        'Tlf
        '
        Me.Tlf.Text = "Tlf"
        Me.Tlf.Width = 54
        '
        'Epost
        '
        Me.Epost.Text = "Epost"
        Me.Epost.Width = 136
        '
        'GrpUtleieKunde
        '
        Me.GrpUtleieKunde.Controls.Add(Me.BtnUtleieNyKunde)
        Me.GrpUtleieKunde.Controls.Add(Me.BtnUtleieKundeSok)
        Me.GrpUtleieKunde.Controls.Add(Me.TextBox1)
        Me.GrpUtleieKunde.Controls.Add(Me.LblUtleieKundesok)
        Me.GrpUtleieKunde.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline)
        Me.GrpUtleieKunde.Location = New System.Drawing.Point(12, 2)
        Me.GrpUtleieKunde.Name = "GrpUtleieKunde"
        Me.GrpUtleieKunde.Size = New System.Drawing.Size(345, 138)
        Me.GrpUtleieKunde.TabIndex = 2
        Me.GrpUtleieKunde.TabStop = False
        Me.GrpUtleieKunde.Text = "Kundesøk:"
        '
        'BtnUtleieNyKunde
        '
        Me.BtnUtleieNyKunde.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BtnUtleieNyKunde.Location = New System.Drawing.Point(238, 90)
        Me.BtnUtleieNyKunde.Name = "BtnUtleieNyKunde"
        Me.BtnUtleieNyKunde.Size = New System.Drawing.Size(101, 39)
        Me.BtnUtleieNyKunde.TabIndex = 3
        Me.BtnUtleieNyKunde.Text = "Ny kunde?"
        Me.BtnUtleieNyKunde.UseVisualStyleBackColor = True
        '
        'BtnUtleieKundeSok
        '
        Me.BtnUtleieKundeSok.Font = New System.Drawing.Font("Calibri", 14.25!)
        Me.BtnUtleieKundeSok.Location = New System.Drawing.Point(9, 93)
        Me.BtnUtleieKundeSok.Name = "BtnUtleieKundeSok"
        Me.BtnUtleieKundeSok.Size = New System.Drawing.Size(82, 32)
        Me.BtnUtleieKundeSok.TabIndex = 2
        Me.BtnUtleieKundeSok.Text = "SØK"
        Me.BtnUtleieKundeSok.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 56)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(157, 31)
        Me.TextBox1.TabIndex = 1
        '
        'LblUtleieKundesok
        '
        Me.LblUtleieKundesok.AutoSize = True
        Me.LblUtleieKundesok.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieKundesok.Location = New System.Drawing.Point(6, 31)
        Me.LblUtleieKundesok.Name = "LblUtleieKundesok"
        Me.LblUtleieKundesok.Size = New System.Drawing.Size(160, 18)
        Me.LblUtleieKundesok.TabIndex = 0
        Me.LblUtleieKundesok.Text = "Søk etter mobilnummer:"
        '
        'GrpUtleieSelger
        '
        Me.GrpUtleieSelger.Controls.Add(Me.LblUtleieSelger)
        Me.GrpUtleieSelger.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline)
        Me.GrpUtleieSelger.Location = New System.Drawing.Point(717, 6)
        Me.GrpUtleieSelger.Name = "GrpUtleieSelger"
        Me.GrpUtleieSelger.Size = New System.Drawing.Size(188, 138)
        Me.GrpUtleieSelger.TabIndex = 1
        Me.GrpUtleieSelger.TabStop = False
        Me.GrpUtleieSelger.Text = "Selger:"
        '
        'LblUtleieSelger
        '
        Me.LblUtleieSelger.AutoSize = True
        Me.LblUtleieSelger.Location = New System.Drawing.Point(46, 43)
        Me.LblUtleieSelger.Name = "LblUtleieSelger"
        Me.LblUtleieSelger.Size = New System.Drawing.Size(79, 23)
        Me.LblUtleieSelger.TabIndex = 0
        Me.LblUtleieSelger.Text = "SelgerTxt"
        '
        'GrpUtleieAvd
        '
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieKlokke)
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieKlokkeTxt)
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieDatoTxt)
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieAvdTxt)
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieDato)
        Me.GrpUtleieAvd.Controls.Add(Me.LblUtleieAvd)
        Me.GrpUtleieAvd.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline)
        Me.GrpUtleieAvd.Location = New System.Drawing.Point(944, 6)
        Me.GrpUtleieAvd.Name = "GrpUtleieAvd"
        Me.GrpUtleieAvd.Size = New System.Drawing.Size(271, 138)
        Me.GrpUtleieAvd.TabIndex = 0
        Me.GrpUtleieAvd.TabStop = False
        Me.GrpUtleieAvd.Text = "Tid og sted:"
        '
        'LblUtleieKlokke
        '
        Me.LblUtleieKlokke.AutoSize = True
        Me.LblUtleieKlokke.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieKlokke.Location = New System.Drawing.Point(133, 98)
        Me.LblUtleieKlokke.Name = "LblUtleieKlokke"
        Me.LblUtleieKlokke.Size = New System.Drawing.Size(45, 18)
        Me.LblUtleieKlokke.TabIndex = 4
        Me.LblUtleieKlokke.Text = "TidTxt"
        '
        'LblUtleieKlokkeTxt
        '
        Me.LblUtleieKlokkeTxt.AutoSize = True
        Me.LblUtleieKlokkeTxt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieKlokkeTxt.Location = New System.Drawing.Point(22, 98)
        Me.LblUtleieKlokkeTxt.Name = "LblUtleieKlokkeTxt"
        Me.LblUtleieKlokkeTxt.Size = New System.Drawing.Size(54, 18)
        Me.LblUtleieKlokkeTxt.TabIndex = 3
        Me.LblUtleieKlokkeTxt.Text = "Klokke:"
        '
        'LblUtleieDatoTxt
        '
        Me.LblUtleieDatoTxt.AutoSize = True
        Me.LblUtleieDatoTxt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieDatoTxt.Location = New System.Drawing.Point(133, 63)
        Me.LblUtleieDatoTxt.Name = "LblUtleieDatoTxt"
        Me.LblUtleieDatoTxt.Size = New System.Drawing.Size(55, 18)
        Me.LblUtleieDatoTxt.TabIndex = 2
        Me.LblUtleieDatoTxt.Text = "DatoTxt"
        '
        'LblUtleieAvdTxt
        '
        Me.LblUtleieAvdTxt.AutoSize = True
        Me.LblUtleieAvdTxt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieAvdTxt.Location = New System.Drawing.Point(133, 31)
        Me.LblUtleieAvdTxt.Name = "LblUtleieAvdTxt"
        Me.LblUtleieAvdTxt.Size = New System.Drawing.Size(50, 18)
        Me.LblUtleieAvdTxt.TabIndex = 1
        Me.LblUtleieAvdTxt.Text = "AvdTxt"
        '
        'LblUtleieDato
        '
        Me.LblUtleieDato.AutoSize = True
        Me.LblUtleieDato.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieDato.Location = New System.Drawing.Point(22, 63)
        Me.LblUtleieDato.Name = "LblUtleieDato"
        Me.LblUtleieDato.Size = New System.Drawing.Size(41, 18)
        Me.LblUtleieDato.TabIndex = 1
        Me.LblUtleieDato.Text = "Dato:"
        '
        'LblUtleieAvd
        '
        Me.LblUtleieAvd.AutoSize = True
        Me.LblUtleieAvd.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline)
        Me.LblUtleieAvd.Location = New System.Drawing.Point(22, 31)
        Me.LblUtleieAvd.Name = "LblUtleieAvd"
        Me.LblUtleieAvd.Size = New System.Drawing.Size(67, 18)
        Me.LblUtleieAvd.TabIndex = 0
        Me.LblUtleieAvd.Text = "Avdeling:"
        '
        'KDTab
        '
        Me.KDTab.Controls.Add(Me.GroupBox3)
        Me.KDTab.Controls.Add(Me.GroupBox4)
        Me.KDTab.Controls.Add(Me.GroupBox2)
        Me.KDTab.Location = New System.Drawing.Point(4, 32)
        Me.KDTab.Name = "KDTab"
        Me.KDTab.Size = New System.Drawing.Size(1416, 744)
        Me.KDTab.TabIndex = 2
        Me.KDTab.Text = "Kundedatabase"
        Me.KDTab.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreHF)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreRbt)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.BtnKndEndre)
        Me.GroupBox3.Controls.Add(Me.BtnKndKundeID)
        Me.GroupBox3.Controls.Add(Me.TxtKndKundeID)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreEP)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreTlf)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreAdr)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreEN)
        Me.GroupBox3.Controls.Add(Me.TxtKndEndreFN)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(309, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 528)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Endre Kunde"
        '
        'TxtKndEndreHF
        '
        Me.TxtKndEndreHF.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreHF.Location = New System.Drawing.Point(123, 367)
        Me.TxtKndEndreHF.Name = "TxtKndEndreHF"
        Me.TxtKndEndreHF.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreHF.TabIndex = 27
        '
        'TxtKndEndreRbt
        '
        Me.TxtKndEndreRbt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreRbt.Location = New System.Drawing.Point(123, 324)
        Me.TxtKndEndreRbt.Name = "TxtKndEndreRbt"
        Me.TxtKndEndreRbt.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreRbt.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 370)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 18)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Handlet for:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Rabatt:"
        '
        'BtnKndEndre
        '
        Me.BtnKndEndre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKndEndre.Location = New System.Drawing.Point(123, 466)
        Me.BtnKndEndre.Name = "BtnKndEndre"
        Me.BtnKndEndre.Size = New System.Drawing.Size(162, 23)
        Me.BtnKndEndre.TabIndex = 23
        Me.BtnKndEndre.Text = "Endre Bruker"
        Me.BtnKndEndre.UseVisualStyleBackColor = True
        '
        'BtnKndKundeID
        '
        Me.BtnKndKundeID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKndKundeID.Location = New System.Drawing.Point(123, 73)
        Me.BtnKndKundeID.Name = "BtnKndKundeID"
        Me.BtnKndKundeID.Size = New System.Drawing.Size(55, 26)
        Me.BtnKndKundeID.TabIndex = 22
        Me.BtnKndKundeID.Text = "Gå!"
        Me.BtnKndKundeID.UseVisualStyleBackColor = True
        '
        'TxtKndKundeID
        '
        Me.TxtKndKundeID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndKundeID.Location = New System.Drawing.Point(123, 33)
        Me.TxtKndKundeID.Name = "TxtKndKundeID"
        Me.TxtKndKundeID.Size = New System.Drawing.Size(100, 26)
        Me.TxtKndKundeID.TabIndex = 21
        '
        'TxtKndEndreEP
        '
        Me.TxtKndEndreEP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreEP.Location = New System.Drawing.Point(123, 279)
        Me.TxtKndEndreEP.Name = "TxtKndEndreEP"
        Me.TxtKndEndreEP.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreEP.TabIndex = 17
        '
        'TxtKndEndreTlf
        '
        Me.TxtKndEndreTlf.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreTlf.Location = New System.Drawing.Point(123, 240)
        Me.TxtKndEndreTlf.Name = "TxtKndEndreTlf"
        Me.TxtKndEndreTlf.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreTlf.TabIndex = 16
        '
        'TxtKndEndreAdr
        '
        Me.TxtKndEndreAdr.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreAdr.Location = New System.Drawing.Point(123, 195)
        Me.TxtKndEndreAdr.Name = "TxtKndEndreAdr"
        Me.TxtKndEndreAdr.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreAdr.TabIndex = 15
        '
        'TxtKndEndreEN
        '
        Me.TxtKndEndreEN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreEN.Location = New System.Drawing.Point(123, 153)
        Me.TxtKndEndreEN.Name = "TxtKndEndreEN"
        Me.TxtKndEndreEN.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreEN.TabIndex = 14
        '
        'TxtKndEndreFN
        '
        Me.TxtKndEndreFN.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEndreFN.Location = New System.Drawing.Point(123, 114)
        Me.TxtKndEndreFN.Name = "TxtKndEndreFN"
        Me.TxtKndEndreFN.Size = New System.Drawing.Size(162, 26)
        Me.TxtKndEndreFN.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Epost:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 18)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Telefon:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 198)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 18)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Adresse:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 18)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Etternavn:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 18)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Fornavn"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 18)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Bruker ID:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DateKndFdato)
        Me.GroupBox4.Controls.Add(Me.LblKndFdato)
        Me.GroupBox4.Controls.Add(Me.BtnKndRegistrer)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.TxtKndEpost)
        Me.GroupBox4.Controls.Add(Me.TxtKndTlf)
        Me.GroupBox4.Controls.Add(Me.TxtKndAdresse)
        Me.GroupBox4.Controls.Add(Me.TxtKndEtternavn)
        Me.GroupBox4.Controls.Add(Me.TxtKndFornavn)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(301, 528)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ny Kunde"
        '
        'BtnKndRegistrer
        '
        Me.BtnKndRegistrer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKndRegistrer.Location = New System.Drawing.Point(123, 325)
        Me.BtnKndRegistrer.Name = "BtnKndRegistrer"
        Me.BtnKndRegistrer.Size = New System.Drawing.Size(172, 23)
        Me.BtnKndRegistrer.TabIndex = 23
        Me.BtnKndRegistrer.Text = "Opprett Kunde"
        Me.BtnKndRegistrer.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 36)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 18)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "xxxxxx"
        '
        'TxtKndEpost
        '
        Me.TxtKndEpost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEpost.Location = New System.Drawing.Point(123, 237)
        Me.TxtKndEpost.Name = "TxtKndEpost"
        Me.TxtKndEpost.Size = New System.Drawing.Size(172, 26)
        Me.TxtKndEpost.TabIndex = 17
        '
        'TxtKndTlf
        '
        Me.TxtKndTlf.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndTlf.Location = New System.Drawing.Point(123, 198)
        Me.TxtKndTlf.Name = "TxtKndTlf"
        Me.TxtKndTlf.Size = New System.Drawing.Size(172, 26)
        Me.TxtKndTlf.TabIndex = 16
        '
        'TxtKndAdresse
        '
        Me.TxtKndAdresse.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndAdresse.Location = New System.Drawing.Point(123, 153)
        Me.TxtKndAdresse.Name = "TxtKndAdresse"
        Me.TxtKndAdresse.Size = New System.Drawing.Size(172, 26)
        Me.TxtKndAdresse.TabIndex = 15
        '
        'TxtKndEtternavn
        '
        Me.TxtKndEtternavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndEtternavn.Location = New System.Drawing.Point(123, 111)
        Me.TxtKndEtternavn.Name = "TxtKndEtternavn"
        Me.TxtKndEtternavn.Size = New System.Drawing.Size(172, 26)
        Me.TxtKndEtternavn.TabIndex = 14
        '
        'TxtKndFornavn
        '
        Me.TxtKndFornavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndFornavn.Location = New System.Drawing.Point(123, 72)
        Me.TxtKndFornavn.Name = "TxtKndFornavn"
        Me.TxtKndFornavn.Size = New System.Drawing.Size(172, 26)
        Me.TxtKndFornavn.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(7, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 18)
        Me.Label16.TabIndex = 9
        Me.Label16.Text = "Epost:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 201)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 18)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Telefon:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 156)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 18)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Adresse:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 114)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 18)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Etternavn:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 75)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 18)
        Me.Label24.TabIndex = 1
        Me.Label24.Text = "Fornavn:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(69, 18)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Bruker ID:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LvKndSok)
        Me.GroupBox2.Controls.Add(Me.BtnKndSok)
        Me.GroupBox2.Controls.Add(Me.CmbKndSok)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtKndSok)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(616, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(613, 292)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kundesøk"
        '
        'LvKndSok
        '
        Me.LvKndSok.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
        Me.LvKndSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvKndSok.Location = New System.Drawing.Point(4, 128)
        Me.LvKndSok.Name = "LvKndSok"
        Me.LvKndSok.Size = New System.Drawing.Size(603, 158)
        Me.LvKndSok.TabIndex = 29
        Me.LvKndSok.UseCompatibleStateImageBehavior = False
        Me.LvKndSok.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Kunde ID"
        Me.ColumnHeader1.Width = 71
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Fornavn"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 76
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Etternavn"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 85
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Adresse"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 104
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Telefon"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Epost"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Rabatt"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Handlet for"
        Me.ColumnHeader8.Width = 84
        '
        'BtnKndSok
        '
        Me.BtnKndSok.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKndSok.Location = New System.Drawing.Point(252, 73)
        Me.BtnKndSok.Name = "BtnKndSok"
        Me.BtnKndSok.Size = New System.Drawing.Size(62, 23)
        Me.BtnKndSok.TabIndex = 28
        Me.BtnKndSok.Text = "Søk!"
        Me.BtnKndSok.UseVisualStyleBackColor = True
        '
        'CmbKndSok
        '
        Me.CmbKndSok.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbKndSok.FormattingEnabled = True
        Me.CmbKndSok.Items.AddRange(New Object() {"bruker_id", "fornavn", "etternavn", "avd_navn", "stilling", "timelonn", "stilling_prosent", "telefon", "epost", "admin"})
        Me.CmbKndSok.Location = New System.Drawing.Point(101, 72)
        Me.CmbKndSok.Name = "CmbKndSok"
        Me.CmbKndSok.Size = New System.Drawing.Size(121, 26)
        Me.CmbKndSok.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Søk etter:"
        '
        'TxtKndSok
        '
        Me.TxtKndSok.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKndSok.Location = New System.Drawing.Point(101, 33)
        Me.TxtKndSok.Name = "TxtKndSok"
        Me.TxtKndSok.Size = New System.Drawing.Size(191, 26)
        Me.TxtKndSok.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Søkefelt:"
        '
        'InventarTab
        '
        Me.InventarTab.Controls.Add(Me.GrpInvSok)
        Me.InventarTab.Controls.Add(Me.GrpInvRegistrerEndre)
        Me.InventarTab.Location = New System.Drawing.Point(4, 32)
        Me.InventarTab.Name = "InventarTab"
        Me.InventarTab.Size = New System.Drawing.Size(1416, 744)
        Me.InventarTab.TabIndex = 3
        Me.InventarTab.Text = "Inventar"
        Me.InventarTab.UseVisualStyleBackColor = True
        '
        'GrpInvSok
        '
        Me.GrpInvSok.Controls.Add(Me.LvInvSok)
        Me.GrpInvSok.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInvSok.Location = New System.Drawing.Point(377, 3)
        Me.GrpInvSok.Name = "GrpInvSok"
        Me.GrpInvSok.Size = New System.Drawing.Size(859, 622)
        Me.GrpInvSok.TabIndex = 0
        Me.GrpInvSok.TabStop = False
        Me.GrpInvSok.Text = "Søkeresultater"
        '
        'LvInvSok
        '
        Me.LvInvSok.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Produktnavn, Me.Varenummer, Me.Kategori, Me.Ramme, Me.Girsystem, Me.Hjulstørrelse, Me.Innkjøpspris, Me.Avdeling, Me.Forhandler, Me.Status, Me.Skadet, Me.Savnet})
        Me.LvInvSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvInvSok.Location = New System.Drawing.Point(6, 33)
        Me.LvInvSok.Name = "LvInvSok"
        Me.LvInvSok.Size = New System.Drawing.Size(847, 583)
        Me.LvInvSok.TabIndex = 0
        Me.LvInvSok.UseCompatibleStateImageBehavior = False
        Me.LvInvSok.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 42
        '
        'Produktnavn
        '
        Me.Produktnavn.Text = "Produktnavn"
        Me.Produktnavn.Width = 91
        '
        'Varenummer
        '
        Me.Varenummer.Text = "Varenr"
        Me.Varenummer.Width = 56
        '
        'Kategori
        '
        Me.Kategori.Text = "Kategori"
        Me.Kategori.Width = 78
        '
        'Ramme
        '
        Me.Ramme.Text = "Ramme"
        Me.Ramme.Width = 54
        '
        'Girsystem
        '
        Me.Girsystem.Text = "Girsystem"
        Me.Girsystem.Width = 69
        '
        'Hjulstørrelse
        '
        Me.Hjulstørrelse.Text = "Hjulstr."
        Me.Hjulstørrelse.Width = 50
        '
        'Innkjøpspris
        '
        Me.Innkjøpspris.Text = "Pris"
        Me.Innkjøpspris.Width = 49
        '
        'Avdeling
        '
        Me.Avdeling.Text = "Avdeling"
        Me.Avdeling.Width = 72
        '
        'Forhandler
        '
        Me.Forhandler.Text = "Forhandler"
        Me.Forhandler.Width = 86
        '
        'Status
        '
        Me.Status.Text = "Status"
        Me.Status.Width = 56
        '
        'Skadet
        '
        Me.Skadet.Text = "Skadet"
        Me.Skadet.Width = 51
        '
        'Savnet
        '
        Me.Savnet.Text = "Savnet"
        Me.Savnet.Width = 50
        '
        'GrpInvRegistrerEndre
        '
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvTest)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvAvbrytEndre)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvTom)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvAktivProdukt)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvSok)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvHentID)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvHentID)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvHent)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvEndre)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvSavnet)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvSkadet)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvStatus)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvStatus)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvSkadet)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvSavnet)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvSubkategori)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvSubkategori)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvGirsystem)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvHjulstorrelse)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvRamme)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvGirsystem)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvHjulstorrelse)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvRamme)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvAvdeling)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvKategori)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvInnkjopspris)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvRegistrer)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.CboInvForhandler)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvVareNummer)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.TxtInvProduktnavn)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvForhandler)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvInnkjopspris)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvVarenummer)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvProduktnavn)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvAvdeling)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvKategori)
        Me.GrpInvRegistrerEndre.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInvRegistrerEndre.Location = New System.Drawing.Point(3, 3)
        Me.GrpInvRegistrerEndre.Name = "GrpInvRegistrerEndre"
        Me.GrpInvRegistrerEndre.Size = New System.Drawing.Size(368, 622)
        Me.GrpInvRegistrerEndre.TabIndex = 0
        Me.GrpInvRegistrerEndre.TabStop = False
        Me.GrpInvRegistrerEndre.Text = "Registrer og Endre Inventar"
        '
        'BtnInvTest
        '
        Me.BtnInvTest.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvTest.Location = New System.Drawing.Point(277, 592)
        Me.BtnInvTest.Name = "BtnInvTest"
        Me.BtnInvTest.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvTest.TabIndex = 50
        Me.BtnInvTest.Text = "Test"
        '
        'BtnInvAvbrytEndre
        '
        Me.BtnInvAvbrytEndre.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvAvbrytEndre.Location = New System.Drawing.Point(242, 500)
        Me.BtnInvAvbrytEndre.Name = "BtnInvAvbrytEndre"
        Me.BtnInvAvbrytEndre.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvAvbrytEndre.TabIndex = 19
        Me.BtnInvAvbrytEndre.Text = "Avbryt"
        '
        'BtnInvTom
        '
        Me.BtnInvTom.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvTom.Location = New System.Drawing.Point(140, 500)
        Me.BtnInvTom.Name = "BtnInvTom"
        Me.BtnInvTom.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvTom.TabIndex = 18
        Me.BtnInvTom.Text = "Tøm felt"
        '
        'LblInvAktivProdukt
        '
        Me.LblInvAktivProdukt.AutoSize = True
        Me.LblInvAktivProdukt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvAktivProdukt.Location = New System.Drawing.Point(36, 593)
        Me.LblInvAktivProdukt.Name = "LblInvAktivProdukt"
        Me.LblInvAktivProdukt.Size = New System.Drawing.Size(139, 18)
        Me.LblInvAktivProdukt.TabIndex = 45
        Me.LblInvAktivProdukt.Text = "Ingen aktive produkt."
        '
        'BtnInvSok
        '
        Me.BtnInvSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvSok.Location = New System.Drawing.Point(39, 471)
        Me.BtnInvSok.Name = "BtnInvSok"
        Me.BtnInvSok.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvSok.TabIndex = 14
        Me.BtnInvSok.Text = "Søk"
        '
        'LblInvHentID
        '
        Me.LblInvHentID.AutoSize = True
        Me.LblInvHentID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvHentID.Location = New System.Drawing.Point(36, 549)
        Me.LblInvHentID.Name = "LblInvHentID"
        Me.LblInvHentID.Size = New System.Drawing.Size(141, 18)
        Me.LblInvHentID.TabIndex = 47
        Me.LblInvHentID.Text = "Hent produkt med ID:"
        '
        'TxtInvHentID
        '
        Me.TxtInvHentID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvHentID.Location = New System.Drawing.Point(183, 546)
        Me.TxtInvHentID.Name = "TxtInvHentID"
        Me.TxtInvHentID.Size = New System.Drawing.Size(84, 26)
        Me.TxtInvHentID.TabIndex = 20
        '
        'BtnInvHent
        '
        Me.BtnInvHent.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvHent.Location = New System.Drawing.Point(39, 500)
        Me.BtnInvHent.Name = "BtnInvHent"
        Me.BtnInvHent.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvHent.TabIndex = 17
        Me.BtnInvHent.Text = "Hent"
        Me.BtnInvHent.UseVisualStyleBackColor = True
        '
        'BtnInvEndre
        '
        Me.BtnInvEndre.Enabled = False
        Me.BtnInvEndre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvEndre.Location = New System.Drawing.Point(242, 470)
        Me.BtnInvEndre.Name = "BtnInvEndre"
        Me.BtnInvEndre.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvEndre.TabIndex = 16
        Me.BtnInvEndre.Text = "Endre"
        Me.BtnInvEndre.UseVisualStyleBackColor = True
        '
        'LblInvSavnet
        '
        Me.LblInvSavnet.AutoSize = True
        Me.LblInvSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSavnet.Location = New System.Drawing.Point(239, 390)
        Me.LblInvSavnet.Name = "LblInvSavnet"
        Me.LblInvSavnet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSavnet.TabIndex = 44
        Me.LblInvSavnet.Text = "Savnet:"
        '
        'LblInvSkadet
        '
        Me.LblInvSkadet.AutoSize = True
        Me.LblInvSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSkadet.Location = New System.Drawing.Point(239, 306)
        Me.LblInvSkadet.Name = "LblInvSkadet"
        Me.LblInvSkadet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSkadet.TabIndex = 43
        Me.LblInvSkadet.Text = "Skadet:"
        '
        'LblInvStatus
        '
        Me.LblInvStatus.AutoSize = True
        Me.LblInvStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvStatus.Location = New System.Drawing.Point(239, 222)
        Me.LblInvStatus.Name = "LblInvStatus"
        Me.LblInvStatus.Size = New System.Drawing.Size(50, 18)
        Me.LblInvStatus.TabIndex = 42
        Me.LblInvStatus.Text = "Status:"
        '
        'CboInvStatus
        '
        Me.CboInvStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvStatus.FormattingEnabled = True
        Me.CboInvStatus.Items.AddRange(New Object() {"Ledig", "Utleid", "Verksted"})
        Me.CboInvStatus.Location = New System.Drawing.Point(242, 243)
        Me.CboInvStatus.Name = "CboInvStatus"
        Me.CboInvStatus.Size = New System.Drawing.Size(121, 26)
        Me.CboInvStatus.TabIndex = 11
        '
        'CboInvSkadet
        '
        Me.CboInvSkadet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSkadet.FormattingEnabled = True
        Me.CboInvSkadet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSkadet.Location = New System.Drawing.Point(242, 327)
        Me.CboInvSkadet.Name = "CboInvSkadet"
        Me.CboInvSkadet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSkadet.TabIndex = 12
        '
        'CboInvSavnet
        '
        Me.CboInvSavnet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSavnet.FormattingEnabled = True
        Me.CboInvSavnet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSavnet.Location = New System.Drawing.Point(242, 411)
        Me.CboInvSavnet.Name = "CboInvSavnet"
        Me.CboInvSavnet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSavnet.TabIndex = 13
        '
        'CboInvSubkategori
        '
        Me.CboInvSubkategori.BackColor = System.Drawing.SystemColors.Window
        Me.CboInvSubkategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvSubkategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSubkategori.FormattingEnabled = True
        Me.CboInvSubkategori.Items.AddRange(New Object() {"Barnesykkel", "Bysykkel", "Downhill", "Elsykkel", "Racer", "Tandem", "Terrengsykkel"})
        Me.CboInvSubkategori.Location = New System.Drawing.Point(104, 75)
        Me.CboInvSubkategori.Name = "CboInvSubkategori"
        Me.CboInvSubkategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSubkategori.TabIndex = 2
        '
        'LblInvSubkategori
        '
        Me.LblInvSubkategori.AutoSize = True
        Me.LblInvSubkategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSubkategori.Location = New System.Drawing.Point(6, 78)
        Me.LblInvSubkategori.Name = "LblInvSubkategori"
        Me.LblInvSubkategori.Size = New System.Drawing.Size(86, 18)
        Me.LblInvSubkategori.TabIndex = 37
        Me.LblInvSubkategori.Text = "Subkategori:"
        '
        'TxtInvGirsystem
        '
        Me.TxtInvGirsystem.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvGirsystem.Location = New System.Drawing.Point(104, 369)
        Me.TxtInvGirsystem.Name = "TxtInvGirsystem"
        Me.TxtInvGirsystem.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvGirsystem.TabIndex = 9
        '
        'TxtInvHjulstorrelse
        '
        Me.TxtInvHjulstorrelse.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvHjulstorrelse.Location = New System.Drawing.Point(104, 327)
        Me.TxtInvHjulstorrelse.Name = "TxtInvHjulstorrelse"
        Me.TxtInvHjulstorrelse.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvHjulstorrelse.TabIndex = 8
        '
        'TxtInvRamme
        '
        Me.TxtInvRamme.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvRamme.Location = New System.Drawing.Point(104, 285)
        Me.TxtInvRamme.Name = "TxtInvRamme"
        Me.TxtInvRamme.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvRamme.TabIndex = 7
        '
        'LblInvGirsystem
        '
        Me.LblInvGirsystem.AutoSize = True
        Me.LblInvGirsystem.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvGirsystem.Location = New System.Drawing.Point(6, 372)
        Me.LblInvGirsystem.Name = "LblInvGirsystem"
        Me.LblInvGirsystem.Size = New System.Drawing.Size(74, 18)
        Me.LblInvGirsystem.TabIndex = 29
        Me.LblInvGirsystem.Text = "Girsystem:"
        '
        'LblInvHjulstorrelse
        '
        Me.LblInvHjulstorrelse.AutoSize = True
        Me.LblInvHjulstorrelse.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvHjulstorrelse.Location = New System.Drawing.Point(6, 330)
        Me.LblInvHjulstorrelse.Name = "LblInvHjulstorrelse"
        Me.LblInvHjulstorrelse.Size = New System.Drawing.Size(88, 18)
        Me.LblInvHjulstorrelse.TabIndex = 28
        Me.LblInvHjulstorrelse.Text = "Hjulstørrelse"
        '
        'LblInvRamme
        '
        Me.LblInvRamme.AutoSize = True
        Me.LblInvRamme.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvRamme.Location = New System.Drawing.Point(6, 288)
        Me.LblInvRamme.Name = "LblInvRamme"
        Me.LblInvRamme.Size = New System.Drawing.Size(59, 18)
        Me.LblInvRamme.TabIndex = 27
        Me.LblInvRamme.Text = "Ramme:"
        '
        'CboInvAvdeling
        '
        Me.CboInvAvdeling.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvAvdeling.FormattingEnabled = True
        Me.CboInvAvdeling.Items.AddRange(New Object() {"Finse", "Flåm", "Haugastøl", "Myrdal", "Voss"})
        Me.CboInvAvdeling.Location = New System.Drawing.Point(104, 117)
        Me.CboInvAvdeling.Name = "CboInvAvdeling"
        Me.CboInvAvdeling.Size = New System.Drawing.Size(121, 26)
        Me.CboInvAvdeling.TabIndex = 3
        '
        'CboInvKategori
        '
        Me.CboInvKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvKategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvKategori.FormattingEnabled = True
        Me.CboInvKategori.Items.AddRange(New Object() {"Sykkel", "Utstyr"})
        Me.CboInvKategori.Location = New System.Drawing.Point(104, 33)
        Me.CboInvKategori.Name = "CboInvKategori"
        Me.CboInvKategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvKategori.TabIndex = 1
        '
        'TxtInvInnkjopspris
        '
        Me.TxtInvInnkjopspris.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvInnkjopspris.Location = New System.Drawing.Point(104, 243)
        Me.TxtInvInnkjopspris.Name = "TxtInvInnkjopspris"
        Me.TxtInvInnkjopspris.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvInnkjopspris.TabIndex = 6
        '
        'BtnInvRegistrer
        '
        Me.BtnInvRegistrer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvRegistrer.Location = New System.Drawing.Point(140, 470)
        Me.BtnInvRegistrer.Name = "BtnInvRegistrer"
        Me.BtnInvRegistrer.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvRegistrer.TabIndex = 15
        Me.BtnInvRegistrer.Text = "Registrer"
        Me.BtnInvRegistrer.UseVisualStyleBackColor = True
        '
        'CboInvForhandler
        '
        Me.CboInvForhandler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboInvForhandler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvForhandler.FormattingEnabled = True
        Me.CboInvForhandler.Items.AddRange(New Object() {"Stians Sport AS", "Svendsens sykler AS"})
        Me.CboInvForhandler.Location = New System.Drawing.Point(104, 411)
        Me.CboInvForhandler.Name = "CboInvForhandler"
        Me.CboInvForhandler.Size = New System.Drawing.Size(121, 26)
        Me.CboInvForhandler.TabIndex = 10
        '
        'TxtInvVareNummer
        '
        Me.TxtInvVareNummer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvVareNummer.Location = New System.Drawing.Point(104, 201)
        Me.TxtInvVareNummer.Name = "TxtInvVareNummer"
        Me.TxtInvVareNummer.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvVareNummer.TabIndex = 5
        '
        'TxtInvProduktnavn
        '
        Me.TxtInvProduktnavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvProduktnavn.Location = New System.Drawing.Point(104, 159)
        Me.TxtInvProduktnavn.Name = "TxtInvProduktnavn"
        Me.TxtInvProduktnavn.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvProduktnavn.TabIndex = 4
        '
        'LblInvForhandler
        '
        Me.LblInvForhandler.AutoSize = True
        Me.LblInvForhandler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvForhandler.Location = New System.Drawing.Point(6, 414)
        Me.LblInvForhandler.Name = "LblInvForhandler"
        Me.LblInvForhandler.Size = New System.Drawing.Size(80, 18)
        Me.LblInvForhandler.TabIndex = 8
        Me.LblInvForhandler.Text = "Forhandler:"
        '
        'LblInvInnkjopspris
        '
        Me.LblInvInnkjopspris.AutoSize = True
        Me.LblInvInnkjopspris.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvInnkjopspris.Location = New System.Drawing.Point(6, 246)
        Me.LblInvInnkjopspris.Name = "LblInvInnkjopspris"
        Me.LblInvInnkjopspris.Size = New System.Drawing.Size(88, 18)
        Me.LblInvInnkjopspris.TabIndex = 6
        Me.LblInvInnkjopspris.Text = "Innkjøpspris:"
        '
        'LblInvVarenummer
        '
        Me.LblInvVarenummer.AutoSize = True
        Me.LblInvVarenummer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvVarenummer.Location = New System.Drawing.Point(6, 204)
        Me.LblInvVarenummer.Name = "LblInvVarenummer"
        Me.LblInvVarenummer.Size = New System.Drawing.Size(93, 18)
        Me.LblInvVarenummer.TabIndex = 5
        Me.LblInvVarenummer.Text = "Varenummer:"
        '
        'LblInvProduktnavn
        '
        Me.LblInvProduktnavn.AutoSize = True
        Me.LblInvProduktnavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvProduktnavn.Location = New System.Drawing.Point(6, 162)
        Me.LblInvProduktnavn.Name = "LblInvProduktnavn"
        Me.LblInvProduktnavn.Size = New System.Drawing.Size(91, 18)
        Me.LblInvProduktnavn.TabIndex = 4
        Me.LblInvProduktnavn.Text = "Produktnavn:"
        '
        'LblInvAvdeling
        '
        Me.LblInvAvdeling.AutoSize = True
        Me.LblInvAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvAvdeling.Location = New System.Drawing.Point(6, 120)
        Me.LblInvAvdeling.Name = "LblInvAvdeling"
        Me.LblInvAvdeling.Size = New System.Drawing.Size(67, 18)
        Me.LblInvAvdeling.TabIndex = 3
        Me.LblInvAvdeling.Text = "Avdeling:"
        '
        'LblInvKategori
        '
        Me.LblInvKategori.AutoSize = True
        Me.LblInvKategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvKategori.Location = New System.Drawing.Point(6, 36)
        Me.LblInvKategori.Name = "LblInvKategori"
        Me.LblInvKategori.Size = New System.Drawing.Size(64, 18)
        Me.LblInvKategori.TabIndex = 1
        Me.LblInvKategori.Text = "Kategori:"
        '
        'ISTab
        '
        Me.ISTab.Location = New System.Drawing.Point(4, 32)
        Me.ISTab.Name = "ISTab"
        Me.ISTab.Size = New System.Drawing.Size(1416, 744)
        Me.ISTab.TabIndex = 4
        Me.ISTab.Text = "Inventar Søk"
        Me.ISTab.UseVisualStyleBackColor = True
        '
        'LogiTab
        '
        Me.LogiTab.Location = New System.Drawing.Point(4, 32)
        Me.LogiTab.Name = "LogiTab"
        Me.LogiTab.Size = New System.Drawing.Size(1416, 744)
        Me.LogiTab.TabIndex = 5
        Me.LogiTab.Text = "Logistikk"
        Me.LogiTab.UseVisualStyleBackColor = True
        '
        'StatTab
        '
        Me.StatTab.Location = New System.Drawing.Point(4, 32)
        Me.StatTab.Name = "StatTab"
        Me.StatTab.Size = New System.Drawing.Size(1416, 744)
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
        Me.AdminTab.Size = New System.Drawing.Size(1416, 744)
        Me.AdminTab.TabIndex = 7
        Me.AdminTab.Text = "Admin"
        Me.AdminTab.UseVisualStyleBackColor = True
        '
        'AdminMOTDGroup
        '
        Me.AdminMOTDGroup.Controls.Add(Me.AdminMOTDEndreB)
        Me.AdminMOTDGroup.Controls.Add(Me.TxtAdminMOTD)
        Me.AdminMOTDGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminMOTDGroup.Location = New System.Drawing.Point(626, 310)
        Me.AdminMOTDGroup.Name = "AdminMOTDGroup"
        Me.AdminMOTDGroup.Size = New System.Drawing.Size(347, 221)
        Me.AdminMOTDGroup.TabIndex = 24
        Me.AdminMOTDGroup.TabStop = False
        Me.AdminMOTDGroup.Text = "MOTD"
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
        'TxtAdminMOTD
        '
        Me.TxtAdminMOTD.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminMOTD.Location = New System.Drawing.Point(9, 31)
        Me.TxtAdminMOTD.Multiline = True
        Me.TxtAdminMOTD.Name = "TxtAdminMOTD"
        Me.TxtAdminMOTD.Size = New System.Drawing.Size(321, 128)
        Me.TxtAdminMOTD.TabIndex = 0
        '
        'AdminBrukerSokGroup
        '
        Me.AdminBrukerSokGroup.Controls.Add(Me.LvAdminBS)
        Me.AdminBrukerSokGroup.Controls.Add(Me.AdminBSSokB)
        Me.AdminBrukerSokGroup.Controls.Add(Me.CboAdminBSEtter)
        Me.AdminBrukerSokGroup.Controls.Add(Me.LblAdminBSEtter)
        Me.AdminBrukerSokGroup.Controls.Add(Me.TxtAdminBSFelt)
        Me.AdminBrukerSokGroup.Controls.Add(Me.LblAdminBSFelt)
        Me.AdminBrukerSokGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminBrukerSokGroup.Location = New System.Drawing.Point(626, 3)
        Me.AdminBrukerSokGroup.Name = "AdminBrukerSokGroup"
        Me.AdminBrukerSokGroup.Size = New System.Drawing.Size(347, 300)
        Me.AdminBrukerSokGroup.TabIndex = 23
        Me.AdminBrukerSokGroup.TabStop = False
        Me.AdminBrukerSokGroup.Text = "Brukersøk"
        '
        'LvAdminBS
        '
        Me.LvAdminBS.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.LvAdminBID, Me.LVAdminFornavn, Me.LVAdminEtternavn, Me.LVAdminSoekefelt})
        Me.LvAdminBS.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LvAdminBS.Location = New System.Drawing.Point(9, 114)
        Me.LvAdminBS.Name = "LvAdminBS"
        Me.LvAdminBS.Size = New System.Drawing.Size(332, 158)
        Me.LvAdminBS.TabIndex = 29
        Me.LvAdminBS.UseCompatibleStateImageBehavior = False
        Me.LvAdminBS.View = System.Windows.Forms.View.Details
        '
        'LvAdminBID
        '
        Me.LvAdminBID.Text = "Bruk. ID"
        '
        'LVAdminFornavn
        '
        Me.LVAdminFornavn.Text = "Fornavn"
        Me.LVAdminFornavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LVAdminFornavn.Width = 76
        '
        'LVAdminEtternavn
        '
        Me.LVAdminEtternavn.Text = "Etternavn"
        Me.LVAdminEtternavn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LVAdminEtternavn.Width = 85
        '
        'LVAdminSoekefelt
        '
        Me.LVAdminSoekefelt.Text = "Søkefelt"
        Me.LVAdminSoekefelt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.LVAdminSoekefelt.Width = 104
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
        'CboAdminBSEtter
        '
        Me.CboAdminBSEtter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminBSEtter.FormattingEnabled = True
        Me.CboAdminBSEtter.Items.AddRange(New Object() {"bruker_id", "fornavn", "etternavn", "avd_navn", "stilling", "timelonn", "stilling_prosent", "telefon", "epost", "admin"})
        Me.CboAdminBSEtter.Location = New System.Drawing.Point(101, 72)
        Me.CboAdminBSEtter.Name = "CboAdminBSEtter"
        Me.CboAdminBSEtter.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminBSEtter.TabIndex = 26
        '
        'LblAdminBSEtter
        '
        Me.LblAdminBSEtter.AutoSize = True
        Me.LblAdminBSEtter.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminBSEtter.Location = New System.Drawing.Point(6, 75)
        Me.LblAdminBSEtter.Name = "LblAdminBSEtter"
        Me.LblAdminBSEtter.Size = New System.Drawing.Size(68, 18)
        Me.LblAdminBSEtter.TabIndex = 23
        Me.LblAdminBSEtter.Text = "Søk etter:"
        '
        'TxtAdminBSFelt
        '
        Me.TxtAdminBSFelt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminBSFelt.Location = New System.Drawing.Point(101, 33)
        Me.TxtAdminBSFelt.Name = "TxtAdminBSFelt"
        Me.TxtAdminBSFelt.Size = New System.Drawing.Size(191, 26)
        Me.TxtAdminBSFelt.TabIndex = 22
        '
        'LblAdminBSFelt
        '
        Me.LblAdminBSFelt.AutoSize = True
        Me.LblAdminBSFelt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminBSFelt.Location = New System.Drawing.Point(6, 36)
        Me.LblAdminBSFelt.Name = "LblAdminBSFelt"
        Me.LblAdminBSFelt.Size = New System.Drawing.Size(64, 18)
        Me.LblAdminBSFelt.TabIndex = 1
        Me.LblAdminBSFelt.Text = "Søkefelt:"
        '
        'AdminEndreBrukerGroup
        '
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBTime)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBEndreB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.AdminEBLastInnB)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBBID)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.CboAdminEBSP)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.CboAdminEBStilling)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.CboAdminEBAvdeling)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBEpost)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBTelefon)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBEtternavn)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBFornavn)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.TxtAdminEBPassord)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.ChkAdminEBTime)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.ChkAdminEBAdmin)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBAdmin)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBEpost)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBSP)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBTelefon)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBTime)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBStilling)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBAvdeling)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBEtternavn)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBFornavn)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBPassord)
        Me.AdminEndreBrukerGroup.Controls.Add(Me.LblAdminEBBID)
        Me.AdminEndreBrukerGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminEndreBrukerGroup.Location = New System.Drawing.Point(310, 3)
        Me.AdminEndreBrukerGroup.Name = "AdminEndreBrukerGroup"
        Me.AdminEndreBrukerGroup.Size = New System.Drawing.Size(301, 528)
        Me.AdminEndreBrukerGroup.TabIndex = 22
        Me.AdminEndreBrukerGroup.TabStop = False
        Me.AdminEndreBrukerGroup.Text = "Endre Bruker"
        '
        'TxtAdminEBTime
        '
        Me.TxtAdminEBTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBTime.Location = New System.Drawing.Point(166, 279)
        Me.TxtAdminEBTime.Name = "TxtAdminEBTime"
        Me.TxtAdminEBTime.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBTime.TabIndex = 25
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
        'TxtAdminEBBID
        '
        Me.TxtAdminEBBID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBBID.Location = New System.Drawing.Point(123, 33)
        Me.TxtAdminEBBID.Name = "TxtAdminEBBID"
        Me.TxtAdminEBBID.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBBID.TabIndex = 21
        '
        'CboAdminEBSP
        '
        Me.CboAdminEBSP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminEBSP.FormattingEnabled = True
        Me.CboAdminEBSP.Items.AddRange(New Object() {"30", "40", "50", "60", "70", "80", "90", "100"})
        Me.CboAdminEBSP.Location = New System.Drawing.Point(123, 320)
        Me.CboAdminEBSP.Name = "CboAdminEBSP"
        Me.CboAdminEBSP.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminEBSP.TabIndex = 20
        '
        'CboAdminEBStilling
        '
        Me.CboAdminEBStilling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminEBStilling.FormattingEnabled = True
        Me.CboAdminEBStilling.Items.AddRange(New Object() {"Butikkmedarbeider", "King Kong"})
        Me.CboAdminEBStilling.Location = New System.Drawing.Point(123, 237)
        Me.CboAdminEBStilling.Name = "CboAdminEBStilling"
        Me.CboAdminEBStilling.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminEBStilling.TabIndex = 19
        '
        'CboAdminEBAvdeling
        '
        Me.CboAdminEBAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminEBAvdeling.FormattingEnabled = True
        Me.CboAdminEBAvdeling.Location = New System.Drawing.Point(123, 195)
        Me.CboAdminEBAvdeling.Name = "CboAdminEBAvdeling"
        Me.CboAdminEBAvdeling.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminEBAvdeling.TabIndex = 18
        '
        'TxtAdminEBEpost
        '
        Me.TxtAdminEBEpost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBEpost.Location = New System.Drawing.Point(123, 402)
        Me.TxtAdminEBEpost.Name = "TxtAdminEBEpost"
        Me.TxtAdminEBEpost.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBEpost.TabIndex = 17
        '
        'TxtAdminEBTelefon
        '
        Me.TxtAdminEBTelefon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBTelefon.Location = New System.Drawing.Point(123, 363)
        Me.TxtAdminEBTelefon.Name = "TxtAdminEBTelefon"
        Me.TxtAdminEBTelefon.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBTelefon.TabIndex = 16
        '
        'TxtAdminEBEtternavn
        '
        Me.TxtAdminEBEtternavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBEtternavn.Location = New System.Drawing.Point(123, 153)
        Me.TxtAdminEBEtternavn.Name = "TxtAdminEBEtternavn"
        Me.TxtAdminEBEtternavn.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBEtternavn.TabIndex = 15
        '
        'TxtAdminEBFornavn
        '
        Me.TxtAdminEBFornavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBFornavn.Location = New System.Drawing.Point(123, 111)
        Me.TxtAdminEBFornavn.Name = "TxtAdminEBFornavn"
        Me.TxtAdminEBFornavn.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBFornavn.TabIndex = 14
        '
        'TxtAdminEBPassord
        '
        Me.TxtAdminEBPassord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminEBPassord.Location = New System.Drawing.Point(123, 72)
        Me.TxtAdminEBPassord.Name = "TxtAdminEBPassord"
        Me.TxtAdminEBPassord.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminEBPassord.TabIndex = 13
        '
        'ChkAdminEBTime
        '
        Me.ChkAdminEBTime.AutoSize = True
        Me.ChkAdminEBTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdminEBTime.Location = New System.Drawing.Point(123, 282)
        Me.ChkAdminEBTime.Name = "ChkAdminEBTime"
        Me.ChkAdminEBTime.Size = New System.Drawing.Size(39, 22)
        Me.ChkAdminEBTime.TabIndex = 12
        Me.ChkAdminEBTime.Text = "Ja"
        Me.ChkAdminEBTime.UseVisualStyleBackColor = True
        '
        'ChkAdminEBAdmin
        '
        Me.ChkAdminEBAdmin.AutoSize = True
        Me.ChkAdminEBAdmin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdminEBAdmin.Location = New System.Drawing.Point(123, 444)
        Me.ChkAdminEBAdmin.Name = "ChkAdminEBAdmin"
        Me.ChkAdminEBAdmin.Size = New System.Drawing.Size(39, 22)
        Me.ChkAdminEBAdmin.TabIndex = 11
        Me.ChkAdminEBAdmin.Text = "Ja"
        Me.ChkAdminEBAdmin.UseVisualStyleBackColor = True
        '
        'LblAdminEBAdmin
        '
        Me.LblAdminEBAdmin.AutoSize = True
        Me.LblAdminEBAdmin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBAdmin.Location = New System.Drawing.Point(7, 445)
        Me.LblAdminEBAdmin.Name = "LblAdminEBAdmin"
        Me.LblAdminEBAdmin.Size = New System.Drawing.Size(53, 18)
        Me.LblAdminEBAdmin.TabIndex = 10
        Me.LblAdminEBAdmin.Text = "Admin:"
        '
        'LblAdminEBEpost
        '
        Me.LblAdminEBEpost.AutoSize = True
        Me.LblAdminEBEpost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBEpost.Location = New System.Drawing.Point(7, 405)
        Me.LblAdminEBEpost.Name = "LblAdminEBEpost"
        Me.LblAdminEBEpost.Size = New System.Drawing.Size(46, 18)
        Me.LblAdminEBEpost.TabIndex = 9
        Me.LblAdminEBEpost.Text = "Epost:"
        '
        'LblAdminEBSP
        '
        Me.LblAdminEBSP.AutoSize = True
        Me.LblAdminEBSP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBSP.Location = New System.Drawing.Point(6, 323)
        Me.LblAdminEBSP.Name = "LblAdminEBSP"
        Me.LblAdminEBSP.Size = New System.Drawing.Size(108, 18)
        Me.LblAdminEBSP.TabIndex = 8
        Me.LblAdminEBSP.Text = "Stillingsprosent:"
        '
        'LblAdminEBTelefon
        '
        Me.LblAdminEBTelefon.AutoSize = True
        Me.LblAdminEBTelefon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBTelefon.Location = New System.Drawing.Point(7, 366)
        Me.LblAdminEBTelefon.Name = "LblAdminEBTelefon"
        Me.LblAdminEBTelefon.Size = New System.Drawing.Size(59, 18)
        Me.LblAdminEBTelefon.TabIndex = 7
        Me.LblAdminEBTelefon.Text = "Telefon:"
        '
        'LblAdminEBTime
        '
        Me.LblAdminEBTime.AutoSize = True
        Me.LblAdminEBTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBTime.Location = New System.Drawing.Point(6, 282)
        Me.LblAdminEBTime.Name = "LblAdminEBTime"
        Me.LblAdminEBTime.Size = New System.Drawing.Size(71, 18)
        Me.LblAdminEBTime.TabIndex = 6
        Me.LblAdminEBTime.Text = "Timelønn:"
        '
        'LblAdminEBStilling
        '
        Me.LblAdminEBStilling.AutoSize = True
        Me.LblAdminEBStilling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBStilling.Location = New System.Drawing.Point(6, 240)
        Me.LblAdminEBStilling.Name = "LblAdminEBStilling"
        Me.LblAdminEBStilling.Size = New System.Drawing.Size(54, 18)
        Me.LblAdminEBStilling.TabIndex = 5
        Me.LblAdminEBStilling.Text = "Stilling:"
        '
        'LblAdminEBAvdeling
        '
        Me.LblAdminEBAvdeling.AutoSize = True
        Me.LblAdminEBAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBAvdeling.Location = New System.Drawing.Point(6, 198)
        Me.LblAdminEBAvdeling.Name = "LblAdminEBAvdeling"
        Me.LblAdminEBAvdeling.Size = New System.Drawing.Size(67, 18)
        Me.LblAdminEBAvdeling.TabIndex = 4
        Me.LblAdminEBAvdeling.Text = "Avdeling:"
        '
        'LblAdminEBEtternavn
        '
        Me.LblAdminEBEtternavn.AutoSize = True
        Me.LblAdminEBEtternavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBEtternavn.Location = New System.Drawing.Point(6, 156)
        Me.LblAdminEBEtternavn.Name = "LblAdminEBEtternavn"
        Me.LblAdminEBEtternavn.Size = New System.Drawing.Size(72, 18)
        Me.LblAdminEBEtternavn.TabIndex = 3
        Me.LblAdminEBEtternavn.Text = "Etternavn:"
        '
        'LblAdminEBFornavn
        '
        Me.LblAdminEBFornavn.AutoSize = True
        Me.LblAdminEBFornavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBFornavn.Location = New System.Drawing.Point(6, 114)
        Me.LblAdminEBFornavn.Name = "LblAdminEBFornavn"
        Me.LblAdminEBFornavn.Size = New System.Drawing.Size(62, 18)
        Me.LblAdminEBFornavn.TabIndex = 2
        Me.LblAdminEBFornavn.Text = "Fornavn:"
        '
        'LblAdminEBPassord
        '
        Me.LblAdminEBPassord.AutoSize = True
        Me.LblAdminEBPassord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBPassord.Location = New System.Drawing.Point(6, 75)
        Me.LblAdminEBPassord.Name = "LblAdminEBPassord"
        Me.LblAdminEBPassord.Size = New System.Drawing.Size(60, 18)
        Me.LblAdminEBPassord.TabIndex = 1
        Me.LblAdminEBPassord.Text = "Passord:"
        '
        'LblAdminEBBID
        '
        Me.LblAdminEBBID.AutoSize = True
        Me.LblAdminEBBID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminEBBID.Location = New System.Drawing.Point(6, 36)
        Me.LblAdminEBBID.Name = "LblAdminEBBID"
        Me.LblAdminEBBID.Size = New System.Drawing.Size(69, 18)
        Me.LblAdminEBBID.TabIndex = 0
        Me.LblAdminEBBID.Text = "Bruker ID:"
        '
        'AdminNyBrukerGroup
        '
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBTime)
        Me.AdminNyBrukerGroup.Controls.Add(Me.AdminNBOpprettB)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblBrukerIDNBVis)
        Me.AdminNyBrukerGroup.Controls.Add(Me.CboAdminNBSP)
        Me.AdminNyBrukerGroup.Controls.Add(Me.CboAdminNBStilling)
        Me.AdminNyBrukerGroup.Controls.Add(Me.CboAdminNBAvdeling)
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBEpost)
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBTelefon)
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBEtternavn)
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBFornavn)
        Me.AdminNyBrukerGroup.Controls.Add(Me.TxtAdminNBPassord)
        Me.AdminNyBrukerGroup.Controls.Add(Me.ChkAdminNBTime)
        Me.AdminNyBrukerGroup.Controls.Add(Me.ChkAdminNBAdmin)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBAdmin)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBEpost)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBSP)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBTelefon)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBTimelonn)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBStilling)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBAvdeling)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBEtternavn)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBFornavn)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBPassord)
        Me.AdminNyBrukerGroup.Controls.Add(Me.LblAdminNBBID)
        Me.AdminNyBrukerGroup.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminNyBrukerGroup.Location = New System.Drawing.Point(3, 3)
        Me.AdminNyBrukerGroup.Name = "AdminNyBrukerGroup"
        Me.AdminNyBrukerGroup.Size = New System.Drawing.Size(301, 528)
        Me.AdminNyBrukerGroup.TabIndex = 0
        Me.AdminNyBrukerGroup.TabStop = False
        Me.AdminNyBrukerGroup.Text = "Ny Bruker"
        '
        'TxtAdminNBTime
        '
        Me.TxtAdminNBTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBTime.Location = New System.Drawing.Point(168, 279)
        Me.TxtAdminNBTime.Name = "TxtAdminNBTime"
        Me.TxtAdminNBTime.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBTime.TabIndex = 24
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
        'LblBrukerIDNBVis
        '
        Me.LblBrukerIDNBVis.AutoSize = True
        Me.LblBrukerIDNBVis.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBrukerIDNBVis.Location = New System.Drawing.Point(120, 36)
        Me.LblBrukerIDNBVis.Name = "LblBrukerIDNBVis"
        Me.LblBrukerIDNBVis.Size = New System.Drawing.Size(50, 18)
        Me.LblBrukerIDNBVis.TabIndex = 21
        Me.LblBrukerIDNBVis.Text = "xxxxxx"
        '
        'CboAdminNBSP
        '
        Me.CboAdminNBSP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminNBSP.FormattingEnabled = True
        Me.CboAdminNBSP.Items.AddRange(New Object() {"30", "40", "50", "60", "70", "80", "90", "100"})
        Me.CboAdminNBSP.Location = New System.Drawing.Point(123, 320)
        Me.CboAdminNBSP.Name = "CboAdminNBSP"
        Me.CboAdminNBSP.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminNBSP.TabIndex = 20
        '
        'CboAdminNBStilling
        '
        Me.CboAdminNBStilling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminNBStilling.FormattingEnabled = True
        Me.CboAdminNBStilling.Items.AddRange(New Object() {"Butikkmedarbeider", "King Kong"})
        Me.CboAdminNBStilling.Location = New System.Drawing.Point(123, 237)
        Me.CboAdminNBStilling.Name = "CboAdminNBStilling"
        Me.CboAdminNBStilling.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminNBStilling.TabIndex = 19
        '
        'CboAdminNBAvdeling
        '
        Me.CboAdminNBAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboAdminNBAvdeling.FormattingEnabled = True
        Me.CboAdminNBAvdeling.Location = New System.Drawing.Point(123, 195)
        Me.CboAdminNBAvdeling.Name = "CboAdminNBAvdeling"
        Me.CboAdminNBAvdeling.Size = New System.Drawing.Size(121, 26)
        Me.CboAdminNBAvdeling.TabIndex = 18
        '
        'TxtAdminNBEpost
        '
        Me.TxtAdminNBEpost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBEpost.Location = New System.Drawing.Point(123, 402)
        Me.TxtAdminNBEpost.Name = "TxtAdminNBEpost"
        Me.TxtAdminNBEpost.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBEpost.TabIndex = 17
        '
        'TxtAdminNBTelefon
        '
        Me.TxtAdminNBTelefon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBTelefon.Location = New System.Drawing.Point(123, 363)
        Me.TxtAdminNBTelefon.Name = "TxtAdminNBTelefon"
        Me.TxtAdminNBTelefon.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBTelefon.TabIndex = 16
        '
        'TxtAdminNBEtternavn
        '
        Me.TxtAdminNBEtternavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBEtternavn.Location = New System.Drawing.Point(123, 153)
        Me.TxtAdminNBEtternavn.Name = "TxtAdminNBEtternavn"
        Me.TxtAdminNBEtternavn.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBEtternavn.TabIndex = 15
        '
        'TxtAdminNBFornavn
        '
        Me.TxtAdminNBFornavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBFornavn.Location = New System.Drawing.Point(123, 111)
        Me.TxtAdminNBFornavn.Name = "TxtAdminNBFornavn"
        Me.TxtAdminNBFornavn.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBFornavn.TabIndex = 14
        '
        'TxtAdminNBPassord
        '
        Me.TxtAdminNBPassord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminNBPassord.Location = New System.Drawing.Point(123, 72)
        Me.TxtAdminNBPassord.Name = "TxtAdminNBPassord"
        Me.TxtAdminNBPassord.Size = New System.Drawing.Size(100, 26)
        Me.TxtAdminNBPassord.TabIndex = 13
        '
        'ChkAdminNBTime
        '
        Me.ChkAdminNBTime.AutoSize = True
        Me.ChkAdminNBTime.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdminNBTime.Location = New System.Drawing.Point(123, 282)
        Me.ChkAdminNBTime.Name = "ChkAdminNBTime"
        Me.ChkAdminNBTime.Size = New System.Drawing.Size(39, 22)
        Me.ChkAdminNBTime.TabIndex = 12
        Me.ChkAdminNBTime.Text = "Ja"
        Me.ChkAdminNBTime.UseVisualStyleBackColor = True
        '
        'ChkAdminNBAdmin
        '
        Me.ChkAdminNBAdmin.AutoSize = True
        Me.ChkAdminNBAdmin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAdminNBAdmin.Location = New System.Drawing.Point(123, 444)
        Me.ChkAdminNBAdmin.Name = "ChkAdminNBAdmin"
        Me.ChkAdminNBAdmin.Size = New System.Drawing.Size(39, 22)
        Me.ChkAdminNBAdmin.TabIndex = 11
        Me.ChkAdminNBAdmin.Text = "Ja"
        Me.ChkAdminNBAdmin.UseVisualStyleBackColor = True
        '
        'LblAdminNBAdmin
        '
        Me.LblAdminNBAdmin.AutoSize = True
        Me.LblAdminNBAdmin.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBAdmin.Location = New System.Drawing.Point(7, 445)
        Me.LblAdminNBAdmin.Name = "LblAdminNBAdmin"
        Me.LblAdminNBAdmin.Size = New System.Drawing.Size(53, 18)
        Me.LblAdminNBAdmin.TabIndex = 10
        Me.LblAdminNBAdmin.Text = "Admin:"
        '
        'LblAdminNBEpost
        '
        Me.LblAdminNBEpost.AutoSize = True
        Me.LblAdminNBEpost.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBEpost.Location = New System.Drawing.Point(7, 405)
        Me.LblAdminNBEpost.Name = "LblAdminNBEpost"
        Me.LblAdminNBEpost.Size = New System.Drawing.Size(46, 18)
        Me.LblAdminNBEpost.TabIndex = 9
        Me.LblAdminNBEpost.Text = "Epost:"
        '
        'LblAdminNBSP
        '
        Me.LblAdminNBSP.AutoSize = True
        Me.LblAdminNBSP.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBSP.Location = New System.Drawing.Point(6, 323)
        Me.LblAdminNBSP.Name = "LblAdminNBSP"
        Me.LblAdminNBSP.Size = New System.Drawing.Size(108, 18)
        Me.LblAdminNBSP.TabIndex = 8
        Me.LblAdminNBSP.Text = "Stillingsprosent:"
        '
        'LblAdminNBTelefon
        '
        Me.LblAdminNBTelefon.AutoSize = True
        Me.LblAdminNBTelefon.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBTelefon.Location = New System.Drawing.Point(7, 366)
        Me.LblAdminNBTelefon.Name = "LblAdminNBTelefon"
        Me.LblAdminNBTelefon.Size = New System.Drawing.Size(59, 18)
        Me.LblAdminNBTelefon.TabIndex = 7
        Me.LblAdminNBTelefon.Text = "Telefon:"
        '
        'LblAdminNBTimelonn
        '
        Me.LblAdminNBTimelonn.AutoSize = True
        Me.LblAdminNBTimelonn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBTimelonn.Location = New System.Drawing.Point(6, 282)
        Me.LblAdminNBTimelonn.Name = "LblAdminNBTimelonn"
        Me.LblAdminNBTimelonn.Size = New System.Drawing.Size(71, 18)
        Me.LblAdminNBTimelonn.TabIndex = 6
        Me.LblAdminNBTimelonn.Text = "Timelønn:"
        '
        'LblAdminNBStilling
        '
        Me.LblAdminNBStilling.AutoSize = True
        Me.LblAdminNBStilling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBStilling.Location = New System.Drawing.Point(6, 240)
        Me.LblAdminNBStilling.Name = "LblAdminNBStilling"
        Me.LblAdminNBStilling.Size = New System.Drawing.Size(54, 18)
        Me.LblAdminNBStilling.TabIndex = 5
        Me.LblAdminNBStilling.Text = "Stilling:"
        '
        'LblAdminNBAvdeling
        '
        Me.LblAdminNBAvdeling.AutoSize = True
        Me.LblAdminNBAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBAvdeling.Location = New System.Drawing.Point(6, 198)
        Me.LblAdminNBAvdeling.Name = "LblAdminNBAvdeling"
        Me.LblAdminNBAvdeling.Size = New System.Drawing.Size(67, 18)
        Me.LblAdminNBAvdeling.TabIndex = 4
        Me.LblAdminNBAvdeling.Text = "Avdeling:"
        '
        'LblAdminNBEtternavn
        '
        Me.LblAdminNBEtternavn.AutoSize = True
        Me.LblAdminNBEtternavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBEtternavn.Location = New System.Drawing.Point(6, 156)
        Me.LblAdminNBEtternavn.Name = "LblAdminNBEtternavn"
        Me.LblAdminNBEtternavn.Size = New System.Drawing.Size(72, 18)
        Me.LblAdminNBEtternavn.TabIndex = 3
        Me.LblAdminNBEtternavn.Text = "Etternavn:"
        '
        'LblAdminNBFornavn
        '
        Me.LblAdminNBFornavn.AutoSize = True
        Me.LblAdminNBFornavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBFornavn.Location = New System.Drawing.Point(6, 114)
        Me.LblAdminNBFornavn.Name = "LblAdminNBFornavn"
        Me.LblAdminNBFornavn.Size = New System.Drawing.Size(62, 18)
        Me.LblAdminNBFornavn.TabIndex = 2
        Me.LblAdminNBFornavn.Text = "Fornavn:"
        '
        'LblAdminNBPassord
        '
        Me.LblAdminNBPassord.AutoSize = True
        Me.LblAdminNBPassord.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBPassord.Location = New System.Drawing.Point(6, 75)
        Me.LblAdminNBPassord.Name = "LblAdminNBPassord"
        Me.LblAdminNBPassord.Size = New System.Drawing.Size(60, 18)
        Me.LblAdminNBPassord.TabIndex = 1
        Me.LblAdminNBPassord.Text = "Passord:"
        '
        'LblAdminNBBID
        '
        Me.LblAdminNBBID.AutoSize = True
        Me.LblAdminNBBID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdminNBBID.Location = New System.Drawing.Point(6, 36)
        Me.LblAdminNBBID.Name = "LblAdminNBBID"
        Me.LblAdminNBBID.Size = New System.Drawing.Size(69, 18)
        Me.LblAdminNBBID.TabIndex = 0
        Me.LblAdminNBBID.Text = "Bruker ID:"
        '
        'DBAdminTab
        '
        Me.DBAdminTab.Location = New System.Drawing.Point(4, 32)
        Me.DBAdminTab.Name = "DBAdminTab"
        Me.DBAdminTab.Size = New System.Drawing.Size(1416, 744)
        Me.DBAdminTab.TabIndex = 8
        Me.DBAdminTab.Text = "DB Admin"
        Me.DBAdminTab.UseVisualStyleBackColor = True
        '
        'LblKndFdato
        '
        Me.LblKndFdato.AutoSize = True
        Me.LblKndFdato.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblKndFdato.Location = New System.Drawing.Point(7, 282)
        Me.LblKndFdato.Name = "LblKndFdato"
        Me.LblKndFdato.Size = New System.Drawing.Size(87, 18)
        Me.LblKndFdato.TabIndex = 25
        Me.LblKndFdato.Text = "Fødselsdato:"
        '
        'DateKndFdato
        '
        Me.DateKndFdato.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateKndFdato.Location = New System.Drawing.Point(123, 279)
        Me.DateKndFdato.Name = "DateKndFdato"
        Me.DateKndFdato.Size = New System.Drawing.Size(172, 22)
        Me.DateKndFdato.TabIndex = 26
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 413)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(162, 22)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(7, 416)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 18)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Fødselsdato:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.HovedTab)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "SykkelUtleie DB"
        Me.HovedTab.ResumeLayout(False)
        Me.StartTab.ResumeLayout(False)
        Me.StartTab.PerformLayout()
        CType(Me.StartLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UtleieTab.ResumeLayout(False)
        Me.GrpUtleieKundeInfo.ResumeLayout(False)
        Me.GrpUtleieKunde.ResumeLayout(False)
        Me.GrpUtleieKunde.PerformLayout()
        Me.GrpUtleieSelger.ResumeLayout(False)
        Me.GrpUtleieSelger.PerformLayout()
        Me.GrpUtleieAvd.ResumeLayout(False)
        Me.GrpUtleieAvd.PerformLayout()
        Me.KDTab.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.InventarTab.ResumeLayout(False)
        Me.GrpInvSok.ResumeLayout(False)
        Me.GrpInvRegistrerEndre.ResumeLayout(False)
        Me.GrpInvRegistrerEndre.PerformLayout()
        Me.AdminTab.ResumeLayout(False)
        Me.AdminMOTDGroup.ResumeLayout(False)
        Me.AdminMOTDGroup.PerformLayout()
        Me.AdminBrukerSokGroup.ResumeLayout(False)
        Me.AdminBrukerSokGroup.PerformLayout()
        Me.AdminEndreBrukerGroup.ResumeLayout(False)
        Me.AdminEndreBrukerGroup.PerformLayout()
        Me.AdminNyBrukerGroup.ResumeLayout(False)
        Me.AdminNyBrukerGroup.PerformLayout()
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
    Friend WithEvents LblStartMOTD As Label
    Friend WithEvents StartRettigheterLabel As Label
    Friend WithEvents StartVelkommenLabel As Label
    Friend WithEvents StartLogo As PictureBox
    Friend WithEvents AdminEndreBrukerGroup As GroupBox
    Friend WithEvents TxtAdminEBTime As TextBox
    Friend WithEvents AdminEBEndreB As Button
    Friend WithEvents AdminEBLastInnB As Button
    Friend WithEvents TxtAdminEBBID As TextBox
    Friend WithEvents CboAdminEBSP As ComboBox
    Friend WithEvents CboAdminEBStilling As ComboBox
    Friend WithEvents CboAdminEBAvdeling As ComboBox
    Friend WithEvents TxtAdminEBEpost As TextBox
    Friend WithEvents TxtAdminEBTelefon As TextBox
    Friend WithEvents TxtAdminEBEtternavn As TextBox
    Friend WithEvents TxtAdminEBFornavn As TextBox
    Friend WithEvents TxtAdminEBPassord As TextBox
    Friend WithEvents ChkAdminEBTime As CheckBox
    Friend WithEvents ChkAdminEBAdmin As CheckBox
    Friend WithEvents LblAdminEBAdmin As Label
    Friend WithEvents LblAdminEBEpost As Label
    Friend WithEvents LblAdminEBSP As Label
    Friend WithEvents LblAdminEBTelefon As Label
    Friend WithEvents LblAdminEBTime As Label
    Friend WithEvents LblAdminEBStilling As Label
    Friend WithEvents LblAdminEBAvdeling As Label
    Friend WithEvents LblAdminEBEtternavn As Label
    Friend WithEvents LblAdminEBFornavn As Label
    Friend WithEvents LblAdminEBPassord As Label
    Friend WithEvents LblAdminEBBID As Label
    Friend WithEvents AdminNyBrukerGroup As GroupBox
    Friend WithEvents TxtAdminNBTime As TextBox
    Friend WithEvents AdminNBOpprettB As Button
    Friend WithEvents LblBrukerIDNBVis As Label
    Friend WithEvents CboAdminNBSP As ComboBox
    Friend WithEvents CboAdminNBStilling As ComboBox
    Friend WithEvents CboAdminNBAvdeling As ComboBox
    Friend WithEvents TxtAdminNBEpost As TextBox
    Friend WithEvents TxtAdminNBTelefon As TextBox
    Friend WithEvents TxtAdminNBEtternavn As TextBox
    Friend WithEvents TxtAdminNBFornavn As TextBox
    Friend WithEvents TxtAdminNBPassord As TextBox
    Friend WithEvents ChkAdminNBTime As CheckBox
    Friend WithEvents ChkAdminNBAdmin As CheckBox
    Friend WithEvents LblAdminNBAdmin As Label
    Friend WithEvents LblAdminNBEpost As Label
    Friend WithEvents LblAdminNBSP As Label
    Friend WithEvents LblAdminNBTelefon As Label
    Friend WithEvents LblAdminNBTimelonn As Label
    Friend WithEvents LblAdminNBStilling As Label
    Friend WithEvents LblAdminNBAvdeling As Label
    Friend WithEvents LblAdminNBEtternavn As Label
    Friend WithEvents LblAdminNBFornavn As Label
    Friend WithEvents LblAdminNBPassord As Label
    Friend WithEvents LblAdminNBBID As Label
    Friend WithEvents AdminBrukerSokGroup As GroupBox
    Friend WithEvents CboAdminBSEtter As ComboBox
    Friend WithEvents LblAdminBSEtter As Label
    Friend WithEvents TxtAdminBSFelt As TextBox
    Friend WithEvents LblAdminBSFelt As Label
    Friend WithEvents AdminMOTDGroup As GroupBox
    Friend WithEvents AdminMOTDEndreB As Button
    Friend WithEvents TxtAdminMOTD As TextBox
    Friend WithEvents AdminBSSokB As Button
    Friend WithEvents DBAdminTab As TabPage
    Friend WithEvents GrpInvSok As GroupBox
    Friend WithEvents LblInvHentID As Label
    Friend WithEvents TxtInvHentID As TextBox
    Friend WithEvents BtnInvHent As Button
    Friend WithEvents GrpInvRegistrerEndre As GroupBox
    Friend WithEvents BtnInvEndre As Button
    Friend WithEvents LblInvAktivProdukt As Label
    Friend WithEvents LblInvSavnet As Label
    Friend WithEvents LblInvSkadet As Label
    Friend WithEvents LblInvStatus As Label
    Friend WithEvents CboInvStatus As ComboBox
    Friend WithEvents CboInvSkadet As ComboBox
    Friend WithEvents CboInvSavnet As ComboBox
    Friend WithEvents CboInvSubkategori As ComboBox
    Friend WithEvents LblInvSubkategori As Label
    Friend WithEvents TxtInvGirsystem As TextBox
    Friend WithEvents TxtInvHjulstorrelse As TextBox
    Friend WithEvents TxtInvRamme As TextBox
    Friend WithEvents LblInvGirsystem As Label
    Friend WithEvents LblInvHjulstorrelse As Label
    Friend WithEvents LblInvRamme As Label
    Friend WithEvents CboInvAvdeling As ComboBox
    Friend WithEvents CboInvKategori As ComboBox
    Friend WithEvents TxtInvInnkjopspris As TextBox
    Friend WithEvents BtnInvRegistrer As Button
    Friend WithEvents CboInvForhandler As ComboBox
    Friend WithEvents TxtInvVareNummer As TextBox
    Friend WithEvents TxtInvProduktnavn As TextBox
    Friend WithEvents LblInvForhandler As Label
    Friend WithEvents LblInvInnkjopspris As Label
    Friend WithEvents LblInvVarenummer As Label
    Friend WithEvents LblInvProduktnavn As Label
    Friend WithEvents LblInvAvdeling As Label
    Friend WithEvents LblInvKategori As Label
    Friend WithEvents LvAdminBS As ListView
    Friend WithEvents LvAdminBID As ColumnHeader
    Friend WithEvents LVAdminFornavn As ColumnHeader
    Friend WithEvents LVAdminEtternavn As ColumnHeader
    Friend WithEvents LVAdminSoekefelt As ColumnHeader
    Friend WithEvents LvInvSok As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Produktnavn As ColumnHeader
    Friend WithEvents Varenummer As ColumnHeader
    Friend WithEvents Kategori As ColumnHeader
    Friend WithEvents Ramme As ColumnHeader
    Friend WithEvents Girsystem As ColumnHeader
    Friend WithEvents Hjulstørrelse As ColumnHeader
    Friend WithEvents Innkjøpspris As ColumnHeader
    Friend WithEvents Avdeling As ColumnHeader
    Friend WithEvents Forhandler As ColumnHeader
    Friend WithEvents Status As ColumnHeader
    Friend WithEvents Skadet As ColumnHeader
    Friend WithEvents Savnet As ColumnHeader
    Friend WithEvents BtnInvSok As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BtnKndEndre As Button
    Friend WithEvents BtnKndKundeID As Button
    Friend WithEvents TxtKndKundeID As TextBox
    Friend WithEvents TxtKndEndreEP As TextBox
    Friend WithEvents TxtKndEndreTlf As TextBox
    Friend WithEvents TxtKndEndreAdr As TextBox
    Friend WithEvents TxtKndEndreEN As TextBox
    Friend WithEvents TxtKndEndreFN As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LvKndSok As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents BtnKndSok As Button
    Friend WithEvents CmbKndSok As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtKndSok As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtKndEndreHF As TextBox
    Friend WithEvents TxtKndEndreRbt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BtnKndRegistrer As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtKndEpost As TextBox
    Friend WithEvents TxtKndTlf As TextBox
    Friend WithEvents TxtKndAdresse As TextBox
    Friend WithEvents TxtKndEtternavn As TextBox
    Friend WithEvents TxtKndFornavn As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents BtnInvTom As Button
    Friend WithEvents BtnInvTest As Button
    Friend WithEvents BtnInvAvbrytEndre As Button
    Friend WithEvents GrpUtleieKundeInfo As GroupBox
    Friend WithEvents GrpUtleieKunde As GroupBox
    Friend WithEvents BtnUtleieKundeSok As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblUtleieKundesok As Label
    Friend WithEvents GrpUtleieSelger As GroupBox
    Friend WithEvents LblUtleieSelger As Label
    Friend WithEvents GrpUtleieAvd As GroupBox
    Friend WithEvents LblUtleieDatoTxt As Label
    Friend WithEvents LblUtleieAvdTxt As Label
    Friend WithEvents LblUtleieDato As Label
    Friend WithEvents LblUtleieAvd As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents KundeID As ColumnHeader
    Friend WithEvents Fornavn As ColumnHeader
    Friend WithEvents Etternavn As ColumnHeader
    Friend WithEvents Adresse As ColumnHeader
    Friend WithEvents Tlf As ColumnHeader
    Friend WithEvents Epost As ColumnHeader
    Friend WithEvents BtnUtleieNyKunde As Button
    Friend WithEvents LblUtleieKlokke As Label
    Friend WithEvents LblUtleieKlokkeTxt As Label
    Friend WithEvents DateKndFdato As DateTimePicker
    Friend WithEvents LblKndFdato As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
