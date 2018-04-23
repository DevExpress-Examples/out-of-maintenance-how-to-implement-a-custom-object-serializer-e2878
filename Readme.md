# How to implement a custom object serializer


<p>The following example shows how to implement a custom serializer.</p><p>Custom serializers are required when data source field values are custom objects (not numeric or string values). In this example, the data source contains a Sales Person field whose values are Employee objects, exposing the FirstName, LastName and Age properties. The Employee class implements the IComparable interface, and overrides the GetHashCode, Equals and ToString methods (required to display and handle custom objects).</p><p>The custom serializer is represented by the CustomObjectConverter class, which implements the ICustomObjectConverter interface. The ToString and FromString methods are implemented to serialize and deserialize the Employee objects, respectively. A CustomObjectConverter class instance is assigned to the PivotGridOptionsData.CustomObjectConverter property. It is used for serializing Sales Person field values when data is sorted or filtered. You can also use the Save and Load buttons to save the pivot grid layout to a string and restored it, respectively, which also implies field values serialization with the custom serializer.</p>

<br/>


