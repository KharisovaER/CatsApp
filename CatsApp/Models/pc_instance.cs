//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CatsApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class pc_instance
    {
        public int id { get; set; }
        public int pcid { get; set; }
        public int accid { get; set; }
    
        public virtual account account { get; set; }
        public virtual personal_card personal_card { get; set; }
    }
}
