Imports System
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading
Imports System.ComponentModel
Imports System.Xml
Imports System.Xml.Linq
Imports System.Linq
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Configuration
Imports System.Collections.Specialized
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form1
    Public csvPath, tracePath, csvLokal, SART, ISNR As String
    Public Vers_Schnitt, Mandant, Port, PfadBGConfig, SART_Vorprozess, FKTGruppe_Vorprozess, Zeit_Verriegelung_Vorprozess, FKTGruppe, PRE_Nutzen_Einzel As String
    Dim rptext, rptims, rptima, rptext_array(26), erco, IDNutzen, PRE_ErgEinzelprint, PRE_ErgNutzen As String
    Dim Pretimestamp, zeit_jetzt As Integer
    Dim ISNR_einzel, ISNR_Nutzen As Boolean
    Dim lzisnr(), lzrei1, lzrei2 As String
    Dim Erg_Ges_AOI As String
    Dim state_einzel, state_nutzen As String
    Dim ISNR_status, ISNR_lzstat As String
    Dim Pers_status, Auftrag_status As String
    Dim ISNR_Abfrage As String = ""
    Dim ISNRmaster As String
    Dim Tabelle As New DataTable
    Dim URLTraceDataExchange, URLProfidDataExchange, URLSMTDataExchange As String
    Private Sub ColorChange(Color As Object)

        'Rechteck zeichnen
        'Dim Rechteck As Graphics = CreateGraphics()
        'Dim pinsel As New SolidBrush(Color)

        'Rechteck.FillRectangle(pinsel, 160, 320, 270, 80)

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '###########Programmversion######################
        ProgVersion.Text = "V06"
        '################################################

        Call Einstellungen.Einstellungen_Load()     'laden der Konfigurationen

        'AppConfig auslesen
        URLTraceDataExchange = ConfigurationManager.AppSettings.Get("URLTraceDataExchange")
        URLProfidDataExchange = ConfigurationManager.AppSettings.Get("URLProfidDataExchange")
        URLSMTDataExchange = ConfigurationManager.AppSettings.Get("URLSMTDataExchange")

        'prüfen, ob lokaler Trace-Ordner vorhanden ist (sonst einen erstellen)
        If IO.Directory.Exists(csvLokal) Then
            'prüfen, ob lokale Tracedaten vorhanden sind
            If My.Computer.FileSystem.GetFiles(csvLokal).Count > 0 Then
                LokalTrace.Visible = True
                LokalTrace.ForeColor = Color.Red
            End If
        Else
            Directory.CreateDirectory(csvLokal)     'lokalen Ordner erstellen
        End If

        'User LOG schreiben
        If IO.Directory.Exists("S:\FTP\MRehberger\Programme\User") Then
            Dim TIMESTAMP_NOW As String = DateTime.Now.ToString("yyyy-MM-dd-HH.mm.ss")
            'strTimeImport = TIMESTAMP_NOW.ToString("yyyy-MM-dd-HH.mm.ss.ffffffzzz")
            Dim inputString As String = vbCrLf & TIMESTAMP_NOW & vbTab & Environment.UserName & vbTab & ProgVersion.Text & vbTab & "Programm geöffnet"
            My.Computer.FileSystem.WriteAllText("S:\FTP\MRehberger\Programme\User\VergussLackieren.txt", inputString, True)
        End If

        Timer1.Enabled = True

        'LblSART.Text = SART
        LblDBPfad.Text = csvPath

        LblErrorText.Text = ""
        TextBoxISNR.Visible = False
        ListBox1.Visible = False
        Label3.Visible = False
        lblAnzahlISNR.Visible = False
        BListelöschen.Visible = False
        BTR3schreiben.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        cbProzess.Visible = False
        LblVerbindung.Visible = True
        LblVerbindung.Text = "Verbindungsprüfung" & vbCrLf & "Netzlaufwerk"
        Me.Refresh()

        TBPersNr.Select()

        'Tabelle erstellen, um Ergebnisse zu den ISNR zu sammeln
        Tabelle.Columns.Add("ISNR", GetType(String))
        Tabelle.Columns.Add("GesErg_Einzel", GetType(String))
        Tabelle.Columns.Add("GesErg_Nutzen", GetType(String))

        TBPersNr.Text = "5160"
        begleitzettel_DMC.Text = "8771865000000001"
        'TextBoxISNR.Text = "9991067423085"  'UBF2411--D    8551093000000001
        'TextBoxISNR.Text = "9991067422922"  'UBF3238--A    8554440000000001
        'TextBoxISNR.Text = "1902338649221" 1912338649220  'UBF3299-1C    8920160000000003
        'TextBoxISNR.Text = "1402515015493" '1912338649220  'UBF3299--C    8920160000000003

    End Sub
    Public Function IsDriveReady(ByVal sDrive As String) As Boolean
        ' Prüft, ob das angegebene Laufwerk existiert und 
        ' ob darauf zugegriffen werden kann
        Try
            Dim oDrive As New System.IO.DriveInfo(sDrive)
            Return oDrive.IsReady
        Catch ex As Exception
            Return False
        End Try
    End Function
    Private Sub bReset_Click(sender As Object, e As EventArgs) Handles bReset.Click
        TBPersNr.Text = ""
        begleitzettel_DMC.Visible = False
        auftrag.Visible = False
        restauftragsnummer.Visible = False
        positionsnummer.Visible = False
        abrufnummer.Visible = False
        auftragdaten.Visible = False
        begleitzettel_DMC.Enabled = True
        auftrag.Text = ""
        restauftragsnummer.Text = ""
        abrufnummer.Text = ""
        positionsnummer.Text = ""
        LblSART.Text = "???"
        lblPreZeit.Text = "???"
        artikel.Text = "???"
        lblFKTGruppe.Text = "???"
        PictureBox2.Visible = False
        TBPersNr.Enabled = True
        Label7.Visible = False
        PictureBox2.Visible = False
        Label8.Visible = False
        cbProzess.Visible = False
        cbProzess.SelectedIndex = 0

        ListBox1.Items.Clear()
        lblAnzahlISNR.Text = ListBox1.Items.Count
        TextBoxISNR.Visible = False
        ListBox1.Visible = False
        Label3.Visible = False
        lblAnzahlISNR.Visible = False
        BListelöschen.Visible = False
        BTR3schreiben.Visible = False
        PictureBox3.Visible = False
        Label6.Visible = False
        LblDBPfad.Visible = False
        Label10.Visible = False
        lblFKTGruppe.Visible = False
        FKTGruppe = ""
        TBPersNr.Select()
    End Sub
    Private Sub ConfigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigToolStripMenuItem.Click
        Process.Start(PfadBGConfig)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Timer1.Interval = 10000     'Intervall auf 10 Sekunden stellen

        If My.Computer.FileSystem.GetFiles(csvLokal).Count > 0 Then
            LokalTrace.Visible = True 'lokale Tracedaten vorhanden
            LokalTrace.ForeColor = Color.Red
            Me.Refresh()
            Trace_move()
        Else
            LokalTrace.Visible = False 'Anzeige lokale Daten vorhanden wieder ausblenden
        End If

        'Verbindung Netzlaufwerk prüfen
        Dim sDrive As String = IO.Path.GetPathRoot(csvPath)
        If IsDriveReady(sDrive) Then
            'MsgBox("Laufwerk " & sDrive & " ist bereit.")
            LblVerbindung.Visible = False
        Else
            LblVerbindung.Visible = True
            LblVerbindung.Text = "Laufwerk " & sDrive & " existiert" & vbCrLf & " nicht oder ist nicht verbunden!"
            Timer1.Interval = 30000     'Intervall auf 30 Sekunden stellen
            'MsgBox("Laufwerk " & sDrive & " existiert nicht oder " &
            ' "das Laufwerk ist nicht verbunden!")
        End If

    End Sub
    Public Sub Trace_move()
        Dim renamedFile As String
        For Each foundFile As String In My.Computer.FileSystem.GetFiles(csvLokal)
            If IO.Directory.Exists(csvPath) Then
                foundFile = IO.Path.GetFileName(foundFile)      'Dateinamen extrahieren
                renamedFile = Path.ChangeExtension(csvPath + foundFile, "tmp")
                File.Move(csvLokal + foundFile, Path.ChangeExtension(csvPath + foundFile, "tmp"))
                File.Move(renamedFile, Path.ChangeExtension(csvPath + foundFile, "csv"))
                'My.Computer.FileSystem.MoveFile(csvLokal + foundFile, csvPath + foundFile, True)    'Datei verschieben
            Else
                Exit For 'Pfad noch immer nicht vorhanden, FOR-Schleife beenden
            End If
            Me.Refresh()
        Next
        Me.Refresh()
    End Sub
    Private Sub begleitzettel_DMC_TextChanged(sender As Object, e As EventArgs) Handles begleitzettel_DMC.TextChanged
        'Thread.Sleep(2000)
        'If begleitzettel_DMC.TextLength > 15 Then
        'begleitzettel_DMC.Text = "8545245000000001"
        If begleitzettel_DMC.Text = "Auftragsdaten einlesen" Then
            begleitzettel_DMC.Clear()
            auftragdaten_Click(sender, e)
        Else
            If begleitzettel_DMC.TextLength = 16 And Not begleitzettel_DMC.Text.Contains("Auftragsdaten") Then

                auftrag.Text = begleitzettel_DMC.Text.Substring(0, 7)
                abrufnummer.Text = begleitzettel_DMC.Text.Substring(7, 3)
                restauftragsnummer.Text = begleitzettel_DMC.Text.Substring(10, 3)
                positionsnummer.Text = begleitzettel_DMC.Text.Substring(13, 3)

                auftragdaten.Enabled = True
                begleitzettel_DMC.Select()
                begleitzettel_DMC.Clear()
            End If
        End If
        'End If
    End Sub
    Private Sub Button_Beenden_Click(sender As Object, e As EventArgs) Handles Button_Beenden.Click
        Me.Close()
    End Sub
    Private Sub BListelöschen_Click() Handles BListelöschen.Click
        ListBox1.Items.Clear()
        lblAnzahlISNR.Text = ListBox1.Items.Count
    End Sub
    Private Sub TBPersNr_TextChanged(sender As Object, e As EventArgs) Handles TBPersNr.TextChanged
        TBPersNr.Select()
        If TBPersNr.TextLength > 3 Then
            Pers_status = ""
            webservice_checkPersonal(TBPersNr.Text, Mandant)

            If Pers_status = "J" Then
                begleitzettel_DMC.Visible = True
                auftrag.Visible = True
                restauftragsnummer.Visible = True
                positionsnummer.Visible = True
                abrufnummer.Visible = True
                auftragdaten.Visible = True
                PictureBox2.Visible = True
                begleitzettel_DMC.Select()
                TBPersNr.Enabled = False
                Label7.Visible = True
            Else
                MsgBox("Personalnummer nicht erlaubt!!!")
                TBPersNr.Clear()
            End If
        End If



    End Sub
    Private Sub auftragdaten_Click(sender As Object, e As EventArgs) Handles auftragdaten.Click
        Auftrag_status = ""
        webservice_getauftrag()

        If Auftrag_status = "2" Or Auftrag_status = "6" Then
            If erco = "88009" Then
                'Fehler
                MsgBox("Auftrag ungültig")
            ElseIf erco = "22005" Then
                'Fehler
                MsgBox("Auftrag gelöscht/storniert")
            ElseIf erco = "22006" Then
                'Fehler
                MsgBox("Auftrag bereits geliefert")
            Else
                auftragdaten.Enabled = False
                begleitzettel_DMC.Enabled = False
                PictureBox2.Visible = False
                Label8.Visible = True
                cbProzess.Visible = True
            End If
        Else
            MsgBox("Auftragstatus ungültig")
            begleitzettel_DMC.Clear()
        End If
        TextBoxISNR.Select()
    End Sub
    Private Sub cbProzess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProzess.SelectedIndexChanged
        If cbProzess.SelectedIndex > 0 Then
            TextBoxISNR.Visible = True
            ListBox1.Visible = True
            Label3.Visible = True
            lblAnzahlISNR.Visible = True
            BListelöschen.Visible = True
            BTR3schreiben.Visible = True
            PictureBox3.Visible = True
            Label6.Visible = True
            LblDBPfad.Visible = True
            Label10.Visible = True
            lblFKTGruppe.Visible = True
            ListBox1.Items.Clear()
            lblAnzahlISNR.Text = ListBox1.Items.Count
            FKTGruppe = cbProzess.Items(cbProzess.SelectedIndex).ToString
            FKTGruppe = Mid(FKTGruppe, InStr(FKTGruppe, "/") + 2, InStr(InStr(FKTGruppe, "/") + 1, FKTGruppe, "/") - InStr(FKTGruppe, "/") - 3)
            'FKTGruppe = FKTGruppe.Substring(FKTGruppe.IndexOf("/ ") + 2)
            SART = Microsoft.VisualBasic.Right(cbProzess.Items(cbProzess.SelectedIndex).ToString, 4)
            INI_BGCongif_lesen()
            TextBoxISNR.Select()
        Else
            TextBoxISNR.Visible = False
            ListBox1.Visible = False
            Label3.Visible = False
            lblAnzahlISNR.Visible = False
            BListelöschen.Visible = False
            BTR3schreiben.Visible = False
            PictureBox3.Visible = False
            Label6.Visible = False
            LblDBPfad.Visible = False
            Label10.Visible = False
            lblFKTGruppe.Visible = False
            FKTGruppe = ""
        End If

        lblFKTGruppe.Text = FKTGruppe
    End Sub
    Private Sub TextBoxISNR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxISNR.TextChanged

        Dim FormError As New Form_Error

        erco = ""

        If TextBoxISNR.Text = "Tracedaten schreiben" Then
            'TR3 Daten schreiben
            BTR3schreiben_Click()
        Else
            If TextBoxISNR.TextLength = 13 And Not TextBoxISNR.Text.Contains("Tracedaten") And Not TextBoxISNR.Text.Contains("Auftragsdaten") Then
                'If TextBoxISNR.TextLength = 43 And Not TextBoxISNR.Text.Contains("Tracedaten") And Not TextBoxISNR.Text.Contains("Auftragsdaten") Then      'für Thomas Magnete
                init_Var()  'alle Variablen initialisieren
                ISNR_Abfrage = TextBoxISNR.Text

                'ISNR_Abfrage = Microsoft.VisualBasic.Right(ISNR_Abfrage, 13)    'für Thomas Magnete
                'webservice_getMaisBySlis(ISNR_Abfrage)
                'ISNR_Abfrage = ISNRmaster
                webservice_checkISNR(ISNR_Abfrage)  'Prüfung, ob ISNR einer Seriennummer entspricht

                'If (ISNR_lzstat = "A" Or ISNR_lzstat = "") Then   'Thomas Magnete
                If (ISNR_lzstat = "A" Or ISNR_lzstat = "") And ISNR_status = "J" Then  'Thomas Magnete

                    webservice_getLzByRei(ISNR_Abfrage) 'prüfen, ob ISNR eine Nutzenseriennummer ist
                    If erco <> "" Then
                        erco = ""   'Fehlercode zurücksetzen
                        ISNR_einzel = True
                        webservice_getLzByIsnr(ISNR_Abfrage)    'prüfen, ob ISNR eine Einzelseriennummer ist
                    Else
                        ISNR_Nutzen = True
                    End If


                    If erco = "" Or (erco <> "" And ISNR_einzel = True) Then 'wenn kein Fehler von Referenzabfrage zurück gekommen ist ODER Fehler+Einzelprint (Einfachprint), dann ausführen
                        If ListBox1.Items.Count >= 1 Then
                            For Each item In ListBox1.Items
                                If item = ISNR_Abfrage Then
                                    LblErrorText.Text = "Seriennummer bereits vorhanden"
                                    LblErrorText.ForeColor = Color.Red
                                    ColorChange(Color.Red)
                                    GoTo PrüfungEnde
                                End If
                            Next
                            GoTo Prüfung
                        Else
Prüfung:
                            If SART_Vorprozess = "" Then    ' wenn Vorprozess deaktiviert, dann wird immer OK angenommen
                                state_einzel = "1"

                                If ISNR_Nutzen = True Then  'wenn Nutzen, dann Ergebniss ALLES OK zusammenbauen
                                    For i = 0 To lzisnr.Length - 1
                                        state_nutzen = state_nutzen & "1"
                                    Next
                                End If
                            Else
                                'Abfrage Vorprozess
                                If PRE_Nutzen_Einzel = "E" Then 'Leiterplattenzustand Vorprozess ist Einzel
                                    webservice_getTraceDataByIsnrAndSart2(ISNR_Abfrage)
                                    If erco = "" Then
                                        PRE_ErgEinzelprint = rptext_array(13)
                                    End If

                                    'Prüfung Wartezeit
                                    zeit_jetzt = (DateTime.Now - New DateTime(DateTime.Now.Year - 1, 1, 1, 0, 0, 0)).TotalMinutes
                                    If (zeit_jetzt - Pretimestamp) < Zeit_Verriegelung_Vorprozess Then
                                        LblErrorText.Text = "Fehler Aushärtezeit" & vbCrLf & "SOLL: " & Zeit_Verriegelung_Vorprozess.ToString & " min    IST: " & (zeit_jetzt - Pretimestamp).ToString & " min"
                                        LblErrorText.ForeColor = Color.Red
                                        ColorChange(Color.Red)
                                        FormError.ISNR = ISNR_Abfrage
                                        FormError.Fehler = 5
                                        FormError.ShowDialog()
                                        GoTo PrüfungEnde
                                    End If
                                ElseIf PRE_Nutzen_Einzel = "N" Then 'Nutzenzustand Vorprozess ist Nutzen
                                    erco = ""
                                    If SART_Vorprozess = "AOI" Then 'Prüfung Vorprozess = AOI
                                        AOI_Ergebnis_verknüpfen()
                                    Else
                                        webservice_getTraceDataByIsnrAndSart2(lzrei1)   'Abfrage mit REI1
                                        If erco <> "" Then  'wenn Fehler, mit REI2 abfragen
                                            erco = ""
                                            webservice_getTraceDataByIsnrAndSart2(lzrei2)
                                        End If
                                    End If

                                    If erco = "" Then
                                        If SART_Vorprozess = "AOI" Then
                                            If ISNR_einzel = True Then
                                                PRE_ErgEinzelprint = Mid(Erg_Ges_AOI, IDNutzen, 1) 'Ergebnis Einzelprint, wenn VorPr. Nutzen war
                                            End If
                                            PRE_ErgNutzen = Erg_Ges_AOI    'Ergebnis Nutzen, wenn VorPr. Nutzen war
                                        Else
                                            If ISNR_einzel = True Then
                                                PRE_ErgEinzelprint = Mid(rptext_array(14), IDNutzen, 1) 'Ergebnis Einzelprint, wenn VorPr. Nutzen war
                                            End If
                                            PRE_ErgNutzen = rptext_array(14)    'Ergebnis Nutzen, wenn VorPr. Nutzen war
                                        End If
                                    End If

                                    'Prüfung Wartezeit
                                    zeit_jetzt = (DateTime.Now - New DateTime(DateTime.Now.Year - 1, 1, 1, 0, 0, 0)).TotalMinutes
                                    If (zeit_jetzt - Pretimestamp) < Zeit_Verriegelung_Vorprozess Then
                                        LblErrorText.Text = "Fehler Aushärtezeit" & vbCrLf & "SOLL: " & Zeit_Verriegelung_Vorprozess.ToString & " min    IST: " & (zeit_jetzt - Pretimestamp).ToString & " min"
                                        LblErrorText.ForeColor = Color.Red
                                        ColorChange(Color.Red)
                                        FormError.ISNR = ISNR_Abfrage
                                        FormError.Fehler = 5
                                        FormError.ShowDialog()
                                        GoTo PrüfungEnde
                                    End If
                                End If
                            End If

                            If erco <> "" Then  'Keine Daten gefunden
                                LblErrorText.Text = "Keine Daten vom" & vbCrLf & " Vorprozess " & SART_Vorprozess & " vorhanden"
                                LblErrorText.ForeColor = Color.Red
                                ColorChange(Color.Red)
                                FormError.ISNR = ISNR_Abfrage
                                FormError.SART_Pre = SART_Vorprozess
                                FormError.Fehler = 1
                                FormError.ShowDialog()
                            Else
                                TR3_Ergebnis()

                                If PRE_ErgEinzelprint = "0" Or PRE_ErgEinzelprint = "2" Or PRE_ErgEinzelprint = "3" Or state_einzel = "0" Or state_nutzen.Contains("3") = True Then    'Vorprozess NOK?    Or rptext_array(11) <> FKTGruppe_Vorprozess
                                    LblErrorText.Text = "Vorprozess " & SART_Vorprozess & " Fehlerhaft"
                                    LblErrorText.ForeColor = Color.Red
                                    ColorChange(Color.Red)
                                    FormError.ISNR = ISNR_Abfrage
                                    FormError.Fehler = 2
                                    FormError.ShowDialog()
                                Else
                                    ListBox1.Items.Add(ISNR_Abfrage)
                                    LblErrorText.Text = "Vorprozess " & SART_Vorprozess & " OK"
                                    LblErrorText.ForeColor = Color.Green
                                    ColorChange(Color.Green)
                                End If
                            End If

PrüfungEnde:
                            TextBoxISNR.Clear()

                        End If
                    Else
                        LblErrorText.Text = "Seriennummerreferenz" & vbCrLf & "ist fehlerhaft"
                        LblErrorText.ForeColor = Color.Red
                        ColorChange(Color.Red)
                        FormError.ISNR = ISNR_Abfrage
                        FormError.Fehler = 4
                        FormError.ShowDialog()
                        TextBoxISNR.Clear()
                    End If
                Else
                    'MsgBox("Seriennummer ist ungültig oder hat einen falschen Zustand (geliefert, Slave, ...)")
                    LblErrorText.Text = "Seriennummer ist ungültig" & vbCrLf & "oder hat einen falschen Zustand" & vbCrLf & " (geliefert, Slave, ...)"
                    LblErrorText.ForeColor = Color.Red
                    ColorChange(Color.Red)
                    FormError.ISNR = ISNR_Abfrage
                    FormError.Fehler = 3
                    FormError.ShowDialog()
                    TextBoxISNR.Clear()
                End If
                lblAnzahlISNR.Text = ListBox1.Items.Count
                ListBox1.SelectedIndex = ListBox1.Items.Count - 1
            End If
            lblAnzahlISNR.Text = ListBox1.Items.Count
            ListBox1.SelectedIndex = ListBox1.Items.Count - 1
        End If

        If TextBoxISNR.Text = ("Auftragsdaten einlesen") Then
            TextBoxISNR.Clear()
        End If

    End Sub
    Public Sub TR3_Ergebnis()
        'wenn die eingegebene ISNR und Vorprozess eine Einzelschaltung ist
        If ISNR_einzel = True And PRE_ErgEinzelprint = "1" Then
            state_einzel = "1"
        ElseIf ISNR_einzel = True And (PRE_ErgEinzelprint = "0" Or PRE_ErgEinzelprint = "2" Or PRE_ErgEinzelprint = "3") Then
            state_einzel = "2"
        End If
        'wenn die eingegebene ISNR und Vorprozess eine Nutzen ist
        If ISNR_Nutzen = True Then
            For i = 0 To lzisnr.Length - 1
                If PRE_ErgNutzen(i) = "1" Then
                    state_nutzen = String.Concat(state_nutzen, "1")
                ElseIf PRE_ErgNutzen(i) = "0" Or PRE_ErgNutzen(i) = "2" Then
                    state_nutzen = String.Concat(state_nutzen, "2")
                ElseIf PRE_ErgNutzen(i) = "3" Then
                    state_nutzen = String.Concat(state_nutzen, "3")
                End If
            Next
        End If
        'wenn die eingegebene ISNR eine Einzelschaltung und Vorprozess eine Nutzen ist
        If ISNR_einzel = True And PRE_Nutzen_Einzel = "N" Then
            state_einzel = PRE_ErgEinzelprint
        End If

        'ISNR mit Ergebnis in Tabelle einfügen
        Tabelle.Rows.Add(ISNR_Abfrage, state_einzel, state_nutzen)

    End Sub
    Public Sub AOI_Ergebnis_verknüpfen()
        'wenn der Vorprozess AOI ist, müssen beide Seiten miteinander verknüpft werden, da AOI sich selber nicht verriegelt
        Dim ISNR_Anfrage As String
        Dim AOIErg_TOP, AOIErg_BOT As String

        If lzrei1 <> 0 And lzrei2 = 0 Then 'nur TOP vorhanden
            ISNR_Anfrage = lzrei1
            webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage)
            If erco = "88020" Then 'Fehler Webservice
                GoTo Subaufruf
            End If
            AOIErg_TOP = rptext_array(14)
            AOIErg_BOT = AOIErg_TOP     'gleiches Ergebnis auf andere Seite übertragen (für Auswertung)
        ElseIf lzrei1 = 0 And lzrei2 <> 0 Then ' nur BOTTOM vorhanden
            ISNR_Anfrage = lzrei2
            webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage)
            If erco = "88020" Then 'Fehler Webservice
                GoTo Subaufruf
            End If
            AOIErg_BOT = rptext_array(14)
            AOIErg_TOP = AOIErg_BOT     'gleiches Ergebnis auf andere Seite übertragen (für Auswertung)
        ElseIf lzrei1 <> 0 And lzrei2 <> 0 Then ' TOP und BOTTOM vorhanden
            'Anfrage TOP
            ISNR_Anfrage = lzrei1
            webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage)
            If erco = "88020" Then 'Fehler Webservice
                GoTo Subaufruf
            End If
            AOIErg_TOP = rptext_array(14)
            'Anfrage BOTTOM
            ISNR_Anfrage = lzrei2
            webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage)
            If erco = "88020" Then 'Fehler Webservice
                GoTo Subaufruf
            End If
            AOIErg_BOT = rptext_array(14)
        End If

        'Gesamtergebnis zusammensetzen
        Erg_Ges_AOI = ""
        If rptima <> "" Then        'TR3
            For i = 0 To AOIErg_TOP.Length - 1
                If AOIErg_TOP(i) = "1" And AOIErg_BOT(i) = "1" Then         'beide Seiten OK
                    Erg_Ges_AOI = String.Concat(Erg_Ges_AOI, "1")
                Else
                    If AOIErg_TOP(i) = "3" Or AOIErg_BOT(i) = "3" Then      'zur Verifikation
                        Erg_Ges_AOI = String.Concat(Erg_Ges_AOI, "3")
                    ElseIf AOIErg_TOP(i) = "2" Or AOIErg_BOT(i) = "2" Then  'BBS
                        Erg_Ges_AOI = String.Concat(Erg_Ges_AOI, "2")
                    ElseIf AOIErg_TOP(i) = "0" Or AOIErg_BOT(i) = "0" Then  'NOK
                        Erg_Ges_AOI = String.Concat(Erg_Ges_AOI, "0")
                    End If
                End If
            Next
        End If

Subaufruf:  'wenn Fehler aus Abfrage dann wird hierher gesprugen

    End Sub
    Public Sub init_Var()
        ISNR_Abfrage = ""
        ISNR_lzstat = ""
        ISNR_status = ""
        Erase lzisnr
        lzrei1 = ""
        lzrei2 = ""
        erco = ""
        ISNR_einzel = False
        ISNR_Nutzen = False
        state_einzel = ""
        state_nutzen = ""
        PRE_ErgEinzelprint = ""
        PRE_ErgNutzen = ""
    End Sub
    Private Sub BTR3schreiben_Click() Handles BTR3schreiben.Click
        Dim id As String
        Dim strCSV As String = ""
        Dim csvWriter As StreamWriter
        Dim enc As System.Text.Encoding
        Dim blnAppend As Boolean = False
        Dim TIMESTAMP_Start As DateTime = DateTime.Now
        Dim strTimeStart As String

        'state_einzel = "1"

        For i = 0 To ListBox1.Items.Count - 1

            id = Guid.NewGuid().ToString()
            ISNR = ListBox1.Items.Item(i)   'Seriennummern aus Liste

            'Daten aus gesammelter Tabelle auslesen
            Dim foundrow() As DataRow
            foundrow = Tabelle.Select("ISNR='" & ISNR & "'")


            strTimeStart = TIMESTAMP_Start.ToString("yyyy-MM-dd-HH.mm.ss.ffffffzzz")
            tracePath = ""
            enc = System.Text.Encoding.Default      'CP1252 oder ANSI

            If IO.Directory.Exists(csvPath) Then
                tracePath = csvPath & "TR3_" & SART & "_" & ISNR & "_" & id & ".tmp"
            Else
                If IO.Directory.Exists(csvLokal) Then
                    tracePath = csvLokal & "TR3_" & SART & "_" & ISNR & "_" & id & ".tmp"
                Else
                    Directory.CreateDirectory(csvLokal)
                    tracePath = csvLokal & "TR3_" & SART & "_" & ISNR & "_" & id & ".tmp"
                End If
            End If
            csvWriter = New StreamWriter(tracePath, blnAppend, enc)   'Datei erstellen
            strCSV = "T1;" & ISNR & ";;" & auftrag.Text & ";" & abrufnummer.Text & ";" & restauftragsnummer.Text & ";" & positionsnummer.Text & ";" & SART & ";" & TBPersNr.Text & ";" & Vers_Schnitt & ";" & Mandant & ";;" & strTimeStart & ";" & foundrow(0).Item("GesErg_Einzel").ToString & ";" & foundrow(0).Item("GesErg_Nutzen").ToString & ";;;;;" & Application.ProductName & ";" & ProgVersion.Text & ";;;;;;" & vbCrLf &
                     "T2;" & ISNR & ";0;;" & artikel.Text & ";"
            csvWriter.Write(strCSV)     'Datei befüllen
            csvWriter.Close()
            File.Move(tracePath, Path.ChangeExtension(tracePath, "csv"))    'Dateiendung in csv ändern

        Next

        TextBoxISNR.Clear()
        Tabelle.Clear()
        BListelöschen_Click()
        TextBoxISNR.Select()
    End Sub
    Private Sub INI_BGCongif_lesen()
        Dim InipfadConfig As String = PfadBGConfig
        Dim INI_Config As New INIDatei(InipfadConfig)
        SART_Vorprozess = INI_Config.WertLesen(artikel.Text & " " & FKTGruppe, "SART_PRE", "error")
        Zeit_Verriegelung_Vorprozess = INI_Config.WertLesen(artikel.Text & " " & FKTGruppe, "Zeit_Verriegelung_Vorprozess", "error")
        PRE_Nutzen_Einzel = INI_Config.WertLesen(artikel.Text & " " & FKTGruppe, "PRE_Nutzen_Einzel", "N")

        'wenn Vorprozessabfrage deaktiviert ist, dann Text einblenden
        If SART_Vorprozess = "" And FKTGruppe_Vorprozess = "" Then
            lblPreprocess.Visible = True
            LblSART.Text = "deaktiviert"
        Else
            lblPreprocess.Visible = False
            lblPreZeit.Text = Zeit_Verriegelung_Vorprozess & " min"
            LblSART.Text = SART_Vorprozess
        End If

        'wenn in Config nichts definiert ist
        If SART_Vorprozess = "error" Then   'And FKTGruppe_Vorprozess = "error"
            cbProzess.SelectedIndex = 0
            MsgBox("Auswahl ""Sachnummer - Prozess"" in Config-File nicht enthalten")
        End If

    End Sub
    Private Sub InformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub
    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Einstellungen.ShowDialog()
        Me.Refresh()
    End Sub
    Private Sub webservice_getauftrag()
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:prof=""http://whedi1/ProfidDataExchange"">
               <soapenv:Header/>
               <soapenv:Body>
                  <prof:getAuftrag>
                     <aun7>" + auftrag.Text + "</aun7>
                     <aura>" + abrufnummer.Text + "</aura>
                     <aure>" + restauftragsnummer.Text + "</aure>
                     <ponr>" + positionsnummer.Text + "</ponr>
                     <btrm>" + Mandant + "</btrm>
                  </prof:getAuftrag>
               </soapenv:Body>
            </soapenv:Envelope>"

        Dim url As String = URLProfidDataExchange
        Dim responsestring As String = ""
        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))

        With XMLReader
            Do While .Read
                If XMLReader.Name = "artn" Then
                    artikel.Text = XMLReader.ReadElementContentAsString
                    'Exit Do
                ElseIf XMLReader.Name = "stat" Then
                    Auftrag_status = XMLReader.ReadElementContentAsString
                    Exit Do
                ElseIf XMLReader.Name = "erco" Then         'Keine Daten gefunden! // No data found! // Nincsenek adatok!
                    erco = XMLReader.ReadElementContentAsString
                    Exit Do
                End If
            Loop
            .Close()
        End With
        artikel.Text = Microsoft.VisualBasic.Left(artikel.Text, 10)
    End Sub
    Private Sub webservice_checkPersonal(PersNr As String, Mandant As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:prof=""http://whedi1/ProfidDataExchange"">
                <soapenv:Header/>
                    <soapenv:Body>
                        <prof:checkPersonal>
                            <pern>" & PersNr & "</pern>
                            <btrm>" & Mandant & "</btrm>
                        </prof:checkPersonal>
                    </soapenv:Body>
                </soapenv:Envelope>"

        Dim url As String = URLProfidDataExchange
        Dim responsestring As String = ""
        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))

        With XMLReader
            Do While .Read
                If XMLReader.Name = "status" Then
                    Pers_status = XMLReader.ReadElementContentAsString
                    Exit Do
                End If
            Loop
            .Close()
        End With

    End Sub
    Private Sub webservice_checkISNR(ISNR As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:prof=""http://whedi1/ProfidDataExchange"">
                <soapenv:Header/>
                    <soapenv:Body>
                        <prof:checkIsnr>
                            <isnr>" & ISNR & "</isnr>
                        </prof:checkIsnr>
                    </soapenv:Body>
                </soapenv:Envelope>"

        Dim url As String = URLProfidDataExchange
        Dim responsestring As String = ""
        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))

        With XMLReader
            Do While .Read
                If XMLReader.Name = "lzstat" Then
                    ISNR_lzstat = XMLReader.ReadElementContentAsString
                    ISNR_status = XMLReader.ReadElementContentAsString
                    Exit Do
                End If
            Loop
            .Close()
        End With
    End Sub
    Private Sub webservice_getTraceDataByIsnrAndSart2(ISNR_Anfrage As String)

        Dim xml As String

        Erase rptext_array
        rptext = ""
        erco = ""

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                               <trac:getTraceDataByIsnrAndSart2>
                                    <isnr>" & ISNR_Anfrage & "</isnr>
                                    <sart>" & SART_Vorprozess & "</sart>
                                    <getAll>false</getAll>
                               </trac:getTraceDataByIsnrAndSart2>
                       </soapenv:Body>
                   </soapenv:Envelope>"

        Dim url As String = URLTraceDataExchange
        Dim responsestring As String = ""

        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        Dim XMLReader As Xml.XmlReader = New Xml.XmlTextReader(New StringReader(response))

        '#######################
        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode
        Dim rptext_hilf As String = ""
        Dim rptima_hilf As Integer = 0
        erco = "4711" 'irgend ein Fehlercode. Wird überschrieben, wenn richtiger Datensatz gefunden wird

        xmldoc.LoadXml(response)

        xmlnodelist = xmldoc.SelectNodes("//rrpList")
        'verschiedene Datensätze auswerten
        For Each node In xmlnodelist
            rptext = node.SelectSingleNode("rptext").InnerText      'rptext auslesen
            rptima = node.SelectSingleNode("rptima").InnerText      'rptima auslesen
            rptext_array = Split(rptext, ";")

            'If rptext_array(11) = FKTGruppe_Vorprozess Then
            Dim time As DateTime = Convert.ToDateTime(Date.ParseExact(Microsoft.VisualBasic.Left(rptima, 19), "yyyy-MM-dd-HH.mm.ss", Nothing))
            Dim time_minutes As Integer = (time - New DateTime(DateTime.Now.Year - 1, 1, 1, 0, 0, 0)).TotalMinutes      'in Minuten umwandeln
            If rptima_hilf < time_minutes Then
                rptext_hilf = rptext
                rptima_hilf = time_minutes
                erco = ""
            End If
            'End If
        Next
        rptext = rptext_hilf
        Pretimestamp = rptima_hilf
        rptext_array = Split(rptext, ";")
    End Sub
    Public Sub webservice_getLzByRei(ISNR_Anfrage As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                          <trac:getLzByRei>
                             <isnr>" & ISNR_Anfrage & "</isnr>
                          </trac:getLzByRei>
                       </soapenv:Body>
                   </soapenv:Envelope>"

        Dim url As String = URLTraceDataExchange
        Dim responsestring As String = ""

        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd 'Ergebnis Webserviceanfrage

        erco = ""
        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode
        xmldoc.LoadXml(response)

        xmlnodelist = xmldoc.SelectNodes("//rlzList")

        Erase lzisnr  'Array löschen
        Dim i As Integer = 0

        For Each node In xmlnodelist
            ReDim Preserve lzisnr(i)    'Array neu definieren mit Anzahl der Einzelprints
            lzrei1 = node.SelectSingleNode("lzrei1").InnerText
            lzrei2 = node.SelectSingleNode("lzrei2").InnerText
            lzisnr(node.SelectSingleNode("lzfr01").InnerText - 1) = node.SelectSingleNode("lzisnr").InnerText
            i += 1
        Next

        xmlnodelist = xmldoc.SelectNodes("//getLzByRei/errorList/errors")
        For Each node In xmlnodelist
            erco = node.SelectSingleNode("erco").InnerText
        Next

    End Sub
    Private Sub webservice_getLzByIsnr(ISNR_Anfrage As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                               <trac:getLzByIsnr>
                                   <isnr>" & ISNR_Anfrage & "</isnr>
                               </trac:getLzByIsnr>
                       </soapenv:Body>
                   </soapenv:Envelope>"

        Dim url As String = URLTraceDataExchange
        Dim responsestring As String = ""

        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        'Abfrage der Referenztabelle
        erco = ""
        'lzisnr = ""
        lzrei1 = ""
        lzrei2 = ""
        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode
        xmldoc.LoadXml(response)


        xmlnodelist = xmldoc.SelectNodes("//getLzByIsnr/errorList/errors")
        For Each node In xmlnodelist
            erco = node.SelectSingleNode("erco").InnerText
        Next

        xmlnodelist = xmldoc.SelectNodes("//getLzByIsnr")
        For Each node In xmlnodelist
            If erco = "" Then
                IDNutzen = LTrim(RTrim(node.SelectSingleNode("lzfr01").InnerText))
                lzrei1 = LTrim(RTrim(node.SelectSingleNode("lzrei1").InnerText))
                lzrei2 = LTrim(RTrim(node.SelectSingleNode("lzrei2").InnerText))
            End If
        Next

    End Sub
    Private Sub webservice_getMaisBySlis(ISNR_Anfrage As String)
        Dim xml As String

        xml = "<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:trac=""http://whedi1/traceDataExchange"">
                   <soapenv:Header/>
                       <soapenv:Body>
                               <trac:getMaisBySlis>
                                   <slis>" & ISNR_Anfrage & "</slis>
                               </trac:getMaisBySlis>
                       </soapenv:Body>
                   </soapenv:Envelope>"
        Dim url As String = URLTraceDataExchange
        Dim responsestring As String = ""

        Dim myReq As HttpWebRequest = WebRequest.Create(url)
        Dim encoding As New ASCIIEncoding
        Dim buffer() As Byte = encoding.GetBytes(xml)
        Dim response As String

        myReq.AllowWriteStreamBuffering = False
        myReq.Method = "POST"
        myReq.ContentType = "text/xml; charset=UTF-8"
        myReq.ContentLength = buffer.Length
        myReq.Proxy = Nothing
        Dim post As Stream = myReq.GetRequestStream

        post.Write(buffer, 0, buffer.Length)
        post.Close()

        Dim myResponse As HttpWebResponse = myReq.GetResponse
        Dim responsedata As Stream = myResponse.GetResponseStream
        Dim responsereader As New StreamReader(responsedata)

        response = responsereader.ReadToEnd

        Dim xmldoc As New XmlDocument()
        Dim xmlnodelist As XmlNodeList
        Dim node As XmlNode
        erco = ""
        xmldoc.LoadXml(response)
        xmlnodelist = xmldoc.SelectNodes("//rsrList")
        If xmlnodelist.Count = 0 Then
            erco = "88023"
        Else
            For Each node In xmlnodelist
                ISNRmaster = node.SelectSingleNode("srmais").InnerText             'Master
            Next
        End If
    End Sub
End Class
