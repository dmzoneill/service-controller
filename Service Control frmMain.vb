

Public Class frmMain 'Were things really better back in the day?  I seem to
    Inherits System.Windows.Forms.Form 'not be able to let go of the past, tend

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub
    Friend WithEvents tabMain As System.Windows.Forms.TabControl
    Friend WithEvents tbpServices As System.Windows.Forms.TabPage
    Friend WithEvents lvwServices As System.Windows.Forms.ListView
    Friend WithEvents lchCaptions As System.Windows.Forms.ColumnHeader
    Friend WithEvents lchNames As System.Windows.Forms.ColumnHeader
    Friend WithEvents lchState As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents lnk As System.Windows.Forms.LinkLabel
    Private components As System.ComponentModel.IContainer

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.lchState = New System.Windows.Forms.ColumnHeader()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.tbpServices = New System.Windows.Forms.TabPage()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.lvwServices = New System.Windows.Forms.ListView()
        Me.lchCaptions = New System.Windows.Forms.ColumnHeader()
        Me.lchNames = New System.Windows.Forms.ColumnHeader()
        Me.tabMain = New System.Windows.Forms.TabControl()
        Me.lnk = New System.Windows.Forms.LinkLabel()
        Me.tbpServices.SuspendLayout()
        Me.tabMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(376, 296)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(76, 24)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Exit"
        '
        'cmdStop
        '
        Me.cmdStop.Enabled = False
        Me.cmdStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStop.Location = New System.Drawing.Point(260, 232)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(84, 24)
        Me.cmdStop.TabIndex = 1
        Me.cmdStop.Text = "Stop Service"
        '
        'lchState
        '
        Me.lchState.Text = "State"
        Me.lchState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lchState.Width = 100
        '
        'cmdStart
        '
        Me.cmdStart.Enabled = False
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStart.Location = New System.Drawing.Point(348, 232)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(84, 24)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start Service"
        '
        'tbpServices
        '
        Me.tbpServices.Controls.AddRange(New System.Windows.Forms.Control() {Me.lnk, Me.cmdRefresh, Me.cmdStart, Me.cmdStop, Me.lvwServices})
        Me.tbpServices.Location = New System.Drawing.Point(4, 22)
        Me.tbpServices.Name = "tbpServices"
        Me.tbpServices.Size = New System.Drawing.Size(440, 262)
        Me.tbpServices.TabIndex = 0
        Me.tbpServices.Text = "Windows Services"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdRefresh.Location = New System.Drawing.Point(156, 232)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(84, 24)
        Me.cmdRefresh.TabIndex = 1
        Me.cmdRefresh.Text = "Refresh"
        '
        'lvwServices
        '
        Me.lvwServices.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lchCaptions, Me.lchNames, Me.lchState})
        Me.lvwServices.FullRowSelect = True
        Me.lvwServices.GridLines = True
        Me.lvwServices.Location = New System.Drawing.Point(8, 8)
        Me.lvwServices.Name = "lvwServices"
        Me.lvwServices.Size = New System.Drawing.Size(424, 220)
        Me.lvwServices.TabIndex = 0
        Me.lvwServices.View = System.Windows.Forms.View.Details
        '
        'lchCaptions
        '
        Me.lchCaptions.Text = "Service"
        Me.lchCaptions.Width = 200
        '
        'lchNames
        '
        Me.lchNames.Text = "Real Names"
        Me.lchNames.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.lchNames.Width = 100
        '
        'tabMain
        '
        Me.tabMain.Controls.AddRange(New System.Windows.Forms.Control() {Me.tbpServices})
        Me.tabMain.Location = New System.Drawing.Point(4, 4)
        Me.tabMain.Name = "tabMain"
        Me.tabMain.SelectedIndex = 0
        Me.tabMain.Size = New System.Drawing.Size(448, 288)
        Me.tabMain.TabIndex = 0
        '
        'lnk
        '
        Me.lnk.Location = New System.Drawing.Point(12, 236)
        Me.lnk.Name = "lnk"
        Me.lnk.Size = New System.Drawing.Size(144, 16)
        Me.lnk.TabIndex = 2
        Me.lnk.TabStop = True
        Me.lnk.Text = "jBistoGOOD@Hotmail.com"
        '
        'frmMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(456, 323)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmdExit, Me.tabMain})
        Me.Name = "frmMain"
        Me.Text = "Windows Services Control - tHe_cLeanER productions..."
        Me.tbpServices.ResumeLayout(False)
        Me.tabMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region 'to revel on previous experiences, just because it is ... comfortable.

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ReadSvcs() '... as pathetic as a middle-aged
    End Sub 'corporate drone watching tapes 

    Sub ReadSvcs() 'of his old football
        Dim ListSvcs() As ServiceProcess.ServiceController 'games from back in the day,
        Dim SingleSvc As ServiceProcess.ServiceController 'when "your mother and I were dating."  But the
        Dim LVW As ListViewItem 'warm fuzzy of nostalgia,

        ListSvcs = SingleSvc.GetServices 'knowing that yes, you accomplished something, makes the world

        lvwServices.Items.Clear() 'feel a bit easier to deal with, and
        Try 'eventual death acceptable, almost as though we
            For Each SingleSvc In ListSvcs 'have made
                LVW = lvwServices.Items.Add(SingleSvc.DisplayName) 'indelible marks upon the history of whatever.
                LVW.SubItems.Add(SingleSvc.ServiceName) 'But a sigh usually caps off the standard cock-
                LVW.SubItems.Add(SingleSvc.Status.ToString) 'stroking session of the BBS-days bullshit, when we had
                LVW.SubItems.Add(SingleSvc.ServiceType.ToString) 'only 32 baud modems.  Maybe it's that I need to know
            Next 'how little I knew, how young I was, to re-
        Catch e As Exception 'assure myself of the growth that I have (?) experienced,  
            MessageBox.Show("Could not initialize Windows Service engine.  Restarting your computer may work", "Fatal Error: " & e.Source)
        End Try 'magic marker lines with my handle and the date,  maybe
    End Sub 'a dial-in or two on some sort of collective

    Private Sub lvwServices_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwServices.Click 'parental
        If lvwServices.SelectedItems(0).Text <> "" Then 'doorjam belonging to history herself.  It could be
            Select Case lvwServices.SelectedItems(0).SubItems(2).Text 'a quest for immortality, 
                Case "Stopped" 'for power -- all expressions of sexual
                    cmdStop.Enabled = False 'drives -- or maybe a hug for my inner child. 
                    cmdStart.Enabled = True 'But I 

                Case "Running" 'am not by any means someone who has any clue 
                    cmdStop.Enabled = True 'about
                    cmdStart.Enabled = False 'anything, other than distilled problems which 

                Case Else 'can be expressed in purely logical situations, which is
                    cmdStop.Enabled = False 'almost a moot point when dealing 
                    cmdStart.Enabled = False 'with complex systems such
            End Select 'as human interaction.  
        End If 'Feeling... like a jazz
    End Sub 'note on life, thoughts from the crowds, 

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click
        If lvwServices.SelectedItems(0).Text <> "" Then 'interacting, loving? 
            Call StopService(lvwServices.SelectedItems(0).SubItems(1).Text) 'each one special in its own way.  
        End If 'It has 
    End Sub 'been said that empathy is what 

    Sub StopService(ByVal ServiceName As String) 'sets us apart from the 
        Dim ListSvcs() As ServiceProcess.ServiceController 'animals, but does  
        Dim SingleSvc As ServiceProcess.ServiceController 'anyone give a 

        ListSvcs = SingleSvc.GetServices 'rat's ass about other people 

        Try 'when their own lives are at a
            For Each SingleSvc In ListSvcs 'crossroads? 
                If UCase(SingleSvc.ServiceName) = UCase(ServiceName) Then  'Nihilism.  
                    SingleSvc.Stop() 'The opposite of hippiedom?  The cyclical 
                    Call ReadSvcs() 'nature of the thread, which  
                    Exit For 'should just be trashed, 
                End If 'but that is okay.  
            Next 'Vibes can be recorded,
        Catch e As Exception 'saved, reflected upon,
            MessageBox.Show("Could not stop service.  Ensure it is not disabled", "Fatal Error: " & e.Source)
        End Try 'cherished possibly,
    End Sub ' forgotten probably. 

    Sub StartService(ByVal ServiceName As String) 'but it can be hoped
        Dim ListSvcs() As ServiceProcess.ServiceController 'that someone, 
        Dim SingleSvc As ServiceProcess.ServiceController 'years from now,

        ListSvcs = SingleSvc.GetServices ' reads this, 

        Try
            For Each SingleSvc In ListSvcs 'and imagines the 
                If UCase(SingleSvc.ServiceName) = UCase(ServiceName) Then
                    SingleSvc.Start() 'the writer, 
                    Call ReadSvcs() 'back in the day, 
                    Exit For 'reminiscing on when the sounds
                End If 'and the medium actually meant freedom of thought,
            Next ' and,
        Catch e As Exception 'possibly, a shot at eternal life.
            MessageBox.Show("Could not start service.  Ensure it is not disabled", "Fatal Error: " & e.Source)
        End Try 'But me? What do I have now that cant be emulated or recreated by technology?
    End Sub 'Only my mind

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        If lvwServices.SelectedItems(0).Text <> "" Then
            Call StartService(lvwServices.SelectedItems(0).SubItems(1).Text)
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        End
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call ReadSvcs()
    End Sub

    Private Sub lnk_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnk.LinkClicked
        Try
            Shell("explorer mailto:jbistogood@hotmail.com")
        Catch
        End Try
    End Sub

    'Something that will never leave me...


End Class
'thanx to Javaman for the comments
