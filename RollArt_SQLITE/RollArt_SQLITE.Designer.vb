<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollArt_SQLITE
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RollArt_SQLITE))
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripEditor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.treeEvents = New System.Windows.Forms.TreeView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.file_dialog = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.btn_ver_participantes = New System.Windows.Forms.Button()
        Me.btn_OpenDB = New System.Windows.Forms.Button()
        Me.num_ParticipantesFinal = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_numActual = New System.Windows.Forms.TextBox()
        Me.btn_recalcula = New System.Windows.Forms.Button()
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditor.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_ParticipantesFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewTable.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.ContextMenuStrip = Me.ContextMenuStripEditor
        Me.DataGridViewTable.Location = New System.Drawing.Point(106, 271)
        Me.DataGridViewTable.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.ReadOnly = True
        Me.DataGridViewTable.RowTemplate.Height = 31
        Me.DataGridViewTable.Size = New System.Drawing.Size(878, 286)
        Me.DataGridViewTable.TabIndex = 20
        '
        'ContextMenuStripEditor
        '
        Me.ContextMenuStripEditor.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ContextMenuStripEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem})
        Me.ContextMenuStripEditor.Name = "ContextMenuStripEditor"
        Me.ContextMenuStripEditor.Size = New System.Drawing.Size(135, 106)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.RollArt_SQLITE.My.Resources.Resources.edit_docu_32
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(134, 34)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Image = Global.RollArt_SQLITE.My.Resources.Resources.papelera_32
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(134, 34)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Image = Global.RollArt_SQLITE.My.Resources.Resources.database_32
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(134, 34)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.treeEvents)
        Me.Panel1.Location = New System.Drawing.Point(106, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 257)
        Me.Panel1.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 23)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Eventos"
        '
        'treeEvents
        '
        Me.treeEvents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.treeEvents.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.treeEvents.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.treeEvents.ImageIndex = 2
        Me.treeEvents.ImageList = Me.ImageList1
        Me.treeEvents.Location = New System.Drawing.Point(80, 4)
        Me.treeEvents.Name = "treeEvents"
        Me.treeEvents.SelectedImageIndex = 1
        Me.treeEvents.ShowPlusMinus = False
        Me.treeEvents.Size = New System.Drawing.Size(795, 250)
        Me.treeEvents.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "evento1.png")
        Me.ImageList1.Images.SetKeyName(1, "blue-search-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "LogoRFEP.png")
        Me.ImageList1.Images.SetKeyName(3, "punto.png")
        '
        'file_dialog
        '
        Me.file_dialog.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.RollArt_SQLITE.My.Resources.Resources.LogoRFEP
        Me.PictureBox1.Location = New System.Drawing.Point(9, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSave.Image = Global.RollArt_SQLITE.My.Resources.Resources.guardar_32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSave.Location = New System.Drawing.Point(10, 493)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSave.Size = New System.Drawing.Size(76, 49)
        Me.ButtonSave.TabIndex = 17
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'btn_ver_participantes
        '
        Me.btn_ver_participantes.Image = Global.RollArt_SQLITE.My.Resources.Resources.tarjeta_32
        Me.btn_ver_participantes.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_ver_participantes.Location = New System.Drawing.Point(9, 159)
        Me.btn_ver_participantes.Name = "btn_ver_participantes"
        Me.btn_ver_participantes.Size = New System.Drawing.Size(76, 50)
        Me.btn_ver_participantes.TabIndex = 29
        Me.btn_ver_participantes.Text = "Recarga TABLA"
        Me.btn_ver_participantes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_ver_participantes.UseVisualStyleBackColor = True
        '
        'btn_OpenDB
        '
        Me.btn_OpenDB.Image = Global.RollArt_SQLITE.My.Resources.Resources.database_32
        Me.btn_OpenDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_OpenDB.Location = New System.Drawing.Point(9, 98)
        Me.btn_OpenDB.Name = "btn_OpenDB"
        Me.btn_OpenDB.Size = New System.Drawing.Size(76, 50)
        Me.btn_OpenDB.TabIndex = 28
        Me.btn_OpenDB.Text = "Abrir BD"
        Me.btn_OpenDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_OpenDB.UseVisualStyleBackColor = True
        '
        'num_ParticipantesFinal
        '
        Me.num_ParticipantesFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.num_ParticipantesFinal.Location = New System.Drawing.Point(9, 370)
        Me.num_ParticipantesFinal.Maximum = New Decimal(New Integer() {37, 0, 0, 0})
        Me.num_ParticipantesFinal.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.num_ParticipantesFinal.Name = "num_ParticipantesFinal"
        Me.num_ParticipantesFinal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.num_ParticipantesFinal.Size = New System.Drawing.Size(76, 26)
        Me.num_ParticipantesFinal.TabIndex = 31
        Me.num_ParticipantesFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.num_ParticipantesFinal.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 65)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Numero particiantes para 2ª RONDA"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(93, 57)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "participantes en 1ª RONDA"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_numActual
        '
        Me.txt_numActual.BackColor = System.Drawing.SystemColors.Info
        Me.txt_numActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_numActual.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.txt_numActual.Location = New System.Drawing.Point(9, 273)
        Me.txt_numActual.Name = "txt_numActual"
        Me.txt_numActual.ReadOnly = True
        Me.txt_numActual.Size = New System.Drawing.Size(78, 20)
        Me.txt_numActual.TabIndex = 34
        Me.txt_numActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_recalcula
        '
        Me.btn_recalcula.Image = Global.RollArt_SQLITE.My.Resources.Resources.refresh_32
        Me.btn_recalcula.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_recalcula.Location = New System.Drawing.Point(10, 414)
        Me.btn_recalcula.Name = "btn_recalcula"
        Me.btn_recalcula.Size = New System.Drawing.Size(75, 50)
        Me.btn_recalcula.TabIndex = 35
        Me.btn_recalcula.Text = "SORTEO"
        Me.btn_recalcula.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_recalcula.UseVisualStyleBackColor = True
        '
        'RollArt_SQLITE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(987, 568)
        Me.Controls.Add(Me.btn_recalcula)
        Me.Controls.Add(Me.txt_numActual)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.num_ParticipantesFinal)
        Me.Controls.Add(Me.btn_ver_participantes)
        Me.Controls.Add(Me.btn_OpenDB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Controls.Add(Me.ButtonSave)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "RollArt_SQLITE"
        Me.Text = "RollArt Base Editor"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEditor.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_ParticipantesFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonSave As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents ContextMenuStripEditor As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents treeEvents As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Label7 As Label
    Friend WithEvents file_dialog As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_ver_participantes As Button
    Friend WithEvents btn_OpenDB As Button
    Friend WithEvents num_ParticipantesFinal As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_numActual As TextBox
    Friend WithEvents btn_recalcula As Button
End Class
