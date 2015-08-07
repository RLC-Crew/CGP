﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión del motor en tiempo de ejecución:2.0.50727.3615
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
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
'This source code was auto-generated by wsdl, Version=2.0.50727.3038.
'
Namespace UsrPagos.Dat_PC_Bitacora


    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Web.Services.WebServiceBindingAttribute(Name:="Dat_PC_BitacoraSoap", [Namespace]:="http://www.prosoft.cr/")> _
    Partial Public Class Dat_PC_Bitacora
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol

        Private AgregarBDOperationCompleted As System.Threading.SendOrPostCallback

        Private TraerListaTotalBDOperationCompleted As System.Threading.SendOrPostCallback

        '''<remarks/>
        Public Sub New()
            MyBase.New()
            Me.Url = ConfigurationManager.AppSettings(Constantes.ServidorDatos) + "UsrPagos/Dat_PC_Bitacora.asmx"
        End Sub

        '''<remarks/>
        Public Event AgregarBDCompleted As AgregarBDCompletedEventHandler

        '''<remarks/>
        Public Event TraerListaTotalBDCompleted As TraerListaTotalBDCompletedEventHandler

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/AgregarBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Sub AgregarBD(ByVal v_TipoEvento As Integer, ByVal v_DescripcionEvento As String, ByVal v_ReferenciaTecnica As String, ByVal v_TipoOperacion As String, ByVal v_NumeroTransaccion As Integer, ByVal v_NumeroEnvio As Integer, ByVal v_DireccionIP As String, ByVal v_Usuario As String)
            Me.Invoke("AgregarBD", New Object() {v_TipoEvento, v_DescripcionEvento, v_ReferenciaTecnica, v_TipoOperacion, v_NumeroTransaccion, v_NumeroEnvio, v_DireccionIP, v_Usuario})
        End Sub

        '''<remarks/>
        Public Function BeginAgregarBD(ByVal v_TipoEvento As Integer, ByVal v_DescripcionEvento As String, ByVal v_ReferenciaTecnica As String, ByVal v_TipoOperacion As String, ByVal v_NumeroTransaccion As Integer, ByVal v_NumeroEnvio As Integer, ByVal v_DireccionIP As String, ByVal v_Usuario As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("AgregarBD", New Object() {v_TipoEvento, v_DescripcionEvento, v_ReferenciaTecnica, v_TipoOperacion, v_NumeroTransaccion, v_NumeroEnvio, v_DireccionIP, v_Usuario}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Sub EndAgregarBD(ByVal asyncResult As System.IAsyncResult)
            Me.EndInvoke(asyncResult)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal v_TipoEvento As Integer, ByVal v_DescripcionEvento As String, ByVal v_ReferenciaTecnica As String, ByVal v_TipoOperacion As String, ByVal v_NumeroTransaccion As Integer, ByVal v_NumeroEnvio As Integer, ByVal v_DireccionIP As String, ByVal v_Usuario As String)
            Me.AgregarBDAsync(v_TipoEvento, v_DescripcionEvento, v_ReferenciaTecnica, v_TipoOperacion, v_NumeroTransaccion, v_NumeroEnvio, v_DireccionIP, v_Usuario, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub AgregarBDAsync(ByVal v_TipoEvento As Integer, ByVal v_DescripcionEvento As String, ByVal v_ReferenciaTecnica As String, ByVal v_TipoOperacion As String, ByVal v_NumeroTransaccion As Integer, ByVal v_NumeroEnvio As Integer, ByVal v_DireccionIP As String, ByVal v_Usuario As String, ByVal userState As Object)
            If (Me.AgregarBDOperationCompleted Is Nothing) Then
                Me.AgregarBDOperationCompleted = AddressOf Me.OnAgregarBDOperationCompleted
            End If
            Me.InvokeAsync("AgregarBD", New Object() {v_TipoEvento, v_DescripcionEvento, v_ReferenciaTecnica, v_TipoOperacion, v_NumeroTransaccion, v_NumeroEnvio, v_DireccionIP, v_Usuario}, Me.AgregarBDOperationCompleted, userState)
        End Sub

        Private Sub OnAgregarBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.AgregarBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent AgregarBDCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.prosoft.cr/TraerListaTotalBD", RequestNamespace:="http://www.prosoft.cr/", ResponseNamespace:="http://www.prosoft.cr/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)> _
        Public Function TraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String) As System.Data.DataSet
            Dim results() As Object = Me.Invoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP})
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Function BeginTraerListaTotalBD(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
            Return Me.BeginInvoke("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP}, callback, asyncState)
        End Function

        '''<remarks/>
        Public Function EndTraerListaTotalBD(ByVal asyncResult As System.IAsyncResult) As System.Data.DataSet
            Dim results() As Object = Me.EndInvoke(asyncResult)
            Return CType(results(0), System.Data.DataSet)
        End Function

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String)
            Me.TraerListaTotalBDAsync(ListaCondiciones, MaxRegistros, usuario, IP, Nothing)
        End Sub

        '''<remarks/>
        Public Overloads Sub TraerListaTotalBDAsync(ByVal ListaCondiciones As clsListaCondiciones, ByVal MaxRegistros As Integer, ByVal usuario As String, ByVal IP As String, ByVal userState As Object)
            If (Me.TraerListaTotalBDOperationCompleted Is Nothing) Then
                Me.TraerListaTotalBDOperationCompleted = AddressOf Me.OnTraerListaTotalBDOperationCompleted
            End If
            Me.InvokeAsync("TraerListaTotalBD", New Object() {ListaCondiciones, MaxRegistros, usuario, IP}, Me.TraerListaTotalBDOperationCompleted, userState)
        End Sub

        Private Sub OnTraerListaTotalBDOperationCompleted(ByVal arg As Object)
            If (Not (Me.TraerListaTotalBDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg, System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent TraerListaTotalBDCompleted(Me, New TraerListaTotalBDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub

        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub AgregarBDCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038")> _
    Public Delegate Sub TraerListaTotalBDCompletedEventHandler(ByVal sender As Object, ByVal e As TraerListaTotalBDCompletedEventArgs)

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.3038"), _
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
End Namespace