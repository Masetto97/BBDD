Module MetodosComunes
    'Estilo a utilizar en la tablas
    Sub estilodgvArt(ByVal dgv As DataGridView)

        dgv.ReadOnly = True
        dgv.AllowUserToAddRows = False ' para que la ultima fila no se muestre en blanco
        dgv.ColumnHeadersVisible = True ' para que se muestre el titulo de la columna
        dgv.RowHeadersVisible = False ' para que no se muestre la columna vacia de cada fila


        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each c As DataGridViewColumn In dgv.Columns
            c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next

        With (dgv)
            .RowsDefaultCellStyle.BackColor = Color.White
            .AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke
        End With
        'Seleccion de la fuente y tamaño de la letra, junto con el color de esta
        With dgv.DefaultCellStyle
            .Font = New Font("Tahoma", 9)
            .ForeColor = Color.Black
            .BackColor = Color.Beige
            .SelectionForeColor = Color.Black
            .SelectionBackColor = Color.LightBlue
        End With

    End Sub
    'Funcion para saber si la pila esta vacia 
    Public Function IsDataGridViewEmpty(ByRef dataGridView As DataGridView) As Boolean
        Dim vacio As Boolean
        vacio = True
        For Each row As DataGridViewRow In dataGridView.Rows
            For Each cell As DataGridViewCell In row.Cells
                If Not String.IsNullOrEmpty(cell.Value) Then
                    If Not String.IsNullOrEmpty(Trim(cell.Value.ToString())) Then
                        vacio = False
                        Exit For
                    End If
                End If
            Next
        Next
        Return vacio
    End Function
End Module
