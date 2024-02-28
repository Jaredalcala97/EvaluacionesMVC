Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

Partial Public Class EUser
    <Key>
    <Column(Order:=0)>
    <StringLength(20)>
    Public Property Knumber As String

    <StringLength(50)>
    Public Property nombre As String

    <Key>
    <Column(Order:=1)>
    <StringLength(50)>
    Public Property contrasena As String

    <Key>
    <Column(Order:=2)>
    <StringLength(10)>
    Public Property rol As String
End Class
