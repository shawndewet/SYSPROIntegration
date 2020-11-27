﻿Imports System
Imports System.Text
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class BOMSROTest

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    <TestInitialize()> _
    Public Sub SetLogonParameters()
        Common.CommonTestMethods.SetLogonParameters()
    End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region


    <TestMethod()> _
    Public Sub TestMultipleItems()

        Dim setupObj As New Codewell.SysproIntegration.SystemSetup.BomRoutingMaintenance.Data.SetupBomRouting

        Dim newItem As New Codewell.SysproIntegration.SystemSetup.BomRoutingMaintenance.Data.Item
        newItem.Key.Operation = 1

        setupObj.ItemCollection.Add(newItem)

        setupObj.Post(False)

        Assert.AreNotEqual(setupObj.XmlOut.IndexOf("<Item>") <> setupObj.XmlOut.LastIndexOf("<Item>"), "There is only one <Item> element!")

    End Sub
End Class
