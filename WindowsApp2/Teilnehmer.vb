Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Teilnehmer")>
Partial Public Class Teilnehmer
    Public Property Id As Integer

    <StringLength(50)>
    Public Property FamName As String
End Class
