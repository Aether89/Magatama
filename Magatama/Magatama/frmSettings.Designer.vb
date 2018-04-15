<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.cboSettingsSectionID = New System.Windows.Forms.ComboBox()
        Me.cboSettingsClass = New System.Windows.Forms.ComboBox()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblSectionID = New System.Windows.Forms.Label()
        Me.lblSynchro = New System.Windows.Forms.Label()
        Me.nudSettingsSynchro = New System.Windows.Forms.NumericUpDown()
        Me.lblFeedingTime = New System.Windows.Forms.Label()
        Me.nudSettingsFeedingTime = New System.Windows.Forms.NumericUpDown()
        Me.btnSettingsCancel = New System.Windows.Forms.Button()
        Me.btnSettingsSave = New System.Windows.Forms.Button()
        Me.nudCostMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudCostDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudCostTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudCostMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudCostDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudCostTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudCostAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudCostAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudCostSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudCostMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudCostStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.lblCostMonomate = New System.Windows.Forms.Label()
        Me.lblCostDimate = New System.Windows.Forms.Label()
        Me.lblCostTrimate = New System.Windows.Forms.Label()
        Me.lblCostMonofluid = New System.Windows.Forms.Label()
        Me.lblCostAntiparalysis = New System.Windows.Forms.Label()
        Me.lblCostAntidote = New System.Windows.Forms.Label()
        Me.lblCostTrifluid = New System.Windows.Forms.Label()
        Me.lblCostDifluid = New System.Windows.Forms.Label()
        Me.lblCostStarAtomizer = New System.Windows.Forms.Label()
        Me.lblCostMoonAtomizer = New System.Windows.Forms.Label()
        Me.lblCostSolAtomizer = New System.Windows.Forms.Label()
        Me.lblSettingsCost = New System.Windows.Forms.Label()
        Me.lblSettingsItems = New System.Windows.Forms.Label()
        Me.lblSettingsSeconds = New System.Windows.Forms.Label()
        Me.chkRacialRestriction = New System.Windows.Forms.CheckBox()
        Me.flbGameVersion = New System.Windows.Forms.FlowLayoutPanel()
        Me.radVer1 = New System.Windows.Forms.RadioButton()
        Me.radEp2 = New System.Windows.Forms.RadioButton()
        Me.radBB = New System.Windows.Forms.RadioButton()
        Me.lblGameVersion = New System.Windows.Forms.Label()
        Me.nudSettingsIQ = New System.Windows.Forms.NumericUpDown()
        Me.lblIQ = New System.Windows.Forms.Label()
        Me.nudSettingsPOW = New System.Windows.Forms.NumericUpDown()
        Me.lblPOW = New System.Windows.Forms.Label()
        Me.nudSettingsDEF = New System.Windows.Forms.NumericUpDown()
        Me.lblDEF = New System.Windows.Forms.Label()
        Me.nudSettingsMIND = New System.Windows.Forms.NumericUpDown()
        Me.lblMIND = New System.Windows.Forms.Label()
        Me.nudSettingsDEX = New System.Windows.Forms.NumericUpDown()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblInitialStats = New System.Windows.Forms.Label()
        Me.nudMaxLevel = New System.Windows.Forms.NumericUpDown()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.pnlGeneral = New System.Windows.Forms.Panel()
        Me.pnlMag = New System.Windows.Forms.Panel()
        Me.pnlCost = New System.Windows.Forms.Panel()
        Me.btnGeneral = New System.Windows.Forms.Button()
        Me.btnMag = New System.Windows.Forms.Button()
        Me.btnCost = New System.Windows.Forms.Button()
        CType(Me.nudSettingsSynchro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSettingsFeedingTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCostStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flbGameVersion.SuspendLayout()
        CType(Me.nudSettingsIQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSettingsPOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSettingsDEF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSettingsMIND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSettingsDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMaxLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGeneral.SuspendLayout()
        Me.pnlMag.SuspendLayout()
        Me.pnlCost.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboSettingsSectionID
        '
        Me.cboSettingsSectionID.FormattingEnabled = True
        Me.cboSettingsSectionID.Location = New System.Drawing.Point(15, 142)
        Me.cboSettingsSectionID.MaxDropDownItems = 9
        Me.cboSettingsSectionID.Name = "cboSettingsSectionID"
        Me.cboSettingsSectionID.Size = New System.Drawing.Size(153, 21)
        Me.cboSettingsSectionID.TabIndex = 3
        '
        'cboSettingsClass
        '
        Me.cboSettingsClass.FormattingEnabled = True
        Me.cboSettingsClass.Location = New System.Drawing.Point(14, 91)
        Me.cboSettingsClass.MaxDropDownItems = 12
        Me.cboSettingsClass.Name = "cboSettingsClass"
        Me.cboSettingsClass.Size = New System.Drawing.Size(153, 21)
        Me.cboSettingsClass.TabIndex = 2
        '
        'lblClass
        '
        Me.lblClass.BackColor = System.Drawing.Color.Transparent
        Me.lblClass.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblClass.Location = New System.Drawing.Point(14, 63)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(153, 21)
        Me.lblClass.TabIndex = 4
        Me.lblClass.Text = "Initial Class"
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSectionID
        '
        Me.lblSectionID.BackColor = System.Drawing.Color.Transparent
        Me.lblSectionID.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSectionID.Location = New System.Drawing.Point(15, 115)
        Me.lblSectionID.Name = "lblSectionID"
        Me.lblSectionID.Size = New System.Drawing.Size(153, 21)
        Me.lblSectionID.TabIndex = 5
        Me.lblSectionID.Text = "Initial Section ID"
        Me.lblSectionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSynchro
        '
        Me.lblSynchro.BackColor = System.Drawing.Color.Transparent
        Me.lblSynchro.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSynchro.Location = New System.Drawing.Point(10, 69)
        Me.lblSynchro.Name = "lblSynchro"
        Me.lblSynchro.Size = New System.Drawing.Size(65, 21)
        Me.lblSynchro.TabIndex = 6
        Me.lblSynchro.Text = "Synchro"
        Me.lblSynchro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsSynchro
        '
        Me.nudSettingsSynchro.Location = New System.Drawing.Point(105, 69)
        Me.nudSettingsSynchro.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudSettingsSynchro.Name = "nudSettingsSynchro"
        Me.nudSettingsSynchro.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsSynchro.TabIndex = 7
        Me.nudSettingsSynchro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsSynchro.ThousandsSeparator = True
        Me.nudSettingsSynchro.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'lblFeedingTime
        '
        Me.lblFeedingTime.BackColor = System.Drawing.Color.Transparent
        Me.lblFeedingTime.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFeedingTime.Location = New System.Drawing.Point(15, 167)
        Me.lblFeedingTime.Name = "lblFeedingTime"
        Me.lblFeedingTime.Size = New System.Drawing.Size(180, 20)
        Me.lblFeedingTime.TabIndex = 8
        Me.lblFeedingTime.Text = "Time Between Feeding"
        Me.lblFeedingTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsFeedingTime
        '
        Me.nudSettingsFeedingTime.Location = New System.Drawing.Point(15, 193)
        Me.nudSettingsFeedingTime.Maximum = New Decimal(New Integer() {86400, 0, 0, 0})
        Me.nudSettingsFeedingTime.Name = "nudSettingsFeedingTime"
        Me.nudSettingsFeedingTime.Size = New System.Drawing.Size(57, 20)
        Me.nudSettingsFeedingTime.TabIndex = 9
        Me.nudSettingsFeedingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSettingsCancel
        '
        Me.btnSettingsCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSettingsCancel.Location = New System.Drawing.Point(12, 287)
        Me.btnSettingsCancel.Name = "btnSettingsCancel"
        Me.btnSettingsCancel.Size = New System.Drawing.Size(116, 46)
        Me.btnSettingsCancel.TabIndex = 10
        Me.btnSettingsCancel.Text = "Cancel"
        Me.btnSettingsCancel.UseVisualStyleBackColor = True
        '
        'btnSettingsSave
        '
        Me.btnSettingsSave.Location = New System.Drawing.Point(12, 237)
        Me.btnSettingsSave.Name = "btnSettingsSave"
        Me.btnSettingsSave.Size = New System.Drawing.Size(116, 46)
        Me.btnSettingsSave.TabIndex = 11
        Me.btnSettingsSave.Text = "Save"
        Me.btnSettingsSave.UseVisualStyleBackColor = True
        '
        'nudCostMonomate
        '
        Me.nudCostMonomate.Location = New System.Drawing.Point(322, 31)
        Me.nudCostMonomate.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostMonomate.Name = "nudCostMonomate"
        Me.nudCostMonomate.Size = New System.Drawing.Size(63, 20)
        Me.nudCostMonomate.TabIndex = 12
        Me.nudCostMonomate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostMonomate.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostDimate
        '
        Me.nudCostDimate.Location = New System.Drawing.Point(322, 57)
        Me.nudCostDimate.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostDimate.Name = "nudCostDimate"
        Me.nudCostDimate.Size = New System.Drawing.Size(63, 20)
        Me.nudCostDimate.TabIndex = 13
        Me.nudCostDimate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostDimate.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostTrimate
        '
        Me.nudCostTrimate.Location = New System.Drawing.Point(322, 83)
        Me.nudCostTrimate.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostTrimate.Name = "nudCostTrimate"
        Me.nudCostTrimate.Size = New System.Drawing.Size(63, 20)
        Me.nudCostTrimate.TabIndex = 14
        Me.nudCostTrimate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostTrimate.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostMonofluid
        '
        Me.nudCostMonofluid.Location = New System.Drawing.Point(322, 109)
        Me.nudCostMonofluid.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostMonofluid.Name = "nudCostMonofluid"
        Me.nudCostMonofluid.Size = New System.Drawing.Size(63, 20)
        Me.nudCostMonofluid.TabIndex = 15
        Me.nudCostMonofluid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostMonofluid.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostDifluid
        '
        Me.nudCostDifluid.Location = New System.Drawing.Point(322, 135)
        Me.nudCostDifluid.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostDifluid.Name = "nudCostDifluid"
        Me.nudCostDifluid.Size = New System.Drawing.Size(63, 20)
        Me.nudCostDifluid.TabIndex = 16
        Me.nudCostDifluid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostDifluid.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostTrifluid
        '
        Me.nudCostTrifluid.Location = New System.Drawing.Point(322, 161)
        Me.nudCostTrifluid.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostTrifluid.Name = "nudCostTrifluid"
        Me.nudCostTrifluid.Size = New System.Drawing.Size(63, 20)
        Me.nudCostTrifluid.TabIndex = 17
        Me.nudCostTrifluid.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostTrifluid.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostAntidote
        '
        Me.nudCostAntidote.Location = New System.Drawing.Point(322, 187)
        Me.nudCostAntidote.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostAntidote.Name = "nudCostAntidote"
        Me.nudCostAntidote.Size = New System.Drawing.Size(63, 20)
        Me.nudCostAntidote.TabIndex = 18
        Me.nudCostAntidote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostAntidote.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostAntiparalysis
        '
        Me.nudCostAntiparalysis.Location = New System.Drawing.Point(322, 213)
        Me.nudCostAntiparalysis.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostAntiparalysis.Name = "nudCostAntiparalysis"
        Me.nudCostAntiparalysis.Size = New System.Drawing.Size(63, 20)
        Me.nudCostAntiparalysis.TabIndex = 19
        Me.nudCostAntiparalysis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostAntiparalysis.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostSolAtomizer
        '
        Me.nudCostSolAtomizer.Location = New System.Drawing.Point(322, 239)
        Me.nudCostSolAtomizer.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostSolAtomizer.Name = "nudCostSolAtomizer"
        Me.nudCostSolAtomizer.Size = New System.Drawing.Size(63, 20)
        Me.nudCostSolAtomizer.TabIndex = 20
        Me.nudCostSolAtomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostSolAtomizer.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostMoonAtomizer
        '
        Me.nudCostMoonAtomizer.Location = New System.Drawing.Point(322, 265)
        Me.nudCostMoonAtomizer.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostMoonAtomizer.Name = "nudCostMoonAtomizer"
        Me.nudCostMoonAtomizer.Size = New System.Drawing.Size(63, 20)
        Me.nudCostMoonAtomizer.TabIndex = 21
        Me.nudCostMoonAtomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostMoonAtomizer.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'nudCostStarAtomizer
        '
        Me.nudCostStarAtomizer.Location = New System.Drawing.Point(322, 291)
        Me.nudCostStarAtomizer.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.nudCostStarAtomizer.Name = "nudCostStarAtomizer"
        Me.nudCostStarAtomizer.Size = New System.Drawing.Size(63, 20)
        Me.nudCostStarAtomizer.TabIndex = 22
        Me.nudCostStarAtomizer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudCostStarAtomizer.Value = New Decimal(New Integer() {999999, 0, 0, 0})
        '
        'lblCostMonomate
        '
        Me.lblCostMonomate.BackColor = System.Drawing.Color.Transparent
        Me.lblCostMonomate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostMonomate.Location = New System.Drawing.Point(197, 31)
        Me.lblCostMonomate.Name = "lblCostMonomate"
        Me.lblCostMonomate.Size = New System.Drawing.Size(119, 20)
        Me.lblCostMonomate.TabIndex = 24
        Me.lblCostMonomate.Text = "Monomate"
        Me.lblCostMonomate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostDimate
        '
        Me.lblCostDimate.BackColor = System.Drawing.Color.Transparent
        Me.lblCostDimate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostDimate.Location = New System.Drawing.Point(197, 57)
        Me.lblCostDimate.Name = "lblCostDimate"
        Me.lblCostDimate.Size = New System.Drawing.Size(119, 20)
        Me.lblCostDimate.TabIndex = 25
        Me.lblCostDimate.Text = "Dimate"
        Me.lblCostDimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostTrimate
        '
        Me.lblCostTrimate.BackColor = System.Drawing.Color.Transparent
        Me.lblCostTrimate.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostTrimate.Location = New System.Drawing.Point(197, 83)
        Me.lblCostTrimate.Name = "lblCostTrimate"
        Me.lblCostTrimate.Size = New System.Drawing.Size(119, 20)
        Me.lblCostTrimate.TabIndex = 26
        Me.lblCostTrimate.Text = "Trimate"
        Me.lblCostTrimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostMonofluid
        '
        Me.lblCostMonofluid.BackColor = System.Drawing.Color.Transparent
        Me.lblCostMonofluid.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostMonofluid.Location = New System.Drawing.Point(197, 109)
        Me.lblCostMonofluid.Name = "lblCostMonofluid"
        Me.lblCostMonofluid.Size = New System.Drawing.Size(119, 20)
        Me.lblCostMonofluid.TabIndex = 27
        Me.lblCostMonofluid.Text = "Monofluid"
        Me.lblCostMonofluid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostAntiparalysis
        '
        Me.lblCostAntiparalysis.BackColor = System.Drawing.Color.Transparent
        Me.lblCostAntiparalysis.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostAntiparalysis.Location = New System.Drawing.Point(197, 213)
        Me.lblCostAntiparalysis.Name = "lblCostAntiparalysis"
        Me.lblCostAntiparalysis.Size = New System.Drawing.Size(119, 20)
        Me.lblCostAntiparalysis.TabIndex = 31
        Me.lblCostAntiparalysis.Text = "Antiparalysis"
        Me.lblCostAntiparalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostAntidote
        '
        Me.lblCostAntidote.BackColor = System.Drawing.Color.Transparent
        Me.lblCostAntidote.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostAntidote.Location = New System.Drawing.Point(197, 187)
        Me.lblCostAntidote.Name = "lblCostAntidote"
        Me.lblCostAntidote.Size = New System.Drawing.Size(119, 20)
        Me.lblCostAntidote.TabIndex = 30
        Me.lblCostAntidote.Text = "Antidote"
        Me.lblCostAntidote.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostTrifluid
        '
        Me.lblCostTrifluid.BackColor = System.Drawing.Color.Transparent
        Me.lblCostTrifluid.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostTrifluid.Location = New System.Drawing.Point(197, 161)
        Me.lblCostTrifluid.Name = "lblCostTrifluid"
        Me.lblCostTrifluid.Size = New System.Drawing.Size(119, 20)
        Me.lblCostTrifluid.TabIndex = 29
        Me.lblCostTrifluid.Text = "Trifluid"
        Me.lblCostTrifluid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostDifluid
        '
        Me.lblCostDifluid.BackColor = System.Drawing.Color.Transparent
        Me.lblCostDifluid.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostDifluid.Location = New System.Drawing.Point(197, 135)
        Me.lblCostDifluid.Name = "lblCostDifluid"
        Me.lblCostDifluid.Size = New System.Drawing.Size(119, 20)
        Me.lblCostDifluid.TabIndex = 28
        Me.lblCostDifluid.Text = "Difluid"
        Me.lblCostDifluid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostStarAtomizer
        '
        Me.lblCostStarAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblCostStarAtomizer.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostStarAtomizer.Location = New System.Drawing.Point(197, 291)
        Me.lblCostStarAtomizer.Name = "lblCostStarAtomizer"
        Me.lblCostStarAtomizer.Size = New System.Drawing.Size(119, 20)
        Me.lblCostStarAtomizer.TabIndex = 34
        Me.lblCostStarAtomizer.Text = "Star Atomizer"
        Me.lblCostStarAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostMoonAtomizer
        '
        Me.lblCostMoonAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblCostMoonAtomizer.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostMoonAtomizer.Location = New System.Drawing.Point(197, 265)
        Me.lblCostMoonAtomizer.Name = "lblCostMoonAtomizer"
        Me.lblCostMoonAtomizer.Size = New System.Drawing.Size(119, 20)
        Me.lblCostMoonAtomizer.TabIndex = 33
        Me.lblCostMoonAtomizer.Text = "Moon Atomizer"
        Me.lblCostMoonAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCostSolAtomizer
        '
        Me.lblCostSolAtomizer.BackColor = System.Drawing.Color.Transparent
        Me.lblCostSolAtomizer.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblCostSolAtomizer.Location = New System.Drawing.Point(197, 239)
        Me.lblCostSolAtomizer.Name = "lblCostSolAtomizer"
        Me.lblCostSolAtomizer.Size = New System.Drawing.Size(119, 20)
        Me.lblCostSolAtomizer.TabIndex = 32
        Me.lblCostSolAtomizer.Text = "Sol Atomizer"
        Me.lblCostSolAtomizer.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSettingsCost
        '
        Me.lblSettingsCost.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsCost.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsCost.Location = New System.Drawing.Point(322, 10)
        Me.lblSettingsCost.Name = "lblSettingsCost"
        Me.lblSettingsCost.Size = New System.Drawing.Size(63, 20)
        Me.lblSettingsCost.TabIndex = 35
        Me.lblSettingsCost.Text = "Cost"
        Me.lblSettingsCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSettingsItems
        '
        Me.lblSettingsItems.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsItems.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsItems.Location = New System.Drawing.Point(199, 9)
        Me.lblSettingsItems.Name = "lblSettingsItems"
        Me.lblSettingsItems.Size = New System.Drawing.Size(117, 20)
        Me.lblSettingsItems.TabIndex = 36
        Me.lblSettingsItems.Text = "Items"
        Me.lblSettingsItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSettingsSeconds
        '
        Me.lblSettingsSeconds.BackColor = System.Drawing.Color.Transparent
        Me.lblSettingsSeconds.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettingsSeconds.Location = New System.Drawing.Point(74, 193)
        Me.lblSettingsSeconds.Name = "lblSettingsSeconds"
        Me.lblSettingsSeconds.Size = New System.Drawing.Size(66, 20)
        Me.lblSettingsSeconds.TabIndex = 37
        Me.lblSettingsSeconds.Text = "Seconds"
        Me.lblSettingsSeconds.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'chkRacialRestriction
        '
        Me.chkRacialRestriction.AutoSize = True
        Me.chkRacialRestriction.BackColor = System.Drawing.Color.Transparent
        Me.chkRacialRestriction.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chkRacialRestriction.Location = New System.Drawing.Point(5, 293)
        Me.chkRacialRestriction.Name = "chkRacialRestriction"
        Me.chkRacialRestriction.Size = New System.Drawing.Size(216, 15)
        Me.chkRacialRestriction.TabIndex = 38
        Me.chkRacialRestriction.Text = "Mag Racials Restrictions"
        Me.chkRacialRestriction.UseVisualStyleBackColor = False
        '
        'flbGameVersion
        '
        Me.flbGameVersion.BackColor = System.Drawing.Color.Transparent
        Me.flbGameVersion.Controls.Add(Me.radVer1)
        Me.flbGameVersion.Controls.Add(Me.radEp2)
        Me.flbGameVersion.Controls.Add(Me.radBB)
        Me.flbGameVersion.Location = New System.Drawing.Point(13, 36)
        Me.flbGameVersion.Name = "flbGameVersion"
        Me.flbGameVersion.Size = New System.Drawing.Size(269, 19)
        Me.flbGameVersion.TabIndex = 39
        '
        'radVer1
        '
        Me.radVer1.AutoSize = True
        Me.radVer1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.radVer1.Location = New System.Drawing.Point(3, 3)
        Me.radVer1.Name = "radVer1"
        Me.radVer1.Size = New System.Drawing.Size(47, 15)
        Me.radVer1.TabIndex = 0
        Me.radVer1.TabStop = True
        Me.radVer1.Text = "Ep1"
        Me.radVer1.UseVisualStyleBackColor = True
        '
        'radEp2
        '
        Me.radEp2.AutoSize = True
        Me.radEp2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.radEp2.Location = New System.Drawing.Point(56, 3)
        Me.radEp2.Name = "radEp2"
        Me.radEp2.Size = New System.Drawing.Size(55, 15)
        Me.radEp2.TabIndex = 1
        Me.radEp2.TabStop = True
        Me.radEp2.Text = "Ep 2"
        Me.radEp2.UseVisualStyleBackColor = True
        '
        'radBB
        '
        Me.radBB.AutoSize = True
        Me.radBB.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.radBB.Location = New System.Drawing.Point(117, 3)
        Me.radBB.Name = "radBB"
        Me.radBB.Size = New System.Drawing.Size(47, 15)
        Me.radBB.TabIndex = 2
        Me.radBB.TabStop = True
        Me.radBB.Text = "Ep4"
        Me.radBB.UseVisualStyleBackColor = True
        '
        'lblGameVersion
        '
        Me.lblGameVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblGameVersion.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblGameVersion.Location = New System.Drawing.Point(15, 15)
        Me.lblGameVersion.Name = "lblGameVersion"
        Me.lblGameVersion.Size = New System.Drawing.Size(176, 21)
        Me.lblGameVersion.TabIndex = 40
        Me.lblGameVersion.Text = "Game Version"
        Me.lblGameVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsIQ
        '
        Me.nudSettingsIQ.Location = New System.Drawing.Point(105, 96)
        Me.nudSettingsIQ.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudSettingsIQ.Name = "nudSettingsIQ"
        Me.nudSettingsIQ.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsIQ.TabIndex = 42
        Me.nudSettingsIQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsIQ.ThousandsSeparator = True
        '
        'lblIQ
        '
        Me.lblIQ.BackColor = System.Drawing.Color.Transparent
        Me.lblIQ.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIQ.Location = New System.Drawing.Point(10, 96)
        Me.lblIQ.Name = "lblIQ"
        Me.lblIQ.Size = New System.Drawing.Size(65, 21)
        Me.lblIQ.TabIndex = 41
        Me.lblIQ.Text = "IQ"
        Me.lblIQ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsPOW
        '
        Me.nudSettingsPOW.Location = New System.Drawing.Point(105, 147)
        Me.nudSettingsPOW.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudSettingsPOW.Name = "nudSettingsPOW"
        Me.nudSettingsPOW.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsPOW.TabIndex = 46
        Me.nudSettingsPOW.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsPOW.ThousandsSeparator = True
        '
        'lblPOW
        '
        Me.lblPOW.BackColor = System.Drawing.Color.Transparent
        Me.lblPOW.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPOW.Location = New System.Drawing.Point(10, 149)
        Me.lblPOW.Name = "lblPOW"
        Me.lblPOW.Size = New System.Drawing.Size(65, 21)
        Me.lblPOW.TabIndex = 45
        Me.lblPOW.Text = "POW"
        Me.lblPOW.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsDEF
        '
        Me.nudSettingsDEF.Location = New System.Drawing.Point(105, 121)
        Me.nudSettingsDEF.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudSettingsDEF.Name = "nudSettingsDEF"
        Me.nudSettingsDEF.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsDEF.TabIndex = 44
        Me.nudSettingsDEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsDEF.ThousandsSeparator = True
        Me.nudSettingsDEF.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'lblDEF
        '
        Me.lblDEF.BackColor = System.Drawing.Color.Transparent
        Me.lblDEF.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEF.Location = New System.Drawing.Point(10, 123)
        Me.lblDEF.Name = "lblDEF"
        Me.lblDEF.Size = New System.Drawing.Size(65, 21)
        Me.lblDEF.TabIndex = 43
        Me.lblDEF.Text = "DEF"
        Me.lblDEF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsMIND
        '
        Me.nudSettingsMIND.Location = New System.Drawing.Point(105, 199)
        Me.nudSettingsMIND.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudSettingsMIND.Name = "nudSettingsMIND"
        Me.nudSettingsMIND.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsMIND.TabIndex = 50
        Me.nudSettingsMIND.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsMIND.ThousandsSeparator = True
        '
        'lblMIND
        '
        Me.lblMIND.BackColor = System.Drawing.Color.Transparent
        Me.lblMIND.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMIND.Location = New System.Drawing.Point(10, 199)
        Me.lblMIND.Name = "lblMIND"
        Me.lblMIND.Size = New System.Drawing.Size(65, 21)
        Me.lblMIND.TabIndex = 49
        Me.lblMIND.Text = "MIND"
        Me.lblMIND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'nudSettingsDEX
        '
        Me.nudSettingsDEX.Location = New System.Drawing.Point(105, 173)
        Me.nudSettingsDEX.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudSettingsDEX.Name = "nudSettingsDEX"
        Me.nudSettingsDEX.Size = New System.Drawing.Size(45, 20)
        Me.nudSettingsDEX.TabIndex = 48
        Me.nudSettingsDEX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudSettingsDEX.ThousandsSeparator = True
        '
        'lblDEX
        '
        Me.lblDEX.BackColor = System.Drawing.Color.Transparent
        Me.lblDEX.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDEX.Location = New System.Drawing.Point(10, 175)
        Me.lblDEX.Name = "lblDEX"
        Me.lblDEX.Size = New System.Drawing.Size(65, 21)
        Me.lblDEX.TabIndex = 47
        Me.lblDEX.Text = "DEX"
        Me.lblDEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInitialStats
        '
        Me.lblInitialStats.BackColor = System.Drawing.Color.Transparent
        Me.lblInitialStats.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInitialStats.Location = New System.Drawing.Point(10, 9)
        Me.lblInitialStats.Name = "lblInitialStats"
        Me.lblInitialStats.Size = New System.Drawing.Size(140, 21)
        Me.lblInitialStats.TabIndex = 51
        Me.lblInitialStats.Text = "Initial Stats"
        Me.lblInitialStats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'nudMaxLevel
        '
        Me.nudMaxLevel.Location = New System.Drawing.Point(105, 39)
        Me.nudMaxLevel.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMaxLevel.Name = "nudMaxLevel"
        Me.nudMaxLevel.Size = New System.Drawing.Size(45, 20)
        Me.nudMaxLevel.TabIndex = 53
        Me.nudMaxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudMaxLevel.ThousandsSeparator = True
        Me.nudMaxLevel.Value = New Decimal(New Integer() {200, 0, 0, 0})
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        Me.lblLevel.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLevel.Location = New System.Drawing.Point(10, 39)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(89, 21)
        Me.lblLevel.TabIndex = 52
        Me.lblLevel.Text = "Max Level"
        Me.lblLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnlGeneral
        '
        Me.pnlGeneral.BackColor = System.Drawing.Color.Transparent
        Me.pnlGeneral.Controls.Add(Me.lblGameVersion)
        Me.pnlGeneral.Controls.Add(Me.cboSettingsClass)
        Me.pnlGeneral.Controls.Add(Me.nudSettingsFeedingTime)
        Me.pnlGeneral.Controls.Add(Me.flbGameVersion)
        Me.pnlGeneral.Controls.Add(Me.lblFeedingTime)
        Me.pnlGeneral.Controls.Add(Me.cboSettingsSectionID)
        Me.pnlGeneral.Controls.Add(Me.lblSectionID)
        Me.pnlGeneral.Controls.Add(Me.lblSettingsSeconds)
        Me.pnlGeneral.Controls.Add(Me.lblClass)
        Me.pnlGeneral.Location = New System.Drawing.Point(134, 12)
        Me.pnlGeneral.Name = "pnlGeneral"
        Me.pnlGeneral.Size = New System.Drawing.Size(400, 320)
        Me.pnlGeneral.TabIndex = 41
        '
        'pnlMag
        '
        Me.pnlMag.BackColor = System.Drawing.Color.Transparent
        Me.pnlMag.Controls.Add(Me.lblInitialStats)
        Me.pnlMag.Controls.Add(Me.nudMaxLevel)
        Me.pnlMag.Controls.Add(Me.nudSettingsPOW)
        Me.pnlMag.Controls.Add(Me.lblSynchro)
        Me.pnlMag.Controls.Add(Me.lblPOW)
        Me.pnlMag.Controls.Add(Me.chkRacialRestriction)
        Me.pnlMag.Controls.Add(Me.lblDEX)
        Me.pnlMag.Controls.Add(Me.lblLevel)
        Me.pnlMag.Controls.Add(Me.nudSettingsDEF)
        Me.pnlMag.Controls.Add(Me.nudSettingsSynchro)
        Me.pnlMag.Controls.Add(Me.nudSettingsDEX)
        Me.pnlMag.Controls.Add(Me.lblIQ)
        Me.pnlMag.Controls.Add(Me.lblDEF)
        Me.pnlMag.Controls.Add(Me.nudSettingsMIND)
        Me.pnlMag.Controls.Add(Me.lblMIND)
        Me.pnlMag.Controls.Add(Me.nudSettingsIQ)
        Me.pnlMag.Location = New System.Drawing.Point(134, 12)
        Me.pnlMag.Name = "pnlMag"
        Me.pnlMag.Size = New System.Drawing.Size(400, 320)
        Me.pnlMag.TabIndex = 55
        '
        'pnlCost
        '
        Me.pnlCost.BackColor = System.Drawing.Color.Transparent
        Me.pnlCost.Controls.Add(Me.lblSettingsCost)
        Me.pnlCost.Controls.Add(Me.nudCostStarAtomizer)
        Me.pnlCost.Controls.Add(Me.nudCostMonomate)
        Me.pnlCost.Controls.Add(Me.lblCostTrimate)
        Me.pnlCost.Controls.Add(Me.nudCostDimate)
        Me.pnlCost.Controls.Add(Me.lblCostMonofluid)
        Me.pnlCost.Controls.Add(Me.nudCostTrimate)
        Me.pnlCost.Controls.Add(Me.lblCostDimate)
        Me.pnlCost.Controls.Add(Me.nudCostMonofluid)
        Me.pnlCost.Controls.Add(Me.lblCostDifluid)
        Me.pnlCost.Controls.Add(Me.lblSettingsItems)
        Me.pnlCost.Controls.Add(Me.lblCostMonomate)
        Me.pnlCost.Controls.Add(Me.nudCostDifluid)
        Me.pnlCost.Controls.Add(Me.lblCostTrifluid)
        Me.pnlCost.Controls.Add(Me.nudCostTrifluid)
        Me.pnlCost.Controls.Add(Me.lblCostAntidote)
        Me.pnlCost.Controls.Add(Me.lblCostStarAtomizer)
        Me.pnlCost.Controls.Add(Me.nudCostMoonAtomizer)
        Me.pnlCost.Controls.Add(Me.nudCostAntidote)
        Me.pnlCost.Controls.Add(Me.lblCostAntiparalysis)
        Me.pnlCost.Controls.Add(Me.lblCostMoonAtomizer)
        Me.pnlCost.Controls.Add(Me.nudCostSolAtomizer)
        Me.pnlCost.Controls.Add(Me.nudCostAntiparalysis)
        Me.pnlCost.Controls.Add(Me.lblCostSolAtomizer)
        Me.pnlCost.Location = New System.Drawing.Point(134, 12)
        Me.pnlCost.Name = "pnlCost"
        Me.pnlCost.Size = New System.Drawing.Size(400, 320)
        Me.pnlCost.TabIndex = 56
        '
        'btnGeneral
        '
        Me.btnGeneral.BackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGeneral.FlatAppearance.BorderSize = 0
        Me.btnGeneral.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeneral.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGeneral.Location = New System.Drawing.Point(12, 12)
        Me.btnGeneral.Name = "btnGeneral"
        Me.btnGeneral.Size = New System.Drawing.Size(122, 52)
        Me.btnGeneral.TabIndex = 57
        Me.btnGeneral.Text = "General"
        Me.btnGeneral.UseVisualStyleBackColor = False
        '
        'btnMag
        '
        Me.btnMag.BackColor = System.Drawing.Color.Transparent
        Me.btnMag.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnMag.FlatAppearance.BorderSize = 0
        Me.btnMag.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnMag.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnMag.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMag.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMag.Location = New System.Drawing.Point(12, 64)
        Me.btnMag.Name = "btnMag"
        Me.btnMag.Size = New System.Drawing.Size(122, 52)
        Me.btnMag.TabIndex = 58
        Me.btnMag.Text = "Mag"
        Me.btnMag.UseVisualStyleBackColor = False
        '
        'btnCost
        '
        Me.btnCost.BackColor = System.Drawing.Color.Transparent
        Me.btnCost.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCost.FlatAppearance.BorderSize = 0
        Me.btnCost.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCost.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCost.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCost.Location = New System.Drawing.Point(12, 112)
        Me.btnCost.Name = "btnCost"
        Me.btnCost.Size = New System.Drawing.Size(122, 52)
        Me.btnCost.TabIndex = 58
        Me.btnCost.Text = "Cost"
        Me.btnCost.UseVisualStyleBackColor = False
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSettingsCancel
        Me.ClientSize = New System.Drawing.Size(546, 344)
        Me.Controls.Add(Me.btnCost)
        Me.Controls.Add(Me.btnMag)
        Me.Controls.Add(Me.btnGeneral)
        Me.Controls.Add(Me.btnSettingsSave)
        Me.Controls.Add(Me.btnSettingsCancel)
        Me.Controls.Add(Me.pnlMag)
        Me.Controls.Add(Me.pnlGeneral)
        Me.Controls.Add(Me.pnlCost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmSettings"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.nudSettingsSynchro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSettingsFeedingTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCostStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flbGameVersion.ResumeLayout(False)
        Me.flbGameVersion.PerformLayout()
        CType(Me.nudSettingsIQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSettingsPOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSettingsDEF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSettingsMIND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSettingsDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMaxLevel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGeneral.ResumeLayout(False)
        Me.pnlMag.ResumeLayout(False)
        Me.pnlMag.PerformLayout()
        Me.pnlCost.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cboSettingsSectionID As ComboBox
    Friend WithEvents cboSettingsClass As ComboBox
    Friend WithEvents lblClass As Label
    Friend WithEvents lblSectionID As Label
    Friend WithEvents lblSynchro As Label
    Friend WithEvents nudSettingsSynchro As NumericUpDown
    Friend WithEvents lblFeedingTime As Label
    Friend WithEvents nudSettingsFeedingTime As NumericUpDown
    Friend WithEvents btnSettingsCancel As Button
    Friend WithEvents btnSettingsSave As Button
    Friend WithEvents nudCostMonomate As NumericUpDown
    Friend WithEvents nudCostDimate As NumericUpDown
    Friend WithEvents nudCostTrimate As NumericUpDown
    Friend WithEvents nudCostMonofluid As NumericUpDown
    Friend WithEvents nudCostDifluid As NumericUpDown
    Friend WithEvents nudCostTrifluid As NumericUpDown
    Friend WithEvents nudCostAntidote As NumericUpDown
    Friend WithEvents nudCostAntiparalysis As NumericUpDown
    Friend WithEvents nudCostSolAtomizer As NumericUpDown
    Friend WithEvents nudCostMoonAtomizer As NumericUpDown
    Friend WithEvents nudCostStarAtomizer As NumericUpDown
    Friend WithEvents lblCostMonomate As Label
    Friend WithEvents lblCostDimate As Label
    Friend WithEvents lblCostTrimate As Label
    Friend WithEvents lblCostMonofluid As Label
    Friend WithEvents lblCostAntiparalysis As Label
    Friend WithEvents lblCostAntidote As Label
    Friend WithEvents lblCostTrifluid As Label
    Friend WithEvents lblCostDifluid As Label
    Friend WithEvents lblCostStarAtomizer As Label
    Friend WithEvents lblCostMoonAtomizer As Label
    Friend WithEvents lblCostSolAtomizer As Label
    Friend WithEvents lblSettingsCost As Label
    Friend WithEvents lblSettingsItems As Label
    Friend WithEvents lblSettingsSeconds As Label
    Friend WithEvents chkRacialRestriction As CheckBox
    Friend WithEvents flbGameVersion As FlowLayoutPanel
    Friend WithEvents radVer1 As RadioButton
    Friend WithEvents radEp2 As RadioButton
    Friend WithEvents radBB As RadioButton
    Friend WithEvents lblGameVersion As Label
    Friend WithEvents nudSettingsIQ As NumericUpDown
    Friend WithEvents lblIQ As Label
    Friend WithEvents nudSettingsPOW As NumericUpDown
    Friend WithEvents lblPOW As Label
    Friend WithEvents nudSettingsDEF As NumericUpDown
    Friend WithEvents lblDEF As Label
    Friend WithEvents nudSettingsMIND As NumericUpDown
    Friend WithEvents lblMIND As Label
    Friend WithEvents nudSettingsDEX As NumericUpDown
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblInitialStats As Label
    Friend WithEvents nudMaxLevel As NumericUpDown
    Friend WithEvents lblLevel As Label
    Friend WithEvents pnlGeneral As Panel
    Friend WithEvents pnlMag As Panel
    Friend WithEvents pnlCost As Panel
    Friend WithEvents btnGeneral As Button
    Friend WithEvents btnMag As Button
    Friend WithEvents btnCost As Button
End Class
