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
    
    public partial class Warnings
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public System.DateTime DateIssued { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
