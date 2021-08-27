<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577591/11.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2878)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [DataHelper.cs](./CS/ASPxPivotGrid_CustomObjectConverter/DataHelper.cs) (VB: [DataHelper.vb](./VB/ASPxPivotGrid_CustomObjectConverter/DataHelper.vb))
* [Default.aspx](./CS/ASPxPivotGrid_CustomObjectConverter/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_CustomObjectConverter/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_CustomObjectConverter/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_CustomObjectConverter/Default.aspx.vb))
<!-- default file list end -->
# How to implement a custom object serializer


<p>The following example shows how to implement a custom serializer.</p><p>Custom serializers are required when data source field values are custom objects (not numeric or string values). In this example, the data source contains a Sales Person field whose values are Employee objects, exposing the FirstName, LastName and Age properties. The Employee class implements the IComparable interface, and overrides the GetHashCode, Equals and ToString methods (required to display and handle custom objects).</p><p>The custom serializer is represented by the CustomObjectConverter class, which implements the ICustomObjectConverter interface. The ToString and FromString methods are implemented to serialize and deserialize the Employee objects, respectively. A CustomObjectConverter class instance is assigned to the PivotGridOptionsData.CustomObjectConverter property. It is used for serializing Sales Person field values when data is sorted or filtered. You can also use the Save and Load buttons to save the pivot grid layout to a string and restored it, respectively, which also implies field values serialization with the custom serializer.</p>

<br/>


