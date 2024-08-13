Imports System

Module Program
    Sub Main(args As String())
        Dim f As Double
        Dim l As Double
        Dim c As Double
        Dim r As Double
        Dim x As Double
        Dim z As Double
        Dim xl As Double
        Dim xc As Double
        Dim angulo As Double
        Dim fdr As Double
        Console.Write("ingrese el valor de la frecuencia: ")
        f = Console.ReadLine()
        Console.Write("ingrese el valor de inductancia: ")
        l = Console.ReadLine()
        Console.Write("ingresar el valor de capacitancia: ")
        c = Console.ReadLine()
        Console.Write("ingrese el valor de la resistencia: ")
        r = Console.ReadLine()
        xl = 2 * Math.PI * f * l
        xc = 1 / (2 * Math.PI * f * c)
        x = xl - xc
        z = Math.Sqrt(r * r + x * x)
        angulo = Math.Atan(x / r) * (180 / Math.PI)
        fdr = 1 / (2 * Math.PI * Math.Sqrt(l * c))
        Console.WriteLine("inductancia xl: " & xl)
        Console.WriteLine("capacitancia xc: " & xc)
        Console.WriteLine("resistencia r: " & r)
        Console.WriteLine("resistencia total x:" & x)
        Console.WriteLine("impedancia z: " & z)
        Console.WriteLine("angulo de fase: " & angulo & " grados")
        Console.WriteLine("frecuencia de resonancia: " & fdr & " hz")
    End Sub
End Module
