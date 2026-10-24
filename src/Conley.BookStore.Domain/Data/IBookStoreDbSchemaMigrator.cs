using System.Threading.Tasks;

namespace Conley.BookStore.Data;

public interface IBookStoreDbSchemaMigrator
{
    Task MigrateAsync();
}
