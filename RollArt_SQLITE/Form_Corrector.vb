Imports System.Data.SQLite

Public Class Form_Corrector
    Public caminoDB As String
    Public competicion As Integer

    Private Sub Btn_CERRAR_Click(sender As Object, e As EventArgs) Handles Btn_CERRAR.Click
        RollArt_SQLITE.Visible = True
        Me.Close()
    End Sub

    Private Sub Form_Corrector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Cursor = System.Windows.Forms.Cursors.Arrow
        MsgBox("Datos" & caminoDB & vbCrLf & competicion, MsgBoxStyle.DefaultButton1, "Datos")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SQLiteCon As New SQLiteConnection(caminoDB)
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
            EjecutaSQL_SinRetorno("SELECT FROM Participants WHERE ID_GaraParams = " & competicion, SQLiteCon)


            'Moddificado para que guarde los participantes por orden de salida

            'For x_loop = 0 To DataGridViewTable.Rows.Count - 2
            '    sql_comando = "INSERT INTO Participants VALUES (" & id_gara & ", 2," & DataGridViewTable.Rows(x_loop).Cells(5).Value & "," & DataGridViewTable.Rows(x_loop).Cells(4).Value & ")"
            '    EjecutaSQL_SinRetorno(sql_comando, SQLiteCon)
            'Next


            'For loop_orden_salida = 1 To DataGridViewTable.RowCount - 1
            ' For loop_celdas = 0 To DataGridViewTable.RowCount - 2
            ' If DataGridViewTable.Rows(loop_celdas).Cells(4).Value = loop_orden_salida Then
            ' sql_comando = "INSERT INTO Participants VALUES (" & id_gara & ", 2," & DataGridViewTable.Rows(loop_celdas).Cells(5).Value & "," & DataGridViewTable.Rows(loop_celdas).Cells(4).Value & ")"
            ' EjecutaSQL_SinRetorno(sql_comando, SQLiteCon)
            ' End If
            ' Next
            ' Next

            'sql_comando = "UPDATE GaraParams SET Partecipants= " & DataGridViewTable.Rows.Count - 1 & " WHERE ID_Segment = 2 AND ID_GaraParams = " & id_gara
            'EjecutaSQL_SinRetorno(sql_comando, SQLiteCon)

            MsgBox("Insert Data successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub


    Private Sub EjecutaSQL_SinRetorno(ByVal query As String, ByVal cn As SQLiteConnection)
        Dim SQLiteCM As New SQLiteCommand(query, cn)
        SQLiteCM.ExecuteNonQuery()
        SQLiteCM.Dispose()
        SQLiteCM = Nothing
    End Sub


    Private Sub leerTabla()
        Dim SQLiteCon As New SQLiteConnection(caminoDB)
        Dim id_gara As Integer
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

            id_gara = competicion
            'LoadDB("select NumStartingList as Sal, B.Name as nombre , A.ID_Atleta, Societa, Country, B.ID_Specialita, Position from Participants as A, Athletes as B, GaraFinal as G where A.ID_GaraParams = " & id_gara & " AND  A.ID_SEGMENT = G.ID_SEGMENT AND A.ID_GaraParams = G.ID_GaraParams AND A.ID_SEGMENT = 1 AND B.ID_Atleta = G.ID_Atleta AND A.ID_Atleta = B.ID_Atleta ORDER BY Position", TableDB, SQLiteCon)
            LoadDB("select NumStartingList as Sal, B.Name as NOMBRE , Societa as CLUB, Country as PAIS,  Position as Pos, A.ID_Atleta as ID from Participants as A, Athletes as B, GaraFinal as G where A.ID_GaraParams = " & id_gara & " AND  A.ID_SEGMENT = G.ID_SEGMENT AND A.ID_GaraParams = G.ID_GaraParams AND A.ID_SEGMENT = 1 AND B.ID_Atleta = G.ID_Atleta AND A.ID_Atleta = B.ID_Atleta ORDER BY Position", TableDB, SQLiteCon)
            'Contamos el numero de numero_participantes_en_sorteo y se muestra en el cuadro de texto y el selector de numeros

            If TableDB.Rows.Count = 0 Then
                'DataGridViewTable.DataSource = Nothing
                'txt_numActual.Text = "0"
                'desactivar_botones()
                Exit Sub
            End If
            'txt_numActual.Text = TableDB.Rows.Count

            If TableDB.Rows.Count < 38 Then
                'num_ParticipantesFinal.Maximum = TableDB.Rows.Count
                'num_ParticipantesFinal.Minimum = 1
                'num_ParticipantesFinal.Value = TableDB.Rows.Count
            Else
                'num_ParticipantesFinal.Maximum = 37
                'num_ParticipantesFinal.Minimum = 1
                'num_ParticipantesFinal.Value = 37
            End If

            'Cargamos TableDB en el gridview y asignamos el ancho de las celdas
            'DataGridViewTable.DataSource = Nothing
            'DataGridViewTable.DataSource = TableDB
            'DataGridViewTable.Columns(0).Width = 30
            'DataGridViewTable.Columns(1).Width = 350
            'DataGridViewTable.Columns(2).Width = 190
            'DataGridViewTable.Columns(3).Width = 50
            'DataGridViewTable.Columns(4).Width = 30
            'DataGridViewTable.Columns(5).Width = 50
            'DataGridViewTable.ClearSelection()
            'activar_botones()
        Catch ex As Exception
            MsgBox(ex.Message)
            'desactivar_botones()
            'Exit Sub
        End Try

        TableDB.Dispose()
        TableDB = Nothing
        SQLiteCon.Close()
        SQLiteCon.Dispose()
        SQLiteCon = Nothing
    End Sub

    Private Sub LoadDB(ByVal q As String, ByVal tbl As DataTable, ByVal cn As SQLiteConnection)
        Dim SQLiteDA As New SQLiteDataAdapter(q, cn)
        SQLiteDA.Fill(tbl)
        SQLiteDA.Dispose()
        SQLiteDA = Nothing
    End Sub

End Class