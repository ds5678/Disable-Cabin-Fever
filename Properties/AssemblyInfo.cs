using MelonLoader;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BuildInfo = DisableCabinFever.BuildInfo;

[assembly: ComVisible(false)]
[assembly: Guid("81d23335-3e59-434d-9a0f-14dfcd147e37")]

[assembly: AssemblyTitle(BuildInfo.Name)]
[assembly: AssemblyDescription(BuildInfo.Description)]
[assembly: AssemblyCompany(BuildInfo.Company)]
[assembly: AssemblyProduct(BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + BuildInfo.Author)]
[assembly: AssemblyTrademark(BuildInfo.Company)]
[assembly: AssemblyCulture("")]

[assembly: AssemblyVersion(BuildInfo.Version)]
[assembly: AssemblyFileVersion(BuildInfo.Version)]
[assembly: MelonInfo(typeof(DisableCabinFever.Implementation), BuildInfo.Name, BuildInfo.Version, BuildInfo.Author, BuildInfo.DownloadLink)]
[assembly: MelonGame("Hinterland", "TheLongDark")]