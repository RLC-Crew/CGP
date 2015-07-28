﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3603
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization
Imports System.Configuration

'
'This source code was auto-generated by wsdl, Version=2.0.50727.1432.
'
Namespace Seguridad.UsrSeguridad.Dat_Estaciones


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Dat_EstacionesSoap", [Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class Dat_Estaciones
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private AgregarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private BorrarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private ModificarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerRegistroBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerListaTotalBDOperationCompleted As System.Threading.SendOrPostCallback

        Private ListaCamposOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrSeguridad/Dat_Estaciones.asmx"
        End Sub

        '''<remarks/>
        Public Event AgregarBDCompleted As AgregarBDCompletedEventHandler

        '''<remarks/>
        Public Event BorrarBDCompleted As BorrarBDCompletedEventHandler

        '''<remarks/>
        Public Event ModificarBDCompleted As ModificarBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerRegistroBDCompleted As TraerRegistroBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerListaTotalBDCompleted As TraerListaTotalBDCompletedEventHandler

        '''<remarks/>
        Public Event ListaCamposCompleted As ListaCamposCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/AgregarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub AgregarBD(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double)
            Me.Invoke("AgregarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento})
        End Sub

        '''<remarks/>
        Public Function BeginAgregarBD(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AgregarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndAgregarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double)
            Me.AgregarBDAsync(varCodigoEstacion, varNombreEstacion, varCodigoDepartamento, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal userState As Object)
            If (Me.AgregarBDOperationCompleted Is Nothing) Then
                Me.AgregarBDOperationCompleted = AddressOf Me.OnAgregarBDOperationCompleted
            End If
            Me.InvokeAsync("AgregarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, Me.AgregarBDOperationCompleted, userState)
        End Sub

        Private Sub OnAgregarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.AgregarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AgregarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/BorrarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub BorrarBD(ByVal varCodigoEstacion As Double)
            Me.Invoke("BorrarBD", New Object() {varCodigoEstacion})
        End Sub

        '''<remarks/>
        Public Function BeginBorrarBD(ByVal varCodigoEstacion As Double, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("BorrarBD", New Object() {varCodigoEstacion}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndBorrarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal varCodigoEstacion As Double)
            Me.BorrarBDAsync(varCodigoEstacion, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub BorrarBDAsync(ByVal varCodigoEstacion As Double, ByVal userState As Object)
            If (Me.BorrarBDOperationCompleted Is Nothing) Then
                Me.BorrarBDOperationCompleted = AddressOf Me.OnBorrarBDOperationCompleted
            End If
            Me.InvokeAsync("BorrarBD", New Object() {varCodigoEstacion}, Me.BorrarBDOperationCompleted, userState)
        End Sub

        Private Sub OnBorrarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.BorrarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent BorrarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/ModificarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub ModificarBD(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double)
            Me.Invoke("ModificarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento})
        End Sub

        '''<remarks/>
        Public Function BeginModificarBD(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ModificarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndModificarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub ModificarBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double)
            Me.ModificarBDAsync(varCodigoEstacion, varNombreEstacion, varCodigoDepartamento, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ModificarBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal userState As Object)
            If (Me.ModificarBDOperationCompleted Is Nothing) Then
                Me.ModificarBDOperationCompleted = AddressOf Me.OnModificarBDOperationCompleted
            End If
            Me.InvokeAsync("ModificarBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, Me.ModificarBDOperationCompleted, userState)
        End Sub

        Private Sub OnModificarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.ModificarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ModificarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerRegistroBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub TraerRegistroBD(ByVal varCodigoEstacion As Double, ByRef varNombreEstacion As String, ByRef varCodigoDepartamento As Double)
            Dim results() As Object = Me.Invoke("TraerRegistroBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento})
            varNombreEstacion = CType(results(0), String)
            varCodigoDepartamento = CType(results(1), Double)
        End Sub

        '''<remarks/>
        Public Function BeginTraerRegistroBD(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerRegistroBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndTraerRegistroBD(ByVal asyncResult As System.IAsyncResult, ByRef varNombreEstacion As String, ByRef varCodigoDepartamento As Double)
            Dim results() As Object = Me.EndInvoke(asyncResult)
            varNombreEstacion = CType(results(0), String)
            varCodigoDepartamento = CType(results(1), Double)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double)
            Me.TraerRegistroBDAsync(varCodigoEstacion, varNombreEstacion, varCodigoDepartamento, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerRegistroBDAsync(ByVal varCodigoEstacion As Double, ByVal varNombreEstacion As String, ByVal varCodigoDepartamento As Double, ByVal userState As Object)
            If (Me.TraerRegistroBDOperationCompleted Is Nothing) Then
                Me.TraerRegistroBDOperationCompleted = AddressOf Me.OnTraerRegistroBDOperationCompleted
            End If
            Me.InvokeAsync("TraerRegistroBD", New Object() {varCodigoEstacion, varNombreEstacion, varCodigoDepartamento}, Me.TraerRegistroBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerRegistroBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerRegistroBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerRegistroBDCompleted(Me, New TraerRegistroBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerListaTotalBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function TraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros})
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Function BeginTraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndTraerListaTotalBD(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer)
            Me.TraerListaTotalBDAsync(ListaCondiciones, MaxRegistros, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal userState As Object)
            If (Me.TraerListaTotalBDOperationCompleted Is Nothing) Then
                Me.TraerListaTotalBDOperationCompleted = AddressOf Me.OnTraerListaTotalBDOperationCompleted
            End If
            Me.InvokeAsync("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros}, Me.TraerListaTotalBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerListaTotalBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerListaTotalBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerListaTotalBDCompleted(Me, New TraerListaTotalBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/ListaCampos", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function ListaCampos() As clsListaCampos
            Dim results() As Object = Me.Invoke("ListaCampos", New Object(-1) {})
            Return CType(results(0), clsListaCampos)
        End Function

        '''<remarks/>
        Public Function BeginListaCampos(ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("ListaCampos", New Object(-1) {}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndListaCampos(ByVal asyncResult As System.IAsyncResult) As clsListaCampos
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), clsListaCampos)
        End Function

        '''<remarks/>
        Public Overloads Sub ListaCamposAsync()
            Me.ListaCamposAsync(Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub ListaCamposAsync(ByVal userState As Object)
            If (Me.ListaCamposOperationCompleted Is Nothing) Then
                Me.ListaCamposOperationCompleted = AddressOf Me.OnListaCamposOperationCompleted
            End If
            Me.InvokeAsync("ListaCampos", New Object(-1) {}, Me.ListaCamposOperationCompleted, userState)
        End Sub

        Private Sub OnListaCamposOperationCompleted(ByVal arg As Object)
            If (Not (Me.ListaCamposCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ListaCamposCompleted(Me, New ListaCamposCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class clsListaCampos
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub AgregarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub BorrarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub ModificarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub TraerRegistroBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerRegistroBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class TraerRegistroBDCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property varNombreEstacion() As String
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), String)
            End Get
        End Property

        '''<remarks/>
        Public ReadOnly Property varCodigoDepartamento() As Double
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(1), Double)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub TraerListaTotalBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerListaTotalBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class TraerListaTotalBDCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As System.Data.DataSet
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), System.Data.DataSet)
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")> _
    Public Delegate Sub ListaCamposCompletedEventHandler(ByVal sender As Object, ByVal e As ListaCamposCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code")> _
    Partial Public Class ListaCamposCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs

        Private results() As Object

        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub

        '''<remarks/>
        Public ReadOnly Property Result() As clsListaCampos
            Get
                Me.RaiseExceptionIfNecessary()
                Return CType(Me.results(0), clsListaCampos)
            End Get
        End Property
    End Class
End Namespace