Imports AccpacCOMAPI
Public Class Frmitmbal

    Public compid As String = ""
    Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    Public mSession As New AccpacCOMAPI.AccpacSession
    Public compname As String
    Public xdbcom As AccpacDBLink


    Private Sub Frmitmbal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            mSession.Init("", "XX", "XX0001", "65A")
            acsignon.Signon(mSession)
            compid = mSession.CompanyID
            compname = mSession.CompanyName

            xdbcom = mSession.GetDBLink(tagDBLinkTypeEnum.DBLINK_COMPANY, tagDBLinkFlagsEnum.DBLINK_FLG_READONLY)

            If compid = "" Then
                Close()
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Butexit.Click
        Close()
    End Sub

    Private Sub Butprint_Click(sender As Object, e As EventArgs) Handles Butprint.Click
        Try

            If Trim(Txtfrmloc.Text) <= Trim(Txttoloc.Text) Then
                If Trim(Txtfrmcat.Text) <= Trim(Txttocat.Text) Then
                    If Trim(Txtfrmitem.Text) <= Trim(Txttoitem.Text) Then
                        crviewer.Show()
                    Else
                        MessageBox.Show("From Item  greater than To Item ")
                    End If
                Else
                    MessageBox.Show("From Catgory  greater than To Category ")
                End If
            Else
                MessageBox.Show("From Location  greater than To Location ")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub bfdloc_Click(sender As Object, e As EventArgs) Handles bfdloc.Click
        bfdloc.Enabled = False
        FromLocation.Show()
    End Sub

    Private Sub btdloc_Click(sender As Object, e As EventArgs) Handles btdloc.Click
        btdloc.Enabled = False
        ToLocation.Show()
    End Sub

    Private Sub Bfdcat_Click(sender As Object, e As EventArgs) Handles Bfdcat.Click
        Bfdcat.Enabled = False
        FromCategory.Show()
    End Sub

    Private Sub Btdcat_Click(sender As Object, e As EventArgs) Handles Btdcat.Click
        Btdcat.Enabled = False
        ToCategory.Show()
    End Sub

    Private Sub Bfdit_Click(sender As Object, e As EventArgs) Handles Bfdit.Click
        Bfdit.Enabled = False
        FromItem.Show()
    End Sub

    Private Sub Btdit_Click(sender As Object, e As EventArgs) Handles Btdit.Click
        Btdit.Enabled = True
        ToItem.Show()
    End Sub
End Class
