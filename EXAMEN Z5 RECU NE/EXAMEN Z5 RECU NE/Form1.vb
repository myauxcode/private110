Public Class Form1

    'ejercicio 1

    Public Function ejercicio1(n As Integer) As Integer

        Dim nn, e, d As Integer

        While n > 0

            d = n Mod 10

            nn = nn + d * (10 ^ e)

            e = e + 1

            n = Elim_todos_num(n, d)

        End While
        Return nn

    End Function

    Public Function Elim_todos_num(n As Integer, num As Integer) As Integer
        Dim nd, d, nn, e As Integer

        nd = Cant_digs(num)
        d = 0
        nn = 0
        e = 0

        While n > 0
            d = n Mod (10 ^ nd)
            n = n \ (10 ^ nd)

            If d <> num Then

                nn = nn + (d * (10 ^ e))
                e = e + nd

            End If
        End While

        Return nn
    End Function

    Public Function Cant_digs(n As Integer) As Integer
        Dim cd, d As Integer
        cd = 0
        If n = 0 Then
            n = 1
        End If
        While n > 0
            d = n Mod 10
            n = n \ 10
            cd = cd + 1
        End While
        Return cd
    End Function

    Private Sub Ejercicio1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio1ToolStripMenuItem.Click
        TextBox2.Text = ejercicio1(TextBox1.Text)
    End Sub


    'ejercicio 2

    Public Function Ejercicio2(n As Integer) As Integer
        Dim may, men, nr As Integer

        men = Dig_men(n)
        may = Dig_may(n)

        nr = Unir2NE(men, may)

        Return nr


    End Function

    Public Function Unir2NE(n As Integer, num As Integer) As Integer
        Dim nn As Integer
        nn = 0
        nn = n * 10 ^ (Cant_digs(num)) + num
        Return nn

    End Function



    Public Function Dig_may(n As Integer) As Integer
        Dim d1, d2 As Integer

        d1 = n Mod 10
        n = n \ 10

        While n > 0
            d2 = n Mod 10
            n = n \ 10

            If d2 > d1 Then
                d1 = d2
            End If
        End While
        Return d1

    End Function


    Public Function Dig_men(n As Integer) As Integer
        Dim dm, d As Integer
        dm = n Mod 10
        n = n \ 10

        While n > 0
            d = n Mod 10
            n = n \ 10

            If d < dm Then
                dm = d
            End If
        End While
        Return dm

    End Function

    Private Sub Ejercicio2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Ejercicio2ToolStripMenuItem.Click
        TextBox2.Text = Ejercicio2(TextBox1.Text)
    End Sub
End Class
