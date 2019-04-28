Imports MySql.Data.MySqlClient

Public Class Form1
#Region "GlobaleVariabler"
    'Her plasseres globale variabler
    'som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
    'Test forandring
    ' Test hilsen IVar
    'Globalevariabler som må sjekkes ved ønsket tilgang. LogBool settes til TRUE ved inlogging, AdminBool settes til TRUE hvis bruker er admin.

    Dim LogBool As Boolean
    Dim AdminBool As Boolean
    Dim tilkobling As MySqlConnection
    Dim InvAktivtProduktID As String

#End Region

#Region "GlobaleFunksjonerOgProsedyrer"
    'Her plasseres globale funksjoner og prosdyrer som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.

    Private Sub DBConnect()
        tilkobling = New MySqlConnection(
        "Server=mysql-ait.stud.idi.ntnu.no;" _
        & "Database=colinft;" _
        & "Uid=colinft;" _
        & "Pwd=BJhYR1HS;")
        Try
            tilkobling.Open()
        Catch ex As MySqlException
            MsgBox(ex)
        End Try
    End Sub

    Private Sub DBDisconnect()
        tilkobling.Close()
        tilkobling.Dispose()
    End Sub

#End Region

#Region "Form Load og Login"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartMOTDUpdate()
    End Sub


#End Region

#Region "TabSkifting"
    'Denne regionen er brukt til eventkoding av det som skjer da du skifter tab.
    'Nedenfor er en event som kjoeres hver gang man skifter tab. Den sjekker tabindex verdien og kjorer koden som er under det riktige caset.
    'Dette er til bruk for f.eks tilgangsskjekker og for aa laste inn verdier da man bytter til tabs.
    'Proev aa holde dette region saa ren som mulig, hvis man skal kjoere masse kode er det best aa lage egen prosedyre/funksjon for a derette kalle paa det nedenfor.
    Private Sub HovedTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HovedTab.SelectedIndexChanged
        Dim HovedTabIndex As Integer
        HovedTabIndex = HovedTab.SelectedIndex + 1

        Select Case HovedTabIndex
            Case 1 'Bestemmer det som skjer etter man har valgt startmeny.
                MsgBox("Startmeny")
                StartMOTDUpdate()
            Case 2 'Bestemmer det som skjer etter man har valgt Utleiemeny.
                MsgBox("Utleiemeny")
            Case 3 'Bestemmer det som skjer etter man har valgt Kundedatabasemeny.
                CmbKndSok.Items.Clear()
                Dim innhold = New String() {"ID", "Fornavn", "Etternavn", "Adresse", "Telefon", "Epost", "Rabatt Tier", "Handlet For"}

                For i As Integer = 0 To innhold.Length - 1
                    CmbKndSok.Items.Add(innhold(i))
                Next
                MsgBox("KDBmeny")
                BtnKndEndre.Enabled = False
            Case 4 'Bestemmer det som skjer etter man har valgt Inventarmeny.
                MsgBox("Inventarmeny")
            Case 5 'Bestemmer det som skjer etter man har valgt Inventarsearchmeny.
                MsgBox("InvSearchmeny")
            Case 6 'Bestemmer det som skjer etter man har valgt Logistikkmeny.
                MsgBox("Logistikkmeny")
            Case 7 'Bestemmer det som skjer etter man har valgt Statistikkmeny.
                MsgBox("Statistikkmeny")
            Case 8 'Bestemmer det som skjer etter man har valgt Adminmeny.
                MsgBox("AdminMeny")
                AdminAvdelingPopulate()
                AdminBrukerIDCalc()
            Case 9 'Bestemmer det som skjer etter man har valgt AdminDBmeny.
                'MsgBox("AdminDBMeny")
        End Select
    End Sub


#End Region

#Region "StartTab"
    'Her plasseres kode som er relevant til Start Tab.
    'Variabler som brukes her skal begynne med Start. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    Private Sub StartMOTDUpdate()
        Try
            DBConnect()
            Dim StartMOTDKommando As New MySqlCommand("Select * FROM message_of_the_day WHERE message_id = 1", tilkobling)
            Dim StartMOTDAdapter As New MySqlDataAdapter
            Dim StartMOTDTable As New DataTable
            StartMOTDAdapter.SelectCommand = StartMOTDKommando
            StartMOTDAdapter.Fill(StartMOTDTable)
            DBDisconnect()
            Dim StartMOTDRow As DataRow
            For Each StartMOTDRow In StartMOTDTable.Rows
                LblStartMOTD.Text = "Message of the Day: " + StartMOTDRow("message")
            Next

        Catch StartSqlError1 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & StartSqlError1.Message)

        End Try
    End Sub
#End Region


#Region "UtleieTab"
    'Her plasseres kode som er relevant til Utleie Tab.
    'Variabler som brukes her skal begynne med Leie. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "KundeTab"
    'Her plasseres kode som er relevant til Kunde Tab.
    'Variabler som brukes her skal begynne med Kunde. Dette er for å unngå klasj.
    'Husk kode kommentarer.


    'Testing testing 123'
    'Håvard var her >:)'



    Dim KndFornavn As String
    Dim KndEtternavn As String
    Dim KndAdresse As String
    Dim KndFodselsar As Date
    Dim KndTlf As String
    Dim KndEpost As String





    'Bedre måte å gjøre dette på:
    Private Sub TxtKndFornavn_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndFornavn.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå -"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtKndEtternavn_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndEtternavn.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå -"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxtKndAdresse_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndAdresse.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub TxtKndEpost_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndEpost.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå1234567890@!#$%&'*+-/=?^_`{|}~;."
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtKndTlf_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndTlf.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub





    'LEGG INN NYE KUNDER
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnKndRegistrer.Click


        KndFornavn = TxtKndFornavn.Text
        KndEtternavn = TxtKndEtternavn.Text
        KndAdresse = TxtKndAdresse.Text

        KndTlf = TxtKndTlf.Text
        KndEpost = TxtKndEpost.Text

        'Insert new data with SQL

        If KndFornavn = "" Then
            MsgBox("Vennligst fyll inn fornavn")
            Exit Sub
        End If
        If KndEtternavn = "" Then
            MsgBox("Vennligst fyll inn etternavn")
            Exit Sub
        End If
        If KndAdresse = "" Then
            MsgBox("Vennligst fyll inn adresse")
            Exit Sub
        End If
        If KndTlf = "" Then
            MsgBox("Vennligst fyll inn telefonnummer")
            Exit Sub
        End If
        If KndEpost = "" Then
            MsgBox("Vennligst fyll inn epost")
            Exit Sub
        End If



        Try
            DBConnect()
            Dim sporring As New MySqlCommand("INSERT INTO kunder (kunde_fornavn, kunde_etternavn, adresse, telefon, epost, rabatt_id, handlet_for) VALUES ('" & KndFornavn & "', '" & KndEtternavn & "', '" & KndAdresse & "', " & KndTlf & ", '" & KndEpost & "', 1, 0)", tilkobling)
            sporring.ExecuteNonQuery()

            DBDisconnect()
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        End Try
        MsgBox("Innlegging var vellykket")
    End Sub



    Dim KndSokKundeID

    Dim KndFornavnSelected
    Dim KndEtternavnSelected
    Dim KndAdresseSelected

    Dim KndTlfSelected
    Dim KndEpostSelected
    Dim KndRabattSelected
    Dim KndHandletSelected



    'ENDRE FANE
    Private Sub BtnKndKundeID_Click(sender As Object, e As EventArgs) Handles BtnKndKundeID.Click

        KndSokKundeID = TxtKndKundeID.Text
        If KndSokKundeID = "" Then
            MsgBox("Vennligst fyll inn ID for søk")
            Exit Sub
        End If



        Try
            DBConnect()
            Dim sporring As New MySqlCommand("SELECT * FROM kunder WHERE kunde_id = " & KndSokKundeID, tilkobling)
            Dim tempVarSporring = sporring.ExecuteReader

            While tempVarSporring.Read
                KndFornavnSelected = tempVarSporring("kunde_fornavn")
                KndEtternavnSelected = tempVarSporring("kunde_etternavn")
                KndAdresseSelected = tempVarSporring("adresse")

                KndTlfSelected = tempVarSporring("telefon")
                KndEpostSelected = tempVarSporring("epost")
                KndRabattSelected = tempVarSporring("rabatt_id")
                KndHandletSelected = tempVarSporring("handlet_for")

            End While
            tempVarSporring.Close()
            DBDisconnect()

            TxtKndEndreFN.Text = KndFornavnSelected
            TxtKndEndreEN.Text = KndEtternavnSelected
            TxtKndEndreAdr.Text = KndAdresseSelected

            TxtKndEndreTlf.Text = KndTlfSelected
            TxtKndEndreEP.Text = KndEpostSelected
            TxtKndEndreRbt.Text = KndRabattSelected
            TxtKndEndreHF.Text = KndHandletSelected




        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)

        End Try
        If KndFornavnSelected <> "" Then
            BtnKndEndre.Enabled = True
        Else
            MsgBox("Beklager, ingen treff på det nummeret")
            BtnKndEndre.Enabled = False
        End If
    End Sub




    'SØK DROPDOWN
    '  Private Sub CmbKndSok_Click(sender As Object, e As EventArgs) Handles CmbKndSok.Click
    '      CmbKndSok.Items.Clear()
    '  Dim innhold = New String() {"ID", "Fornavn", "Etternavn", "Adresse", "Telefon", "Epost", "Rabatt Tier", "Handlet For"}

    ' For i As Integer = 0 To innhold.Length - 1
    '           CmbKndSok.Items.Add(innhold(i))
    '   Next
    '  End Sub

    'SØK KNAPP

    Dim KndSokInput
    Dim KndSokSelectedTag


    Private Sub BtnKndSok_Click(sender As Object, e As EventArgs) Handles BtnKndSok.Click
        KndSokInput = TxtKndSok.Text
        Dim KndTempVar = CmbKndSok.SelectedIndex

        If KndSokInput = "" Then
            MsgBox("Vennligst fyll inn gylding søkeord")
            Exit Sub
        End If
        If KndTempVar = -1 Then
            MsgBox("Vennligst velg en søkekategori")
            Exit Sub
        End If

        Dim KndSQLKolonner = New String() {"kunde_id", "kunde_fornavn", "kunde_etternavn", "adresse", "telefon", "epost", "rabatt_id", "handlet_for"}
        KndSokSelectedTag = KndSQLKolonner(KndTempVar)



        Try
            DBConnect()
            Dim sporring As New MySqlCommand("SELECT * FROM kunder WHERE " & KndSokSelectedTag & " LIKE '%" & KndSokInput & "%'", tilkobling)


            Dim KndSearchAdapter As New MySqlDataAdapter
            Dim KndSearchTable As New DataTable
            KndSearchAdapter.SelectCommand = sporring
            KndSearchAdapter.Fill(KndSearchTable)

            DBDisconnect()

            Dim KundeRow As DataRow
            Dim Kunde_ID, Kunde_Fornavn, Kunde_Etternavn, Kunde_Adresse, Kunde_Tlf, Kunde_Epost, Kunde_rabatt, Kunde_HF, KundeSok As String
            LvKndSok.Items.Clear()
            For Each KundeRow In KndSearchTable.Rows
                Kunde_ID = KundeRow("kunde_id")
                Kunde_Fornavn = KundeRow("kunde_fornavn")
                Kunde_Etternavn = KundeRow("kunde_etternavn")
                Kunde_Adresse = KundeRow("adresse")

                Kunde_Tlf = KundeRow("telefon")
                Kunde_Epost = KundeRow("epost")
                Kunde_rabatt = KundeRow("rabatt_id")
                Kunde_HF = KundeRow("handlet_for")

                KundeSok = KundeRow(KndSokSelectedTag)
                LvKndSok.Items.Add(New ListViewItem({Kunde_ID, Kunde_Fornavn, Kunde_Etternavn, Kunde_Adresse, Kunde_Tlf, Kunde_Epost, Kunde_rabatt, Kunde_HF, KundeSok}))
            Next



        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)

        End Try

        'SQL for søk 
        'Select * from Kunder where kndsokselectedtag = kndsokInput
        'Skriv ut til listbox i søk
        'Legg kundeID i KndSokKundeID for bruk i endring



    End Sub




    Private Sub BtnKndEndre_Click(sender As Object, e As EventArgs) Handles BtnKndEndre.Click

        Dim selectedKundeId = TxtKndKundeID.Text

        Dim KndChangeValueFN = TxtKndEndreFN.Text
        Dim KndChangeValueEN = TxtKndEndreEN.Text
        Dim KndChangeValueAdr = TxtKndEndreAdr.Text
        Dim KndChangeValueTlf = TxtKndEndreTlf.Text
        Dim KndChangeValueEP = TxtKndEndreEP.Text
        Dim KndChangeValueRbt = TxtKndEndreRbt.Text
        Dim KndChangeValueHF = TxtKndEndreHF.Text


        If selectedKundeId = "" Then
            MsgBox("Vennligst fyll inn et gyldig ID-nummer")
            Exit Sub
        End If

        If KndChangeValueFN = "" Then
            MsgBox("Vennligst fyll inn et fornavn")
            Exit Sub
        End If
        If KndChangeValueEN = "" Then
            MsgBox("Vennligst fyll inn et etternavn")
            Exit Sub
        End If
        If KndChangeValueAdr = "" Then
            MsgBox("Vennligst fyll inn en adresse")
            Exit Sub
        End If
        If KndChangeValueTlf = "" And KndChangeValueTlf.Length <> 8 Then
            MsgBox("Vennligst fyll inn et gyldig telefonnummer")
            Exit Sub
        End If
        If KndChangeValueEP = "" Then
            MsgBox("Vennligst fyll inn en epostadresse")
            Exit Sub
        End If
        If KndChangeValueRbt = "" Then
            KndChangeValueRbt = "1"
        End If

        If KndChangeValueHF = "" Then
            KndChangeValueHF = "0"
        End If



        Try
            DBConnect()
            Dim sporring As New MySqlCommand("UPDATE kunder SET kunde_fornavn = '" & KndChangeValueFN & "', kunde_etternavn = '" & KndChangeValueEN & "', adresse = '" & KndChangeValueAdr & "', telefon = " & KndChangeValueTlf & ", epost = '" & KndChangeValueEP & "', rabatt_id = " & KndChangeValueRbt & ", handlet_for = " & KndChangeValueHF & " WHERE kunde_id = " & selectedKundeId, tilkobling)
            sporring.ExecuteNonQuery()

            DBDisconnect()

            MsgBox("Endring vellykket")



        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)

        End Try


    End Sub


#End Region


#Region "InventarTab"
    'Her plasseres kode som er relevant til Inventar Tab.
    'Variabler som brukes her skal begynne med Inv. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    'Dropdown:
    'Kategori er delt i sykkel og utstyr.
    'Subkategorier vil avhenge av om det er sykkel eller utstyr som skal registreres.
    'Foreløpig ingen kategorier for utstyr

    'Standardvalg for status, skadet, savnet bør være henholdsvis inne, nei, nei. ???

    'Må gjøres:
    'MsgBox for bekreftelse av registrering og endring av objekter.
    'Sjekk av tillatte verdier
    'True / false i søkeresultat -> "ja" / "nei" for skadet/savnet
    'Legge inn kode for henting av utstyr
    'håndtering av null resultat ved søk.. ?

    Private Sub InvTomFelt()
        CboInvKategori.SelectedIndex = -1
        CboInvSubkategori.SelectedIndex = -1
        CboInvAvdeling.SelectedIndex = -1
        TxtInvProduktnavn.Text = ""
        TxtInvVareNummer.Text = ""
        TxtInvInnkjopspris.Text = ""
        TxtInvRamme.Text = ""
        TxtInvHjulstorrelse.Text = ""
        TxtInvGirsystem.Text = ""
        CboInvForhandler.SelectedIndex = -1
        CboInvStatus.SelectedIndex = -1
        CboInvSkadet.SelectedIndex = -1
        CboInvSavnet.SelectedIndex = -1
    End Sub

    Private Function InvHentID(subkategori, avdeling, forhandler)
        'Henter ID fra forhandler, avdeling og subkategori basert på navn i respektive comboboxer

        Dim InvForhandlerID As String = ""
        Dim InvAvdelingID As String = ""
        Dim InvSubKategoriID As String = ""
        Dim InvForhandlerIDSporring As String = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='" & forhandler & "';"
        Dim InvAvdelingIDSporring As String = "SELECT avdeling_id FROM avdeling WHERE avd_navn='" & avdeling & "';"
        Dim InvSubKategoriIDSporring As String = "SELECT type_id FROM sykkel_typer WHERE kategori='" & subkategori & "';"
        Dim InvIDListe(2) As String

        Dim InvSqlHent As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        Try
            DBConnect()

            InvSqlHent = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlHent.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlHent = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlHent.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlHent = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlHent.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()

            InvIDListe(0) = InvSubKategoriID
            InvIDListe(1) = InvAvdelingID
            InvIDListe(2) = InvForhandlerID

            Return (InvIDListe)

        Catch ex As MySqlException
            MsgBox("Feil ved henting av ID:" & vbNewLine & ex.Message)
        End Try
    End Function

    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvForhandlerID, InvAvdelingID, InvSubKategoriID, InvForhandlerIDSporring,
            InvAvdelingIDSporring, InvSubKategoriIDSporring, InvRegistrerSporring As String

        InvKategori = CboInvKategori.SelectedItem
        InvSubkategori = CboInvSubkategori.SelectedItem
        InvAvdeling = CboInvAvdeling.SelectedItem
        InvProduktnavn = TxtInvProduktnavn.Text
        InvVarenummer = TxtInvVareNummer.Text
        InvInnkjopspris = TxtInvInnkjopspris.Text
        InvRamme = TxtInvRamme.Text
        InvHjulstorrlese = TxtInvHjulstorrelse.Text
        InvGirsystem = TxtInvGirsystem.Text
        InvForhandler = CboInvForhandler.SelectedItem
        InvStatus = CboInvStatus.SelectedItem
        InvSkadet = CboInvSkadet.SelectedIndex
        InvSavnet = CboInvSavnet.SelectedIndex

        'SQLspørringer for henting av id fra forhandler, avdeling og subkategori
        InvForhandlerIDSporring = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='" & InvForhandler & "';"
        InvAvdelingIDSporring = "SELECT avdeling_id FROM avdeling WHERE avd_navn='" & InvAvdeling & "';"
        InvSubKategoriIDSporring = "SELECT type_id FROM sykkel_typer WHERE kategori='" & InvSubkategori & "';"

        Dim InvSqlRegistrer As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        'Henter ID fra forhandler, avdeling og subkategori basert på navn i respektive comboboxer
        Try
            DBConnect()

            InvSqlRegistrer = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlRegistrer.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlRegistrer = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlRegistrer.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlRegistrer = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlRegistrer.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()
        Catch ex As MySqlException
            MsgBox("Feil ved henting av ID:" & vbNewLine & ex.Message)
        End Try

        'SQLspørring for innlegging av sykkel i database. Data hentes fra felt
        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvRegistrerSporring = "INSERT INTO sykler (forhandler_id, type_id, avdeling_id, sykkel_navn, " &
                "sykkel_modell, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet)" _
                & "VALUES ('" + InvForhandlerID & "', '" & InvSubKategoriID & "', '" _
                & InvAvdelingID + "', '" & InvProduktnavn & "', '" & InvVarenummer & "', '" _
                & InvInnkjopspris & "', '" & InvStatus & "', '" & InvHjulstorrlese & "', '" _
                & InvRamme & "', '" & InvGirsystem & "', '" & InvSavnet & "', '" & InvSkadet & "');"

            Try
                DBConnect()
                InvSqlRegistrer = New MySqlCommand(InvRegistrerSporring, tilkobling)
                InvSqlRegistrer.ExecuteNonQuery()
                DBDisconnect()
            Catch ex As MySqlException
                MsgBox("Feil ved registrering av sykkel:" & vbNewLine & ex.Message)
            End Try

            'SQLspørring for innlegging av utstyr i database. Data hentes fra felt
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then
            InvRegistrerSporring = "INSERT INTO utstyr (utstyr_navn, varenummer, utstyr_pris, forhandler_id)" _
                & " VALUES('" & InvProduktnavn & "' ,'" & InvVarenummer & "', '" & InvInnkjopspris _
                & "', '" & InvForhandlerID & "');"

            Try
                DBConnect()
                InvSqlRegistrer = New MySqlCommand(InvRegistrerSporring, tilkobling)
                InvSqlRegistrer.ExecuteNonQuery()
                DBDisconnect()
            Catch ex As MySqlException
                MsgBox("Feil ved registrering av utstyr:" & vbNewLine & ex.Message)
            End Try
        Else
            MsgBox("Velg kategori")
        End If

    End Sub

    Private Sub BtnInvSoke_Click(sender As Object, e As EventArgs) Handles BtnInvSoke.Click
        'skadet og savnet må settes selectedindex? - se if else for å unngå NULL

        'Tømmer tidligere søkeresultat fra listview
        LivSok.Items.Clear()

        Dim InvForhandlerID As String
        Dim InvAvdelingID As String
        Dim InvSubKategoriID As String
        Dim InvSpSkadet As String
        Dim InvSpSavnet As String
        'Dim InvIDListe(2) As String

        Dim InvForhandlerNavn As String = CboInvForhandler.SelectedItem
        Dim InvAvdelingNavn As String = CboInvAvdeling.SelectedItem
        Dim InvSubKategori As String = CboInvSubkategori.SelectedItem

        Dim InvForhandlerIDSporring As String = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='" _
            & InvForhandlerNavn & "';"
        Dim InvAvdelingIDSporring As String = "SELECT avdeling_id FROM avdeling WHERE avd_navn='" _
            & InvAvdelingNavn & "';"
        Dim InvSubKategoriIDSporring As String = "SELECT type_id FROM sykkel_typer WHERE kategori='" _
            & InvSubKategori & "';"

        Dim InvSqlSok As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        'InvIDListe = InvHentID(InvSubKategori, InvAvdelingNavn, InvForhandlerNavn)

        'SQLspørringer for henting av id fra forhandler, avdeling og subkategori
        Try
            DBConnect()

            InvSqlSok = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlSok.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlSok = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlSok.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlSok = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlSok.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()
        Catch ex As Exception
            MsgBox("Feil ved henting av ID:" & vbNewLine & ex.Message)
        End Try

        'Deklarering av variabler for oppbygging av SQLspørring
        Dim SpInit As String = "SELECT * FROM sykler WHERE "
        Dim SpSykkelNavn As String = "sykkel_navn LIKE '%" & TxtInvProduktnavn.Text.Trim & "%'"
        Dim SpsykkelModell As String = "type_id LIKE '%" & InvSubKategoriID & "%'"
        'Dim SpsykkelModell As String = "type_id LIKE '%" & InvIDListe(0) & "%'"

        Dim SpTypeid As String = "sykkel_modell LIKE '%" & TxtInvVareNummer.Text.Trim & "%'"
        Dim SpSykkelRamme As String = "sykkel_ramme LIKE '%" & TxtInvRamme.Text.Trim & "%'"
        Dim SpGirsystem As String = "girsystem LIKE '%" & TxtInvGirsystem.Text.Trim & "%'"
        Dim SpHjulstorrelse As String = "hjul_str LIKE '%" & TxtInvHjulstorrelse.Text.Trim & "%'"
        Dim SpSykkelPris As String = "sykkel_pris LIKE '%" & TxtInvInnkjopspris.Text.Trim & "%'"
        Dim SpAvdeling As String = "avdeling_id LIKE '%" & InvAvdelingID & "%'"
        'Dim SpAvdeling As String = "avdeling_id LIKE '%" & InvIDListe(1) & "%'"

        Dim SpForhandlerID As String = "forhandler_id LIKE '%" & InvForhandlerID & "%'"
        'Dim SpForhandlerID As String = "forhandler_id LIKE '%" & InvIDListe(2) & "%'"

        Dim SpSykkelStatus As String = "sykkel_status LIKE '%" & CboInvStatus.SelectedItem & "%'"


        'Unngår NULL verdi fra combobox skadet og savnet - (nødvendig? sammenheng med selectedindex presatt...)
        If CboInvSkadet.SelectedIndex = 0 Or CboInvSkadet.SelectedIndex = 1 Then
            InvSpSkadet = "skadet LIKE '%" & CboInvSkadet.SelectedIndex & "%'"
        Else
            InvSpSkadet = "skadet LIKE '%%'"
        End If

        If CboInvSavnet.SelectedIndex = 0 Or CboInvSavnet.SelectedIndex = 1 Then
            InvSpSavnet = "savnet LIKE '%" & CboInvSavnet.SelectedIndex & "%'"
        Else
            InvSpSavnet = "savnet LIKE '%%'"
        End If

        Dim Sporring As String
        Sporring = SpInit & SpSykkelNavn & " AND " & SpsykkelModell & " AND " &
            SpTypeid & " AND " & SpSykkelRamme & " AND " & SpGirsystem & " AND " &
            SpHjulstorrelse & " AND " & SpSykkelPris & " AND " & SpAvdeling & " AND " &
            SpForhandlerID & " AND " & SpSykkelStatus & " AND " & InvSpSkadet & " AND " & InvSpSavnet & ";"

        Dim InvResultatArray(12) As String
        Dim InvResultatObjekt As ListViewItem

        'Sender spørring for søk basert på innlagte data i skjema [navn].
        'Skriver ut returnerte rader til listview [navn]
        Try
            DBConnect()

            InvSqlSok = New MySqlCommand(Sporring, tilkobling)
            InvSqlLeser = InvSqlSok.ExecuteReader()

            'For hver kolonne les inn verdi 0-12 og legg i listview  - 3 8 9 ID
            While InvSqlLeser.Read()
                For i = 0 To InvSqlLeser.FieldCount - 1
                    If TypeOf InvSqlLeser(i) Is DBNull Then
                    Else
                        InvResultatArray(i) = InvSqlLeser(i)
                    End If
                Next
                InvResultatObjekt = New ListViewItem(InvResultatArray)
                LivSok.Items.Add(InvResultatObjekt)
            End While
            InvSqlLeser.Close()

            DBDisconnect()
        Catch ex As MySqlException
            MsgBox("Feil ved søk i database:" & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click

        'SQLspørring med _endring_ (alter table) av data for valgt produkt med ID fra valgt produkt i søkefelt
        BtnInvRegistrer.Enabled = True
        BtnInvSoke.Enabled = True

        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvForhandlerID, InvAvdelingID, InvSubKategoriID, InvForhandlerIDSporring,
            InvAvdelingIDSporring, InvSubKategoriIDSporring, InvEndreSporring As String

        InvKategori = CboInvKategori.SelectedItem
        InvSubkategori = CboInvSubkategori.SelectedItem
        InvAvdeling = CboInvAvdeling.SelectedItem
        InvProduktnavn = TxtInvProduktnavn.Text.Trim
        InvVarenummer = TxtInvVareNummer.Text.Trim
        InvInnkjopspris = TxtInvInnkjopspris.Text.Trim
        InvRamme = TxtInvRamme.Text.Trim
        InvHjulstorrlese = TxtInvHjulstorrelse.Text.Trim
        InvGirsystem = TxtInvGirsystem.Text.Trim
        InvForhandler = CboInvForhandler.SelectedItem
        InvStatus = CboInvStatus.SelectedItem
        InvSkadet = CboInvSkadet.SelectedIndex
        InvSavnet = CboInvSavnet.SelectedIndex

        InvForhandlerIDSporring = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='" & InvForhandler & "';"
        InvAvdelingIDSporring = "SELECT avdeling_id FROM avdeling WHERE avd_navn='" & InvAvdeling & "';"
        InvSubKategoriIDSporring = "SELECT type_id FROM sykkel_typer WHERE kategori='" & InvSubkategori & "';"

        Dim InvSqlEndre As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        'Henter ID fra forhandler, avdeling og subkategori basert på navn i respektive comboboxer
        Try
            DBConnect()

            InvSqlEndre = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlEndre.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlEndre = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlEndre.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlEndre = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlEndre.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()
        Catch ex As MySqlException
            MsgBox("Feil ved henting av ID:" & vbNewLine & ex.Message)
        End Try

        'SQLspørring for endring av sykkel i database. Data hentes fra felt
        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvEndreSporring = "UPDATE sykler SET sykkel_navn='" & InvProduktnavn _
            & "', sykkel_modell='" & InvVarenummer & "', type_id='" & InvSubKategoriID & "', sykkel_ramme='" _
            & InvRamme & "', girsystem='" & InvGirsystem & "', hjul_str='" & InvHjulstorrlese _
            & "', sykkel_pris='" & InvInnkjopspris & "', avdeling_id='" & InvAvdelingID & "', forhandler_id='" _
            & InvForhandlerID & "', sykkel_status='" & InvStatus & "', skadet='" & InvSkadet & "', savnet='" _
            & InvSavnet & "' WHERE sykkel_id='" & InvAktivtProduktID & "';"

            Try
                DBConnect()
                'Dim da As New MySqlDataAdapter
                InvSqlEndre = New MySqlCommand(InvEndreSporring, tilkobling)
                'Dim interntabell As New DataTable
                'da.SelectCommand = sqlEndre
                'da.Fill(interntabell)
                InvSqlEndre.ExecuteNonQuery()
                DBDisconnect()
                MsgBox("Endring av sykkel med ID " & InvAktivtProduktID & " vellykket.")
                InvAktivtProduktID = ""
            Catch ex As MySqlException
                MsgBox("Feil ved endring av sykkel:" & vbNewLine & ex.Message)
            End Try

            'SQLspørring for endring av utstyr i database. Data hentes fra felt
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then
            InvEndreSporring = "UPDATE utstyr SET utstyr_navn='" & InvProduktnavn & "', varenummer='" _
                & InvVarenummer & "', utstyr_pris='" & InvInnkjopspris & "', forhandler_id='" _
                & InvForhandlerID & "' WHERE utstyr_id='" & InvAktivtProduktID & "';"


            Try
                DBConnect()
                InvSqlEndre = New MySqlCommand(InvEndreSporring, tilkobling)
                InvSqlEndre.ExecuteNonQuery()
                DBDisconnect()
                MsgBox("Endring av utstyr med ID " & InvAktivtProduktID & " vellykket.")
                InvAktivtProduktID = ""
            Catch ex As MySqlException
                MsgBox("Feil ved endring av utstyr:" & vbNewLine & ex.Message)
            End Try
        Else
            MsgBox("Velg kategori")
        End If

    End Sub

    Private Sub BtnInvAvbrytEndre_Click(sender As Object, e As EventArgs) Handles BtnInvAvbrytEndre.Click
        BtnInvRegistrer.Enabled = True
        BtnInvSoke.Enabled = True
        InvAktivtProduktID = ""
        InvTomFelt()
        LblInvAktivProdukt.Text = "Ingen aktive produkt"
    End Sub

    Private Sub BtnInvTom_Click(sender As Object, e As EventArgs) Handles BtnInvTom.Click
        InvTomFelt()
    End Sub

    Private Sub CboInvKategori_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboInvKategori.SelectedIndexChanged
        'Setter Enabled false på ukurrante felt for utstyr
        If CboInvKategori.SelectedItem = "Utstyr" Then
            CboInvSubkategori.Enabled = False
            CboInvAvdeling.Enabled = False
            TxtInvRamme.Enabled = False
            TxtInvHjulstorrelse.Enabled = False
            TxtInvGirsystem.Enabled = False
            CboInvStatus.Enabled = False
            CboInvSkadet.Enabled = False
            CboInvSavnet.Enabled = False
        Else
            CboInvSubkategori.Enabled = True
            CboInvAvdeling.Enabled = True
            TxtInvRamme.Enabled = True
            TxtInvHjulstorrelse.Enabled = True
            TxtInvGirsystem.Enabled = True
            CboInvStatus.Enabled = True
            CboInvSkadet.Enabled = True
            CboInvSavnet.Enabled = True
        End If
    End Sub

    Private Sub BtnInvHent_Click(sender As Object, e As EventArgs) Handles BtnInvHent.Click
        'Henter data for objekt med inntastet ID fra database og legger i skjema

        BtnInvSoke.Enabled = False
        BtnInvRegistrer.Enabled = False


        Dim InvForhandlerIDSporring, InvAvdelingIDSporring, InvSubKategoriIDSporring,
            InvForhandlerID, InvAvdelingID, InvSubkategoriID, InvForhandler, InvAvdeling,
            InvSubkategori As String

        Dim InvSkadetBol, InvSavnetBol As Boolean

        Dim InvSqlHent As MySqlCommand
        Dim InvSqlDA As New MySqlDataAdapter
        Dim InvSqlLeser As MySqlDataReader
        Dim InvDatatable As New DataTable




        If TxtInvHentID.Text = "" Then
            MsgBox("Skriv inn et ID nummer")

        ElseIf CboInvKategori.SelectedItem = "Sykkel" Then

            InvAktivtProduktID = TxtInvHentID.Text.Trim
            LblInvAktivProdukt.Text = "Aktivt produkt ID: " & InvAktivtProduktID

            Dim InvHentSporring As String = "Select * FROM sykler WHERE sykkel_id ='" & InvAktivtProduktID & "';"

            InvSqlHent = New MySqlCommand(InvHentSporring, tilkobling)

            Try
                DBConnect()
                InvSqlDA.SelectCommand = InvSqlHent
                InvSqlDA.Fill(InvDatatable)
                DBDisconnect()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'Setter verdier i skjema basert på spørring. For fremmednøkler lagres ID for uthenting av navn.
            'Bool verdier lagres for setting av korrekt index i combobox
            Dim InvHentRad As DataRow
            Try
                For Each InvHentRad In InvDatatable.Rows
                    InvSubkategoriID = InvHentRad("type_id").ToString 'ID greie
                    InvAvdelingID = InvHentRad("avdeling_id").ToString 'og her må det noe til...
                    TxtInvProduktnavn.Text = InvHentRad("sykkel_navn")
                    TxtInvVareNummer.Text = InvHentRad("sykkel_modell")
                    TxtInvInnkjopspris.Text = InvHentRad("sykkel_pris")
                    TxtInvRamme.Text = InvHentRad("sykkel_ramme")
                    TxtInvHjulstorrelse.Text = InvHentRad("hjul_str")
                    TxtInvGirsystem.Text = InvHentRad("girsystem")
                    InvForhandlerID = InvHentRad("forhandler_id").ToString 'og her...
                    CboInvStatus.SelectedItem = InvHentRad("sykkel_status")
                    InvSkadetBol = InvHentRad("skadet")
                    InvSavnetBol = InvHentRad("savnet")
                Next
            Catch ex As Exception
                MsgBox("Innlegg av data i skjema: " & ex.Message)
            End Try

            InvForhandlerIDSporring = "SELECT forhandler_navn FROM forhandler WHERE forhandler_id='" & InvForhandlerID & "';"
            InvAvdelingIDSporring = "SELECT avd_navn FROM avdeling WHERE avdeling_id='" & InvAvdelingID & "';"
            InvSubKategoriIDSporring = "SELECT kategori FROM sykkel_typer WHERE type_id='" & InvSubkategoriID & "';"

            'Henter navn fra forhandler, avdeling og subkategori basert på ID 
            Try
                DBConnect()
                InvSqlHent = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
                InvSqlLeser = InvSqlHent.ExecuteReader()
                While InvSqlLeser.Read()
                    InvForhandler = InvSqlLeser("forhandler_navn")
                End While
                InvSqlLeser.Close()
                InvSqlHent = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
                InvSqlLeser = InvSqlHent.ExecuteReader()
                While InvSqlLeser.Read()
                    InvAvdeling = InvSqlLeser("avd_navn")
                End While
                InvSqlLeser.Close()
                InvSqlHent = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
                InvSqlLeser = InvSqlHent.ExecuteReader()
                While InvSqlLeser.Read()
                    InvSubkategori = InvSqlLeser("kategori")
                End While
                InvSqlLeser.Close()
                DBDisconnect()
            Catch ex As MySqlException
                MsgBox("Feil ved henting av navn:" & vbNewLine & ex.Message)
            End Try

            'Fyller inn resterende data i skjema 
            CboInvAvdeling.SelectedItem = InvAvdeling
            CboInvForhandler.SelectedItem = InvForhandler
            CboInvSubkategori.SelectedItem = InvSubkategori
            If InvSkadetBol = False Then
                CboInvSkadet.SelectedIndex = 0
            Else
                CboInvSkadet.SelectedIndex = 1
            End If
            If InvSavnetBol = False Then
                CboInvSavnet.SelectedIndex = 0
            Else
                CboInvSavnet.SelectedIndex = 1
            End If

            'SQØspørring innhenting av data for utstyr basert på valgt ID
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then

            InvAktivtProduktID = TxtInvHentID.Text.Trim
            LblInvAktivProdukt.Text = "Aktivt produkt ID: " & InvAktivtProduktID
            Dim InvHentSporring As String = "Select * FROM utstyr WHERE utstyr_id ='" & InvAktivtProduktID & "';"
            InvSqlHent = New MySqlCommand(InvHentSporring, tilkobling)

            Try
                DBConnect()
                InvSqlDA.SelectCommand = InvSqlHent
                InvSqlDA.Fill(InvDatatable)
                DBDisconnect()
            Catch ex As Exception
                MsgBox("Feil ved innhenting av data." & vbNewLine & ex.Message)
            End Try

            'Setter verdier i skjema basert på spørring. For fremmednøkler lagres ID for uthenting av navn.
            Dim InvHentRad As DataRow
            Try
                For Each InvHentRad In InvDatatable.Rows
                    TxtInvProduktnavn.Text = InvHentRad("utstyr_navn")
                    TxtInvVareNummer.Text = InvHentRad("varenummer")
                    TxtInvInnkjopspris.Text = InvHentRad("utstyr_pris")
                    InvForhandlerID = InvHentRad("forhandler_id").ToString
                Next
            Catch ex As Exception
                MsgBox("Innlegg av data i skjema: " & ex.Message)
            End Try

            InvForhandlerIDSporring = "SELECT forhandler_navn FROM forhandler WHERE forhandler_id='" & InvForhandlerID & "';"

            'Henter navn fra forhandler basert på ID 
            Try
                DBConnect()
                InvSqlHent = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
                InvSqlLeser = InvSqlHent.ExecuteReader()
                While InvSqlLeser.Read()
                    InvForhandler = InvSqlLeser("forhandler_navn")
                End While
                InvSqlLeser.Close()
                DBDisconnect()
            Catch ex As MySqlException
                MsgBox("Feil ved henting av navn:" & vbNewLine & ex.Message)
            End Try

            'Fyller inn resterende data i skjema 
            CboInvForhandler.SelectedItem = InvForhandler
        Else
            MsgBox("Velg kategori")
        End If


    End Sub


#End Region


#Region "InventarSearchTab"
    'Her plasseres kode som er relevant til Inventar Search Tab.
    'Variabler som brukes her skal begynne med Search. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "LogistikkTab"
    'Her plasseres kode som er relevant til Logistikk Tab.
    'Variabler som brukes her skal begynne med Logi. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "StatistikkTab"
    'Her plasseres kode som er relevant til Statistikk Tab.
    'Variabler som brukes her skal begynne med Stat. Dette er for å unngå klasj.
    'Husk kode kommentarer.
#End Region


#Region "AdminTab"
    'Her plasseres kode som er relevant til Admin Tab.
    'Variabler som brukes her skal begynne med Admin. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    Private Sub AdminNyBruker()
        Try
            DBConnect()
            Dim AdminAvdelingNavn As String = ""
            Dim AdminAdminStatus As Integer = 0
            If ChkAdminNBAdmin.Checked = True Then
                AdminAdminStatus = 1
            End If
            Dim AdminNyBruker2 As New MySqlCommand("INSERT INTO passord (passord_id, pwd, bruker_id) VALUES (" & LblBrukerIDNBVis.Text & ", '" & TxtAdminNBPassord.Text & "'," & LblBrukerIDNBVis.Text & ");", tilkobling)
            Dim AdminNyBruker3 As New MySqlCommand("UPDATE brukere SET passord_id = " & LblBrukerIDNBVis.Text & " WHERE bruker_id = " & LblBrukerIDNBVis.Text & ";", tilkobling)
            Dim AdminNyBruker4 As New MySqlCommand("SELECT avdeling_id FROM avdeling WHERE avd_navn ='" & CboAdminNBAvdeling.Text & "';", tilkobling)

            Dim AdminNyBrukerIDAdapter As New MySqlDataAdapter
            Dim AdminNyBrukerIDTable As New DataTable

            AdminNyBrukerIDAdapter.SelectCommand = AdminNyBruker4
            AdminNyBrukerIDAdapter.Fill(AdminNyBrukerIDTable)

            Dim AdminNyBrukerRow As DataRow

            For Each AdminNyBrukerRow In AdminNyBrukerIDTable.Rows
                AdminAvdelingNavn = AdminNyBrukerRow("avdeling_id")
            Next

            Dim AdminNyBruker1 As New MySqlCommand("INSERT INTO brukere (bruker_id, avdeling_id, stilling, fornavn, etternavn, timelonn, telefon, epost, stilling_prosent, admin) VALUES (" & LblBrukerIDNBVis.Text & "," & AdminAvdelingNavn & ",'" & CboAdminNBStilling.Text & "','" & TxtAdminNBFornavn.Text & "','" & TxtAdminNBEtternavn.Text & "'," _
                                                   & TxtAdminNBTime.Text & ",'" & TxtAdminNBTelefon.Text & "', '" & TxtAdminNBEpost.Text & "'," & CboAdminNBSP.Text & "," & AdminAdminStatus & ");", tilkobling)

            AdminNyBruker1.ExecuteNonQuery()
            AdminNyBruker2.ExecuteNonQuery()
            AdminNyBruker3.ExecuteNonQuery()

            DBDisconnect()
            TxtAdminNBPassord.Text = ""
            TxtAdminNBFornavn.Text = ""
            TxtAdminNBEtternavn.Text = ""
            TxtAdminNBTime.Text = ""
            TxtAdminNBEpost.Text = ""
            TxtAdminNBTelefon.Text = ""
            ChkAdminNBAdmin.Checked = False

            MsgBox("Ny Bruker Opprettet!")

        Catch AdminSqlError6 As MySqlException
            MsgBox("Man får ikke koble til databasen:  " & AdminSqlError6.Message)
        End Try
    End Sub

    Private Sub AdminEndreBruker()
        Try
            DBConnect()
            Dim AdminAvdelingNavn As String = ""
            Dim AdminAdminStatus As Integer = 0
            If ChkAdminNBAdmin.Checked = True Then
                AdminAdminStatus = 1
            End If

            Dim AdminEndreBruker3 As New MySqlCommand("UPDATE passord SET pwd ='" & TxtAdminEBPassord.Text & "' WHERE bruker_id = " & TxtAdminEBBID.Text & ";", tilkobling)
            Dim AdminEndreBruker4 As New MySqlCommand("SELECT avdeling_id FROM avdeling WHERE avd_navn ='" & CboAdminEBAvdeling.Text & "';", tilkobling)

            Dim AdminEndreBrukerIDAdapter As New MySqlDataAdapter
            Dim AdminEndreBrukerIDTable As New DataTable

            AdminEndreBrukerIDAdapter.SelectCommand = AdminEndreBruker4
            AdminEndreBrukerIDAdapter.Fill(AdminEndreBrukerIDTable)

            Dim AdminNyBrukerRow As DataRow

            For Each AdminNyBrukerRow In AdminEndreBrukerIDTable.Rows
                AdminAvdelingNavn = AdminNyBrukerRow("avdeling_id")
            Next

            Dim AdminEndreBruker1 As New MySqlCommand("UPDATE brukere SET avdeling_id=" & AdminAvdelingNavn & ", stilling='" & CboAdminEBStilling.Text & "', fornavn='" & TxtAdminEBFornavn.Text & "', etternavn='" & TxtAdminEBEtternavn.Text & "', timelonn=" & TxtAdminEBTime.Text & ", telefon='" & TxtAdminEBTelefon.Text & "', epost='" & TxtAdminEBEpost.Text & "', stilling_prosent=" & CboAdminEBSP.Text & ", admin=" & AdminAdminStatus & " WHERE bruker_id=" & TxtAdminEBBID.Text & ";", tilkobling)

            AdminEndreBruker1.ExecuteNonQuery()

            If TxtAdminEBPassord.Text = "" Then
            Else
                AdminEndreBruker3.ExecuteNonQuery()
            End If


            DBDisconnect()
            TxtAdminEBPassord.Text = ""
            TxtAdminEBFornavn.Text = ""
            TxtAdminEBEtternavn.Text = ""
            TxtAdminEBTime.Text = ""
            TxtAdminEBEpost.Text = ""
            TxtAdminEBTelefon.Text = ""
            ChkAdminEBAdmin.Checked = False

            MsgBox("Bruker Endret!")

        Catch AdminSqlError8 As MySqlException
            MsgBox("Man får ikke koble til databasen:  " & AdminSqlError8.Message)
        End Try
    End Sub
    Private Sub AdminLastInnEndreBruker()
        Try
            DBConnect()
            Dim AdminEBBIDKommando As New MySqlCommand("Select * FROM brukere WHERE bruker_id =" & TxtAdminEBBID.Text & ";", tilkobling)
            Dim AdminEBBIDAdapter As New MySqlDataAdapter
            Dim AdminEBBIDTable As New DataTable
            Dim AdminEBAvdelingID As String = ""
            AdminEBBIDAdapter.SelectCommand = AdminEBBIDKommando
            AdminEBBIDAdapter.Fill(AdminEBBIDTable)
            DBDisconnect()

            Dim AdminEBBIDRow As DataRow
            For Each AdminEBBIDRow In AdminEBBIDTable.Rows
                TxtAdminEBFornavn.Text = AdminEBBIDRow("fornavn")
                TxtAdminEBEtternavn.Text = AdminEBBIDRow("etternavn")
                TxtAdminEBTime.Text = AdminEBBIDRow("timelonn")
                TxtAdminEBEpost.Text = AdminEBBIDRow("epost")
                TxtAdminEBTelefon.Text = AdminEBBIDRow("telefon")
                CboAdminEBStilling.SelectedItem = AdminEBBIDRow("stilling")
                CboAdminEBSP.SelectedItem = AdminEBBIDRow("stilling_prosent")
                If AdminEBBIDRow("admin") = "1" Then
                    ChkAdminEBAdmin.Checked = True
                End If
                AdminEBAvdelingID = AdminEBBIDRow("avdeling_id")

            Next

            DBConnect()
            Dim AdminEBAvdelingKom As New MySqlCommand("SELECT avd_navn FROM avdeling WHERE avdeling_id =" & AdminEBAvdelingID & ";", tilkobling)
            Dim AdminEBAvdelingAdapter As New MySqlDataAdapter
            Dim AdminEBAvdelingTable As New DataTable

            AdminEBAvdelingAdapter.SelectCommand = AdminEBAvdelingKom
            AdminEBAvdelingAdapter.Fill(AdminEBAvdelingTable)
            DBDisconnect()

            Dim AdminEBAvdelingRow As DataRow

            For Each AdminEBAvdelingRow In AdminEBAvdelingTable.Rows
                CboAdminEBAvdeling.SelectedItem = AdminEBAvdelingRow("avd_navn")
            Next

            If TxtAdminEBFornavn.Text = "" Then
                MsgBox("Brukeren med ID: " & TxtAdminEBBID.Text & " eksisterer ikke.")
            End If
        Catch AdminSqlError7 As MySqlException
            MsgBox("Man får ikke koble til databasen:  " & AdminSqlError7.Message)
        End Try
    End Sub

    Private Sub AdminBrukerIDCalc()
        Try
            DBConnect()
            Dim AdminBrukerIDKommando As New MySqlCommand("Select COUNT(bruker_id) FROM brukere", tilkobling)
            Dim AdminBrukerIDAdapter As New MySqlDataAdapter
            Dim AdminBrukerIDTable As New DataTable
            AdminBrukerIDAdapter.SelectCommand = AdminBrukerIDKommando
            AdminBrukerIDAdapter.Fill(AdminBrukerIDTable)
            DBDisconnect()
            Dim AdminBrukerIDVerdi As Integer
            Dim AdminBrukerRow As DataRow
            For Each AdminBrukerRow In AdminBrukerIDTable.Rows
                AdminBrukerIDVerdi = AdminBrukerRow("COUNT(bruker_id)")
                LblBrukerIDNBVis.Text = (AdminBrukerIDVerdi + 1)
            Next

        Catch AdminSqlError3 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & AdminSqlError3.Message)

        End Try
    End Sub

    Private Sub AdminAvdelingPopulate()
        Try
            DBConnect()
            Dim AdminAvdelingKommando As New MySqlCommand("SELECT * FROM avdeling", tilkobling)
            Dim AdminAvdelingAdapter As New MySqlDataAdapter
            Dim AdminAvdelingTable As New DataTable
            AdminAvdelingAdapter.SelectCommand = AdminAvdelingKommando
            AdminAvdelingAdapter.Fill(AdminAvdelingTable)
            DBDisconnect()
            CboAdminNBAvdeling.Items.Clear()
            CboAdminEBAvdeling.Items.Clear()
            Dim AdminAvdelingRow As DataRow
            Dim AdminAvdelingString As String
            For Each AdminAvdelingRow In AdminAvdelingTable.Rows
                AdminAvdelingString = AdminAvdelingRow("avd_navn")
                CboAdminNBAvdeling.Items.Add(AdminAvdelingString)
                CboAdminEBAvdeling.Items.Add(AdminAvdelingString)
            Next

        Catch AdminSqlError1 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & AdminSqlError1.Message)

        End Try
    End Sub
    Private Sub AdminBSSokB_Click(sender As Object, e As EventArgs) Handles AdminBSSokB.Click
        Dim AdminSoekefelt, AdminSoekekategori As String
        AdminSoekefelt = TxtAdminBSFelt.Text
        AdminSoekekategori = CboAdminBSEtter.Text



        Try
            DBConnect()
            Dim AdminBrukerSearch As New MySqlCommand("SELECT * FROM brukere WHERE " & AdminSoekekategori & " LIKE '%" & AdminSoekefelt & "%'", tilkobling)
            Dim AdminSearchAdapter As New MySqlDataAdapter
            Dim AdminSearchTable As New DataTable
            AdminSearchAdapter.SelectCommand = AdminBrukerSearch
            AdminSearchAdapter.Fill(AdminSearchTable)
            DBDisconnect()
            Dim AdminRow As DataRow
            Dim AdminBSbruker_id, AdminBSfornavn, AdminBSetternavn, AdminBSsoekefelt As String
            LvAdminBS.Items.Clear()
            For Each AdminRow In AdminSearchTable.Rows
                AdminBSbruker_id = AdminRow("bruker_id")
                AdminBSfornavn = AdminRow("fornavn")
                AdminBSetternavn = AdminRow("etternavn")
                AdminBSsoekefelt = AdminRow(AdminSoekekategori)
                LvAdminBS.Items.Add(New ListViewItem({AdminBSbruker_id, AdminBSfornavn, AdminBSetternavn, AdminBSsoekefelt}))
            Next
        Catch AdminSqlError2 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & AdminSqlError2.Message)
        End Try

    End Sub

    Private Sub AdminMOTDEndreB_Click(sender As Object, e As EventArgs) Handles AdminMOTDEndreB.Click
        Try
            DBConnect()
            Dim AdminMOTDSet As New MySqlCommand("UPDATE message_of_the_day SET message = '" & TxtAdminMOTD.Text & "' WHERE message_id = 1;", tilkobling)
            AdminMOTDSet.ExecuteNonQuery()
            DBDisconnect()
            TxtAdminMOTD.Text = ""
            MsgBox("Message of the Day har blitt endret!")
            StartMOTDUpdate()
        Catch AdminSqlError4 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & AdminSqlError4.Message)
        End Try
    End Sub

    Private Sub AdminNBOpprettB_Click(sender As Object, e As EventArgs) Handles AdminNBOpprettB.Click
        AdminNyBruker()
        AdminBrukerIDCalc()
    End Sub

    Private Sub AdminEBLastInnB_Click(sender As Object, e As EventArgs) Handles AdminEBLastInnB.Click
        AdminLastInnEndreBruker()


    End Sub

    Private Sub AdminEBEndreB_Click(sender As Object, e As EventArgs) Handles AdminEBEndreB.Click
        AdminEndreBruker()
    End Sub









#End Region
End Class
