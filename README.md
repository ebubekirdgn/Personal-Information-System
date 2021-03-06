# PersonelInformationSystem
### 1 . Project Structure
```
├── PersonalInformationSystem
│   ├── PersonalInformationSystem.Business
│   │   ├── Contracts
│   │   │   ├── IPersonalLeaveRequestBusiness.cs
│   │   │   └── IPersonalLeaveTypesBusiness.cs
│   │   └── Implementation
│   │       ├── PersonalLeaveRequestBusiness.cs
│   │       └── PersonalLeaveTypesBusiness.cs
│   ├── PersonalInformationSystem.Common
│   │   ├── ConstantsModels
│   │   │   ├── ResultConstant.cs
│   │   │   └── SeedData.cs
│   │   ├── Mappings
│   │   │   └── Maps.cs
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
│   │   ├── Contracts
│   │   │   ├── IPersonalLeaveAllocationRepository.cs
│   │   │   ├── IPersonalLeaveRequestRepository.cs
│   │   │   ├── IPersonalLeaveTypeRepository.cs
│   │   │   ├── IPersonalRepository.cs
│   │   │   ├── IRepositoryBase.cs
│   │   │   └── IUnitOfWork.cs
│   │   ├── DataContext
│   │   │   └── PersonalInformationContext.cs
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
│   │   └── Models
│   │       ├── BaseEntity.cs
│   │       ├── Personal.cs
│   │       ├── PersonalLeaveAllocation.cs
│   │       ├── PersonalLeaveRequest.cs
│   │       └── PersonalLeaveType.cs
│   ├── PersonalInformationSystem.sln
│   └── PersonalInformationSystem.UI
│       ├── appsettings.json
│       ├── Areas
│       │   └── Identity
│       │       └── Pages
│       │           ├── Account
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
│       ├── Controllers
│       │   ├── HomeController.cs
│       │   └── PersonalLeaveTypesController.cs
│       ├── Program.cs
│       └── Views
│           ├── Error.cshtml
│           ├── Error.cshtml.cs
│           ├── Home
│           │   └── Index.cshtml
│           ├── Index.cshtml
│           ├── Index.cshtml.cs
│           ├── PersonalLeaveTypes
│           │   ├── Create.cshtml
│           │   ├── Edit.cshtml
│           │   └── Index.cshtml
│           ├── Privacy.cshtml
│           ├── Privacy.cshtml.cs
│           ├── Shared
│           │   ├── _Layout.cshtml
│           │   ├── _Layout.cshtml.css
│           │   ├── _LoginPartial.cshtml
│           │   └── _ValidationScriptsPartial.cshtml
│           ├── _ViewImports.cshtml
│           └── _ViewStart.cshtml
└── README.md
 ```
 
 ### 2. Project Requirements
```
├── PersonalInformationSystem
│   ├── PersonalInformationSystem.Business
 
│   ├── PersonalInformationSystem.Common
|	* AutoMapper (Version : 11.0.0)
│   ├── PersonalInformationSystem.DataAccess
|	* AutoMapper.Extensions.Microsoft.DependencyInjection (Version : 11.0.0)
|	* Microsoft.AspNetCore.Identity.EntityFrameworkCore (Version : 6.0.1)
|	* Microsoft.EntityFrameworkCore (Version : 6.0.1)
|	* Microsoft.EntityFrameworkCore.SqlServer (Version : 6.0.1)
|	* Microsoft.EntityFrameworkCore.Tools (Version : 6.0.1)
│   
│   └── PersonalInformationSystem.UI
│      	* AutoMapper.Extensions.Microsoft.DependencyInjection (Version : 11.0.0)
|	* Microsoft.AspNetCore.Identity.EntityFrameworkCore (Version : 6.0.1)
|	* Microsoft.AspNetCore.Identity.UI (Version : 6.0.1)
|	* Microsoft.AspNetCore.Mvc.Razor (Version : 2.2.0)
|	* Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation (Version : 6.0.1)
|	* Microsoft.AspNetCore.Session (Version : 2.2.0)
|	* Microsoft.EntityFrameworkCore.Design (Version : 6.0.1)
|	* Microsoft.EntityFrameworkCore.SqlServer (Version : 6.0.1)
|	* Microsoft.EntityFrameworkCore.Tools (Version : 6.0.1)
| 	* Microsoft.VisualStudio.Web.CodeGeneration.Design (Version : 6.0.1)
└── 
```
