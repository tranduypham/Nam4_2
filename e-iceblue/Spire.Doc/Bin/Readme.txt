Thank you for downloading our product.

1. If you need a temporary license to remove the warning message,
   please contact us sales@e-iceblue.com.

2. If you are interested in buying our product, please check
   Purchase Policies to choose the appropriate license type for you.
   https://www.e-iceblue.com/Misc/purchase-policies.html


This following information describes what folder contains the assemblies you need to use with a particular version of the .NET Framework.


Folder						Description
---------------------------------------------------------------------------------------------------------------------------

NET2.0						Contains assemblies that target .NET Framework 2.0.

NET4.0						Contains assemblies to use with .NET Framework 4.0.

NET4.0 ClientProfile			        Contains assemblies to use with .NET Framework 4.0 Client Profile.

NET4.6                                          Contains assemblies to use with .NET Framework 4.6 and higher.

netcoreapp2.0                                   Contains assemblies to use with frameworks that implements .NET Core 2.0.

netcoreapp3.0                                   Contains assemblies to use with frameworks that implements .NET Core 3.0.

netstandard2.0					Contains assemblies to use with frameworks that implements .NET Standard 2.0.

WPF4.0     					Contains assemblies to use with .NET Framework 4.0.

WPF4.0 ClientProfile				Contains assemblies to use with .NET Framework 4.0 Client Profile.


Note that netcoreapp2.0 and netcoreapp3.0 and netstandard2.0 dlls have external references:

netcoreapp2.0  					Has external reference to 	System.Drawing.Common >= 4.5.0
                                    						System.Text.Encoding.CodePages >= 4.5.0
										System.Security.Cryptography.Xml >=4.5.0

netcoreapp3.0  					Has external reference to 	System.Drawing.Common >= 4.7.0
                                    						System.Text.Encoding.CodePages >= 4.7.0
										System.Security.Cryptography.Xml >=4.7.0
                                      
netstandard2.0					Has external reference to 	SkiaSharp >= 1.68.0 
										System.Text.Encoding.CodePages >= 4.5.0
										System.Security.Cryptography.Xml >=4.5.0