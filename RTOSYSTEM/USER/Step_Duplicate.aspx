﻿<%@ Page Language="C#" MasterPageFile="~/USER/USERMASTER.Master" AutoEventWireup="true" CodeBehind="Step_Duplicate.aspx.cs" Inherits="RTOSYSTEM.USER.WebForm18" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div align="center" style="height: 438px">
    <br />
    <br />
    
    <table align="center" bgcolor="Black" 
        style="border-style: groove; font-size: large; color: #FFFFFF;" 
        class="transbox"  >
    <tr>
    <td>
           <p>There are some steps you have to follow for Duplicate license.<br /><br />
           1. You have to Pay 
               <asp:Label ID="Label1" runat="server" Text="100"></asp:Label> &nbsp;exam fees.<br /><br />
           2. You have to give RTO-TEST<br /><br />
           3. If yout marks more than 13 then you can get license form.<br />
            &nbsp;&nbsp;&nbsp;  otherwise if you failed then you have to try again and pay too.<br /><br />
           4. you have to fill the driving license form.
           </p>
        </td>
         </tr>
         <tr>
            <td align="center">
                <asp:ImageButton ID="btnpaysment" runat="server" 
                    PostBackUrl="~/USER/Payment.aspx" Height="48px" ImageUrl="~/USER/image/driving-license.png" 
                    Width="105px"/>
            </td>
         </tr>
    </table>
    </div>
</asp:Content>
