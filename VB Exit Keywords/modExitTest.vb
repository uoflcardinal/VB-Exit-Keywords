
Imports System.Windows.Forms

Module modExitTest

    Sub Main()
        Dim output As String
        Dim counter As Integer

        For counter = 1 To 10

            'skip remaining code in loop only if counter = 3
            If counter = 3 Then
                Exit For
            End If
        Next

        output = "counter = " & counter &
            " after exiting For/Next structure" & vbCrLf

        Do Until counter > 10

            'skip remaining code in loop only if counter = 5
            If counter = 5 Then
                Exit Do
            End If
            counter += 1
        Loop

        output &= "counter = " & counter &
            " after exiting Do Until/Loop structure" & vbCrLf

        While counter <= 10

            'skip remaining code in loop only if counter = 7
            If counter = 7 Then
                Exit While
            End If

            counter += 1
        End While

        output &= "counter = " & counter &
            " after exiting While structure"

        MessageBox.Show(output, "Exit Test",
              MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Module
