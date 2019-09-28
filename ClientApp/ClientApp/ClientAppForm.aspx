<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClientAppForm.aspx.cs" Inherits="ClientApp.ClientAppForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div style="margin: 0px auto 0px auto; width: 400px">
        <form id="form1" runat="server">
            <h1>Music information</h1>
            <table style="font-family: Arial; border: 1px solid black;">
                <tr>
                    <td>
                        <b>SongName (Search)</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSongName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Get Music Info" OnClick="btnGetMusic_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Artist</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtArtist" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>Album</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAlbum" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <b>ReleaseYear</b>
                    </td>
                    <td>
                        <asp:TextBox ID="txtReleaseYear" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Green" Font-Bold="true"></asp:Label>
                    </td>
                </tr>
            </table>
        </form>
    </div>
</body>
</html>
