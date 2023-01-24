<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs"
Inherits="ASPxPivotGrid_CustomObjectConverter._Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.14.0, 
Culture=neutral, PublicKeyToken=b88d1754d700e49a"
Namespace="DevExpress.Web" TagPrefix="dx" %>

<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v13.1, Version=13.1.14.0,
Culture=neutral, PublicKeyToken=b88d1754d700e49a"
Namespace="DevExpress.Web.ASPxPivotGrid" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <table>
                            <tr>
                                <td>
                                    <dx:ASPxButton ID="ASPxButton1" runat="server"
                                        Text="Save" OnClick="ASPxButton1_Click">
                                    </dx:ASPxButton>
                                </td>
                                <td>
                                    <dx:ASPxButton ID="ASPxButton2" runat="server"
                                        Text="Load" OnClick="ASPxButton2_Click">
                                    </dx:ASPxButton>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>
                        <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server">
                            <Fields>
                                <dx:PivotGridField ID="fieldProductName" Area="RowArea"
                                    AreaIndex="0" Caption="Product Name"
                                    FieldName="ProductName">
                                </dx:PivotGridField>
                                <dx:PivotGridField ID="fieldSalesPerson" Area="ColumnArea"
                                    AreaIndex="0" Caption="Sales Person"
                                    FieldName="SalesPerson">
                                </dx:PivotGridField>
                                <dx:PivotGridField ID="fieldQuantity" Area="DataArea"
                                    AreaIndex="0" Caption="Quantity"
                                    FieldName="Quantity">
                                </dx:PivotGridField>
                            </Fields>
                        </dx:ASPxPivotGrid>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
