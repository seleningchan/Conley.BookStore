using Microsoft.AspNetCore.Builder;
using Conley.BookStore;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("Conley.BookStore.Web.csproj"); 
await builder.RunAbpModuleAsync<BookStoreWebTestModule>(applicationName: "Conley.BookStore.Web");

public partial class Program
{
}
