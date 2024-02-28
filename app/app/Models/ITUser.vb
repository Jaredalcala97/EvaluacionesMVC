Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class ITUser
    <Key>
    <StringLength(50)>
    Public Property Knumber As String

    <StringLength(100)>
    Public Property Name As String

    <StringLength(100)>
    Public Property Mail As String

    <StringLength(50)>
    Public Property Asset As String

    <Column(TypeName:="date")>
    Public Property StartDate As Date?

    <StringLength(150)>
    Public Property TempPassword As String

    <StringLength(200)>
    Public Property Status As String
End Class
