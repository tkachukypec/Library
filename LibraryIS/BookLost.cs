//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryIS
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookLost
    {
        public int Id { get; set; }
        public int LibrarianId { get; set; }
        public int ClientId { get; set; }
        public int PublicationId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Librarian Librarian { get; set; }
        public virtual Publication Publication { get; set; }
    }
}
