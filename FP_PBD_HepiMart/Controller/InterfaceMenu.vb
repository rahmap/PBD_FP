Public Interface InterfaceMenu
    Function tampilMenu() As DataView
    Function hapusMenu(ob As Object) As OleDb.OleDbCommand
    Sub updateMenu()
    Sub insertMenu()
    Function cariMenu() As DataView
End Interface
