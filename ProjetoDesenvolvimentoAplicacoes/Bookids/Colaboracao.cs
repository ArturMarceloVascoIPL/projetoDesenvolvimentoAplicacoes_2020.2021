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
    
    public partial class Colaboracao
    {
        public int IdAnimador { get; set; }
        public int IdEvento { get; set; }
    
        public virtual Animador Animador { get; set; }
        public virtual Evento Evento { get; set; }
    }
}
