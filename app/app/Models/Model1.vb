Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property IntranetSecurities As DbSet(Of IntranetSecurity)
    Public Overridable Property ITUsers As DbSet(Of ITUser)
    Public Overridable Property EUsers As DbSet(Of EUser)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of IntranetSecurity)() _
            .Property(Function(e) e.IDEmployee) _
            .IsUnicode(False)

        modelBuilder.Entity(Of IntranetSecurity)() _
            .Property(Function(e) e.EmployeeName) _
            .IsUnicode(False)

        modelBuilder.Entity(Of IntranetSecurity)() _
            .Property(Function(e) e.Password) _
            .IsUnicode(False)

        modelBuilder.Entity(Of IntranetSecurity)() _
            .Property(Function(e) e.Role) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.Knumber) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.Name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.Mail) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.Asset) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.TempPassword) _
            .IsUnicode(False)

        modelBuilder.Entity(Of ITUser)() _
            .Property(Function(e) e.Status) _
            .IsUnicode(False)

        modelBuilder.Entity(Of EUser)() _
            .Property(Function(e) e.Knumber) _
            .IsUnicode(False)

        modelBuilder.Entity(Of EUser)() _
            .Property(Function(e) e.nombre) _
            .IsUnicode(False)

        modelBuilder.Entity(Of EUser)() _
            .Property(Function(e) e.contrasena) _
            .IsUnicode(False)

        modelBuilder.Entity(Of EUser)() _
            .Property(Function(e) e.rol) _
            .IsFixedLength() _
            .IsUnicode(False)
    End Sub
End Class
