<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMagatama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMagatama))
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.cmsMagatamaVoid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cboSectionID = New System.Windows.Forms.ComboBox()
        Me.cboPhotonBlast03 = New System.Windows.Forms.ComboBox()
        Me.cboPhotonBlast02 = New System.Windows.Forms.ComboBox()
        Me.cboPhotonBlast01 = New System.Windows.Forms.ComboBox()
        Me.cboMag = New System.Windows.Forms.ComboBox()
        Me.mnuMagatama = New System.Windows.Forms.MenuStrip()
        Me.mnuFileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileNewBlank = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExportOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditResetQty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditStat = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditInit = New System.Windows.Forms.ToolStripMenuItem()
        Me.nmuHelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.nmuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cboMagCell = New System.Windows.Forms.ComboBox()
        Me.prgDEF = New System.Windows.Forms.ProgressBar()
        Me.prgPOW = New System.Windows.Forms.ProgressBar()
        Me.prgDEX = New System.Windows.Forms.ProgressBar()
        Me.prgMind = New System.Windows.Forms.ProgressBar()
        Me.nudDEF = New System.Windows.Forms.NumericUpDown()
        Me.cmsMagatamaNud = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsPlus = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsPlus1000 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMinus1000 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsNUDto3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsNUDtoMax = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsNUDtoHalf = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsNUDtoZero = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudIQ = New System.Windows.Forms.NumericUpDown()
        Me.nudLevel = New System.Windows.Forms.NumericUpDown()
        Me.nudSynchro = New System.Windows.Forms.NumericUpDown()
        Me.nudPOW = New System.Windows.Forms.NumericUpDown()
        Me.nudDEX = New System.Windows.Forms.NumericUpDown()
        Me.nudMIND = New System.Windows.Forms.NumericUpDown()
        Me.rtfOutput = New System.Windows.Forms.RichTextBox()
        Me.cmsMagatamaMain = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsExportOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_separator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsUndo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsRedo = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_separator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsNewMag = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsBlankMag = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_separator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudProgressDEF = New System.Windows.Forms.NumericUpDown()
        Me.nudProgressPOW = New System.Windows.Forms.NumericUpDown()
        Me.nudProgressDEX = New System.Windows.Forms.NumericUpDown()
        Me.nudProgressMIND = New System.Windows.Forms.NumericUpDown()
        Me.picPhotonBlast02 = New System.Windows.Forms.PictureBox()
        Me.picPhotonBlast03 = New System.Windows.Forms.PictureBox()
        Me.picPhotonBlast01 = New System.Windows.Forms.PictureBox()
        Me.picMag = New System.Windows.Forms.PictureBox()
        Me.picClass = New System.Windows.Forms.PictureBox()
        Me.ttMagatama = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblCost = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPBFilled = New System.Windows.Forms.Label()
        Me.lbl1HP10 = New System.Windows.Forms.Label()
        Me.lblBoss = New System.Windows.Forms.Label()
        Me.lblDeath = New System.Windows.Forms.Label()
        Me.lblActivationPercent = New System.Windows.Forms.Label()
        Me.btnMagCell = New System.Windows.Forms.Button()
        Me.btnMonomate = New System.Windows.Forms.Button()
        Me.btnDimate = New System.Windows.Forms.Button()
        Me.btnTrimate = New System.Windows.Forms.Button()
        Me.btnMonofluid = New System.Windows.Forms.Button()
        Me.btnDifluid = New System.Windows.Forms.Button()
        Me.btnTrifluid = New System.Windows.Forms.Button()
        Me.btnAntidote = New System.Windows.Forms.Button()
        Me.btnAntiparalysis = New System.Windows.Forms.Button()
        Me.btnSolAtomizer = New System.Windows.Forms.Button()
        Me.btnMoonAtomizer = New System.Windows.Forms.Button()
        Me.btnStarAtomizer = New System.Windows.Forms.Button()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblSynchro = New System.Windows.Forms.Label()
        Me.lblIQ = New System.Windows.Forms.Label()
        Me.lblPOW = New System.Windows.Forms.Label()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblDEF = New System.Windows.Forms.Label()
        Me.lblMIND = New System.Windows.Forms.Label()
        Me.picSectionID = New System.Windows.Forms.PictureBox()
        Me.lblActivation = New System.Windows.Forms.Label()
        Me.nudQtyMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudQtyStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudQtySolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryMonomate = New System.Windows.Forms.NumericUpDown()
        Me.cmsMagatamanudHistory = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ctsHistoryPlus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryPlus1000 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus100 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus250 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctsHistoryMinus1000 = New System.Windows.Forms.ToolStripMenuItem()
        Me.nudHistoryDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudHistorySolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.btnFeedAll = New System.Windows.Forms.Button()
        Me.lblMinutes = New System.Windows.Forms.Label()
        Me.lblMeseta = New System.Windows.Forms.Label()
        Me.lblHistory = New System.Windows.Forms.Label()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.lblItems = New System.Windows.Forms.Label()
        Me.picSave = New System.Windows.Forms.PictureBox()
        Me.lblCycles = New System.Windows.Forms.Label()
        Me.lblCyclesCount = New System.Windows.Forms.Label()
        Me.lblDeathText = New System.Windows.Forms.Label()
        Me.lblBossText = New System.Windows.Forms.Label()
        Me.lbl1HP10Text = New System.Windows.Forms.Label()
        Me.lblPBFilledText = New System.Windows.Forms.Label()
        Me.ofdMagatama = New System.Windows.Forms.OpenFileDialog()
        Me.sfdMatagama = New System.Windows.Forms.SaveFileDialog()
        Me.btnOutputSpace = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.nudHistoryCostMonomate = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostDimate = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostTrimate = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostMonofluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostDifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostAntiparalysis = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostTrifluid = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostAntidote = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostSolAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostMoonAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.nudHistoryCostStarAtomizer = New System.Windows.Forms.NumericUpDown()
        Me.lblHistoryCost = New System.Windows.Forms.Label()
        Me.rtfExport = New System.Windows.Forms.RichTextBox()
        Me.pnlLoading = New System.Windows.Forms.Panel()
        Me.prgFeed = New System.Windows.Forms.ProgressBar()
        Me.prgMassFeed = New System.Windows.Forms.ProgressBar()
        Me.mnuMagatama.SuspendLayout()
        CType(Me.nudDEF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMagatamaNud.SuspendLayout()
        CType(Me.nudIQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSynchro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudPOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMIND, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMagatamaMain.SuspendLayout()
        CType(Me.nudProgressDEF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProgressPOW, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProgressDEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudProgressMIND, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhotonBlast02, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhotonBlast03, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPhotonBlast01, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picClass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSectionID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtyStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQtySolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsMagatamanudHistory.SuspendLayout()
        CType(Me.nudHistoryDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistorySolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostMonomate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostDimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostTrimate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostMonofluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostDifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostAntiparalysis, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostTrifluid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostAntidote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostSolAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostMoonAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudHistoryCostStarAtomizer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLoading.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboClass
        '
        Me.cboClass.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboClass.FormattingEnabled = True
        resources.ApplyResources(Me.cboClass, "cboClass")
        Me.cboClass.Name = "cboClass"
        '
        'cmsMagatamaVoid
        '
        Me.cmsMagatamaVoid.Name = "cmsMagatamaVoid"
        resources.ApplyResources(Me.cmsMagatamaVoid, "cmsMagatamaVoid")
        '
        'cboSectionID
        '
        Me.cboSectionID.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboSectionID.FormattingEnabled = True
        resources.ApplyResources(Me.cboSectionID, "cboSectionID")
        Me.cboSectionID.Name = "cboSectionID"
        '
        'cboPhotonBlast03
        '
        Me.cboPhotonBlast03.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboPhotonBlast03.FormattingEnabled = True
        resources.ApplyResources(Me.cboPhotonBlast03, "cboPhotonBlast03")
        Me.cboPhotonBlast03.Name = "cboPhotonBlast03"
        '
        'cboPhotonBlast02
        '
        Me.cboPhotonBlast02.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboPhotonBlast02.FormattingEnabled = True
        resources.ApplyResources(Me.cboPhotonBlast02, "cboPhotonBlast02")
        Me.cboPhotonBlast02.Name = "cboPhotonBlast02"
        '
        'cboPhotonBlast01
        '
        Me.cboPhotonBlast01.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboPhotonBlast01.FormattingEnabled = True
        resources.ApplyResources(Me.cboPhotonBlast01, "cboPhotonBlast01")
        Me.cboPhotonBlast01.Name = "cboPhotonBlast01"
        '
        'cboMag
        '
        Me.cboMag.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboMag.FormattingEnabled = True
        Me.cboMag.Items.AddRange(New Object() {resources.GetString("cboMag.Items")})
        resources.ApplyResources(Me.cboMag, "cboMag")
        Me.cboMag.Name = "cboMag"
        '
        'mnuMagatama
        '
        Me.mnuMagatama.BackColor = System.Drawing.Color.Transparent
        Me.mnuMagatama.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileMenu, Me.mnuEditMenu, Me.nmuHelpMenu})
        resources.ApplyResources(Me.mnuMagatama, "mnuMagatama")
        Me.mnuMagatama.Name = "mnuMagatama"
        '
        'mnuFileMenu
        '
        Me.mnuFileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileNew, Me.mnuFileNewBlank, Me.mnuFileOpen, Me.mnuFileSave, Me.mnuFileSaveAs, Me.mnuFileExportOutput, Me.mnuFileExit})
        resources.ApplyResources(Me.mnuFileMenu, "mnuFileMenu")
        Me.mnuFileMenu.Name = "mnuFileMenu"
        '
        'mnuFileNew
        '
        Me.mnuFileNew.Name = "mnuFileNew"
        resources.ApplyResources(Me.mnuFileNew, "mnuFileNew")
        '
        'mnuFileNewBlank
        '
        Me.mnuFileNewBlank.Name = "mnuFileNewBlank"
        resources.ApplyResources(Me.mnuFileNewBlank, "mnuFileNewBlank")
        '
        'mnuFileOpen
        '
        Me.mnuFileOpen.Name = "mnuFileOpen"
        resources.ApplyResources(Me.mnuFileOpen, "mnuFileOpen")
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        resources.ApplyResources(Me.mnuFileSave, "mnuFileSave")
        '
        'mnuFileSaveAs
        '
        Me.mnuFileSaveAs.Name = "mnuFileSaveAs"
        resources.ApplyResources(Me.mnuFileSaveAs, "mnuFileSaveAs")
        '
        'mnuFileExportOutput
        '
        Me.mnuFileExportOutput.Name = "mnuFileExportOutput"
        resources.ApplyResources(Me.mnuFileExportOutput, "mnuFileExportOutput")
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        resources.ApplyResources(Me.mnuFileExit, "mnuFileExit")
        '
        'mnuEditMenu
        '
        Me.mnuEditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditUndo, Me.mnuEditRedo, Me.mnuEditResetQty, Me.mnuEditStat, Me.mnuEditInit})
        Me.mnuEditMenu.Name = "mnuEditMenu"
        resources.ApplyResources(Me.mnuEditMenu, "mnuEditMenu")
        '
        'mnuEditUndo
        '
        Me.mnuEditUndo.Name = "mnuEditUndo"
        resources.ApplyResources(Me.mnuEditUndo, "mnuEditUndo")
        '
        'mnuEditRedo
        '
        Me.mnuEditRedo.Name = "mnuEditRedo"
        resources.ApplyResources(Me.mnuEditRedo, "mnuEditRedo")
        '
        'mnuEditResetQty
        '
        Me.mnuEditResetQty.Name = "mnuEditResetQty"
        resources.ApplyResources(Me.mnuEditResetQty, "mnuEditResetQty")
        '
        'mnuEditStat
        '
        Me.mnuEditStat.CheckOnClick = True
        Me.mnuEditStat.Name = "mnuEditStat"
        resources.ApplyResources(Me.mnuEditStat, "mnuEditStat")
        '
        'mnuEditInit
        '
        Me.mnuEditInit.Name = "mnuEditInit"
        resources.ApplyResources(Me.mnuEditInit, "mnuEditInit")
        '
        'nmuHelpMenu
        '
        Me.nmuHelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.nmuHelpAbout})
        Me.nmuHelpMenu.Name = "nmuHelpMenu"
        resources.ApplyResources(Me.nmuHelpMenu, "nmuHelpMenu")
        '
        'nmuHelpAbout
        '
        Me.nmuHelpAbout.Name = "nmuHelpAbout"
        resources.ApplyResources(Me.nmuHelpAbout, "nmuHelpAbout")
        '
        'cboMagCell
        '
        Me.cboMagCell.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.cboMagCell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMagCell.FormattingEnabled = True
        resources.ApplyResources(Me.cboMagCell, "cboMagCell")
        Me.cboMagCell.Name = "cboMagCell"
        '
        'prgDEF
        '
        Me.prgDEF.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.prgDEF, "prgDEF")
        Me.prgDEF.Name = "prgDEF"
        Me.prgDEF.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgDEF.Tag = "Blue"
        '
        'prgPOW
        '
        Me.prgPOW.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.prgPOW, "prgPOW")
        Me.prgPOW.Name = "prgPOW"
        Me.prgPOW.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgPOW.Tag = "Red"
        '
        'prgDEX
        '
        Me.prgDEX.ForeColor = System.Drawing.Color.Yellow
        resources.ApplyResources(Me.prgDEX, "prgDEX")
        Me.prgDEX.Name = "prgDEX"
        Me.prgDEX.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgDEX.Tag = "Goldenrod"
        '
        'prgMind
        '
        Me.prgMind.ForeColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.prgMind, "prgMind")
        Me.prgMind.Name = "prgMind"
        Me.prgMind.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgMind.Tag = "Green"
        '
        'nudDEF
        '
        Me.nudDEF.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudDEF, "nudDEF")
        Me.nudDEF.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudDEF.Name = "nudDEF"
        Me.nudDEF.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'cmsMagatamaNud
        '
        Me.cmsMagatamaNud.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPlus, Me.cmsMinus, Me.cmsSeparator1, Me.cmsNUDto3, Me.cmsNUDtoMax, Me.cmsNUDtoHalf, Me.cmsNUDtoZero})
        Me.cmsMagatamaNud.Name = "cmsMagatamaNud"
        resources.ApplyResources(Me.cmsMagatamaNud, "cmsMagatamaNud")
        '
        'cmsPlus
        '
        Me.cmsPlus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsPlus5, Me.cmsPlus10, Me.cmsPlus25, Me.cmsPlus100, Me.cmsPlus250, Me.cmsPlus1000})
        Me.cmsPlus.Name = "cmsPlus"
        resources.ApplyResources(Me.cmsPlus, "cmsPlus")
        Me.cmsPlus.Tag = "by"
        '
        'cmsPlus5
        '
        Me.cmsPlus5.Name = "cmsPlus5"
        resources.ApplyResources(Me.cmsPlus5, "cmsPlus5")
        Me.cmsPlus5.Tag = "5"
        '
        'cmsPlus10
        '
        Me.cmsPlus10.Name = "cmsPlus10"
        resources.ApplyResources(Me.cmsPlus10, "cmsPlus10")
        Me.cmsPlus10.Tag = "10"
        '
        'cmsPlus25
        '
        Me.cmsPlus25.Name = "cmsPlus25"
        resources.ApplyResources(Me.cmsPlus25, "cmsPlus25")
        Me.cmsPlus25.Tag = "25"
        '
        'cmsPlus100
        '
        Me.cmsPlus100.Name = "cmsPlus100"
        resources.ApplyResources(Me.cmsPlus100, "cmsPlus100")
        Me.cmsPlus100.Tag = "100"
        '
        'cmsPlus250
        '
        Me.cmsPlus250.Name = "cmsPlus250"
        resources.ApplyResources(Me.cmsPlus250, "cmsPlus250")
        Me.cmsPlus250.Tag = "250"
        '
        'cmsPlus1000
        '
        Me.cmsPlus1000.Name = "cmsPlus1000"
        resources.ApplyResources(Me.cmsPlus1000, "cmsPlus1000")
        Me.cmsPlus1000.Tag = "1000"
        '
        'cmsMinus
        '
        Me.cmsMinus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsMinus5, Me.cmsMinus10, Me.cmsMinus25, Me.cmsMinus100, Me.cmsMinus250, Me.cmsMinus1000})
        Me.cmsMinus.Name = "cmsMinus"
        resources.ApplyResources(Me.cmsMinus, "cmsMinus")
        '
        'cmsMinus5
        '
        Me.cmsMinus5.Name = "cmsMinus5"
        resources.ApplyResources(Me.cmsMinus5, "cmsMinus5")
        '
        'cmsMinus10
        '
        Me.cmsMinus10.Name = "cmsMinus10"
        resources.ApplyResources(Me.cmsMinus10, "cmsMinus10")
        '
        'cmsMinus25
        '
        Me.cmsMinus25.Name = "cmsMinus25"
        resources.ApplyResources(Me.cmsMinus25, "cmsMinus25")
        '
        'cmsMinus100
        '
        Me.cmsMinus100.Name = "cmsMinus100"
        resources.ApplyResources(Me.cmsMinus100, "cmsMinus100")
        '
        'cmsMinus250
        '
        Me.cmsMinus250.Name = "cmsMinus250"
        resources.ApplyResources(Me.cmsMinus250, "cmsMinus250")
        '
        'cmsMinus1000
        '
        Me.cmsMinus1000.Name = "cmsMinus1000"
        resources.ApplyResources(Me.cmsMinus1000, "cmsMinus1000")
        '
        'cmsSeparator1
        '
        Me.cmsSeparator1.Name = "cmsSeparator1"
        resources.ApplyResources(Me.cmsSeparator1, "cmsSeparator1")
        '
        'cmsNUDto3
        '
        Me.cmsNUDto3.Name = "cmsNUDto3"
        resources.ApplyResources(Me.cmsNUDto3, "cmsNUDto3")
        Me.cmsNUDto3.Tag = "3"
        '
        'cmsNUDtoMax
        '
        Me.cmsNUDtoMax.Name = "cmsNUDtoMax"
        resources.ApplyResources(Me.cmsNUDtoMax, "cmsNUDtoMax")
        '
        'cmsNUDtoHalf
        '
        Me.cmsNUDtoHalf.Name = "cmsNUDtoHalf"
        resources.ApplyResources(Me.cmsNUDtoHalf, "cmsNUDtoHalf")
        '
        'cmsNUDtoZero
        '
        Me.cmsNUDtoZero.Name = "cmsNUDtoZero"
        resources.ApplyResources(Me.cmsNUDtoZero, "cmsNUDtoZero")
        '
        'nudIQ
        '
        Me.nudIQ.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudIQ, "nudIQ")
        Me.nudIQ.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudIQ.Name = "nudIQ"
        '
        'nudLevel
        '
        resources.ApplyResources(Me.nudLevel, "nudLevel")
        Me.nudLevel.Maximum = New Decimal(New Integer() {800, 0, 0, 0})
        Me.nudLevel.Name = "nudLevel"
        Me.nudLevel.ReadOnly = True
        '
        'nudSynchro
        '
        Me.nudSynchro.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudSynchro, "nudSynchro")
        Me.nudSynchro.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.nudSynchro.Name = "nudSynchro"
        '
        'nudPOW
        '
        Me.nudPOW.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudPOW, "nudPOW")
        Me.nudPOW.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudPOW.Name = "nudPOW"
        '
        'nudDEX
        '
        Me.nudDEX.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudDEX, "nudDEX")
        Me.nudDEX.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudDEX.Name = "nudDEX"
        '
        'nudMIND
        '
        Me.nudMIND.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudMIND, "nudMIND")
        Me.nudMIND.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudMIND.Name = "nudMIND"
        '
        'rtfOutput
        '
        Me.rtfOutput.BackColor = System.Drawing.Color.White
        Me.rtfOutput.ContextMenuStrip = Me.cmsMagatamaMain
        Me.rtfOutput.HideSelection = False
        resources.ApplyResources(Me.rtfOutput, "rtfOutput")
        Me.rtfOutput.Name = "rtfOutput"
        Me.rtfOutput.ReadOnly = True
        Me.rtfOutput.TabStop = False
        '
        'cmsMagatamaMain
        '
        Me.cmsMagatamaMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsExportOutput, Me.cmsSave, Me.cmsSaveAs, Me.cms_separator1, Me.cmsUndo, Me.cmsRedo, Me.cms_separator2, Me.cmsNewMag, Me.cmsBlankMag, Me.cms_separator3, Me.cmsOpen})
        Me.cmsMagatamaMain.Name = "cmsMagatamaMain"
        resources.ApplyResources(Me.cmsMagatamaMain, "cmsMagatamaMain")
        '
        'cmsExportOutput
        '
        Me.cmsExportOutput.Name = "cmsExportOutput"
        resources.ApplyResources(Me.cmsExportOutput, "cmsExportOutput")
        '
        'cmsSave
        '
        Me.cmsSave.Name = "cmsSave"
        resources.ApplyResources(Me.cmsSave, "cmsSave")
        '
        'cmsSaveAs
        '
        Me.cmsSaveAs.Name = "cmsSaveAs"
        resources.ApplyResources(Me.cmsSaveAs, "cmsSaveAs")
        '
        'cms_separator1
        '
        Me.cms_separator1.Name = "cms_separator1"
        resources.ApplyResources(Me.cms_separator1, "cms_separator1")
        '
        'cmsUndo
        '
        Me.cmsUndo.Name = "cmsUndo"
        resources.ApplyResources(Me.cmsUndo, "cmsUndo")
        '
        'cmsRedo
        '
        Me.cmsRedo.Name = "cmsRedo"
        resources.ApplyResources(Me.cmsRedo, "cmsRedo")
        '
        'cms_separator2
        '
        Me.cms_separator2.Name = "cms_separator2"
        resources.ApplyResources(Me.cms_separator2, "cms_separator2")
        '
        'cmsNewMag
        '
        Me.cmsNewMag.Name = "cmsNewMag"
        resources.ApplyResources(Me.cmsNewMag, "cmsNewMag")
        '
        'cmsBlankMag
        '
        Me.cmsBlankMag.Name = "cmsBlankMag"
        resources.ApplyResources(Me.cmsBlankMag, "cmsBlankMag")
        '
        'cms_separator3
        '
        Me.cms_separator3.Name = "cms_separator3"
        resources.ApplyResources(Me.cms_separator3, "cms_separator3")
        '
        'cmsOpen
        '
        Me.cmsOpen.Name = "cmsOpen"
        resources.ApplyResources(Me.cmsOpen, "cmsOpen")
        '
        'nudProgressDEF
        '
        Me.nudProgressDEF.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudProgressDEF, "nudProgressDEF")
        Me.nudProgressDEF.Name = "nudProgressDEF"
        '
        'nudProgressPOW
        '
        Me.nudProgressPOW.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudProgressPOW, "nudProgressPOW")
        Me.nudProgressPOW.Name = "nudProgressPOW"
        '
        'nudProgressDEX
        '
        Me.nudProgressDEX.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudProgressDEX, "nudProgressDEX")
        Me.nudProgressDEX.Name = "nudProgressDEX"
        '
        'nudProgressMIND
        '
        Me.nudProgressMIND.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudProgressMIND, "nudProgressMIND")
        Me.nudProgressMIND.Name = "nudProgressMIND"
        '
        'picPhotonBlast02
        '
        Me.picPhotonBlast02.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picPhotonBlast02, "picPhotonBlast02")
        Me.picPhotonBlast02.Name = "picPhotonBlast02"
        Me.picPhotonBlast02.TabStop = False
        '
        'picPhotonBlast03
        '
        Me.picPhotonBlast03.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picPhotonBlast03, "picPhotonBlast03")
        Me.picPhotonBlast03.Name = "picPhotonBlast03"
        Me.picPhotonBlast03.TabStop = False
        '
        'picPhotonBlast01
        '
        Me.picPhotonBlast01.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picPhotonBlast01, "picPhotonBlast01")
        Me.picPhotonBlast01.Name = "picPhotonBlast01"
        Me.picPhotonBlast01.TabStop = False
        '
        'picMag
        '
        Me.picMag.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picMag, "picMag")
        Me.picMag.Name = "picMag"
        Me.picMag.TabStop = False
        '
        'picClass
        '
        Me.picClass.BackColor = System.Drawing.Color.Transparent
        Me.picClass.ContextMenuStrip = Me.cmsMagatamaVoid
        resources.ApplyResources(Me.picClass, "picClass")
        Me.picClass.Name = "picClass"
        Me.picClass.TabStop = False
        '
        'lblCost
        '
        Me.lblCost.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblCost, "lblCost")
        Me.lblCost.Name = "lblCost"
        '
        'lblTime
        '
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblTime, "lblTime")
        Me.lblTime.Name = "lblTime"
        '
        'lblPBFilled
        '
        Me.lblPBFilled.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblPBFilled, "lblPBFilled")
        Me.lblPBFilled.Name = "lblPBFilled"
        '
        'lbl1HP10
        '
        Me.lbl1HP10.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbl1HP10, "lbl1HP10")
        Me.lbl1HP10.Name = "lbl1HP10"
        '
        'lblBoss
        '
        Me.lblBoss.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblBoss, "lblBoss")
        Me.lblBoss.Name = "lblBoss"
        '
        'lblDeath
        '
        Me.lblDeath.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblDeath, "lblDeath")
        Me.lblDeath.Name = "lblDeath"
        '
        'lblActivationPercent
        '
        Me.lblActivationPercent.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblActivationPercent, "lblActivationPercent")
        Me.lblActivationPercent.Name = "lblActivationPercent"
        '
        'btnMagCell
        '
        resources.ApplyResources(Me.btnMagCell, "btnMagCell")
        Me.btnMagCell.Name = "btnMagCell"
        Me.btnMagCell.UseVisualStyleBackColor = True
        '
        'btnMonomate
        '
        resources.ApplyResources(Me.btnMonomate, "btnMonomate")
        Me.btnMonomate.Name = "btnMonomate"
        Me.btnMonomate.Tag = "mate"
        Me.btnMonomate.UseVisualStyleBackColor = True
        '
        'btnDimate
        '
        resources.ApplyResources(Me.btnDimate, "btnDimate")
        Me.btnDimate.Name = "btnDimate"
        Me.btnDimate.Tag = "mate"
        Me.btnDimate.UseVisualStyleBackColor = True
        '
        'btnTrimate
        '
        resources.ApplyResources(Me.btnTrimate, "btnTrimate")
        Me.btnTrimate.Name = "btnTrimate"
        Me.btnTrimate.Tag = "mate"
        Me.btnTrimate.UseVisualStyleBackColor = True
        '
        'btnMonofluid
        '
        resources.ApplyResources(Me.btnMonofluid, "btnMonofluid")
        Me.btnMonofluid.Name = "btnMonofluid"
        Me.btnMonofluid.Tag = "fluid"
        Me.btnMonofluid.UseVisualStyleBackColor = True
        '
        'btnDifluid
        '
        resources.ApplyResources(Me.btnDifluid, "btnDifluid")
        Me.btnDifluid.Name = "btnDifluid"
        Me.btnDifluid.Tag = "fluid"
        Me.btnDifluid.UseVisualStyleBackColor = True
        '
        'btnTrifluid
        '
        resources.ApplyResources(Me.btnTrifluid, "btnTrifluid")
        Me.btnTrifluid.Name = "btnTrifluid"
        Me.btnTrifluid.Tag = "fluid"
        Me.btnTrifluid.UseVisualStyleBackColor = True
        '
        'btnAntidote
        '
        resources.ApplyResources(Me.btnAntidote, "btnAntidote")
        Me.btnAntidote.Name = "btnAntidote"
        Me.btnAntidote.Tag = "Anti"
        Me.btnAntidote.UseVisualStyleBackColor = True
        '
        'btnAntiparalysis
        '
        resources.ApplyResources(Me.btnAntiparalysis, "btnAntiparalysis")
        Me.btnAntiparalysis.Name = "btnAntiparalysis"
        Me.btnAntiparalysis.Tag = "Anti"
        Me.btnAntiparalysis.UseVisualStyleBackColor = True
        '
        'btnSolAtomizer
        '
        resources.ApplyResources(Me.btnSolAtomizer, "btnSolAtomizer")
        Me.btnSolAtomizer.Name = "btnSolAtomizer"
        Me.btnSolAtomizer.Tag = "Atomizer"
        Me.btnSolAtomizer.UseVisualStyleBackColor = True
        '
        'btnMoonAtomizer
        '
        resources.ApplyResources(Me.btnMoonAtomizer, "btnMoonAtomizer")
        Me.btnMoonAtomizer.Name = "btnMoonAtomizer"
        Me.btnMoonAtomizer.Tag = "Atomizer"
        Me.btnMoonAtomizer.UseVisualStyleBackColor = True
        '
        'btnStarAtomizer
        '
        resources.ApplyResources(Me.btnStarAtomizer, "btnStarAtomizer")
        Me.btnStarAtomizer.Name = "btnStarAtomizer"
        Me.btnStarAtomizer.Tag = "Atomizer"
        Me.btnStarAtomizer.UseVisualStyleBackColor = True
        '
        'lblLevel
        '
        Me.lblLevel.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblLevel, "lblLevel")
        Me.lblLevel.Name = "lblLevel"
        '
        'lblSynchro
        '
        Me.lblSynchro.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblSynchro, "lblSynchro")
        Me.lblSynchro.Name = "lblSynchro"
        '
        'lblIQ
        '
        Me.lblIQ.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblIQ, "lblIQ")
        Me.lblIQ.Name = "lblIQ"
        '
        'lblPOW
        '
        Me.lblPOW.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblPOW, "lblPOW")
        Me.lblPOW.Name = "lblPOW"
        '
        'lblDEX
        '
        Me.lblDEX.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblDEX, "lblDEX")
        Me.lblDEX.Name = "lblDEX"
        '
        'lblDEF
        '
        Me.lblDEF.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblDEF, "lblDEF")
        Me.lblDEF.Name = "lblDEF"
        '
        'lblMIND
        '
        Me.lblMIND.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblMIND, "lblMIND")
        Me.lblMIND.Name = "lblMIND"
        '
        'picSectionID
        '
        Me.picSectionID.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picSectionID, "picSectionID")
        Me.picSectionID.Name = "picSectionID"
        Me.picSectionID.TabStop = False
        '
        'lblActivation
        '
        Me.lblActivation.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblActivation, "lblActivation")
        Me.lblActivation.Name = "lblActivation"
        '
        'nudQtyMonomate
        '
        Me.nudQtyMonomate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyMonomate, "nudQtyMonomate")
        Me.nudQtyMonomate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyMonomate.Name = "nudQtyMonomate"
        '
        'nudQtyDimate
        '
        Me.nudQtyDimate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyDimate, "nudQtyDimate")
        Me.nudQtyDimate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyDimate.Name = "nudQtyDimate"
        '
        'nudQtyTrimate
        '
        Me.nudQtyTrimate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyTrimate, "nudQtyTrimate")
        Me.nudQtyTrimate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyTrimate.Name = "nudQtyTrimate"
        '
        'nudQtyMonofluid
        '
        Me.nudQtyMonofluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyMonofluid, "nudQtyMonofluid")
        Me.nudQtyMonofluid.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyMonofluid.Name = "nudQtyMonofluid"
        '
        'nudQtyDifluid
        '
        Me.nudQtyDifluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyDifluid, "nudQtyDifluid")
        Me.nudQtyDifluid.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyDifluid.Name = "nudQtyDifluid"
        '
        'nudQtyTrifluid
        '
        Me.nudQtyTrifluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyTrifluid, "nudQtyTrifluid")
        Me.nudQtyTrifluid.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyTrifluid.Name = "nudQtyTrifluid"
        '
        'nudQtyAntidote
        '
        Me.nudQtyAntidote.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyAntidote, "nudQtyAntidote")
        Me.nudQtyAntidote.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyAntidote.Name = "nudQtyAntidote"
        '
        'nudQtyAntiparalysis
        '
        Me.nudQtyAntiparalysis.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyAntiparalysis, "nudQtyAntiparalysis")
        Me.nudQtyAntiparalysis.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyAntiparalysis.Name = "nudQtyAntiparalysis"
        '
        'nudQtyMoonAtomizer
        '
        Me.nudQtyMoonAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyMoonAtomizer, "nudQtyMoonAtomizer")
        Me.nudQtyMoonAtomizer.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyMoonAtomizer.Name = "nudQtyMoonAtomizer"
        '
        'nudQtyStarAtomizer
        '
        Me.nudQtyStarAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtyStarAtomizer, "nudQtyStarAtomizer")
        Me.nudQtyStarAtomizer.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtyStarAtomizer.Name = "nudQtyStarAtomizer"
        '
        'nudQtySolAtomizer
        '
        Me.nudQtySolAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudQtySolAtomizer, "nudQtySolAtomizer")
        Me.nudQtySolAtomizer.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQtySolAtomizer.Name = "nudQtySolAtomizer"
        '
        'nudHistoryMonomate
        '
        Me.nudHistoryMonomate.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryMonomate, "nudHistoryMonomate")
        Me.nudHistoryMonomate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryMonomate.Name = "nudHistoryMonomate"
        Me.nudHistoryMonomate.TabStop = False
        '
        'cmsMagatamanudHistory
        '
        Me.cmsMagatamanudHistory.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctsHistoryPlus, Me.ctsHistoryMinus})
        Me.cmsMagatamanudHistory.Name = "cmsMagatamanudHistory"
        resources.ApplyResources(Me.cmsMagatamanudHistory, "cmsMagatamanudHistory")
        '
        'ctsHistoryPlus
        '
        Me.ctsHistoryPlus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctsHistoryPlus5, Me.ctsHistoryPlus10, Me.ctsHistoryPlus25, Me.ctsHistoryPlus100, Me.ctsHistoryPlus250, Me.ctsHistoryPlus1000})
        Me.ctsHistoryPlus.Name = "ctsHistoryPlus"
        resources.ApplyResources(Me.ctsHistoryPlus, "ctsHistoryPlus")
        '
        'ctsHistoryPlus5
        '
        Me.ctsHistoryPlus5.Name = "ctsHistoryPlus5"
        resources.ApplyResources(Me.ctsHistoryPlus5, "ctsHistoryPlus5")
        Me.ctsHistoryPlus5.Tag = ""
        '
        'ctsHistoryPlus10
        '
        Me.ctsHistoryPlus10.Name = "ctsHistoryPlus10"
        resources.ApplyResources(Me.ctsHistoryPlus10, "ctsHistoryPlus10")
        Me.ctsHistoryPlus10.Tag = ""
        '
        'ctsHistoryPlus25
        '
        Me.ctsHistoryPlus25.Name = "ctsHistoryPlus25"
        resources.ApplyResources(Me.ctsHistoryPlus25, "ctsHistoryPlus25")
        Me.ctsHistoryPlus25.Tag = ""
        '
        'ctsHistoryPlus100
        '
        Me.ctsHistoryPlus100.Name = "ctsHistoryPlus100"
        resources.ApplyResources(Me.ctsHistoryPlus100, "ctsHistoryPlus100")
        Me.ctsHistoryPlus100.Tag = ""
        '
        'ctsHistoryPlus250
        '
        Me.ctsHistoryPlus250.Name = "ctsHistoryPlus250"
        resources.ApplyResources(Me.ctsHistoryPlus250, "ctsHistoryPlus250")
        Me.ctsHistoryPlus250.Tag = ""
        '
        'ctsHistoryPlus1000
        '
        Me.ctsHistoryPlus1000.Name = "ctsHistoryPlus1000"
        resources.ApplyResources(Me.ctsHistoryPlus1000, "ctsHistoryPlus1000")
        Me.ctsHistoryPlus1000.Tag = ""
        '
        'ctsHistoryMinus
        '
        Me.ctsHistoryMinus.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ctsHistoryMinus5, Me.ctsHistoryMinus10, Me.ctsHistoryMinus25, Me.ctsHistoryMinus100, Me.ctsHistoryMinus250, Me.ctsHistoryMinus1000})
        Me.ctsHistoryMinus.Name = "ctsHistoryMinus"
        resources.ApplyResources(Me.ctsHistoryMinus, "ctsHistoryMinus")
        '
        'ctsHistoryMinus5
        '
        Me.ctsHistoryMinus5.Name = "ctsHistoryMinus5"
        resources.ApplyResources(Me.ctsHistoryMinus5, "ctsHistoryMinus5")
        '
        'ctsHistoryMinus10
        '
        Me.ctsHistoryMinus10.Name = "ctsHistoryMinus10"
        resources.ApplyResources(Me.ctsHistoryMinus10, "ctsHistoryMinus10")
        '
        'ctsHistoryMinus25
        '
        Me.ctsHistoryMinus25.Name = "ctsHistoryMinus25"
        resources.ApplyResources(Me.ctsHistoryMinus25, "ctsHistoryMinus25")
        '
        'ctsHistoryMinus100
        '
        Me.ctsHistoryMinus100.Name = "ctsHistoryMinus100"
        resources.ApplyResources(Me.ctsHistoryMinus100, "ctsHistoryMinus100")
        '
        'ctsHistoryMinus250
        '
        Me.ctsHistoryMinus250.Name = "ctsHistoryMinus250"
        resources.ApplyResources(Me.ctsHistoryMinus250, "ctsHistoryMinus250")
        '
        'ctsHistoryMinus1000
        '
        Me.ctsHistoryMinus1000.Name = "ctsHistoryMinus1000"
        resources.ApplyResources(Me.ctsHistoryMinus1000, "ctsHistoryMinus1000")
        '
        'nudHistoryDimate
        '
        Me.nudHistoryDimate.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryDimate, "nudHistoryDimate")
        Me.nudHistoryDimate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryDimate.Name = "nudHistoryDimate"
        Me.nudHistoryDimate.TabStop = False
        '
        'nudHistoryTrimate
        '
        Me.nudHistoryTrimate.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryTrimate, "nudHistoryTrimate")
        Me.nudHistoryTrimate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryTrimate.Name = "nudHistoryTrimate"
        Me.nudHistoryTrimate.TabStop = False
        '
        'nudHistoryMonofluid
        '
        Me.nudHistoryMonofluid.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryMonofluid, "nudHistoryMonofluid")
        Me.nudHistoryMonofluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryMonofluid.Name = "nudHistoryMonofluid"
        Me.nudHistoryMonofluid.TabStop = False
        '
        'nudHistoryDifluid
        '
        Me.nudHistoryDifluid.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryDifluid, "nudHistoryDifluid")
        Me.nudHistoryDifluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryDifluid.Name = "nudHistoryDifluid"
        Me.nudHistoryDifluid.TabStop = False
        '
        'nudHistoryTrifluid
        '
        Me.nudHistoryTrifluid.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryTrifluid, "nudHistoryTrifluid")
        Me.nudHistoryTrifluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryTrifluid.Name = "nudHistoryTrifluid"
        Me.nudHistoryTrifluid.TabStop = False
        '
        'nudHistoryAntidote
        '
        Me.nudHistoryAntidote.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryAntidote, "nudHistoryAntidote")
        Me.nudHistoryAntidote.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryAntidote.Name = "nudHistoryAntidote"
        Me.nudHistoryAntidote.TabStop = False
        '
        'nudHistoryAntiparalysis
        '
        Me.nudHistoryAntiparalysis.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryAntiparalysis, "nudHistoryAntiparalysis")
        Me.nudHistoryAntiparalysis.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryAntiparalysis.Name = "nudHistoryAntiparalysis"
        Me.nudHistoryAntiparalysis.TabStop = False
        '
        'nudHistorySolAtomizer
        '
        Me.nudHistorySolAtomizer.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistorySolAtomizer, "nudHistorySolAtomizer")
        Me.nudHistorySolAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistorySolAtomizer.Name = "nudHistorySolAtomizer"
        Me.nudHistorySolAtomizer.TabStop = False
        '
        'nudHistoryMoonAtomizer
        '
        Me.nudHistoryMoonAtomizer.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryMoonAtomizer, "nudHistoryMoonAtomizer")
        Me.nudHistoryMoonAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryMoonAtomizer.Name = "nudHistoryMoonAtomizer"
        Me.nudHistoryMoonAtomizer.TabStop = False
        '
        'nudHistoryStarAtomizer
        '
        Me.nudHistoryStarAtomizer.ContextMenuStrip = Me.cmsMagatamanudHistory
        resources.ApplyResources(Me.nudHistoryStarAtomizer, "nudHistoryStarAtomizer")
        Me.nudHistoryStarAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryStarAtomizer.Name = "nudHistoryStarAtomizer"
        Me.nudHistoryStarAtomizer.TabStop = False
        '
        'btnFeedAll
        '
        resources.ApplyResources(Me.btnFeedAll, "btnFeedAll")
        Me.btnFeedAll.Name = "btnFeedAll"
        Me.btnFeedAll.UseVisualStyleBackColor = True
        '
        'lblMinutes
        '
        Me.lblMinutes.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblMinutes, "lblMinutes")
        Me.lblMinutes.Name = "lblMinutes"
        '
        'lblMeseta
        '
        Me.lblMeseta.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblMeseta, "lblMeseta")
        Me.lblMeseta.Name = "lblMeseta"
        '
        'lblHistory
        '
        Me.lblHistory.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblHistory, "lblHistory")
        Me.lblHistory.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHistory.Name = "lblHistory"
        '
        'lblQTY
        '
        Me.lblQTY.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblQTY, "lblQTY")
        Me.lblQTY.ForeColor = System.Drawing.SystemColors.Control
        Me.lblQTY.Name = "lblQTY"
        '
        'lblItems
        '
        Me.lblItems.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblItems, "lblItems")
        Me.lblItems.ForeColor = System.Drawing.SystemColors.Control
        Me.lblItems.Name = "lblItems"
        '
        'picSave
        '
        Me.picSave.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.picSave, "picSave")
        Me.picSave.Name = "picSave"
        Me.picSave.TabStop = False
        '
        'lblCycles
        '
        Me.lblCycles.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblCycles, "lblCycles")
        Me.lblCycles.Name = "lblCycles"
        '
        'lblCyclesCount
        '
        Me.lblCyclesCount.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblCyclesCount, "lblCyclesCount")
        Me.lblCyclesCount.Name = "lblCyclesCount"
        '
        'lblDeathText
        '
        Me.lblDeathText.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblDeathText, "lblDeathText")
        Me.lblDeathText.Name = "lblDeathText"
        '
        'lblBossText
        '
        Me.lblBossText.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblBossText, "lblBossText")
        Me.lblBossText.Name = "lblBossText"
        '
        'lbl1HP10Text
        '
        Me.lbl1HP10Text.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lbl1HP10Text, "lbl1HP10Text")
        Me.lbl1HP10Text.Name = "lbl1HP10Text"
        '
        'lblPBFilledText
        '
        Me.lblPBFilledText.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblPBFilledText, "lblPBFilledText")
        Me.lblPBFilledText.Name = "lblPBFilledText"
        '
        'btnOutputSpace
        '
        resources.ApplyResources(Me.btnOutputSpace, "btnOutputSpace")
        Me.btnOutputSpace.Name = "btnOutputSpace"
        Me.btnOutputSpace.UseVisualStyleBackColor = True
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblOutput, "lblOutput")
        Me.lblOutput.ForeColor = System.Drawing.SystemColors.Control
        Me.lblOutput.Name = "lblOutput"
        '
        'nudHistoryCostMonomate
        '
        Me.nudHistoryCostMonomate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostMonomate, "nudHistoryCostMonomate")
        Me.nudHistoryCostMonomate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostMonomate.Name = "nudHistoryCostMonomate"
        Me.nudHistoryCostMonomate.TabStop = False
        '
        'nudHistoryCostDimate
        '
        Me.nudHistoryCostDimate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostDimate, "nudHistoryCostDimate")
        Me.nudHistoryCostDimate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostDimate.Name = "nudHistoryCostDimate"
        Me.nudHistoryCostDimate.TabStop = False
        '
        'nudHistoryCostTrimate
        '
        Me.nudHistoryCostTrimate.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostTrimate, "nudHistoryCostTrimate")
        Me.nudHistoryCostTrimate.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostTrimate.Name = "nudHistoryCostTrimate"
        Me.nudHistoryCostTrimate.TabStop = False
        '
        'nudHistoryCostMonofluid
        '
        Me.nudHistoryCostMonofluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostMonofluid, "nudHistoryCostMonofluid")
        Me.nudHistoryCostMonofluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostMonofluid.Name = "nudHistoryCostMonofluid"
        Me.nudHistoryCostMonofluid.TabStop = False
        '
        'nudHistoryCostDifluid
        '
        Me.nudHistoryCostDifluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostDifluid, "nudHistoryCostDifluid")
        Me.nudHistoryCostDifluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostDifluid.Name = "nudHistoryCostDifluid"
        Me.nudHistoryCostDifluid.TabStop = False
        '
        'nudHistoryCostAntiparalysis
        '
        Me.nudHistoryCostAntiparalysis.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostAntiparalysis, "nudHistoryCostAntiparalysis")
        Me.nudHistoryCostAntiparalysis.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostAntiparalysis.Name = "nudHistoryCostAntiparalysis"
        Me.nudHistoryCostAntiparalysis.TabStop = False
        '
        'nudHistoryCostTrifluid
        '
        Me.nudHistoryCostTrifluid.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostTrifluid, "nudHistoryCostTrifluid")
        Me.nudHistoryCostTrifluid.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostTrifluid.Name = "nudHistoryCostTrifluid"
        Me.nudHistoryCostTrifluid.TabStop = False
        '
        'nudHistoryCostAntidote
        '
        Me.nudHistoryCostAntidote.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostAntidote, "nudHistoryCostAntidote")
        Me.nudHistoryCostAntidote.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostAntidote.Name = "nudHistoryCostAntidote"
        Me.nudHistoryCostAntidote.TabStop = False
        '
        'nudHistoryCostSolAtomizer
        '
        Me.nudHistoryCostSolAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostSolAtomizer, "nudHistoryCostSolAtomizer")
        Me.nudHistoryCostSolAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostSolAtomizer.Name = "nudHistoryCostSolAtomizer"
        Me.nudHistoryCostSolAtomizer.TabStop = False
        '
        'nudHistoryCostMoonAtomizer
        '
        Me.nudHistoryCostMoonAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostMoonAtomizer, "nudHistoryCostMoonAtomizer")
        Me.nudHistoryCostMoonAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostMoonAtomizer.Name = "nudHistoryCostMoonAtomizer"
        Me.nudHistoryCostMoonAtomizer.TabStop = False
        '
        'nudHistoryCostStarAtomizer
        '
        Me.nudHistoryCostStarAtomizer.ContextMenuStrip = Me.cmsMagatamaNud
        resources.ApplyResources(Me.nudHistoryCostStarAtomizer, "nudHistoryCostStarAtomizer")
        Me.nudHistoryCostStarAtomizer.Maximum = New Decimal(New Integer() {-1, -1, -1, 0})
        Me.nudHistoryCostStarAtomizer.Name = "nudHistoryCostStarAtomizer"
        Me.nudHistoryCostStarAtomizer.TabStop = False
        '
        'lblHistoryCost
        '
        Me.lblHistoryCost.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.lblHistoryCost, "lblHistoryCost")
        Me.lblHistoryCost.ForeColor = System.Drawing.SystemColors.Control
        Me.lblHistoryCost.Name = "lblHistoryCost"
        '
        'rtfExport
        '
        Me.rtfExport.ContextMenuStrip = Me.cmsMagatamaVoid
        resources.ApplyResources(Me.rtfExport, "rtfExport")
        Me.rtfExport.Name = "rtfExport"
        Me.rtfExport.ShortcutsEnabled = False
        '
        'pnlLoading
        '
        Me.pnlLoading.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.pnlLoading, "pnlLoading")
        Me.pnlLoading.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.pnlLoading.Controls.Add(Me.prgFeed)
        Me.pnlLoading.Controls.Add(Me.prgMassFeed)
        Me.pnlLoading.Name = "pnlLoading"
        '
        'prgFeed
        '
        Me.prgFeed.BackColor = System.Drawing.SystemColors.Control
        Me.prgFeed.ContextMenuStrip = Me.cmsMagatamaVoid
        Me.prgFeed.ForeColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.prgFeed, "prgFeed")
        Me.prgFeed.Name = "prgFeed"
        Me.prgFeed.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgFeed.Tag = "100"
        '
        'prgMassFeed
        '
        Me.prgMassFeed.ContextMenuStrip = Me.cmsMagatamaVoid
        resources.ApplyResources(Me.prgMassFeed, "prgMassFeed")
        Me.prgMassFeed.Maximum = 10
        Me.prgMassFeed.Name = "prgMassFeed"
        '
        'frmMagatama
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip = Me.cmsMagatamaMain
        Me.Controls.Add(Me.rtfExport)
        Me.Controls.Add(Me.lblHistoryCost)
        Me.Controls.Add(Me.nudHistoryCostStarAtomizer)
        Me.Controls.Add(Me.nudHistoryCostMoonAtomizer)
        Me.Controls.Add(Me.nudHistoryCostSolAtomizer)
        Me.Controls.Add(Me.nudHistoryCostAntidote)
        Me.Controls.Add(Me.nudHistoryCostTrifluid)
        Me.Controls.Add(Me.nudHistoryCostAntiparalysis)
        Me.Controls.Add(Me.nudHistoryCostDifluid)
        Me.Controls.Add(Me.nudHistoryCostMonofluid)
        Me.Controls.Add(Me.nudHistoryCostTrimate)
        Me.Controls.Add(Me.nudHistoryCostDimate)
        Me.Controls.Add(Me.nudHistoryCostMonomate)
        Me.Controls.Add(Me.btnOutputSpace)
        Me.Controls.Add(Me.lblPBFilledText)
        Me.Controls.Add(Me.lbl1HP10Text)
        Me.Controls.Add(Me.lblBossText)
        Me.Controls.Add(Me.lblDeathText)
        Me.Controls.Add(Me.lblCyclesCount)
        Me.Controls.Add(Me.lblCycles)
        Me.Controls.Add(Me.picSave)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblItems)
        Me.Controls.Add(Me.lblQTY)
        Me.Controls.Add(Me.lblHistory)
        Me.Controls.Add(Me.lblMeseta)
        Me.Controls.Add(Me.lblMinutes)
        Me.Controls.Add(Me.btnFeedAll)
        Me.Controls.Add(Me.nudHistoryStarAtomizer)
        Me.Controls.Add(Me.nudHistoryMoonAtomizer)
        Me.Controls.Add(Me.nudHistorySolAtomizer)
        Me.Controls.Add(Me.nudHistoryAntiparalysis)
        Me.Controls.Add(Me.nudHistoryAntidote)
        Me.Controls.Add(Me.nudHistoryTrifluid)
        Me.Controls.Add(Me.nudHistoryDifluid)
        Me.Controls.Add(Me.nudHistoryMonofluid)
        Me.Controls.Add(Me.nudHistoryTrimate)
        Me.Controls.Add(Me.nudHistoryDimate)
        Me.Controls.Add(Me.nudHistoryMonomate)
        Me.Controls.Add(Me.nudQtySolAtomizer)
        Me.Controls.Add(Me.nudQtyStarAtomizer)
        Me.Controls.Add(Me.nudQtyMoonAtomizer)
        Me.Controls.Add(Me.nudQtyAntiparalysis)
        Me.Controls.Add(Me.nudQtyAntidote)
        Me.Controls.Add(Me.nudQtyTrifluid)
        Me.Controls.Add(Me.nudQtyDifluid)
        Me.Controls.Add(Me.nudQtyMonofluid)
        Me.Controls.Add(Me.nudQtyTrimate)
        Me.Controls.Add(Me.nudQtyDimate)
        Me.Controls.Add(Me.nudQtyMonomate)
        Me.Controls.Add(Me.lblActivation)
        Me.Controls.Add(Me.lblMIND)
        Me.Controls.Add(Me.lblDEF)
        Me.Controls.Add(Me.lblDEX)
        Me.Controls.Add(Me.lblPOW)
        Me.Controls.Add(Me.lblIQ)
        Me.Controls.Add(Me.lblSynchro)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.btnStarAtomizer)
        Me.Controls.Add(Me.btnMoonAtomizer)
        Me.Controls.Add(Me.btnSolAtomizer)
        Me.Controls.Add(Me.btnAntiparalysis)
        Me.Controls.Add(Me.btnAntidote)
        Me.Controls.Add(Me.btnTrifluid)
        Me.Controls.Add(Me.btnDifluid)
        Me.Controls.Add(Me.btnMonofluid)
        Me.Controls.Add(Me.btnTrimate)
        Me.Controls.Add(Me.btnDimate)
        Me.Controls.Add(Me.btnMonomate)
        Me.Controls.Add(Me.btnMagCell)
        Me.Controls.Add(Me.lblActivationPercent)
        Me.Controls.Add(Me.lblDeath)
        Me.Controls.Add(Me.lblBoss)
        Me.Controls.Add(Me.lbl1HP10)
        Me.Controls.Add(Me.lblPBFilled)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.nudProgressMIND)
        Me.Controls.Add(Me.nudProgressDEX)
        Me.Controls.Add(Me.nudProgressPOW)
        Me.Controls.Add(Me.nudProgressDEF)
        Me.Controls.Add(Me.rtfOutput)
        Me.Controls.Add(Me.picPhotonBlast02)
        Me.Controls.Add(Me.picPhotonBlast03)
        Me.Controls.Add(Me.picPhotonBlast01)
        Me.Controls.Add(Me.nudMIND)
        Me.Controls.Add(Me.nudDEX)
        Me.Controls.Add(Me.nudPOW)
        Me.Controls.Add(Me.nudSynchro)
        Me.Controls.Add(Me.nudLevel)
        Me.Controls.Add(Me.nudIQ)
        Me.Controls.Add(Me.nudDEF)
        Me.Controls.Add(Me.prgMind)
        Me.Controls.Add(Me.prgDEX)
        Me.Controls.Add(Me.prgPOW)
        Me.Controls.Add(Me.prgDEF)
        Me.Controls.Add(Me.picMag)
        Me.Controls.Add(Me.cboMagCell)
        Me.Controls.Add(Me.picClass)
        Me.Controls.Add(Me.picSectionID)
        Me.Controls.Add(Me.cboMag)
        Me.Controls.Add(Me.cboPhotonBlast01)
        Me.Controls.Add(Me.cboPhotonBlast02)
        Me.Controls.Add(Me.cboPhotonBlast03)
        Me.Controls.Add(Me.cboSectionID)
        Me.Controls.Add(Me.cboClass)
        Me.Controls.Add(Me.mnuMagatama)
        Me.Controls.Add(Me.pnlLoading)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnuMagatama
        Me.MaximizeBox = False
        Me.Name = "frmMagatama"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.mnuMagatama.ResumeLayout(False)
        Me.mnuMagatama.PerformLayout()
        CType(Me.nudDEF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMagatamaNud.ResumeLayout(False)
        CType(Me.nudIQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSynchro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudPOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMIND, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMagatamaMain.ResumeLayout(False)
        CType(Me.nudProgressDEF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProgressPOW, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProgressDEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudProgressMIND, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhotonBlast02, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhotonBlast03, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPhotonBlast01, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picClass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSectionID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtyStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQtySolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsMagatamanudHistory.ResumeLayout(False)
        CType(Me.nudHistoryDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistorySolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostMonomate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostDimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostTrimate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostMonofluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostDifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostAntiparalysis, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostTrifluid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostAntidote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostSolAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostMoonAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudHistoryCostStarAtomizer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLoading.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboClass As ComboBox
    Friend WithEvents cboSectionID As ComboBox
    Friend WithEvents cboPhotonBlast03 As ComboBox
    Friend WithEvents cboPhotonBlast02 As ComboBox
    Friend WithEvents cboPhotonBlast01 As ComboBox
    Friend WithEvents cboMag As ComboBox
    Friend WithEvents mnuMagatama As MenuStrip
    Friend WithEvents mnuFileMenu As ToolStripMenuItem
    Friend WithEvents mnuFileNew As ToolStripMenuItem
    Friend WithEvents mnuFileOpen As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents picClass As PictureBox
    Friend WithEvents cboMagCell As ComboBox
    Friend WithEvents picMag As PictureBox
    Friend WithEvents prgDEF As ProgressBar
    Friend WithEvents prgPOW As ProgressBar
    Friend WithEvents prgDEX As ProgressBar
    Friend WithEvents prgMind As ProgressBar
    Friend WithEvents nudDEF As NumericUpDown
    Friend WithEvents nudIQ As NumericUpDown
    Friend WithEvents nudLevel As NumericUpDown
    Friend WithEvents nudSynchro As NumericUpDown
    Friend WithEvents nudPOW As NumericUpDown
    Friend WithEvents nudDEX As NumericUpDown
    Friend WithEvents nudMIND As NumericUpDown
    Friend WithEvents picPhotonBlast01 As PictureBox
    Friend WithEvents picPhotonBlast03 As PictureBox
    Friend WithEvents picPhotonBlast02 As PictureBox
    Friend WithEvents rtfOutput As RichTextBox
    Friend WithEvents nudProgressDEF As NumericUpDown
    Friend WithEvents nudProgressPOW As NumericUpDown
    Friend WithEvents nudProgressDEX As NumericUpDown
    Friend WithEvents nudProgressMIND As NumericUpDown
    Friend WithEvents ttMagatama As ToolTip
    Friend WithEvents lblCost As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents ofdMagatama As OpenFileDialog
    Friend WithEvents lblPBFilled As Label
    Friend WithEvents lbl1HP10 As Label
    Friend WithEvents lblBoss As Label
    Friend WithEvents lblDeath As Label
    Friend WithEvents lblActivationPercent As Label
    Friend WithEvents btnMagCell As Button
    Friend WithEvents btnMonomate As Button
    Friend WithEvents btnDimate As Button
    Friend WithEvents btnTrimate As Button
    Friend WithEvents btnMonofluid As Button
    Friend WithEvents btnDifluid As Button
    Friend WithEvents btnTrifluid As Button
    Friend WithEvents btnAntidote As Button
    Friend WithEvents btnAntiparalysis As Button
    Friend WithEvents btnSolAtomizer As Button
    Friend WithEvents btnMoonAtomizer As Button
    Friend WithEvents btnStarAtomizer As Button
    Friend WithEvents lblLevel As Label
    Friend WithEvents lblSynchro As Label
    Friend WithEvents lblIQ As Label
    Friend WithEvents lblPOW As Label
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblDEF As Label
    Friend WithEvents lblMIND As Label
    Friend WithEvents picSectionID As PictureBox
    Friend WithEvents lblActivation As Label
    Friend WithEvents nudQtyMonomate As NumericUpDown
    Friend WithEvents nudQtyDimate As NumericUpDown
    Friend WithEvents nudQtyTrimate As NumericUpDown
    Friend WithEvents nudQtyMonofluid As NumericUpDown
    Friend WithEvents nudQtyDifluid As NumericUpDown
    Friend WithEvents nudQtyTrifluid As NumericUpDown
    Friend WithEvents nudQtyAntidote As NumericUpDown
    Friend WithEvents nudQtyAntiparalysis As NumericUpDown
    Friend WithEvents nudQtyMoonAtomizer As NumericUpDown
    Friend WithEvents nudQtyStarAtomizer As NumericUpDown
    Friend WithEvents nudQtySolAtomizer As NumericUpDown
    Friend WithEvents nudHistoryMonomate As NumericUpDown
    Friend WithEvents nudHistoryDimate As NumericUpDown
    Friend WithEvents nudHistoryTrimate As NumericUpDown
    Friend WithEvents nudHistoryMonofluid As NumericUpDown
    Friend WithEvents nudHistoryDifluid As NumericUpDown
    Friend WithEvents nudHistoryTrifluid As NumericUpDown
    Friend WithEvents nudHistoryAntidote As NumericUpDown
    Friend WithEvents nudHistoryAntiparalysis As NumericUpDown
    Friend WithEvents nudHistorySolAtomizer As NumericUpDown
    Friend WithEvents nudHistoryMoonAtomizer As NumericUpDown
    Friend WithEvents nudHistoryStarAtomizer As NumericUpDown
    Friend WithEvents btnFeedAll As Button
    Friend WithEvents mnuEditMenu As ToolStripMenuItem
    Friend WithEvents mnuEditStat As ToolStripMenuItem
    Friend WithEvents lblMinutes As Label
    Friend WithEvents lblMeseta As Label
    Friend WithEvents lblHistory As Label
    Friend WithEvents lblQTY As Label
    Friend WithEvents lblItems As Label
    Friend WithEvents nmuHelpMenu As ToolStripMenuItem
    Friend WithEvents nmuHelpAbout As ToolStripMenuItem
    Friend WithEvents mnuFileExportOutput As ToolStripMenuItem
    Friend WithEvents picSave As PictureBox
    Friend WithEvents sfdMatagama As SaveFileDialog
    Friend WithEvents mnuEditInit As ToolStripMenuItem
    Friend WithEvents lblCycles As Label
    Friend WithEvents lblCyclesCount As Label
    Friend WithEvents mnuFileSaveAs As ToolStripMenuItem
    Friend WithEvents lblDeathText As Label
    Friend WithEvents lblBossText As Label
    Friend WithEvents lbl1HP10Text As Label
    Friend WithEvents lblPBFilledText As Label
    Friend WithEvents btnOutputSpace As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents nudHistoryCostMonomate As NumericUpDown
    Friend WithEvents nudHistoryCostDimate As NumericUpDown
    Friend WithEvents nudHistoryCostTrimate As NumericUpDown
    Friend WithEvents nudHistoryCostMonofluid As NumericUpDown
    Friend WithEvents nudHistoryCostDifluid As NumericUpDown
    Friend WithEvents nudHistoryCostAntiparalysis As NumericUpDown
    Friend WithEvents nudHistoryCostTrifluid As NumericUpDown
    Friend WithEvents nudHistoryCostAntidote As NumericUpDown
    Friend WithEvents nudHistoryCostSolAtomizer As NumericUpDown
    Friend WithEvents nudHistoryCostMoonAtomizer As NumericUpDown
    Friend WithEvents nudHistoryCostStarAtomizer As NumericUpDown
    Friend WithEvents lblHistoryCost As Label
    Friend WithEvents mnuEditUndo As ToolStripMenuItem
    Friend WithEvents mnuEditRedo As ToolStripMenuItem
    Friend WithEvents mnuEditResetQty As ToolStripMenuItem
    Friend WithEvents mnuFileNewBlank As ToolStripMenuItem
    Friend WithEvents rtfExport As RichTextBox
    Friend WithEvents cmsMagatamaNud As ContextMenuStrip
    Friend WithEvents cmsNUDtoMax As ToolStripMenuItem
    Friend WithEvents cmsNUDtoZero As ToolStripMenuItem
    Friend WithEvents cmsNUDtoHalf As ToolStripMenuItem
    Friend WithEvents cmsMagatamanudHistory As ContextMenuStrip
    Friend WithEvents cmsMagatamaVoid As ContextMenuStrip
    Friend WithEvents ctsHistoryPlus As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus5 As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus10 As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus100 As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus1000 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus5 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus10 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus100 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus1000 As ToolStripMenuItem
    Friend WithEvents cmsMagatamaMain As ContextMenuStrip
    Friend WithEvents cmsSave As ToolStripMenuItem
    Friend WithEvents cmsExportOutput As ToolStripMenuItem
    Friend WithEvents cmsNewMag As ToolStripMenuItem
    Friend WithEvents cmsRedo As ToolStripMenuItem
    Friend WithEvents cmsUndo As ToolStripMenuItem
    Friend WithEvents cmsBlankMag As ToolStripMenuItem
    Friend WithEvents cms_separator1 As ToolStripSeparator
    Friend WithEvents cms_separator2 As ToolStripSeparator
    Friend WithEvents cmsSaveAs As ToolStripMenuItem
    Friend WithEvents cmsOpen As ToolStripMenuItem
    Friend WithEvents cms_separator3 As ToolStripSeparator
    Friend WithEvents pnlLoading As Panel
    Friend WithEvents prgMassFeed As ProgressBar
    Friend WithEvents prgFeed As ProgressBar
    Friend WithEvents cmsPlus As ToolStripMenuItem
    Friend WithEvents cmsPlus5 As ToolStripMenuItem
    Friend WithEvents cmsPlus10 As ToolStripMenuItem
    Friend WithEvents cmsPlus100 As ToolStripMenuItem
    Friend WithEvents cmsPlus1000 As ToolStripMenuItem
    Friend WithEvents cmsMinus As ToolStripMenuItem
    Friend WithEvents cmsMinus5 As ToolStripMenuItem
    Friend WithEvents cmsMinus10 As ToolStripMenuItem
    Friend WithEvents cmsMinus100 As ToolStripMenuItem
    Friend WithEvents cmsMinus1000 As ToolStripMenuItem
    Friend WithEvents cmsSeparator1 As ToolStripSeparator
    Friend WithEvents cmsPlus25 As ToolStripMenuItem
    Friend WithEvents cmsPlus250 As ToolStripMenuItem
    Friend WithEvents cmsMinus25 As ToolStripMenuItem
    Friend WithEvents cmsMinus250 As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus25 As ToolStripMenuItem
    Friend WithEvents ctsHistoryPlus250 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus25 As ToolStripMenuItem
    Friend WithEvents ctsHistoryMinus250 As ToolStripMenuItem
    Friend WithEvents cmsNUDto3 As ToolStripMenuItem
End Class
