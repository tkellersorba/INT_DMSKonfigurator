﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports System.Reflection
Namespace DMSCenter

    Partial Public Class FilesnFolders
        Inherits XPObject
        Dim fName As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Name), fName, value)
            End Set
        End Property
        Dim fPath As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Path() As String
            Get
                Return fPath
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Path), fPath, value)
            End Set
        End Property
        Dim fStatus As Long
        Public Property Status() As Long
            Get
                Return fStatus
            End Get
            Set(ByVal value As Long)
                SetPropertyValue(Of Long)(NameOf(Status), fStatus, value)
            End Set
        End Property
        Dim fActualDate As DateTime
        Public Property ActualDate() As DateTime
            Get
                Return fActualDate
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)(NameOf(ActualDate), fActualDate, value)
            End Set
        End Property
        Dim fFK_DatenObjekt As DatenObjekt
        <Association("FilesnFoldersReferencesDatenObjekt")>
        Public Property FK_DatenObjekt() As DatenObjekt
            Get
                Return fFK_DatenObjekt
            End Get
            Set(ByVal value As DatenObjekt)
                SetPropertyValue(Of DatenObjekt)(NameOf(FK_DatenObjekt), fFK_DatenObjekt, value)
            End Set
        End Property
        Dim fIsFolder As Boolean
        Public Property IsFolder() As Boolean
            Get
                Return fIsFolder
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)(NameOf(IsFolder), fIsFolder, value)
            End Set
        End Property
        Dim fParent As String
        <Size(SizeAttribute.Unlimited)>
        Public Property Parent() As String
            Get
                Return fParent
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)(NameOf(Parent), fParent, value)
            End Set
        End Property
        Dim fTransfered As Boolean
        Public Property Transfered() As Boolean
            Get
                Return fTransfered
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)(NameOf(Transfered), fTransfered, value)
            End Set
        End Property
    End Class

End Namespace
