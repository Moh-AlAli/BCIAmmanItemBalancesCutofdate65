Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows.Forms
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text
Public Class crviewer
    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Dim server As String = ""
    Dim uid As String = ""
    Dim pass As String = ""
    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function
    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\bcicon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()


        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)

        Dim cons As String = "" ' = "Data Source =" & server & "; DataBase =" & Agescreen.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub crviewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim cwvr As New CrystalReportViewer
            cwvr.Dock = DockStyle.Fill
            cwvr.BorderStyle = BorderStyle.None
            Me.Controls.Add(cwvr)
          
       
            rdoc.Load("reports\ICItemQtyBalancesDetailed.rpt")
  
            Dim tabs As Tables = rdoc.Database.Tables
            Dim parv As New ParameterValues
            Dim dis As New ParameterDiscreteValue

        
            Dim fmonthnew As String = 0
            If Frmitmbal.DTPupdate.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & Frmitmbal.DTPupdate.Value.Month
            Else
                fmonthnew = Frmitmbal.DTPupdate.Value.Month
            End If
            Dim fdaynew As String = 0
            If Frmitmbal.DTPupdate.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & Frmitmbal.DTPupdate.Value.Day
            Else
                fdaynew = Frmitmbal.DTPupdate.Value.Day
            End If
            Dim fdate As String = Frmitmbal.DTPupdate.Value.Year & fmonthnew & fdaynew


            Readconnectionstring()



            For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs
                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = server '"ACCPAC62" '
                conrpt.DatabaseName = Frmitmbal.compid
                conrpt.UserID = uid '"sa" ' 
                conrpt.Password = pass ' "admin@123" '
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)
            Next

           
            rdoc.SetParameterValue("TransDate", fdate)
            rdoc.SetParameterValue("cutdate", fdate)
            rdoc.SetParameterValue("qtycutdate", fdate)
            rdoc.SetParameterValue("Fromitem", Frmitmbal.Txtfrmitem.Text)
            rdoc.SetParameterValue("Toitem", Frmitmbal.Txttoitem.Text)

            rdoc.SetParameterValue("FromCategory", Frmitmbal.Txtfrmcat.Text)
            rdoc.SetParameterValue("ToCategory", Frmitmbal.Txttocat.Text)

            rdoc.SetParameterValue("FromLoc", Frmitmbal.Txtfrmloc.Text)
            rdoc.SetParameterValue("ToLoc", Frmitmbal.Txttoloc.Text)
            rdoc.SetParameterValue("DB", Frmitmbal.compid)
            rdoc.SetParameterValue("Coname", Frmitmbal.compname)

            cwvr.ReportSource = rdoc

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try
    End Sub
End Class