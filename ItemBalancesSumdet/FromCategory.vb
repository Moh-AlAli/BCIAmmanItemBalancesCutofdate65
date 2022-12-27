Imports AccpacCOMAPI
Public Class FromCategory
    Private i As Integer
    Private j As Integer
    Private Sub FromCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'os.Init("", "XX", "XX0001", "60A")
            'os.OpenWin("", "", "", Frmitmbal.compid, System.DateTime.Now, 0)
            ''os.Open("ADMIN", "ADMIN", Frmitmbal.compid, System.DateTime.Now, 0)
            'dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)


            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim ICCATds As DataSet = New DataSet("IC")
            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim name As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim id As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "CATEGORY"
            icl.Name = "clidc"
            icl.HeaderText = "Category"
            icl.Width = 150
            DGfcus.Columns.Add(icl)
            Dim ncl As New DataGridViewTextBoxColumn
            ncl.DataPropertyName = "DESC"
            ncl.Name = "colnc"
            ncl.HeaderText = "Description"
            ncl.Width = 190
            DGfcus.Columns.Add(ncl)
            DGfcus.DataSource = ICCATds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try


            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim searfil As String = ""

            If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
                searfil = "DESC like %" + Txtname.Text + "%"" "
            ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim ICCATds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = ICCATds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Frmitmbal.txtfrmcat.Text = dt.Rows(i)(0)
            Frmitmbal.bfdcat.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        Close()
        Frmitmbal.bfdcat.Enabled = True
    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcat.MouseLeave




        Dim arv As AccpacView
        arv = Frmitmbal.xdbcom.OpenView2("IC0210")
        Dim searfil As String = ""
        If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
            searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
        ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
            searfil = "DESC like %" + Txtname.Text + "%"" "
        ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
            searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
        End If

        arv.Browse(searfil, True)


        Dim ICCATds As DataSet = New DataSet("IC")

        Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
        Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
        Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
        cust.PrimaryKey = New DataColumn() {id}
        Dim row As DataRow
        row = cust.NewRow()

        Do While arv.FilterFetch(False)

            Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
            Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
            row("CATEGORY") = cid
            row("DESC") = cn
            ICCATds.Tables(0).Rows.Add(row)
            row = cust.NewRow()

        Loop


        DGfcus.DataSource = ICCATds.Tables(0)

    End Sub

    Private Sub Txtname_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.MouseLeave
        Try


            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim searfil As String = ""

            If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
                searfil = "DESC like %" + Txtname.Text + "%"" "
            ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim ICCATds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICCATds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcat.TextChanged
        Try

            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim searfil As String = ""
            If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
                searfil = "DESC like %" + Txtname.Text + "%"" "
            ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim ICCATds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICCATds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.TextChanged
        Try



            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim searfil As String = ""

            If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
                searfil = "DESC like %" + Txtname.Text + "%"" "
            ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim ICCATds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = ICCATds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
        Try

            Dim arv As AccpacView
            arv = Frmitmbal.xdbcom.OpenView2("IC0210")
            Dim searfil As String = ""
            If Txtcat.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "DESC Like ""%" + Txtname.Text + "%"" and CATEGORY like ""%" + Txtcat.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcat.Text = Nothing Then
                searfil = "DESC like %" + Txtname.Text + "%"" "
            ElseIf Txtcat.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "CATEGORY like ""%" + Txtcat.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim ICCATds As DataSet = New DataSet("IC")

            Dim cust As DataTable = ICCATds.Tables.Add("ICCAT")
            Dim id As DataColumn = cust.Columns.Add("CATEGORY", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("DESC", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("CATEGORY").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("DESC").Value.ToString()
                row("CATEGORY") = cid
                row("DESC") = cn
                ICCATds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = ICCATds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            Frmitmbal.txtfrmcat.Text = dt.Rows(i)(0)
            Frmitmbal.bfdcat.Enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Fromcust_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Frmitmbal.bfdcat.Enabled = True
    End Sub
End Class