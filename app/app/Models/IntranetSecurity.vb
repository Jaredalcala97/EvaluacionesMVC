Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("IntranetSecurity")>
Partial Public Class IntranetSecurity
    <Key>
    <StringLength(20)>
    Public Property IDEmployee As String

    <StringLength(100)>
    Public Property EmployeeName As String

    <StringLength(50)>
    Public Property Password As String

    <StringLength(100)>
    Public Property Role As String
End Class
