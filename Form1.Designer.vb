<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.auftrag = New System.Windows.Forms.TextBox()
        Me.positionsnummer = New System.Windows.Forms.TextBox()
        Me.restauftragsnummer = New System.Windows.Forms.TextBox()
        Me.abrufnummer = New System.Windows.Forms.TextBox()
        Me.begleitzettel_DMC = New System.Windows.Forms.TextBox()
        Me.auftragdaten = New System.Windows.Forms.Button()
        Me.Button_Beenden = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.artikel = New System.Windows.Forms.Label()
        Me.ProgVersion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblSART = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LokalTrace = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblDBPfad = New System.Windows.Forms.Label()
        Me.TextBoxISNR = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAnzahlISNR = New System.Windows.Forms.Label()
        Me.LblErrorText = New System.Windows.Forms.Label()
        Me.BListelöschen = New System.Windows.Forms.Button()
        Me.BTR3schreiben = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBPersNr = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.EinstellungenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblVerbindung = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbProzess = New System.Windows.Forms.ComboBox()
        Me.lblFKTGruppe = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblPreprocess = New System.Windows.Forms.Label()
        Me.bReset = New System.Windows.Forms.Button()
        Me.lblPreZeit = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'auftrag
        '
        Me.auftrag.Location = New System.Drawing.Point(10, 109)
        Me.auftrag.Name = "auftrag"
        Me.auftrag.ReadOnly = True
        Me.auftrag.Size = New System.Drawing.Size(57, 20)
        Me.auftrag.TabIndex = 27
        Me.auftrag.TabStop = False
        Me.auftrag.Visible = False
        '
        'positionsnummer
        '
        Me.positionsnummer.Location = New System.Drawing.Point(129, 109)
        Me.positionsnummer.Name = "positionsnummer"
        Me.positionsnummer.ReadOnly = True
        Me.positionsnummer.Size = New System.Drawing.Size(24, 20)
        Me.positionsnummer.TabIndex = 26
        Me.positionsnummer.TabStop = False
        Me.positionsnummer.Visible = False
        '
        'restauftragsnummer
        '
        Me.restauftragsnummer.Location = New System.Drawing.Point(72, 109)
        Me.restauftragsnummer.Name = "restauftragsnummer"
        Me.restauftragsnummer.ReadOnly = True
        Me.restauftragsnummer.Size = New System.Drawing.Size(24, 20)
        Me.restauftragsnummer.TabIndex = 25
        Me.restauftragsnummer.TabStop = False
        Me.restauftragsnummer.Visible = False
        '
        'abrufnummer
        '
        Me.abrufnummer.Location = New System.Drawing.Point(100, 109)
        Me.abrufnummer.Name = "abrufnummer"
        Me.abrufnummer.ReadOnly = True
        Me.abrufnummer.Size = New System.Drawing.Size(24, 20)
        Me.abrufnummer.TabIndex = 24
        Me.abrufnummer.TabStop = False
        Me.abrufnummer.Visible = False
        '
        'begleitzettel_DMC
        '
        Me.begleitzettel_DMC.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.begleitzettel_DMC.Location = New System.Drawing.Point(10, 78)
        Me.begleitzettel_DMC.Name = "begleitzettel_DMC"
        Me.begleitzettel_DMC.Size = New System.Drawing.Size(143, 26)
        Me.begleitzettel_DMC.TabIndex = 23
        Me.begleitzettel_DMC.Visible = False
        '
        'auftragdaten
        '
        Me.auftragdaten.Enabled = False
        Me.auftragdaten.Location = New System.Drawing.Point(172, 69)
        Me.auftragdaten.Name = "auftragdaten"
        Me.auftragdaten.Size = New System.Drawing.Size(83, 58)
        Me.auftragdaten.TabIndex = 28
        Me.auftragdaten.Text = "Auftragdaten einlesen"
        Me.auftragdaten.UseVisualStyleBackColor = True
        Me.auftragdaten.Visible = False
        '
        'Button_Beenden
        '
        Me.Button_Beenden.Location = New System.Drawing.Point(357, 495)
        Me.Button_Beenden.Margin = New System.Windows.Forms.Padding(2)
        Me.Button_Beenden.Name = "Button_Beenden"
        Me.Button_Beenden.Size = New System.Drawing.Size(124, 30)
        Me.Button_Beenden.TabIndex = 29
        Me.Button_Beenden.Text = "Beenden"
        Me.Button_Beenden.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 295)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Artikel:"
        '
        'artikel
        '
        Me.artikel.AutoSize = True
        Me.artikel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artikel.Location = New System.Drawing.Point(314, 295)
        Me.artikel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.artikel.Name = "artikel"
        Me.artikel.Size = New System.Drawing.Size(39, 20)
        Me.artikel.TabIndex = 31
        Me.artikel.Text = "???"
        '
        'ProgVersion
        '
        Me.ProgVersion.AutoSize = True
        Me.ProgVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgVersion.Location = New System.Drawing.Point(438, 470)
        Me.ProgVersion.Name = "ProgVersion"
        Me.ProgVersion.Size = New System.Drawing.Size(17, 16)
        Me.ProgVersion.TabIndex = 32
        Me.ProgVersion.Text = "V"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Vorprozess:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(322, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 48)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'LblSART
        '
        Me.LblSART.AutoSize = True
        Me.LblSART.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSART.Location = New System.Drawing.Point(353, 221)
        Me.LblSART.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblSART.Name = "LblSART"
        Me.LblSART.Size = New System.Drawing.Size(39, 20)
        Me.LblSART.TabIndex = 35
        Me.LblSART.Text = "???"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'LokalTrace
        '
        Me.LokalTrace.AutoSize = True
        Me.LokalTrace.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LokalTrace.Location = New System.Drawing.Point(7, 189)
        Me.LokalTrace.Name = "LokalTrace"
        Me.LokalTrace.Size = New System.Drawing.Size(283, 24)
        Me.LokalTrace.TabIndex = 36
        Me.LokalTrace.Text = "lokale Tracedaten vorhanden"
        Me.LokalTrace.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "DB-Pfad:"
        Me.Label6.Visible = False
        '
        'LblDBPfad
        '
        Me.LblDBPfad.AutoSize = True
        Me.LblDBPfad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDBPfad.Location = New System.Drawing.Point(69, 221)
        Me.LblDBPfad.Name = "LblDBPfad"
        Me.LblDBPfad.Size = New System.Drawing.Size(45, 13)
        Me.LblDBPfad.TabIndex = 38
        Me.LblDBPfad.Text = "Label7"
        Me.LblDBPfad.Visible = False
        '
        'TextBoxISNR
        '
        Me.TextBoxISNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.TextBoxISNR.Location = New System.Drawing.Point(11, 245)
        Me.TextBoxISNR.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBoxISNR.Name = "TextBoxISNR"
        Me.TextBoxISNR.Size = New System.Drawing.Size(144, 29)
        Me.TextBoxISNR.TabIndex = 39
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(11, 277)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(143, 208)
        Me.ListBox1.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 495)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Anzahl Seriennummern:"
        '
        'lblAnzahlISNR
        '
        Me.lblAnzahlISNR.AutoSize = True
        Me.lblAnzahlISNR.BackColor = System.Drawing.Color.Transparent
        Me.lblAnzahlISNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnzahlISNR.Location = New System.Drawing.Point(151, 493)
        Me.lblAnzahlISNR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAnzahlISNR.Name = "lblAnzahlISNR"
        Me.lblAnzahlISNR.Size = New System.Drawing.Size(17, 18)
        Me.lblAnzahlISNR.TabIndex = 43
        Me.lblAnzahlISNR.Text = "0"
        '
        'LblErrorText
        '
        Me.LblErrorText.AutoSize = True
        Me.LblErrorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblErrorText.Location = New System.Drawing.Point(170, 385)
        Me.LblErrorText.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblErrorText.Name = "LblErrorText"
        Me.LblErrorText.Size = New System.Drawing.Size(79, 18)
        Me.LblErrorText.TabIndex = 45
        Me.LblErrorText.Text = "ErrorText"
        '
        'BListelöschen
        '
        Me.BListelöschen.Location = New System.Drawing.Point(38, 516)
        Me.BListelöschen.Name = "BListelöschen"
        Me.BListelöschen.Size = New System.Drawing.Size(86, 23)
        Me.BListelöschen.TabIndex = 46
        Me.BListelöschen.Text = "Liste löschen"
        Me.BListelöschen.UseVisualStyleBackColor = True
        '
        'BTR3schreiben
        '
        Me.BTR3schreiben.Location = New System.Drawing.Point(160, 241)
        Me.BTR3schreiben.Name = "BTR3schreiben"
        Me.BTR3schreiben.Size = New System.Drawing.Size(75, 38)
        Me.BTR3schreiben.TabIndex = 47
        Me.BTR3schreiben.Text = "Tracedaten schreiben"
        Me.BTR3schreiben.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(360, 526)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "© Mario Rehberger"
        '
        'TBPersNr
        '
        Me.TBPersNr.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPersNr.Location = New System.Drawing.Point(82, 30)
        Me.TBPersNr.Name = "TBPersNr"
        Me.TBPersNr.Size = New System.Drawing.Size(71, 26)
        Me.TBPersNr.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 37)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "Personal Nr.:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(260, 83)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 55)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(166, 284)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(62, 55)
        Me.PictureBox3.TabIndex = 52
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinstellungenToolStripMenuItem, Me.ConfigToolStripMenuItem, Me.InformationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(493, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'EinstellungenToolStripMenuItem
        '
        Me.EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        Me.EinstellungenToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.EinstellungenToolStripMenuItem.Text = "Einstellungen"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Auftragszettel einscannen"
        '
        'LblVerbindung
        '
        Me.LblVerbindung.AutoSize = True
        Me.LblVerbindung.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVerbindung.ForeColor = System.Drawing.Color.Red
        Me.LblVerbindung.Location = New System.Drawing.Point(170, 424)
        Me.LblVerbindung.Name = "LblVerbindung"
        Me.LblVerbindung.Size = New System.Drawing.Size(63, 20)
        Me.LblVerbindung.TabIndex = 55
        Me.LblVerbindung.Text = "Label8"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Prozess:"
        '
        'cbProzess
        '
        Me.cbProzess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProzess.FormattingEnabled = True
        Me.cbProzess.Items.AddRange(New Object() {"", "Damm auftragen / DAMM / DAMM", "Bauteil unterfüllen / UNDERFILL / UFIL", "Bauteil sichern / SICHERN / SICH", "Baugruppe lackieren / LACKIEREN / LACK", "Körapur auftragen / KOERAPUR / KOER", "Baugruppe vergießen / VERGUSS / VERG", "Certonal beschichten / CERTONAL / CERT"})
        Me.cbProzess.Location = New System.Drawing.Point(60, 146)
        Me.cbProzess.Name = "cbProzess"
        Me.cbProzess.Size = New System.Drawing.Size(421, 28)
        Me.cbProzess.TabIndex = 57
        '
        'lblFKTGruppe
        '
        Me.lblFKTGruppe.AutoSize = True
        Me.lblFKTGruppe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFKTGruppe.Location = New System.Drawing.Point(361, 270)
        Me.lblFKTGruppe.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFKTGruppe.Name = "lblFKTGruppe"
        Me.lblFKTGruppe.Size = New System.Drawing.Size(39, 20)
        Me.lblFKTGruppe.TabIndex = 59
        Me.lblFKTGruppe.Text = "???"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(245, 270)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(112, 20)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "FKT-Gruppe:"
        '
        'lblPreprocess
        '
        Me.lblPreprocess.AutoSize = True
        Me.lblPreprocess.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreprocess.ForeColor = System.Drawing.Color.Red
        Me.lblPreprocess.Location = New System.Drawing.Point(247, 324)
        Me.lblPreprocess.Name = "lblPreprocess"
        Me.lblPreprocess.Size = New System.Drawing.Size(162, 40)
        Me.lblPreprocess.TabIndex = 60
        Me.lblPreprocess.Text = "Vorprozessabfrage" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "deaktiviert"
        Me.lblPreprocess.Visible = False
        '
        'bReset
        '
        Me.bReset.Location = New System.Drawing.Point(172, 33)
        Me.bReset.Name = "bReset"
        Me.bReset.Size = New System.Drawing.Size(75, 23)
        Me.bReset.TabIndex = 61
        Me.bReset.Text = "reset Auftrag"
        Me.bReset.UseVisualStyleBackColor = True
        '
        'lblPreZeit
        '
        Me.lblPreZeit.AutoSize = True
        Me.lblPreZeit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreZeit.Location = New System.Drawing.Point(403, 246)
        Me.lblPreZeit.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPreZeit.Name = "lblPreZeit"
        Me.lblPreZeit.Size = New System.Drawing.Size(39, 20)
        Me.lblPreZeit.TabIndex = 63
        Me.lblPreZeit.Text = "???"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(245, 246)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(154, 20)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "Verriegelungszeit:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 548)
        Me.Controls.Add(Me.lblPreZeit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.bReset)
        Me.Controls.Add(Me.lblPreprocess)
        Me.Controls.Add(Me.lblFKTGruppe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbProzess)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LblVerbindung)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TBPersNr)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTR3schreiben)
        Me.Controls.Add(Me.BListelöschen)
        Me.Controls.Add(Me.LblErrorText)
        Me.Controls.Add(Me.lblAnzahlISNR)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.TextBoxISNR)
        Me.Controls.Add(Me.LblDBPfad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LokalTrace)
        Me.Controls.Add(Me.LblSART)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ProgVersion)
        Me.Controls.Add(Me.artikel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Beenden)
        Me.Controls.Add(Me.auftragdaten)
        Me.Controls.Add(Me.auftrag)
        Me.Controls.Add(Me.positionsnummer)
        Me.Controls.Add(Me.restauftragsnummer)
        Me.Controls.Add(Me.abrufnummer)
        Me.Controls.Add(Me.begleitzettel_DMC)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Verguss Lackieren Traceability"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents auftrag As TextBox
    Friend WithEvents positionsnummer As TextBox
    Friend WithEvents restauftragsnummer As TextBox
    Friend WithEvents abrufnummer As TextBox
    Friend WithEvents begleitzettel_DMC As TextBox
    Friend WithEvents auftragdaten As Button
    Friend WithEvents Button_Beenden As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents artikel As Label
    Friend WithEvents ProgVersion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblSART As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LokalTrace As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblDBPfad As Label
    Friend WithEvents TextBoxISNR As TextBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAnzahlISNR As Label
    Friend WithEvents LblErrorText As Label
    Friend WithEvents BListelöschen As Button
    Friend WithEvents BTR3schreiben As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TBPersNr As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InformationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label7 As Label
    Friend WithEvents LblVerbindung As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbProzess As ComboBox
    Friend WithEvents lblFKTGruppe As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblPreprocess As Label
    Friend WithEvents bReset As Button
    Friend WithEvents lblPreZeit As Label
    Friend WithEvents Label11 As Label
End Class
