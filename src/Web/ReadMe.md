[Visual Studio 2017中使用Libman管理客户端库 - LamondLu - 博客园 (cnblogs.com)](https://www.cnblogs.com/lwqlun/p/9850261.html)

[通过 LibMan 在 ASP.NET Core 中获取客户端库 | Microsoft Docs](https://docs.microsoft.com/zh-cn/aspnet/core/client-side/libman/?view=aspnetcore-5.0)

库管理器 (LibMan) 是一个轻量型客户端库获取工具。 LibMan 可从文件系统或从内容分发网络 (CDN) 下载库和框架。 支持的 CDN 包括 CDNJS、jsDelivr 和 unpkg。 将提取所选库文件，并将其置于 ASP.NET Core 项目中的相应位置。



Grunt 是一种 JavaScript 任务运行程序，可自动执行脚本缩减、TypeScript 编译、代码质量“lint”工具、CSS 预处理器以及支持客户端开发所需的所有重复性工作。 

---------------

[Getting Started for Beginners · dotnet-architecture/eShopOnWeb Wiki (github.com)](https://github.com/dotnet-architecture/eShopOnWeb/wiki/Getting-Started-for-Beginners)

##### 项目分为两大块:ApplicationCore/Infrastructure/Web是基础的MVC架构Web程序

##### BlazorAdmin/BlazorShared作为Blazor 应用程序

##### PublicApi独立对外提供可访问接口,很可能采用不同的安全机制，其中利用基于 Cookie 的身份验证和 API 的基于表单的标准应用程序很可能使用基于令牌的身份验证



Infrastructure主要提供通用的基础服务和持久化。

数据访问和其他基础设施管道代码属于基础设施项目

1. Config文件夹定义实体与数据库表字段映射
2. Migrations定义数据库迁移
3. 在Data文件夹下定义用于持久化的数据库上下文`CatalogContext`和泛型仓储`EfRepository`
4. Identity文件夹下定义身份数据库上下文
5. Logging文件夹定义一个日志适配器
6. Services定义了一个通用的邮件发送基础服务



ApplicationCore领域层是一个项目的核心，用来定义业务规则并实现。其主要用来实体、值对象、聚合、仓储、领域服务和领域事件等.

1. Constants文件夹定义一些常量
2. Entities文件夹下定义聚合根和相关的实体及值对象
3. Exceptions文件夹定义公共的异常
4. Extensions定义一些扩展方法(可以抽象出一个Common层来放扩展方法)
5. Interfaces文件夹定义领域相关接口
6. Services文件夹定义领域服务。
7. Specifications文件夹下是实现的规约模式



Web/WebRazorPages：展现层

其实该项目架构是DDD经典四层架构，只不过其将应用层(Interfaces/Services)集成到展现层中去了.

应用层负责展现层与领域层之间的协调，协调业务对象来执行特定的应用程序。

1. Areas区域用于组织功能在这个示例中Identity 功能使用 Area 进行配置和定制
2. Extensions扩展是可以向现有对象添加方法的帮助器方法
3. HealthChecks健康检查是 ASP.NET 核心功能，用于可视化 web 应用程序的状态，以便用户(和 IT 人员)可以确定应用程序是否健康。

