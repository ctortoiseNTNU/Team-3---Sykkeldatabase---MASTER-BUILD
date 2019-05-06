Imports MySql.Data.MySqlClient

Public Class Form1
#Region "GlobaleVariabler"
    'Her plasseres globale variabler
    'som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
    'Globale variabler som må sjekkes ved ønsket tilgang. LogBool settes til TRUE ved inlogging, AdminBool settes til TRUE hvis bruker er admin.

    Dim LogBool As Boolean = False
    Dim AdminBool As Boolean = False
    Dim FornavnString As String = ""
    Dim EtternavnString As String = ""
    Dim Tilkobling As MySqlConnection
    Dim InvAktivtProduktID As String
    Dim SecurityCounter As Integer = 0
    Dim StaTotalUtstyrKostnad As Integer = 0
    Dim StaTotalSykkelKostnad As Integer = 0
    Dim StaTotalUtleieInntekt As Integer = 0
    Dim StaTotalResultat As Integer = 0
    'Dim UtlAktivtUtleieID As String
    Dim UtlSisteUtleieID, UtlSykkelID, UtlKundeID As String
    Dim UtlValgteSyklerID, UtlValgtUtstyrID As New ArrayList



#End Region


#Region "GlobaleFunksjonerOgProsedyrer"
    'Her plasseres globale funksjoner og prosdyrer som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.

    Private Sub DBConnect()
        Tilkobling = New MySqlConnection(
        "Server=mysql-ait.stud.idi.ntnu.no;" _
        & "Database=colinft;" _
        & "Uid=colinft;" _
        & "Pwd=BJhYR1HS;")
        Try
            Tilkobling.Open()
        Catch ex As MySqlException
            MsgBox("Feil med tilkobling:" & ex.Message)
        End Try
    End Sub

    Private Sub DBDisconnect()
        Tilkobling.Close()
        Tilkobling.Dispose()
    End Sub

    Private Function SQLWhiteWash(ByVal StartString As String) As String
        Dim EndString As String
        EndString = StartString.Replace("'", "\'")
        Return EndString
    End Function

    Private Function CheckVarChar20(ByVal CheckString As String) As Boolean
        If CheckString.Length > 0 And CheckString.Length < 21 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckVarChar30(ByVal CheckString As String) As Boolean
        If CheckString.Length > 0 And CheckString.Length < 31 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckVarChar15(ByVal CheckString As String) As Boolean
        If CheckString.Length > 0 And CheckString.Length < 16 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function CheckIntValue(ByVal CheckString As String) As Boolean
        If CheckString.Length > 0 And CheckString.Length < 11 And IsNumeric(CheckString) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' SQL SELECT spørring som returnerer DataTable basert på søkekriterier.
    ''' </summary>
    ''' <param name="WhereTable">Tabell det skal søkes i</param>
    ''' <param name="WhereColumn">Kolonner som skal inkluderes i søkeresultat.
    ''' String = "column1, coulmn2, ..."''' </param>
    ''' <param name="WhereCriteria">Kriterier for søk. Angis med alle søkeparametre etter WHERE.
    ''' column1='value1' AND column2='value2' ...</param>
    ''' <returns>DataTabell med søkeresultat fra spørringen</returns>
    Private Function SQLSelect(ByVal WhereTable As String, WhereColumn As String, WhereCriteria As String)
        DBConnect()
        Dim SqlWhereKommando As New MySqlCommand("SELECT " & WhereColumn & " FROM " & WhereTable & " WHERE " _
                & WhereCriteria, Tilkobling)
        Dim SqlWhereAdapter As New MySqlDataAdapter
        Dim SqlWhereTable As New DataTable
        Try
            SqlWhereAdapter.SelectCommand = SqlWhereKommando
            SqlWhereAdapter.Fill(SqlWhereTable)
            Return SqlWhereTable
        Catch SQLex As MySqlException
            MsgBox("Feil ved søk (SELECT) i database:" & SQLex.Message)
            Return Nothing
        End Try
        DBDisconnect()
    End Function

    ''' <summary>
    ''' SQL INSERT spørring som legger til tuppel i valgt tabell
    ''' </summary>
    ''' <param name="InsertTable">Tabell det skal legges inn i</param>
    ''' <param name="InsertColumn">Kolonner som skal legges inn. Angis med parantes.
    ''' (column1, column2, ...)</param>
    ''' <param name="InsertValues">De verdier hver kolonne skal tillegges. Angis med parantes.
    ''' (value1, value2, ...)</param>
    Private Function SQLInsert(ByVal InsertTable As String, InsertColumn As String, InsertValues As String)
        Try
            DBConnect()

            Dim SqlCom As New MySqlCommand("INSERT INTO " & InsertTable & InsertColumn & " VALUES " &
                InsertValues, Tilkobling)
            SqlCom.ExecuteNonQuery()

            Dim SQLReader As MySqlDataReader
            Dim SisteID As String
            Dim SpSisteID = "SELECT LAST_INSERT_ID();"
            SqlCom = New MySqlCommand(SpSisteID, Tilkobling)
            SQLReader = SqlCom.ExecuteReader()
            While SQLReader.Read()
                SisteID = SQLReader(0)
            End While
            SQLReader.Close()

            DBDisconnect()
            Return SisteID
            MsgBox("Registrering (INSERT) vellykket")
        Catch SQLex As MySqlException
            MsgBox("Feil ved innlegg (INSERT) i database:" & vbNewLine & SQLex.Message)
            Return Nothing
        End Try
    End Function

    ''' <summary>
    ''' SQL UDATE spørring som oppdaterer tuppler i tabell
    ''' </summary>
    ''' <param name="UpdateTable">Tabell som skal oppdateres</param>
    ''' <param name="UpdateValues">Kolonner og verdier som skal legges inn i valgte kolonner.
    ''' column1='value1', column2='value2', ...</param>
    ''' <param name="UpdateCriteria">Kriterier for oppdateringen. Alt som kommer etter WHERE.
    ''' column1=ID_number ...</param>
    Public Sub SQLUpdate(ByVal UpdateTable As String, UpdateValues As String, UpdateCriteria As String)
        DBConnect()
        Dim SqlCom As New MySqlCommand("UPDATE " & UpdateTable & " SET " & UpdateValues & " WHERE " _
                                       & UpdateCriteria, Tilkobling)
        Try
            SqlCom.ExecuteNonQuery()
            MsgBox("Oppdatering vellykket.")
        Catch SQLex As Exception
            MsgBox("Feil ved oppdatering (UPDATE) database:" & vbNewLine & SQLex.Message)
        End Try
        DBDisconnect()
    End Sub

    ''' <summary>
    ''' SQL DELETE spørring som sletter data fra tabell ut i fra valgte kriterier
    ''' </summary>
    ''' <param name="DeleteTable">Tabell det skal slettes fra</param>
    ''' <param name="DeleteCriteria">Kriterier for slettingen. Alt etter WHERE.
    ''' coulmn1='ID_number' AND column1='value1' ...</param>
    Public Sub SQLDelete(ByVal DeleteTable As String, DeleteCriteria As String)
        DBConnect()
        Dim SqlCom As New MySqlCommand("DELETE FROM " & DeleteTable & " WHERE " & DeleteCriteria, Tilkobling)
        Try
            SqlCom.ExecuteNonQuery()
        Catch SQLex As Exception
            MsgBox("Feil ved sletting (DELETE) i database:" & vbNewLine & SQLex.Message)
        End Try
        DBDisconnect()
    End Sub

    ''' <summary>
    ''' SQL spørring for å hente ut navn ut i fra ID, og motsatt, for fremmednøkler i tabeller.
    ''' </summary>
    ''' <param name="Tabell">Tabellen det skal FRA</param>
    ''' <param name="KolonneInn">Navn eller ID (kolonne) det skal hentes FRA</param>
    ''' <param name="KolonneUt">Navn eller ID (kolonne) som skal hentes UT</param>
    ''' <param name="VerdiInn">Navn eller ID på tuppel som det gjelder</param>
    ''' <returns>Navn eller ID</returns>
    Private Function SQLHentIDNavn(ByVal Tabell As String, KolonneInn As String, KolonneUt As String, VerdiInn As String)
        Dim SqlCom As MySqlCommand
        Try
            DBConnect()
            Dim Result As String
            SqlCom = New MySqlCommand("SELECT " & KolonneUt & " FROM " & Tabell &
            " WHERE " & KolonneInn & "='" & VerdiInn & "'", Tilkobling)
            Dim SqlRead As MySqlDataReader
            SqlRead = SqlCom.ExecuteReader
            While SqlRead.Read()
                Result = SqlRead(KolonneUt)
            End While
            SqlRead.Close()
            DBDisconnect()
            Return Result
        Catch ex As MySqlException
            MsgBox("Feil ved henting av navn/ID:" & vbNewLine & ex.Message)
            Return Nothing
        End Try
    End Function


    ''' <summary>
    ''' Autopopulasjon av ComboBox. Elementer hentes fra kolonne i database.
    ''' </summary>
    ''' <param name="sender">Combobox som sender forespørsel. ... ComboBox1(_sender_ As Object...</param>
    ''' <param name="Tabell">Tabell kolonnen befinner seg i</param>
    ''' <param name="Kolonne">Kolonnen som skal fylle ComboBoxen</param>
    Private Sub AutoPopCbo(ByVal sender As Object, Tabell As String, Kolonne As String)
        Try
            DBConnect()
            Dim SqlCom As New MySqlCommand("SELECT " & Kolonne & " FROM " & Tabell & " WHERE 1", Tilkobling)
            Dim SqlDA As New MySqlDataAdapter
            Dim ComboDaT As New DataTable
            SqlDA.SelectCommand = SqlCom
            SqlDA.Fill(ComboDaT)
            DBDisconnect()
            sender.Items.Clear()
            For Each r In ComboDaT.Rows
                sender.Items.Add(r(Kolonne))
            Next
        Catch ex As MySqlException
            MsgBox("Feil med autoutfylling av combobox" & ex.Message)
        End Try
    End Sub

    Private Sub AutoPopCboSpesific(ByVal sender As Object, Tabell As String, Kolonne As String, combo As Object)
        Try
            DBConnect()
            Dim SqlCom As New MySqlCommand("SELECT " & Kolonne & " FROM " & Tabell & " WHERE 1", Tilkobling)
            Dim SqlDA As New MySqlDataAdapter
            Dim ComboDaT As New DataTable
            SqlDA.SelectCommand = SqlCom
            SqlDA.Fill(ComboDaT)
            DBDisconnect()
            combo.Items.Clear()
            For Each r In ComboDaT.Rows
                combo.Items.Add(r(Kolonne))
            Next
        Catch ex As MySqlException
            MsgBox("Feil med autoutfylling av " & CStr(combo) & ": " & ex.Message)
        End Try
    End Sub

#End Region


#Region "Form Load og Login"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'With HovedTab.TabPages

        '    .Remove(StartTab)
        '    .Remove(UtleieTab)
        '    .Remove(KDTab)
        '    .Remove(InventarTab)
        '    .Remove(LogiTab)
        '    .Remove(StatTab)
        '    .Remove(AdminTab)
        '    .Remove(DBAdminTab)
        '    HovedTab.SelectedTab = LoginTab

        'End With


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
                'StartMOTDUpdate()

            Case 2 'Bestemmer det som skjer etter man har valgt Utleiemeny.
                Dim dato As Date = Date.Today
                LblUtleieSelger.Text = FornavnString & " " & EtternavnString
                LblUtleieDatoTxt.Text = dato
                'LblUtleieKlokke.Text = TimeOfDay
                Me.CboUtlAvd.SelectedIndex = 2

            Case 3 'Bestemmer det som skjer etter man har valgt Kundedatabasemeny.
                CboKndSok.Items.Clear()

                Dim innhold = New String() {"ID", "Fornavn", "Etternavn", "Adresse", "Telefon", "Epost", "Rabatt Tier", "Handlet For"}

                For i As Integer = 0 To innhold.Length - 1
                    CboKndSok.Items.Add(innhold(i))
                Next
                BtnKndEndre.Enabled = False

            Case 4 'Bestemmer det som skjer etter man har valgt Inventarmeny.
                AutoPopCbo(CboInvForhandler, "forhandler", "forhandler_navn")
                AutoPopCbo(CboInvAvdeling, "avdeling", "avd_navn")


            Case 5 'Bestemmer det som skjer etter man har valgt Logistikkmeny.

            Case 6 'Bestemmer det som skjer etter man har valgt Statistikkmeny.
                AutoPopCbo(CboStaAvdeling, "avdeling", "avd_navn")
                CboStaAvdeling.Items.Add("")
                AutoPopCbo(CboStaType, "sykkel_typer", "kategori")
                CboStaType.Items.Add("")
                StaMestPopulaer()
                StaTotalSykkelPris()
                StaTotalUtsyrPris()
                StaTotalUtleie()
                StaTotalAvanse()


            Case 7 'Bestemmer det som skjer etter man har valgt Adminmeny.
                MsgBox("AdminMeny")
                AdminAvdelingPopulate()
                AdminBrukerIDCalc()

            Case 8 'Bestemmer det som skjer etter man har valgt AdminDBmeny.
                MsgBox("AdminDBMeny")

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
            Dim StartMOTDKommando As New MySqlCommand("Select * FROM message_of_the_day WHERE message_id = 1", Tilkobling)
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

    'Utstyr tilgjengelig for valgt sykkel kan legges i combobox som populeres automatisk ?
    'If Kategori utstyr Then remove from utstyr else from sykkel  - overføring tilfra Lv


    '----------------TEST------------------
    Private Sub UtlTESTlbl_Click(sender As Object, e As EventArgs) Handles UtlTESTlbl.Click

        'UtlTESTlbl.Text = LvUtleieKunde.Items(LvUtleieKunde.FocusedItem.Index).SubItems(0).Text
        Dim UtlLeieLengde

        'Dim lengde = String.Format("%d", aaa)
        UtlLeieLengde = UtlDtpUtleieFra.Value.Subtract(UtlDtpUtleieTil.Value).ToString("%d")
        UtlTESTlbl.Text = UtlLeieLengde

    End Sub

    'Setter kundeID for bestilling
    Private Sub LvUtleieKunde_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LvUtleieKunde.SelectedIndexChanged
        UtlKundeID = LvUtleieKunde.Items(LvUtleieKunde.FocusedItem.Index).SubItems(0).Text
        LblUtlAktivKundeID.Text = "Aktiv Kunde-ID: " & UtlKundeID
    End Sub

    'Sorterer listview etter kolonne som klikkes
    Private Sub LvUtlVarer_Sort(sender As Object, e As EventArgs) Handles LvUtlVarer.ColumnClick
        ColumnClick(sender, e)
    End Sub

    'Sorterer listview etter kolonne som klikkes
    Private Sub LvUtleieOrdre_Sort(sender As Object, e As EventArgs) Handles LvUtleieOrdre.ColumnClick
        ColumnClick(sender, e)
    End Sub

    'Prosedyre for reset
    Private Sub UtleieTomFelt()
        CboUtlKat.SelectedIndex = -1
        CboUtlRabatt.SelectedIndex = -1
        CboUtlSubkat.SelectedIndex = -1
        CboUtlRamme.SelectedIndex = -1
        TxtUtlAntall.Text = ""
        TxtUtleieKundeSok.Text = ""
        RdbUtlTimer.Checked = False
        RdbUtlDager.Checked = False
        RdbUtlUke.Checked = False
        UtlDtpUtleieFra.Value = Now
        UtlDtpUtleieTil.Value = Now
        LvUtleieKunde.Items.Clear()
        LvUtleieOrdre.Items.Clear()
        LvUtlVarer.Items.Clear()
        LblUtlAktivKundeID.Text = "Aktiv Kunde-ID: "
        LblUtlAktivKundeID = Nothing
    End Sub

    'Klokke
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblUtleieKlokke.Text = Format(Now, "HH:mm:ss")
    End Sub

    'Kundesøk
    Private Sub BtnUtleieKundeSok_Click(sender As Object, e As EventArgs) Handles BtnUtleieKundeSok.Click

        Dim Kunde_ID, Kunde_Fornavn, Kunde_Etternavn, Kunde_Adresse, Kunde_Tlf, Kunde_Epost, Kunde_rabatt, UtlKndSok As String
        Dim UtlMsgBoxNyKunde As MsgBoxResult

        LvUtleieKunde.Items.Clear()

        If IsNumeric(TxtUtleieKundeSok.Text) And TxtUtleieKundeSok.Text <> "" And TxtUtleieKundeSok.Text.Length >= 8 Then
            UtlKndSok = SQLWhiteWash(TxtUtleieKundeSok.Text)
        Else
            MsgBox("Vennligst skriv inn et gyldig mobilnummer, minst 8 siffer")
            TxtUtleieKundeSok.Clear()
        End If

        Dim UtleieSokTable As DataTable
        UtleieSokTable = SQLSelect("kunder", "*", "telefon='" & UtlKndSok & "'")

        Try
            'Sjekker om datatable gir et tomt svar.
            'Gir beskjed om kunde ikke finnes fra før, og hopper til kundemenyen om det ønskes å registere ny kunde.
            If UtleieSokTable.Rows.Count = 0 And TxtUtleieKundeSok.Text <> "" Then
                UtlMsgBoxNyKunde = MsgBox("Ingen kunder med dette nummeret er registrert." & vbNewLine _
                                          & "Registrer ny kunde med telefonnummer " & TxtUtleieKundeSok.Text _
                                          & " ?", MsgBoxStyle.OkCancel)
                If UtlMsgBoxNyKunde = DialogResult.OK Then
                    BtnUtleieNyKunde.PerformClick()
                End If
            Else
                LvUtleieKunde.Items.Clear()
                For Each r In UtleieSokTable.Rows
                    Kunde_ID = r("kunde_id")
                    Kunde_Fornavn = r("kunde_fornavn")
                    Kunde_Etternavn = r("kunde_etternavn")
                    Kunde_Adresse = r("adresse")
                    Kunde_Tlf = r("telefon")
                    Kunde_Epost = r("epost")
                    Kunde_rabatt = r("rabatt_id")
                    LvUtleieKunde.Items.Add(New ListViewItem({Kunde_ID, Kunde_Fornavn, Kunde_Etternavn, Kunde_Adresse,
                                                             Kunde_Tlf, Kunde_Epost, Kunde_rabatt}))
                Next
            End If
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        End Try

    End Sub

    'Søker på varer
    Private Sub BtnUtlAddVare_Click(sender As Object, e As EventArgs) Handles BtnUtlAddVare.Click
        LvUtlVarer.Items.Clear()
        varehent()
    End Sub

    Private Sub UtleieFullfør()

        Dim UtlAvdelingID, UtlBetalingsType, UtlRabattID, UtlPris, UtlDatoSlutt, UtlDatoStart,
                UtlRabatt, UtlSisteUtleieID, UtlUtstyrPris, UtlLeieLengde As String
        Dim UtlAvgittRabatt, UtlAntall As Integer
        Dim UtlRabattDT, UtlKatPris, UtlRabattIDDT As DataTable

        'pris = sykkel_kat from sykkel_id , and pris_dag if dag pris_uke if uke etc
        UtlAvdelingID = SQLHentIDNavn("avdeling", "avd_navn", "avdeling_id", CboUtlAvd.SelectedItem)
        UtlKundeID = LvUtleieKunde.Items(LvUtleieKunde.FocusedItem.Index).SubItems(0).Text 'bytt med onclick og lagrei i var
        UtlRabattIDDT = SQLSelect("kunder", "rabatt_id", "kunde_id='" & UtlKundeID & "'")
        For Each r In UtlRabattIDDT.Rows
            UtlRabattID = r("rabatt_id")
        Next
        UtlRabattDT = SQLSelect("rabatter join kunder as k on rabatter.rabatt_id=k.rabatt_id", "rabatt_prosenter", "k.kunde_id='" _
                                & UtlKundeID & "'")
        For Each r In UtlRabattDT.Rows
            UtlRabatt = r("rabatt_prosenter")
        Next
        UtlDatoSlutt = UtlDtpUtleieTil.Value
        UtlDatoStart = UtlDtpUtleieFra.Value
        UtlPris = 0
        UtlBetalingsType = "Vipps"
        UtlAntall = TxtUtlAntall.Text.Trim

        'UtlLeieLengde = UtlDtpUtleieTil.Value.Subtract(UtlDtpUtleieFra.Value).ToString("%d") 

        For i = 0 To UtlValgteSyklerID.Count - 1
            UtlKatPris = SQLSelect("sykkel_typer join sykler as s on sykkel_typer.type_id=s.type_id",
                "sykkel_kat_timepris, sykkel_kat_dognpris, sykkel_kat_ukepris", "s.sykkel_id='" & UtlValgteSyklerID(i) & "'")
            For Each r In UtlKatPris.Rows
                If RdbUtlTimer.Checked Then
                    UtlPris += r("sykkel_kat_timepris")
                ElseIf RdbUtlDager.Checked Then
                    UtlPris += r("sykkel_kat_dognpris")
                ElseIf RdbUtlUke.Checked Then
                    UtlPris += r("sykkel_kat_ukepris")
                Else
                    MsgBox("velg leietid")
                End If
            Next
        Next

        'Hardkodet pris på utstyr som bør være en variabel hentet fra database, med mulighet for endring i programmet som admin.
        UtlUtstyrPris = 50
        UtlPris += UtlValgtUtstyrID.Count * UtlUtstyrPris
        UtlPris = (UtlPris * UtlAntall) * ((100 - UtlRabatt) / 100)
        UtlAvgittRabatt = UtlPris * (UtlRabatt / 100)

        If UtlKundeID = "" Or UtlAvdelingID = "" Or UtlRabattID = "" Or UtlValgteSyklerID.Count < 1 _
            And UtlValgtUtstyrID.Count < 1 Then
            MsgBox("Vennligst ferdigstill bestillingsinfo.")
            Exit Sub
        Else
            LblUtleieSum.Text = UtlPris
            LblUtlRabatt.Text = UtlAvgittRabatt
            UtlSisteUtleieID = SQLInsert("utleie", "(utleie_id, avdeling_id, kunde_id, rabatt_id, utleie_pris, utleie_slutt, " _
                                   & "utleie_start, betalings_type)", "(DEFAULT, '" & UtlAvdelingID & "', '" & UtlKundeID _
                                   & "', '" & UtlRabattID & "', '" & UtlPris & "', '" _
                                   & UtlDtpUtleieTil.Value.ToString("yyyy-MM-dd") & "', '" _
                                   & UtlDtpUtleieFra.Value.ToString("yyyy-MM-dd") & "', '" & UtlBetalingsType & "')")

            For i = 0 To UtlValgtUtstyrID.Count - 1
                SQLInsert("utleie_utstyr", "(utleie_utstyr_id, utleie_id, utstyr_id)", "(DEFAULT, '" & UtlSisteUtleieID _
                          & "', '" & UtlValgtUtstyrID(i) & "')")
                SQLUpdate("utstyr", "utstyr_status='Utleid'", "utstyr_id='" & UtlValgteSyklerID(i) & "'")
            Next
            For i = 0 To UtlValgteSyklerID.Count - 1
                SQLInsert("utleie_sykkel", "(utleie_sykkel_id, utleie_id, sykkel_id)", "(DEFAULT, '" & UtlSisteUtleieID _
                          & "', '" & UtlValgteSyklerID(i) & "')")
                SQLUpdate("sykler", "sykkel_status='Utleid'", "sykkel_id='" & UtlValgteSyklerID(i) & "'")
            Next
        End If

    End Sub

    Private Sub BtnUtleieFullfør_Click(sender As Object, e As EventArgs) Handles BtnUtleieFullfør.Click
        Dim UtlBekreftUtleie As New MsgBoxResult
        UtlBekreftUtleie = MsgBox("Bekreft bestilling.", MsgBoxStyle.OkCancel)

        If UtlBekreftUtleie = DialogResult.OK Then
            UtleieFullfør()
        Else
            Exit Sub
        End If

    End Sub


    'trykk for å kopiere varer fra vareliste til ordre liste
    Private Sub LvUtlVarer_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LvUtlVarer.MouseClick

        LvUtleieOrdre.Items.Add(LvUtlVarer.SelectedItems(0).Clone())
        If CboUtlKat.SelectedItem = "Sykkel" Then

            UtlValgteSyklerID.Add(LvUtlVarer.Items(LvUtlVarer.FocusedItem.Index).SubItems(0).Text)

        ElseIf CboUtlKat.SelectedItem = "utstyr" Then

            UtlValgtUtstyrID.Add(LvUtlVarer.Items(LvUtlVarer.FocusedItem.Index).SubItems(0).Text)

        Else
            MsgBox("velg kategori")
        End If

    End Sub


    ' trykk for å fjerne linjer fra ordre
    Private Sub LvUtlOrdre_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LvUtleieOrdre.MouseClick

        Dim UtlFjernID As String = LvUtleieOrdre.Items(LvUtleieOrdre.FocusedItem.Index).SubItems(0).Text

        UtlTESTlbl.Text = UtlFjernID   'TESTLABEL

        'If Kategori utstyr Then remove from utstyr else from sykkel
        'if colonne kategori(utstyr/sykkel) = utstyr/sykkel then remove from utstyr/sykkel
        UtlValgteSyklerID.Remove(UtlFjernID)
        LvUtleieOrdre.Items.RemoveAt(LvUtleieOrdre.SelectedIndices(0))



    End Sub


    Private Sub varehent()

        'fyller varelistv. med data fra valgte bokser.
        '''''''''''''''''''''''''''FROM          WHERE         SELECT    =    
        'String = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", verdi)

        Dim UtlKategori As String = CboUtlKat.SelectedItem
        Dim UtlSubKategori As String = CboUtlSubkat.SelectedItem
        Dim UtlRamme As String = CboUtlRamme.SelectedItem
        Dim UtlHjulStr As String = ""  'combobox select
        Dim UtlSubkatID, UtlSykkelIDRamme As String
        'Dim SykkelSQLKolonner = New String() {"sykkel_modell", "sykkel_navn", "sykkel_status", "kategori",
        ' "sykkel_kat_timepris", "sykkel_kat_døgnpris", "sykkel_kat_ukepris"}

        'henter typeID fra sykler og utstyr etter data fra subkategori
        'hente varenummer fra sykler med valgt ramme og hjul

        If UtlKategori = "Sykkel" Then
            UtlSubkatID = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", UtlSubKategori)
            UtlSykkelIDRamme = SQLHentIDNavn("sykler", "type_id", "sykkel_id", UtlSubkatID)   '?????
            'SykkelIdHjul = SQLHentIDNavn("sykler", "type_id", "sykkel_id", UtlSubkatID)

            Dim VareSokTable As New DataTable

            'for søk på ramme og hjulstr
            VareSokTable = SQLSelect("sykler join avdeling as a on sykler.avdeling_id=a.avdeling_id",
                                     "sykler.*, a.avd_navn", "type_id LIKE '%" & UtlSubkatID & "%' AND hjul_str LIKE'%" _
                                     & UtlHjulStr & "%' AND sykkel_ramme LIKE '%" & UtlRamme & "%' AND sykkel_status='ledig' " _
                                     & "AND NOT skadet='1' AND NOT savnet='1'")

            Dim UtlSokVareID, UtlSokVarenavn, UtlSokRamme, UtlSokHjulStr, UtlSokTilgjengelig, UtlSokAvdelingID,
                UtlSokAvdelingNavn As String
            Try
                For Each r In VareSokTable.Rows
                    If VareSokTable.Rows.Count = 0 Then
                        MsgBox("Ingen ledige sykler for dette søket.")
                    Else
                        UtlSokVareID = r("sykkel_id")
                        UtlSokVarenavn = r("sykkel_navn")
                        UtlSokRamme = r("sykkel_ramme")
                        UtlSokHjulStr = r("hjul_str")
                        UtlSokTilgjengelig = r("sykkel_status")
                        UtlSokAvdelingID = r("avdeling_id")
                        UtlSokAvdelingNavn = r("avd_navn")

                        LvUtlVarer.Items.Add(New ListViewItem({UtlSokVareID, UtlSokVarenavn, UtlSokRamme,
                             UtlSokHjulStr, UtlSokTilgjengelig, UtlSokAvdelingNavn, UtlKategori}))
                    End If
                Next
            Catch ex As Exception
                MsgBox("Feil med varetabell: " & ex.Message)
            End Try

        ElseIf UtlKategori = "Utstyr" Then

            UtlSubkatID = SQLHentIDNavn("utstyr_kategori", "utstyr_kat", "utstyr_kat_id", UtlSubKategori)

            Dim UtlUtstyrID, UtlUtstyrNavn, UtlUtstyrStatus As String
            Dim UtlVareSokDT As DataTable
            UtlVareSokDT = SQLSelect("utstyr", "utstyr_id, utstyr_navn, utstyr_status", "utstyr_id='" _
                                     & UtlSubkatID & "'")

            Try
                For Each r In UtlVareSokDT.Rows
                    UtlUtstyrID = r("utstyr_id")
                    UtlUtstyrNavn = r("utstyr_navn")
                    UtlUtstyrStatus = r("utstyr_status")
                    LvUtlVarer.Items.Add(New ListViewItem({UtlUtstyrID, UtlUtstyrNavn, "", "", UtlUtstyrStatus, "", "Utstyr"}))
                Next
            Catch ex As Exception
                MsgBox("Feil ved henting av data for utstyr fra datatabell." & vbNewLine & ex.Message)
            End Try

        Else
            MsgBox("Du har ikke valgt gategori din luring.")
            Exit Sub
        End If

    End Sub

    'hopp til kundetab. og ta med telefonnr
    Private Sub BtnUtleieNyKunde_Click(sender As Object, e As EventArgs) Handles BtnUtleieNyKunde.Click
        HovedTab.SelectTab(KDTab)
        TxtKndTlf.Text = TxtUtleieKundeSok.Text
    End Sub

    'tøm felt knappen
    Private Sub BtnUtlAbort_Click(sender As Object, e As EventArgs) Handles BtnUtlAbort.Click
        UtleieTomFelt()
    End Sub

    'Fyller combobox med avdelinger som er registrert i database
    Private Sub CboUtlAvd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboUtlAvd.DropDown
        AutoPopCbo(sender, "avdeling", "avd_navn")
    End Sub

    'Autofyll av ramme combobox fra database.
    'Denne henter ramme fra valgt sykkeltype
    'Private Sub CboUtlRamme_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboUtlRamme.SelectedIndexChanged
    '    CboUtlRamme.SelectedIndex = -1
    '    UtlAutoPopRamme()

    'End Sub

    'Endrer innhold i combobox for subkategori og ramme avhenging om det er sykkel eller utstyr som er valgt.
    Private Sub CboUtlKat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboUtlKat.SelectedIndexChanged
        'Dropdownlisten Subkategori endrer kategorier (leses fra databasen) _
        'basert på om det er sykkel eller utstyr som er valgt.
        'ramme og hjul valg deaktiveres om det er valgt utstyr.

        If CboUtlKat.SelectedItem = "Utstyr" Then
            CboUtlRamme.Enabled = False
            CboUtlSubkat.Items.Clear()
            CboUtlRamme.Items.Clear()
            'UtlAutoPopUtstyr()
            AutoPopCbo(CboUtlSubkat, "utstyr_kategori", "utstyr_kat")
        Else
            CboUtlRamme.Enabled = True
            CboUtlSubkat.Items.Clear()
            CboUtlRamme.Items.Clear()
            AutoPopCbo(CboUtlSubkat, "sykkel_typer", "kategori")
            AutoPopCbo(CboUtlRamme, "sykler", "sykkel_ramme")
            'UtlAutoPopSykkel()
        End If

    End Sub

    'Fyller combobox for ramme etter valgt kategori
    Private Sub CboUtlSubkat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboUtlRamme.DropDown
        If CboUtlKat.SelectedItem = "Sykkel" Then
            Dim sykkelkatnavn = CboUtlSubkat.SelectedItem
            Dim sykkelkatID As String = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", sykkelkatnavn)
            CboUtlRamme.Items.Clear()
            Dim rammedat As DataTable
            If CboUtlSubkat.SelectedIndex = -1 Then
                rammedat = SQLSelect("sykler", "DISTINCT sykkel_ramme", "1")
            Else
                rammedat = SQLSelect("sykler", "DISTINCT sykkel_ramme", "type_id='" & sykkelkatID & "'") '"type_id='" & sykkelkatID & "'")
            End If
            If rammedat IsNot Nothing AndAlso rammedat.Rows.Count > 0 Then
                For Each r In rammedat.Rows
                    CboUtlRamme.Items.Add(r("sykkel_ramme"))
                Next
            Else
            End If
        End If
    End Sub

    'Metode som fyller combobox (som kaller) med data fra database. ----------OVerflødig
    'Tabell og kolonne det skal leses fra må angis som argumenter.
    'Private Sub UtlAutoPopCbo(sender, tabell, kolonne)

    '    Try
    '        DBConnect()
    '        Dim UtlSqlCom As New MySqlCommand("SELECT " & kolonne & " FROM " & tabell, Tilkobling)
    '        Dim UtlSqlDA As New MySqlDataAdapter
    '        Dim UtlUtstyrComboDaT As New DataTable
    '        UtlSqlDA.SelectCommand = UtlSqlCom
    '        UtlSqlDA.Fill(UtlUtstyrComboDaT)
    '        DBDisconnect()
    '        sender.Items.Clear()
    '        Dim UtlUtstyrRow As DataRow
    '        Dim UtlUtstyrString As String
    '        For Each UtlUtstyrRow In UtlUtstyrComboDaT.Rows
    '            UtlUtstyrString = UtlUtstyrRow(kolonne)
    '            sender.Items.Add(UtlUtstyrString)
    '        Next
    '    Catch ex As MySqlException
    '        MsgBox("Feil med autoutfylling av " & CStr(sender) & ": " & ex.Message)
    '    End Try
    'End Sub

    'Combobox Subkategori styres av indexchanged på combobox kategori. Dermed vil et kall på UtlCboPop fra _
    'combobox for kategori føre til endringer i kategori og ikke subkategori som ønsket.
    'Derfor egne autopopulate for sykkel og utstyr.

    'Private Sub UtlAutoPopUtstyr()
    '    Try
    '        DBConnect()
    '        Dim UtlSqlCom As New MySqlCommand("SELECT utstyr_kat FROM utstyr_kategori", Tilkobling)
    '        Dim UtlSqlDA As New MySqlDataAdapter
    '        Dim UtlUtstyrComboDaT As New DataTable
    '        UtlSqlDA.SelectCommand = UtlSqlCom
    '        UtlSqlDA.Fill(UtlUtstyrComboDaT)
    '        DBDisconnect()
    '        CboUtlSubkat.Items.Clear()
    '        Dim UtlUtstyrRow As DataRow
    '        Dim UtlUtstyrString As String
    '        For Each UtlUtstyrRow In UtlUtstyrComboDaT.Rows
    '            UtlUtstyrString = UtlUtstyrRow("utstyr_kat")
    '            CboUtlSubkat.Items.Add(UtlUtstyrString)
    '        Next
    '    Catch ex As MySqlException
    '        MsgBox("Feil med autoutfylling av utstyrskategorier: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub UtlAutoPopSykkel()
    '    Try
    '        DBConnect()
    '        Dim UtlSqlCom As New MySqlCommand("SELECT kategori FROM sykkel_typer", Tilkobling)
    '        Dim UtlSqlDA As New MySqlDataAdapter
    '        Dim UtlSykkelComboDaT As New DataTable
    '        UtlSqlDA.SelectCommand = UtlSqlCom
    '        UtlSqlDA.Fill(UtlSykkelComboDaT)
    '        DBDisconnect()
    '        CboUtlSubkat.Items.Clear()
    '        Dim UtlSykkelRow As DataRow
    '        Dim UtlSykkelString As String
    '        For Each UtlSykkelRow In UtlSykkelComboDaT.Rows
    '            UtlSykkelString = UtlSykkelRow("kategori")
    '            CboUtlSubkat.Items.Add(UtlSykkelString)
    '        Next
    '    Catch ex As MySqlException
    '        MsgBox("Feil med autoutfylling av sykkelkategorier: " & ex.Message)
    '    End Try
    'End Sub

    'Private Sub UtlAutoPopRamme()

    '    Dim UtlSubKategori As String = CboUtlSubkat.SelectedItem
    '    Dim UtlSubkatID = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", UtlSubKategori)
    '    Try
    '        DBConnect()

    '        Dim UtlSqlCom As New MySqlCommand("SELECT sykkel_ramme FROM sykler 
    '                                            WHERE type_id =" & UtlSubkatID & "", Tilkobling)
    '        Dim UtlSqlDA As New MySqlDataAdapter
    '        Dim UtlRammeComboDaT As New DataTable
    '        UtlSqlDA.SelectCommand = UtlSqlCom
    '        UtlSqlDA.Fill(UtlRammeComboDaT)
    '        DBDisconnect()
    '        CboUtlRamme.Items.Clear()
    '        Dim UtlRammeRow As DataRow
    '        Dim UtlRammeString As String
    '        For Each UtlRammeRow In UtlRammeComboDaT.Rows
    '            UtlRammeString = UtlRammeRow("sykkel_ramme")
    '            CboUtlRamme.Items.Add(UtlRammeString)
    '        Next
    '    Catch ex As MySqlException
    '        MsgBox("Feil med autoutfylling av utstyrskategorier: " & ex.Message)
    '    End Try
    'End Sub


#End Region


#Region "KundeTab"
    'Her plasseres kode som er relevant til Kunde Tab.
    'Variabler som brukes her skal begynne med Kunde. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    Private Sub LvKndSok_Sort(sender As Object, e As EventArgs) Handles LvKndSok.ColumnClick
        ColumnClick(sender, e)
    End Sub

    Private Sub TxtKndTlf_TextChanged(sender As Object, e As KeyPressEventArgs) Handles TxtKndTlf.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub


    'Registrer ny kunde
    Private Sub BtnKndRegistrer_Click(sender As Object, e As EventArgs) Handles BtnKndRegistrer.Click

        Dim KnDFdato As Date = DateKndReg.Value
        Dim KndFornavn = TxtKndFornavn.Text
        Dim KndEtternavn = TxtKndEtternavn.Text
        Dim KndAdresse = TxtKndAdresse.Text
        Dim KndTlf = TxtKndTlf.Text
        Dim KndEpost = TxtKndEpost.Text

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
            'DBConnect()
            'Dim Kndsporring As New MySqlCommand("INSERT INTO kunder (kunde_fdato, kunde_fornavn, " _
            '    & "kunde_etternavn, adresse, telefon, epost, rabatt_id, handlet_for) VALUES('" _
            '    & KnDFdato.ToString("yyyy-MM-dd") & "', '" & KndFornavn & "', '" & KndEtternavn _
            '    & "', '" & KndAdresse & "', " & KndTlf & ", '" & KndEpost & "', 1, 0)", Tilkobling)

            SQLInsert("kunder", "(kunde_fdato, kunde_fornavn, " & "kunde_etternavn, adresse, telefon, " &
                      "epost, rabatt_id, handlet_for)", "('" & KnDFdato.ToString("yyyy-MM-dd") & "', '" & KndFornavn _
                & "', '" & KndEtternavn & "', '" & KndAdresse & "', '" & KndTlf & "', '" & KndEpost & "', 1, 0)")

            'Kndsporring.ExecuteNonQuery()
            'DBDisconnect()
            'MsgBox("Innlegging var vellykket")
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        End Try

    End Sub


    'Henter inn en kunde basert på inntastet ID og legger verdier i skjema.
    Private Sub BtnKndKundeID_Click(sender As Object, e As EventArgs) Handles BtnKndKundeID.Click

        Dim KndSokKundeID, KndSokResultatID As String
        Dim kndtest As New DataTable

        KndSokKundeID = TxtKndKundeID.Text
        If KndSokKundeID = "" Then
            MsgBox("Vennligst fyll inn ID for søk")
            Exit Sub
        End If

        kndtest = SQLSelect("kunder", "*", "kunde_id='" & KndSokKundeID & "'")

        Try
            For Each r In kndtest.Rows
                KndSokResultatID = r("kunde_id")
                TxtKndEndreFN.Text = r("kunde_fornavn")
                TxtKndEndreEN.Text = r("kunde_etternavn")
                TxtKndEndreAdr.Text = r("adresse")
                TxtKndEndreTlf.Text = r("telefon")
                TxtKndEndreEP.Text = r("epost")
                TxtKndEndreRbt.Text = r("rabatt_id")
                TxtKndEndreHF.Text = r("handlet_for")
                DateKndEndre.Value = r("kunde_fdato")
            Next
        Catch feilmelding As MySqlException
            MsgBox("Feil ved lesing av datatabell: " & feilmelding.Message)
        End Try

        If KndSokResultatID <> "" Then
            BtnKndEndre.Enabled = True
        Else
            MsgBox("Beklager, ingen treff på det nummeret")
            BtnKndEndre.Enabled = False
            'Tom skjema
        End If

    End Sub


    'Søker på kunde basert på inntastet data og valgt kategori. Resultat vises i listview.
    Private Sub BtnKndSok_Click(sender As Object, e As EventArgs) Handles BtnKndSok.Click

        Dim KndSokSelectedTag
        Dim Kunde_ID, Kunde_Fornavn, Kunde_Etternavn, Kunde_Adresse, Kunde_Tlf, Kunde_Epost, KndSokInput,
            Kunde_rabatt, Kunde_HF As String

        Dim KndSearchTable As New DataTable

        KndSokInput = TxtKndSok.Text

        If KndSokInput = "" Then
            MsgBox("Vennligst fyll inn gylding søkeord")
            Exit Sub
        End If
        If CboKndSok.SelectedIndex = -1 Then
            MsgBox("Vennligst velg en søkekategori")
            Exit Sub
        End If

        Dim KndSQLKolonner = New String() {"kunde_id", "kunde_fornavn", "kunde_etternavn",
            "adresse", "telefon", "epost", "rabatt_id", "handlet_for"}
        KndSokSelectedTag = KndSQLKolonner(CboKndSok.SelectedIndex)

        KndSearchTable = SQLSelect("kunder", "*", KndSokSelectedTag & " LIKE '%" & KndSokInput & "%'")

        Try
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
                LvKndSok.Items.Add(New ListViewItem({Kunde_ID, Kunde_Fornavn, Kunde_Etternavn,
                    Kunde_Adresse, Kunde_Tlf, Kunde_Epost, Kunde_rabatt, Kunde_HF}))
            Next
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        End Try

    End Sub


    Private Sub BtnKndEndre_Click(sender As Object, e As EventArgs) Handles BtnKndEndre.Click

        Dim KnDFdato As Date = DateKndEndre.Value
        Dim selectedKundeId = TxtKndKundeID.Text
        Dim KndChangeValueFN = TxtKndEndreFN.Text
        Dim KndChangeValueEN = TxtKndEndreEN.Text
        Dim KndChangeValueAdr = TxtKndEndreAdr.Text
        Dim KndChangeValueTlf = TxtKndEndreTlf.Text
        Dim KndChangeValueEP = TxtKndEndreEP.Text
        Dim KndChangeValueRbt = TxtKndEndreRbt.Text
        Dim KndChangeValueHF = TxtKndEndreHF.Text


        If selectedKundeId = "" Or KndChangeValueFN = "" Or KndChangeValueEN = "" Or KndChangeValueAdr = "" _
            Or KndChangeValueTlf = "" Or KndChangeValueEP = "" Or KndChangeValueRbt = "" Or KndChangeValueHF = "" Then
            MsgBox("Vennligst fyll inn alle felt.")
        Else
            SQLUpdate("kunder", "kunde_fdato ='" & KnDFdato.ToString("yyyy-MM-dd") & ", kunde_fornavn='" _
            & KndChangeValueFN & "', kunde_etternavn='" & KndChangeValueEN & "', adresse='" & KndChangeValueAdr _
            & "', telefon='" & KndChangeValueTlf & "', epost='" & KndChangeValueEP & "', rabatt_id='" _
            & KndChangeValueRbt & "', handlet_for='" & KndChangeValueHF & "'", "kunde_id='" & selectedKundeId & "'")
        End If

    End Sub


#End Region


#Region "InventarTab"
    'Her plasseres kode som er relevant til Inventar Tab.
    'Variabler som brukes her skal begynne med Inv. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    Private Sub LvInvSok_Sort(sender As Object, e As EventArgs) Handles LvInvSok.ColumnClick
        ColumnClick(sender, e)
    End Sub

    'Prosedyre for tømming av alle felt i skjema
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
        ChkInvBarneHenger.Checked = False
        ChkInvLastehenger.Checked = False
        ChkInvBarnesete.Checked = False
        ChkInvSykkelveske.Checked = False
    End Sub

    'Tillater kun inntasting av tall i textbox for innkjøpspris
    Private Sub TxtInvInnkjopspris_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
        Handles TxtInvInnkjopspris.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Tillater kun inntasting av tall i textbox for hjulstørrelse
    Private Sub TxtInvHjulstorrelse_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
        Handles TxtInvHjulstorrelse.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Endrer status på felt i skjema avhengig om det er sykkel eller utstyr som skal registreres.
    'Med kategori "Sykkel" valgt vil alle felt være tilgjengelig.
    'For "Utstyr" vil kun felt som er en kolonne i tabellen for utstyr være aktivert.
    'Innhold i Combobox Subkategori endrer innhold (leses fra databasen) basert på om det er sykkel eller _
    'utstyr som er valgt.
    'Også kolonner i listview (LvInvSok) endres avhengig av valgt kategori (sykkel eller utstyr)
    Private Sub CboInvKategori_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CboInvKategori.SelectedIndexChanged
        If CboInvKategori.SelectedItem = "Utstyr" Then
            CboInvAvdeling.Enabled = False
            TxtInvRamme.Enabled = False
            TxtInvHjulstorrelse.Enabled = False
            TxtInvGirsystem.Enabled = False
            'CboInvStatus.Enabled = False
            CboInvSkadet.Enabled = False
            CboInvSavnet.Enabled = False
            ChkInvBarneHenger.Enabled = False
            ChkInvBarnesete.Enabled = False
            ChkInvLastehenger.Enabled = False
            ChkInvSykkelveske.Enabled = False
            LvInvSok.Items.Clear()
            LvInvSok.Columns.Clear()
            LvInvSok.Columns.AddRange(New ColumnHeader() {ID, Me.Produktnavn, Me.Kategori,
                Me.Varenummer, Me.Innkjøpspris, Me.Forhandler})
            CboInvSubkategori.Items.Clear()
            InvAutoPopUtstyr()
        Else
            CboInvAvdeling.Enabled = True
            TxtInvRamme.Enabled = True
            TxtInvHjulstorrelse.Enabled = True
            TxtInvGirsystem.Enabled = True
            'CboInvStatus.Enabled = True
            CboInvSkadet.Enabled = True
            CboInvSavnet.Enabled = True
            ChkInvBarneHenger.Enabled = True
            ChkInvBarnesete.Enabled = True
            ChkInvLastehenger.Enabled = True
            ChkInvSykkelveske.Enabled = True
            LvInvSok.Items.Clear()
            LvInvSok.Columns.Clear()
            'LvInvSok.Columns.AddRange(InvLvKolonnerSykkel())
            LvInvSok.Columns.AddRange(New ColumnHeader() {Me.ID, Me.Produktnavn, Me.Varenummer,
                        Me.Kategori, Me.Ramme, Me.Girsystem, Me.Hjulstørrelse, Me.Innkjøpspris, Me.Avdeling,
                        Me.Forhandler, Me.Status, Me.Skadet, Me.Savnet})

            CboInvSubkategori.Items.Clear()
            InvAutoPopSykkel()
        End If
    End Sub

    'Combobox Subkategori styres av indexchanged på combobox kategori. Dermed vil et kall på InvCboPop fra _
    'combobox for kategori føre til endringer i kategori og ikke subkategori som ønsket.
    'Derfor egne autopopulate for sykkel og utstyr. Disse kalles fra combobox for kategori og endrer _
    'innhold i subkategori.
    Private Sub InvAutoPopUtstyr()
        Dim InvUtstyrComboDaT As New DataTable
        InvUtstyrComboDaT = SQLSelect("utstyr_kategori", "utstyr_kat", "1")
        CboInvSubkategori.Items.Clear()
        Try
            For Each r In InvUtstyrComboDaT.Rows
                CboInvSubkategori.Items.Add(r("utstyr_kat"))
            Next
        Catch ex As Exception
            MsgBox("Feil med autoutfylling av utstyrskategorier fra datatabell: " & ex.Message)
        End Try
    End Sub

    Private Sub InvAutoPopSykkel()
        Dim InvSykkelComboDaT As New DataTable
        InvSykkelComboDaT = SQLSelect("sykkel_typer", "kategori", "1")
        CboInvSubkategori.Items.Clear()
        Try
            For Each r In InvSykkelComboDaT.Rows
                CboInvSubkategori.Items.Add(r("kategori"))
            Next
        Catch ex As Exception
            MsgBox("Feil med autoutfylling av sykkelkategorier fra datatabell: " & ex.Message)
        End Try
    End Sub

    Private Sub InvRegistrerSykkel()
        If CboInvAvdeling.SelectedIndex = -1 Or CboInvForhandler.SelectedIndex = -1 Or
                CboInvSubkategori.SelectedIndex = -1 Or TxtInvProduktnavn.Text.Trim = "" Or
                TxtInvVareNummer.Text.Trim = "" Or TxtInvInnkjopspris.Text.Trim = "" Or
                TxtInvRamme.Text.Trim = "" Or TxtInvHjulstorrelse.Text.Trim = "" Or
                TxtInvGirsystem.Text.Trim = "" Or CboInvStatus.SelectedIndex = -1 Or
                CboInvSkadet.SelectedIndex = -1 Or CboInvSavnet.SelectedIndex = -1 Then

            MsgBox("Vennligst fyll inn alle felt")

        Else

            Dim InvKategori, InvSubkategoriNavn, InvAvdelingNavn, InvProduktnavn, InvVarenummer,
                InvInnkjopspris, InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandlerNavn,
                InvStatus, InvSkadet, InvSavnet, InvForhandlerID, InvAvdelingID, InvSubKategoriID,
                InvSykkelID, InvRegKolonner, InvRegTabell, InvRegVerdier As String

            Dim InvBekreftSykkelReg As DialogResult

            InvKategori = CboInvKategori.SelectedItem
            InvSubkategoriNavn = CboInvSubkategori.SelectedItem
            InvAvdelingNavn = CboInvAvdeling.SelectedItem
            InvProduktnavn = SQLWhiteWash(TxtInvProduktnavn.Text.Trim)
            InvVarenummer = SQLWhiteWash(TxtInvVareNummer.Text.Trim)
            InvInnkjopspris = SQLWhiteWash(TxtInvInnkjopspris.Text.Trim)
            InvRamme = SQLWhiteWash(TxtInvRamme.Text.Trim)
            InvHjulstorrlese = SQLWhiteWash(TxtInvHjulstorrelse.Text.Trim)
            InvGirsystem = SQLWhiteWash(TxtInvGirsystem.Text.Trim)
            InvForhandlerNavn = CboInvForhandler.SelectedItem
            InvStatus = CboInvStatus.SelectedItem
            InvSkadet = CboInvSkadet.SelectedIndex
            InvSavnet = CboInvSavnet.SelectedIndex
            InvForhandlerID = SQLHentIDNavn("forhandler", "forhandler_navn",
                    "forhandler_id", InvForhandlerNavn)
            InvSubKategoriID = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", InvSubkategoriNavn)
            InvAvdelingID = SQLHentIDNavn("avdeling", "avd_navn", "avdeling_id", InvAvdelingNavn)

            InvBekreftSykkelReg = MsgBox("Bekreft registrering av sykkel", MsgBoxStyle.OkCancel)
            If InvBekreftSykkelReg = DialogResult.OK Then

                InvRegKolonner = "(forhandler_id, type_id, avdeling_id, sykkel_navn, sykkel_modell, " _
                    & "sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet)"
                InvRegTabell = "sykler"
                InvRegVerdier = "('" + InvForhandlerID & "', '" & InvSubKategoriID & "', '" _
                & InvAvdelingID + "', '" & InvProduktnavn & "', '" & InvVarenummer & "', '" _
                & InvInnkjopspris & "', '" & InvStatus & "', '" & InvHjulstorrlese & "', '" _
                & InvRamme & "', '" & InvGirsystem & "', '" & InvSavnet & "', '" & InvSkadet & "')"

                InvSykkelID = SQLInsert(InvRegTabell, InvRegKolonner, InvRegVerdier)

                'Registerer valgt utstyr på siste sykkelID
                If ChkInvBarneHenger.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvSykkelID & ", 4)")
                End If
                If ChkInvBarnesete.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvSykkelID & ", 3)")
                End If
                If ChkInvLastehenger.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvSykkelID & ", 5)")
                End If
                If ChkInvSykkelveske.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvSykkelID & ", 2)")
                End If
            End If
        End If
    End Sub

    Private Sub InvRegistrerUtstyr()
        If CboInvForhandler.SelectedIndex = -1 Or CboInvSubkategori.SelectedIndex = -1 Or
            TxtInvProduktnavn.Text.Trim = "" Or TxtInvVareNummer.Text.Trim = "" Or
            TxtInvInnkjopspris.Text.Trim = "" Then

            MsgBox("Vennligst fyll inn alle felt")

        Else

            Dim InvKategori, InvSubkategoriNavn, InvSubKategoriID, InvForhandlerNavn, InvForhandlerID,
                InvProduktnavn, InvVarenummer, InvInnkjopspris, InvSpForhandlerID, InvSpSubkategoriID,
                InvKolonnerUtstyr, InvVerdierUtstyr, InvStatusUtstyr As String

            Dim InvBekreftUtstyrReg As DialogResult
            Dim InvSubkategoriIDTabell, InvForhandlerIDTabell As DataTable

            InvKategori = CboInvKategori.SelectedItem
            InvSubkategoriNavn = CboInvSubkategori.SelectedItem
            InvForhandlerNavn = CboInvForhandler.SelectedItem
            InvStatusUtstyr = CboInvStatus.SelectedItem
            InvProduktnavn = SQLWhiteWash(TxtInvProduktnavn.Text.Trim)
            InvVarenummer = SQLWhiteWash(TxtInvVareNummer.Text.Trim)
            InvInnkjopspris = SQLWhiteWash(TxtInvInnkjopspris.Text.Trim)

            InvSpForhandlerID = "forhandler_navn='" & InvForhandlerNavn & "'"
            InvSpSubkategoriID = "utstyr_kat='" & InvSubkategoriNavn & "'"

            InvSubkategoriIDTabell = SQLSelect("utstyr_kategori", "utstyr_kat_id",
                 InvSpSubkategoriID)
            InvForhandlerIDTabell = SQLSelect("forhandler", "forhandler_id",
                InvSpForhandlerID)

            For Each i In InvSubkategoriIDTabell.Rows
                InvSubKategoriID = i("utstyr_kat_id")
            Next
            For Each i In InvForhandlerIDTabell.Rows
                InvForhandlerID = i("forhandler_id")
            Next

            InvBekreftUtstyrReg = MsgBox("Bekreft registrering av utstyr", MsgBoxStyle.OkCancel)
            If InvBekreftUtstyrReg = DialogResult.OK Then

                InvKolonnerUtstyr = "(utstyr_navn, varenummer, utstyr_pris, " _
                    & "forhandler_id, utstyr_kat_id, utstyr_status)"
                InvVerdierUtstyr = "('" & InvProduktnavn & "' ,'" & InvVarenummer _
                        & "', '" & InvInnkjopspris & "', '" & InvForhandlerID & "', '" & InvSubKategoriID & "', '" _
                        & InvStatusUtstyr & "');"

                SQLInsert("utstyr", InvKolonnerUtstyr, InvVerdierUtstyr)

            End If
        End If
    End Sub

    Private Sub InvSokSykkel()

        'Oppbygging av SQL spørring
        Dim InvSpInit As String = "SELECT s.sykkel_id, s.sykkel_navn, s.sykkel_modell, " _
                & "sykkel_typer.kategori, s.sykkel_ramme, s.girsystem, s.hjul_str, " _
                & "s.sykkel_pris, avdeling.avd_navn, forhandler.forhandler_navn, s.sykkel_status, " _
                & "s.skadet, s.savnet FROM sykler AS s LEFT JOIN avdeling ON " _
                & "s.avdeling_id=avdeling.avdeling_id LEFT JOIN forhandler ON " _
                & "s.forhandler_id=forhandler.forhandler_id LEFT JOIN sykkel_typer ON " _
                & "s.type_id=sykkel_typer.type_id "

        Dim InvSpUtstyrJoin As String = "INNER JOIN sykkel_utstyr AS su ON s.sykkel_id=su.sykkel_id " _
                & "INNER JOIN utstyr_kategori AS uk ON su.utstyr_kat_id=uk.utstyr_kat_id "
        Dim InvSpSykkelNavn As String = "sykkel_navn LIKE '%" & SQLWhiteWash(TxtInvProduktnavn.Text.Trim) & "%'"
        Dim InvSpsykkelModell As String = "kategori LIKE '%" & CboInvSubkategori.SelectedItem & "%'"
        Dim InvSpTypeid As String = "sykkel_modell LIKE '%" & SQLWhiteWash(TxtInvVareNummer.Text.Trim) & "%'"
        Dim InvSpSykkelRamme As String = "sykkel_ramme LIKE '%" & SQLWhiteWash(TxtInvRamme.Text.Trim) & "%'"
        Dim InvSpGirsystem As String = "girsystem LIKE '%" & SQLWhiteWash(TxtInvGirsystem.Text.Trim) & "%'"
        Dim InvSpHjulstorrelse As String = "hjul_str LIKE '%" & SQLWhiteWash(TxtInvHjulstorrelse.Text.Trim) & "%'"
        Dim InvSpSykkelPris As String = "sykkel_pris LIKE '%" & SQLWhiteWash(TxtInvInnkjopspris.Text.Trim) & "%'"
        Dim InvSpAvdeling As String = "avd_navn LIKE '%" & CboInvAvdeling.SelectedItem & "%'"
        Dim InvSpForhandlerID As String = "forhandler_navn LIKE '%" & CboInvForhandler.SelectedItem & "%'"
        Dim InvSpSykkelStatus As String = "sykkel_status LIKE '%" & CboInvStatus.SelectedItem & "%'"
        Dim InvSpSykkelUtstyr As String = ""
        Dim InvSpUtstyrAntall As Integer = -1

        Dim InvSpSkadet As String
        Dim InvSpSavnet As String

        Dim InvSqlSok As MySqlCommand
        Dim invSqlLeser As MySqlDataReader

        'Denne if-else biten sørger for at kun sykler med valgte utstyrskategorier (checkbokser) _
        'tas med i resultatet
        If ChkInvSykkelveske.Checked = True Or ChkInvBarnesete.Checked = True _
                Or ChkInvBarneHenger.Checked = True Or ChkInvLastehenger.Checked = True Then
            InvSpInit = InvSpInit + InvSpUtstyrJoin
            If ChkInvSykkelveske.Checked = True Then
                InvSpSykkelUtstyr = InvSpSykkelUtstyr + " AND(su.utstyr_kat_id=2"
                InvSpUtstyrAntall = InvSpUtstyrAntall + 1
            End If
            If ChkInvBarnesete.Checked = True Then
                If InvSpUtstyrAntall = -1 Then
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " AND(su.utstyr_kat_id=3"
                Else
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " OR su.utstyr_kat_id=3"
                End If
                InvSpUtstyrAntall = InvSpUtstyrAntall + 1
            End If
            If ChkInvBarneHenger.Checked = True Then
                If InvSpUtstyrAntall = -1 Then
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " AND(su.utstyr_kat_id=4"
                Else
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " OR su.utstyr_kat_id=4"
                End If
                InvSpUtstyrAntall = InvSpUtstyrAntall + 1
            End If
            If ChkInvLastehenger.Checked = True Then
                If InvSpUtstyrAntall = -1 Then
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " AND(su.utstyr_kat_id=5"
                Else
                    InvSpSykkelUtstyr = InvSpSykkelUtstyr + " OR su.utstyr_kat_id=5"
                End If
                InvSpUtstyrAntall = InvSpUtstyrAntall + 1
            End If
            InvSpSykkelUtstyr = InvSpSykkelUtstyr & ")" & " GROUP by s.sykkel_id HAVING COUNT(su.sykkel_id) > " _
                    & InvSpUtstyrAntall
        End If

        'Unngår NULL verdi fra combobox skadet og savnet og dermed søk uten resultat.
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

        Dim InvSokSporring As String
        InvSokSporring = InvSpInit & " WHERE " & InvSpSykkelNavn & " AND " & InvSpsykkelModell & " AND " &
                InvSpTypeid & " AND " & InvSpSykkelRamme & " AND " & InvSpGirsystem & " AND " &
                InvSpHjulstorrelse & " AND " & InvSpSykkelPris & " AND " & InvSpAvdeling & " AND " &
                InvSpForhandlerID & " AND " & InvSpSykkelStatus & " AND " & InvSpSkadet & " AND " &
                InvSpSavnet & InvSpSykkelUtstyr & ";"

        Dim InvResultatArray(12) As String
        Dim InvResultatObjekt As ListViewItem

        'Sender spørring for søk basert på innlagte data i skjema. Skriver ut returnerte rader til listview 
        Try
            DBConnect()
            InvSqlSok = New MySqlCommand(InvSokSporring, Tilkobling)
            invSqlLeser = InvSqlSok.ExecuteReader()

            'For hver kolonne les inn verdi 0-12 og legg i listview
            While invSqlLeser.Read()
                For i = 0 To invSqlLeser.FieldCount - 1
                    If i = 11 Or i = 12 Then
                        If invSqlLeser(i) = False Then
                            InvResultatArray(i) = "Nei"
                        Else
                            InvResultatArray(i) = "Ja"
                        End If
                    Else
                        InvResultatArray(i) = invSqlLeser(i)
                    End If
                Next
                InvResultatObjekt = New ListViewItem(InvResultatArray)
                LvInvSok.Items.Add(InvResultatObjekt)
            End While
            invSqlLeser.Close()
            DBDisconnect()
        Catch ex As MySqlException
            MsgBox("Feil ved søk i sykkeldatabase:" & vbNewLine & ex.Message)
        End Try


        '----------------------T E S T-------------------------
        'Dim InvSpInit As String = "s.sykkel_id, s.sykkel_navn, s.sykkel_modell, " _
        '        & "sykkel_typer.kategori, s.sykkel_ramme, s.girsystem, s.hjul_str, " _
        '        & "s.sykkel_pris, avdeling.avd_navn, forhandler.forhandler_navn, s.sykkel_status, " _
        '        & "s.skadet, s.savnet FROM sykler AS s LEFT JOIN avdeling ON " _
        '        & "s.avdeling_id=avdeling.avdeling_id LEFT JOIN forhandler ON " _
        '        & "s.forhandler_id=forhandler.forhandler_id LEFT JOIN sykkel_typer ON " _
        '        & "s.type_id=sykkel_typer.type_id "

        'InvSokSporring = InvSpSykkelNavn & " AND " & InvSpsykkelModell & " AND " &
        '        InvSpTypeid & " AND " & InvSpSykkelRamme & " AND " & InvSpGirsystem & " AND " &
        '        InvSpHjulstorrelse & " AND " & InvSpSykkelPris & " AND " & InvSpAvdeling & " AND " &
        '        InvSpForhandlerID & " AND " & InvSpSykkelStatus & " AND " & InvSpSkadet & " AND " &
        '        InvSpSavnet & InvSpSykkelUtstyr ' & ";"

        'Dim test As String = InvSpInit & InvSpUtstyrJoin
        'Dim invtesttabell As DataTable
        'invtesttabell = SQLSelect("sykler", test, InvSokSporring)
        'Dim invLvSavnet, invLvSkadet As String

        'For Each r In invtesttabell.Rows
        '    If r("s.skadet") = 0 Then
        '        invLvSkadet = "Nei"
        '    Else
        '        invLvSkadet = "Ja"
        '    End If
        '    If r("s.savnet") = 0 Then
        '        invLvSavnet = "Nei"
        '    Else
        '        invLvSavnet = "Ja"
        '    End If
        '    LvInvSok.Items.Add(New ListViewItem({r("s.sykkel_id"), r("s.sykkel_navn"), r("s.sykkel_modell"),
        '        r("sykkel_typer.kategori"), r("s.sykkel_ramme"), r("s.girsystem"), r("s.hjul_str"), r("s.sykkel_pris"),
        '        r("avdeling.avd_navn"), r("forhandler.forhandler_navn"), r("s.status"), invLvSkadet, invLvSavnet}))
        'Next

    End Sub

    Private Sub InvSokUtstyr()

        Dim InvSpInit As String = "SELECT utstyr.utstyr_id, utstyr.utstyr_navn, utstyr_kategori.utstyr_kat, " _
               & "utstyr.varenummer, utstyr.utstyr_pris, forhandler.forhandler_navn " _
               & "FROM utstyr LEFT JOIN forhandler ON utstyr.forhandler_id=forhandler.forhandler_id " _
               & "LEFT JOIN utstyr_kategori ON utstyr.utstyr_kat_id=utstyr_kategori.utstyr_kat_id WHERE "

        Dim InvSpUtstyrNavn As String = "utstyr_navn LIKE '%" & SQLWhiteWash(TxtInvProduktnavn.Text.Trim) & "%'"
        Dim InvSpVarenummer As String = "varenummer LIKE '%" & SQLWhiteWash(TxtInvVareNummer.Text.Trim) & "%'"
        Dim InvSpUtstyrPris As String = "utstyr_pris LIKE '%" & SQLWhiteWash(TxtInvInnkjopspris.Text.Trim) & "%'"
        Dim InvSpForhandlerNavn As String = "forhandler_navn LIKE '%" & CboInvForhandler.SelectedItem & "%'"
        Dim InvSpUtstyrkategori As String = "utstyr_kat LIKE '%" & CboInvSubkategori.SelectedItem & "%'"

        Dim InvSokSporring As String
        InvSokSporring = InvSpInit & InvSpUtstyrNavn & " AND " & InvSpUtstyrkategori & " AND " _
            & InvSpVarenummer & " AND " & InvSpUtstyrPris & " AND " & InvSpForhandlerNavn & ";"

        Dim InvResultatArray(5) As String
        Dim InvResultatObjekt As ListViewItem
        Dim InvSqlSok As MySqlCommand
        Dim invSqlLeser As MySqlDataReader

        'Sender spørring for søk basert på innlagte data i skjema. Skriver ut returnerte rader til listview 
        Try
            DBConnect()
            InvSqlSok = New MySqlCommand(InvSokSporring, Tilkobling)
            invSqlLeser = InvSqlSok.ExecuteReader()

            'For hver kolonne les inn verdi 1 til n og legg i listview
            While invSqlLeser.Read()
                For i = 0 To invSqlLeser.FieldCount - 1
                    If TypeOf invSqlLeser(i) Is DBNull Then
                    Else
                        InvResultatArray(i) = invSqlLeser(i)
                    End If
                Next
                InvResultatObjekt = New ListViewItem(InvResultatArray)
                LvInvSok.Items.Add(InvResultatObjekt)
            End While
            invSqlLeser.Close()
            DBDisconnect()

        Catch ex As MySqlException
            MsgBox("Feil ved søk i utstyrdatabase:" & vbNewLine & ex.Message)
        End Try

    End Sub

    Private Sub InvEndreSykkel()

        Dim InvKategori, InvSubkategoriNavn, InvAvdelingNavn, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandlerNavn, InvStatus, InvSkadet, InvSavnet,
            InvForhandlerID, InvAvdelingID, InvSubKategoriID, InvEndreVerdier As String

        InvKategori = CboInvKategori.SelectedItem
        InvSubkategoriNavn = CboInvSubkategori.SelectedItem
        InvAvdelingNavn = CboInvAvdeling.SelectedItem
        InvProduktnavn = SQLWhiteWash(TxtInvProduktnavn.Text.Trim)
        InvVarenummer = SQLWhiteWash(TxtInvVareNummer.Text.Trim)
        InvInnkjopspris = SQLWhiteWash(TxtInvInnkjopspris.Text.Trim)
        InvRamme = SQLWhiteWash(TxtInvRamme.Text.Trim)
        InvHjulstorrlese = SQLWhiteWash(TxtInvHjulstorrelse.Text.Trim)
        InvGirsystem = SQLWhiteWash(TxtInvGirsystem.Text.Trim)
        InvForhandlerNavn = CboInvForhandler.SelectedItem
        InvStatus = CboInvStatus.SelectedItem
        InvSkadet = CboInvSkadet.SelectedIndex
        InvSavnet = CboInvSavnet.SelectedIndex

        If CboInvAvdeling.SelectedIndex = -1 Or CboInvForhandler.SelectedIndex = -1 Or
              CboInvSubkategori.SelectedIndex = -1 Or TxtInvProduktnavn.Text.Trim = "" Or
              TxtInvVareNummer.Text.Trim = "" Or TxtInvInnkjopspris.Text.Trim = "" Or
              TxtInvRamme.Text.Trim = "" Or TxtInvHjulstorrelse.Text.Trim = "" Or
              TxtInvGirsystem.Text.Trim = "" Or CboInvStatus.SelectedIndex = -1 Or
              CboInvSkadet.SelectedIndex = -1 Or CboInvSavnet.SelectedIndex = -1 Then

            MsgBox("Vennligst fyll inn alle felt")

        Else

            Dim InvBekreftSykkelReg As DialogResult
            InvBekreftSykkelReg = MsgBox("Bekreft endring av sykkel", MsgBoxStyle.OkCancel)
            If InvBekreftSykkelReg = DialogResult.OK Then

                InvForhandlerID = SQLHentIDNavn("forhandler", "forhandler_navn",
                    "forhandler_id", InvForhandlerNavn)
                InvSubKategoriID = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", InvSubkategoriNavn)
                InvAvdelingID = SQLHentIDNavn("avdeling", "avd_navn", "avdeling_id", InvAvdelingNavn)
                InvEndreVerdier = "sykkel_navn='" & InvProduktnavn & "', sykkel_modell='" & InvVarenummer _
                    & "', type_id='" & InvSubKategoriID & "', sykkel_ramme='" & InvRamme & "', girsystem='" _
                    & InvGirsystem & "', hjul_str='" & InvHjulstorrlese & "', sykkel_pris='" &
                    InvInnkjopspris & "', avdeling_id='" & InvAvdelingID & "', forhandler_id='" _
                    & InvForhandlerID & "', sykkel_status='" & InvStatus & "', skadet='" & InvSkadet _
                    & "', savnet='" & InvSavnet & "'"

                SQLUpdate("sykler", InvEndreVerdier, "sykkel_id='" & InvAktivtProduktID & "';")
                SQLDelete("sykkel_utstyr", "sykkel_id='" & InvAktivtProduktID & "';")

                If ChkInvBarneHenger.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvAktivtProduktID & ", 4);")
                End If
                If ChkInvBarnesete.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvAktivtProduktID & ", 3);")
                End If
                If ChkInvLastehenger.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvAktivtProduktID & ", 5)")
                End If
                If ChkInvSykkelveske.Checked = True Then
                    SQLInsert("sykkel_utstyr", "(sykkel_id, utstyr_kat_id)", "(" & InvAktivtProduktID & ", 2)")
                End If


            End If
        End If

    End Sub

    Private Sub InvEndreUtstyr()



        Dim InvKategori, InvSubkategoriNavn, InvAvdelingNavn, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvForhandlerNavn, InvForhandlerID, InvSubKategoriID, InvEndreVerdier As String

        InvKategori = CboInvKategori.SelectedItem
        InvSubkategoriNavn = CboInvSubkategori.SelectedItem
        InvAvdelingNavn = CboInvAvdeling.SelectedItem
        InvProduktnavn = SQLWhiteWash(TxtInvProduktnavn.Text.Trim)
        InvVarenummer = SQLWhiteWash(TxtInvVareNummer.Text.Trim)
        InvInnkjopspris = SQLWhiteWash(TxtInvInnkjopspris.Text.Trim)
        InvForhandlerNavn = CboInvForhandler.SelectedItem

        If CboInvForhandler.SelectedIndex = -1 Or CboInvSubkategori.SelectedIndex = -1 _
             Or TxtInvProduktnavn.Text.Trim = "" Or TxtInvVareNummer.Text.Trim = "" _
             Or TxtInvInnkjopspris.Text.Trim = "" Then

            MsgBox("Vennligst fyll inn alle felt")

        Else

            Dim InvBekreftSykkelReg As DialogResult
            InvBekreftSykkelReg = MsgBox("Bekreft endring av utstyr", MsgBoxStyle.OkCancel)
            If InvBekreftSykkelReg = DialogResult.OK Then

                InvForhandlerID = SQLHentIDNavn("forhandler", "forhandler_navn", "forhandler_id", InvForhandlerNavn)
                InvSubKategoriID = SQLHentIDNavn("utstyr_kategori", "utstyr_kat",
                    "utstyr_kat_id", InvSubkategoriNavn)
                InvEndreVerdier = "utstyr_navn='" & InvProduktnavn & "', varenummer='" _
                & InvVarenummer & "', utstyr_pris='" & InvInnkjopspris & "', forhandler_id='" _
                & InvForhandlerID & "', utstyr_kat_id='" & InvSubKategoriID & "'"

                SQLUpdate("utstyr", InvEndreVerdier, "utstyr_id='" & InvAktivtProduktID & "'")

            End If
        End If

    End Sub

    'SQLspørring med registrering av nytt produkt basert på innlagt data i skjema.
    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvRegistrerSykkel()
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then
            InvRegistrerUtstyr()
        Else
            MsgBox("Velg kategori")
        End If

    End Sub

    'SQLspørring med søk på valgte verdier i søkefelt
    Private Sub BtnInvSok_Click(sender As Object, e As EventArgs) Handles BtnInvSok.Click

        LvInvSok.Items.Clear()

        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvSokSykkel()
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then
            InvSokUtstyr()
        Else
            MsgBox("Velg en kategori")
        End If

    End Sub

    'SQLspørring med endering av data for valgt produkt med ID fra valgt produkt i søkefelt
    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click

        BtnInvRegistrer.Enabled = True
        BtnInvSok.Enabled = True

        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvEndreSykkel()
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then
            InvEndreUtstyr()
        Else
            MsgBox("Velg kategori")
        End If

        InvAktivtProduktID = ""
        LblInvAktivProdukt.Text = "Ingen aktive produkt."
        BtnInvEndre.Enabled = False

    End Sub

    'Henter data for objekt med inntastet ID fra database og legger i skjema
    Private Sub BtnInvHent_Click(sender As Object, e As EventArgs) Handles BtnInvHent.Click

        BtnInvRegistrer.Enabled = False
        BtnInvEndre.Enabled = True

        Dim InvForhandlerID, InvAvdelingID, InvSubkategoriID, InvForhandlerNavn, InvAvdelingNavn,
            InvSubkategoriNavn As String

        Dim InvSkadetBol, InvSavnetBol As Boolean

        Dim InvHentDaT As New DataTable
        Dim InvHentUtstyrKatDaT As New DataTable

        If TxtInvHentID.Text = "" Then

            MsgBox("Skriv inn et ID nummer")

            'Spørring for å hente sykkel fra database basert på inntastet ID og legge det inn i skjema
        ElseIf CboInvKategori.SelectedItem = "Sykkel" Then

            InvAktivtProduktID = SQLWhiteWash(TxtInvHentID.Text.Trim)
            LblInvAktivProdukt.Text = "Aktivt produkt ID: " & InvAktivtProduktID
            InvTomFelt()

            InvHentDaT = SQLSelect("sykler", "*", "sykkel_id='" & InvAktivtProduktID & "'")
            InvHentUtstyrKatDaT = SQLSelect("sykkel_utstyr", "utstyr_kat_id", "sykkel_id=" & InvAktivtProduktID)

            Try
                For Each r In InvHentDaT.Rows
                    InvSubkategoriID = r("type_id").ToString
                    InvAvdelingID = r("avdeling_id").ToString
                    TxtInvProduktnavn.Text = r("sykkel_navn")
                    TxtInvVareNummer.Text = r("sykkel_modell")
                    TxtInvInnkjopspris.Text = r("sykkel_pris")
                    TxtInvRamme.Text = r("sykkel_ramme")
                    TxtInvHjulstorrelse.Text = r("hjul_str")
                    TxtInvGirsystem.Text = r("girsystem")
                    InvForhandlerID = r("forhandler_id").ToString
                    CboInvStatus.SelectedItem = r("sykkel_status")
                    InvSkadetBol = r("skadet")
                    InvSavnetBol = r("savnet")
                Next
                For Each r In InvHentUtstyrKatDaT.Rows
                    If r("utstyr_kat_id") = 2 Then
                        ChkInvSykkelveske.Checked = True
                    ElseIf r("utstyr_kat_id") = 3 Then
                        ChkInvBarnesete.Checked = True
                    ElseIf r("utstyr_kat_id") = 4 Then
                        ChkInvBarneHenger.Checked = True
                    ElseIf r("utstyr_kat_id") = 5 Then
                        ChkInvLastehenger.Checked = True
                    End If
                Next
            Catch ex As Exception
                MsgBox("Feil ved innlegging av data i skjema:" & ex.Message)
            End Try

            InvForhandlerNavn = SQLHentIDNavn("forhandler",
                        "forhandler_id", "forhandler_navn", InvForhandlerID)
            InvSubkategoriNavn = SQLHentIDNavn("sykkel_typer", "type_id", "kategori", InvSubkategoriID)
            InvAvdelingNavn = SQLHentIDNavn("avdeling", "avdeling_id", "avd_navn", InvAvdelingID)

            'Fyller inn resterende data i skjema 
            CboInvKategori.SelectedIndex = 0
            CboInvAvdeling.SelectedItem = InvAvdelingNavn
            CboInvForhandler.SelectedItem = InvForhandlerNavn
            CboInvSubkategori.SelectedItem = InvSubkategoriNavn
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

            'Spørring å hente utstyr fra database basert på inntastet ID og legge det inn i skjema
        ElseIf CboInvKategori.SelectedItem = "Utstyr" Then

            InvAktivtProduktID = SQLWhiteWash(TxtInvHentID.Text.Trim)
            LblInvAktivProdukt.Text = "Aktivt produkt ID: " & InvAktivtProduktID
            InvTomFelt()

            InvHentDaT = SQLSelect("utstyr", "*", "utstyr_id='" & InvAktivtProduktID & "';")

            Try
                For Each r In InvHentDaT.Rows
                    InvSubkategoriID = r("utstyr_kat_id").ToString
                    TxtInvProduktnavn.Text = r("utstyr_navn")
                    TxtInvVareNummer.Text = r("varenummer")
                    TxtInvInnkjopspris.Text = r("utstyr_pris")
                    InvForhandlerID = r("forhandler_id").ToString
                Next
            Catch ex As Exception
                MsgBox("Feil ved innlegging av data i skjema: " & ex.Message)
            End Try

            InvForhandlerNavn = SQLHentIDNavn("forhandler", "forhandler_id", "forhandler_navn", InvForhandlerID)
            InvSubkategoriNavn = SQLHentIDNavn("utstyr_kategori", "utstyr_kat_id", "utstyr_kat", InvSubkategoriID)

            CboInvKategori.SelectedIndex = 1
            CboInvForhandler.SelectedItem = InvForhandlerNavn
            CboInvSubkategori.SelectedItem = InvSubkategoriNavn

        Else
            MsgBox("Velg kategori")
        End If
    End Sub

    'Avbryter endring av produkt. Ved innhenting av produkt, knappen "Hent", settes "Registrer" _
    'knappen til inaktiv For å unngå feilaktig dobbelregistrering av produkt.
    'Ved å avbryte nullstilles skjema og knappen for registrering aktiveres.
    Private Sub BtnInvAvbrytEndre_Click(sender As Object, e As EventArgs) Handles BtnInvAvbrytEndre.Click
        BtnInvRegistrer.Enabled = True
        BtnInvSok.Enabled = True
        BtnInvEndre.Enabled = False
        InvAktivtProduktID = ""
        InvTomFelt()
        LblInvAktivProdukt.Text = "Ingen aktive produkt"
    End Sub

    'Tømmer alle felt i skjema
    Private Sub BtnInvTom_Click(sender As Object, e As EventArgs) Handles BtnInvTom.Click
        InvTomFelt()
    End Sub


#End Region


#Region "LogistikkTab"
    'Her plasseres kode som er relevant til Logistikk Tab.
    'Variabler som brukes her skal begynne med Logi. Dette er for å unngå klasj.
    'Husk kode kommentarer.


    Private Sub TxtLogiID_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs) _
        Handles TxtLogiID.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub CboLogiHentested_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CboLogiHentested.SelectedIndexChanged
        AutoPopCbo(sender, "avdeling", "avd_navn")
    End Sub

    Private Sub CboLogiLeveringsSted_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles CboLogiLeveringsSted.SelectedIndexChanged
        AutoPopCbo(sender, "avdeling", "avd_navn")
    End Sub

    Private Sub BtnLogiSok_Click(sender As Object, e As EventArgs) Handles BtnLogiSok.Click

    End Sub

    Private Sub BtnLogiHentetLevert_Click(sender As Object, e As EventArgs) Handles BtnLogiHentetLevert.Click
        'Siden det ikke er noen tabell for henting og levering for sykkel så trengs strengt tatt ikke _
        'denne fanen.Sykkel. 


        Dim LogiHenteDato As Date
        Dim LogiAktivID
        Dim LogiHenteAvdeling, LogiLeveringsAvdeling, LogiAvdelingID, LogiLeieID, LogiProduktID As String

        LogiHenteAvdeling = CboLogiHentested.SelectedItem
        LogiLeveringsAvdeling = CboLogiLeveringsSted.SelectedItem
        LogiHenteDato = DateLogiLevert.Value.ToString("yyyy-MM-dd")
        LogiProduktID = SQLWhiteWash(TxtLogiID.Text.Trim)
        LogiAvdelingID = SQLHentIDNavn("avdeling", "avd_navn", "avdeling_id", LogiLeveringsAvdeling)

        'Oppdaterer avdelingen til sykkel med valg ID til stedet der sykkelen er levert
        SQLUpdate("sykler", "avdeling_id='" & LogiLeveringsAvdeling & "'", "sykkel_id='" & LogiProduktID & "'")

        'Dato er satt inn etter kravspesisfikasjon.
        'Usikker på bruken av den siden vi ikke har 

    End Sub


#End Region


#Region "StatistikkTab"
    'Her plasseres kode som er relevant til Statistikk Tab.
    'Variabler som brukes her skal begynne med Stat. Dette er for å unngå klasj.
    'Husk kode kommentarer.


    Private Sub LvStaTilgjengelig_Sort(sender As Object, e As EventArgs) Handles LvStaTilgjengelig.ColumnClick
        ColumnClick(sender, e)
    End Sub

    Private Sub LvStaMestUtleid_Sort(sender As Object, e As EventArgs) Handles LvStaMestUtleid.ColumnClick
        ColumnClick(sender, e)
    End Sub


    Dim sortColumn As Integer = -1

    Private Sub ColumnClick(sender As Object, e As ColumnClickEventArgs)

        ' If current column is not the previously clicked column
        ' Add
        If Not e.Column = sortColumn Then

            ' Set the sort column to the new column
            sortColumn = e.Column

            'Default to ascending sort order
            sender.Sorting = SortOrder.Ascending

        Else

            'Flip the sort order
            If sender.Sorting = SortOrder.Ascending Then
                sender.Sorting = SortOrder.Descending
            Else
                sender.Sorting = SortOrder.Ascending
            End If
        End If

        'Set the ListviewItemSorter property to a new ListviewItemComparer object
        sender.ListViewItemSorter = New ListViewItemComparer(e.Column, sender.Sorting)

        ' Call the sort method to manually sort
        sender.Sort()

    End Sub







    Private Sub StaTotalSykkelPris()
        Dim StaTotalSykkelKostnadDT As DataTable
        StaTotalSykkelKostnadDT = SQLSelect("sykler", "SUM(sykkel_pris)", "1")
        For Each r In StaTotalSykkelKostnadDT.Rows
            StaTotalSykkelKostnad = r("SUM(sykkel_pris)")
        Next
        LblStaTotalSykkelVerdi.Text = CStr(StaTotalSykkelKostnad) & " Kr"
    End Sub

    Private Sub StaTotalUtsyrPris()
        Dim StaTotalUtstyrKostnadDT As DataTable
        StaTotalUtstyrKostnadDT = SQLSelect("utstyr", "SUM(utstyr_pris)", "1")
        For Each r In StaTotalUtstyrKostnadDT.Rows
            StaTotalUtstyrKostnad = r("SUM(utstyr_pris)")
        Next
        LblStaTotalUtstyrVerdi.Text = CStr(StaTotalUtstyrKostnad) & " Kr"
    End Sub


    Private Sub StaTotalUtleie()
        Dim StaTotalUtleieInntektDT As DataTable
        StaTotalUtleieInntektDT = SQLSelect("utleie", "SUM(utleie_pris)", "1")
        For Each r In StaTotalUtleieInntektDT.Rows
            StaTotalUtleieInntekt = r("sum(utleie_pris)")
        Next
        LblStaTotalUtleieVerdi.Text = CStr(StaTotalUtleieInntekt) & " Kr"
    End Sub


    Private Sub StaTotalAvanse()
        StaTotalResultat = StaTotalUtleieInntekt - (StaTotalUtstyrKostnad + StaTotalSykkelKostnad)
        LblStaTotalSumVerdi.Text = CStr(StaTotalResultat) & " Kr"
    End Sub


    Private Sub BtnStaSok_Click(sender As Object, e As EventArgs) Handles BtnStaSok.Click

        Dim StaValgtAvdeling = CboStaAvdeling.SelectedItem
        Dim StaSykkelType = CboStaType.SelectedItem

        If StaValgtAvdeling = "" Then
            MsgBox("Vennligst velg avdeling")
            Exit Sub
        End If
        If StaSykkelType = "" Then
            MsgBox("Vennligst velg type")
            Exit Sub
        End If

        Dim StaAvdID As String = SQLHentIDNavn("avdeling", "avd_navn", "avdeling_id", CboStaAvdeling.SelectedItem)
        Dim StaTypeID As String = SQLHentIDNavn("sykkel_typer", "kategori", "type_id", CboStaType.SelectedItem)
        Dim StaLedigDT, StaVerkstedDT, StaUtleidDT As DataTable
        Dim StaLedig, StaVerksted, StaUtleid As String

        StaLedigDT = SQLSelect("sykler", "COUNT(sykkel_status)", "avdeling_id='" & StaAvdID _
                                        & "' AND type_id='" & StaTypeID & "' AND sykkel_status='Ledig' GROUP BY sykkel_status")
        StaVerkstedDT = SQLSelect("sykler", "COUNT(sykkel_status)", "avdeling_id='" & StaAvdID _
                                        & "' AND type_id='" & StaTypeID & "' AND sykkel_status='Verksted' GROUP BY sykkel_status")
        StaUtleidDT = SQLSelect("sykler", "COUNT(sykkel_status)", "avdeling_id='" & StaAvdID _
                                        & "' AND type_id='" & StaTypeID & "' AND sykkel_status='Utleid' GROUP BY sykkel_status")

        For Each r In StaLedigDT.Rows
            StaLedig = r("COUNT(sykkel_status)")
        Next
        For Each r In StaVerkstedDT.Rows
            StaVerksted = r("COUNT(sykkel_status)")
        Next
        For Each r In StaUtleidDT.Rows
            StaUtleid = r("COUNT(sykkel_status)")
        Next

        If StaLedig = "" Then
            StaLedig = 0
        End If
        If StaVerksted = "" Then
            StaVerksted = 0
        End If
        If StaUtleid = "" Then
            StaUtleid = 0
        End If

        LvStaTilgjengelig.Items.Clear()
        LvStaTilgjengelig.Items.Add(New ListViewItem({CboStaAvdeling.SelectedItem, CboStaType.SelectedItem,
        StaUtleid, StaLedig, StaVerksted}))

        'Dim StaValgtAvdTilgj As String
        'Dim StaValgtTypTilgj As String
        'Dim outputAntallSyklerLedig, outputAntallSyklerUtleid, outputAntallSyklerVerksted As Integer
        'Dim StaSykkeltypeValue = New Integer() {9999, 10000, 10001, 10002, 10003, 10004, 10005, 10006}
        'Dim StaAvdelingValue = New Integer() {10000, 10001, 10002, 10003, 10004}
        'StaValgtAvdTilgj = StaAvdelingValue(CboStaAvdeling.SelectedIndex)
        'StaValgtTypTilgj = StaSykkeltypeValue(CboStaType.SelectedIndex)

        'Try
        'DBConnect()

        'Dim sporring As New MySqlCommand("SELECT COUNT(sykkel_modell) FROM sykler WHERE avdeling_id = '" _
        '                                 & StaAvdID & "' AND type_id = '" & StaTypeID _
        '                                 & "' AND sykkel_status = 'Ledig'", Tilkobling)
        'Dim sporring2 As New MySqlCommand("SELECT COUNT(sykkel_modell) FROM sykler WHERE avdeling_id = '" _
        '                                  & StaAvdID & "' AND type_id = '" & StaTypeID _
        '                                  & "' AND sykkel_status = 'Utleid'", Tilkobling)
        'Dim sporring3 As New MySqlCommand("SELECT COUNT(sykkel_modell) FROM sykler WHERE avdeling_id = '" _
        '                                  & StaAvdID & "' AND type_id = '" & StaTypeID _
        '                                  & "' AND sykkel_status = 'Verksted' group by sykkel_modell", Tilkobling)
        'outputAntallSyklerLedig = sporring.ExecuteScalar()
        'outputAntallSyklerUtleid = sporring2.ExecuteScalar()
        'outputAntallSyklerVerksted = sporring3.ExecuteNonQuery()

        'StaTilgjengeligData = SQLSelect("sykler", "sykkel_status, COUNT(sykkel_status)", "avdeling_id='" & StaAvdID _
        '                                & "' AND type_id='" & StaTypeID & "' GROUP BY sykkel_status")

        'DBDisconnect()
        'Catch feilmelding As MySqlException
        'MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        'End Try

        'LvStaTilgjengelig.Items.Clear()
        'LvStaTilgjengelig.Items.Add(New ListViewItem({CboStaAvdeling.SelectedItem, CboStaType.SelectedItem, outputAntallSyklerUtleid,
        '    outputAntallSyklerVerksted, outputAntallSyklerLedig}))

    End Sub

    Private Sub StaMestPopulaer()
        Dim StaAntSyklTyp As Integer

        Dim StaSQLFinnAnt = SQLSelect("sykkel_typer", "COUNT(*) AS c", "1")
        For Each row As DataRow In StaSQLFinnAnt.Rows
            StaAntSyklTyp = row.Field(Of Int64)(0)
        Next

        Dim StaAntSykler(StaAntSyklTyp) As Integer
        Dim StaTypeSykkel(StaAntSyklTyp) As String

        Dim StaInputCommand As String = "select sykkel_typer.kategori, count(*) AS c from sykkel_typer join " _
            & "sykler as s on sykkel_typer.type_id=s.type_id join utleie on s.sykkel_id=utleie.sykkel_id group by sykkel_typer.kategori"

        Dim part1 As String = "select sykkel_typer.kategori, count(*) As c"
        Dim part2 As String = "from sykkel_typer join sykler as s on sykkel_typer.type_id=s.type_id join utleie on s.sykkel_id=utleie.sykkel_id group by sykkel_typer.kategori"
        Dim part3 As String = "1"

        Try
            DBConnect()
            Dim sporring As New MySqlCommand(StaInputCommand, Tilkobling)
            Dim StatempVarSporring = sporring.ExecuteReader()
            Dim i = 0
            While StatempVarSporring.Read

                StaAntSykler(i) = StatempVarSporring("c")
                StaTypeSykkel(i) = StatempVarSporring("kategori")

                i = i + 1
            End While
            DBDisconnect()
            LvStaMestUtleid.Items.Clear()

            For j As Integer = 0 To StaAntSykler.Length - 1
                LvStaMestUtleid.Items.Add(New ListViewItem({StaTypeSykkel(j), StaAntSykler(j)}))
            Next
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        End Try
    End Sub

#End Region


#Region "AdminTab"
    'Her plasseres kode som er relevant til Admin Tab.
    'Variabler som brukes her skal begynne med Admin. Dette er for å unngå klasj.
    'Husk kode kommentarer.


    'Prosedyre som brukes til lagring av ny bruker i MySQLDatabasen.
    'Dette er kjørt når man trykker på ny bruker knappen.
    'Her er det slik at Passord og Avdelinger befinner seg i egne tabeller.
    'Vi henter først AvdelingsIDen til Avdelingen som har blitt valgt vha MySQL som leser Avd_navn og skriver tilsvarende avdelings id til variabel.
    'Da kjører vi insert sql i 3 stadier - insert bruker, insert passord, update bruker. Dette er slik at vi får lenket opp passord fk og bruker fk med hverandre
    'ANB1 : Insert ny bruker ANB2 : Insert ny passord ANB3 : Update bruker for å knytte passord fk ANB4 : laster inn tilsvarende avdelings id.

    Private Sub LvAdminBS_Sort(sender As Object, e As EventArgs) Handles LvAdminBS.ColumnClick
        ColumnClick(sender, e)
    End Sub

    Private Sub AdminNyBruker()
        Try
            DBConnect()
            Dim AdminAvdelingNavn As String = ""
            Dim AdminAdminStatus As Integer = 0
            If ChkAdminNBAdmin.Checked = True Then
                AdminAdminStatus = 1
            End If

            TxtAdminNBPassord.Text = SQLWhiteWash(TxtAdminNBPassord.Text)
            TxtAdminNBFornavn.Text = SQLWhiteWash(TxtAdminNBFornavn.Text)
            TxtAdminNBEtternavn.Text = SQLWhiteWash(TxtAdminNBEtternavn.Text)
            TxtAdminNBTime.Text = SQLWhiteWash(TxtAdminNBTime.Text)
            TxtAdminNBEpost.Text = SQLWhiteWash(TxtAdminNBEpost.Text)
            TxtAdminNBTelefon.Text = SQLWhiteWash(TxtAdminNBTelefon.Text)

            Dim AdminNyBruker2 As New MySqlCommand("INSERT INTO passord (passord_id, pwd, bruker_id) VALUES (" & LblBrukerIDNBVis.Text & ", '" & TxtAdminNBPassord.Text & "'," & LblBrukerIDNBVis.Text & ");", Tilkobling)
            Dim AdminNyBruker3 As New MySqlCommand("UPDATE brukere SET passord_id = " & LblBrukerIDNBVis.Text & " WHERE bruker_id = " & LblBrukerIDNBVis.Text & ";", Tilkobling)
            Dim AdminNyBruker4 As New MySqlCommand("SELECT avdeling_id FROM avdeling WHERE avd_navn ='" & CboAdminNBAvdeling.Text & "';", Tilkobling)

            Dim AdminNyBrukerIDAdapter As New MySqlDataAdapter
            Dim AdminNyBrukerIDTable As New DataTable

            AdminNyBrukerIDAdapter.SelectCommand = AdminNyBruker4
            AdminNyBrukerIDAdapter.Fill(AdminNyBrukerIDTable)

            Dim AdminNyBrukerRow As DataRow

            For Each AdminNyBrukerRow In AdminNyBrukerIDTable.Rows
                AdminAvdelingNavn = AdminNyBrukerRow("avdeling_id")
            Next

            Dim AdminNyBruker1 As New MySqlCommand("INSERT INTO brukere (bruker_id, avdeling_id, stilling, fornavn, etternavn, timelonn, telefon, epost, stilling_prosent, admin) VALUES (" & LblBrukerIDNBVis.Text & "," & AdminAvdelingNavn & ",'" & CboAdminNBStilling.Text & "','" & TxtAdminNBFornavn.Text & "','" & TxtAdminNBEtternavn.Text & "'," _
                                                   & TxtAdminNBTime.Text & ",'" & TxtAdminNBTelefon.Text & "', '" & TxtAdminNBEpost.Text & "'," & CboAdminNBSP.Text & "," & AdminAdminStatus & ");", Tilkobling)

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


    'Prosedyre som brukes til endring av ekisterende bruker i SQLdatabasen.
    'Veldig lik den som brukes til ny bruker, men noen forandringer:
    'Som før så hentes tilsvarende avdeling id slik at FK til brukeren kan oppdateres riktig.
    'Da er det SQL update for å bytte bruker detaljene.
    'Hvis passordfeltet er tom, så byttes ikke passordet. AEB1 : Update Bruker AEB3 : Update Passord AEB4 : Hent avdelingid
    Private Sub AdminEndreBruker()

        TxtAdminEBPassord.Text = SQLWhiteWash(TxtAdminEBPassord.Text)
        TxtAdminEBFornavn.Text = SQLWhiteWash(TxtAdminEBFornavn.Text)
        TxtAdminEBEtternavn.Text = SQLWhiteWash(TxtAdminEBEtternavn.Text)
        TxtAdminEBTime.Text = SQLWhiteWash(TxtAdminEBTime.Text)
        TxtAdminEBEpost.Text = SQLWhiteWash(TxtAdminEBEpost.Text)
        TxtAdminEBTelefon.Text = SQLWhiteWash(TxtAdminEBTelefon.Text)

        Try
            DBConnect()
            Dim AdminAvdelingNavn As String = ""
            Dim AdminAdminStatus As Integer = 0
            If ChkAdminNBAdmin.Checked = True Then
                AdminAdminStatus = 1
            End If

            Dim AdminEndreBruker3 As New MySqlCommand("UPDATE passord SET pwd ='" & TxtAdminEBPassord.Text & "' WHERE bruker_id = " & TxtAdminEBBID.Text & ";", Tilkobling)
            Dim AdminEndreBruker4 As New MySqlCommand("SELECT avdeling_id FROM avdeling WHERE avd_navn ='" & CboAdminEBAvdeling.Text & "';", Tilkobling)

            Dim AdminEndreBrukerIDAdapter As New MySqlDataAdapter
            Dim AdminEndreBrukerIDTable As New DataTable

            AdminEndreBrukerIDAdapter.SelectCommand = AdminEndreBruker4
            AdminEndreBrukerIDAdapter.Fill(AdminEndreBrukerIDTable)

            Dim AdminNyBrukerRow As DataRow

            For Each AdminNyBrukerRow In AdminEndreBrukerIDTable.Rows
                AdminAvdelingNavn = AdminNyBrukerRow("avdeling_id")
            Next

            Dim AdminEndreBruker1 As New MySqlCommand("UPDATE brukere SET avdeling_id=" & AdminAvdelingNavn & ", stilling='" & CboAdminEBStilling.Text & "', fornavn='" & TxtAdminEBFornavn.Text & "', etternavn='" & TxtAdminEBEtternavn.Text & "', timelonn=" & TxtAdminEBTime.Text & ", telefon='" & TxtAdminEBTelefon.Text & "', epost='" & TxtAdminEBEpost.Text & "', stilling_prosent=" & CboAdminEBSP.Text & ", admin=" & AdminAdminStatus & " WHERE bruker_id=" & TxtAdminEBBID.Text & ";", Tilkobling)

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


    'Prosedyre for inn lasting av bruker detaljer. Når man taster inn bruker ID så lastes inn info slik at man vet hva det var før.
    'Her har vi mysql kode som laster in tabellen for tilsvarende brukerID. Den kjøres ved knappetrykk.
    'Da populeres det som befinner seg i formen med verdiene som er i tabellen som vi har laget.
    Private Sub AdminLastInnEndreBruker()

        TxtAdminEBBID.Text = SQLWhiteWash(TxtAdminEBBID.Text)
        Dim EBSPString As String = ""
        Dim AdminEBBIDTable As New DataTable
        Dim AdminEBAvdelingID As String = ""
        AdminEBBIDTable = SQLSelect("*", "brukere", "bruker_id='" & TxtAdminEBBID.Text & "'")
        Dim AdminEBBIDRow As DataRow
        For Each AdminEBBIDRow In AdminEBBIDTable.Rows

            TxtAdminEBFornavn.Text = AdminEBBIDRow("fornavn")
            TxtAdminEBEtternavn.Text = AdminEBBIDRow("etternavn")
            TxtAdminEBTime.Text = AdminEBBIDRow("timelonn")
            TxtAdminEBEpost.Text = AdminEBBIDRow("epost")
            TxtAdminEBTelefon.Text = AdminEBBIDRow("telefon")
            CboAdminEBStilling.SelectedItem = AdminEBBIDRow("stilling")
            EBSPString = AdminEBBIDRow("stilling_prosent")
            CboAdminEBSP.SelectedItem = EBSPString
            If AdminEBBIDRow("admin") = "1" Then
                ChkAdminEBAdmin.Checked = True
            End If
            AdminEBAvdelingID = AdminEBBIDRow("avdeling_id")

        Next

        Dim AdminEBAvdelingTable As New DataTable
        AdminEBAvdelingTable = SQLSelect("*", "avdeling", "avdeling_id='" & AdminEBAvdelingID & "'")
        Dim AdminEBAvdelingRow As DataRow

        For Each AdminEBAvdelingRow In AdminEBAvdelingTable.Rows
            CboAdminEBAvdeling.SelectedItem = AdminEBAvdelingRow("avd_navn")
        Next

        If TxtAdminEBFornavn.Text = "" Then
            MsgBox("Brukeren med ID: " & TxtAdminEBBID.Text & " eksisterer ikke.")
        End If

    End Sub


    'Dette er en prosedyre som kjører på hvert lasting av Adminside og ved lagring av ny bruker.
    'Den kalkulerer neste bruker ID automatisk. Dette er gjort fordi det fjerner muligheten for menneskefeil iht bruker id.
    Private Sub AdminBrukerIDCalc()

        Try
            DBConnect()
            Dim AdminBrukerIDKommando As New MySqlCommand("Select COUNT(bruker_id) FROM brukere", Tilkobling)
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


    'Dette er en prosedyre som populerer ComboBoksene til avdelingene. Dette gir muligheten å velge riktig avdelingsnavn.
    'Comboboksene er tatt i bruk for å ha best mulig information hygiene på plass.
    Private Sub AdminAvdelingPopulate()

        Dim AdminAvdelingFString As String = "avdeling"
        Dim AdminAvdelingTable As New DataTable
        Dim AdminAvdelingRow As DataRow
        Dim AdminAvdelingString As String

        AdminAvdelingTable = SQLSelect(AdminAvdelingFString, "avd_navn", "1")
        CboAdminNBAvdeling.Items.Clear()
        CboAdminEBAvdeling.Items.Clear()

        For Each AdminAvdelingRow In AdminAvdelingTable.Rows
            AdminAvdelingString = AdminAvdelingRow("avd_navn")
            CboAdminNBAvdeling.Items.Add(AdminAvdelingString)
            CboAdminEBAvdeling.Items.Add(AdminAvdelingString)
        Next
    End Sub


    'Dette er søkeboksprosedyren.
    'Den søker vha et select command som gjør at søkefeltet er kolonnen som blir søket på. Vi bruker også LIKE sql commando som gjør at vi får partial matching.
    Private Sub AdminBSSokB_Click(sender As Object, e As EventArgs) Handles AdminBSSokB.Click

        Dim AdminSoekefelt, AdminSoekekategori As String
        AdminSoekefelt = SQLWhiteWash(TxtAdminBSFelt.Text)
        AdminSoekekategori = CboAdminBSEtter.Text

        Try
            DBConnect()
            Dim AdminBrukerSearch As New MySqlCommand("SELECT * FROM brukere WHERE " & AdminSoekekategori & " LIKE '%" & AdminSoekefelt & "%'", Tilkobling)
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


    'Dette oppdaterer MOTD i databasen og reflekterer det som vises på fremsiden. Man klikker på knappen for å kjøre koden.
    'Den kjører også en tilleggsprosydre som oppdaterer på start siden også.
    Private Sub AdminMOTDEndreB_Click(sender As Object, e As EventArgs) Handles AdminMOTDEndreB.Click

        TxtAdminMOTD.Text = SQLWhiteWash(TxtAdminMOTD.Text)

        Try
            DBConnect()
            Dim AdminMOTDSet As New MySqlCommand("UPDATE message_of_the_day SET message = '" & TxtAdminMOTD.Text & "' WHERE message_id = 1;", Tilkobling)
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
        Dim NBInputSjekk As Boolean

        NBInputSjekk = CheckVarChar30(TxtAdminNBPassord.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig passord. (Mindre enn 30 tegn)")
            Exit Sub
        End If
        NBInputSjekk = CheckVarChar20(TxtAdminNBFornavn.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig fornavn. (Mindre enn 20 tegn)")
            Exit Sub
        End If
        NBInputSjekk = CheckVarChar30(TxtAdminNBEtternavn.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig etternavn. (Mindre enn 30 tegn)")
            Exit Sub
        End If
        NBInputSjekk = CheckIntValue(TxtAdminNBTime.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig timelønn. Tallformat.")
            Exit Sub
        End If
        NBInputSjekk = CheckVarChar30(TxtAdminNBEpost.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig epost. (Mindre enn 30 tegn)")
            Exit Sub
        End If
        NBInputSjekk = CheckVarChar15(TxtAdminNBTelefon.Text)
        If NBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig passord. (Mindre enn 30 tegn)")
            Exit Sub
        End If

        AdminNyBruker()
        AdminBrukerIDCalc()
    End Sub


    Private Sub AdminEBLastInnB_Click(sender As Object, e As EventArgs) Handles AdminEBLastInnB.Click
        AdminLastInnEndreBruker()
    End Sub


    Private Sub AdminEBEndreB_Click(sender As Object, e As EventArgs) Handles AdminEBEndreB.Click
        Dim EBInputSjekk As Boolean

        EBInputSjekk = CheckIntValue(TxtAdminEBBID.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig Bruker ID. (Tall mindre enn 12 char)")
            Exit Sub
        End If
        EBInputSjekk = CheckVarChar20(TxtAdminEBFornavn.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig fornavn. (Mindre enn 20 char)")
            Exit Sub
        End If
        EBInputSjekk = CheckVarChar30(TxtAdminEBEtternavn.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig etternavn. (Mindre enn 30 char)")
            Exit Sub
        End If
        EBInputSjekk = CheckIntValue(TxtAdminEBTime.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig timelønn. Tallformat.")
            Exit Sub
        End If
        EBInputSjekk = CheckVarChar30(TxtAdminEBEpost.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig epost. (Mindre enn 30 char)")
            Exit Sub
        End If
        EBInputSjekk = CheckVarChar15(TxtAdminEBTelefon.Text)
        If EBInputSjekk = False Then
            MsgBox("Vennligst tast inn gyldig passord. (Mindre enn 30 char)")
            Exit Sub
        End If

        AdminEndreBruker()

    End Sub




















































#End Region


#Region "LoginTab"

    Public Sub LoginCheck()

        Dim LoginBrukerTabell As New DataTable
        Dim LoginPassordTabell As New DataTable
        Dim LoginBrukerCheck As String = ""
        Dim LoginPassordCheck As String = ""
        Dim LoginAdminCheck As Integer = 0
        Dim LoginFornavn As String = ""
        Dim LoginEtternavn As String = ""
        Dim LoginBrukerTabellRow As DataRow
        Dim LoginPassordTabellRow As DataRow

        If SecurityCounter = 3 Then
            MsgBox("Du har blitt låst ut grunnet for mange feilforsøk.")
            Exit Sub
        End If

        If IsNumeric(TxtLoginBrukerID.Text) Then
        Else
            MsgBox("Vennligst tast inn gyldig BrukerID.")
            Exit Sub
        End If
        TxtLoginBrukerID.Text = SQLWhiteWash(TxtLoginBrukerID.Text)
        TxtLoginPassord.Text = SQLWhiteWash(TxtLoginPassord.Text)

        LoginBrukerTabell = SQLSelect("brukere", "*", "bruker_id=" & TxtLoginBrukerID.Text)
        LoginPassordTabell = SQLSelect("passord", "*", "pwd='" & TxtLoginPassord.Text & "' AND passord_id=" & TxtLoginBrukerID.Text)

        For Each LoginBrukerTabellRow In LoginBrukerTabell.Rows
            LoginBrukerCheck = LoginBrukerTabellRow("bruker_id")
            LoginFornavn = LoginBrukerTabellRow("fornavn")
            LoginEtternavn = LoginBrukerTabellRow("etternavn")
            LoginAdminCheck = LoginBrukerTabellRow("admin")
        Next

        For Each LoginPassordTabellRow In LoginPassordTabell.Rows
            LoginPassordCheck = LoginPassordTabellRow("pwd")
        Next

        If TxtLoginBrukerID.Text = LoginBrukerCheck And TxtLoginPassord.Text = LoginPassordCheck Then

        Else
            SecurityCounter = SecurityCounter + 1

            If SecurityCounter = 3 Then
                MsgBox("BrukerID, Passord eller begge er feil. Du har blitt låst ut grunnet for mange feilforsøk.")
            Else
                MsgBox("BrukerID, Passord eller begge er feil. Vennligst prøv igjen. Du har " & (3 - SecurityCounter) & " forsøk igjen.")
            End If
            Exit Sub
        End If

        If LoginAdminCheck <> 0 Then
            AdminBool = True
        End If
        LogBool = True
        FornavnString = LoginFornavn
        EtternavnString = LoginEtternavn
        LoginSuccess()
    End Sub

    Public Sub LoginSuccess()
        With HovedTab.TabPages
            .Insert(0, StartTab)
            .Insert(1, UtleieTab)
            .Insert(2, KDTab)
            .Insert(3, InventarTab)
            .Insert(4, LogiTab)
            .Insert(5, StatTab)
            .Remove(LoginTab)

        End With
        If AdminBool = True Then
            With HovedTab.TabPages
                .Insert(6, AdminTab)
                .Insert(7, DBAdminTab)
            End With
            StartRettigheterLabel.Text = "Brukerrettigheter: Admin"
        Else
            StartRettigheterLabel.Text = "Brukerrettigheter: Bruker"
        End If

        HovedTab.SelectedTab = StartTab

        StartVelkommenLabel.Text = "Velkommen, " & FornavnString & " " & EtternavnString
        StartMOTDUpdate()
    End Sub

    Private Sub BtnLoginLogin_Click(sender As Object, e As EventArgs) Handles BtnLoginLogin.Click
        LoginCheck()
    End Sub

    Private Sub BtnLoginAvslutt_Click(sender As Object, e As EventArgs) Handles BtnLoginAvslutt.Click
        End
    End Sub









#End Region


#Region "AdminDB"


    Private Sub LvAdminListview2_Sort(sender As Object, e As EventArgs) Handles LvDBASokboks.ColumnClick
        ColumnClick(sender, e)
    End Sub


    Private Sub DBANyAvdeling()
        Dim DBALandTable As New DataTable
        Dim DBALandRow As DataRow
        Dim LandString As String = ""

        TxtDBAAvdNavn.Text = SQLWhiteWash(TxtDBAAvdNavn.Text)
        TxtDBAAvdAdr.Text = SQLWhiteWash(TxtDBAAvdAdr.Text)

        DBALandTable = SQLSelect("landsdel", "landsdel_id", "landsdel_navn='" & CboDBALandsdel.Text & "'")

        For Each DBALandRow In DBALandTable.Rows
            LandString = DBALandRow("landsdel_id")
        Next

        SQLInsert("avdeling", "(avd_navn, avd_adresse, landsdel_id)", "('" & TxtDBAAvdNavn.Text & "', '" & TxtDBAAvdAdr.Text & "', '" & LandString & "')")

        TxtDBAAvdNavn.Text = ""
        TxtDBAAvdAdr.Text = ""

    End Sub

    Private Sub DBANyUtstyrskategori()

        TxtDBAKnavn.Text = SQLWhiteWash(TxtDBAKnavn.Text)

        SQLInsert("utstyr_kategori", "(utstyr_kat)", "('" & TxtDBAKnavn.Text & "')")

        TxtDBAKnavn.Text = ""

    End Sub

    Private Sub DBANySykkelType()

        TxtDBATypeNavn.Text = SQLWhiteWash(TxtDBATypeNavn.Text)
        TxtDBATimepris.Text = SQLWhiteWash(TxtDBATimepris.Text)
        TxtDBADognpris.Text = SQLWhiteWash(TxtDBADognpris.Text)
        TxtDBAUkepris.Text = SQLWhiteWash(TxtDBAUkepris.Text)

        SQLInsert("sykkel_typer", "(kategori, sykkel_kat_timepris, sykkel_kat_døgnpris, sykkel_kat_ukepris)", "('" & TxtDBATypeNavn.Text & "', '" & TxtDBATimepris.Text & "', '" & TxtDBADognpris.Text & "', '" & TxtDBAUkepris.Text & "')")

        TxtDBATypeNavn.Text = ""
        TxtDBATimepris.Text = ""
        TxtDBADognpris.Text = ""
        TxtDBAUkepris.Text = ""


    End Sub

    Private Sub DBAEndreAvdeling()
        Dim DBALandTable As New DataTable
        Dim DBALandRow As DataRow
        Dim LandString As String = ""

        SQLWhiteWash(TxtDBAAvdelingID.Text)
        TxtDBAAvdNavn.Text = SQLWhiteWash(TxtDBAAvdNavn.Text)
        TxtDBAAvdAdr.Text = SQLWhiteWash(TxtDBAAvdAdr.Text)

        DBALandTable = SQLSelect("landsdel", "landsdel_id", "landsdel_navn='" & CboDBALandsdel.Text & "'")

        For Each DBALandRow In DBALandTable.Rows
            LandString = DBALandRow("landsdel_id")
        Next

        SQLUpdate("avdeling", "avd_navn='" & TxtDBAAvdNavn.Text & "', avd_adresse='" & TxtDBAAvdAdr.Text & "', landsdel_id='" & LandString & "'", "avdeling_id='" & TxtDBAAvdelingID.Text & "'")

        TxtDBAAvdelingID.Text = ""
        TxtDBAAvdNavn.Text = ""
        TxtDBAAvdAdr.Text = ""

    End Sub

    Private Sub DBAEndreUtstyrskategori()

        TxtDBAKID.Text = SQLWhiteWash(TxtDBAKID.Text)
        TxtDBAKnavn.Text = SQLWhiteWash(TxtDBAKnavn.Text)

        SQLInsert("utstyr_kategori", "(utstyr_kat)", "('" & TxtDBAKnavn.Text & "')")
        SQLUpdate("utstyr_kategori", "utstyr_kat='" & TxtDBAKnavn.Text & "'", "utstyr_kat_id='" & TxtDBAKID.Text & "'")

        TxtDBAKID.Text = ""
        TxtDBAKnavn.Text = ""

    End Sub

    Private Sub DBAEndreSykkelType()

        TxtDBATypeID.Text = SQLWhiteWash(TxtDBATypeID.Text)
        TxtDBATypeNavn.Text = SQLWhiteWash(TxtDBATypeNavn.Text)
        TxtDBATimepris.Text = SQLWhiteWash(TxtDBATimepris.Text)
        TxtDBADognpris.Text = SQLWhiteWash(TxtDBADognpris.Text)
        TxtDBAUkepris.Text = SQLWhiteWash(TxtDBAUkepris.Text)

        SQLUpdate("sykkel_typer", "kategori='" & TxtDBATypeNavn.Text & "', sykkel_kat_timepris='" & TxtDBATimepris.Text & "', sykkel_kat_døgnpris='" & TxtDBADognpris.Text & "', sykkel_kat_ukepris='" & TxtDBAUkepris.Text & "'", "type_id='" & TxtDBATypeID.Text & "'")

        TxtDBATypeID.Text = ""
        TxtDBATypeNavn.Text = ""
        TxtDBATimepris.Text = ""
        TxtDBADognpris.Text = ""
        TxtDBAUkepris.Text = ""

    End Sub

    Private Sub DBALastInnSykkelType()

        Dim DBASTTable As New DataTable
        Dim DBASTRow As DataRow


        TxtDBATypeID.Text = SQLWhiteWash(TxtDBATypeID.Text)

        DBASTTable = SQLSelect("sykkel_typer", "*", "type_id='" & TxtDBATypeID.Text & "'")

        For Each DBASTRow In DBASTTable.Rows
            TxtDBAUkepris.Text = DBASTRow("sykkel_kat_ukepris")

            TxtDBATimepris.Text = DBASTRow("sykkel_kat_timepris")
            TxtDBATypeNavn.Text = DBASTRow("kategori")
        Next

    End Sub

    Private Sub DBALastInnUtstyrskategori()

        Dim DBAUKTable As New DataTable
        Dim DBAUKRow As DataRow


        TxtDBAKID.Text = SQLWhiteWash(TxtDBAKID.Text)

        DBAUKTable = SQLSelect("utstyr_kategori", "*", "utstyr_kat_id='" & TxtDBAKID.Text & "'")

        For Each DBAUKRow In DBAUKTable.Rows
            TxtDBAKnavn.Text = DBAUKRow("utstyr_kat")
        Next

    End Sub

    Private Sub DBALastInnAvdeling()

        Dim DBAAvdelingTable As New DataTable
        Dim DBAAvdelingRow As DataRow
        Dim DBAAvdelingLandRow As DataRow
        Dim LandString As String = ""

        TxtDBAAvdelingID.Text = SQLWhiteWash(TxtDBAAvdelingID.Text)

        DBAAvdelingTable = SQLSelect("avdeling", "*", "avdeling_id='" & TxtDBAAvdelingID.Text & "'")

        For Each DBAAvdelingRow In DBAAvdelingTable.Rows
            TxtDBAAvdNavn.Text = DBAAvdelingRow("avd_navn")
            TxtDBAAvdAdr.Text = DBAAvdelingRow("avd_adresse")
            LandString = DBAAvdelingRow("landsdel_id")
        Next

        DBAAvdelingTable = SQLSelect("landsdel", "landsdel_navn", "landsdel_id='" & LandString & "'")

        For Each DBAAvdelingLandRow In DBAAvdelingTable.Rows
            CboDBALandsdel.SelectedItem = DBAAvdelingLandRow("landsdel_navn")
        Next

    End Sub

    Private Sub DBASokefelt()

        Dim DBASoekefelt, DBASoekekategori, DBATableChoose, DBAIDChoose, DBANameChoose As String
        DBASoekefelt = SQLWhiteWash(TxtDBASokefelt.Text)
        DBASoekekategori = CboDBASokeetter.Text


        If DBASoekekategori = "avdeling_id" Or DBASoekekategori = "avd_navn" Or DBASoekekategori = "avd_adresse" Or DBASoekekategori = "landsdel" Then
            DBATableChoose = "avdeling"
            DBAIDChoose = "avdeling_id"
            DBANameChoose = "avd_navn"
        ElseIf DBASoekekategori = "type_id" Or DBASoekekategori = "sykkelkategori" Then
            DBATableChoose = "sykkel_typer"
            DBAIDChoose = "type_id"
            DBANameChoose = "sykkelkategori"
        Else
            DBATableChoose = "utstyr_kategori"
            DBAIDChoose = "utstyr_kat_id"
            DBANameChoose = "utstyr_kat"
        End If

        Try
            DBConnect()
            Dim DBASearch As New MySqlCommand("SELECT * FROM " & DBATableChoose & " WHERE " & DBASoekekategori & " LIKE '%" & DBASoekefelt & "%'", Tilkobling)
            Dim DBASearchAdapter As New MySqlDataAdapter
            Dim DBASearchTable As New DataTable
            DBASearchAdapter.SelectCommand = DBASearch
            DBASearchAdapter.Fill(DBASearchTable)
            DBDisconnect()
            Dim DBARow As DataRow

            LvAdminBS.Items.Clear()
            For Each DBARow In DBASearchTable.Rows

                LvDBASokboks.Items.Add(New ListViewItem({DBARow(DBAIDChoose), DBARow(DBANameChoose), DBARow(DBASoekekategori)}))
            Next
        Catch AdminSqlError2 As MySqlException
            MsgBox("Man får ikke koble til databasen: " & AdminSqlError2.Message)
        End Try

    End Sub

    Private Sub BtnDBAAvdNy_Click(sender As Object, e As EventArgs) Handles BtnDBAAvdNy.Click
        DBANyAvdeling()
    End Sub

    Private Sub BtnDBASTNy_Click(sender As Object, e As EventArgs) Handles BtnDBASTNy.Click
        DBANySykkelType()
    End Sub

    Private Sub BtnDBASTEndre_Click(sender As Object, e As EventArgs) Handles BtnDBASTEndre.Click
        DBAEndreSykkelType()
    End Sub

    Private Sub BtnDBAAvdLast_Click(sender As Object, e As EventArgs) Handles BtnDBAAvdLast.Click

        DBALastInnAvdeling()

    End Sub

    Private Sub UKLast_Click(sender As Object, e As EventArgs) Handles UKLast.Click
        DBALastInnUtstyrskategori()
    End Sub

    Private Sub BtnDBAUKEndre_Click(sender As Object, e As EventArgs) Handles BtnDBAUKEndre.Click
        DBAEndreUtstyrskategori()
    End Sub

    Private Sub BtnDBAAvdEndre_Click(sender As Object, e As EventArgs) Handles BtnDBAAvdEndre.Click
        DBAEndreAvdeling()
    End Sub


    Private Sub BtnDBASTLast_Click(sender As Object, e As EventArgs) Handles BtnDBASTLast.Click
        DBALastInnSykkelType()
    End Sub



    Private Sub BtnDBASok_Click(sender As Object, e As EventArgs) Handles BtnDBASok.Click
        DBASokefelt()
    End Sub

    Private Sub BtnDBAUKNy_Click(sender As Object, e As EventArgs) Handles BtnDBAUKNy.Click
        DBANyUtstyrskategori()
    End Sub



#End Region
End Class
