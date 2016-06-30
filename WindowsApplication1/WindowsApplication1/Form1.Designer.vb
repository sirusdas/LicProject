<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LIC_Database1DataSet = New WindowsApplication1.LIC_Database1DataSet()
        Me.LICDatabase1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager1 = New WindowsApplication1.LIC_Database1DataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LIC_Database1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LICDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.DataSource = Me.LICDatabase1DataSetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(120, 147)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(699, 241)
        Me.DataGridView1.TabIndex = 0
        '
        'LIC_Database1DataSet
        '
        Me.LIC_Database1DataSet.DataSetName = "LIC_Database1DataSet"
        Me.LIC_Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LICDatabase1DataSetBindingSource
        '
        Me.LICDatabase1DataSetBindingSource.DataSource = Me.LIC_Database1DataSet
        Me.LICDatabase1DataSetBindingSource.Position = 0
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.Ldb1TableAdapter = Nothing
        Me.TableAdapterManager1.Pdb1TableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = WindowsApplication1.LIC_Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 525)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LIC_Database1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LICDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LICDatabase1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LIC_Database1DataSet As WindowsApplication1.LIC_Database1DataSet
    Friend WithEvents TableAdapterManager1 As WindowsApplication1.LIC_Database1DataSetTableAdapters.TableAdapterManager

End Class
