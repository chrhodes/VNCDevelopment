Rem These Assemblies are needed for Log

gacutil -if Microsoft.Practices.EnterpriseLibrary.Common.dll
gacutil -if Microsoft.Practices.EnterpriseLibrary.Logging.dll
gacutil -if Microsoft.Practices.ObjectBuilder.dll

Rem PLLog

gacutil -if Log.dll