using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class BookDto: AuditedEntityDto<Guid>
    {
        public string Name { get; set; } 
        public Class1 Type { get; set; } 
        public DateTime PublishDate { get; set; } 
        public float Price { get; set; }
    }
}
