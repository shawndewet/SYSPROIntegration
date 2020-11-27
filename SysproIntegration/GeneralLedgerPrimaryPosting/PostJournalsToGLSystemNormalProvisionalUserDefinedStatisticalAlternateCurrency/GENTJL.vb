Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace GeneralLedgerPrimaryPosting.PostJournalsToGLSystemNormalProvisionalUserDefinedStatisticalAlternateCurrency.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostGlJournal
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As PostGlJournalParameters
        
        Public Sub New()
            MyBase.New
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New PostGlJournalParameters
            End If
        End Sub
        
        Public Property Parameters() As PostGlJournalParameters
            Get
                Return Me.parametersField
            End Get
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Partial Public Class PostGlJournalParameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As PostGlJournalParametersIgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As PostGlJournalParametersApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As PostGlJournalParametersValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeField As PostGlJournalParametersActionType
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private actionTypeFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validatePasswordsField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private deleteEntriesonMaintField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreAnalysisField As PostGlJournalParametersIgnoreAnalysis
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreAnalysisFieldSpecified As Boolean
        
        Public Property IgnoreWarnings() As PostGlJournalParametersIgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set
                Me.ignoreWarningsField = value
                Me.IgnoreWarningsFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property
        
        Public Property ApplyIfEntireDocumentValid() As PostGlJournalParametersApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set
                Me.applyIfEntireDocumentValidField = value
                Me.ApplyIfEntireDocumentValidFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property
        
        Public Property ValidateOnly() As PostGlJournalParametersValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set
                Me.validateOnlyField = value
                Me.ValidateOnlyFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
        
        Public Property ActionType() As PostGlJournalParametersActionType
            Get
                Return Me.actionTypeField
            End Get
            Set
                Me.actionTypeField = value
                Me.ActionTypeFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ActionTypeSpecified() As Boolean
            Get
                Return Me.actionTypeFieldSpecified
            End Get
        End Property
        
        Public Property ValidatePasswords() As String
            Get
                Return Me.validatePasswordsField
            End Get
            Set
                Me.validatePasswordsField = value
            End Set
        End Property
        
        Public Property DeleteEntriesonMaint() As String
            Get
                Return Me.deleteEntriesonMaintField
            End Get
            Set
                Me.deleteEntriesonMaintField = value
            End Set
        End Property
        
        Public Property IgnoreAnalysis() As PostGlJournalParametersIgnoreAnalysis
            Get
                Return Me.ignoreAnalysisField
            End Get
            Set
                Me.ignoreAnalysisField = value
                Me.IgnoreAnalysisFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property IgnoreAnalysisSpecified() As Boolean
            Get
                Return Me.ignoreAnalysisFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalParametersIgnoreWarnings
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        W
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalParametersApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalParametersValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalParametersActionType
        
        '''<remarks/>
        A
        
        '''<remarks/>
        M
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true)>  _
    Public Enum PostGlJournalParametersIgnoreAnalysis
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
End Namespace
