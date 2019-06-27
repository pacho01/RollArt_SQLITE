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
        Me.TextBoxSearch = New System.Windows.Forms.TextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonRefresh = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.DataGridViewTable = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripEditor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ComboBoxGender = New System.Windows.Forms.ComboBox()
        Me.ButtonMakeId = New System.Windows.Forms.Button()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxMobilePhone = New System.Windows.Forms.TextBox()
        Me.TextBoxCity = New System.Windows.Forms.TextBox()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBoxSearchbyName = New System.Windows.Forms.CheckBox()
        Me.CheckBoxSearchbyID = New System.Windows.Forms.CheckBox()
        Me.Panel_Tabla = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.treeEvents = New System.Windows.Forms.TreeView()
        Me.btn_OpenDB = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripEditor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxSearch
        '
        Me.TextBoxSearch.Location = New System.Drawing.Point(215, 576)
        Me.TextBoxSearch.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxSearch.Name = "TextBoxSearch"
        Me.TextBoxSearch.Size = New System.Drawing.Size(347, 20)
        Me.TextBoxSearch.TabIndex = 11
        '
        'ButtonClear
        '
        Me.ButtonClear.Image = Global.RollArt_SQLITE.My.Resources.Resources.clear_32
        Me.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonClear.Location = New System.Drawing.Point(341, 83)
        Me.ButtonClear.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(82, 40)
        Me.ButtonClear.TabIndex = 13
        Me.ButtonClear.Text = "Limpiar"
        Me.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonDelete.Image = Global.RollArt_SQLITE.My.Resources.Resources.papelera_32
        Me.ButtonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonDelete.Location = New System.Drawing.Point(12, 553)
        Me.ButtonDelete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(94, 43)
        Me.ButtonDelete.TabIndex = 14
        Me.ButtonDelete.Text = "Borrar"
        Me.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonRefresh
        '
        Me.ButtonRefresh.Image = Global.RollArt_SQLITE.My.Resources.Resources.refresh_32
        Me.ButtonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRefresh.Location = New System.Drawing.Point(110, 553)
        Me.ButtonRefresh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonRefresh.Name = "ButtonRefresh"
        Me.ButtonRefresh.Size = New System.Drawing.Size(94, 43)
        Me.ButtonRefresh.TabIndex = 15
        Me.ButtonRefresh.Text = "Refrescar"
        Me.ButtonRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonRefresh.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Image = Global.RollArt_SQLITE.My.Resources.Resources.editar_32
        Me.ButtonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUpdate.Location = New System.Drawing.Point(566, 555)
        Me.ButtonUpdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(94, 43)
        Me.ButtonUpdate.TabIndex = 16
        Me.ButtonUpdate.Text = "Actualizar"
        Me.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonSave.Image = Global.RollArt_SQLITE.My.Resources.Resources.guardar_32
        Me.ButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSave.Location = New System.Drawing.Point(664, 553)
        Me.ButtonSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ButtonSave.Size = New System.Drawing.Size(94, 43)
        Me.ButtonSave.TabIndex = 17
        Me.ButtonSave.Text = "Guardar"
        Me.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'DataGridViewTable
        '
        Me.DataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewTable.ContextMenuStrip = Me.ContextMenuStripEditor
        Me.DataGridViewTable.Location = New System.Drawing.Point(762, 12)
        Me.DataGridViewTable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridViewTable.Name = "DataGridViewTable"
        Me.DataGridViewTable.RowTemplate.Height = 31
        Me.DataGridViewTable.Size = New System.Drawing.Size(107, 118)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBoxGender)
        Me.GroupBox1.Controls.Add(Me.ButtonMakeId)
        Me.GroupBox1.Controls.Add(Me.TextBoxEmail)
        Me.GroupBox1.Controls.Add(Me.TextBoxMobilePhone)
        Me.GroupBox1.Controls.Add(Me.TextBoxCity)
        Me.GroupBox1.Controls.Add(Me.TextBoxName)
        Me.GroupBox1.Controls.Add(Me.TextBoxID)
        Me.GroupBox1.Controls.Add(Me.ButtonClear)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 392)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(746, 152)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'ComboBoxGender
        '
        Me.ComboBoxGender.FormattingEnabled = True
        Me.ComboBoxGender.Items.AddRange(New Object() {"Masculino", "Femenino"})
        Me.ComboBoxGender.Location = New System.Drawing.Point(504, 112)
        Me.ComboBoxGender.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBoxGender.Name = "ComboBoxGender"
        Me.ComboBoxGender.Size = New System.Drawing.Size(231, 21)
        Me.ComboBoxGender.TabIndex = 31
        '
        'ButtonMakeId
        '
        Me.ButtonMakeId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonMakeId.Image = Global.RollArt_SQLITE.My.Resources.Resources.tarjeta_32
        Me.ButtonMakeId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonMakeId.Location = New System.Drawing.Point(258, 34)
        Me.ButtonMakeId.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ButtonMakeId.Name = "ButtonMakeId"
        Me.ButtonMakeId.Size = New System.Drawing.Size(74, 22)
        Me.ButtonMakeId.TabIndex = 30
        Me.ButtonMakeId.Text = "New ID"
        Me.ButtonMakeId.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ButtonMakeId.UseVisualStyleBackColor = True
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(504, 74)
        Me.TextBoxEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxEmail.TabIndex = 29
        '
        'TextBoxMobilePhone
        '
        Me.TextBoxMobilePhone.Location = New System.Drawing.Point(504, 34)
        Me.TextBoxMobilePhone.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxMobilePhone.Name = "TextBoxMobilePhone"
        Me.TextBoxMobilePhone.Size = New System.Drawing.Size(231, 20)
        Me.TextBoxMobilePhone.TabIndex = 28
        '
        'TextBoxCity
        '
        Me.TextBoxCity.Location = New System.Drawing.Point(68, 115)
        Me.TextBoxCity.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxCity.Name = "TextBoxCity"
        Me.TextBoxCity.Size = New System.Drawing.Size(264, 20)
        Me.TextBoxCity.TabIndex = 27
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(68, 76)
        Me.TextBoxName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(264, 20)
        Me.TextBoxName.TabIndex = 26
        '
        'TextBoxID
        '
        Me.TextBoxID.Location = New System.Drawing.Point(68, 36)
        Me.TextBoxID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBoxID.Name = "TextBoxID"
        Me.TextBoxID.Size = New System.Drawing.Size(186, 20)
        Me.TextBoxID.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(443, 122)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Genero"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(443, 83)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Correo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(443, 43)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Ciudad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 83)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'CheckBoxSearchbyName
        '
        Me.CheckBoxSearchbyName.AutoSize = True
        Me.CheckBoxSearchbyName.Checked = True
        Me.CheckBoxSearchbyName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxSearchbyName.Location = New System.Drawing.Point(217, 553)
        Me.CheckBoxSearchbyName.Name = "CheckBoxSearchbyName"
        Me.CheckBoxSearchbyName.Size = New System.Drawing.Size(127, 17)
        Me.CheckBoxSearchbyName.TabIndex = 23
        Me.CheckBoxSearchbyName.Text = "Buscar por NOMBRE"
        Me.CheckBoxSearchbyName.UseVisualStyleBackColor = True
        '
        'CheckBoxSearchbyID
        '
        Me.CheckBoxSearchbyID.AutoSize = True
        Me.CheckBoxSearchbyID.Location = New System.Drawing.Point(470, 553)
        Me.CheckBoxSearchbyID.Name = "CheckBoxSearchbyID"
        Me.CheckBoxSearchbyID.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxSearchbyID.TabIndex = 24
        Me.CheckBoxSearchbyID.Text = "Buscar por ID"
        Me.CheckBoxSearchbyID.UseVisualStyleBackColor = True
        '
        'Panel_Tabla
        '
        Me.Panel_Tabla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_Tabla.Location = New System.Drawing.Point(12, 171)
        Me.Panel_Tabla.Name = "Panel_Tabla"
        Me.Panel_Tabla.Size = New System.Drawing.Size(745, 215)
        Me.Panel_Tabla.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btn_OpenDB)
        Me.Panel1.Controls.Add(Me.treeEvents)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(745, 153)
        Me.Panel1.TabIndex = 26
        '
        'treeEvents
        '
        Me.treeEvents.Location = New System.Drawing.Point(4, 4)
        Me.treeEvents.Name = "treeEvents"
        Me.treeEvents.Size = New System.Drawing.Size(555, 146)
        Me.treeEvents.TabIndex = 0
        '
        'btn_OpenDB
        '
        Me.btn_OpenDB.Location = New System.Drawing.Point(604, 14)
        Me.btn_OpenDB.Name = "btn_OpenDB"
        Me.btn_OpenDB.Size = New System.Drawing.Size(109, 26)
        Me.btn_OpenDB.TabIndex = 1
        Me.btn_OpenDB.Text = "Open DB"
        Me.btn_OpenDB.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(604, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 26)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'RollArt_SQLITE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 401)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel_Tabla)
        Me.Controls.Add(Me.CheckBoxSearchbyID)
        Me.Controls.Add(Me.CheckBoxSearchbyName)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridViewTable)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRefresh)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.TextBoxSearch)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "RollArt_SQLITE"
        Me.Text = "RollArt Base Editor"
        CType(Me.DataGridViewTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripEditor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxSearch As TextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonRefresh As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonSave As Button
    Friend WithEvents DataGridViewTable As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ComboBoxGender As ComboBox
    Friend WithEvents ButtonMakeId As Button
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxMobilePhone As TextBox
    Friend WithEvents TextBoxCity As TextBox
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBoxSearchbyName As CheckBox
    Friend WithEvents CheckBoxSearchbyID As CheckBox
    Friend WithEvents ContextMenuStripEditor As ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel_Tabla As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_OpenDB As Button
    Friend WithEvents treeEvents As TreeView
    Friend WithEvents ImageList1 As ImageList
End Class
