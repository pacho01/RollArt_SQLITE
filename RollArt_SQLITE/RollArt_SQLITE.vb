Imports System.Data.SQLite
Imports System.Runtime.InteropServices


Public Class RollArt_SQLITE
    Dim DB_Path As String
    Dim id_gara As Integer
    Dim TableName As String = "Athletes"
    '*************************************************************************

    Dim IDRam, NameRam, CityRam, Mobile_PhoneRam, EmailRam, GenderRam As String

    'code to make "hint text" in the textbox search
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function


    Private Sub btn_OpenDB_Click_1(sender As Object, e As EventArgs) Handles btn_OpenDB.Click
        leer_Eventos()
    End Sub


    Private Sub btn_ver_participantes_Click(sender As Object, e As EventArgs) Handles btn_ver_participantes.Click
        leer_posiciones_participantes()
    End Sub


    Private Sub treeEvents_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles treeEvents.AfterSelect
        leer_posiciones_participantes()
    End Sub


    Sub leer_Eventos()

        file_dialog.Filter = "DB|*.s3db"
        Dim archivo As String

        If file_dialog.ShowDialog() = DialogResult.OK Then
            archivo = file_dialog.FileName
            DB_Path = "Data Source=" & archivo
        Else
            MsgBox("No se cargo ningun Archivo", vbOKOnly)
            Exit Sub
        End If


        Dim SQLiteCon As New SQLiteConnection(DB_Path)
        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            LoadDB("SELECT DISTINCT G.Name as nombre, G.Place, G.Date, G.ID_GaraParams, S.Name as sname, C.Name as cname  FROM GaraParams G, Specialita S, Category C WHERE G.ID_Specialita = S.ID_Specialita AND G.ID_Category = C.ID_Category", TableDB, SQLiteCon)

            treeEvents.Nodes.Clear()
            treeEvents.BeginUpdate()
            treeEvents.Nodes.Add("Eventos")
            Dim i As Integer = 0
            For Each row As DataRow In TableDB.Rows

                Dim nombre As String = CStr(row("nombre"))
                Dim nombre2 As String = CStr(row("cname"))
                Dim fecha As String = CStr(row("Date"))

                treeEvents.Nodes(0).Nodes.Add(nombre)
                treeEvents.Nodes(0).Nodes(i).Tag = row("ID_GaraParams")
                treeEvents.Nodes(0).Nodes(i).Nodes.Add(nombre2 & " - " & fecha)
                treeEvents.Nodes(0).Nodes(i).Nodes(0).Tag = row("ID_GaraParams")
                i += 1
            Next
            treeEvents.EndUpdate()
            treeEvents.ExpandAll()
            'activar_botones()
        Catch ex As Exception
            MsgBox(ex.Message)
            desactivar_botones()
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

    End Sub


    Sub leer_posiciones_participantes()

        Dim SQLiteCon As New SQLiteConnection(DB_Path)


        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Dim TableDB As New DataTable

        Try
            'Para saber de que evento se leera la lista de numero_participantes_en_sorteo consultamos el TAG del nodo
            'donde se ha depositado el id del gara al cargar los eventos 

            id_gara = treeEvents.SelectedNode.Tag
            'LoadDB("select NumStartingList as Sal, B.Name as nombre , A.ID_Atleta, Societa, Country, B.ID_Specialita, Position from Participants as A, Athletes as B, GaraFinal as G where A.ID_GaraParams = " & id_gara & " AND  A.ID_SEGMENT = G.ID_SEGMENT AND A.ID_GaraParams = G.ID_GaraParams AND A.ID_SEGMENT = 1 AND B.ID_Atleta = G.ID_Atleta AND A.ID_Atleta = B.ID_Atleta ORDER BY Position", TableDB, SQLiteCon)
            LoadDB("select NumStartingList as Sal, B.Name as NOMBRE , Societa as CLUB, Country as PAIS,  Position as Pos, A.ID_Atleta as ID from Participants as A, Athletes as B, GaraFinal as G where A.ID_GaraParams = " & id_gara & " AND  A.ID_SEGMENT = G.ID_SEGMENT AND A.ID_GaraParams = G.ID_GaraParams AND A.ID_SEGMENT = 1 AND B.ID_Atleta = G.ID_Atleta AND A.ID_Atleta = B.ID_Atleta ORDER BY Position", TableDB, SQLiteCon)
            'Contamos el numero de numero_participantes_en_sorteo y se muestra en el cuadro de texto y el selector de numeros

            If TableDB.Rows.Count = 0 Then
                DataGridViewTable.DataSource = Nothing
                txt_numActual.Text = "0"
                desactivar_botones()
                Exit Sub
            End If
            txt_numActual.Text = TableDB.Rows.Count

            If TableDB.Rows.Count < 38 Then
                num_ParticipantesFinal.Maximum = TableDB.Rows.Count
                num_ParticipantesFinal.Minimum = 1
                num_ParticipantesFinal.Value = TableDB.Rows.Count
            Else
                num_ParticipantesFinal.Maximum = 37
                num_ParticipantesFinal.Minimum = 1
                num_ParticipantesFinal.Value = 37
            End If



            'Cargamos TableDB en el gridview y asignamos el ancho de las celdas
            DataGridViewTable.DataSource = Nothing
            DataGridViewTable.DataSource = TableDB
            DataGridViewTable.Columns(0).Width = 30
            DataGridViewTable.Columns(1).Width = 350
            DataGridViewTable.Columns(2).Width = 190
            DataGridViewTable.Columns(3).Width = 50
            DataGridViewTable.Columns(4).Width = 30
            DataGridViewTable.Columns(5).Width = 50
            DataGridViewTable.ClearSelection()
            activar_botones()
        Catch ex As Exception
            MsgBox(ex.Message)
            desactivar_botones()
            'Exit Sub
        End Try



        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing


    End Sub

    Private Sub btn_recalcula_Click(sender As Object, e As EventArgs) Handles btn_recalcula.Click

        Dim numero_participantes_en_sorteo As Integer = num_ParticipantesFinal.Value
        Dim matriz_grupos_sorteo(,) As Integer
        Dim filas_en_tabla As Integer
        Dim celdas_en_fila As Integer

        Dim loop_grupos_de_sorteo_posibles As Integer
        Dim posiciones_acumuladas_de_grupos_ya_sorteados As Integer
        Dim nuevapos As Integer
        Dim color_de_fondo As Color
        Dim diferentes_posActual_Anteriores As Boolean

        If txt_numActual.Text <> num_ParticipantesFinal.Value Then borra_filas_en_tablas()

        For x = 0 To num_ParticipantesFinal.Value - 1
            DataGridViewTable.Rows(x).Cells(4).Value = 0
        Next

        matriz_grupos_sorteo = New Integer(,) {{0, 0, 0, 0, 0, 0},
                                                {1, 0, 0, 0, 0, 0},
                                                {2, 0, 0, 0, 0, 0},
                                                {3, 0, 0, 0, 0, 0},
                                                {2, 2, 0, 0, 0, 0},
                                                {3, 2, 0, 0, 0, 0},
                                                {3, 3, 0, 0, 0, 0},
                                                {4, 3, 0, 0, 0, 0},
                                                {4, 4, 0, 0, 0, 0},
                                                {5, 4, 0, 0, 0, 0},
                                                {5, 5, 0, 0, 0, 0},
                                                {6, 5, 0, 0, 0, 0},
                                                {6, 6, 0, 0, 0, 0},
                                                {5, 4, 4, 0, 0, 0},
                                                {5, 5, 4, 0, 0, 0},
                                                {5, 5, 5, 0, 0, 0},
                                                {6, 5, 5, 0, 0, 0},
                                                {6, 6, 5, 0, 0, 0},
                                                {6, 6, 6, 0, 0, 0},
                                                {5, 5, 5, 4, 0, 0},
                                                {5, 5, 5, 5, 0, 0},
                                                {6, 5, 5, 5, 0, 0},
                                                {6, 6, 5, 5, 0, 0},
                                                {6, 6, 6, 5, 0, 0},
                                                {6, 6, 6, 6, 0, 0},
                                                {5, 5, 5, 5, 5, 0},
                                                {6, 5, 5, 5, 5, 0},
                                                {6, 6, 5, 5, 5, 0},
                                                {6, 6, 6, 5, 5, 0},
                                                {6, 6, 6, 6, 5, 0},
                                                {6, 6, 6, 6, 6, 0},
                                                {7, 6, 6, 6, 6, 0},
                                                {7, 7, 6, 6, 6, 0},
                                                {7, 7, 7, 6, 6, 0},
                                                {7, 7, 7, 7, 6, 0},
                                                {7, 7, 7, 7, 7, 0},
                                                {6, 6, 6, 6, 6, 6},
                                                {7, 6, 6, 6, 6, 6}}



        posiciones_acumuladas_de_grupos_ya_sorteados = 0
        If numero_participantes_en_sorteo < 4 Then
            Select Case num_ParticipantesFinal.Value
                Case 1
                    DataGridViewTable.Rows(0).Cells(4).Value = 1
                Case 2
                    DataGridViewTable.Rows(0).Cells(4).Value = 2
                    DataGridViewTable.Rows(1).Cells(4).Value = 1
                Case 3
                    DataGridViewTable.Rows(0).Cells(4).Value = 3
                    DataGridViewTable.Rows(1).Cells(4).Value = 2
                    DataGridViewTable.Rows(2).Cells(4).Value = 1
            End Select
        Else
            For loop_grupos_de_sorteo_posibles = 0 To 5 'Step -1 'Rotacion por todos los grupos de la matriz
                'Depndiendo del grupo se le asigna un color 
                Select Case loop_grupos_de_sorteo_posibles
                    Case 0
                        color_de_fondo = Color.Coral
                    Case 1
                        color_de_fondo = Color.WhiteSmoke
                    Case 2
                        color_de_fondo = Color.Violet
                    Case 3
                        color_de_fondo = Color.Yellow
                    Case 4
                        color_de_fondo = Color.Turquoise
                    Case 5
                        color_de_fondo = Color.Tomato
                End Select
                If matriz_grupos_sorteo(numero_participantes_en_sorteo, loop_grupos_de_sorteo_posibles) > 0 Then 'Si el grupo de la matriz es cero se salta
                    For filas_en_tabla = 1 To matriz_grupos_sorteo(numero_participantes_en_sorteo, loop_grupos_de_sorteo_posibles) 'Rotacion por cada un ade las filas_en_tablas dentro de cada grupo

                        If filas_en_tabla = 0 Then
                            nuevapos = Int(matriz_grupos_sorteo(numero_participantes_en_sorteo, loop_grupos_de_sorteo_posibles) * Rnd() + 1) + posiciones_acumuladas_de_grupos_ya_sorteados
                        Else
                            diferentes_posActual_Anteriores = False
                            Do Until diferentes_posActual_Anteriores
                                diferentes_posActual_Anteriores = True
                                nuevapos = Int(matriz_grupos_sorteo(numero_participantes_en_sorteo, loop_grupos_de_sorteo_posibles) * Rnd() + 1) + posiciones_acumuladas_de_grupos_ya_sorteados
                                For x = filas_en_tabla To 1 Step -1
                                    If DataGridViewTable.Rows(numero_participantes_en_sorteo - (posiciones_acumuladas_de_grupos_ya_sorteados + x)).Cells(4).Value = nuevapos Then diferentes_posActual_Anteriores = False
                                Next
                            Loop
                        End If
                        DataGridViewTable.Rows(numero_participantes_en_sorteo - (posiciones_acumuladas_de_grupos_ya_sorteados + filas_en_tabla)).Cells(4).Value = nuevapos

                        'solo colorear
                        For celdas_en_fila = 0 To 4 ' rotacion por dentro de cada una de las celdas del la filas_en_tabla
                            DataGridViewTable.Rows(numero_participantes_en_sorteo - (posiciones_acumuladas_de_grupos_ya_sorteados + filas_en_tabla)).Cells(celdas_en_fila).Style.BackColor = color_de_fondo
                        Next


                    Next
                    posiciones_acumuladas_de_grupos_ya_sorteados += matriz_grupos_sorteo(numero_participantes_en_sorteo, loop_grupos_de_sorteo_posibles) 'Se suma el valor de numero_participantes_en_sorteo del grupo recien terminado al posiciones_acumuladas_de_grupos_ya_sorteados de participantes
                End If
            Next
        End If
        ButtonSave.Enabled = True
    End Sub

    Sub borra_filas_en_tablas()
        Dim filas_en_tablaInicio As Integer
        Dim filas_en_tablaFin As Integer

        'filas_en_tablaInicio = txt_numActual.Text
        filas_en_tablaInicio = DataGridViewTable.Rows.Count - 1
        filas_en_tablaFin = num_ParticipantesFinal.Value + 1
        num_ParticipantesFinal.Maximum = num_ParticipantesFinal.Value
        For x = filas_en_tablaInicio To filas_en_tablaFin Step -1

            DataGridViewTable.Rows.Remove(DataGridViewTable.Rows(x - 1))
        Next


    End Sub


    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'If TextBoxID.Text = "" And TextBoxName.Text = "" And TextBoxCity.Text = "" And TextBoxMobilePhone.Text = "" And TextBoxEmail.Text = "" And ComboBoxGender.Text = "- choose gender -" Then
        '    MessageBox.Show("All data has not been filled, please fill in", "Failed")
        '    Return
        'End If

        'If TextBoxID.Text = "" Then
        '    MessageBox.Show("ID has not been filled, please fill in ID", "Failed")
        '    Return
        'End If

        'If TextBoxName.Text = "" Then
        '    MessageBox.Show("Name has not been filled, please fill in Name", "Failed")
        '    Return
        'End If

        'If TextBoxCity.Text = "" Then
        '    MessageBox.Show("City has not been filled, please fill in City", "Failed")
        '    Return
        'End If

        'If TextBoxMobilePhone.Text = "" Then
        '    MessageBox.Show("Mobile Phone has not been filled, please fill in Mobile Phone", "Failed")
        '    Return
        'End If

        'If TextBoxEmail.Text = "" Then
        '    MessageBox.Show("Email has not been filled, please fill in Email", "Failed")
        '    Return
        'End If

        'If ComboBoxGender.Text = "- choose gender -" Then
        '    MessageBox.Show("Gender not selected, please select Gender", "Failed")
        '    Return
        'End If





        '*******************************************************************************
        'Exit Sub
        '*******************************************************************************




        Dim SQLiteCon As New SQLiteConnection(DB_Path)

        Try
            SQLiteCon.Open()
        Catch ex As Exception
            SQLiteCon.Dispose()
            SQLiteCon = Nothing
            MsgBox(ex.Message)
            Exit Sub
        End Try

        Try
            Dim sql_comando As String
            'EjecutaSQL_SinRetorno("insert into " & TableName & " (ID,Name,Mobile_Phone,Email,City,Gender) values ('" & TextBoxID.Text & "','" & TextBoxName.Text _
            '                & "','" & TextBoxMobilePhone.Text & "','" & TextBoxEmail.Text & "','" & TextBoxCity.Text & "','" & ComboBoxGender.Text & "')", SQLiteCon)
            EjecutaSQL_SinRetorno("DELETE FROM Participants WHERE ID_GaraParams = " & id_gara & " AND ID_Segment = 2", SQLiteCon)


            For x_loop = 0 To DataGridViewTable.Rows.Count - 2
                sql_comando = "INSERT INTO Participants VALUES (" & id_gara & ", 2," & DataGridViewTable.Rows(x_loop).Cells(5).Value & "," & DataGridViewTable.Rows(x_loop).Cells(4).Value & ")"
                EjecutaSQL_SinRetorno(sql_comando, SQLiteCon)
            Next
            sql_comando = "UPDATE GaraParams SET Partecipants= " & DataGridViewTable.Rows.Count - 1 & " WHERE ID_Segment = 2 AND ID_GaraParams = " & id_gara
            EjecutaSQL_SinRetorno(sql_comando, SQLiteCon)

            MsgBox("Insert Data successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing

        'ButtonRefresh_Click(sender, e)
        'ButtonClear_Click(sender, e)
    End Sub

    Private Sub RollArt_SQLITE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Width = 1500
        desactivar_botones()

    End Sub

    Private Sub DataGridViewTable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewTable.CellContentClick

    End Sub

    Private Sub num_ParticipantesFinal_ValueChanged(sender As Object, e As EventArgs) Handles num_ParticipantesFinal.ValueChanged

    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        'ButtonDelete_Click(sender, e)
    End Sub


    Private Sub DataGridViewTable_CellMouseDown(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridViewTable.CellMouseDown
        If AllCellsSelected(DataGridViewTable) = False Then
            If e.Button = MouseButtons.Right Then
                DataGridViewTable.CurrentCell = DataGridViewTable(e.ColumnIndex, e.RowIndex)
                Dim i As Integer
                With DataGridViewTable
                    If e.RowIndex >= 0 Then
                        i = .CurrentRow.Index

                        'IDRam = .Rows(i).Cells("ID").Value.ToString
                        'NameRam = .Rows(i).Cells("Name").Value.ToString
                        'CityRam = .Rows(i).Cells("City").Value.ToString
                        'Mobile_PhoneRam = .Rows(i).Cells("Mobile_Phone").Value.ToString
                        'EmailRam = .Rows(i).Cells("Email").Value.ToString
                        'GenderRam = .Rows(i).Cells("Gender").Value.ToString

                        IDRam = .Rows(i).Cells("ID_Atleta").Value.ToString
                        NameRam = .Rows(i).Cells("Name").Value.ToString
                        CityRam = .Rows(i).Cells("Country").Value.ToString
                        Mobile_PhoneRam = .Rows(i).Cells("ID_Specialita").Value.ToString
                        EmailRam = .Rows(i).Cells("Region").Value
                        GenderRam = .Rows(i).Cells("Societa").Value.ToString
                    End If
                End With
            End If
        End If
    End Sub


    'Sub to read the database
    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

    'Sub to write to the database
    Private Sub EjecutaSQL_SinRetorno(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub

    'Function to detect datagridview is selected all
    Private Function AllCellsSelected(dgv As DataGridView) As Boolean
        AllCellsSelected = (DataGridViewTable.SelectedCells.Count = (DataGridViewTable.RowCount * DataGridViewTable.Columns.GetColumnCount(DataGridViewElementStates.Visible)))
    End Function

    Sub activar_botones()
        ButtonSave.Enabled = False
        btn_recalcula.Enabled = True
        btn_ver_participantes.Enabled = True
        num_ParticipantesFinal.Enabled = True
    End Sub

    Sub desactivar_botones()
        ButtonSave.Enabled = False
        btn_recalcula.Enabled = False
        btn_ver_participantes.Enabled = False
        num_ParticipantesFinal.Enabled = False

    End Sub
End Class