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
    
    public partial class DetalheCompra
    {
        public DetalheCompra()
        {

        }
        public int IdProduto { get; set; }
        public int IdCompra { get; set; }
        public int Quantidade { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Compra Compra { get; set; }
    }
}
