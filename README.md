# TestSystemDataSQLite
Simple performance test of System.Data.SQLite

```
TestSystemDataSQLite

Installing:

EntityFramework.6.4.4
Microsoft.CSharp.4.7.0
Microsoft.NETCore.Platforms.3.1.0
Microsoft.Win32.Registry.4.7.0
Microsoft.Win32.SystemEvents.4.7.0
runtime.native.System.Data.SqlClient.sni.4.7.0
runtime.win-arm64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x64.runtime.native.System.Data.SqlClient.sni.4.4.0
runtime.win-x86.runtime.native.System.Data.SqlClient.sni.4.4.0
Stub.System.Data.SQLite.Core.NetStandard.1.0.118
System.CodeDom.4.7.0
System.ComponentModel.Annotations.4.7.0
System.Configuration.ConfigurationManager.4.7.0
System.Data.SqlClient.4.8.1
System.Data.SQLite.1.0.118
System.Data.SQLite.Core.1.0.118
System.Data.SQLite.EF6.1.0.118
System.Drawing.Common.4.7.0
System.Security.AccessControl.4.7.0
System.Security.Cryptography.ProtectedData.4.7.0
System.Security.Permissions.4.7.0
System.Security.Principal.Windows.4.7.0
System.Windows.Extensions.4.7.0
```

## Results

```
Time to insert 1000000 records: 11153 ms
Time to read 1000000 records: 361 ms

Time to insert 1000000 records: 11878 ms
Time to read 1000000 records: 461 ms

Time to insert 1000000 records: 11193 ms
Time to read 1000000 records: 350 ms
```
