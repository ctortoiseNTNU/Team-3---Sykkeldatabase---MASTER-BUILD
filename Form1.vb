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
                MsgBox("KDBmeny")
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
#End Region


#Region "InventarTab"
    'Her plasseres kode som er relevant til Inventar Tab.
    'Variabler som brukes her skal begynne med Inv. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    'Dropdown:
    'Kategori er delt i sykkel og utstyr.
    'Subkategorier vil avhenge av om det er sykkel eller utstyr som skal registreres. Disse må fastsettes.
    'Standardvalg for status, skadet, savnet er henholdsvis inne, nei, nei. ???

    'LblInvProduktID viser ID til objekt som ønskes endret.
    'LblInvRegistrertID viser ID til produkt som er registrert ETTER registreringen er fullført.

    'MsgBox for bekreftelse av registrering og endring av objekter.

    Private Sub BtnInvRegistrer_Click(sender As Object, e As EventArgs) Handles BtnInvRegistrer.Click

        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvSokefelt, InvProduktID As String

        Dim InvForhandlerID, InvAvdelingID, InvSubKategoriID As String

        Dim InvForhandlerIDSporring, InvAvdelingIDSporring, InvSubKategoriIDSporring As String

        Dim InvRegistrerSporring As String

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

        Dim InvSqlID As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader
        Try
            DBConnect()

            InvSqlID = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlID = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlID = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlID.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try


        'SQLspørring for innlegging av sykkel/utstyr i database. Data hentes fra felt
        If CboInvKategori.SelectedItem = "Sykkel" Then
            InvRegistrerSporring = "INSERT INTO sykler (forhandler_id, type_id, avdeling_id, sykkel_navn, " &
                "sykkel_modell, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet)" _
                & "VALUES (""" + InvForhandlerID & """, """ & InvSubKategoriID & """, """ _
                & InvAvdelingID + """, """ & InvProduktnavn & """, """ & InvVarenummer & """, """ _
                & InvInnkjopspris & """, """ & InvStatus & """, """ & InvHjulstorrlese & """, """ _
                & InvRamme & """, """ & InvGirsystem & """, """ & InvSavnet & """, """ & InvSkadet & """);"

            Try
                DBConnect()
                Dim da As New MySqlDataAdapter
                Dim sqlRegistrer As New MySqlCommand(InvRegistrerSporring, tilkobling)
                Dim interntabell As New DataTable
                da.SelectCommand = sqlRegistrer
                da.Fill(interntabell)
                DBDisconnect()
            Catch ex As MySqlException
                MsgBox(ex.Message)
            End Try

        Else
            'Spørring for innlegg av utstyr.
            'Elementer i combobox for subkat må endres til subkat for utstyr.
            'VedBytteAvVerdi.comboboxkat -> comboboxsubkat.elementer = ...
        End If


    End Sub

    Private Sub BtnInvSoke_Click(sender As Object, e As EventArgs) Handles BtnInvSoke.Click
        'skadet og savnet må settes selectedindex - ?

        'Tømmer tidligere søkeresultat fra listview
        LivSok.Items.Clear()

        Dim InvForhandlerID As String
        Dim InvAvdelingID As String
        Dim InvSubKategoriID As String

        Dim InvForhandlerNavn As String = CboInvForhandler.SelectedItem
        Dim InvAvdelingNavn As String = CboInvAvdeling.SelectedItem
        Dim InvSubKategori As String = CboInvSubkategori.SelectedItem

        Dim InvForhandlerIDSporring As String = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='" & InvForhandlerNavn & "';"
        Dim InvAvdelingIDSporring As String = "SELECT avdeling_id FROM avdeling WHERE avd_navn='" & InvAvdelingNavn & "';"
        Dim InvSubKategoriIDSporring As String = "SELECT type_id FROM sykkel_typer WHERE kategori='" & InvSubKategori & "';"

        Dim InvSqlCom As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        'SQLspørringer for henting av id fra forhandler, avdeling og subkategori
        Try
            DBConnect()

            InvSqlCom = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
            InvSqlLeser = InvSqlCom.ExecuteReader()
            While InvSqlLeser.Read()
                InvForhandlerID = InvSqlLeser("forhandler_id")
            End While
            InvSqlLeser.Close()

            InvSqlCom = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
            InvSqlLeser = InvSqlCom.ExecuteReader()
            While InvSqlLeser.Read()
                InvAvdelingID = InvSqlLeser("avdeling_id")
            End While
            InvSqlLeser.Close()

            InvSqlCom = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
            InvSqlLeser = InvSqlCom.ExecuteReader()
            While InvSqlLeser.Read()
                InvSubKategoriID = InvSqlLeser("type_id")
            End While
            InvSqlLeser.Close()

            DBDisconnect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim SpSkadet As String
        Dim SpSavnet As String
        Dim SpInit As String = "SELECT * FROM sykler WHERE "
        Dim SpSykkelNavn As String = "sykkel_navn LIKE '%" & TxtInvProduktnavn.Text.Trim & "%'"
        Dim SpsykkelModell As String = "type_id LIKE '%" & InvSubKategoriID & "%'"
        Dim SpTypeid As String = "sykkel_modell LIKE '%" & TxtInvVareNummer.Text.Trim & "%'"
        Dim SpSykkelRamme As String = "sykkel_ramme LIKE '%" & TxtInvRamme.Text.Trim & "%'"
        Dim SpGirsystem As String = "girsystem LIKE '%" & TxtInvGirsystem.Text.Trim & "%'"
        Dim SpHjulstorrelse As String = "hjul_str LIKE '%" & TxtInvHjulstorrelse.Text.Trim & "%'"
        Dim SpSykkelPris As String = "sykkel_pris LIKE '%" & TxtInvInnkjopspris.Text.Trim & "%'"
        Dim SpAvdeling As String = "avdeling_id LIKE '%" & InvAvdelingID & "%'"
        Dim SpForhandlerID As String = "forhandler_id LIKE '%" & InvForhandlerID & "%'"
        Dim SpSykkelStatus As String = "sykkel_status LIKE '%" & CboInvStatus.SelectedItem & "%'"

        'Unngår NULL verdi fra combobox skadet og savnet - (nødvendig?)
        If CboInvSkadet.SelectedIndex = 0 Or CboInvSkadet.SelectedIndex = 1 Then
            SpSkadet = "skadet LIKE '%" & CboInvSkadet.SelectedIndex & "%'"
        Else
            SpSkadet = "skadet LIKE '%%'"
        End If

        If CboInvSavnet.SelectedIndex = 0 Or CboInvSavnet.SelectedIndex = 1 Then
            SpSavnet = "savnet LIKE '%" & CboInvSavnet.SelectedIndex & "%'"
        Else
            SpSavnet = "savnet LIKE '%%'"
        End If

        Dim Sporring As String
        Sporring = SpInit & SpSykkelNavn & " AND " & SpsykkelModell & " AND " &
            SpTypeid & " AND " & SpSykkelRamme & " AND " & SpGirsystem & " AND " &
            SpHjulstorrelse & " AND " & SpSykkelPris & " AND " & SpAvdeling & " AND " &
            SpForhandlerID & " AND " & SpSykkelStatus & " AND " & SpSkadet & " AND " & SpSavnet & ";"

        Dim InvResultatArray(12) As String
        Dim InvResultatObjekt As ListViewItem

        'Sender spørring basert på innlagte data i skjema [navn] og skriver ut returnerte rader til listview [navn]
        Try
            DBConnect()

            InvSqlCom = New MySqlCommand(Sporring, tilkobling)
            InvSqlLeser = InvSqlCom.ExecuteReader()

            'for hver kolonne les inn verdi 0-12 og legg i listview
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
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtnInvEndre_Click(sender As Object, e As EventArgs) Handles BtnInvEndre.Click
        'SQLspørring med _endring_ (alter table) av data for valgt produkt med ID fra valgt produkt i søkefelt
    End Sub

    Private Sub BtnIvnSokEndre_Click(sender As Object, e As EventArgs) Handles BtnIvnSokEndre.Click
        'ID nummer hentes fra TxtInvSokProduktID og SQLspørring henter objektet og legger verdiene i feltet for
        'registrering/endring. 
        Dim InvKategori, InvSubkategori, InvAvdeling, InvProduktnavn, InvVarenummer, InvInnkjopspris,
            InvRamme, InvHjulstorrlese, InvGirsystem, InvForhandler, InvStatus, InvSkadet, InvSavnet,
            InvSokefelt, InvProduktID As String
        Dim InvForhandlerID, InvAvdelingID, InvSubKategoriID As String
        Dim InvForhandlerIDSporring, InvAvdelingIDSporring, InvSubKategoriIDSporring As String
        Dim InvRegistrerSporring As String

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

        InvForhandlerIDSporring = "SELECT forhandler_id FROM forhandler WHERE forhandler_navn='testforhandler';"
        InvAvdelingIDSporring = "SELECT avdeling_id FROM avdeling WHERE avd_navn='Finse';"
        InvSubKategoriIDSporring = "SELECT type_id FROM sykkel_typer WHERE kategori='Racer';"

        Dim InvSqlID As MySqlCommand
        Dim InvSqlLeser As MySqlDataReader

        DBConnect()

        InvSqlID = New MySqlCommand(InvForhandlerIDSporring, tilkobling)
        InvSqlLeser = InvSqlID.ExecuteReader()
        While InvSqlLeser.Read()
            InvForhandlerID = InvSqlLeser("forhandler_id")
        End While
        InvSqlLeser.Close()
        InvSqlID = New MySqlCommand(InvAvdelingIDSporring, tilkobling)
        InvSqlLeser = InvSqlID.ExecuteReader()
        While InvSqlLeser.Read()
            InvAvdelingID = InvSqlLeser("avdeling_id")
        End While
        InvSqlLeser.Close()
        InvSqlID = New MySqlCommand(InvSubKategoriIDSporring, tilkobling)
        InvSqlLeser = InvSqlID.ExecuteReader()
        While InvSqlLeser.Read()
            InvSubKategoriID = InvSqlLeser("type_id")
        End While
        InvSqlLeser.Close()
        DBDisconnect()

        InvRegistrerSporring = "SELECT * FROM sykler WHERE forhandler_id LIKE '%" & InvForhandlerID _
            & "%'"

        ', type_id, avdeling_id, sykkel_navn, " &
        '        "sykkel_modell, sykkel_pris, sykkel_status, hjul_str, sykkel_ramme, girsystem, savnet, skadet)""



        ' & "VALUES (""" + InvForhandlerID & """, """ & InvSubKategoriID & """, """ _
        '                & InvAvdelingID + """, """ & InvProduktnavn & """, """ & InvVarenummer & """, """ _
        '                & InvInnkjopspris & """, """ & InvStatus & """, """ & InvHjulstorrlese & """, """ _
        '                & InvRamme & """, """ & InvGirsystem & """, """ & InvSavnet & """, """ & InvSkadet & """);"



    End Sub

    Private Sub BtnInvSokSok_Click(sender As Object, e As EventArgs) Handles BtnInvSokSok.Click
        'SQLspørring med valgte søkekriterier for søk etter objekter 
        'Bruke samme skjema som reg/endre? 
        'chkbox for å velge kolonner som skal vises
        '  SELECT * FROM sykler WHERE diverse_felt = søkeverdi AND subkat, status, skadet, savnet = verdier

        DBConnect()


        'test for søk
        Dim testcommand As MySqlCommand
        Dim testleser As MySqlDataReader
        Dim testsporring As String
        Dim testarray(12) As String
        Dim arritem As ListViewItem
        Dim testsporring3 As String
        Dim InvSokeKategori As String = "sykkel_navn"
        testsporring = "SELECT * FROM sykler WHERE " & InvSokeKategori & " Like '%" & TxtInvSokSokefelt.Text & "%'"
        testsporring3 = "SELECT * FROM sykler WHERE forhandler_id LIKE '%" & CboInvForhandler.SelectedItem & "%'"

        'SELECT sykler.sykkel_navn, forhandler.forhandler_navn FROM sykler INNER JOIN forhandler ON sykler.forhandler_id=forhandler.forhandler_id

        'testsporring2 = "select * From sykler where forhandler_id=""9999"";"
        testcommand = New MySqlCommand(testsporring3, tilkobling)
        testleser = testcommand.ExecuteReader()

        'for hver kolonne les inn verdi 0-12 og legg i listview
        While testleser.Read()
            For i = 0 To testleser.FieldCount - 1
                If TypeOf testleser(i) Is DBNull Then
                Else
                    testarray(i) = testleser(i)
                End If
            Next
            arritem = New ListViewItem(testarray)
            LivSok.Items.Add(arritem)
        End While

        '   legger inn i listbox
        'Dim testdata As String
        'While testleser.Read()
        '    testdata = ""
        '    For i = 0 To testleser.FieldCount - 1
        '        If TypeOf testleser(i) Is DBNull Then
        '            testdata = testdata + ""
        '        Else
        '            If testdata = "" Then
        '                testdata = CStr(testleser(i))
        '            Else
        '                testdata = testdata + " - " + CStr(testleser(i))
        '            End If
        '        End If
        '    Next
        '    LstInvSokSokeResultat.Items.Add(testdata)
        'End While

        testleser.Close()

        DBDisconnect()

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
                CboAdminEBStilling.SelectedText = AdminEBBIDRow("stilling")
                CboAdminEBSP.SelectedText = AdminEBBIDRow("stilling_prosent")
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
                CboAdminEBAvdeling.SelectedText = AdminEBAvdelingRow("avd_navn")
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
