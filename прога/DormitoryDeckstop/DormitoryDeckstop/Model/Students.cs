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
    
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdRoom { get; set; }
        public int IdGroup { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Rooms Rooms { get; set; }
    }
}
