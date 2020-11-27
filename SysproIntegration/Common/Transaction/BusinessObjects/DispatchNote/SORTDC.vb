Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace TransactionObjects.CancelDispatchNote.Params

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class PostDispCancel

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private parametersField As Parameters

        Public Sub New()
            MyBase.New()
            If (Me.parametersField Is Nothing) Then
                Me.parametersField = New Parameters
            End If
        End Sub

        '''<summary>
        '''This contains parameters.
        '''</summary>
        Public Property Parameters() As Parameters
            Get
                Return Me.parametersField
            End Get
            Set(ByVal value As Parameters)
                Me.parametersField = value
            End Set
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Partial Public Class Parameters

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cancelAttachedCommentsField As CancelAttachedComments

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private cancelAttachedCommentsFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsField As IgnoreWarnings

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private ignoreWarningsFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyField As ValidateOnly

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Private validateOnlyFieldSpecified As Boolean

        Public Sub New()
            MyBase.New()
            Me.cancelAttachedCommentsField = CancelAttachedComments.N
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.N
        End Sub

        '''<summary>
        '''This element indicates whether or not to cancel any further comments attached to the selected line. Default is 'N'. Valid values are 'Y' and 'N'.
        '''</summary>
        Public Property CancelAttachedComments() As CancelAttachedComments
            Get
                Return Me.cancelAttachedCommentsField
            End Get
            Set(ByVal value As CancelAttachedComments)
                Me.cancelAttachedCommentsField = value
                Me.cancelAttachedCommentsFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property CancelAttachedCommentsSpecified() As Boolean
            Get
                Return Me.cancelAttachedCommentsFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates whether or not a dispatch must be rejected if there are any warnings such components attached to a parent. If 'W' is supplied, error will be reported as a warning If not supplied it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
            Get
                Return Me.ignoreWarningsField
            End Get
            Set(ByVal value As IgnoreWarnings)
                Me.ignoreWarningsField = value
                Me.ignoreWarningsFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property IgnoreWarningsSpecified() As Boolean
            Get
                Return Me.ignoreWarningsFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
        '''
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
            Get
                Return Me.applyIfEntireDocumentValidField
            End Get
            Set(ByVal value As ApplyIfEntireDocumentValid)
                Me.applyIfEntireDocumentValidField = value
                Me.applyIfEntireDocumentValidFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property ApplyIfEntireDocumentValidSpecified() As Boolean
            Get
                Return Me.applyIfEntireDocumentValidFieldSpecified
            End Get
        End Property

        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
            Get
                Return Me.validateOnlyField
            End Get
            Set(ByVal value As ValidateOnly)
                Me.validateOnlyField = value
                Me.validateOnlyFieldSpecified = True
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()> _
        Public ReadOnly Property ValidateOnlySpecified() As Boolean
            Get
                Return Me.validateOnlyFieldSpecified
            End Get
        End Property
    End Class

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum CancelAttachedComments

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum IgnoreWarnings

        '''<remarks/>
        N

        '''<remarks/>
        Y

        '''<remarks/>
        W
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum ApplyIfEntireDocumentValid

        '''<remarks/>
        Y

        '''<remarks/>
        N
    End Enum

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"), _
     System.SerializableAttribute(), _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True), _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)> _
    Public Enum ValidateOnly

        '''<remarks/>
        N

        '''<remarks/>
        Y
    End Enum
End Namespace
