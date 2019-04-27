Imports MySql.Data.MySqlClient

Public Class Form1
#Region "GlobaleVariabler"
    'Her plasseres globale variabler
    'som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.
    'Test forandring
    ' Test hilsen IVar
    'Globalevariabler som må sjekkes ved ønsket tilgang. LogBool settes til TRUE ved inlogging, AdminBool settes til TRUE hvis bruker er admin.
    'e
    Dim LogBool As Boolean
    Dim AdminBool As Boolean
#End Region

#Region "GlobaleFunksjonerOgProsedyrer"
    'Her plasseres globale funksjoner og prosdyrer som gjenbrukes over programmet. De er uten navnekonvensjon
    'Husk å kommentere på kodensfunksjon og hvor i programmet den er tatt i bruk.

    Private Sub DBConnect()
        '     tilkobling = New MySqlConnection(
        '    "Server=mysql-ait.stud.idi.ntnu.no;" _
        '   & "Database=colinft;" _
        '  & "Uid=colinft;" _
        ' & "Pwd=BJhYR1HS;")
        'Try
        'tilkobling.Open()
        'Catch ex As MySqlException
        'MsgBox(ex)
        'End Try
    End Sub

    Private Sub DBDisconnect()
        '   tilkobling.Close()
        '   tilkobling.Dispose()
    End Sub
#End Region

#Region "Form Load og Login"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





#End Region

#Region "StartTab"
    'Her plasseres kode som er relevant til Start Tab.
    'Variabler som brukes her skal begynne med Start. Dette er for å unngå klasj.
    'Husk kode kommentarer.
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

    Private Sub DaTiKndNy_Click(sender As Object, e As EventArgs) Handles DaTiKndNy.Click


    End Sub

    Private Sub DaTiKndNy_ValueChanged(sender As Object, e As EventArgs) Handles DaTiKndNy.ValueChanged
        DaTiKndNy.Format = DateTimePickerFormat.Custom
        DaTiKndNy.CustomFormat = "yyyy-MM-dd"
    End Sub

    'LEGG INN NYE KUNDER
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnKndRegistrer.Click


        KndFornavn = TxtKndFornavn.Text
        KndEtternavn = TxtKndEtternavn.Text
        KndAdresse = TxtKndAdresse.Text

        KndTlf = TxtKndTlf.Text
        KndEpost = TxtKndEpost.Text

        'Insert new data with SQL



        Dim sqlopen = tilkobling()

        Try
            sqlopen.Open
            Dim sporring As New MySqlCommand("INSERT INTO kunder (kunde_fornavn, kunde_etternavn, adresse, telefon, epost, rabatt_id, handlet_for) VALUES ('" & KndFornavn & "', '" & KndEtternavn & "', '" & KndAdresse & "', " & KndTlf & ", '" & KndEpost & "', 1, 0)", sqlopen)
            sporring.ExecuteNonQuery()

            sqlopen.Close()
        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        Finally
            sqlopen.Dispose()
        End Try
    End Sub


    Dim KndSokInput
    Dim KndSokSelectedTag
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
        Dim sqltest = tilkobling()


        Try
            sqltest.Open
            Dim sporring As New MySqlCommand("SELECT * FROM kunder WHERE kunde_id = " & KndSokKundeID, sqltest)
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
            sqltest.Close()

            TxtKndEndreFN.Text = KndFornavnSelected
            TxtKndEndreEN.Text = KndEtternavnSelected
            TxtKndEndreAdr.Text = KndAdresseSelected

            TxtKndEndreTlf.Text = KndTlfSelected
            TxtKndEndreEP.Text = KndEpostSelected
            TxtKndEndreRbt.Text = KndRabattSelected
            TxtKndEndreHF.Text = KndHandletSelected



        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        Finally
            sqltest.Dispose()
        End Try

    End Sub




    'SØK DROPDOWN
    Private Sub CmbKndSok_Click(sender As Object, e As EventArgs) Handles CmbKndSok.Click
        CmbKndSok.Items.Clear()
        Dim innhold = New String() {"ID", "Fornavn", "Etternavn", "Adresse", "Telefon", "Epost", "Rabatt Tier", "Handlet For"}

        For i As Integer = 0 To innhold.Length - 1
            CmbKndSok.Items.Add(innhold(i))
        Next
    End Sub

    'SØK KNAPP

    Private Sub BtnKndSok_Click(sender As Object, e As EventArgs) Handles BtnKndSok.Click
        KndSokInput = TxtKndSok.Text
        Dim KndTempVar = CmbKndSok.SelectedIndex

        Dim KndSQLKolonner = New String() {"kunde_id", "kunde_fornavn", "kunde_etternavn", "adresse", "telefon", "epost", "rabatt_id", "handlet_for"}
        KndSokSelectedTag = KndSQLKolonner(KndTempVar)


        Dim sqlopen = tilkobling()
        Try

            Dim sporring As New MySqlCommand("SELECT * FROM kunder WHERE " & KndSokSelectedTag & " LIKE '%" & KndSokInput & "%'", sqlopen)


            Dim KndSearchAdapter As New MySqlDataAdapter
            Dim KndSearchTable As New DataTable
            KndSearchAdapter.SelectCommand = sporring
            KndSearchAdapter.Fill(KndSearchTable)
            sqlopen.Close()
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
        Finally
            sqlopen.Dispose()
        End Try

        'SQL for søk 
        'Select * from Kunder where kndsokselectedtag = kndsokInput
        'Skriv ut til listbox i søk
        'Legg kundeID i KndSokKundeID for bruk i endring



    End Sub




















    Private Function tilkobling()
        Dim sqlTilkobling As New MySqlConnection(
            "Server=mysql-ait.stud.idi.ntnu.no;" _
            & "Database=colinft;" _
            & "Uid=colinft;" _
            & "Pwd=BJhYR1HS;")
        Return sqlTilkobling
    End Function

    Private Sub BtnKndEndre_Click(sender As Object, e As EventArgs) Handles BtnKndEndre.Click

        Dim selectedKundeId = TxtKndKundeID.Text

        Dim KndChangeValueFN = TxtKndEndreFN.Text
        Dim KndChangeValueEN = TxtKndEndreEN.Text
        Dim KndChangeValueAdr = TxtKndEndreAdr.Text
        Dim KndChangeValueTlf = TxtKndEndreTlf.Text
        Dim KndChangeValueEP = TxtKndEndreEP.Text
        Dim KndChangeValueRbt = TxtKndEndreRbt.Text
        Dim KndChangeValueHF = TxtKndEndreHF.Text
        Dim KndChangeValueDoB = DaTiKndEndre.Value


        Dim openSql = tilkobling()
        Try
            openSql.Open
            Dim sporring As New MySqlCommand("UPDATE kunder SET kunde_fornavn = '" & KndChangeValueFN & "', kunde_etternavn = '" & KndChangeValueEN & "', adresse = '" & KndChangeValueAdr & "', telefon = " & KndChangeValueTlf & ", epost = '" & KndChangeValueEP & "', rabatt_id = " & KndChangeValueRbt & ", handlet_for = " & KndChangeValueHF & " WHERE kunde_id = " & selectedKundeId, openSql)
            sporring.ExecuteNonQuery()

            openSql.Close()

            MsgBox("Endring vellykket")



        Catch feilmelding As MySqlException
            MsgBox("Feil ved tilkobling til databasen: " & feilmelding.Message)
        Finally
            openSql.Dispose()
        End Try


    End Sub




#End Region


#Region "InventarTab"
    'Her plasseres kode som er relevant til Inventar Tab.
    'Variabler som brukes her skal begynne med Inv. Dette er for å unngå klasj.
    'Husk kode kommentarer.

    'testgit morten
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
#End Region
End Class
