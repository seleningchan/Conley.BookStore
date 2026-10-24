using Conley.BookStore.Books;
using Riok.Mapperly.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Mapperly;

namespace Conley.BookStore
{
    [Mapper]
    public partial class BookToBookDtoMapper : MapperBase<Book, BookDto>
    {
        public override partial BookDto Map(Book source);

        public override partial void Map(Book source, BookDto destination);

    }
}
