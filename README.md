# PersonelInformationSystem
```
Proje Yapısı 
├── PersonalInformationSystem
│   ├── PersonalInformationSystem.Business
│   │   ├── bin
│   │   │   └── Debug
│   │   │       └── net6.0
│   │   │           ├── PersonalInformationSystem.Business.deps.json
│   │   │           ├── PersonalInformationSystem.Business.dll
│   │   │           ├── PersonalInformationSystem.Business.pdb
│   │   │           ├── PersonalInformationSystem.Common.dll
│   │   │           ├── PersonalInformationSystem.Common.pdb
│   │   │           ├── PersonalInformationSystem.DataAccess.dll
│   │   │           ├── PersonalInformationSystem.DataAccess.pdb
│   │   │           └── ref
│   │   │               └── PersonalInformationSystem.Business.dll
│   │   ├── Contracts
│   │   │   ├── IPersonalLeaveRequestBusiness.cs
│   │   │   └── IPersonalLeaveTypesBusiness.cs
│   │   ├── GlobalBusinessJson.cs
│   │   ├── Implementation
│   │   │   ├── PersonalLeaveRequestBusiness.cs
│   │   │   └── PersonalLeaveTypesBusiness.cs
│   │   ├── obj
│   │   │   ├── Debug
│   │   │   │   └── net6.0
│   │   │   │       ├── PersonalInformationSystem.Business.AssemblyInfo.cs
│   │   │   │       ├── PersonalInformationSystem.Business.AssemblyInfoInputs.cache
│   │   │   │       ├── PersonalInformationSystem.Business.assets.cache
│   │   │   │       ├── PersonalInformationSystem.Business.csproj.AssemblyReference.cache
│   │   │   │       ├── PersonalInformationSystem.Business.csproj.CopyComplete
│   │   │   │       ├── PersonalInformationSystem.Business.csproj.CoreCompileInputs.cache
│   │   │   │       ├── PersonalInformationSystem.Business.csproj.FileListAbsolute.txt
│   │   │   │       ├── PersonalInformationSystem.Business.dll
│   │   │   │       ├── PersonalInformationSystem.Business.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── PersonalInformationSystem.Business.GlobalUsings.g.cs
│   │   │   │       ├── PersonalInformationSystem.Business.pdb
│   │   │   │       └── ref
│   │   │   │           └── PersonalInformationSystem.Business.dll
│   │   │   ├── PersonalInformationSystem.Business.csproj.nuget.dgspec.json
│   │   │   ├── PersonalInformationSystem.Business.csproj.nuget.g.props
│   │   │   ├── PersonalInformationSystem.Business.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   └── PersonalInformationSystem.Business.csproj
│   ├── PersonalInformationSystem.Common
│   │   ├── bin
│   │   │   └── Debug
│   │   │       └── net6.0
│   │   │           ├── PersonalInformationSystem.Common.deps.json
│   │   │           ├── PersonalInformationSystem.Common.dll
│   │   │           ├── PersonalInformationSystem.Common.pdb
│   │   │           ├── PersonalInformationSystem.DataAccess.dll
│   │   │           ├── PersonalInformationSystem.DataAccess.pdb
│   │   │           └── ref
│   │   │               └── PersonalInformationSystem.Common.dll
│   │   ├── ConstantsModels
│   │   │   ├── ResultConstant.cs
│   │   │   └── SeedData.cs
│   │   ├── GlobalCommonJson.cs
│   │   ├── Mappings
│   │   │   └── Maps.cs
│   │   ├── obj
│   │   │   ├── Debug
│   │   │   │   └── net6.0
│   │   │   │       ├── PersonalInformationSystem.Common.AssemblyInfo.cs
│   │   │   │       ├── PersonalInformationSystem.Common.AssemblyInfoInputs.cache
│   │   │   │       ├── PersonalInformationSystem.Common.assets.cache
│   │   │   │       ├── PersonalInformationSystem.Common.csproj.AssemblyReference.cache
│   │   │   │       ├── PersonalInformationSystem.Common.csproj.CopyComplete
│   │   │   │       ├── PersonalInformationSystem.Common.csproj.CoreCompileInputs.cache
│   │   │   │       ├── PersonalInformationSystem.Common.csproj.FileListAbsolute.txt
│   │   │   │       ├── PersonalInformationSystem.Common.dll
│   │   │   │       ├── PersonalInformationSystem.Common.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── PersonalInformationSystem.Common.GlobalUsings.g.cs
│   │   │   │       ├── PersonalInformationSystem.Common.pdb
│   │   │   │       └── ref
│   │   │   │           └── PersonalInformationSystem.Common.dll
│   │   │   ├── PersonalInformationSystem.Common.csproj.nuget.dgspec.json
│   │   │   ├── PersonalInformationSystem.Common.csproj.nuget.g.props
│   │   │   ├── PersonalInformationSystem.Common.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   ├── PersonalInformationSystem.Common.csproj
│   │   ├── ResultModels
│   │   │   ├── IResult.cs
│   │   │   └── Result.cs
│   │   ├── Session
│   │   │   └── SessionContext.cs
│   │   └── VModels
│   │       ├── BaseVM.cs
│   │       ├── PersonalLeaveAllocationsVM.cs
│   │       ├── PersonalLeaveRequestVM.cs
│   │       ├── PersonalLeaveTypeVM.cs
│   │       └── PersonalVM.cs
│   ├── PersonalInformationSystem.Data
│   │   ├── bin
│   │   │   └── Debug
│   │   │       └── net6.0
│   │   │           ├── PersonalInformationSystem.DataAccess.deps.json
│   │   │           ├── PersonalInformationSystem.DataAccess.dll
│   │   │           ├── PersonalInformationSystem.DataAccess.pdb
│   │   │           ├── PersonalInformationSystem.DataAccess.runtimeconfig.json
│   │   │           └── ref
│   │   │               └── PersonalInformationSystem.DataAccess.dll
│   │   ├── Contracts
│   │   │   ├── IPersonalLeaveAllocationRepository.cs
│   │   │   ├── IPersonalLeaveRequestRepository.cs
│   │   │   ├── IPersonalLeaveTypeRepository.cs
│   │   │   ├── IPersonalRepository.cs
│   │   │   ├── IRepositoryBase.cs
│   │   │   └── IUnitOfWork.cs
│   │   ├── DataContext
│   │   │   └── PersonalInformationContext.cs
│   │   ├── GlobalDataJson.cs
│   │   ├── Implementation
│   │   │   ├── PersonalLeaveAllocationRepository.cs
│   │   │   ├── PersonalLeaveRequestRepository.cs
│   │   │   ├── PersonalLeaveTypeRepository.cs
│   │   │   ├── PersonalRepository.cs
│   │   │   ├── Repository.cs
│   │   │   └── UnitOfWork.cs
│   │   ├── Migrations
│   │   │   ├── 20220209191435_Initiate.cs
│   │   │   ├── 20220209191435_Initiate.Designer.cs
│   │   │   └── PersonalInformationContextModelSnapshot.cs
│   │   ├── Models
│   │   │   ├── BaseEntity.cs
│   │   │   ├── Personal.cs
│   │   │   ├── PersonalLeaveAllocation.cs
│   │   │   ├── PersonalLeaveRequest.cs
│   │   │   └── PersonalLeaveType.cs
│   │   ├── obj
│   │   │   ├── Debug
│   │   │   │   └── net6.0
│   │   │   │       ├── PersonalInformationSystem.DataAccess.AssemblyInfo.cs
│   │   │   │       ├── PersonalInformationSystem.DataAccess.AssemblyInfoInputs.cache
│   │   │   │       ├── PersonalInformationSystem.DataAccess.assets.cache
│   │   │   │       ├── PersonalInformationSystem.DataAccess.csproj.AssemblyReference.cache
│   │   │   │       ├── PersonalInformationSystem.DataAccess.csproj.CoreCompileInputs.cache
│   │   │   │       ├── PersonalInformationSystem.DataAccess.csproj.FileListAbsolute.txt
│   │   │   │       ├── PersonalInformationSystem.DataAccess.dll
│   │   │   │       ├── PersonalInformationSystem.DataAccess.GeneratedMSBuildEditorConfig.editorconfig
│   │   │   │       ├── PersonalInformationSystem.DataAccess.genruntimeconfig.cache
│   │   │   │       ├── PersonalInformationSystem.DataAccess.GlobalUsings.g.cs
│   │   │   │       ├── PersonalInformationSystem.DataAccess.pdb
│   │   │   │       └── ref
│   │   │   │           └── PersonalInformationSystem.DataAccess.dll
│   │   │   ├── PersonalInformationSystem.DataAccess.csproj.nuget.dgspec.json
│   │   │   ├── PersonalInformationSystem.DataAccess.csproj.nuget.g.props
│   │   │   ├── PersonalInformationSystem.DataAccess.csproj.nuget.g.targets
│   │   │   ├── project.assets.json
│   │   │   └── project.nuget.cache
│   │   ├── PersonalInformationSystem - Backup.Data.csproj
│   │   └── PersonalInformationSystem.DataAccess.csproj
│   ├── PersonalInformationSystem.sln
│   └── PersonalInformationSystem.UI
│       ├── appsettings.Development.json
│       ├── appsettings.json
│       ├── Areas
│       │   └── Identity
│       │       └── Pages
│       │           ├── Account
│       │           │   ├── AccessDenied.cshtml
│       │           │   ├── AccessDenied.cshtml.cs
│       │           │   ├── ConfirmEmailChange.cshtml
│       │           │   ├── ConfirmEmailChange.cshtml.cs
│       │           │   ├── ConfirmEmail.cshtml
│       │           │   ├── ConfirmEmail.cshtml.cs
│       │           │   ├── ExternalLogin.cshtml
│       │           │   ├── ExternalLogin.cshtml.cs
│       │           │   ├── ForgotPasswordConfirmation.cshtml
│       │           │   ├── ForgotPasswordConfirmation.cshtml.cs
│       │           │   ├── ForgotPassword.cshtml
│       │           │   ├── ForgotPassword.cshtml.cs
│       │           │   ├── Lockout.cshtml
│       │           │   ├── Lockout.cshtml.cs
│       │           │   ├── Login.cshtml
│       │           │   ├── Login.cshtml.cs
│       │           │   ├── LoginWith2fa.cshtml
│       │           │   ├── LoginWith2fa.cshtml.cs
│       │           │   ├── LoginWithRecoveryCode.cshtml
│       │           │   ├── LoginWithRecoveryCode.cshtml.cs
│       │           │   ├── Logout.cshtml
│       │           │   ├── Logout.cshtml.cs
│       │           │   ├── Manage
│       │           │   │   ├── ChangePassword.cshtml
│       │           │   │   ├── ChangePassword.cshtml.cs
│       │           │   │   ├── DeletePersonalData.cshtml
│       │           │   │   ├── DeletePersonalData.cshtml.cs
│       │           │   │   ├── Disable2fa.cshtml
│       │           │   │   ├── Disable2fa.cshtml.cs
│       │           │   │   ├── DownloadPersonalData.cshtml
│       │           │   │   ├── DownloadPersonalData.cshtml.cs
│       │           │   │   ├── Email.cshtml
│       │           │   │   ├── Email.cshtml.cs
│       │           │   │   ├── EnableAuthenticator.cshtml
│       │           │   │   ├── EnableAuthenticator.cshtml.cs
│       │           │   │   ├── ExternalLogins.cshtml
│       │           │   │   ├── ExternalLogins.cshtml.cs
│       │           │   │   ├── GenerateRecoveryCodes.cshtml
│       │           │   │   ├── GenerateRecoveryCodes.cshtml.cs
│       │           │   │   ├── Index.cshtml
│       │           │   │   ├── Index.cshtml.cs
│       │           │   │   ├── _Layout.cshtml
│       │           │   │   ├── _ManageNav.cshtml
│       │           │   │   ├── ManageNavPages.cs
│       │           │   │   ├── PersonalData.cshtml
│       │           │   │   ├── PersonalData.cshtml.cs
│       │           │   │   ├── ResetAuthenticator.cshtml
│       │           │   │   ├── ResetAuthenticator.cshtml.cs
│       │           │   │   ├── SetPassword.cshtml
│       │           │   │   ├── SetPassword.cshtml.cs
│       │           │   │   ├── ShowRecoveryCodes.cshtml
│       │           │   │   ├── ShowRecoveryCodes.cshtml.cs
│       │           │   │   ├── _StatusMessage.cshtml
│       │           │   │   ├── TwoFactorAuthentication.cshtml
│       │           │   │   ├── TwoFactorAuthentication.cshtml.cs
│       │           │   │   └── _ViewImports.cshtml
│       │           │   ├── RegisterConfirmation.cshtml
│       │           │   ├── RegisterConfirmation.cshtml.cs
│       │           │   ├── Register.cshtml
│       │           │   ├── Register.cshtml.cs
│       │           │   ├── ResendEmailConfirmation.cshtml
│       │           │   ├── ResendEmailConfirmation.cshtml.cs
│       │           │   ├── ResetPasswordConfirmation.cshtml
│       │           │   ├── ResetPasswordConfirmation.cshtml.cs
│       │           │   ├── ResetPassword.cshtml
│       │           │   ├── ResetPassword.cshtml.cs
│       │           │   ├── _StatusMessage.cshtml
│       │           │   └── _ViewImports.cshtml
│       │           ├── Error.cshtml
│       │           ├── Error.cshtml.cs
│       │           ├── _ValidationScriptsPartial.cshtml
│       │           ├── _ViewImports.cshtml
│       │           └── _ViewStart.cshtml
│       ├── bin
│       │   └── Debug
│       │       └── net6.0
│       │           ├── appsettings.Development.json
│       │           ├── appsettings.json
│       │           ├── AutoMapper.dll
│       │           ├── AutoMapper.Extensions.Microsoft.DependencyInjection.dll
│       │           ├── cs
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── de
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── dotnet-aspnet-codegenerator-design.dll
│       │           ├── es
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── fr
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── Humanizer.dll
│       │           ├── it
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── ja
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── ko
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── MessagePack.Annotations.dll
│       │           ├── MessagePack.dll
│       │           ├── Microsoft.AspNetCore.Cryptography.Internal.dll
│       │           ├── Microsoft.AspNetCore.Cryptography.KeyDerivation.dll
│       │           ├── Microsoft.AspNetCore.Identity.EntityFrameworkCore.dll
│       │           ├── Microsoft.AspNetCore.Identity.UI.dll
│       │           ├── Microsoft.AspNetCore.JsonPatch.dll
│       │           ├── Microsoft.AspNetCore.Mvc.Razor.Extensions.dll
│       │           ├── Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation.dll
│       │           ├── Microsoft.AspNetCore.Razor.Language.dll
│       │           ├── Microsoft.Bcl.AsyncInterfaces.dll
│       │           ├── Microsoft.Build.Locator.dll
│       │           ├── Microsoft.CodeAnalysis.AnalyzerUtilities.dll
│       │           ├── Microsoft.CodeAnalysis.CSharp.dll
│       │           ├── Microsoft.CodeAnalysis.CSharp.Features.dll
│       │           ├── Microsoft.CodeAnalysis.CSharp.Scripting.dll
│       │           ├── Microsoft.CodeAnalysis.CSharp.Workspaces.dll
│       │           ├── Microsoft.CodeAnalysis.dll
│       │           ├── Microsoft.CodeAnalysis.Features.dll
│       │           ├── Microsoft.CodeAnalysis.Razor.dll
│       │           ├── Microsoft.CodeAnalysis.Scripting.dll
│       │           ├── Microsoft.CodeAnalysis.VisualBasic.dll
│       │           ├── Microsoft.CodeAnalysis.VisualBasic.Features.dll
│       │           ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.dll
│       │           ├── Microsoft.CodeAnalysis.Workspaces.dll
│       │           ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.dll
│       │           ├── Microsoft.Data.SqlClient.dll
│       │           ├── Microsoft.DiaSymReader.dll
│       │           ├── Microsoft.DotNet.Scaffolding.Shared.dll
│       │           ├── Microsoft.EntityFrameworkCore.Abstractions.dll
│       │           ├── Microsoft.EntityFrameworkCore.Design.dll
│       │           ├── Microsoft.EntityFrameworkCore.dll
│       │           ├── Microsoft.EntityFrameworkCore.Relational.dll
│       │           ├── Microsoft.EntityFrameworkCore.SqlServer.dll
│       │           ├── Microsoft.Extensions.DependencyModel.dll
│       │           ├── Microsoft.Extensions.FileProviders.Embedded.dll
│       │           ├── Microsoft.Extensions.Identity.Core.dll
│       │           ├── Microsoft.Extensions.Identity.Stores.dll
│       │           ├── Microsoft.Identity.Client.dll
│       │           ├── Microsoft.IdentityModel.JsonWebTokens.dll
│       │           ├── Microsoft.IdentityModel.Logging.dll
│       │           ├── Microsoft.IdentityModel.Protocols.dll
│       │           ├── Microsoft.IdentityModel.Protocols.OpenIdConnect.dll
│       │           ├── Microsoft.IdentityModel.Tokens.dll
│       │           ├── Microsoft.VisualStudio.Debugger.Contracts.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGeneration.Core.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGeneration.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGeneration.EntityFrameworkCore.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGeneration.Templating.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGeneration.Utils.dll
│       │           ├── Microsoft.VisualStudio.Web.CodeGenerators.Mvc.dll
│       │           ├── Microsoft.Win32.SystemEvents.dll
│       │           ├── Newtonsoft.Json.Bson.dll
│       │           ├── Newtonsoft.Json.dll
│       │           ├── NuGet.Common.dll
│       │           ├── NuGet.Configuration.dll
│       │           ├── NuGet.DependencyResolver.Core.dll
│       │           ├── NuGet.Frameworks.dll
│       │           ├── NuGet.LibraryModel.dll
│       │           ├── NuGet.Packaging.dll
│       │           ├── NuGet.ProjectModel.dll
│       │           ├── NuGet.Protocol.dll
│       │           ├── NuGet.Versioning.dll
│       │           ├── PersonalInformationSystem.Business.dll
│       │           ├── PersonalInformationSystem.Business.pdb
│       │           ├── PersonalInformationSystem.Common.dll
│       │           ├── PersonalInformationSystem.Common.pdb
│       │           ├── PersonalInformationSystem.DataAccess.dll
│       │           ├── PersonalInformationSystem.DataAccess.pdb
│       │           ├── PersonalInformationSystem.UI.deps.json
│       │           ├── PersonalInformationSystem.UI.dll
│       │           ├── PersonalInformationSystem.UI.exe
│       │           ├── PersonalInformationSystem.UI.pdb
│       │           ├── PersonalInformationSystem.UI.runtimeconfig.json
│       │           ├── PersonalInformationSystem.UI.staticwebassets.runtime.json
│       │           ├── pl
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── pt-BR
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── ref
│       │           │   └── PersonalInformationSystem.UI.dll
│       │           ├── refs
│       │           │   ├── Microsoft.AspNetCore.Antiforgery.dll
│       │           │   ├── Microsoft.AspNetCore.Authentication.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Authentication.Cookies.dll
│       │           │   ├── Microsoft.AspNetCore.Authentication.Core.dll
│       │           │   ├── Microsoft.AspNetCore.Authentication.dll
│       │           │   ├── Microsoft.AspNetCore.Authentication.OAuth.dll
│       │           │   ├── Microsoft.AspNetCore.Authorization.dll
│       │           │   ├── Microsoft.AspNetCore.Authorization.Policy.dll
│       │           │   ├── Microsoft.AspNetCore.Components.Authorization.dll
│       │           │   ├── Microsoft.AspNetCore.Components.dll
│       │           │   ├── Microsoft.AspNetCore.Components.Forms.dll
│       │           │   ├── Microsoft.AspNetCore.Components.Server.dll
│       │           │   ├── Microsoft.AspNetCore.Components.Web.dll
│       │           │   ├── Microsoft.AspNetCore.Connections.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.CookiePolicy.dll
│       │           │   ├── Microsoft.AspNetCore.Cors.dll
│       │           │   ├── Microsoft.AspNetCore.DataProtection.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.DataProtection.dll
│       │           │   ├── Microsoft.AspNetCore.DataProtection.Extensions.dll
│       │           │   ├── Microsoft.AspNetCore.Diagnostics.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Diagnostics.dll
│       │           │   ├── Microsoft.AspNetCore.Diagnostics.HealthChecks.dll
│       │           │   ├── Microsoft.AspNetCore.dll
│       │           │   ├── Microsoft.AspNetCore.HostFiltering.dll
│       │           │   ├── Microsoft.AspNetCore.Hosting.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Hosting.dll
│       │           │   ├── Microsoft.AspNetCore.Hosting.Server.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Html.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Connections.Common.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Connections.dll
│       │           │   ├── Microsoft.AspNetCore.Http.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Extensions.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Features.dll
│       │           │   ├── Microsoft.AspNetCore.HttpLogging.dll
│       │           │   ├── Microsoft.AspNetCore.HttpOverrides.dll
│       │           │   ├── Microsoft.AspNetCore.Http.Results.dll
│       │           │   ├── Microsoft.AspNetCore.HttpsPolicy.dll
│       │           │   ├── Microsoft.AspNetCore.Identity.dll
│       │           │   ├── Microsoft.AspNetCore.Localization.dll
│       │           │   ├── Microsoft.AspNetCore.Localization.Routing.dll
│       │           │   ├── Microsoft.AspNetCore.Metadata.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.ApiExplorer.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Core.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Cors.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.DataAnnotations.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Formatters.Json.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Formatters.Xml.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Localization.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.Razor.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.RazorPages.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.TagHelpers.dll
│       │           │   ├── Microsoft.AspNetCore.Mvc.ViewFeatures.dll
│       │           │   ├── Microsoft.AspNetCore.Razor.dll
│       │           │   ├── Microsoft.AspNetCore.Razor.Runtime.dll
│       │           │   ├── Microsoft.AspNetCore.ResponseCaching.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.ResponseCaching.dll
│       │           │   ├── Microsoft.AspNetCore.ResponseCompression.dll
│       │           │   ├── Microsoft.AspNetCore.Rewrite.dll
│       │           │   ├── Microsoft.AspNetCore.Routing.Abstractions.dll
│       │           │   ├── Microsoft.AspNetCore.Routing.dll
│       │           │   ├── Microsoft.AspNetCore.Server.HttpSys.dll
│       │           │   ├── Microsoft.AspNetCore.Server.IIS.dll
│       │           │   ├── Microsoft.AspNetCore.Server.IISIntegration.dll
│       │           │   ├── Microsoft.AspNetCore.Server.Kestrel.Core.dll
│       │           │   ├── Microsoft.AspNetCore.Server.Kestrel.dll
│       │           │   ├── Microsoft.AspNetCore.Server.Kestrel.Transport.Quic.dll
│       │           │   ├── Microsoft.AspNetCore.Server.Kestrel.Transport.Sockets.dll
│       │           │   ├── Microsoft.AspNetCore.Session.dll
│       │           │   ├── Microsoft.AspNetCore.SignalR.Common.dll
│       │           │   ├── Microsoft.AspNetCore.SignalR.Core.dll
│       │           │   ├── Microsoft.AspNetCore.SignalR.dll
│       │           │   ├── Microsoft.AspNetCore.SignalR.Protocols.Json.dll
│       │           │   ├── Microsoft.AspNetCore.StaticFiles.dll
│       │           │   ├── Microsoft.AspNetCore.WebSockets.dll
│       │           │   ├── Microsoft.AspNetCore.WebUtilities.dll
│       │           │   ├── Microsoft.CSharp.dll
│       │           │   ├── Microsoft.Extensions.Caching.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Caching.Memory.dll
│       │           │   ├── Microsoft.Extensions.Configuration.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Configuration.Binder.dll
│       │           │   ├── Microsoft.Extensions.Configuration.CommandLine.dll
│       │           │   ├── Microsoft.Extensions.Configuration.dll
│       │           │   ├── Microsoft.Extensions.Configuration.EnvironmentVariables.dll
│       │           │   ├── Microsoft.Extensions.Configuration.FileExtensions.dll
│       │           │   ├── Microsoft.Extensions.Configuration.Ini.dll
│       │           │   ├── Microsoft.Extensions.Configuration.Json.dll
│       │           │   ├── Microsoft.Extensions.Configuration.KeyPerFile.dll
│       │           │   ├── Microsoft.Extensions.Configuration.UserSecrets.dll
│       │           │   ├── Microsoft.Extensions.Configuration.Xml.dll
│       │           │   ├── Microsoft.Extensions.DependencyInjection.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.DependencyInjection.dll
│       │           │   ├── Microsoft.Extensions.Diagnostics.HealthChecks.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Diagnostics.HealthChecks.dll
│       │           │   ├── Microsoft.Extensions.Features.dll
│       │           │   ├── Microsoft.Extensions.FileProviders.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.FileProviders.Composite.dll
│       │           │   ├── Microsoft.Extensions.FileProviders.Physical.dll
│       │           │   ├── Microsoft.Extensions.FileSystemGlobbing.dll
│       │           │   ├── Microsoft.Extensions.Hosting.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Hosting.dll
│       │           │   ├── Microsoft.Extensions.Http.dll
│       │           │   ├── Microsoft.Extensions.Localization.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Localization.dll
│       │           │   ├── Microsoft.Extensions.Logging.Abstractions.dll
│       │           │   ├── Microsoft.Extensions.Logging.Configuration.dll
│       │           │   ├── Microsoft.Extensions.Logging.Console.dll
│       │           │   ├── Microsoft.Extensions.Logging.Debug.dll
│       │           │   ├── Microsoft.Extensions.Logging.dll
│       │           │   ├── Microsoft.Extensions.Logging.EventLog.dll
│       │           │   ├── Microsoft.Extensions.Logging.EventSource.dll
│       │           │   ├── Microsoft.Extensions.Logging.TraceSource.dll
│       │           │   ├── Microsoft.Extensions.ObjectPool.dll
│       │           │   ├── Microsoft.Extensions.Options.ConfigurationExtensions.dll
│       │           │   ├── Microsoft.Extensions.Options.DataAnnotations.dll
│       │           │   ├── Microsoft.Extensions.Options.dll
│       │           │   ├── Microsoft.Extensions.Primitives.dll
│       │           │   ├── Microsoft.Extensions.WebEncoders.dll
│       │           │   ├── Microsoft.JSInterop.dll
│       │           │   ├── Microsoft.Net.Http.Headers.dll
│       │           │   ├── Microsoft.VisualBasic.Core.dll
│       │           │   ├── Microsoft.VisualBasic.dll
│       │           │   ├── Microsoft.Win32.Primitives.dll
│       │           │   ├── Microsoft.Win32.Registry.dll
│       │           │   ├── mscorlib.dll
│       │           │   ├── netstandard.dll
│       │           │   ├── System.AppContext.dll
│       │           │   ├── System.Buffers.dll
│       │           │   ├── System.Collections.Concurrent.dll
│       │           │   ├── System.Collections.dll
│       │           │   ├── System.Collections.Immutable.dll
│       │           │   ├── System.Collections.NonGeneric.dll
│       │           │   ├── System.Collections.Specialized.dll
│       │           │   ├── System.ComponentModel.Annotations.dll
│       │           │   ├── System.ComponentModel.DataAnnotations.dll
│       │           │   ├── System.ComponentModel.dll
│       │           │   ├── System.ComponentModel.EventBasedAsync.dll
│       │           │   ├── System.ComponentModel.Primitives.dll
│       │           │   ├── System.ComponentModel.TypeConverter.dll
│       │           │   ├── System.Configuration.dll
│       │           │   ├── System.Console.dll
│       │           │   ├── System.Core.dll
│       │           │   ├── System.Data.Common.dll
│       │           │   ├── System.Data.DataSetExtensions.dll
│       │           │   ├── System.Data.dll
│       │           │   ├── System.Diagnostics.Contracts.dll
│       │           │   ├── System.Diagnostics.Debug.dll
│       │           │   ├── System.Diagnostics.DiagnosticSource.dll
│       │           │   ├── System.Diagnostics.EventLog.dll
│       │           │   ├── System.Diagnostics.FileVersionInfo.dll
│       │           │   ├── System.Diagnostics.Process.dll
│       │           │   ├── System.Diagnostics.StackTrace.dll
│       │           │   ├── System.Diagnostics.TextWriterTraceListener.dll
│       │           │   ├── System.Diagnostics.Tools.dll
│       │           │   ├── System.Diagnostics.TraceSource.dll
│       │           │   ├── System.Diagnostics.Tracing.dll
│       │           │   ├── System.dll
│       │           │   ├── System.Drawing.dll
│       │           │   ├── System.Drawing.Primitives.dll
│       │           │   ├── System.Dynamic.Runtime.dll
│       │           │   ├── System.Formats.Asn1.dll
│       │           │   ├── System.Globalization.Calendars.dll
│       │           │   ├── System.Globalization.dll
│       │           │   ├── System.Globalization.Extensions.dll
│       │           │   ├── System.IO.Compression.Brotli.dll
│       │           │   ├── System.IO.Compression.dll
│       │           │   ├── System.IO.Compression.FileSystem.dll
│       │           │   ├── System.IO.Compression.ZipFile.dll
│       │           │   ├── System.IO.dll
│       │           │   ├── System.IO.FileSystem.AccessControl.dll
│       │           │   ├── System.IO.FileSystem.dll
│       │           │   ├── System.IO.FileSystem.DriveInfo.dll
│       │           │   ├── System.IO.FileSystem.Primitives.dll
│       │           │   ├── System.IO.FileSystem.Watcher.dll
│       │           │   ├── System.IO.IsolatedStorage.dll
│       │           │   ├── System.IO.MemoryMappedFiles.dll
│       │           │   ├── System.IO.Pipelines.dll
│       │           │   ├── System.IO.Pipes.AccessControl.dll
│       │           │   ├── System.IO.Pipes.dll
│       │           │   ├── System.IO.UnmanagedMemoryStream.dll
│       │           │   ├── System.Linq.dll
│       │           │   ├── System.Linq.Expressions.dll
│       │           │   ├── System.Linq.Parallel.dll
│       │           │   ├── System.Linq.Queryable.dll
│       │           │   ├── System.Memory.dll
│       │           │   ├── System.Net.dll
│       │           │   ├── System.Net.Http.dll
│       │           │   ├── System.Net.Http.Json.dll
│       │           │   ├── System.Net.HttpListener.dll
│       │           │   ├── System.Net.Mail.dll
│       │           │   ├── System.Net.NameResolution.dll
│       │           │   ├── System.Net.NetworkInformation.dll
│       │           │   ├── System.Net.Ping.dll
│       │           │   ├── System.Net.Primitives.dll
│       │           │   ├── System.Net.Requests.dll
│       │           │   ├── System.Net.Security.dll
│       │           │   ├── System.Net.ServicePoint.dll
│       │           │   ├── System.Net.Sockets.dll
│       │           │   ├── System.Net.WebClient.dll
│       │           │   ├── System.Net.WebHeaderCollection.dll
│       │           │   ├── System.Net.WebProxy.dll
│       │           │   ├── System.Net.WebSockets.Client.dll
│       │           │   ├── System.Net.WebSockets.dll
│       │           │   ├── System.Numerics.dll
│       │           │   ├── System.Numerics.Vectors.dll
│       │           │   ├── System.ObjectModel.dll
│       │           │   ├── System.Reflection.DispatchProxy.dll
│       │           │   ├── System.Reflection.dll
│       │           │   ├── System.Reflection.Emit.dll
│       │           │   ├── System.Reflection.Emit.ILGeneration.dll
│       │           │   ├── System.Reflection.Emit.Lightweight.dll
│       │           │   ├── System.Reflection.Extensions.dll
│       │           │   ├── System.Reflection.Metadata.dll
│       │           │   ├── System.Reflection.Primitives.dll
│       │           │   ├── System.Reflection.TypeExtensions.dll
│       │           │   ├── System.Resources.Reader.dll
│       │           │   ├── System.Resources.ResourceManager.dll
│       │           │   ├── System.Resources.Writer.dll
│       │           │   ├── System.Runtime.CompilerServices.Unsafe.dll
│       │           │   ├── System.Runtime.CompilerServices.VisualC.dll
│       │           │   ├── System.Runtime.dll
│       │           │   ├── System.Runtime.Extensions.dll
│       │           │   ├── System.Runtime.Handles.dll
│       │           │   ├── System.Runtime.InteropServices.dll
│       │           │   ├── System.Runtime.InteropServices.RuntimeInformation.dll
│       │           │   ├── System.Runtime.Intrinsics.dll
│       │           │   ├── System.Runtime.Loader.dll
│       │           │   ├── System.Runtime.Numerics.dll
│       │           │   ├── System.Runtime.Serialization.dll
│       │           │   ├── System.Runtime.Serialization.Formatters.dll
│       │           │   ├── System.Runtime.Serialization.Json.dll
│       │           │   ├── System.Runtime.Serialization.Primitives.dll
│       │           │   ├── System.Runtime.Serialization.Xml.dll
│       │           │   ├── System.Security.AccessControl.dll
│       │           │   ├── System.Security.Claims.dll
│       │           │   ├── System.Security.Cryptography.Algorithms.dll
│       │           │   ├── System.Security.Cryptography.Cng.dll
│       │           │   ├── System.Security.Cryptography.Csp.dll
│       │           │   ├── System.Security.Cryptography.Encoding.dll
│       │           │   ├── System.Security.Cryptography.OpenSsl.dll
│       │           │   ├── System.Security.Cryptography.Primitives.dll
│       │           │   ├── System.Security.Cryptography.X509Certificates.dll
│       │           │   ├── System.Security.Cryptography.Xml.dll
│       │           │   ├── System.Security.dll
│       │           │   ├── System.Security.Principal.dll
│       │           │   ├── System.Security.Principal.Windows.dll
│       │           │   ├── System.Security.SecureString.dll
│       │           │   ├── System.ServiceModel.Web.dll
│       │           │   ├── System.ServiceProcess.dll
│       │           │   ├── System.Text.Encoding.CodePages.dll
│       │           │   ├── System.Text.Encoding.dll
│       │           │   ├── System.Text.Encoding.Extensions.dll
│       │           │   ├── System.Text.Encodings.Web.dll
│       │           │   ├── System.Text.Json.dll
│       │           │   ├── System.Text.RegularExpressions.dll
│       │           │   ├── System.Threading.Channels.dll
│       │           │   ├── System.Threading.dll
│       │           │   ├── System.Threading.Overlapped.dll
│       │           │   ├── System.Threading.Tasks.Dataflow.dll
│       │           │   ├── System.Threading.Tasks.dll
│       │           │   ├── System.Threading.Tasks.Extensions.dll
│       │           │   ├── System.Threading.Tasks.Parallel.dll
│       │           │   ├── System.Threading.Thread.dll
│       │           │   ├── System.Threading.ThreadPool.dll
│       │           │   ├── System.Threading.Timer.dll
│       │           │   ├── System.Transactions.dll
│       │           │   ├── System.Transactions.Local.dll
│       │           │   ├── System.ValueTuple.dll
│       │           │   ├── System.Web.dll
│       │           │   ├── System.Web.HttpUtility.dll
│       │           │   ├── System.Windows.dll
│       │           │   ├── System.Xml.dll
│       │           │   ├── System.Xml.Linq.dll
│       │           │   ├── System.Xml.ReaderWriter.dll
│       │           │   ├── System.Xml.Serialization.dll
│       │           │   ├── System.Xml.XDocument.dll
│       │           │   ├── System.Xml.XmlDocument.dll
│       │           │   ├── System.Xml.XmlSerializer.dll
│       │           │   ├── System.Xml.XPath.dll
│       │           │   ├── System.Xml.XPath.XDocument.dll
│       │           │   └── WindowsBase.dll
│       │           ├── ru
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── runtimes
│       │           │   ├── unix
│       │           │   │   └── lib
│       │           │   │       ├── netcoreapp3.0
│       │           │   │       │   └── System.Drawing.Common.dll
│       │           │   │       └── netcoreapp3.1
│       │           │   │           └── Microsoft.Data.SqlClient.dll
│       │           │   ├── win
│       │           │   │   └── lib
│       │           │   │       ├── netcoreapp3.0
│       │           │   │       │   ├── Microsoft.Win32.SystemEvents.dll
│       │           │   │       │   ├── System.Drawing.Common.dll
│       │           │   │       │   └── System.Windows.Extensions.dll
│       │           │   │       ├── netcoreapp3.1
│       │           │   │       │   └── Microsoft.Data.SqlClient.dll
│       │           │   │       └── netstandard2.0
│       │           │   │           ├── System.Runtime.Caching.dll
│       │           │   │           └── System.Security.Cryptography.ProtectedData.dll
│       │           │   ├── win-arm
│       │           │   │   ├── lib
│       │           │   │   │   └── net6.0
│       │           │   │   │       └── dotnet-aspnet-codegenerator-design.exe
│       │           │   │   └── native
│       │           │   │       └── Microsoft.Data.SqlClient.SNI.dll
│       │           │   ├── win-arm64
│       │           │   │   ├── lib
│       │           │   │   │   └── net6.0
│       │           │   │   │       └── dotnet-aspnet-codegenerator-design.exe
│       │           │   │   └── native
│       │           │   │       └── Microsoft.Data.SqlClient.SNI.dll
│       │           │   ├── win-x64
│       │           │   │   └── native
│       │           │   │       └── Microsoft.Data.SqlClient.SNI.dll
│       │           │   └── win-x86
│       │           │       └── native
│       │           │           └── Microsoft.Data.SqlClient.SNI.dll
│       │           ├── System.Composition.AttributedModel.dll
│       │           ├── System.Composition.Convention.dll
│       │           ├── System.Composition.Hosting.dll
│       │           ├── System.Composition.Runtime.dll
│       │           ├── System.Composition.TypedParts.dll
│       │           ├── System.Configuration.ConfigurationManager.dll
│       │           ├── System.Drawing.Common.dll
│       │           ├── System.IdentityModel.Tokens.Jwt.dll
│       │           ├── System.Runtime.Caching.dll
│       │           ├── System.Security.Cryptography.ProtectedData.dll
│       │           ├── System.Security.Permissions.dll
│       │           ├── System.Windows.Extensions.dll
│       │           ├── tr
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           ├── zh-Hans
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │           │   ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │           │   └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       │           └── zh-Hant
│       │               ├── Microsoft.CodeAnalysis.CSharp.Features.resources.dll
│       │               ├── Microsoft.CodeAnalysis.CSharp.resources.dll
│       │               ├── Microsoft.CodeAnalysis.CSharp.Scripting.resources.dll
│       │               ├── Microsoft.CodeAnalysis.CSharp.Workspaces.resources.dll
│       │               ├── Microsoft.CodeAnalysis.Features.resources.dll
│       │               ├── Microsoft.CodeAnalysis.resources.dll
│       │               ├── Microsoft.CodeAnalysis.Scripting.resources.dll
│       │               ├── Microsoft.CodeAnalysis.VisualBasic.Features.resources.dll
│       │               ├── Microsoft.CodeAnalysis.VisualBasic.resources.dll
│       │               ├── Microsoft.CodeAnalysis.VisualBasic.Workspaces.resources.dll
│       │               ├── Microsoft.CodeAnalysis.Workspaces.MSBuild.resources.dll
│       │               └── Microsoft.CodeAnalysis.Workspaces.resources.dll
│       ├── Controllers
│       │   ├── HomeController.cs
│       │   └── PersonalLeaveTypesController.cs
│       ├── GlobalUIJson.cs
│       ├── obj
│       │   ├── Debug
│       │   │   └── net6.0
│       │   │       ├── apphost.exe
│       │   │       ├── PersonalInformationSystem.UI.AssemblyInfo.cs
│       │   │       ├── PersonalInformationSystem.UI.AssemblyInfoInputs.cache
│       │   │       ├── PersonalInformationSystem.UI.assets.cache
│       │   │       ├── PersonalInformationSystem.UI.csproj.AssemblyReference.cache
│       │   │       ├── PersonalInformationSystem.UI.csproj.CopyComplete
│       │   │       ├── PersonalInformationSystem.UI.csproj.CoreCompileInputs.cache
│       │   │       ├── PersonalInformationSystem.UI.csproj.FileListAbsolute.txt
│       │   │       ├── PersonalInformationSystem.UI.dll
│       │   │       ├── PersonalInformationSystem.UI.GeneratedMSBuildEditorConfig.editorconfig
│       │   │       ├── PersonalInformationSystem.UI.genruntimeconfig.cache
│       │   │       ├── PersonalInformationSystem.UI.GlobalUsings.g.cs
│       │   │       ├── PersonalInformationSystem.UI.MvcApplicationPartsAssemblyInfo.cache
│       │   │       ├── PersonalInformationSystem.UI.MvcApplicationPartsAssemblyInfo.cs
│       │   │       ├── PersonalInformationSystem.UI.pdb
│       │   │       ├── PersonalInformationSystem.UI.RazorAssemblyInfo.cache
│       │   │       ├── PersonalInformationSystem.UI.RazorAssemblyInfo.cs
│       │   │       ├── project.razor.json
│       │   │       ├── ref
│       │   │       │   └── PersonalInformationSystem.UI.dll
│       │   │       ├── scopedcss
│       │   │       │   ├── bundle
│       │   │       │   │   └── PersonalInformationSystem.UI.styles.css
│       │   │       │   ├── projectbundle
│       │   │       │   │   └── PersonalInformationSystem.UI.bundle.scp.css
│       │   │       │   └── Views
│       │   │       │       └── Shared
│       │   │       │           └── _Layout.cshtml.rz.scp.css
│       │   │       ├── staticwebassets
│       │   │       ├── staticwebassets.build.json
│       │   │       └── staticwebassets.development.json
│       │   ├── PersonalInformationSystem.UI.csproj.nuget.dgspec.json
│       │   ├── PersonalInformationSystem.UI.csproj.nuget.g.props
│       │   ├── PersonalInformationSystem.UI.csproj.nuget.g.targets
│       │   ├── project.assets.json
│       │   ├── project.nuget.cache
│       │   └── staticwebassets.pack.sentinel
│       ├── PersonalInformationSystem.UI.csproj
│       ├── Program.cs
│       ├── Properties
│       │   └── launchSettings.json
│       ├── ScaffoldingReadMe.txt
│       ├── Views
│       │   ├── Error.cshtml
│       │   ├── Error.cshtml.cs
│       │   ├── Home
│       │   │   └── Index.cshtml
│       │   ├── Index.cshtml
│       │   ├── Index.cshtml.cs
│       │   ├── PersonalLeaveTypes
│       │   │   ├── Create.cshtml
│       │   │   ├── Edit.cshtml
│       │   │   └── Index.cshtml
│       │   ├── Privacy.cshtml
│       │   ├── Privacy.cshtml.cs
│       │   ├── Shared
│       │   │   ├── _Layout.cshtml
│       │   │   ├── _Layout.cshtml.css
│       │   │   ├── _LoginPartial.cshtml
│       │   │   └── _ValidationScriptsPartial.cshtml
│       │   ├── _ViewImports.cshtml
│       │   └── _ViewStart.cshtml
│       └── wwwroot
│           ├── css
│           │   ├── ace-ie.min.css
│           │   ├── ace.min.css
│           │   ├── ace-part2.min.css
│           │   ├── ace-rtl.min.css
│           │   ├── ace-skins.min.css
│           │   ├── bootstrap-colorpicker.min.css
│           │   ├── bootstrap-datepicker3.min.css
│           │   ├── bootstrap-datetimepicker.min.css
│           │   ├── bootstrap-duallistbox.min.css
│           │   ├── bootstrap-editable.min.css
│           │   ├── bootstrap.min.css
│           │   ├── bootstrap-multiselect.min.css
│           │   ├── bootstrap-timepicker.min.css
│           │   ├── chosen.min.css
│           │   ├── colorbox.min.css
│           │   ├── daterangepicker.min.css
│           │   ├── dropzone.min.css
│           │   ├── font-awesome.min.css
│           │   ├── fonts.googleapis.com.css
│           │   ├── fullcalendar.min.css
│           │   ├── jquery.gritter.min.css
│           │   ├── jquery-ui.custom.min.css
│           │   ├── jquery-ui.min.css
│           │   ├── prettify.min.css
│           │   ├── select2.min.css
│           │   ├── site.css
│           │   └── ui.jqgrid.min.css
│           ├── CustomImages
│           │   └── dc878ec6-f66c-4a24-bf43-4519386f83d8_buttonBack.jpg
│           ├── favicon.ico
│           ├── font-awesome
│           │   └── 4.5.0
│           │       ├── css
│           │       │   └── font-awesome.min.css
│           │       └── fonts
│           │           ├── fontawesome-webfont.eot
│           │           ├── fontawesome-webfont.svg
│           │           ├── fontawesome-webfont.ttf
│           │           ├── fontawesome-webfont.woff
│           │           └── fontawesome-webfont.woff2
│           ├── fonts
│           │   ├── glyphicons-halflings-regular.eot
│           │   ├── glyphicons-halflings-regular.svg
│           │   ├── glyphicons-halflings-regular.ttf
│           │   ├── glyphicons-halflings-regular.woff
│           │   └── glyphicons-halflings-regular.woff2
│           ├── images
│           │   ├── avatars
│           │   │   ├── avatar1.png
│           │   │   ├── avatar2.png
│           │   │   ├── avatar3.png
│           │   │   ├── avatar4.png
│           │   │   ├── avatar5.png
│           │   │   ├── avatar.png
│           │   │   ├── profile-pic.jpg
│           │   │   └── user.jpg
│           │   ├── bootstrap-colorpicker
│           │   │   ├── alpha-horizontal.png
│           │   │   ├── alpha.png
│           │   │   ├── hue-horizontal.png
│           │   │   ├── hue.png
│           │   │   └── saturation.png
│           │   ├── email
│           │   │   ├── email1.png
│           │   │   ├── email2.png
│           │   │   ├── email3.png
│           │   │   └── email4.png
│           │   ├── gallery
│           │   │   ├── image-1.jpg
│           │   │   ├── image-2.jpg
│           │   │   ├── image-3.jpg
│           │   │   ├── image-4.jpg
│           │   │   ├── image-5.jpg
│           │   │   ├── image-6.jpg
│           │   │   ├── thumb-1.jpg
│           │   │   ├── thumb-2.jpg
│           │   │   ├── thumb-3.jpg
│           │   │   ├── thumb-4.jpg
│           │   │   ├── thumb-5.jpg
│           │   │   └── thumb-6.jpg
│           │   └── placeholder
│           │       ├── 165x90.png
│           │       ├── 255x150.png
│           │       ├── 530x270.png
│           │       └── 550x280.png
│           ├── js
│           │   ├── ace-editable.min.js
│           │   ├── ace-elements.min.js
│           │   ├── ace-extra.min.js
│           │   ├── ace.min.js
│           │   ├── autosize.min.js
│           │   ├── bootbox.js
│           │   ├── bootstrap-colorpicker.min.js
│           │   ├── bootstrap-datepicker.min.js
│           │   ├── bootstrap-datetimepicker.min.js
│           │   ├── bootstrap-editable.min.js
│           │   ├── bootstrap-markdown.min.js
│           │   ├── bootstrap.min.js
│           │   ├── bootstrap-multiselect.min.js
│           │   ├── bootstrap-tag.min.js
│           │   ├── bootstrap-timepicker.min.js
│           │   ├── bootstrap-wysiwyg.min.js
│           │   ├── buttons.colVis.min.js
│           │   ├── buttons.flash.min.js
│           │   ├── buttons.html5.min.js
│           │   ├── buttons.print.min.js
│           │   ├── chosen.jquery.min.js
│           │   ├── dataTables.buttons.min.js
│           │   ├── dataTables.select.min.js
│           │   ├── daterangepicker.min.js
│           │   ├── dropzone.min.js
│           │   ├── excanvas.min.js
│           │   ├── fullcalendar.min.js
│           │   ├── grid.locale-en.js
│           │   ├── holder.min.js
│           │   ├── html5shiv.min.js
│           │   ├── jquery-1.11.3.min.js
│           │   ├── jquery-2.1.4.min.js
│           │   ├── jquery-additional-methods.min.js
│           │   ├── jquery.bootstrap-duallistbox.min.js
│           │   ├── jquery.colorbox.min.js
│           │   ├── jquery.dataTables.bootstrap.min.js
│           │   ├── jquery.dataTables.min.js
│           │   ├── jquery.easypiechart.min.js
│           │   ├── jquery.flot.min.js
│           │   ├── jquery.flot.pie.min.js
│           │   ├── jquery.flot.resize.min.js
│           │   ├── jquery.gritter.min.js
│           │   ├── jquery.hotkeys.index.min.js
│           │   ├── jquery.inputlimiter.min.js
│           │   ├── jquery.jqGrid.min.js
│           │   ├── jquery.knob.min.js
│           │   ├── jquery.maskedinput.min.js
│           │   ├── jquery.mobile.custom.min.js
│           │   ├── jquery.nestable.min.js
│           │   ├── jquery.raty.min.js
│           │   ├── jquery.sparkline.index.min.js
│           │   ├── jquery-typeahead.js
│           │   ├── jquery-ui.custom.min.js
│           │   ├── jquery-ui.min.js
│           │   ├── jquery.ui.touch-punch.min.js
│           │   ├── jquery.validate.min.js
│           │   ├── markdown.min.js
│           │   ├── moment.min.js
│           │   ├── prettify.min.js
│           │   ├── respond.min.js
│           │   ├── select2.min.js
│           │   ├── site.js
│           │   ├── spinbox.min.js
│           │   ├── spin.js
│           │   ├── tree.min.js
│           │   └── wizard.min.js
│           ├── lib
│           │   ├── bootstrap
│           │   │   ├── dist
│           │   │   │   ├── css
│           │   │   │   │   ├── bootstrap.css
│           │   │   │   │   ├── bootstrap.css.map
│           │   │   │   │   ├── bootstrap-grid.css
│           │   │   │   │   ├── bootstrap-grid.css.map
│           │   │   │   │   ├── bootstrap-grid.min.css
│           │   │   │   │   ├── bootstrap-grid.min.css.map
│           │   │   │   │   ├── bootstrap-grid.rtl.css
│           │   │   │   │   ├── bootstrap-grid.rtl.css.map
│           │   │   │   │   ├── bootstrap-grid.rtl.min.css
│           │   │   │   │   ├── bootstrap-grid.rtl.min.css.map
│           │   │   │   │   ├── bootstrap.min.css
│           │   │   │   │   ├── bootstrap.min.css.map
│           │   │   │   │   ├── bootstrap-reboot.css
│           │   │   │   │   ├── bootstrap-reboot.css.map
│           │   │   │   │   ├── bootstrap-reboot.min.css
│           │   │   │   │   ├── bootstrap-reboot.min.css.map
│           │   │   │   │   ├── bootstrap-reboot.rtl.css
│           │   │   │   │   ├── bootstrap-reboot.rtl.css.map
│           │   │   │   │   ├── bootstrap-reboot.rtl.min.css
│           │   │   │   │   ├── bootstrap-reboot.rtl.min.css.map
│           │   │   │   │   ├── bootstrap.rtl.css
│           │   │   │   │   ├── bootstrap.rtl.css.map
│           │   │   │   │   ├── bootstrap.rtl.min.css
│           │   │   │   │   ├── bootstrap.rtl.min.css.map
│           │   │   │   │   ├── bootstrap-utilities.css
│           │   │   │   │   ├── bootstrap-utilities.css.map
│           │   │   │   │   ├── bootstrap-utilities.min.css
│           │   │   │   │   ├── bootstrap-utilities.min.css.map
│           │   │   │   │   ├── bootstrap-utilities.rtl.css
│           │   │   │   │   ├── bootstrap-utilities.rtl.css.map
│           │   │   │   │   ├── bootstrap-utilities.rtl.min.css
│           │   │   │   │   └── bootstrap-utilities.rtl.min.css.map
│           │   │   │   └── js
│           │   │   │       ├── bootstrap.bundle.js
│           │   │   │       ├── bootstrap.bundle.js.map
│           │   │   │       ├── bootstrap.bundle.min.js
│           │   │   │       ├── bootstrap.bundle.min.js.map
│           │   │   │       ├── bootstrap.esm.js
│           │   │   │       ├── bootstrap.esm.js.map
│           │   │   │       ├── bootstrap.esm.min.js
│           │   │   │       ├── bootstrap.esm.min.js.map
│           │   │   │       ├── bootstrap.js
│           │   │   │       ├── bootstrap.js.map
│           │   │   │       ├── bootstrap.min.js
│           │   │   │       └── bootstrap.min.js.map
│           │   │   └── LICENSE
│           │   ├── jquery
│           │   │   ├── dist
│           │   │   │   ├── jquery.js
│           │   │   │   ├── jquery.min.js
│           │   │   │   └── jquery.min.map
│           │   │   └── LICENSE.txt
│           │   ├── jquery-validation
│           │   │   ├── dist
│           │   │   │   ├── additional-methods.js
│           │   │   │   ├── additional-methods.min.js
│           │   │   │   ├── jquery.validate.js
│           │   │   │   └── jquery.validate.min.js
│           │   │   └── LICENSE.md
│           │   └── jquery-validation-unobtrusive
│           │       ├── jquery.validate.unobtrusive.js
│           │       ├── jquery.validate.unobtrusive.min.js
│           │       └── LICENSE.txt
│           └── swf
│               └── flashExport.swf
└── README.md

128 directories, 987 files

Projede Kullanılan Kütüphaneler
1. First list item
   - First nested list item
     - Second nested list item
