<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577591/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2878)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/ASPxPivotGrid_CustomObjectConverter/DataHelper.cs) (VB: [DataHelper.vb](./VB/ASPxPivotGrid_CustomObjectConverter/DataHelper.vb))
* [Default.aspx](./CS/ASPxPivotGrid_CustomObjectConverter/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CustomObjectConverter/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CustomObjectConverter/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CustomObjectConverter/Default.aspx.vb))
<!-- default file list end -->
# How to Implement a Custom Object Serializer
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2878/)**
<!-- run online end -->


This example demonstrates how to implement a custom serializer. Custom serializers are necessary when the data source field values are custom objects (not numeric or string values).

The project's data source contains the Sales Person field whose values are **Employee** objects. The Employee object exposes the FirstName, LastName, and Age properties. The Employee class implements the _IComparable_ interface and overrides the GetHashCode, Equals, and ToString methods.

The **CustomObjectConverter** class is a custom serializer. It implements the _ICustomObjectConverter_ interface. The ToString and FromString methods are implemented to serialize and deserialize the Employee object. A CustomObjectConverter class instance is assigned to the [PivotGridOptionsData.CustomObjectConverter](https://docs.devexpress.com/CoreLibraries/DevExpress.XtraPivotGrid.PivotGridOptionsData.CustomObjectConverter) property. The converter serializes the Sales Person field values when data is sorted or filtered. 

Click the Save and Load buttons to save the pivot grid layout to a string and restore it. Save and Restore actions uses a custom serializer.
