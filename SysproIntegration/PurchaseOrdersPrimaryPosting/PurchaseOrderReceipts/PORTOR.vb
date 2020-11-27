Imports System
Imports System.Diagnostics
Imports System.Collections.Generic
Imports System.Xml.Serialization
Imports System.Collections
Imports System.Xml.Schema
Imports System.ComponentModel

Namespace PurchaseOrdersPrimaryPosting.PurchaseOrderReceipts.Params
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ApplyIfEntireDocumentValid
        
        '''<remarks/>
        Y
        
        '''<remarks/>
        N
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum GRNMatchingAction
        
        '''<remarks/>
        A
        
        '''<remarks/>
        R
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum IgnoreWarnings
        
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ManualSerialTransfersAllowed
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class Parameters
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private transactionDateField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsField As IgnoreWarnings
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private ignoreWarningsFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private nonStockedWhToUseField As String
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNMatchingActionField As GRNMatchingAction
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private gRNMatchingActionFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidField As ApplyIfEntireDocumentValid
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private applyIfEntireDocumentValidFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyField As ValidateOnly
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private validateOnlyFieldSpecified As Boolean
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualSerialTransfersAllowedField As ManualSerialTransfersAllowed
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private manualSerialTransfersAllowedFieldSpecified As Boolean
        
        Public Sub New()
            MyBase.New
            Me.ignoreWarningsField = IgnoreWarnings.N
            Me.gRNMatchingActionField = GRNMatchingAction.A
            Me.applyIfEntireDocumentValidField = ApplyIfEntireDocumentValid.Y
            Me.validateOnlyField = ValidateOnly.N
            Me.manualSerialTransfersAllowedField = ManualSerialTransfersAllowed.N
        End Sub
        
        '''<summary>
        '''Date transaction raised. If not supplied, rundate is assumed.
        '''</summary>
        Public Property TransactionDate() As String
            Get
                Return Me.transactionDateField
            End Get
            Set
                Me.transactionDateField = value
            End Set
        End Property
        
        '''<summary>
        '''This element indicates whether or not a transaction must be rejected if there are any warnings, such as a P/O not yet printed, ledger code, debit ledger code or non-merchandise ledger code is a control account, quantity greater than inspected to date or greater than available to accept, transaction not allowed for kits, cost variance exceeded, stock on partial hold, quantity received greater than ordered, early or late supply, over or under supply, order already released for invoicing, S/O line complete or access to job classification denied. If 'W' supplied, these errors will be reported as warnings. If it is not supplied, it defaults to 'N'. Valid values are 'N', 'W' and 'Y'.
        '''</summary>
        Public Property IgnoreWarnings() As IgnoreWarnings
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
        
        '''<summary>
        '''This element contains the default warehouse to be used when processing non-stocked items. If supplied, it overrides the non-stocked warehouse defined in operator defaults or company defaults in SYSPRO. 
        '''</summary>
        Public Property NonStockedWhToUse() As String
            Get
                Return Me.nonStockedWhToUseField
            End Get
            Set
                Me.nonStockedWhToUseField = value
            End Set
        End Property
        
        '''<summary>
        '''This element instructs the program what to do with regards to GRN matching.
        '''If GRN matching is required and the supplier is not switched on for GRN matching, the transaction is rejected if this element is set to 'R'. Alternatively, if this element is set to 'A', the transaction is accepted as is. Valid values are 'A' and 'R'. Default is 'A'.
        '''</summary>
        Public Property GRNMatchingAction() As GRNMatchingAction
            Get
                Return Me.gRNMatchingActionField
            End Get
            Set
                Me.gRNMatchingActionField = value
                Me.GRNMatchingActionFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property GRNMatchingActionSpecified() As Boolean
            Get
                Return Me.gRNMatchingActionFieldSpecified
            End Get
        End Property
        
        '''<summary>
        '''This element indicates whether to process entire document only if all items are valid. If set to 'N', each item is validated and rejected if in error or processed if correct. This is the fastest option. If set to 'Y', all items are validated and only processed if entire document is valid. Default is 'Y'. Valid values are 'Y' and 'N'.
        '''</summary>
        Public Property ApplyIfEntireDocumentValid() As ApplyIfEntireDocumentValid
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
        
        '''<summary>
        '''This element indicates which processing phases are to be performed. If set to 'Y' all items are validated and an XML string is returned with the result of the validation. No updating will take place. If set to 'N', each item is validated and updating is performed based on setting of the element 'ApplyIfEntireDocumentValid'. Default is 'N'. Valid values are 'N' and 'Y'.
        '''</summary>
        Public Property ValidateOnly() As ValidateOnly
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
        
        '''<summary>
        '''If manual serial numbers exist in a different warehouse with no stock on hand they may be transferred to the warehouse where they are required. To do this, this element may be set to 'Y'. This is only applicable to normal receipts. Valid values are 'N' and 'Y'. Default is 'N'.
        '''</summary>
        Public Property ManualSerialTransfersAllowed() As ManualSerialTransfersAllowed
            Get
                Return Me.manualSerialTransfersAllowedField
            End Get
            Set
                Me.manualSerialTransfersAllowedField = value
                Me.ManualSerialTransfersAllowedFieldSpecified = true
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public ReadOnly Property ManualSerialTransfersAllowedSpecified() As Boolean
            Get
                Return Me.manualSerialTransfersAllowedFieldSpecified
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Public Enum ValidateOnly
        
        '''<remarks/>
        N
        
        '''<remarks/>
        Y
    End Enum
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("Shell", "1.0.0.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true),  _
     System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=false)>  _
    Partial Public Class PostPurchaseOrderReceipts
        
        <EditorBrowsable(EditorBrowsableState.Never)>  _
        Private parametersField As Parameters
        
        Public Sub New()
            MyBase.New
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
            Set
                Me.parametersField = value
            End Set
        End Property
    End Class
End Namespace
