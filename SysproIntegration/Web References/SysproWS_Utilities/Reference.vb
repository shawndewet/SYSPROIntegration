﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
'
Namespace SysproWS_Utilities
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="utilitiesclassSoap", [Namespace]:="http://www.syspro.com/ns/utilities/")>  _
    Partial Public Class utilitiesclass
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private LogonOperationCompleted As System.Threading.SendOrPostCallback
        
        Private LogoffOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetLogonProfileOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RunOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = "http://localhost/sysprowebservices/Utilities.asmx"
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event LogonCompleted As LogonCompletedEventHandler
        
        '''<remarks/>
        Public Event LogoffCompleted As LogoffCompletedEventHandler
        
        '''<remarks/>
        Public Event GetLogonProfileCompleted As GetLogonProfileCompletedEventHandler
        
        '''<remarks/>
        Public Event RunCompleted As RunCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.syspro.com/ns/utilities/Logon", RequestNamespace:="http://www.syspro.com/ns/utilities/", ResponseNamespace:="http://www.syspro.com/ns/utilities/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Logon(ByVal [Operator] As String, ByVal OperatorPassword As String, ByVal CompanyId As String, ByVal CompanyPassword As String, ByVal LanguageCode As Language, ByVal LogLevel As LogDetail, ByVal EncoreInstance As Instance, ByVal XmlIn As String) As String
            Dim results() As Object = Me.Invoke("Logon", New Object() {[Operator], OperatorPassword, CompanyId, CompanyPassword, LanguageCode, LogLevel, EncoreInstance, XmlIn})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub LogonAsync(ByVal [Operator] As String, ByVal OperatorPassword As String, ByVal CompanyId As String, ByVal CompanyPassword As String, ByVal LanguageCode As Language, ByVal LogLevel As LogDetail, ByVal EncoreInstance As Instance, ByVal XmlIn As String)
            Me.LogonAsync([Operator], OperatorPassword, CompanyId, CompanyPassword, LanguageCode, LogLevel, EncoreInstance, XmlIn, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogonAsync(ByVal [Operator] As String, ByVal OperatorPassword As String, ByVal CompanyId As String, ByVal CompanyPassword As String, ByVal LanguageCode As Language, ByVal LogLevel As LogDetail, ByVal EncoreInstance As Instance, ByVal XmlIn As String, ByVal userState As Object)
            If (Me.LogonOperationCompleted Is Nothing) Then
                Me.LogonOperationCompleted = AddressOf Me.OnLogonOperationCompleted
            End If
            Me.InvokeAsync("Logon", New Object() {[Operator], OperatorPassword, CompanyId, CompanyPassword, LanguageCode, LogLevel, EncoreInstance, XmlIn}, Me.LogonOperationCompleted, userState)
        End Sub
        
        Private Sub OnLogonOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogonCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogonCompleted(Me, New LogonCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.syspro.com/ns/utilities/Logoff", RequestNamespace:="http://www.syspro.com/ns/utilities/", ResponseNamespace:="http://www.syspro.com/ns/utilities/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Logoff(ByVal UserId As String) As String
            Dim results() As Object = Me.Invoke("Logoff", New Object() {UserId})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub LogoffAsync(ByVal UserId As String)
            Me.LogoffAsync(UserId, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LogoffAsync(ByVal UserId As String, ByVal userState As Object)
            If (Me.LogoffOperationCompleted Is Nothing) Then
                Me.LogoffOperationCompleted = AddressOf Me.OnLogoffOperationCompleted
            End If
            Me.InvokeAsync("Logoff", New Object() {UserId}, Me.LogoffOperationCompleted, userState)
        End Sub
        
        Private Sub OnLogoffOperationCompleted(ByVal arg As Object)
            If (Not (Me.LogoffCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LogoffCompleted(Me, New LogoffCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.syspro.com/ns/utilities/GetLogonProfile", RequestNamespace:="http://www.syspro.com/ns/utilities/", ResponseNamespace:="http://www.syspro.com/ns/utilities/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function GetLogonProfile(ByVal UserId As String) As String
            Dim results() As Object = Me.Invoke("GetLogonProfile", New Object() {UserId})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetLogonProfileAsync(ByVal UserId As String)
            Me.GetLogonProfileAsync(UserId, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetLogonProfileAsync(ByVal UserId As String, ByVal userState As Object)
            If (Me.GetLogonProfileOperationCompleted Is Nothing) Then
                Me.GetLogonProfileOperationCompleted = AddressOf Me.OnGetLogonProfileOperationCompleted
            End If
            Me.InvokeAsync("GetLogonProfile", New Object() {UserId}, Me.GetLogonProfileOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetLogonProfileOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetLogonProfileCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetLogonProfileCompleted(Me, New GetLogonProfileCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.syspro.com/ns/utilities/Run", RequestNamespace:="http://www.syspro.com/ns/utilities/", ResponseNamespace:="http://www.syspro.com/ns/utilities/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Run(ByVal UserId As String, ByVal BusinessObject As String, ByVal Parameter As String) As String
            Dim results() As Object = Me.Invoke("Run", New Object() {UserId, BusinessObject, Parameter})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RunAsync(ByVal UserId As String, ByVal BusinessObject As String, ByVal Parameter As String)
            Me.RunAsync(UserId, BusinessObject, Parameter, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RunAsync(ByVal UserId As String, ByVal BusinessObject As String, ByVal Parameter As String, ByVal userState As Object)
            If (Me.RunOperationCompleted Is Nothing) Then
                Me.RunOperationCompleted = AddressOf Me.OnRunOperationCompleted
            End If
            Me.InvokeAsync("Run", New Object() {UserId, BusinessObject, Parameter}, Me.RunOperationCompleted, userState)
        End Sub
        
        Private Sub OnRunOperationCompleted(ByVal arg As Object)
            If (Not (Me.RunCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RunCompleted(Me, New RunCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.syspro.com/ns/utilities/")>  _
    Public Enum Language
        
        '''<remarks/>
        [AUTO]
        
        '''<remarks/>
        ENGLISH_US
        
        '''<remarks/>
        FRENCH_CANADIAN
        
        '''<remarks/>
        DANISH
        
        '''<remarks/>
        DUTCH
        
        '''<remarks/>
        ENGLISH
        
        '''<remarks/>
        FINNISH
        
        '''<remarks/>
        FRENCH
        
        '''<remarks/>
        GERMAN
        
        '''<remarks/>
        ITALIAN
        
        '''<remarks/>
        NORWEGIAN
        
        '''<remarks/>
        PORTUGUESE
        
        '''<remarks/>
        SPANISH
        
        '''<remarks/>
        SWEDISH
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.syspro.com/ns/utilities/")>  _
    Public Enum LogDetail
        
        '''<remarks/>
        ldNoDebug
        
        '''<remarks/>
        ldDebug
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34234"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.syspro.com/ns/utilities/")>  _
    Public Enum Instance
        
        '''<remarks/>
        EncoreInstance_0
        
        '''<remarks/>
        EncoreInstance_1
        
        '''<remarks/>
        EncoreInstance_2
        
        '''<remarks/>
        EncoreInstance_3
        
        '''<remarks/>
        EncoreInstance_4
        
        '''<remarks/>
        EncoreInstance_5
        
        '''<remarks/>
        EncoreInstance_6
        
        '''<remarks/>
        EncoreInstance_7
        
        '''<remarks/>
        EncoreInstance_8
        
        '''<remarks/>
        EncoreInstance_9
        
        '''<remarks/>
        EncoreInstanceTostring_10
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub LogonCompletedEventHandler(ByVal sender As Object, ByVal e As LogonCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class LogonCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub LogoffCompletedEventHandler(ByVal sender As Object, ByVal e As LogoffCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class LogoffCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub GetLogonProfileCompletedEventHandler(ByVal sender As Object, ByVal e As GetLogonProfileCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetLogonProfileCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")>  _
    Public Delegate Sub RunCompletedEventHandler(ByVal sender As Object, ByVal e As RunCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class RunCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
