<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1842)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [LayoutSettingsPersistingHelper.cs](./CS/Q236875/LayoutSettingsPersistingHelper.cs) (VB: [LayoutSettingsPersistingHelper.vb](./VB/Q236875/LayoutSettingsPersistingHelper.vb))
<!-- default file list end -->
# How to combine the layout of multiple controls in a single file


<p>Some of our components allow you to save their layout into memory, XML file or system registry. However, there is no generic method to save the layout of all components within the Form. This example demonstrates how to save the layout of multiple controls into the temporary memory stream and then merge results into a single XML file.</p>


<h3>Description</h3>

<p>In this sample, the layout of each control is saved into memory. Then the memory stream is used to populate the structure containing two fields: the string to identify the control and the byte array representing the layout. The collection of these structures is serialized into XML and saved to the disk.</p>

<br/>


