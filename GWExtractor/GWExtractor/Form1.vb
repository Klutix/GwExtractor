Imports SHDocVw
Imports NDde.Client
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.IO
Imports Microsoft.Office.Interop

Public Class GWXtractor
    
   
    Dim mExcelApp As Excel.Application
    Dim mExcelWB As Excel.Workbook
    Dim mExcelWS As Excel.Worksheet

    

    '=========================FIREFOX=================================
    'For firefox ; Download the library from http://ndde.codeplex.com/ 
    Public Shared Function GetFirefoxUrl() As String
        Dim dde As New DdeClient("Firefox", "WWW_GetWindowInfo")
        dde.Connect()
        Dim url() As String = Split(dde.Request("URL", Integer.MaxValue), ",")
        dde.Disconnect()
        Return url(0).Replace("""", "")
    End Function

    Private Sub BtnGrab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGrab.Click
        txtUrl.Text = (GetFirefoxUrl())
        RichTextBox1.Text = getPageSource(txtUrl.Text)
        mstrSourceCode = RichTextBox1.Text
        Parse_Source()
    End Sub

    Function getPageSource(ByVal url As String) As String

        Dim sourcecode As String = ""

        Try

            Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(url)
            Dim response As System.Net.HttpWebResponse = request.GetResponse()
            Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

            sourcecode = sr.ReadToEnd()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return sourcecode

    End Function
    ' for 'Internet explorer'
    Public Function getAllRunningIEURLs()
        Try
            Dim list As New ListBox
            For Each browser As InternetExplorer In New ShellWindows()
                txtUrl.Text = browser.LocationURL.ToString
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

    Private Sub GWXtractor_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Disposed
        mExcelApp.Quit()

        mExcelApp = Nothing
        mExcelWB = Nothing
        mExcelWS = Nothing
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Function Parse_Source()
        Dim strTitle As String = ""
        Dim strSKU As String = ""
        Dim strUPC As String = ""
        Dim strDescription As String = ""
        Dim strMPN As String = ""
        Dim strPrice As String = ""
        Dim strMPrice As String = ""

        Dim strLine As String = ""

        Dim lngcntBail As Long = 0

        Dim strRemainingString As String


        Try
            Using sr As StringReader = New StringReader(mstrSourceCode)
                Do Until lngcntBail = 10
                    strLine = sr.ReadLine

                    'check if we have reached the end
                    If (strLine = "") Then
                        lngcntBail += 1
                    Else
                        lngcntBail = 0
                    End If

                    If (strLine Is Nothing = False) Then

                        'grab Title
                        If (strLine.Contains("og:title")) Then

                            'Grabs the begging of all relavent into variable so for a cleaner starting point
                            strRemainingString = strLine.Substring(InStr(strLine, "og:title") + 18)

                            'Remove the irrelavent data
                            strTitle = strRemainingString.Substring(0, strRemainingString.IndexOf(""""))
                            txtTitle.Text = strTitle
                        End If

                        'grab Description

                        'grab SKU

                        'grab UPC
                        If (strLine.Contains("gtin13")) Then
                            'Grabs the begging of all relavent into variable so for a cleaner starting point
                            strRemainingString = strLine.Substring(InStr(strLine, "gtin13") + 7)

                            'Remove the irrelavent data
                            strUPC = strRemainingString.Substring(0, strRemainingString.IndexOf("<"))
                            txtUPC.Text = strUPC
                        End If

                        'grab MPN 
                        If (strLine.Contains("""mpn""")) Then
                            'Grabs the begging of all relavent into variable so for a cleaner starting point
                            strRemainingString = strLine.Substring(InStr(strLine, """mpn""") + 5)

                            'Remove the irrelavent data
                            strMPN = strRemainingString.Substring(0, strRemainingString.IndexOf("<"))
                            txtMPN.Text = strMPN
                        End If



                        'grab Price
                        If (strLine.Contains("""prcIsum""")) Then
                            'Grabs the begging of all relavent into variable so for a cleaner starting point
                            strRemainingString = strLine.Substring(InStr(strLine, ">US") + 3)

                            'Remove the irrelavent data
                            strPrice = strRemainingString.Substring(0, strRemainingString.IndexOf("<"))
                            txtPrice.Text = strPrice
                        End If

                        'grap Mprice
                    End If

                Loop
                Write_Excel(strTitle, strPrice, strDescription, strUPC, strSKU, strMPN, strMPrice, txtUrl.Text)

                mExcelApp = Nothing
                mExcelWB = Nothing
                mExcelWS = Nothing
            End Using

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try



    End Function

    Private Function Write_Excel(ByVal strTitle As String, ByVal strPrice As String, Optional ByVal strDescription As String = "", Optional ByVal strUPC As String = "", Optional ByVal strSKU As String = "", Optional ByVal strMPN As String = "", Optional ByVal strMPrice As String = "", Optional ByVal strURL As String = "") As Boolean
        Try
            Dim lngRow As Long


            If (mExcelApp Is Nothing) Then
                Create_ExcelFile(txtSelectedFile.Text)
            End If

            lngRow = Return_RowCnt()
            mExcelWS.Cells(lngRow, 1) = strTitle
            mExcelWS.Cells(lngRow, 2) = strDescription
            mExcelWS.Cells(lngRow, 3) = "&" & strUPC
            mExcelWS.Cells(lngRow, 4) = strSKU
            mExcelWS.Cells(lngRow, 5) = strMPN
            mExcelWS.Cells(lngRow, 6) = strPrice
            mExcelWS.Cells(lngRow, 7) = strMPrice
            mExcelWS.Cells(lngRow, 8) = strURL

            mExcelWB.SaveAs(txtSelectedFile.Text)
            mExcelApp.Quit()

            mExcelApp = Nothing
            mExcelWB = Nothing
            mExcelWS = Nothing

        Catch ex As Exception
            MsgBox(ex.Message & vbNewLine & ex.StackTrace)
        End Try


    End Function

    'Creates Initial Excel File if none has been selected
    Private Function Create_ExcelFile(Optional ByRef strFullPathName = "")

        Try
            Dim lngRow As Long = 1

            mExcelApp = New Excel.Application

            If (mExcelApp Is Nothing) Then
                MsgBox("Excel not Property Installed")
                Return False
                Exit Function
            End If

            mExcelWB = mExcelApp.Workbooks.Add
            mExcelWS = mExcelWB.Worksheets.Add

            mExcelWS.Cells(lngRow, 1) = "Title"
            mExcelWS.Cells(lngRow, 2) = "Description"
            mExcelWS.Cells(lngRow, 3) = "UPC"
            mExcelWS.Cells(lngRow, 4) = "SKU"
            mExcelWS.Cells(lngRow, 5) = "MPN"
            mExcelWS.Cells(lngRow, 6) = "Price"
            mExcelWS.Cells(lngRow, 7) = "MPrice"
            mExcelWS.Cells(lngRow, 8) = "URL"

            If (strFullPathName = "") Then strFullPathName = CurDir() & "\ProductInfo.xls"

            txtSelectedFile.Text = strFullPathName

        Catch ex As Exception

        End Try

    End Function

    Private Sub LblCurrentFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblCurrentFile.Click
        FolderBrowserDialog1.ShowDialog()
        'FolderBrowserDialog1.SelectedPath = CurDir() & "\exceldump.xls"
        mstrFilePath = FolderBrowserDialog1.SelectedPath
        txtSelectedFile.Text = mstrFilePath & "\ProductInfo.xls"
    End Sub

    Private Function Return_RowCnt()
        Dim lngrow As Long = 1

        Do Until String.IsNullOrEmpty(mExcelWS.Cells(lngrow, 1).value)
            lngrow += 1
        Loop

        Return lngrow

    End Function
End Class



