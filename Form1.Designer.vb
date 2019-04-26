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
        Me.KDTab = New System.Windows.Forms.TabPage()
        Me.InventarTab = New System.Windows.Forms.TabPage()
        Me.GrpInvSok = New System.Windows.Forms.GroupBox()
        Me.LivSok = New System.Windows.Forms.ListView()
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
        Me.LblInvSokSavnet = New System.Windows.Forms.Label()
        Me.LblInvSokProduktID = New System.Windows.Forms.Label()
        Me.LblInvSokSkadet = New System.Windows.Forms.Label()
        Me.TxtInvSokProduktID = New System.Windows.Forms.TextBox()
        Me.LblInvSokStatus = New System.Windows.Forms.Label()
        Me.CboInvSokSubkategori = New System.Windows.Forms.ComboBox()
        Me.CboInvSokStatus = New System.Windows.Forms.ComboBox()
        Me.CboInvSokSkadet = New System.Windows.Forms.ComboBox()
        Me.LblInvSokSubkategori = New System.Windows.Forms.Label()
        Me.CboInvSokSavnet = New System.Windows.Forms.ComboBox()
        Me.BtnIvnSokEndre = New System.Windows.Forms.Button()
        Me.BtnInvSokSok = New System.Windows.Forms.Button()
        Me.LstInvSokSokeResultat = New System.Windows.Forms.ListBox()
        Me.CboInvSokKategori = New System.Windows.Forms.ComboBox()
        Me.LblInvSokKategori = New System.Windows.Forms.Label()
        Me.TxtInvSokSokefelt = New System.Windows.Forms.TextBox()
        Me.LblInvSokSokefelt = New System.Windows.Forms.Label()
        Me.GrpInvRegistrerEndre = New System.Windows.Forms.GroupBox()
        Me.BtnInvEndre = New System.Windows.Forms.Button()
        Me.LblInvRegistrertID = New System.Windows.Forms.Label()
        Me.LblInvProduktID = New System.Windows.Forms.Label()
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
        Me.HovedTab.SuspendLayout()
        Me.StartTab.SuspendLayout()
        CType(Me.StartLogo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.UtleieTab.Location = New System.Drawing.Point(4, 32)
        Me.UtleieTab.Name = "UtleieTab"
        Me.UtleieTab.Padding = New System.Windows.Forms.Padding(3)
        Me.UtleieTab.Size = New System.Drawing.Size(1416, 744)
        Me.UtleieTab.TabIndex = 1
        Me.UtleieTab.Text = "Utleie"
        Me.UtleieTab.UseVisualStyleBackColor = True
        '
        'KDTab
        '
        Me.KDTab.Location = New System.Drawing.Point(4, 32)
        Me.KDTab.Name = "KDTab"
        Me.KDTab.Size = New System.Drawing.Size(1416, 744)
        Me.KDTab.TabIndex = 2
        Me.KDTab.Text = "Kundedatabase"
        Me.KDTab.UseVisualStyleBackColor = True
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
        Me.GrpInvSok.Controls.Add(Me.LivSok)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokSavnet)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokProduktID)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokSkadet)
        Me.GrpInvSok.Controls.Add(Me.TxtInvSokProduktID)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokStatus)
        Me.GrpInvSok.Controls.Add(Me.CboInvSokSubkategori)
        Me.GrpInvSok.Controls.Add(Me.CboInvSokStatus)
        Me.GrpInvSok.Controls.Add(Me.CboInvSokSkadet)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokSubkategori)
        Me.GrpInvSok.Controls.Add(Me.CboInvSokSavnet)
        Me.GrpInvSok.Controls.Add(Me.BtnIvnSokEndre)
        Me.GrpInvSok.Controls.Add(Me.BtnInvSokSok)
        Me.GrpInvSok.Controls.Add(Me.LstInvSokSokeResultat)
        Me.GrpInvSok.Controls.Add(Me.CboInvSokKategori)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokKategori)
        Me.GrpInvSok.Controls.Add(Me.TxtInvSokSokefelt)
        Me.GrpInvSok.Controls.Add(Me.LblInvSokSokefelt)
        Me.GrpInvSok.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpInvSok.Location = New System.Drawing.Point(431, 3)
        Me.GrpInvSok.Name = "GrpInvSok"
        Me.GrpInvSok.Size = New System.Drawing.Size(805, 622)
        Me.GrpInvSok.TabIndex = 40
        Me.GrpInvSok.TabStop = False
        Me.GrpInvSok.Text = "Søk i sykler og inventar"
        '
        'LivSok
        '
        Me.LivSok.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Produktnavn, Me.Varenummer, Me.Kategori, Me.Ramme, Me.Girsystem, Me.Hjulstørrelse, Me.Innkjøpspris, Me.Avdeling, Me.Forhandler, Me.Status, Me.Skadet, Me.Savnet})
        Me.LivSok.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LivSok.Location = New System.Drawing.Point(6, 330)
        Me.LivSok.Name = "LivSok"
        Me.LivSok.Size = New System.Drawing.Size(790, 147)
        Me.LivSok.TabIndex = 54
        Me.LivSok.UseCompatibleStateImageBehavior = False
        Me.LivSok.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 42
        '
        'Produktnavn
        '
        Me.Produktnavn.Text = "Produktnavn"
        Me.Produktnavn.Width = 80
        '
        'Varenummer
        '
        Me.Varenummer.Text = "Varenummer"
        Me.Varenummer.Width = 84
        '
        'Kategori
        '
        Me.Kategori.Text = "Kategori"
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
        Me.Hjulstørrelse.Text = "Hjulstørrelse"
        Me.Hjulstørrelse.Width = 25
        '
        'Innkjøpspris
        '
        Me.Innkjøpspris.Text = "Innkjøpspris"
        Me.Innkjøpspris.Width = 82
        '
        'Avdeling
        '
        Me.Avdeling.Text = "Avdeling"
        Me.Avdeling.Width = 59
        '
        'Forhandler
        '
        Me.Forhandler.Text = "Forhandler"
        Me.Forhandler.Width = 73
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
        'LblInvSokSavnet
        '
        Me.LblInvSokSavnet.AutoSize = True
        Me.LblInvSokSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokSavnet.Location = New System.Drawing.Point(364, 114)
        Me.LblInvSokSavnet.Name = "LblInvSokSavnet"
        Me.LblInvSokSavnet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSokSavnet.TabIndex = 53
        Me.LblInvSokSavnet.Text = "Savnet:"
        '
        'LblInvSokProduktID
        '
        Me.LblInvSokProduktID.AutoSize = True
        Me.LblInvSokProduktID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokProduktID.Location = New System.Drawing.Point(140, 592)
        Me.LblInvSokProduktID.Name = "LblInvSokProduktID"
        Me.LblInvSokProduktID.Size = New System.Drawing.Size(202, 18)
        Me.LblInvSokProduktID.TabIndex = 47
        Me.LblInvSokProduktID.Text = "Legg inn produkt ID for å endre:"
        '
        'LblInvSokSkadet
        '
        Me.LblInvSokSkadet.AutoSize = True
        Me.LblInvSokSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokSkadet.Location = New System.Drawing.Point(364, 75)
        Me.LblInvSokSkadet.Name = "LblInvSokSkadet"
        Me.LblInvSokSkadet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSokSkadet.TabIndex = 52
        Me.LblInvSokSkadet.Text = "Skadet:"
        '
        'TxtInvSokProduktID
        '
        Me.TxtInvSokProduktID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvSokProduktID.Location = New System.Drawing.Point(348, 589)
        Me.TxtInvSokProduktID.Name = "TxtInvSokProduktID"
        Me.TxtInvSokProduktID.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvSokProduktID.TabIndex = 46
        '
        'LblInvSokStatus
        '
        Me.LblInvSokStatus.AutoSize = True
        Me.LblInvSokStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokStatus.Location = New System.Drawing.Point(364, 36)
        Me.LblInvSokStatus.Name = "LblInvSokStatus"
        Me.LblInvSokStatus.Size = New System.Drawing.Size(50, 18)
        Me.LblInvSokStatus.TabIndex = 51
        Me.LblInvSokStatus.Text = "Status:"
        '
        'CboInvSokSubkategori
        '
        Me.CboInvSokSubkategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSokSubkategori.FormattingEnabled = True
        Me.CboInvSokSubkategori.Location = New System.Drawing.Point(101, 111)
        Me.CboInvSokSubkategori.Name = "CboInvSokSubkategori"
        Me.CboInvSokSubkategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSokSubkategori.TabIndex = 41
        '
        'CboInvSokStatus
        '
        Me.CboInvSokStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSokStatus.FormattingEnabled = True
        Me.CboInvSokStatus.Items.AddRange(New Object() {"Ledig", "Utleid", "Verksted"})
        Me.CboInvSokStatus.Location = New System.Drawing.Point(443, 33)
        Me.CboInvSokStatus.Name = "CboInvSokStatus"
        Me.CboInvSokStatus.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSokStatus.TabIndex = 50
        Me.CboInvSokStatus.Text = "Inne"
        '
        'CboInvSokSkadet
        '
        Me.CboInvSokSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSokSkadet.FormattingEnabled = True
        Me.CboInvSokSkadet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSokSkadet.Location = New System.Drawing.Point(443, 72)
        Me.CboInvSokSkadet.Name = "CboInvSokSkadet"
        Me.CboInvSokSkadet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSokSkadet.TabIndex = 49
        '
        'LblInvSokSubkategori
        '
        Me.LblInvSokSubkategori.AutoSize = True
        Me.LblInvSokSubkategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokSubkategori.Location = New System.Drawing.Point(6, 114)
        Me.LblInvSokSubkategori.Name = "LblInvSokSubkategori"
        Me.LblInvSokSubkategori.Size = New System.Drawing.Size(86, 18)
        Me.LblInvSokSubkategori.TabIndex = 40
        Me.LblInvSokSubkategori.Text = "Subkategori:"
        '
        'CboInvSokSavnet
        '
        Me.CboInvSokSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSokSavnet.FormattingEnabled = True
        Me.CboInvSokSavnet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSokSavnet.Location = New System.Drawing.Point(443, 111)
        Me.CboInvSokSavnet.Name = "CboInvSokSavnet"
        Me.CboInvSokSavnet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSokSavnet.TabIndex = 48
        '
        'BtnIvnSokEndre
        '
        Me.BtnIvnSokEndre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIvnSokEndre.Location = New System.Drawing.Point(485, 590)
        Me.BtnIvnSokEndre.Name = "BtnIvnSokEndre"
        Me.BtnIvnSokEndre.Size = New System.Drawing.Size(85, 23)
        Me.BtnIvnSokEndre.TabIndex = 39
        Me.BtnIvnSokEndre.Text = "Endre"
        Me.BtnIvnSokEndre.UseVisualStyleBackColor = True
        '
        'BtnInvSokSok
        '
        Me.BtnInvSokSok.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvSokSok.Location = New System.Drawing.Point(262, 112)
        Me.BtnInvSokSok.Name = "BtnInvSokSok"
        Me.BtnInvSokSok.Size = New System.Drawing.Size(62, 23)
        Me.BtnInvSokSok.TabIndex = 28
        Me.BtnInvSokSok.Text = "Søk!"
        Me.BtnInvSokSok.UseVisualStyleBackColor = True
        '
        'LstInvSokSokeResultat
        '
        Me.LstInvSokSokeResultat.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstInvSokSokeResultat.FormattingEnabled = True
        Me.LstInvSokSokeResultat.HorizontalScrollbar = True
        Me.LstInvSokSokeResultat.ItemHeight = 15
        Me.LstInvSokSokeResultat.Location = New System.Drawing.Point(6, 159)
        Me.LstInvSokSokeResultat.Name = "LstInvSokSokeResultat"
        Me.LstInvSokSokeResultat.Size = New System.Drawing.Size(793, 139)
        Me.LstInvSokSokeResultat.TabIndex = 27
        Me.LstInvSokSokeResultat.Tag = ""
        '
        'CboInvSokKategori
        '
        Me.CboInvSokKategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSokKategori.FormattingEnabled = True
        Me.CboInvSokKategori.Items.AddRange(New Object() {"Sykkel", "Utstyr"})
        Me.CboInvSokKategori.Location = New System.Drawing.Point(101, 72)
        Me.CboInvSokKategori.Name = "CboInvSokKategori"
        Me.CboInvSokKategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSokKategori.TabIndex = 26
        '
        'LblInvSokKategori
        '
        Me.LblInvSokKategori.AutoSize = True
        Me.LblInvSokKategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokKategori.Location = New System.Drawing.Point(6, 75)
        Me.LblInvSokKategori.Name = "LblInvSokKategori"
        Me.LblInvSokKategori.Size = New System.Drawing.Size(64, 18)
        Me.LblInvSokKategori.TabIndex = 23
        Me.LblInvSokKategori.Text = "Kategori:"
        '
        'TxtInvSokSokefelt
        '
        Me.TxtInvSokSokefelt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvSokSokefelt.Location = New System.Drawing.Point(101, 33)
        Me.TxtInvSokSokefelt.Name = "TxtInvSokSokefelt"
        Me.TxtInvSokSokefelt.Size = New System.Drawing.Size(211, 26)
        Me.TxtInvSokSokefelt.TabIndex = 22
        '
        'LblInvSokSokefelt
        '
        Me.LblInvSokSokefelt.AutoSize = True
        Me.LblInvSokSokefelt.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSokSokefelt.Location = New System.Drawing.Point(6, 36)
        Me.LblInvSokSokefelt.Name = "LblInvSokSokefelt"
        Me.LblInvSokSokefelt.Size = New System.Drawing.Size(64, 18)
        Me.LblInvSokSokefelt.TabIndex = 1
        Me.LblInvSokSokefelt.Text = "Søkefelt:"
        '
        'GrpInvRegistrerEndre
        '
        Me.GrpInvRegistrerEndre.Controls.Add(Me.BtnInvEndre)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvRegistrertID)
        Me.GrpInvRegistrerEndre.Controls.Add(Me.LblInvProduktID)
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
        Me.GrpInvRegistrerEndre.Size = New System.Drawing.Size(422, 622)
        Me.GrpInvRegistrerEndre.TabIndex = 39
        Me.GrpInvRegistrerEndre.TabStop = False
        Me.GrpInvRegistrerEndre.Text = "Registrer og Endre Inventar"
        '
        'BtnInvEndre
        '
        Me.BtnInvEndre.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvEndre.Location = New System.Drawing.Point(303, 499)
        Me.BtnInvEndre.Name = "BtnInvEndre"
        Me.BtnInvEndre.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvEndre.TabIndex = 47
        Me.BtnInvEndre.Text = "Endre"
        Me.BtnInvEndre.UseVisualStyleBackColor = True
        '
        'LblInvRegistrertID
        '
        Me.LblInvRegistrertID.AutoSize = True
        Me.LblInvRegistrertID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvRegistrertID.Location = New System.Drawing.Point(6, 501)
        Me.LblInvRegistrertID.Name = "LblInvRegistrertID"
        Me.LblInvRegistrertID.Size = New System.Drawing.Size(178, 18)
        Me.LblInvRegistrertID.TabIndex = 46
        Me.LblInvRegistrertID.Text = "Siste registrering ID: xxxxxx"
        '
        'LblInvProduktID
        '
        Me.LblInvProduktID.AutoSize = True
        Me.LblInvProduktID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvProduktID.Location = New System.Drawing.Point(262, 36)
        Me.LblInvProduktID.Name = "LblInvProduktID"
        Me.LblInvProduktID.Size = New System.Drawing.Size(122, 18)
        Me.LblInvProduktID.TabIndex = 45
        Me.LblInvProduktID.Text = "Produkt ID: xxxxxx"
        '
        'LblInvSavnet
        '
        Me.LblInvSavnet.AutoSize = True
        Me.LblInvSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSavnet.Location = New System.Drawing.Point(262, 390)
        Me.LblInvSavnet.Name = "LblInvSavnet"
        Me.LblInvSavnet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSavnet.TabIndex = 44
        Me.LblInvSavnet.Text = "Savnet:"
        '
        'LblInvSkadet
        '
        Me.LblInvSkadet.AutoSize = True
        Me.LblInvSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvSkadet.Location = New System.Drawing.Point(262, 306)
        Me.LblInvSkadet.Name = "LblInvSkadet"
        Me.LblInvSkadet.Size = New System.Drawing.Size(54, 18)
        Me.LblInvSkadet.TabIndex = 43
        Me.LblInvSkadet.Text = "Skadet:"
        '
        'LblInvStatus
        '
        Me.LblInvStatus.AutoSize = True
        Me.LblInvStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInvStatus.Location = New System.Drawing.Point(262, 222)
        Me.LblInvStatus.Name = "LblInvStatus"
        Me.LblInvStatus.Size = New System.Drawing.Size(50, 18)
        Me.LblInvStatus.TabIndex = 42
        Me.LblInvStatus.Text = "Status:"
        '
        'CboInvStatus
        '
        Me.CboInvStatus.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvStatus.FormattingEnabled = True
        Me.CboInvStatus.Items.AddRange(New Object() {"Ledig", "Utleid", "Verksted"})
        Me.CboInvStatus.Location = New System.Drawing.Point(265, 243)
        Me.CboInvStatus.Name = "CboInvStatus"
        Me.CboInvStatus.Size = New System.Drawing.Size(121, 26)
        Me.CboInvStatus.TabIndex = 41
        Me.CboInvStatus.Text = "Inne"
        '
        'CboInvSkadet
        '
        Me.CboInvSkadet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSkadet.FormattingEnabled = True
        Me.CboInvSkadet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSkadet.Location = New System.Drawing.Point(265, 327)
        Me.CboInvSkadet.Name = "CboInvSkadet"
        Me.CboInvSkadet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSkadet.TabIndex = 40
        Me.CboInvSkadet.Tag = ""
        '
        'CboInvSavnet
        '
        Me.CboInvSavnet.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSavnet.FormattingEnabled = True
        Me.CboInvSavnet.Items.AddRange(New Object() {"Nei", "Ja"})
        Me.CboInvSavnet.Location = New System.Drawing.Point(265, 411)
        Me.CboInvSavnet.Name = "CboInvSavnet"
        Me.CboInvSavnet.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSavnet.TabIndex = 39
        '
        'CboInvSubkategori
        '
        Me.CboInvSubkategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvSubkategori.FormattingEnabled = True
        Me.CboInvSubkategori.Items.AddRange(New Object() {"Barnesykkel", "Bysykkel", "Downhill", "Elsykkel", "Racer", "Tandem", "Terrengsykkel", "testkategori"})
        Me.CboInvSubkategori.Location = New System.Drawing.Point(123, 75)
        Me.CboInvSubkategori.Name = "CboInvSubkategori"
        Me.CboInvSubkategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvSubkategori.TabIndex = 38
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
        Me.TxtInvGirsystem.Location = New System.Drawing.Point(123, 369)
        Me.TxtInvGirsystem.Name = "TxtInvGirsystem"
        Me.TxtInvGirsystem.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvGirsystem.TabIndex = 32
        '
        'TxtInvHjulstorrelse
        '
        Me.TxtInvHjulstorrelse.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvHjulstorrelse.Location = New System.Drawing.Point(123, 327)
        Me.TxtInvHjulstorrelse.Name = "TxtInvHjulstorrelse"
        Me.TxtInvHjulstorrelse.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvHjulstorrelse.TabIndex = 31
        '
        'TxtInvRamme
        '
        Me.TxtInvRamme.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvRamme.Location = New System.Drawing.Point(123, 285)
        Me.TxtInvRamme.Name = "TxtInvRamme"
        Me.TxtInvRamme.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvRamme.TabIndex = 30
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
        Me.CboInvAvdeling.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvAvdeling.FormattingEnabled = True
        Me.CboInvAvdeling.Items.AddRange(New Object() {"Finse", "Flåm", "Haugastøl", "Myrdal", "Voss", "The Management"})
        Me.CboInvAvdeling.Location = New System.Drawing.Point(123, 117)
        Me.CboInvAvdeling.Name = "CboInvAvdeling"
        Me.CboInvAvdeling.Size = New System.Drawing.Size(121, 26)
        Me.CboInvAvdeling.TabIndex = 26
        '
        'CboInvKategori
        '
        Me.CboInvKategori.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvKategori.FormattingEnabled = True
        Me.CboInvKategori.Items.AddRange(New Object() {"Sykkel", "Utstyr", "9999"})
        Me.CboInvKategori.Location = New System.Drawing.Point(123, 33)
        Me.CboInvKategori.Name = "CboInvKategori"
        Me.CboInvKategori.Size = New System.Drawing.Size(121, 26)
        Me.CboInvKategori.TabIndex = 25
        '
        'TxtInvInnkjopspris
        '
        Me.TxtInvInnkjopspris.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvInnkjopspris.Location = New System.Drawing.Point(123, 243)
        Me.TxtInvInnkjopspris.Name = "TxtInvInnkjopspris"
        Me.TxtInvInnkjopspris.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvInnkjopspris.TabIndex = 24
        '
        'BtnInvRegistrer
        '
        Me.BtnInvRegistrer.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInvRegistrer.Location = New System.Drawing.Point(212, 499)
        Me.BtnInvRegistrer.Name = "BtnInvRegistrer"
        Me.BtnInvRegistrer.Size = New System.Drawing.Size(85, 23)
        Me.BtnInvRegistrer.TabIndex = 23
        Me.BtnInvRegistrer.Text = "Registrer"
        Me.BtnInvRegistrer.UseVisualStyleBackColor = True
        '
        'CboInvForhandler
        '
        Me.CboInvForhandler.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboInvForhandler.FormattingEnabled = True
        Me.CboInvForhandler.Items.AddRange(New Object() {"testforhandler", "Stians Sport AS", "Svendsens sykler AS"})
        Me.CboInvForhandler.Location = New System.Drawing.Point(123, 411)
        Me.CboInvForhandler.Name = "CboInvForhandler"
        Me.CboInvForhandler.Size = New System.Drawing.Size(121, 26)
        Me.CboInvForhandler.TabIndex = 20
        '
        'TxtInvVareNummer
        '
        Me.TxtInvVareNummer.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvVareNummer.Location = New System.Drawing.Point(123, 201)
        Me.TxtInvVareNummer.Name = "TxtInvVareNummer"
        Me.TxtInvVareNummer.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvVareNummer.TabIndex = 14
        '
        'TxtInvProduktnavn
        '
        Me.TxtInvProduktnavn.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtInvProduktnavn.Location = New System.Drawing.Point(123, 159)
        Me.TxtInvProduktnavn.Name = "TxtInvProduktnavn"
        Me.TxtInvProduktnavn.Size = New System.Drawing.Size(121, 26)
        Me.TxtInvProduktnavn.TabIndex = 13
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
        Me.InventarTab.ResumeLayout(False)
        Me.GrpInvSok.ResumeLayout(False)
        Me.GrpInvSok.PerformLayout()
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
    Friend WithEvents LblInvSokSavnet As Label
    Friend WithEvents LblInvSokProduktID As Label
    Friend WithEvents LblInvSokSkadet As Label
    Friend WithEvents TxtInvSokProduktID As TextBox
    Friend WithEvents LblInvSokStatus As Label
    Friend WithEvents CboInvSokSubkategori As ComboBox
    Friend WithEvents CboInvSokStatus As ComboBox
    Friend WithEvents CboInvSokSkadet As ComboBox
    Friend WithEvents LblInvSokSubkategori As Label
    Friend WithEvents CboInvSokSavnet As ComboBox
    Friend WithEvents BtnIvnSokEndre As Button
    Friend WithEvents BtnInvSokSok As Button
    Friend WithEvents LstInvSokSokeResultat As ListBox
    Friend WithEvents CboInvSokKategori As ComboBox
    Friend WithEvents LblInvSokKategori As Label
    Friend WithEvents TxtInvSokSokefelt As TextBox
    Friend WithEvents LblInvSokSokefelt As Label
    Friend WithEvents GrpInvRegistrerEndre As GroupBox
    Friend WithEvents BtnInvEndre As Button
    Friend WithEvents LblInvRegistrertID As Label
    Friend WithEvents LblInvProduktID As Label
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
    Friend WithEvents LivSok As ListView
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
End Class
