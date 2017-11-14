<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationConsumindoWebService._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
  
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="cepInstituicao" HeaderText="cep" />
                <asp:BoundField DataField="cidadeInstituicao" HeaderText="cidade" />
                <asp:BoundField DataField="enderecoInstituicao" HeaderText="endereco" />
                <asp:BoundField DataField="estadoInstituicao" HeaderText="estado" />
                <asp:BoundField DataField="idInstituicao" HeaderText="id" />
                <asp:BoundField DataField="idStatusInstituicao" HeaderText="idStatus" />
                <asp:BoundField DataField="nomeInstituicao" HeaderText="nome" />
                <asp:BoundField DataField="telefoneInstituicao" HeaderText="telefone" />

            </Columns>
        </asp:GridView>
    </div>

</asp:Content>
