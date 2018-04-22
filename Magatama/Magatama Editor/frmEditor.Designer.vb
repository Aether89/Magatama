<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim mnuEditorFile As System.Windows.Forms.ToolStripMenuItem
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditor))
        Me.mnuEditorFileSaveMag = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorFileSaveChart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorFileUpdate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditorFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditor = New System.Windows.Forms.MenuStrip()
        Me.ttEditor = New System.Windows.Forms.ToolTip(Me.components)
        Me.tabEditor = New System.Windows.Forms.TabControl()
        Me.tabMag = New System.Windows.Forms.TabPage()
        Me.flpEditorMagVer = New System.Windows.Forms.FlowLayoutPanel()
        Me.radEditorMagEp1 = New System.Windows.Forms.RadioButton()
        Me.radEditorMagEp2 = New System.Windows.Forms.RadioButton()
        Me.radEditorMagEp4 = New System.Windows.Forms.RadioButton()
        Me.txtEditorSearchMag = New System.Windows.Forms.TextBox()
        Me.lsbEditorMag = New System.Windows.Forms.ListBox()
        Me.cboEditorPhotonBlast = New System.Windows.Forms.ComboBox()
        Me.picEditorMag = New System.Windows.Forms.PictureBox()
        Me.tabEditorMag = New System.Windows.Forms.TabControl()
        Me.tabEditorMagFeedingTable = New System.Windows.Forms.TabPage()
        Me.cboFeedVer = New System.Windows.Forms.ComboBox()
        Me.nudIQMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudEditorFeedingTables = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudSyncStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudIQDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudIQTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudIQMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudIQDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudIQTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudIQAntidote = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorStarAtomizer = New System.Windows.Forms.Label()
        Me.nudIQAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorMoonAtomizer = New System.Windows.Forms.Label()
        Me.nudIQSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorSolAtomizer = New System.Windows.Forms.Label()
        Me.nudIQMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorAntiparalysis = New System.Windows.Forms.Label()
        Me.nudIQStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorAntidote = New System.Windows.Forms.Label()
        Me.lblEditorSynchro = New System.Windows.Forms.Label()
        Me.lblEditorTrifluid = New System.Windows.Forms.Label()
        Me.lblEditorIQ = New System.Windows.Forms.Label()
        Me.lblEditorDifluid = New System.Windows.Forms.Label()
        Me.nudDEFMonomate = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorMonofluid = New System.Windows.Forms.Label()
        Me.nudDEFDimate = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorTrimate = New System.Windows.Forms.Label()
        Me.nudDEFTrimate = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorDimate = New System.Windows.Forms.Label()
        Me.nudDEFMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorMonomate = New System.Windows.Forms.Label()
        Me.nudDEFDifluid = New System.Windows.Forms.NumericUpDown()
        Me.lblFeedingTables = New System.Windows.Forms.Label()
        Me.nudDEFTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorMIND = New System.Windows.Forms.Label()
        Me.nudDEFAntidote = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorDEX = New System.Windows.Forms.Label()
        Me.nudDEFAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEFSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEFMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEFStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudMINDMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudPOWStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorDEF = New System.Windows.Forms.Label()
        Me.nudDEXAntidote = New System.Windows.Forms.NumericUpDown()
        Me.lblEditorPOW = New System.Windows.Forms.Label()
        Me.nudDEXTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudDEXTrimate = New System.Windows.Forms.NumericUpDown()
        Me.tabEditorMagHowtoGet = New System.Windows.Forms.TabPage()
        Me.tabEditorMagInfo = New System.Windows.Forms.TabPage()
        Me.rtfEditorMagInfo = New System.Windows.Forms.RichTextBox()
        Me.picEditorPhotonBlast = New System.Windows.Forms.PictureBox()
        Me.cboEditorPBFilled = New System.Windows.Forms.ComboBox()
        Me.cboEditor1HP10 = New System.Windows.Forms.ComboBox()
        Me.nudEditorStage = New System.Windows.Forms.NumericUpDown()
        Me.cboEditorBoss = New System.Windows.Forms.ComboBox()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.cboEditorDeath = New System.Windows.Forms.ComboBox()
        Me.lblEditorPBFilled = New System.Windows.Forms.Label()
        Me.nudEditorActivation = New System.Windows.Forms.NumericUpDown()
        Me.lblEditor1HP10 = New System.Windows.Forms.Label()
        Me.lblEditorActivation = New System.Windows.Forms.Label()
        Me.lblEditorBoss = New System.Windows.Forms.Label()
        Me.lblEditorDeath = New System.Windows.Forms.Label()
        Me.lblEditorMagName = New System.Windows.Forms.Label()
        Me.tabPhotonBlast = New System.Windows.Forms.TabPage()
        Me.tabMagCells = New System.Windows.Forms.TabPage()
        Me.picEditorSave = New System.Windows.Forms.PictureBox()
        mnuEditorFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditor.SuspendLayout()
        Me.tabEditor.SuspendLayout()
        Me.tabMag.SuspendLayout()
        Me.flpEditorMagVer.SuspendLayout()
        CType(Me.picEditorMag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditorMag.SuspendLayout()
        Me.tabEditorMagFeedingTable.SuspendLayout()
        CType(Me.nudIQMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEditorFeedingTables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSyncStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudIQStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEFStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMINDMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOWStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEXTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEditorMagInfo.SuspendLayout()
        CType(Me.picEditorPhotonBlast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEditorStage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudEditorActivation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picEditorSave, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuEditorFile
        '
        mnuEditorFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditorFileSaveMag, Me.mnuEditorFileSaveChart, Me.mnuEditorFileUpdate, Me.mnuEditorFileExit})
        mnuEditorFile.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        mnuEditorFile.Name = "mnuEditorFile"
        mnuEditorFile.Size = New System.Drawing.Size(38, 20)
        mnuEditorFile.Text = "File"
        '
        'mnuEditorFileSaveMag
        '
        Me.mnuEditorFileSaveMag.Name = "mnuEditorFileSaveMag"
        Me.mnuEditorFileSaveMag.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuEditorFileSaveMag.Size = New System.Drawing.Size(257, 22)
        Me.mnuEditorFileSaveMag.Text = "Save Mag"
        '
        'mnuEditorFileSaveChart
        '
        Me.mnuEditorFileSaveChart.Name = "mnuEditorFileSaveChart"
        Me.mnuEditorFileSaveChart.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuEditorFileSaveChart.Size = New System.Drawing.Size(257, 22)
        Me.mnuEditorFileSaveChart.Text = "Save Feeding Table"
        '
        'mnuEditorFileUpdate
        '
        Me.mnuEditorFileUpdate.Name = "mnuEditorFileUpdate"
        Me.mnuEditorFileUpdate.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuEditorFileUpdate.Size = New System.Drawing.Size(257, 22)
        Me.mnuEditorFileUpdate.Text = "&Update Mag"
        '
        'mnuEditorFileExit
        '
        Me.mnuEditorFileExit.Name = "mnuEditorFileExit"
        Me.mnuEditorFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.mnuEditorFileExit.Size = New System.Drawing.Size(257, 22)
        Me.mnuEditorFileExit.Text = "Exit"
        '
        'mnuEditor
        '
        Me.mnuEditor.BackColor = System.Drawing.Color.Transparent
        Me.mnuEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {mnuEditorFile})
        Me.mnuEditor.Location = New System.Drawing.Point(0, 0)
        Me.mnuEditor.Name = "mnuEditor"
        Me.mnuEditor.Size = New System.Drawing.Size(730, 24)
        Me.mnuEditor.TabIndex = 75
        Me.mnuEditor.Text = "MenuStrip1"
        '
        'tabEditor
        '
        Me.tabEditor.Controls.Add(Me.tabMag)
        Me.tabEditor.Controls.Add(Me.tabPhotonBlast)
        Me.tabEditor.Controls.Add(Me.tabMagCells)
        Me.tabEditor.Location = New System.Drawing.Point(8, 34)
        Me.tabEditor.Name = "tabEditor"
        Me.tabEditor.SelectedIndex = 0
        Me.tabEditor.Size = New System.Drawing.Size(714, 607)
        Me.tabEditor.TabIndex = 109
        '
        'tabMag
        '
        Me.tabMag.Controls.Add(Me.flpEditorMagVer)
        Me.tabMag.Controls.Add(Me.txtEditorSearchMag)
        Me.tabMag.Controls.Add(Me.lsbEditorMag)
        Me.tabMag.Controls.Add(Me.cboEditorPhotonBlast)
        Me.tabMag.Controls.Add(Me.picEditorMag)
        Me.tabMag.Controls.Add(Me.tabEditorMag)
        Me.tabMag.Controls.Add(Me.picEditorPhotonBlast)
        Me.tabMag.Controls.Add(Me.cboEditorPBFilled)
        Me.tabMag.Controls.Add(Me.cboEditor1HP10)
        Me.tabMag.Controls.Add(Me.nudEditorStage)
        Me.tabMag.Controls.Add(Me.cboEditorBoss)
        Me.tabMag.Controls.Add(Me.lblStage)
        Me.tabMag.Controls.Add(Me.cboEditorDeath)
        Me.tabMag.Controls.Add(Me.lblEditorPBFilled)
        Me.tabMag.Controls.Add(Me.nudEditorActivation)
        Me.tabMag.Controls.Add(Me.lblEditor1HP10)
        Me.tabMag.Controls.Add(Me.lblEditorActivation)
        Me.tabMag.Controls.Add(Me.lblEditorBoss)
        Me.tabMag.Controls.Add(Me.lblEditorDeath)
        Me.tabMag.Controls.Add(Me.lblEditorMagName)
        Me.tabMag.Location = New System.Drawing.Point(4, 22)
        Me.tabMag.Name = "tabMag"
        Me.tabMag.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMag.Size = New System.Drawing.Size(706, 581)
        Me.tabMag.TabIndex = 0
        Me.tabMag.Text = "Mag"
        '
        'flpEditorMagVer
        '
        Me.flpEditorMagVer.BackColor = System.Drawing.Color.IndianRed
        Me.flpEditorMagVer.Controls.Add(Me.radEditorMagEp1)
        Me.flpEditorMagVer.Controls.Add(Me.radEditorMagEp2)
        Me.flpEditorMagVer.Controls.Add(Me.radEditorMagEp4)
        Me.flpEditorMagVer.Location = New System.Drawing.Point(231, 71)
        Me.flpEditorMagVer.Name = "flpEditorMagVer"
        Me.flpEditorMagVer.Size = New System.Drawing.Size(183, 24)
        Me.flpEditorMagVer.TabIndex = 110
        '
        'radEditorMagEp1
        '
        Me.radEditorMagEp1.AutoSize = True
        Me.radEditorMagEp1.BackColor = System.Drawing.Color.Transparent
        Me.radEditorMagEp1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEditorMagEp1.ForeColor = System.Drawing.Color.White
        Me.radEditorMagEp1.Location = New System.Drawing.Point(3, 3)
        Me.radEditorMagEp1.Name = "radEditorMagEp1"
        Me.radEditorMagEp1.Size = New System.Drawing.Size(55, 21)
        Me.radEditorMagEp1.TabIndex = 0
        Me.radEditorMagEp1.TabStop = True
        Me.radEditorMagEp1.Text = "Ep. 1"
        Me.radEditorMagEp1.UseVisualStyleBackColor = False
        '
        'radEditorMagEp2
        '
        Me.radEditorMagEp2.AutoSize = True
        Me.radEditorMagEp2.BackColor = System.Drawing.Color.Transparent
        Me.radEditorMagEp2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEditorMagEp2.ForeColor = System.Drawing.Color.White
        Me.radEditorMagEp2.Location = New System.Drawing.Point(64, 3)
        Me.radEditorMagEp2.Name = "radEditorMagEp2"
        Me.radEditorMagEp2.Size = New System.Drawing.Size(55, 21)
        Me.radEditorMagEp2.TabIndex = 0
        Me.radEditorMagEp2.TabStop = True
        Me.radEditorMagEp2.Text = "Ep. 2"
        Me.radEditorMagEp2.UseVisualStyleBackColor = False
        '
        'radEditorMagEp4
        '
        Me.radEditorMagEp4.AutoSize = True
        Me.radEditorMagEp4.BackColor = System.Drawing.Color.Transparent
        Me.radEditorMagEp4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radEditorMagEp4.ForeColor = System.Drawing.Color.White
        Me.radEditorMagEp4.Location = New System.Drawing.Point(125, 3)
        Me.radEditorMagEp4.Name = "radEditorMagEp4"
        Me.radEditorMagEp4.Size = New System.Drawing.Size(55, 21)
        Me.radEditorMagEp4.TabIndex = 0
        Me.radEditorMagEp4.TabStop = True
        Me.radEditorMagEp4.Text = "Ep. 4"
        Me.radEditorMagEp4.UseVisualStyleBackColor = False
        '
        'txtEditorSearchMag
        '
        Me.txtEditorSearchMag.Location = New System.Drawing.Point(9, 9)
        Me.txtEditorSearchMag.Name = "txtEditorSearchMag"
        Me.txtEditorSearchMag.Size = New System.Drawing.Size(136, 20)
        Me.txtEditorSearchMag.TabIndex = 109
        '
        'lsbEditorMag
        '
        Me.lsbEditorMag.FormattingEnabled = True
        Me.lsbEditorMag.Location = New System.Drawing.Point(9, 35)
        Me.lsbEditorMag.Name = "lsbEditorMag"
        Me.lsbEditorMag.Size = New System.Drawing.Size(136, 537)
        Me.lsbEditorMag.TabIndex = 106
        '
        'cboEditorPhotonBlast
        '
        Me.cboEditorPhotonBlast.FormattingEnabled = True
        Me.cboEditorPhotonBlast.Location = New System.Drawing.Point(270, 101)
        Me.cboEditorPhotonBlast.Name = "cboEditorPhotonBlast"
        Me.cboEditorPhotonBlast.Size = New System.Drawing.Size(144, 21)
        Me.cboEditorPhotonBlast.TabIndex = 6
        '
        'picEditorMag
        '
        Me.picEditorMag.BackColor = System.Drawing.Color.Transparent
        Me.picEditorMag.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picEditorMag.InitialImage = Nothing
        Me.picEditorMag.Location = New System.Drawing.Point(161, 17)
        Me.picEditorMag.Name = "picEditorMag"
        Me.picEditorMag.Size = New System.Drawing.Size(64, 64)
        Me.picEditorMag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEditorMag.TabIndex = 0
        Me.picEditorMag.TabStop = False
        '
        'tabEditorMag
        '
        Me.tabEditorMag.Controls.Add(Me.tabEditorMagFeedingTable)
        Me.tabEditorMag.Controls.Add(Me.tabEditorMagHowtoGet)
        Me.tabEditorMag.Controls.Add(Me.tabEditorMagInfo)
        Me.tabEditorMag.HotTrack = True
        Me.tabEditorMag.Location = New System.Drawing.Point(151, 187)
        Me.tabEditorMag.Multiline = True
        Me.tabEditorMag.Name = "tabEditorMag"
        Me.tabEditorMag.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tabEditorMag.RightToLeftLayout = True
        Me.tabEditorMag.SelectedIndex = 0
        Me.tabEditorMag.Size = New System.Drawing.Size(546, 385)
        Me.tabEditorMag.TabIndex = 108
        '
        'tabEditorMagFeedingTable
        '
        Me.tabEditorMagFeedingTable.Controls.Add(Me.cboFeedVer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudEditorFeedingTables)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudSyncStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudIQStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorSynchro)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorIQ)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblFeedingTables)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorMIND)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorDEX)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEFStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDTrimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudMINDMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWMoonAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXSolAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudPOWStarAtomizer)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXAntiparalysis)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorDEF)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXAntidote)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.lblEditorPOW)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXTrifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXMonomate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXDifluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXDimate)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXMonofluid)
        Me.tabEditorMagFeedingTable.Controls.Add(Me.nudDEXTrimate)
        Me.tabEditorMagFeedingTable.Location = New System.Drawing.Point(4, 22)
        Me.tabEditorMagFeedingTable.Name = "tabEditorMagFeedingTable"
        Me.tabEditorMagFeedingTable.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditorMagFeedingTable.Size = New System.Drawing.Size(538, 359)
        Me.tabEditorMagFeedingTable.TabIndex = 0
        Me.tabEditorMagFeedingTable.Text = "Feeding Table"
        '
        'cboFeedVer
        '
        Me.cboFeedVer.FormattingEnabled = True
        Me.cboFeedVer.Items.AddRange(New Object() {"Episode 1", "Episode 2"})
        Me.cboFeedVer.Location = New System.Drawing.Point(6, 9)
        Me.cboFeedVer.Name = "cboFeedVer"
        Me.cboFeedVer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboFeedVer.Size = New System.Drawing.Size(121, 21)
        Me.cboFeedVer.TabIndex = 89
        '
        'nudIQMonomate
        '
        Me.nudIQMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudIQMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQMonomate.Location = New System.Drawing.Point(404, 63)
        Me.nudIQMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQMonomate.Name = "nudIQMonomate"
        Me.nudIQMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudIQMonomate.TabIndex = 12
        '
        'nudSyncMonomate
        '
        Me.nudSyncMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudSyncMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncMonomate.Location = New System.Drawing.Point(461, 63)
        Me.nudSyncMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncMonomate.Name = "nudSyncMonomate"
        Me.nudSyncMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncMonomate.TabIndex = 13
        '
        'nudSyncDimate
        '
        Me.nudSyncDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudSyncDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncDimate.Location = New System.Drawing.Point(461, 89)
        Me.nudSyncDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncDimate.Name = "nudSyncDimate"
        Me.nudSyncDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncDimate.TabIndex = 19
        '
        'nudSyncTrimate
        '
        Me.nudSyncTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudSyncTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncTrimate.Location = New System.Drawing.Point(461, 115)
        Me.nudSyncTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncTrimate.Name = "nudSyncTrimate"
        Me.nudSyncTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncTrimate.TabIndex = 25
        '
        'nudEditorFeedingTables
        '
        Me.nudEditorFeedingTables.BackColor = System.Drawing.SystemColors.Window
        Me.nudEditorFeedingTables.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEditorFeedingTables.Location = New System.Drawing.Point(461, 10)
        Me.nudEditorFeedingTables.Maximum = New Decimal(New Integer() {7, 0, 0, 0})
        Me.nudEditorFeedingTables.Name = "nudEditorFeedingTables"
        Me.nudEditorFeedingTables.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudEditorFeedingTables.Size = New System.Drawing.Size(51, 20)
        Me.nudEditorFeedingTables.TabIndex = 7
        '
        'nudSyncMonofluid
        '
        Me.nudSyncMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncMonofluid.Location = New System.Drawing.Point(461, 141)
        Me.nudSyncMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncMonofluid.Name = "nudSyncMonofluid"
        Me.nudSyncMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncMonofluid.TabIndex = 31
        '
        'nudSyncDifluid
        '
        Me.nudSyncDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncDifluid.Location = New System.Drawing.Point(461, 167)
        Me.nudSyncDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncDifluid.Name = "nudSyncDifluid"
        Me.nudSyncDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncDifluid.TabIndex = 37
        '
        'nudSyncTrifluid
        '
        Me.nudSyncTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncTrifluid.Location = New System.Drawing.Point(461, 193)
        Me.nudSyncTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncTrifluid.Name = "nudSyncTrifluid"
        Me.nudSyncTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncTrifluid.TabIndex = 43
        '
        'nudSyncAntidote
        '
        Me.nudSyncAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncAntidote.Location = New System.Drawing.Point(461, 219)
        Me.nudSyncAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncAntidote.Name = "nudSyncAntidote"
        Me.nudSyncAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncAntidote.TabIndex = 49
        '
        'nudSyncAntiparalysis
        '
        Me.nudSyncAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncAntiparalysis.Location = New System.Drawing.Point(461, 245)
        Me.nudSyncAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncAntiparalysis.Name = "nudSyncAntiparalysis"
        Me.nudSyncAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncAntiparalysis.TabIndex = 55
        '
        'nudSyncSolAtomizer
        '
        Me.nudSyncSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncSolAtomizer.Location = New System.Drawing.Point(461, 271)
        Me.nudSyncSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncSolAtomizer.Name = "nudSyncSolAtomizer"
        Me.nudSyncSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncSolAtomizer.TabIndex = 61
        '
        'nudSyncMoonAtomizer
        '
        Me.nudSyncMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncMoonAtomizer.Location = New System.Drawing.Point(461, 297)
        Me.nudSyncMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncMoonAtomizer.Name = "nudSyncMoonAtomizer"
        Me.nudSyncMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncMoonAtomizer.TabIndex = 67
        '
        'nudSyncStarAtomizer
        '
        Me.nudSyncStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudSyncStarAtomizer.Location = New System.Drawing.Point(461, 323)
        Me.nudSyncStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudSyncStarAtomizer.Name = "nudSyncStarAtomizer"
        Me.nudSyncStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudSyncStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudSyncStarAtomizer.TabIndex = 73
        '
        'nudIQDimate
        '
        Me.nudIQDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudIQDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQDimate.Location = New System.Drawing.Point(404, 89)
        Me.nudIQDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQDimate.Name = "nudIQDimate"
        Me.nudIQDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudIQDimate.TabIndex = 18
        '
        'nudIQTrimate
        '
        Me.nudIQTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudIQTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQTrimate.Location = New System.Drawing.Point(404, 115)
        Me.nudIQTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQTrimate.Name = "nudIQTrimate"
        Me.nudIQTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudIQTrimate.TabIndex = 24
        '
        'nudIQMonofluid
        '
        Me.nudIQMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQMonofluid.Location = New System.Drawing.Point(404, 141)
        Me.nudIQMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQMonofluid.Name = "nudIQMonofluid"
        Me.nudIQMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudIQMonofluid.TabIndex = 30
        '
        'nudIQDifluid
        '
        Me.nudIQDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQDifluid.Location = New System.Drawing.Point(404, 167)
        Me.nudIQDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQDifluid.Name = "nudIQDifluid"
        Me.nudIQDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudIQDifluid.TabIndex = 36
        '
        'nudIQTrifluid
        '
        Me.nudIQTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQTrifluid.Location = New System.Drawing.Point(404, 193)
        Me.nudIQTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQTrifluid.Name = "nudIQTrifluid"
        Me.nudIQTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudIQTrifluid.TabIndex = 42
        '
        'nudIQAntidote
        '
        Me.nudIQAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQAntidote.Location = New System.Drawing.Point(404, 219)
        Me.nudIQAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQAntidote.Name = "nudIQAntidote"
        Me.nudIQAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudIQAntidote.TabIndex = 48
        '
        'lblEditorStarAtomizer
        '
        Me.lblEditorStarAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorStarAtomizer.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorStarAtomizer.Location = New System.Drawing.Point(21, 323)
        Me.lblEditorStarAtomizer.Name = "lblEditorStarAtomizer"
        Me.lblEditorStarAtomizer.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorStarAtomizer.TabIndex = 88
        Me.lblEditorStarAtomizer.Text = "Star Atomizer"
        Me.lblEditorStarAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudIQAntiparalysis
        '
        Me.nudIQAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQAntiparalysis.Location = New System.Drawing.Point(404, 245)
        Me.nudIQAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQAntiparalysis.Name = "nudIQAntiparalysis"
        Me.nudIQAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudIQAntiparalysis.TabIndex = 54
        '
        'lblEditorMoonAtomizer
        '
        Me.lblEditorMoonAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorMoonAtomizer.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorMoonAtomizer.Location = New System.Drawing.Point(21, 297)
        Me.lblEditorMoonAtomizer.Name = "lblEditorMoonAtomizer"
        Me.lblEditorMoonAtomizer.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorMoonAtomizer.TabIndex = 87
        Me.lblEditorMoonAtomizer.Text = "Moon Atomizer"
        Me.lblEditorMoonAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudIQSolAtomizer
        '
        Me.nudIQSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQSolAtomizer.Location = New System.Drawing.Point(404, 271)
        Me.nudIQSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQSolAtomizer.Name = "nudIQSolAtomizer"
        Me.nudIQSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudIQSolAtomizer.TabIndex = 60
        '
        'lblEditorSolAtomizer
        '
        Me.lblEditorSolAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorSolAtomizer.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorSolAtomizer.Location = New System.Drawing.Point(21, 271)
        Me.lblEditorSolAtomizer.Name = "lblEditorSolAtomizer"
        Me.lblEditorSolAtomizer.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorSolAtomizer.TabIndex = 86
        Me.lblEditorSolAtomizer.Text = "Sol Atomizer"
        Me.lblEditorSolAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudIQMoonAtomizer
        '
        Me.nudIQMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQMoonAtomizer.Location = New System.Drawing.Point(404, 297)
        Me.nudIQMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQMoonAtomizer.Name = "nudIQMoonAtomizer"
        Me.nudIQMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudIQMoonAtomizer.TabIndex = 66
        '
        'lblEditorAntiparalysis
        '
        Me.lblEditorAntiparalysis.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorAntiparalysis.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorAntiparalysis.Location = New System.Drawing.Point(21, 245)
        Me.lblEditorAntiparalysis.Name = "lblEditorAntiparalysis"
        Me.lblEditorAntiparalysis.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorAntiparalysis.TabIndex = 85
        Me.lblEditorAntiparalysis.Text = "Antiparalysis"
        Me.lblEditorAntiparalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudIQStarAtomizer
        '
        Me.nudIQStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudIQStarAtomizer.Location = New System.Drawing.Point(404, 323)
        Me.nudIQStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudIQStarAtomizer.Name = "nudIQStarAtomizer"
        Me.nudIQStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudIQStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudIQStarAtomizer.TabIndex = 72
        '
        'lblEditorAntidote
        '
        Me.lblEditorAntidote.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorAntidote.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorAntidote.Location = New System.Drawing.Point(21, 219)
        Me.lblEditorAntidote.Name = "lblEditorAntidote"
        Me.lblEditorAntidote.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorAntidote.TabIndex = 84
        Me.lblEditorAntidote.Text = "Antidote"
        Me.lblEditorAntidote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorSynchro
        '
        Me.lblEditorSynchro.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorSynchro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorSynchro.Location = New System.Drawing.Point(461, 36)
        Me.lblEditorSynchro.Name = "lblEditorSynchro"
        Me.lblEditorSynchro.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorSynchro.TabIndex = 27
        Me.lblEditorSynchro.Text = "Sync"
        Me.lblEditorSynchro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEditorTrifluid
        '
        Me.lblEditorTrifluid.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorTrifluid.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorTrifluid.Location = New System.Drawing.Point(21, 193)
        Me.lblEditorTrifluid.Name = "lblEditorTrifluid"
        Me.lblEditorTrifluid.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorTrifluid.TabIndex = 83
        Me.lblEditorTrifluid.Text = "Trifluid"
        Me.lblEditorTrifluid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorIQ
        '
        Me.lblEditorIQ.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorIQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorIQ.Location = New System.Drawing.Point(404, 36)
        Me.lblEditorIQ.Name = "lblEditorIQ"
        Me.lblEditorIQ.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorIQ.TabIndex = 28
        Me.lblEditorIQ.Text = "IQ"
        Me.lblEditorIQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEditorDifluid
        '
        Me.lblEditorDifluid.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorDifluid.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorDifluid.Location = New System.Drawing.Point(21, 167)
        Me.lblEditorDifluid.Name = "lblEditorDifluid"
        Me.lblEditorDifluid.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorDifluid.TabIndex = 82
        Me.lblEditorDifluid.Text = "Difluid"
        Me.lblEditorDifluid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDEFMonomate
        '
        Me.nudDEFMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEFMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFMonomate.Location = New System.Drawing.Point(176, 63)
        Me.nudDEFMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFMonomate.Name = "nudDEFMonomate"
        Me.nudDEFMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFMonomate.TabIndex = 8
        '
        'lblEditorMonofluid
        '
        Me.lblEditorMonofluid.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorMonofluid.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorMonofluid.Location = New System.Drawing.Point(21, 141)
        Me.lblEditorMonofluid.Name = "lblEditorMonofluid"
        Me.lblEditorMonofluid.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorMonofluid.TabIndex = 81
        Me.lblEditorMonofluid.Text = "Monofluid"
        Me.lblEditorMonofluid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDEFDimate
        '
        Me.nudDEFDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEFDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFDimate.Location = New System.Drawing.Point(176, 89)
        Me.nudDEFDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFDimate.Name = "nudDEFDimate"
        Me.nudDEFDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFDimate.TabIndex = 14
        '
        'lblEditorTrimate
        '
        Me.lblEditorTrimate.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorTrimate.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorTrimate.Location = New System.Drawing.Point(21, 115)
        Me.lblEditorTrimate.Name = "lblEditorTrimate"
        Me.lblEditorTrimate.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorTrimate.TabIndex = 80
        Me.lblEditorTrimate.Text = "Trimate"
        Me.lblEditorTrimate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDEFTrimate
        '
        Me.nudDEFTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEFTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFTrimate.Location = New System.Drawing.Point(176, 115)
        Me.nudDEFTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFTrimate.Name = "nudDEFTrimate"
        Me.nudDEFTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFTrimate.TabIndex = 20
        '
        'lblEditorDimate
        '
        Me.lblEditorDimate.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorDimate.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorDimate.Location = New System.Drawing.Point(21, 89)
        Me.lblEditorDimate.Name = "lblEditorDimate"
        Me.lblEditorDimate.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorDimate.TabIndex = 79
        Me.lblEditorDimate.Text = "Dimate"
        Me.lblEditorDimate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDEFMonofluid
        '
        Me.nudDEFMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFMonofluid.Location = New System.Drawing.Point(176, 141)
        Me.nudDEFMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFMonofluid.Name = "nudDEFMonofluid"
        Me.nudDEFMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFMonofluid.TabIndex = 26
        '
        'lblEditorMonomate
        '
        Me.lblEditorMonomate.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorMonomate.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorMonomate.Location = New System.Drawing.Point(21, 63)
        Me.lblEditorMonomate.Name = "lblEditorMonomate"
        Me.lblEditorMonomate.Size = New System.Drawing.Size(149, 20)
        Me.lblEditorMonomate.TabIndex = 78
        Me.lblEditorMonomate.Text = "Monomate"
        Me.lblEditorMonomate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudDEFDifluid
        '
        Me.nudDEFDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFDifluid.Location = New System.Drawing.Point(176, 167)
        Me.nudDEFDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFDifluid.Name = "nudDEFDifluid"
        Me.nudDEFDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFDifluid.TabIndex = 32
        '
        'lblFeedingTables
        '
        Me.lblFeedingTables.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedingTables.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblFeedingTables.Location = New System.Drawing.Point(176, 10)
        Me.lblFeedingTables.Name = "lblFeedingTables"
        Me.lblFeedingTables.Size = New System.Drawing.Size(279, 20)
        Me.lblFeedingTables.TabIndex = 77
        Me.lblFeedingTables.Text = "Feeding Tables"
        Me.lblFeedingTables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDEFTrifluid
        '
        Me.nudDEFTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFTrifluid.Location = New System.Drawing.Point(176, 193)
        Me.nudDEFTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFTrifluid.Name = "nudDEFTrifluid"
        Me.nudDEFTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFTrifluid.TabIndex = 38
        '
        'lblEditorMIND
        '
        Me.lblEditorMIND.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorMIND.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorMIND.Location = New System.Drawing.Point(347, 36)
        Me.lblEditorMIND.Name = "lblEditorMIND"
        Me.lblEditorMIND.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorMIND.TabIndex = 76
        Me.lblEditorMIND.Text = "Mind"
        Me.lblEditorMIND.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDEFAntidote
        '
        Me.nudDEFAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFAntidote.Location = New System.Drawing.Point(176, 219)
        Me.nudDEFAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFAntidote.Name = "nudDEFAntidote"
        Me.nudDEFAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFAntidote.TabIndex = 44
        '
        'lblEditorDEX
        '
        Me.lblEditorDEX.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorDEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorDEX.Location = New System.Drawing.Point(290, 36)
        Me.lblEditorDEX.Name = "lblEditorDEX"
        Me.lblEditorDEX.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorDEX.TabIndex = 75
        Me.lblEditorDEX.Text = "DEX"
        Me.lblEditorDEX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDEFAntiparalysis
        '
        Me.nudDEFAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFAntiparalysis.Location = New System.Drawing.Point(176, 245)
        Me.nudDEFAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFAntiparalysis.Name = "nudDEFAntiparalysis"
        Me.nudDEFAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFAntiparalysis.TabIndex = 50
        '
        'nudMINDStarAtomizer
        '
        Me.nudMINDStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDStarAtomizer.Location = New System.Drawing.Point(347, 323)
        Me.nudMINDStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDStarAtomizer.Name = "nudMINDStarAtomizer"
        Me.nudMINDStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDStarAtomizer.TabIndex = 71
        '
        'nudDEFSolAtomizer
        '
        Me.nudDEFSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFSolAtomizer.Location = New System.Drawing.Point(176, 271)
        Me.nudDEFSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFSolAtomizer.Name = "nudDEFSolAtomizer"
        Me.nudDEFSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFSolAtomizer.TabIndex = 56
        '
        'nudMINDMoonAtomizer
        '
        Me.nudMINDMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDMoonAtomizer.Location = New System.Drawing.Point(347, 297)
        Me.nudMINDMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDMoonAtomizer.Name = "nudMINDMoonAtomizer"
        Me.nudMINDMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDMoonAtomizer.TabIndex = 65
        '
        'nudDEFMoonAtomizer
        '
        Me.nudDEFMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFMoonAtomizer.Location = New System.Drawing.Point(176, 297)
        Me.nudDEFMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFMoonAtomizer.Name = "nudDEFMoonAtomizer"
        Me.nudDEFMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFMoonAtomizer.TabIndex = 62
        '
        'nudMINDSolAtomizer
        '
        Me.nudMINDSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDSolAtomizer.Location = New System.Drawing.Point(347, 271)
        Me.nudMINDSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDSolAtomizer.Name = "nudMINDSolAtomizer"
        Me.nudMINDSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDSolAtomizer.TabIndex = 59
        '
        'nudDEFStarAtomizer
        '
        Me.nudDEFStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEFStarAtomizer.Location = New System.Drawing.Point(176, 323)
        Me.nudDEFStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEFStarAtomizer.Name = "nudDEFStarAtomizer"
        Me.nudDEFStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEFStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEFStarAtomizer.TabIndex = 68
        '
        'nudMINDAntiparalysis
        '
        Me.nudMINDAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDAntiparalysis.Location = New System.Drawing.Point(347, 245)
        Me.nudMINDAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDAntiparalysis.Name = "nudMINDAntiparalysis"
        Me.nudMINDAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDAntiparalysis.TabIndex = 53
        '
        'nudPOWMonomate
        '
        Me.nudPOWMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudPOWMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWMonomate.Location = New System.Drawing.Point(233, 63)
        Me.nudPOWMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWMonomate.Name = "nudPOWMonomate"
        Me.nudPOWMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWMonomate.TabIndex = 9
        '
        'nudMINDAntidote
        '
        Me.nudMINDAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDAntidote.Location = New System.Drawing.Point(347, 219)
        Me.nudMINDAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDAntidote.Name = "nudMINDAntidote"
        Me.nudMINDAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDAntidote.TabIndex = 47
        '
        'nudPOWDimate
        '
        Me.nudPOWDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudPOWDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWDimate.Location = New System.Drawing.Point(233, 89)
        Me.nudPOWDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWDimate.Name = "nudPOWDimate"
        Me.nudPOWDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWDimate.TabIndex = 15
        '
        'nudMINDTrifluid
        '
        Me.nudMINDTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDTrifluid.Location = New System.Drawing.Point(347, 193)
        Me.nudMINDTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDTrifluid.Name = "nudMINDTrifluid"
        Me.nudMINDTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDTrifluid.TabIndex = 41
        '
        'nudPOWTrimate
        '
        Me.nudPOWTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudPOWTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWTrimate.Location = New System.Drawing.Point(233, 115)
        Me.nudPOWTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWTrimate.Name = "nudPOWTrimate"
        Me.nudPOWTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWTrimate.TabIndex = 21
        '
        'nudMINDDifluid
        '
        Me.nudMINDDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDDifluid.Location = New System.Drawing.Point(347, 167)
        Me.nudMINDDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDDifluid.Name = "nudMINDDifluid"
        Me.nudMINDDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDDifluid.TabIndex = 35
        '
        'nudPOWMonofluid
        '
        Me.nudPOWMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWMonofluid.Location = New System.Drawing.Point(233, 141)
        Me.nudPOWMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWMonofluid.Name = "nudPOWMonofluid"
        Me.nudPOWMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWMonofluid.TabIndex = 27
        '
        'nudMINDMonofluid
        '
        Me.nudMINDMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDMonofluid.Location = New System.Drawing.Point(347, 141)
        Me.nudMINDMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDMonofluid.Name = "nudMINDMonofluid"
        Me.nudMINDMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDMonofluid.TabIndex = 29
        '
        'nudPOWDifluid
        '
        Me.nudPOWDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWDifluid.Location = New System.Drawing.Point(233, 167)
        Me.nudPOWDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWDifluid.Name = "nudPOWDifluid"
        Me.nudPOWDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWDifluid.TabIndex = 33
        '
        'nudMINDTrimate
        '
        Me.nudMINDTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudMINDTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDTrimate.Location = New System.Drawing.Point(347, 115)
        Me.nudMINDTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDTrimate.Name = "nudMINDTrimate"
        Me.nudMINDTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDTrimate.TabIndex = 23
        '
        'nudPOWTrifluid
        '
        Me.nudPOWTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWTrifluid.Location = New System.Drawing.Point(233, 193)
        Me.nudPOWTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWTrifluid.Name = "nudPOWTrifluid"
        Me.nudPOWTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWTrifluid.TabIndex = 39
        '
        'nudMINDDimate
        '
        Me.nudMINDDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudMINDDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDDimate.Location = New System.Drawing.Point(347, 89)
        Me.nudMINDDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDDimate.Name = "nudMINDDimate"
        Me.nudMINDDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDDimate.TabIndex = 17
        '
        'nudPOWAntidote
        '
        Me.nudPOWAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWAntidote.Location = New System.Drawing.Point(233, 219)
        Me.nudPOWAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWAntidote.Name = "nudPOWAntidote"
        Me.nudPOWAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWAntidote.TabIndex = 45
        '
        'nudMINDMonomate
        '
        Me.nudMINDMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudMINDMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMINDMonomate.Location = New System.Drawing.Point(347, 63)
        Me.nudMINDMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudMINDMonomate.Name = "nudMINDMonomate"
        Me.nudMINDMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudMINDMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudMINDMonomate.TabIndex = 11
        '
        'nudPOWAntiparalysis
        '
        Me.nudPOWAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWAntiparalysis.Location = New System.Drawing.Point(233, 245)
        Me.nudPOWAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWAntiparalysis.Name = "nudPOWAntiparalysis"
        Me.nudPOWAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWAntiparalysis.TabIndex = 51
        '
        'nudDEXStarAtomizer
        '
        Me.nudDEXStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXStarAtomizer.Location = New System.Drawing.Point(290, 323)
        Me.nudDEXStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXStarAtomizer.Name = "nudDEXStarAtomizer"
        Me.nudDEXStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXStarAtomizer.TabIndex = 70
        '
        'nudPOWSolAtomizer
        '
        Me.nudPOWSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWSolAtomizer.Location = New System.Drawing.Point(233, 271)
        Me.nudPOWSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWSolAtomizer.Name = "nudPOWSolAtomizer"
        Me.nudPOWSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWSolAtomizer.TabIndex = 57
        '
        'nudDEXMoonAtomizer
        '
        Me.nudDEXMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXMoonAtomizer.Location = New System.Drawing.Point(290, 297)
        Me.nudDEXMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXMoonAtomizer.Name = "nudDEXMoonAtomizer"
        Me.nudDEXMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXMoonAtomizer.TabIndex = 64
        '
        'nudPOWMoonAtomizer
        '
        Me.nudPOWMoonAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWMoonAtomizer.Location = New System.Drawing.Point(233, 297)
        Me.nudPOWMoonAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWMoonAtomizer.Name = "nudPOWMoonAtomizer"
        Me.nudPOWMoonAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWMoonAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWMoonAtomizer.TabIndex = 63
        '
        'nudDEXSolAtomizer
        '
        Me.nudDEXSolAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXSolAtomizer.Location = New System.Drawing.Point(290, 271)
        Me.nudDEXSolAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXSolAtomizer.Name = "nudDEXSolAtomizer"
        Me.nudDEXSolAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXSolAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXSolAtomizer.TabIndex = 58
        '
        'nudPOWStarAtomizer
        '
        Me.nudPOWStarAtomizer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudPOWStarAtomizer.Location = New System.Drawing.Point(233, 323)
        Me.nudPOWStarAtomizer.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudPOWStarAtomizer.Name = "nudPOWStarAtomizer"
        Me.nudPOWStarAtomizer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudPOWStarAtomizer.Size = New System.Drawing.Size(51, 20)
        Me.nudPOWStarAtomizer.TabIndex = 69
        '
        'nudDEXAntiparalysis
        '
        Me.nudDEXAntiparalysis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXAntiparalysis.Location = New System.Drawing.Point(290, 245)
        Me.nudDEXAntiparalysis.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXAntiparalysis.Name = "nudDEXAntiparalysis"
        Me.nudDEXAntiparalysis.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXAntiparalysis.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXAntiparalysis.TabIndex = 52
        '
        'lblEditorDEF
        '
        Me.lblEditorDEF.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorDEF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorDEF.Location = New System.Drawing.Point(176, 36)
        Me.lblEditorDEF.Name = "lblEditorDEF"
        Me.lblEditorDEF.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorDEF.TabIndex = 51
        Me.lblEditorDEF.Text = "DEF"
        Me.lblEditorDEF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDEXAntidote
        '
        Me.nudDEXAntidote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXAntidote.Location = New System.Drawing.Point(290, 219)
        Me.nudDEXAntidote.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXAntidote.Name = "nudDEXAntidote"
        Me.nudDEXAntidote.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXAntidote.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXAntidote.TabIndex = 46
        '
        'lblEditorPOW
        '
        Me.lblEditorPOW.BackColor = System.Drawing.Color.Transparent
        Me.lblEditorPOW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorPOW.Location = New System.Drawing.Point(233, 36)
        Me.lblEditorPOW.Name = "lblEditorPOW"
        Me.lblEditorPOW.Size = New System.Drawing.Size(51, 21)
        Me.lblEditorPOW.TabIndex = 52
        Me.lblEditorPOW.Text = "POW"
        Me.lblEditorPOW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudDEXTrifluid
        '
        Me.nudDEXTrifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXTrifluid.Location = New System.Drawing.Point(290, 193)
        Me.nudDEXTrifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXTrifluid.Name = "nudDEXTrifluid"
        Me.nudDEXTrifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXTrifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXTrifluid.TabIndex = 40
        '
        'nudDEXMonomate
        '
        Me.nudDEXMonomate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEXMonomate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXMonomate.Location = New System.Drawing.Point(290, 63)
        Me.nudDEXMonomate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXMonomate.Name = "nudDEXMonomate"
        Me.nudDEXMonomate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXMonomate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXMonomate.TabIndex = 10
        '
        'nudDEXDifluid
        '
        Me.nudDEXDifluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXDifluid.Location = New System.Drawing.Point(290, 167)
        Me.nudDEXDifluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXDifluid.Name = "nudDEXDifluid"
        Me.nudDEXDifluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXDifluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXDifluid.TabIndex = 34
        '
        'nudDEXDimate
        '
        Me.nudDEXDimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEXDimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXDimate.Location = New System.Drawing.Point(290, 89)
        Me.nudDEXDimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXDimate.Name = "nudDEXDimate"
        Me.nudDEXDimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXDimate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXDimate.TabIndex = 16
        '
        'nudDEXMonofluid
        '
        Me.nudDEXMonofluid.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXMonofluid.Location = New System.Drawing.Point(290, 141)
        Me.nudDEXMonofluid.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXMonofluid.Name = "nudDEXMonofluid"
        Me.nudDEXMonofluid.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXMonofluid.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXMonofluid.TabIndex = 28
        '
        'nudDEXTrimate
        '
        Me.nudDEXTrimate.BackColor = System.Drawing.SystemColors.Window
        Me.nudDEXTrimate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudDEXTrimate.Location = New System.Drawing.Point(290, 115)
        Me.nudDEXTrimate.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudDEXTrimate.Name = "nudDEXTrimate"
        Me.nudDEXTrimate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.nudDEXTrimate.Size = New System.Drawing.Size(51, 20)
        Me.nudDEXTrimate.TabIndex = 22
        '
        'tabEditorMagHowtoGet
        '
        Me.tabEditorMagHowtoGet.Location = New System.Drawing.Point(4, 22)
        Me.tabEditorMagHowtoGet.Name = "tabEditorMagHowtoGet"
        Me.tabEditorMagHowtoGet.Size = New System.Drawing.Size(538, 359)
        Me.tabEditorMagHowtoGet.TabIndex = 4
        Me.tabEditorMagHowtoGet.Text = "How to Get"
        Me.tabEditorMagHowtoGet.UseVisualStyleBackColor = True
        '
        'tabEditorMagInfo
        '
        Me.tabEditorMagInfo.Controls.Add(Me.rtfEditorMagInfo)
        Me.tabEditorMagInfo.Location = New System.Drawing.Point(4, 22)
        Me.tabEditorMagInfo.Name = "tabEditorMagInfo"
        Me.tabEditorMagInfo.Padding = New System.Windows.Forms.Padding(3)
        Me.tabEditorMagInfo.Size = New System.Drawing.Size(538, 359)
        Me.tabEditorMagInfo.TabIndex = 3
        Me.tabEditorMagInfo.Text = "Info"
        '
        'rtfEditorMagInfo
        '
        Me.rtfEditorMagInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.rtfEditorMagInfo.Location = New System.Drawing.Point(5, 5)
        Me.rtfEditorMagInfo.Name = "rtfEditorMagInfo"
        Me.rtfEditorMagInfo.ReadOnly = True
        Me.rtfEditorMagInfo.Size = New System.Drawing.Size(528, 349)
        Me.rtfEditorMagInfo.TabIndex = 105
        Me.rtfEditorMagInfo.Text = ""
        '
        'picEditorPhotonBlast
        '
        Me.picEditorPhotonBlast.BackColor = System.Drawing.Color.Transparent
        Me.picEditorPhotonBlast.Location = New System.Drawing.Point(161, 101)
        Me.picEditorPhotonBlast.Name = "picEditorPhotonBlast"
        Me.picEditorPhotonBlast.Size = New System.Drawing.Size(50, 43)
        Me.picEditorPhotonBlast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picEditorPhotonBlast.TabIndex = 4
        Me.picEditorPhotonBlast.TabStop = False
        '
        'cboEditorPBFilled
        '
        Me.cboEditorPBFilled.FormattingEnabled = True
        Me.cboEditorPBFilled.Location = New System.Drawing.Point(559, 43)
        Me.cboEditorPBFilled.Name = "cboEditorPBFilled"
        Me.cboEditorPBFilled.Size = New System.Drawing.Size(128, 21)
        Me.cboEditorPBFilled.TabIndex = 1
        '
        'cboEditor1HP10
        '
        Me.cboEditor1HP10.FormattingEnabled = True
        Me.cboEditor1HP10.Location = New System.Drawing.Point(559, 70)
        Me.cboEditor1HP10.Name = "cboEditor1HP10"
        Me.cboEditor1HP10.Size = New System.Drawing.Size(128, 21)
        Me.cboEditor1HP10.TabIndex = 2
        '
        'nudEditorStage
        '
        Me.nudEditorStage.BackColor = System.Drawing.SystemColors.Window
        Me.nudEditorStage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEditorStage.Location = New System.Drawing.Point(363, 44)
        Me.nudEditorStage.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.nudEditorStage.Minimum = New Decimal(New Integer() {100, 0, 0, -2147483648})
        Me.nudEditorStage.Name = "nudEditorStage"
        Me.nudEditorStage.Size = New System.Drawing.Size(51, 20)
        Me.nudEditorStage.TabIndex = 104
        Me.nudEditorStage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboEditorBoss
        '
        Me.cboEditorBoss.FormattingEnabled = True
        Me.cboEditorBoss.Location = New System.Drawing.Point(559, 97)
        Me.cboEditorBoss.Name = "cboEditorBoss"
        Me.cboEditorBoss.Size = New System.Drawing.Size(128, 21)
        Me.cboEditorBoss.TabIndex = 4
        '
        'lblStage
        '
        Me.lblStage.BackColor = System.Drawing.Color.IndianRed
        Me.lblStage.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblStage.ForeColor = System.Drawing.Color.White
        Me.lblStage.Location = New System.Drawing.Point(231, 44)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(183, 20)
        Me.lblStage.TabIndex = 103
        Me.lblStage.Text = "Stage :"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEditorDeath
        '
        Me.cboEditorDeath.FormattingEnabled = True
        Me.cboEditorDeath.Location = New System.Drawing.Point(559, 124)
        Me.cboEditorDeath.Name = "cboEditorDeath"
        Me.cboEditorDeath.Size = New System.Drawing.Size(128, 21)
        Me.cboEditorDeath.TabIndex = 3
        '
        'lblEditorPBFilled
        '
        Me.lblEditorPBFilled.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditorPBFilled.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditorPBFilled.ForeColor = System.Drawing.Color.White
        Me.lblEditorPBFilled.Location = New System.Drawing.Point(433, 43)
        Me.lblEditorPBFilled.Name = "lblEditorPBFilled"
        Me.lblEditorPBFilled.Size = New System.Drawing.Size(254, 21)
        Me.lblEditorPBFilled.TabIndex = 94
        Me.lblEditorPBFilled.Text = "PB Filled :"
        Me.lblEditorPBFilled.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudEditorActivation
        '
        Me.nudEditorActivation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudEditorActivation.Increment = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudEditorActivation.Location = New System.Drawing.Point(636, 17)
        Me.nudEditorActivation.Name = "nudEditorActivation"
        Me.nudEditorActivation.Size = New System.Drawing.Size(51, 20)
        Me.nudEditorActivation.TabIndex = 5
        Me.nudEditorActivation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEditor1HP10
        '
        Me.lblEditor1HP10.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditor1HP10.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditor1HP10.ForeColor = System.Drawing.Color.White
        Me.lblEditor1HP10.Location = New System.Drawing.Point(433, 70)
        Me.lblEditor1HP10.Name = "lblEditor1HP10"
        Me.lblEditor1HP10.Size = New System.Drawing.Size(254, 21)
        Me.lblEditor1HP10.TabIndex = 95
        Me.lblEditor1HP10.Text = "10% HP   :"
        Me.lblEditor1HP10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorActivation
        '
        Me.lblEditorActivation.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditorActivation.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorActivation.ForeColor = System.Drawing.Color.White
        Me.lblEditorActivation.Location = New System.Drawing.Point(433, 17)
        Me.lblEditorActivation.Name = "lblEditorActivation"
        Me.lblEditorActivation.Size = New System.Drawing.Size(254, 20)
        Me.lblEditorActivation.TabIndex = 98
        Me.lblEditorActivation.Text = "Activation"
        Me.lblEditorActivation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorBoss
        '
        Me.lblEditorBoss.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditorBoss.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorBoss.ForeColor = System.Drawing.Color.White
        Me.lblEditorBoss.Location = New System.Drawing.Point(433, 97)
        Me.lblEditorBoss.Name = "lblEditorBoss"
        Me.lblEditorBoss.Size = New System.Drawing.Size(254, 21)
        Me.lblEditorBoss.TabIndex = 96
        Me.lblEditorBoss.Text = "Boss     :"
        Me.lblEditorBoss.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorDeath
        '
        Me.lblEditorDeath.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditorDeath.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorDeath.ForeColor = System.Drawing.Color.White
        Me.lblEditorDeath.Location = New System.Drawing.Point(434, 124)
        Me.lblEditorDeath.Name = "lblEditorDeath"
        Me.lblEditorDeath.Size = New System.Drawing.Size(253, 21)
        Me.lblEditorDeath.TabIndex = 97
        Me.lblEditorDeath.Text = "Death    :"
        Me.lblEditorDeath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEditorMagName
        '
        Me.lblEditorMagName.BackColor = System.Drawing.Color.IndianRed
        Me.lblEditorMagName.Font = New System.Drawing.Font("Lucida Console", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lblEditorMagName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblEditorMagName.Location = New System.Drawing.Point(231, 17)
        Me.lblEditorMagName.Name = "lblEditorMagName"
        Me.lblEditorMagName.Size = New System.Drawing.Size(183, 20)
        Me.lblEditorMagName.TabIndex = 107
        Me.lblEditorMagName.Text = "Mag"
        Me.lblEditorMagName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabPhotonBlast
        '
        Me.tabPhotonBlast.Location = New System.Drawing.Point(4, 22)
        Me.tabPhotonBlast.Name = "tabPhotonBlast"
        Me.tabPhotonBlast.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPhotonBlast.Size = New System.Drawing.Size(706, 581)
        Me.tabPhotonBlast.TabIndex = 1
        Me.tabPhotonBlast.Text = "Photon Blast"
        Me.tabPhotonBlast.UseVisualStyleBackColor = True
        '
        'tabMagCells
        '
        Me.tabMagCells.Location = New System.Drawing.Point(4, 22)
        Me.tabMagCells.Name = "tabMagCells"
        Me.tabMagCells.Padding = New System.Windows.Forms.Padding(3)
        Me.tabMagCells.Size = New System.Drawing.Size(706, 581)
        Me.tabMagCells.TabIndex = 2
        Me.tabMagCells.Text = "Mag Cells"
        Me.tabMagCells.UseVisualStyleBackColor = True
        '
        'picEditorSave
        '
        Me.picEditorSave.BackColor = System.Drawing.Color.Transparent
        Me.picEditorSave.Location = New System.Drawing.Point(963, 3)
        Me.picEditorSave.Name = "picEditorSave"
        Me.picEditorSave.Size = New System.Drawing.Size(25, 21)
        Me.picEditorSave.TabIndex = 100
        Me.picEditorSave.TabStop = False
        '
        'frmEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 649)
        Me.Controls.Add(Me.tabEditor)
        Me.Controls.Add(Me.picEditorSave)
        Me.Controls.Add(Me.mnuEditor)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuEditor
        Me.MaximizeBox = False
        Me.Name = "frmEditor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mag Editor"
        Me.mnuEditor.ResumeLayout(False)
        Me.mnuEditor.PerformLayout()
        Me.tabEditor.ResumeLayout(False)
        Me.tabMag.ResumeLayout(False)
        Me.tabMag.PerformLayout()
        Me.flpEditorMagVer.ResumeLayout(False)
        Me.flpEditorMagVer.PerformLayout()
        CType(Me.picEditorMag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditorMag.ResumeLayout(False)
        Me.tabEditorMagFeedingTable.ResumeLayout(False)
        CType(Me.nudIQMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEditorFeedingTables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSyncStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudIQStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEFStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMINDMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOWStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEXTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEditorMagInfo.ResumeLayout(False)
        CType(Me.picEditorPhotonBlast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEditorStage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudEditorActivation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picEditorSave, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picEditorMag As PictureBox
    Friend WithEvents cboEditorPhotonBlast As ComboBox
    Friend WithEvents picEditorPhotonBlast As PictureBox
    Friend WithEvents nudSyncMonomate As NumericUpDown
    Friend WithEvents nudSyncDimate As NumericUpDown
    Friend WithEvents nudSyncMonofluid As NumericUpDown
    Friend WithEvents nudSyncTrimate As NumericUpDown
    Friend WithEvents nudSyncAntiparalysis As NumericUpDown
    Friend WithEvents nudSyncAntidote As NumericUpDown
    Friend WithEvents nudSyncTrifluid As NumericUpDown
    Friend WithEvents nudSyncDifluid As NumericUpDown
    Friend WithEvents nudSyncStarAtomizer As NumericUpDown
    Friend WithEvents nudSyncMoonAtomizer As NumericUpDown
    Friend WithEvents nudSyncSolAtomizer As NumericUpDown
    Friend WithEvents nudIQStarAtomizer As NumericUpDown
    Friend WithEvents nudIQMoonAtomizer As NumericUpDown
    Friend WithEvents nudIQSolAtomizer As NumericUpDown
    Friend WithEvents nudIQAntiparalysis As NumericUpDown
    Friend WithEvents nudIQAntidote As NumericUpDown
    Friend WithEvents nudIQTrifluid As NumericUpDown
    Friend WithEvents nudIQDifluid As NumericUpDown
    Friend WithEvents nudIQMonofluid As NumericUpDown
    Friend WithEvents nudIQTrimate As NumericUpDown
    Friend WithEvents nudIQDimate As NumericUpDown
    Friend WithEvents nudIQMonomate As NumericUpDown
    Friend WithEvents lblEditorSynchro As Label
    Friend WithEvents lblEditorIQ As Label
    Friend WithEvents lblEditorPOW As Label
    Friend WithEvents lblEditorDEF As Label
    Friend WithEvents nudPOWStarAtomizer As NumericUpDown
    Friend WithEvents nudPOWMoonAtomizer As NumericUpDown
    Friend WithEvents nudPOWSolAtomizer As NumericUpDown
    Friend WithEvents nudPOWAntiparalysis As NumericUpDown
    Friend WithEvents nudPOWAntidote As NumericUpDown
    Friend WithEvents nudPOWTrifluid As NumericUpDown
    Friend WithEvents nudPOWDifluid As NumericUpDown
    Friend WithEvents nudPOWMonofluid As NumericUpDown
    Friend WithEvents nudPOWTrimate As NumericUpDown
    Friend WithEvents nudPOWDimate As NumericUpDown
    Friend WithEvents nudPOWMonomate As NumericUpDown
    Friend WithEvents nudDEFStarAtomizer As NumericUpDown
    Friend WithEvents nudDEFMoonAtomizer As NumericUpDown
    Friend WithEvents nudDEFSolAtomizer As NumericUpDown
    Friend WithEvents nudDEFAntiparalysis As NumericUpDown
    Friend WithEvents nudDEFAntidote As NumericUpDown
    Friend WithEvents nudDEFTrifluid As NumericUpDown
    Friend WithEvents nudDEFDifluid As NumericUpDown
    Friend WithEvents nudDEFMonofluid As NumericUpDown
    Friend WithEvents nudDEFTrimate As NumericUpDown
    Friend WithEvents nudDEFDimate As NumericUpDown
    Friend WithEvents nudDEFMonomate As NumericUpDown
    Friend WithEvents lblEditorMIND As Label
    Friend WithEvents lblEditorDEX As Label
    Friend WithEvents nudMINDStarAtomizer As NumericUpDown
    Friend WithEvents nudMINDMoonAtomizer As NumericUpDown
    Friend WithEvents nudMINDSolAtomizer As NumericUpDown
    Friend WithEvents nudMINDAntiparalysis As NumericUpDown
    Friend WithEvents nudMINDAntidote As NumericUpDown
    Friend WithEvents nudMINDTrifluid As NumericUpDown
    Friend WithEvents nudMINDDifluid As NumericUpDown
    Friend WithEvents nudMINDMonofluid As NumericUpDown
    Friend WithEvents nudMINDTrimate As NumericUpDown
    Friend WithEvents nudMINDDimate As NumericUpDown
    Friend WithEvents nudMINDMonomate As NumericUpDown
    Friend WithEvents nudDEXStarAtomizer As NumericUpDown
    Friend WithEvents nudDEXMoonAtomizer As NumericUpDown
    Friend WithEvents nudDEXSolAtomizer As NumericUpDown
    Friend WithEvents nudDEXAntiparalysis As NumericUpDown
    Friend WithEvents nudDEXAntidote As NumericUpDown
    Friend WithEvents nudDEXTrifluid As NumericUpDown
    Friend WithEvents nudDEXDifluid As NumericUpDown
    Friend WithEvents nudDEXMonofluid As NumericUpDown
    Friend WithEvents nudDEXTrimate As NumericUpDown
    Friend WithEvents nudDEXDimate As NumericUpDown
    Friend WithEvents nudDEXMonomate As NumericUpDown
    Friend WithEvents lblEditorMonomate As Label
    Friend WithEvents lblEditorDimate As Label
    Friend WithEvents lblEditorTrimate As Label
    Friend WithEvents lblEditorTrifluid As Label
    Friend WithEvents lblEditorDifluid As Label
    Friend WithEvents lblEditorMonofluid As Label
    Friend WithEvents lblEditorSolAtomizer As Label
    Friend WithEvents lblEditorAntiparalysis As Label
    Friend WithEvents lblEditorAntidote As Label
    Friend WithEvents lblEditorStarAtomizer As Label
    Friend WithEvents lblEditorMoonAtomizer As Label
    Friend WithEvents cboEditorPBFilled As ComboBox
    Friend WithEvents cboEditor1HP10 As ComboBox
    Friend WithEvents cboEditorBoss As ComboBox
    Friend WithEvents cboEditorDeath As ComboBox
    Friend WithEvents mnuEditor As MenuStrip
    Friend WithEvents mnuEditorFileSaveMag As ToolStripMenuItem
    Friend WithEvents mnuEditorFileExit As ToolStripMenuItem
    Friend WithEvents lblEditorDeath As Label
    Friend WithEvents lblEditorBoss As Label
    Friend WithEvents lblEditor1HP10 As Label
    Friend WithEvents lblEditorPBFilled As Label
    Friend WithEvents lblEditorActivation As Label
    Friend WithEvents nudEditorActivation As NumericUpDown
    Friend WithEvents picEditorSave As PictureBox
    Friend WithEvents ttEditor As ToolTip
    Friend WithEvents lblStage As Label
    Friend WithEvents nudEditorStage As NumericUpDown
    Friend WithEvents nudEditorFeedingTables As NumericUpDown
    Friend WithEvents mnuEditorFileSaveChart As ToolStripMenuItem
    Friend WithEvents rtfEditorMagInfo As RichTextBox
    Friend WithEvents lsbEditorMag As ListBox
    Friend WithEvents lblEditorMagName As Label
    Friend WithEvents tabEditorMag As TabControl
    Friend WithEvents tabEditorMagFeedingTable As TabPage
    Friend WithEvents lblFeedingTables As Label
    Friend WithEvents tabEditorMagInfo As TabPage
    Friend WithEvents tabEditorMagHowtoGet As TabPage
    Friend WithEvents tabEditor As TabControl
    Friend WithEvents tabMag As TabPage
    Friend WithEvents tabPhotonBlast As TabPage
    Friend WithEvents tabMagCells As TabPage
    Friend WithEvents txtEditorSearchMag As TextBox
    Friend WithEvents flpEditorMagVer As FlowLayoutPanel
    Friend WithEvents radEditorMagEp1 As RadioButton
    Friend WithEvents radEditorMagEp2 As RadioButton
    Friend WithEvents radEditorMagEp4 As RadioButton
    Friend WithEvents mnuEditorFileUpdate As ToolStripMenuItem
    Friend WithEvents cboFeedVer As ComboBox
End Class
