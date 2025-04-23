<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Einstellungen
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TBDBPathLokal = New System.Windows.Forms.TextBox()
        Me.TBMandant = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Bspeichern = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBDBPath = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBSART = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBVersTrace = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BBeenden = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TBBGConfig = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'TBDBPathLokal
        '
        Me.TBDBPathLokal.Location = New System.Drawing.Point(95, 98)
        Me.TBDBPathLokal.Name = "TBDBPathLokal"
        Me.TBDBPathLokal.Size = New System.Drawing.Size(602, 20)
        Me.TBDBPathLokal.TabIndex = 0
        '
        'TBMandant
        '
        Me.TBMandant.Location = New System.Drawing.Point(95, 180)
        Me.TBMandant.Name = "TBMandant"
        Me.TBMandant.Size = New System.Drawing.Size(61, 20)
        Me.TBMandant.TabIndex = 1
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Bspeichern
        '
        Me.Bspeichern.Location = New System.Drawing.Point(175, 208)
        Me.Bspeichern.Name = "Bspeichern"
        Me.Bspeichern.Size = New System.Drawing.Size(75, 23)
        Me.Bspeichern.TabIndex = 2
        Me.Bspeichern.Text = "speichern"
        Me.Bspeichern.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DB-Pfad lokal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mandant"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 31)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Einstellungen"
        '
        'TBDBPath
        '
        Me.TBDBPath.Location = New System.Drawing.Point(95, 72)
        Me.TBDBPath.Name = "TBDBPath"
        Me.TBDBPath.Size = New System.Drawing.Size(602, 20)
        Me.TBDBPath.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "DB-Pfad"
        '
        'TBSART
        '
        Me.TBSART.Location = New System.Drawing.Point(95, 154)
        Me.TBSART.Name = "TBSART"
        Me.TBSART.Size = New System.Drawing.Size(60, 20)
        Me.TBSART.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Anlagennummer"
        '
        'TBVersTrace
        '
        Me.TBVersTrace.Location = New System.Drawing.Point(322, 158)
        Me.TBVersTrace.Name = "TBVersTrace"
        Me.TBVersTrace.ReadOnly = True
        Me.TBVersTrace.Size = New System.Drawing.Size(60, 20)
        Me.TBVersTrace.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(186, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Version Traceschnittstelle"
        '
        'BBeenden
        '
        Me.BBeenden.Location = New System.Drawing.Point(256, 208)
        Me.BBeenden.Name = "BBeenden"
        Me.BBeenden.Size = New System.Drawing.Size(75, 23)
        Me.BBeenden.TabIndex = 2
        Me.BBeenden.Text = "beenden"
        Me.BBeenden.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Pfad Config"
        '
        'TBBGConfig
        '
        Me.TBBGConfig.Location = New System.Drawing.Point(95, 124)
        Me.TBBGConfig.Multiline = True
        Me.TBBGConfig.Name = "TBBGConfig"
        Me.TBBGConfig.Size = New System.Drawing.Size(602, 20)
        Me.TBBGConfig.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Einstellungen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 239)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TBBGConfig)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BBeenden)
        Me.Controls.Add(Me.Bspeichern)
        Me.Controls.Add(Me.TBMandant)
        Me.Controls.Add(Me.TBDBPath)
        Me.Controls.Add(Me.TBVersTrace)
        Me.Controls.Add(Me.TBSART)
        Me.Controls.Add(Me.TBDBPathLokal)
        Me.Name = "Einstellungen"
        Me.Text = "Einstellungen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBDBPathLokal As TextBox
    Friend WithEvents TBMandant As TextBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Bspeichern As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBDBPath As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TBSART As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBVersTrace As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BBeenden As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents TBBGConfig As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
