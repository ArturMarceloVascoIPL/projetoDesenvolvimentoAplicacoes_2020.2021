//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Bookids
{
    using System;
    using System.Collections.Generic;
    
    public partial class Participacao
    {
        public int IdEvento { get; set; }
        public int IdEscola { get; set; }
    
        public virtual Evento Eventos { get; set; }
        public virtual Escola Escola { get; set; }
    }
}
