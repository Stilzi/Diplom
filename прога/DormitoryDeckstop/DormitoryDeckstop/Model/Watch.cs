//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DormitoryDeckstop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Watch
    {
        public int Id { get; set; }
        public int JanitorId { get; set; }
        public int ChangeId { get; set; }
        public int FloorId { get; set; }
    
        public virtual Change Change { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual Janitor Janitor { get; set; }
    }
}
