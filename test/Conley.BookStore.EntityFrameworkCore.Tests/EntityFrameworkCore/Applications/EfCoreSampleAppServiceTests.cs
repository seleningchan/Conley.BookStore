using Conley.BookStore.Samples;
using Xunit;

namespace Conley.BookStore.EntityFrameworkCore.Applications;

[Collection(BookStoreTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BookStoreEntityFrameworkCoreTestModule>
{

}
